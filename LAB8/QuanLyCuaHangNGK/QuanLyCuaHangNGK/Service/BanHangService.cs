using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class BanHangService
    {
        public DataTable LayHoaDon()
        {
            return Db.Query(@"
                SELECT h.MaHD, k.HoTen AS TenKhach, v.HoTen AS NhanVienLap, h.NgayLap, 
                       h.TongTien, h.TienKhachTra, h.TienConLai, h.HinhThucThanhToan, h.TrangThai,
                       h.MaKH, h.MaNVLap
                FROM HoaDon h
                JOIN KhachHang k ON h.MaKH = k.MaKH
                JOIN NhanVien v ON h.MaNVLap = v.MaNV
                ORDER BY h.NgayLap DESC");
        }

        public DataTable LayChiTietHoaDon(string maHD)
        {
            return Db.Query(@"
                SELECT c.MaNGK, n.TenNGK, n.DonViTinh, c.SoLuongMua, c.DonGiaBan, 
                       c.ThanhTien, c.SoLuongGiaoNgay, c.SoLuongHenGiao
                FROM ChiTietHoaDon c
                JOIN NuocGiaiKhat n ON c.MaNGK = n.MaNGK
                WHERE c.MaHD = @hd",
                new SqlParameter("@hd", maHD));
        }

        public KetQuaXuLy LapHoaDon(
            string maHD, string maKH, string maNV, DateTime ngayLap,
            string hinhThucTT, decimal tienKhachTra, List<ChiTietBanItem> items,
            DateTime? ngayHenGiao, DateTime? ngayHenTraNo, string lyDoNo)
        {
            if (string.IsNullOrWhiteSpace(maHD))
                return KetQuaXuLy.Fail("Mã hóa đơn không được để trống.");
            if (items == null || items.Count == 0)
                return KetQuaXuLy.Fail("Hóa đơn phải có ít nhất một mặt hàng.");

            // 1. Kiểm tra thông tin khách hàng
            var dtKhach = Db.Query("SELECT * FROM KhachHang WHERE MaKH = @k", new SqlParameter("@k", maKH));
            if (dtKhach.Rows.Count == 0)
                return KetQuaXuLy.Fail("Không tìm thấy thông tin khách hàng.");

            string loaiKhach = dtKhach.Rows[0]["LoaiKhach"].ToString();
            decimal hanMucNo = Convert.ToDecimal(dtKhach.Rows[0]["HanMucNo"]);
            decimal noHienTai = Convert.ToDecimal(dtKhach.Rows[0]["TongNoHienTai"]);

            // 2. Tính tổng tiền & kiểm tra tồn kho
            decimal tongTien = 0;
            bool coHangHen = false;
            foreach (var it in items)
            {
                tongTien += it.ThanhTien;
                if (it.SoLuongHenGiao > 0)
                    coHangHen = true;
            }

            decimal tienNo = (tongTien > tienKhachTra) ? (tongTien - tienKhachTra) : 0;

            // Quy định nghiệp vụ: Khách vãng lai phải thanh toán và giao ngay tại cửa hàng
            if (loaiKhach == "Vãng lai")
            {
                if (coHangHen)
                    return KetQuaXuLy.Fail("Khách vãng lai chỉ được mua số lượng hiện có đủ trong kho (không hỗ trợ lập phiếu hẹn).");
                if (tienNo > 0)
                    return KetQuaXuLy.Fail("Khách vãng lai phải thanh toán đủ 100% hóa đơn ngay tại cửa hàng.");
            }
            else // Khách quen
            {
                if (tienNo > 0)
                {
                    if (noHienTai + tienNo > hanMucNo)
                        return KetQuaXuLy.Fail(string.Format("Số tiền nợ mới ({0:N0} đ) cộng nợ hiện tại ({1:N0} đ) vượt quá hạn mức nợ cho phép ({2:N0} đ) của khách hàng.", tienNo, noHienTai, hanMucNo));
                }
            }

            // Thực hiện ghi nhận toàn bộ vào CSDL
            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    // A. Lưu Hóa đơn
                    string trangThaiHD = (tienNo == 0) ? "Đã thanh toán" : "Chưa thanh toán đủ";
                    using (var cmd = new SqlCommand(@"
                        INSERT INTO HoaDon(MaHD, MaKH, MaNVLap, NgayLap, TongTien, TienKhachTra, HinhThucThanhToan, TrangThai)
                        VALUES (@hd, @kh, @nv, @ngay, @tong, @tra, @ht, @tt)", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@hd", maHD);
                        cmd.Parameters.AddWithValue("@kh", maKH);
                        cmd.Parameters.AddWithValue("@nv", maNV);
                        cmd.Parameters.AddWithValue("@ngay", ngayLap);
                        cmd.Parameters.AddWithValue("@tong", tongTien);
                        cmd.Parameters.AddWithValue("@tra", tienKhachTra);
                        cmd.Parameters.AddWithValue("@ht", hinhThucTT);
                        cmd.Parameters.AddWithValue("@tt", trangThaiHD);
                        cmd.ExecuteNonQuery();
                    }

                    // B. Lưu Chi tiết Hóa đơn & trừ tồn kho với số lượng giao ngay
                    foreach (var it in items)
                    {
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO ChiTietHoaDon(MaHD, MaNGK, SoLuongMua, DonGiaBan, SoLuongGiaoNgay)
                            VALUES (@hd, @ngk, @mua, @gia, @giao)", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@hd", maHD);
                            cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                            cmd.Parameters.AddWithValue("@mua", it.SoLuongMua);
                            cmd.Parameters.AddWithValue("@gia", it.DonGiaBan);
                            cmd.Parameters.AddWithValue("@giao", it.SoLuongGiaoNgay);
                            cmd.ExecuteNonQuery();
                        }

                        if (it.SoLuongGiaoNgay > 0)
                        {
                            using (var cmd = new SqlCommand(@"
                                UPDATE NuocGiaiKhat 
                                SET SoLuongTon = SoLuongTon - @sl 
                                WHERE MaNGK = @ngk", cn, tr))
                            {
                                cmd.Parameters.AddWithValue("@sl", it.SoLuongGiaoNgay);
                                cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // C. Nếu có hàng hẹn giao cho khách quen -> Tự động sinh Phiếu Hẹn Giao Hàng
                    string thongBaoPhu = "";
                    if (coHangHen && loaiKhach == "Khách quen")
                    {
                        string maPH = "PH" + maHD.Replace("HD", "");
                        DateTime henNgay = ngayHenGiao.HasValue ? ngayHenGiao.Value : ngayLap.AddDays(2);
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO PhieuHenGiaoHang(MaPhieuHen, MaHD, MaNVLap, DotHen, NgayLap, NgayHenGiao, TrangThai)
                            VALUES (@ph, @hd, @nv, 1, @ngay, @hen, N'Chờ giao')", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@ph", maPH);
                            cmd.Parameters.AddWithValue("@hd", maHD);
                            cmd.Parameters.AddWithValue("@nv", maNV);
                            cmd.Parameters.AddWithValue("@ngay", ngayLap);
                            cmd.Parameters.AddWithValue("@hen", henNgay);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (var it in items)
                        {
                            if (it.SoLuongHenGiao > 0)
                            {
                                using (var cmd = new SqlCommand(@"
                                    INSERT INTO ChiTietPhieuHen(MaPhieuHen, MaNGK, SoLuongHen, SoLuongDaGiao, GhiChu)
                                    VALUES (@ph, @ngk, @sl, 0, N'Hẹn giao bổ sung khi kho có hàng')", cn, tr))
                                {
                                    cmd.Parameters.AddWithValue("@ph", maPH);
                                    cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                                    cmd.Parameters.AddWithValue("@sl", it.SoLuongHenGiao);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        thongBaoPhu += string.Format("\n+ Đã tự động tạo Phiếu Hẹn Giao Hàng {0} cho phần hàng thiếu.", maPH);
                    }

                    // D. Nếu khách quen trả chậm còn nợ -> Tự động sinh Phiếu Ghi Nợ
                    if (tienNo > 0 && loaiKhach == "Khách quen")
                    {
                        string maPN = "PGN" + maHD.Replace("HD", "");
                        DateTime hanTra = ngayHenTraNo.HasValue ? ngayHenTraNo.Value : ngayLap.AddDays(15);
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO PhieuGhiNo(MaPhieuNo, MaHD, MaKH, MaNVLap, NgayLap, SoTienNo, SoTienDaTra, NgayDuKienTra, LyDoNo, TrangThai)
                            VALUES (@pn, @hd, @kh, @nv, @ngay, @no, 0, @han, @lydo, N'Đang nợ')", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@pn", maPN);
                            cmd.Parameters.AddWithValue("@hd", maHD);
                            cmd.Parameters.AddWithValue("@kh", maKH);
                            cmd.Parameters.AddWithValue("@nv", maNV);
                            cmd.Parameters.AddWithValue("@ngay", ngayLap);
                            cmd.Parameters.AddWithValue("@no", tienNo);
                            cmd.Parameters.AddWithValue("@han", hanTra);
                            cmd.Parameters.AddWithValue("@lydo", string.IsNullOrWhiteSpace(lyDoNo) ? "Khách quen mua nợ trả chậm" : lyDoNo);
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật tổng nợ hiện tại của khách
                        using (var cmd = new SqlCommand(@"
                            UPDATE KhachHang 
                            SET TongNoHienTai = TongNoHienTai + @no 
                            WHERE MaKH = @kh", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@no", tienNo);
                            cmd.Parameters.AddWithValue("@kh", maKH);
                            cmd.ExecuteNonQuery();
                        }
                        thongBaoPhu += string.Format("\n+ Đã tự động tạo Phiếu Ghi Nợ {0} số tiền {1:N0} đ.", maPN, tienNo);
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok("Lập hóa đơn bán hàng thành công!" + thongBaoPhu);
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return KetQuaXuLy.Fail("Lỗi lập hóa đơn: " + ex.Message);
                }
            }
        }
    }
}
