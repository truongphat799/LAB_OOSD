using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class QuyetToanService
    {
        // Danh sách các đoàn cần quyết toán
        public DataTable LayDoanChoQuyetToan()
        {
            return Db.Query(@"SELECT p.SoPhieuDK, kd.TenCoQuan, kd.NguoiDaiDien, kd.DienThoaiCoQuan,
                                     t.TenTour, p.NgayDiYeuCau, p.SoNguoiDi, 
                                     p.TongKinhPhi, p.TienCoc, p.TienConLai, p.TrangThai
                              FROM PhieuDangKyDoan p
                              JOIN KhachHang k ON p.MaKhachHang = k.MaKhachHang
                              LEFT JOIN KhachDoan kd ON k.MaKhachHang = kd.MaKhachHang
                              JOIN TourDuLich t ON p.MaTour = t.MaTour
                              ORDER BY p.NgayLap DESC");
        }

        // BR05: Hoàn tất quyết toán thu kinh phí còn lại sau chuyến đi
        public KetQuaXuLy QuyetToanDoan(string soPhieuDK)
        {
            try
            {
                DataTable dt = Db.Query("SELECT TongKinhPhi, TienCoc, TienConLai FROM PhieuDangKyDoan WHERE SoPhieuDK = @sp",
                    new SqlParameter("@sp", soPhieuDK));

                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy phiếu đăng ký đoàn.");

                decimal conLai = Convert.ToDecimal(dt.Rows[0]["TienConLai"]);

                int r = Db.Execute("UPDATE PhieuDangKyDoan SET TrangThai = N'Đã quyết toán' WHERE SoPhieuDK = @sp",
                    new SqlParameter("@sp", soPhieuDK));

                return r > 0
                    ? KetQuaXuLy.Ok($"Quyết toán thành công. Đã thu dứt điểm số tiền còn lại: {conLai:N0} đ.")
                    : KetQuaXuLy.Fail("Lỗi khi cập nhật quyết toán.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // BR07: Bảng tính lương hàng tháng của HDV: Lương tháng = Lương căn bản + Tổng thù lao các tour trong tháng
        public DataTable TinhLuongHDV(int thang, int nam)
        {
            return Db.Query(@"SELECT h.MaHDV, h.HoTen, h.SoDienThoai, h.LuongCanBan,
                                     COUNT(pc.MaPhanCong) AS SoTourDan,
                                     ISNULL(SUM(pc.LuongTour), 0) AS TongThuLaoTour,
                                     (h.LuongCanBan + ISNULL(SUM(pc.LuongTour), 0)) AS TongLuongThucLinh,
                                     N'Đã duyệt chi' AS TrangThai
                              FROM HuongDanVien h
                              LEFT JOIN PhanCongHDV pc ON h.MaHDV = pc.MaHDV 
                                   AND MONTH(pc.NgayKetThuc) = @thang AND YEAR(pc.NgayKetThuc) = @nam
                              GROUP BY h.MaHDV, h.HoTen, h.SoDienThoai, h.LuongCanBan
                              ORDER BY TongLuongThucLinh DESC",
                new SqlParameter("@thang", thang),
                new SqlParameter("@nam", nam));
        }
    }
}
