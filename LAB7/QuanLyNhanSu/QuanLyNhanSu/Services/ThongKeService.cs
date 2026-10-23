using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ThongKeService
    {
        public DataTable ThongKeNhanSuTheoPhongBan()
        {
            return Db.Query(@"SELECT pb.MaPhongBan, pb.TenPhongBan, pb.TruongPhong,
                                     COUNT(nv.MaNV) AS SoLuongNhanVien,
                                     SUM(CASE WHEN nv.TrangThai = N'Chính thức' THEN 1 ELSE 0 END) AS SoChinhThuc,
                                     SUM(CASE WHEN nv.TrangThai = N'Thử việc' THEN 1 ELSE 0 END) AS SoThuViec
                              FROM PhongBan pb
                              LEFT JOIN NhanVien nv ON pb.MaPhongBan = nv.MaPhongBan
                              GROUP BY pb.MaPhongBan, pb.TenPhongBan, pb.TruongPhong
                              ORDER BY pb.MaPhongBan");
        }

        public DataTable ThongKeQuyLuongTheoThang()
        {
            return Db.Query(@"SELECT NamLuong, ThangLuong, TongQuyLuong, TrangThai, NgayLap
                              FROM BangLuongThang
                              ORDER BY NamLuong DESC, ThangLuong DESC");
        }

        public DataTable ThongKePhuTroiTheoPhongBan()
        {
            return Db.Query(@"SELECT pb.TenPhongBan, 
                                     COUNT(DISTINCT pt.SoPhieuPhuTroi) AS SoPhieuPhuTroi,
                                     ISNULL(SUM(ct.SoGioPhuTroi), 0) AS TongGioPhuTroi
                              FROM PhongBan pb
                              LEFT JOIN PhieuPhuTroi pt ON pb.MaPhongBan = pt.MaPhongBan
                              LEFT JOIN ChiTietPhuTroi ct ON pt.SoPhieuPhuTroi = ct.SoPhieuPhuTroi
                              GROUP BY pb.TenPhongBan
                              ORDER BY TongGioPhuTroi DESC");
        }
    }
}
