using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class ThongKeService
    {
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"
                SELECT 
                    (SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS SoHoaDon,
                    (SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS TongDoanhThu,
                    (SELECT ISNULL(SUM(SoTienConLai), 0) FROM PhieuGhiNo WHERE TrangThai = N'Đang nợ') AS TongNoChuaThu,
                    (SELECT COUNT(*) FROM PhieuHenGiaoHang WHERE TrangThai = N'Chờ giao' OR TrangThai = N'Đang giao') AS SoPhieuHenChuaGiao,
                    (SELECT COUNT(*) FROM NuocGiaiKhat WHERE SoLuongTon <= DinhMucTonToiThieu) AS SoMatHangSapHetTon",
                new SqlParameter("@tu", tu.Date),
                new SqlParameter("@den", den.Date));
        }

        public DataTable DoanhThuTheoNGK(DateTime tu, DateTime den)
        {
            return Db.Query(@"
                SELECT n.MaNGK, n.TenNGK, h.TenNhanHieu, n.DonViTinh,
                       SUM(c.SoLuongMua) AS TongSoLuongBan,
                       SUM(c.ThanhTien) AS TongDoanhThu
                FROM ChiTietHoaDon c
                JOIN HoaDon d ON c.MaHD = d.MaHD
                JOIN NuocGiaiKhat n ON c.MaNGK = n.MaNGK
                JOIN NhanHieu h ON n.MaNhanHieu = h.MaNhanHieu
                WHERE CAST(d.NgayLap AS date) BETWEEN @tu AND @den
                GROUP BY n.MaNGK, n.TenNGK, h.TenNhanHieu, n.DonViTinh
                ORDER BY TongDoanhThu DESC",
                new SqlParameter("@tu", tu.Date),
                new SqlParameter("@den", den.Date));
        }

        public DataTable CanhBaoTonKho()
        {
            return Db.Query(@"
                SELECT n.MaNGK, n.TenNGK, h.TenNhanHieu, u.TenNCC, n.DonViTinh,
                       n.SoLuongTon, n.DinhMucTonToiThieu,
                       (n.DinhMucTonToiThieu - n.SoLuongTon) AS CanNhapThem
                FROM NuocGiaiKhat n
                JOIN NhanHieu h ON n.MaNhanHieu = h.MaNhanHieu
                JOIN NhaCungUng u ON n.MaNCC = u.MaNCC
                WHERE n.SoLuongTon <= n.DinhMucTonToiThieu
                ORDER BY (n.DinhMucTonToiThieu - n.SoLuongTon) DESC");
        }
    }
}
