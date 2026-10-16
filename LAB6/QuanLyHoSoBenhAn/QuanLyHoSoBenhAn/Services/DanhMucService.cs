using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Services
{
    public class DanhMucService
    {
        public DataTable LayVaiTro() { return Db.Query("SELECT * FROM VaiTro ORDER BY MaVaiTro"); }
        public DataTable LayKhoaDieuTri() { return Db.Query("SELECT * FROM KhoaDieuTri ORDER BY MaKhoa"); }
        public DataTable LayBacSi() { return Db.Query("SELECT * FROM NguoiDung WHERE MaVaiTro='VT_BACSI' AND TrangThai=N'Hoạt động' ORDER BY HoTen"); }
        public DataTable LayNguoiDung() { return Db.Query("SELECT u.*, v.TenVaiTro, k.TenKhoa FROM NguoiDung u JOIN VaiTro v ON u.MaVaiTro=v.MaVaiTro LEFT JOIN KhoaDieuTri k ON u.MaKhoa=k.MaKhoa ORDER BY u.MaNguoiDung"); }
        public DataTable LayDichVuXetNghiem() { return Db.Query("SELECT * FROM DichVuXetNghiem ORDER BY MaDichVuXN"); }
        public DataTable LayThuoc() { return Db.Query("SELECT * FROM Thuoc ORDER BY MaThuoc"); }

        public KetQuaXuLy ThemKhoa(string ma, string ten, string viTri, string truongKhoa, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và tên khoa không được để trống.");
            try
            {
                Db.Execute("INSERT INTO KhoaDieuTri VALUES(@m,@t,@vt,@tk,@sdt)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@vt", viTri), new SqlParameter("@tk", (object)truongKhoa ?? DBNull.Value),
                    new SqlParameter("@sdt", (object)sdt ?? DBNull.Value));
                return KetQuaXuLy.Ok("Đã thêm khoa điều trị.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemDichVuXN(string ma, string ten, string loai, decimal gia, string phong)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || gia < 0)
                return KetQuaXuLy.Fail("Thông tin dịch vụ xét nghiệm không hợp lệ.");
            try
            {
                Db.Execute("INSERT INTO DichVuXetNghiem VALUES(@m,@t,@l,@g,@p)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@l", loai), new SqlParameter("@g", gia),
                    new SqlParameter("@p", (object)phong ?? DBNull.Value));
                return KetQuaXuLy.Ok("Đã thêm dịch vụ xét nghiệm.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemThuoc(string ma, string ten, string hoatChat, string dvt, decimal gia, int tonKho, string chongChiDinh, string phanUngPhu)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || gia < 0 || tonKho < 0)
                return KetQuaXuLy.Fail("Thông tin thuốc không hợp lệ.");
            try
            {
                Db.Execute(@"INSERT INTO Thuoc(MaThuoc,TenThuoc,HoatChat,DonViTinh,DonGia,ChongChiDinh,PhanUngPhu,SoLuongTon)
                             VALUES(@m,@t,@hc,@dvt,@g,@ccd,@pup,@tk)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@hc", hoatChat), new SqlParameter("@dvt", dvt),
                    new SqlParameter("@g", gia),
                    new SqlParameter("@ccd", (object)chongChiDinh ?? DBNull.Value),
                    new SqlParameter("@pup", (object)phanUngPhu ?? DBNull.Value),
                    new SqlParameter("@tk", tonKho));
                return KetQuaXuLy.Ok("Đã thêm thuốc mới thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}
