using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class CongNoService
    {
        public DataTable LayPhieuNo()
        {
            return Db.Query(@"
                SELECT p.MaPhieuNo, p.MaHD, p.MaKH, k.HoTen AS TenKhach, k.SoDienThoai,
                       p.NgayLap, p.SoTienNo, p.SoTienDaTra, p.SoTienConLai, p.NgayDuKienTra,
                       p.LyDoNo, p.TrangThai, v.HoTen AS NhanVienLap, k.HanMucNo, k.TongNoHienTai
                FROM PhieuGhiNo p
                JOIN KhachHang k ON p.MaKH = k.MaKH
                JOIN NhanVien v ON p.MaNVLap = v.MaNV
                ORDER BY p.NgayDuKienTra");
        }

        public DataTable LayChiTietThuNo(string maPN)
        {
            return Db.Query(@"
                SELECT t.MaPhieuThu, t.NgayThu, t.SoTienThu, t.HinhThuc, 
                       v.HoTen AS NhanVienThu, t.GhiChu
                FROM ChiTietThuNo t
                JOIN NhanVien v ON t.MaNVThu = v.MaNV
                WHERE t.MaPhieuNo = @pn
                ORDER BY t.NgayThu DESC",
                new SqlParameter("@pn", maPN));
        }

        public KetQuaXuLy ThuTienNo(string maPTN, string maPN, decimal soTien, string hinhThuc, string maNV, string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maPTN))
                return KetQuaXuLy.Fail("Mã phiếu thu không được để trống.");
            if (soTien <= 0)
                return KetQuaXuLy.Fail("Số tiền thu phải lớn hơn 0.");

            var dtPN = Db.Query("SELECT * FROM PhieuGhiNo WHERE MaPhieuNo = @pn", new SqlParameter("@pn", maPN));
            if (dtPN.Rows.Count == 0)
                return KetQuaXuLy.Fail("Không tìm thấy thông tin phiếu ghi nợ.");

            string maHD = dtPN.Rows[0]["MaHD"].ToString();
            string maKH = dtPN.Rows[0]["MaKH"].ToString();
            decimal conLai = Convert.ToDecimal(dtPN.Rows[0]["SoTienConLai"]);

            if (soTien > conLai)
                return KetQuaXuLy.Fail(string.Format("Số tiền thu ({0:N0} đ) vượt quá số nợ còn lại ({1:N0} đ).", soTien, conLai));

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    // 1. Thêm Phiếu Thu Nợ
                    using (var cmd = new SqlCommand(@"
                        INSERT INTO ChiTietThuNo(MaPhieuThu, MaPhieuNo, NgayThu, SoTienThu, HinhThuc, MaNVThu, GhiChu)
                        VALUES (@ptn, @pn, GETDATE(), @tien, @ht, @nv, @gc)", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@ptn", maPTN);
                        cmd.Parameters.AddWithValue("@pn", maPN);
                        cmd.Parameters.AddWithValue("@tien", soTien);
                        cmd.Parameters.AddWithValue("@ht", hinhThuc ?? "Tiền mặt");
                        cmd.Parameters.AddWithValue("@nv", maNV);
                        cmd.Parameters.AddWithValue("@gc", ghiChu ?? "");
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Cập nhật Phiếu Ghi Nợ
                    using (var cmd = new SqlCommand(@"
                        UPDATE PhieuGhiNo
                        SET SoTienDaTra = SoTienDaTra + @tien,
                            TrangThai = CASE WHEN (SoTienDaTra + @tien) >= SoTienNo THEN N'Đã thanh toán' ELSE N'Đang nợ' END
                        WHERE MaPhieuNo = @pn", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@tien", soTien);
                        cmd.Parameters.AddWithValue("@pn", maPN);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Cập nhật giảm tổng nợ hiện tại của Khách hàng
                    using (var cmd = new SqlCommand(@"
                        UPDATE KhachHang
                        SET TongNoHienTai = CASE WHEN TongNoHienTai >= @tien THEN TongNoHienTai - @tien ELSE 0 END
                        WHERE MaKH = @kh", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@tien", soTien);
                        cmd.Parameters.AddWithValue("@kh", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Cập nhật tăng Tiền khách trả trên Hóa đơn gốc
                    using (var cmd = new SqlCommand(@"
                        UPDATE HoaDon
                        SET TienKhachTra = TienKhachTra + @tien,
                            TrangThai = CASE WHEN (TienKhachTra + @tien) >= TongTien THEN N'Đã thanh toán' ELSE N'Chưa thanh toán đủ' END
                        WHERE MaHD = @hd", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@tien", soTien);
                        cmd.Parameters.AddWithValue("@hd", maHD);
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok(string.Format("Thu nợ thành công số tiền {0:N0} đ cho phiếu nợ {1}.", soTien, maPN));
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return KetQuaXuLy.Fail("Lỗi thu nợ: " + ex.Message);
                }
            }
        }
    }
}
