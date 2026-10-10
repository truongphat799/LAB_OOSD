using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class PhanCongHDVService
    {
        public DataTable LayDanhSachPhanCong()
        {
            return Db.Query(@"SELECT pc.MaPhanCong, pc.MaHDV, h.HoTen AS TenHDV, h.SoDienThoai, 
                                     pc.MaChuyen, pc.SoPhieuDK, pc.NgayPhanCong, pc.NgayBatDau, pc.NgayKetThuc, 
                                     pc.LuongTour, pc.VaiTro, h.LuongCanBan
                              FROM PhanCongHDV pc
                              JOIN HuongDanVien h ON pc.MaHDV = h.MaHDV
                              ORDER BY pc.NgayBatDau DESC");
        }

        public DataTable LayDanhSachHDV()
        {
            return Db.Query("SELECT * FROM HuongDanVien ORDER BY HoTen");
        }

        // BR06: Kiểm tra xung đột lịch làm việc của HDV
        public KetQuaXuLy KiemTraTrungLich(string maHDV, DateTime tuNgay, DateTime denNgay, string boQuaMaPC = null)
        {
            string sql = @"SELECT COUNT(*) FROM PhanCongHDV 
                           WHERE MaHDV = @hdv 
                             AND (NgayBatDau <= @denNgay AND NgayKetThuc >= @tuNgay)";

            if (!string.IsNullOrEmpty(boQuaMaPC))
                sql += " AND MaPhanCong <> @bpc";

            object count = Db.Scalar(sql,
                new SqlParameter("@hdv", maHDV),
                new SqlParameter("@tuNgay", tuNgay.Date),
                new SqlParameter("@denNgay", denNgay.Date),
                new SqlParameter("@bpc", boQuaMaPC ?? ""));

            int trung = Convert.ToInt32(count);
            if (trung > 0)
            {
                return KetQuaXuLy.Fail($"Cảnh báo (BR06): HDV đang bận tour khác trong khoảng thời gian từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}!");
            }

            return KetQuaXuLy.Ok("✅ HDV rảnh lịch, hoàn toàn hợp lệ để phân công.");
        }

        // Thực hiện phân công HDV
        public KetQuaXuLy PhanCongHDV(
            string maPC, string maHDV, string maChuyen, string soPhieuDK,
            DateTime tuNgay, DateTime denNgay, decimal luongTour, string vaiTro)
        {
            if (string.IsNullOrWhiteSpace(maPC) || string.IsNullOrWhiteSpace(maHDV))
                return KetQuaXuLy.Fail("Thông tin mã phân công và hướng dẫn viên không được để trống.");

            if (string.IsNullOrWhiteSpace(maChuyen) && string.IsNullOrWhiteSpace(soPhieuDK))
                return KetQuaXuLy.Fail("Phải chọn chuyến lẻ hoặc đoàn để phân công.");

            if (denNgay < tuNgay)
                return KetQuaXuLy.Fail("Ngày kết thúc tour không được nhỏ hơn ngày bắt đầu.");

            // BR06: Kiểm tra xung đột lịch
            var check = KiemTraTrungLich(maHDV, tuNgay, denNgay);
            if (!check.ThanhCong)
                return check;

            try
            {
                Db.Execute(@"INSERT INTO PhanCongHDV(MaPhanCong, MaHDV, MaChuyen, SoPhieuDK, NgayPhanCong, NgayBatDau, NgayKetThuc, LuongTour, VaiTro)
                             VALUES(@mpc, @hdv, @mc, @sp, GETDATE(), @bd, @kt, @lt, @vt)",
                    new SqlParameter("@mpc", maPC.Trim()),
                    new SqlParameter("@hdv", maHDV.Trim()),
                    new SqlParameter("@mc", string.IsNullOrEmpty(maChuyen) ? (object)DBNull.Value : maChuyen.Trim()),
                    new SqlParameter("@sp", string.IsNullOrEmpty(soPhieuDK) ? (object)DBNull.Value : soPhieuDK.Trim()),
                    new SqlParameter("@bd", tuNgay.Date),
                    new SqlParameter("@kt", denNgay.Date),
                    new SqlParameter("@lt", luongTour),
                    new SqlParameter("@vt", vaiTro ?? "Hướng dẫn viên chính"));

                return KetQuaXuLy.Ok("Phân công hướng dẫn viên thành công (Đã kiểm tra chống trùng lịch).");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi phân công: " + ex.Message);
            }
        }
    }
}
