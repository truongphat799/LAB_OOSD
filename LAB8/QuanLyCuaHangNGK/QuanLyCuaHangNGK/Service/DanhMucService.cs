using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class DanhMucService
    {
        // ---------------- NHÀ CUNG ỨNG ----------------
        public DataTable LayNhaCungUng()
        {
            return Db.Query("SELECT * FROM NhaCungUng ORDER BY MaNCC");
        }

        public KetQuaXuLy ThemNhaCungUng(string ma, string ten, string diaChi, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và tên nhà cung ứng không được để trống.");

            try
            {
                Db.Execute("INSERT INTO NhaCungUng(MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES (@ma, @ten, @dc, @sdt)",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@dc", diaChi ?? ""),
                    new SqlParameter("@sdt", sdt ?? ""));
                return KetQuaXuLy.Ok("Thêm nhà cung ứng thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy SuaNhaCungUng(string ma, string ten, string diaChi, string sdt)
        {
            try
            {
                int r = Db.Execute("UPDATE NhaCungUng SET TenNCC = @ten, DiaChi = @dc, SoDienThoai = @sdt WHERE MaNCC = @ma",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@dc", diaChi ?? ""),
                    new SqlParameter("@sdt", sdt ?? ""));
                return r > 0 ? KetQuaXuLy.Ok("Cập nhật nhà cung ứng thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NCC.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaNhaCungUng(string ma)
        {
            try
            {
                int r = Db.Execute("DELETE FROM NhaCungUng WHERE MaNCC = @ma", new SqlParameter("@ma", ma));
                return r > 0 ? KetQuaXuLy.Ok("Xóa nhà cung ứng thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NCC.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa NCC (đang được liên kết dữ liệu): " + ex.Message);
            }
        }

        // ---------------- NHÃN HIỆU ----------------
        public DataTable LayNhanHieu()
        {
            return Db.Query("SELECT * FROM NhanHieu ORDER BY MaNhanHieu");
        }

        public KetQuaXuLy ThemNhanHieu(string ma, string ten, string xuatXu)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và tên nhãn hiệu không được để trống.");

            try
            {
                Db.Execute("INSERT INTO NhanHieu(MaNhanHieu, TenNhanHieu, XuatXu) VALUES (@ma, @ten, @xx)",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@xx", xuatXu ?? ""));
                return KetQuaXuLy.Ok("Thêm nhãn hiệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy SuaNhanHieu(string ma, string ten, string xuatXu)
        {
            try
            {
                int r = Db.Execute("UPDATE NhanHieu SET TenNhanHieu = @ten, XuatXu = @xx WHERE MaNhanHieu = @ma",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@xx", xuatXu ?? ""));
                return r > 0 ? KetQuaXuLy.Ok("Cập nhật nhãn hiệu thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã nhãn hiệu.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaNhanHieu(string ma)
        {
            try
            {
                int r = Db.Execute("DELETE FROM NhanHieu WHERE MaNhanHieu = @ma", new SqlParameter("@ma", ma));
                return r > 0 ? KetQuaXuLy.Ok("Xóa nhãn hiệu thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã nhãn hiệu.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa nhãn hiệu: " + ex.Message);
            }
        }

        // ---------------- NHÂN VIÊN ----------------
        public DataTable LayNhanVien()
        {
            return Db.Query("SELECT * FROM NhanVien ORDER BY MaNV");
        }

        public KetQuaXuLy ThemNhanVien(string ma, string ten, string vaiTro, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và họ tên nhân viên không được để trống.");

            try
            {
                Db.Execute("INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES (@ma, @ten, @vt, @sdt)",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@vt", vaiTro ?? "Bán hàng"),
                    new SqlParameter("@sdt", sdt ?? ""));
                return KetQuaXuLy.Ok("Thêm nhân viên thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy SuaNhanVien(string ma, string ten, string vaiTro, string sdt)
        {
            try
            {
                int r = Db.Execute("UPDATE NhanVien SET HoTen = @ten, VaiTro = @vt, SoDienThoai = @sdt WHERE MaNV = @ma",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@vt", vaiTro ?? "Bán hàng"),
                    new SqlParameter("@sdt", sdt ?? ""));
                return r > 0 ? KetQuaXuLy.Ok("Cập nhật nhân viên thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NV.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaNhanVien(string ma)
        {
            try
            {
                int r = Db.Execute("DELETE FROM NhanVien WHERE MaNV = @ma", new SqlParameter("@ma", ma));
                return r > 0 ? KetQuaXuLy.Ok("Xóa nhân viên thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NV.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa nhân viên: " + ex.Message);
            }
        }
    }
}
