using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangEShopping.Data;
using QuanLyCuaHangEShopping.Models;

namespace QuanLyCuaHangEShopping.Services
{
    public class DanhMucService
    {
        public DataTable LayNhomSanPham() { return Db.Query("SELECT * FROM NhomSanPham ORDER BY MaNhom"); }
        public DataTable LayKhuVuc() { return Db.Query("SELECT * FROM KhuVucGiaoHang ORDER BY MaKhuVuc"); }
        public DataTable LayLoaiPhieu() { return Db.Query("SELECT * FROM LoaiPhieuDatHang ORDER BY MaLoaiPhieu"); }
        public DataTable LayLoaiThe() { return Db.Query("SELECT * FROM LoaiTheTinDung ORDER BY MaLoaiThe"); }
        public DataTable LayChinhSach() { return Db.Query("SELECT c.*, l.TenLoaiPhieu FROM ChinhSachMienPhi c JOIN LoaiPhieuDatHang l ON c.MaLoaiPhieu=l.MaLoaiPhieu ORDER BY c.MaChinhSach"); }

        public KetQuaXuLy ThemNhomSP(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và tên nhóm không được để trống.");
            try
            {
                Db.Execute("INSERT INTO NhomSanPham VALUES(@m,@t)", new SqlParameter("@m", ma), new SqlParameter("@t", ten));
                return KetQuaXuLy.Ok("Đã thêm nhóm sản phẩm.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemKhuVuc(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Thông tin khu vực chưa đầy đủ.");
            try
            {
                Db.Execute("INSERT INTO KhuVucGiaoHang VALUES(@m,@t)", new SqlParameter("@m", ma), new SqlParameter("@t", ten));
                return KetQuaXuLy.Ok("Đã thêm khu vực giao hàng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemLoaiPhieu(string ma, string ten, decimal gia, string tg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || gia < 0)
                return KetQuaXuLy.Fail("Thông tin loại phiếu không hợp lệ.");
            try
            {
                Db.Execute("INSERT INTO LoaiPhieuDatHang VALUES(@m,@t,@g,@tg)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten), new SqlParameter("@g", gia), new SqlParameter("@tg", tg));
                return KetQuaXuLy.Ok("Đã thêm loại phiếu đặt hàng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemChinhSach(string ma, string maLoai, decimal giaTri, string hinhThuc)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(maLoai) || giaTri < 0)
                return KetQuaXuLy.Fail("Thông tin chính sách miễn phí không hợp lệ.");
            try
            {
                Db.Execute("INSERT INTO ChinhSachMienPhi VALUES(@m,@l,@g,@h)",
                    new SqlParameter("@m", ma), new SqlParameter("@l", maLoai), new SqlParameter("@g", giaTri), new SqlParameter("@h", hinhThuc));
                return KetQuaXuLy.Ok("Đã thêm chính sách miễn phí cước.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}