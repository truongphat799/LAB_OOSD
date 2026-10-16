using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class ThongKeService
    {
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT 
                (SELECT COUNT(*) FROM PhieuKhamBenh WHERE CAST(NgayGioKham AS date) BETWEEN @tu AND @den) AS TongLuotKham,
                (SELECT COUNT(*) FROM PhieuKhamBenh WHERE TrangThai=N'Đã xuất viện' AND CAST(NgayGioKham AS date) BETWEEN @tu AND @den) AS LuotXuatVien,
                (SELECT ISNULL(SUM(TongThanhToan),0) FROM HoaDonVienPhi WHERE CAST(NgayThanhToan AS date) BETWEEN @tu AND @den) AS DoanhThuVienPhi,
                (SELECT ISNULL(SUM(SoTien),0) FROM LePhiNam WHERE CAST(NgayDong AS date) BETWEEN @tu AND @den) AS DoanhThuLePhiNam",
                new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        public DataTable ThuocKeNhieuNhat(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT th.MaThuoc, th.TenThuoc, th.HoatChat, SUM(ct.SoLuong) AS TongSoLuongKe, SUM(ct.ThanhTien) AS TongTienThuoc
                              FROM ToaThuoc t
                              JOIN ChiTietToaThuoc ct ON t.MaToaThuoc=ct.MaToaThuoc
                              JOIN Thuoc th ON ct.MaThuoc=th.MaThuoc
                              WHERE CAST(t.NgayKeToa AS date) BETWEEN @tu AND @den
                              GROUP BY th.MaThuoc, th.TenThuoc, th.HoatChat
                              ORDER BY TongSoLuongKe DESC",
                new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        public DataTable ThongKeTheoKhoa(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT k.MaKhoa, k.TenKhoa, COUNT(p.MaPhieuKham) AS SoCaKham,
                                     ISNULL(SUM(hd.TongThanhToan),0) AS TongTienVienPhi
                              FROM KhoaDieuTri k
                              LEFT JOIN PhieuKhamBenh p ON k.MaKhoa=p.MaKhoa AND CAST(p.NgayGioKham AS date) BETWEEN @tu AND @den
                              LEFT JOIN HoaDonVienPhi hd ON p.MaPhieuKham=hd.MaPhieuKham
                              GROUP BY k.MaKhoa, k.TenKhoa
                              ORDER BY SoCaKham DESC",
                new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }
    }
}
