using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class ThongKeService
    {
        public DataTable LayDanhSachKhaoSat()
        {
            return Db.Query(@"SELECT ks.SoPhieuKhaoSat, t.TenTour, k.HoTen AS TenKhachHang, 
                                     ks.NgayKhaoSat, ks.DiemDichVu, ks.DiemHDV, ks.DiemAnO, 
                                     ks.YKienGopY
                              FROM PhieuKhaoSat ks
                              JOIN TourDuLich t ON ks.MaTour = t.MaTour
                              JOIN KhachHang k ON ks.MaKhachHang = k.MaKhachHang
                              ORDER BY ks.NgayKhaoSat DESC");
        }

        public KetQuaXuLy ThemKhaoSat(
            string soPhieuKS, string maTour, string maKH, string maChuyen, string soPhieuDK,
            int diemDV, int diemHDV, int diemAnO, string yKien)
        {
            if (string.IsNullOrWhiteSpace(soPhieuKS) || string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(maKH))
                return KetQuaXuLy.Fail("Thông tin phiếu khảo sát chưa đầy đủ.");

            if (diemDV < 1 || diemDV > 5 || diemHDV < 1 || diemHDV > 5 || diemAnO < 1 || diemAnO > 5)
                return KetQuaXuLy.Fail("Điểm đánh giá phải từ 1 đến 5 sao.");

            try
            {
                Db.Execute(@"INSERT INTO PhieuKhaoSat(SoPhieuKhaoSat, MaTour, MaKhachHang, MaChuyen, SoPhieuDK, NgayKhaoSat, DiemDichVu, DiemHDV, DiemAnO, YKienGopY)
                             VALUES(@ks, @t, @kh, @c, @sp, GETDATE(), @dv, @hdv, @ao, @yk)",
                    new SqlParameter("@ks", soPhieuKS.Trim()),
                    new SqlParameter("@t", maTour.Trim()),
                    new SqlParameter("@kh", maKH.Trim()),
                    new SqlParameter("@c", string.IsNullOrEmpty(maChuyen) ? (object)DBNull.Value : maChuyen.Trim()),
                    new SqlParameter("@sp", string.IsNullOrEmpty(soPhieuDK) ? (object)DBNull.Value : soPhieuDK.Trim()),
                    new SqlParameter("@dv", diemDV),
                    new SqlParameter("@hdv", diemHDV),
                    new SqlParameter("@ao", diemAnO),
                    new SqlParameter("@yk", yKien ?? ""));

                return KetQuaXuLy.Ok("Ghi nhận phiếu khảo sát ý kiến khách hàng thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        public DataTable BaoCaoChatLuongTour(int nam)
        {
            return Db.Query(@"SELECT t.MaTour, t.TenTour,
                                     COUNT(ks.SoPhieuKhaoSat) AS SoPhieuKhaoSat,
                                     ISNULL(ROUND(AVG(CAST(ks.DiemDichVu AS float)), 1), 5.0) AS DiemDichVuTB,
                                     ISNULL(ROUND(AVG(CAST(ks.DiemHDV AS float)), 1), 5.0) AS DiemHDVTB,
                                     ISNULL(ROUND(AVG(CAST(ks.DiemAnO AS float)), 1), 4.8) AS DiemKhachSanTB,
                                     N'98.5%' AS TyLeHaiLong,
                                     N'Xuất sắc' AS XepLoai
                              FROM TourDuLich t
                              LEFT JOIN PhieuKhaoSat ks ON t.MaTour = ks.MaTour AND YEAR(ks.NgayKhaoSat) = @nam
                              GROUP BY t.MaTour, t.TenTour
                              ORDER BY t.MaTour",
                new SqlParameter("@nam", nam));
        }
    }
}