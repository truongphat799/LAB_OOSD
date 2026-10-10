using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class ChuyenService
    {
        public DataTable LayDanhSachChuyen()
        {
            return Db.Query(@"SELECT c.MaChuyen, c.MaTour, t.TenTour, c.NgayDi, c.NgayVe, 
                                     c.SoChoToiDa, c.SoChoDaDat, 
                                     (c.SoChoToiDa - c.SoChoDaDat) AS SoChoTrong, 
                                     c.TrangThai, t.DonGiaKhach
                              FROM ChuyenDuLich c
                              JOIN TourDuLich t ON c.MaTour = t.MaTour
                              ORDER BY c.NgayDi DESC");
        }

        public DataTable LayDanhSachTour()
        {
            return Db.Query("SELECT MaTour, TenTour, DonGiaKhach FROM TourDuLich ORDER BY TenTour");
        }

        public DataTable LayDiemDon()
        {
            return Db.Query("SELECT * FROM DiemDon ORDER BY GioDonQuyDinh");
        }

        public DataTable LayDiemBanVe()
        {
            return Db.Query("SELECT * FROM DiemBanVe ORDER BY TenDiemBanVe");
        }

        public KetQuaXuLy ThemChuyen(string maChuyen, string maTour, DateTime ngayDi, DateTime ngayVe, int soCho = 45)
        {
            if (string.IsNullOrWhiteSpace(maChuyen) || string.IsNullOrWhiteSpace(maTour))
                return KetQuaXuLy.Fail("Mã chuyến và mã tour không được để trống.");

            if (ngayVe < ngayDi)
                return KetQuaXuLy.Fail("Ngày về không được trước ngày khởi hành.");

            if (soCho <= 0)
                return KetQuaXuLy.Fail("Số chỗ tối đa phải lớn hơn 0.");

            try
            {
                Db.Execute(@"INSERT INTO ChuyenDuLich(MaChuyen, MaTour, NgayDi, NgayVe, SoChoToiDa, SoChoDaDat, TrangThai)
                             VALUES(@mc, @mt, @ndi, @nve, @sc, 0, N'Còn chỗ')",
                    new SqlParameter("@mc", maChuyen.Trim()),
                    new SqlParameter("@mt", maTour.Trim()),
                    new SqlParameter("@ndi", ngayDi.Date),
                    new SqlParameter("@nve", ngayVe.Date),
                    new SqlParameter("@sc", soCho));

                // Tự động gán các điểm đón mặc định vào chuyến
                Db.Execute(@"INSERT INTO Chuyen_DiemDon(MaChuyen, MaDiemDon)
                             SELECT @mc, MaDiemDon FROM DiemDon",
                    new SqlParameter("@mc", maChuyen.Trim()));

                return KetQuaXuLy.Ok("Mở chuyến du lịch mới thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi mở chuyến: " + ex.Message);
            }
        }

        public KetQuaXuLy DongChuyen(string maChuyen)
        {
            try
            {
                int r = Db.Execute("UPDATE ChuyenDuLich SET TrangThai=N'Hết chỗ' WHERE MaChuyen=@mc",
                    new SqlParameter("@mc", maChuyen));
                return r > 0 ? KetQuaXuLy.Ok("Đã đóng nhận khách cho chuyến đi.") : KetQuaXuLy.Fail("Không tìm thấy chuyến.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }
    }
}
