using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Services
{
    public class DanhMucService
    {
        public DataTable LayDanhSachPhongBan()
        {
            return Db.Query("SELECT * FROM PhongBan ORDER BY MaPhongBan");
        }

        public DataTable LayDanhSachChucVu()
        {
            return Db.Query("SELECT * FROM ChucVu ORDER BY MaChucVu");
        }

        public DataTable LayDanhSachNhanVien()
        {
            return Db.Query(@"SELECT nv.*, pb.TenPhongBan, qd.LuongCoBan, qd.PhuCapDocHai, qdc.PhuCapChucVu, hd.LoaiHopDong
                              FROM NhanVien nv
                              LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN QuyetDinhLuong qd ON nv.MaNV = qd.MaNV AND qd.TrangThai = N'Hiện hành'
                              LEFT JOIN QuyetDinhChucVu qdc ON nv.MaNV = qdc.MaNV AND qdc.TrangThai = N'Hiện hành'
                              LEFT JOIN HopDongLaoDong hd ON nv.MaNV = hd.MaNV AND hd.TrangThai = N'Còn hiệu lực'
                              ORDER BY nv.MaNV");
        }

        public DataTable LayDanhSachNguoiDung()
        {
            return Db.Query(@"SELECT nd.MaNguoiDung, nd.TenDangNhap, nd.HoTen, nd.VaiTro, nd.TrangThai, pb.TenPhongBan
                              FROM NguoiDung nd
                              LEFT JOIN NhanVien nv ON nd.MaNV = nv.MaNV
                              LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              ORDER BY nd.MaNguoiDung");
        }

        public KetQuaXuLy DangNhap(string username, string password)
        {
            DataTable dt = Db.Query(@"SELECT nd.*, nv.MaPhongBan 
                                      FROM NguoiDung nd 
                                      LEFT JOIN NhanVien nv ON nd.MaNV = nv.MaNV
                                      WHERE nd.TenDangNhap = @u AND nd.MatKhau = @p AND nd.TrangThai = N'Hoạt động'",
                new SqlParameter("@u", username),
                new SqlParameter("@p", password));

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                NguoiDungHienTai.MaNguoiDung = r["MaNguoiDung"].ToString();
                NguoiDungHienTai.TenDangNhap = r["TenDangNhap"].ToString();
                NguoiDungHienTai.HoTen = r["HoTen"].ToString();
                NguoiDungHienTai.VaiTro = r["VaiTro"].ToString();
                NguoiDungHienTai.MaPhongBan = r["MaPhongBan"] != DBNull.Value ? r["MaPhongBan"].ToString() : "";
                return KetQuaXuLy.Ok("Đăng nhập thành công với vai trò " + NguoiDungHienTai.VaiTro, r);
            }
            return KetQuaXuLy.Fail("Tên đăng nhập hoặc mật khẩu không đúng.");
        }
    }
}
