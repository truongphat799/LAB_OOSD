using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangEShopping.Data;

namespace QuanLyCuaHangEShopping.Services
{
    public class ThongKeService
    {
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT 
                (SELECT COUNT(*) FROM DonDatHang WHERE CAST(NgayDat AS date) BETWEEN @tu AND @den) AS TongSoDon,
                (SELECT COUNT(*) FROM DonDatHang WHERE TrangThai=N'Đã xác nhận' AND CAST(NgayDat AS date) BETWEEN @tu AND @den) AS DonDaXacNhan,
                (SELECT ISNULL(SUM(TongTriGia),0) FROM DonDatHang WHERE TrangThai!=N'Đã hủy' AND CAST(NgayDat AS date) BETWEEN @tu AND @den) AS DoanhThu,
                (SELECT ISNULL(SUM(ChiPhiGiaoHang),0) FROM DonDatHang WHERE CAST(NgayDat AS date) BETWEEN @tu AND @den) AS TongTienShip",
                new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        public DataTable SanPhamBanChay(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT s.MaSP, s.TenSP, SUM(c.SoLuong) AS TongSoLuongBan, SUM(c.ThanhTien) AS TongDoanhThu
                              FROM DonDatHang d
                              JOIN ChiTietDonHang c ON d.MaDonHang=c.MaDonHang
                              JOIN SanPham s ON c.MaSP=s.MaSP
                              WHERE d.TrangThai!=N'Đã hủy' AND CAST(d.NgayDat AS date) BETWEEN @tu AND @den
                              GROUP BY s.MaSP, s.TenSP
                              ORDER BY TongSoLuongBan DESC",
                new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }
    }
}