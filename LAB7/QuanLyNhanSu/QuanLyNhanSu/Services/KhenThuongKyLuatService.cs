using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Services
{
    public class KhenThuongKyLuatService
    {
        public DataTable LayDanhSachQDKhenThuong()
        {
            return Db.Query(@"SELECT kt.*, nv.HoTen, pb.TenPhongBan, pc.SoPhieuChi, pc.NgayChi, pc.NguoiNhanTien
                              FROM QuyetDinhKhenThuong kt
                              LEFT JOIN NhanVien nv ON kt.MaNV = nv.MaNV
                              LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN PhieuChiThuong pc ON kt.SoQDKhenThuong = pc.SoQDKhenThuong
                              ORDER BY kt.NgayBanHanh DESC");
        }

        public DataTable LayDanhSachQDKyLuat()
        {
            return Db.Query(@"SELECT kl.*, nv.HoTen, pb.TenPhongBan, pt.SoPhieuThu, pt.NgayThu, pt.NguoiNopTien
                              FROM QuyetDinhKyLuat kl
                              LEFT JOIN NhanVien nv ON kl.MaNV = nv.MaNV
                              LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN PhieuThuPhat pt ON kl.SoQDKyLuat = pt.SoQDKyLuat
                              ORDER BY kl.NgayBanHanh DESC");
        }

        // BAN HÀNH QUYẾT ĐỊNH KHEN THƯỞNG (DO GIÁM ĐỐC KÝ)
        public KetQuaXuLy BanHanhQDKhenThuong(
            string soQD, DateTime ngayBanHanh, string loaiKT, string maNV, string maPB,
            string lyDo, decimal soTien, string hinhThucChi)
        {
            if (string.IsNullOrWhiteSpace(soQD) || soTien <= 0)
                return KetQuaXuLy.Fail("Số quyết định và số tiền khen thưởng không hợp lệ.");

            try
            {
                Db.Execute(@"INSERT INTO QuyetDinhKhenThuong(SoQDKhenThuong, MaNV, NgayBanHanh, LoaiKhenThuong, LyDoKhenThuong, SoTienKhenThuong, HinhThucChiTra, TrangThai)
                             VALUES(@so, @mnv, @ngay, @loai, @ld, @tien, @ht, N'Đã ban hành')",
                             new SqlParameter("@so", soQD),
                             new SqlParameter("@mnv", string.IsNullOrEmpty(maNV) ? (object)DBNull.Value : maNV),
                             new SqlParameter("@ngay", ngayBanHanh.Date),
                             new SqlParameter("@loai", loaiKT),
                             new SqlParameter("@ld", lyDo),
                             new SqlParameter("@tien", soTien),
                             new SqlParameter("@ht", hinhThucChi));
                return KetQuaXuLy.Ok("Ban hành Quyết định khen thưởng thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi ban hành khen thưởng: " + ex.Message);
            }
        }

        // XUẤT PHIẾU CHI TIỀN KHEN THƯỞNG (KHI CHI TIỀN MẶT TRỰC TIẾP)
        public KetQuaXuLy LapPhieuChiThuong(string soPhieuChi, string soQD, decimal soTien, string nguoiNhan, string lyDoChi)
        {
            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    var cmdChi = new SqlCommand(@"INSERT INTO PhieuChiThuong(SoPhieuChi, SoQDKhenThuong, NgayChi, SoTienChi, NguoiNhanTien, LyDoChi)
                                                  VALUES(@spc, @sqd, @ngay, @tien, @nn, @ld)", cn, tx);
                    cmdChi.Parameters.AddWithValue("@spc", soPhieuChi);
                    cmdChi.Parameters.AddWithValue("@sqd", soQD);
                    cmdChi.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
                    cmdChi.Parameters.AddWithValue("@tien", soTien);
                    cmdChi.Parameters.AddWithValue("@nn", nguoiNhan);
                    cmdChi.Parameters.AddWithValue("@ld", lyDoChi ?? "Chi tiền thưởng trực tiếp");
                    cmdChi.ExecuteNonQuery();

                    var cmdUp = new SqlCommand("UPDATE QuyetDinhKhenThuong SET TrangThai = N'Đã thanh toán' WHERE SoQDKhenThuong = @sqd", cn, tx);
                    cmdUp.Parameters.AddWithValue("@sqd", soQD);
                    cmdUp.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Lập Phiếu chi khen thưởng thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail("Lỗi lập phiếu chi: " + ex.Message);
                }
            }
        }

        // BAN HÀNH QUYẾT ĐỊNH KỶ LUẬT (DO GIÁM ĐỐC KÝ)
        public KetQuaXuLy BanHanhQDKyLuat(
            string soQD, DateTime ngayBanHanh, string loaiKL, string maNV, string maPB,
            string lyDo, decimal soTien, string hinhThucNop)
        {
            if (string.IsNullOrWhiteSpace(soQD) || soTien <= 0)
                return KetQuaXuLy.Fail("Số quyết định và số tiền phạt không hợp lệ.");

            try
            {
                Db.Execute(@"INSERT INTO QuyetDinhKyLuat(SoQDKyLuat, MaNV, NgayBanHanh, LoaiKyLuat, LyDoKyLuat, SoTienNopPhat, HinhThucNopPhat, TrangThai)
                             VALUES(@so, @mnv, @ngay, @loai, @ld, @tien, @ht, N'Đã ban hành')",
                             new SqlParameter("@so", soQD),
                             new SqlParameter("@mnv", string.IsNullOrEmpty(maNV) ? (object)DBNull.Value : maNV),
                             new SqlParameter("@ngay", ngayBanHanh.Date),
                             new SqlParameter("@loai", loaiKL),
                             new SqlParameter("@ld", lyDo),
                             new SqlParameter("@tien", soTien),
                             new SqlParameter("@ht", hinhThucNop));
                return KetQuaXuLy.Ok("Ban hành Quyết định xử lý kỷ luật thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi ban hành kỷ luật: " + ex.Message);
            }
        }
    }
}
