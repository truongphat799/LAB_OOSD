using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class TourService
    {
        public DataTable LayDanhSachTour()
        {
            return Db.Query("SELECT * FROM TourDuLich ORDER BY MaTour");
        }

        public DataTable LayNoiDungChan(string maTour)
        {
            return Db.Query("SELECT * FROM NoiDungChan WHERE MaTour=@t ORDER BY ThuTuDung",
                new SqlParameter("@t", maTour));
        }

        public DataTable LayDiemThamQuan(string maTour)
        {
            return Db.Query(@"SELECT d.*, td.GhiChu 
                             FROM DiemThamQuan d 
                             JOIN Tour_DiemThamQuan td ON d.MaDiemThamQuan = td.MaDiemThamQuan 
                             WHERE td.MaTour = @t",
                new SqlParameter("@t", maTour));
        }

        public KetQuaXuLy ThemTour(string maTour, string tenTour, int soNgay, int soDem, decimal donGia)
        {
            if (string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(tenTour))
                return KetQuaXuLy.Fail("Mã tour và tên tour không được để trống.");

            if (soNgay <= 0 || soDem < 0)
                return KetQuaXuLy.Fail("Số ngày phải lớn hơn 0 và số đêm không được âm.");

            if (donGia < 0)
                return KetQuaXuLy.Fail("Đơn giá tour không được âm.");

            try
            {
                Db.Execute(@"INSERT INTO TourDuLich(MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, NoiKhoiHanh, NoiKetThuc)
                             VALUES(@m, @t, @ng, @d, @g, N'TP.HCM', N'TP.HCM')",
                    new SqlParameter("@m", maTour.Trim()),
                    new SqlParameter("@t", tenTour.Trim()),
                    new SqlParameter("@ng", soNgay),
                    new SqlParameter("@d", soDem),
                    new SqlParameter("@g", donGia));

                return KetQuaXuLy.Ok("Thêm Tour du lịch thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi thêm Tour: " + ex.Message);
            }
        }

        public KetQuaXuLy CapNhatTour(string maTour, string tenTour, int soNgay, int soDem, decimal donGia)
        {
            if (string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(tenTour))
                return KetQuaXuLy.Fail("Mã tour và tên tour không được để trống.");

            try
            {
                int r = Db.Execute(@"UPDATE TourDuLich 
                                     SET TenTour=@t, SoNgay=@ng, SoDem=@d, DonGiaKhach=@g 
                                     WHERE MaTour=@m",
                    new SqlParameter("@m", maTour.Trim()),
                    new SqlParameter("@t", tenTour.Trim()),
                    new SqlParameter("@ng", soNgay),
                    new SqlParameter("@d", soDem),
                    new SqlParameter("@g", donGia));

                return r > 0 ? KetQuaXuLy.Ok("Cập nhật Tour thành công.") : KetQuaXuLy.Fail("Không tìm thấy tour cần cập nhật.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaTour(string maTour)
        {
            try
            {
                int r = Db.Execute("DELETE FROM TourDuLich WHERE MaTour=@m", new SqlParameter("@m", maTour));
                return r > 0 ? KetQuaXuLy.Ok("Đã xóa Tour du lịch.") : KetQuaXuLy.Fail("Không tìm thấy tour để xóa.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa tour (đang có chuyến đi hoặc dữ liệu ràng buộc): " + ex.Message);
            }
        }
    }
}
