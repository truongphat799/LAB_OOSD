using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class NuocGiaiKhatService
    {
        public DataTable LayNuocGiaiKhat()
        {
            return Db.Query(@"
                SELECT n.MaNGK, n.TenNGK, h.TenNhanHieu, u.TenNCC, n.DonViTinh, 
                       n.SoLuongTon, n.DonGiaBan, n.DinhMucTonToiThieu,
                       CASE WHEN n.SoLuongTon <= n.DinhMucTonToiThieu THEN N'Sắp hết hàng' ELSE N'Đủ hàng' END AS TrangThaiTon,
                       n.MaNhanHieu, n.MaNCC
                FROM NuocGiaiKhat n
                JOIN NhanHieu h ON n.MaNhanHieu = h.MaNhanHieu
                JOIN NhaCungUng u ON n.MaNCC = u.MaNCC
                ORDER BY n.MaNGK");
        }

        public DataTable LayCanhBaoTonKho()
        {
            return Db.Query(@"
                SELECT n.MaNGK, n.TenNGK, h.TenNhanHieu, u.TenNCC, n.DonViTinh, 
                       n.SoLuongTon, n.DinhMucTonToiThieu,
                       (n.DinhMucTonToiThieu - n.SoLuongTon) AS SoLuongCanNhapThem
                FROM NuocGiaiKhat n
                JOIN NhanHieu h ON n.MaNhanHieu = h.MaNhanHieu
                JOIN NhaCungUng u ON n.MaNCC = u.MaNCC
                WHERE n.SoLuongTon <= n.DinhMucTonToiThieu
                ORDER BY (n.DinhMucTonToiThieu - n.SoLuongTon) DESC");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT n.MaNGK, n.TenNGK, h.TenNhanHieu, u.TenNCC, n.DonViTinh, 
                       n.SoLuongTon, n.DonGiaBan, n.DinhMucTonToiThieu,
                       CASE WHEN n.SoLuongTon <= n.DinhMucTonToiThieu THEN N'Sắp hết hàng' ELSE N'Đủ hàng' END AS TrangThaiTon,
                       n.MaNhanHieu, n.MaNCC
                FROM NuocGiaiKhat n
                JOIN NhanHieu h ON n.MaNhanHieu = h.MaNhanHieu
                JOIN NhaCungUng u ON n.MaNCC = u.MaNCC
                WHERE n.MaNGK LIKE @kw OR n.TenNGK LIKE @kw OR h.TenNhanHieu LIKE @kw
                ORDER BY n.MaNGK",
                new SqlParameter("@kw", "%" + (tuKhoa ?? "") + "%"));
        }

        public KetQuaXuLy Them(string ma, string ten, string maNH, string maNCC, string dvt, int ton, decimal gia, int minTon)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và tên nước giải khát không được để trống.");

            try
            {
                Db.Execute(@"
                    INSERT INTO NuocGiaiKhat(MaNGK, TenNGK, MaNhanHieu, MaNCC, DonViTinh, SoLuongTon, DonGiaBan, DinhMucTonToiThieu)
                    VALUES (@ma, @ten, @nh, @ncc, @dvt, @ton, @gia, @min)",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@nh", maNH),
                    new SqlParameter("@ncc", maNCC),
                    new SqlParameter("@dvt", dvt ?? "Thùng"),
                    new SqlParameter("@ton", ton),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@min", minTon));
                return KetQuaXuLy.Ok("Thêm nước giải khát thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy Sua(string ma, string ten, string maNH, string maNCC, string dvt, int ton, decimal gia, int minTon)
        {
            try
            {
                int r = Db.Execute(@"
                    UPDATE NuocGiaiKhat
                    SET TenNGK = @ten, MaNhanHieu = @nh, MaNCC = @ncc, DonViTinh = @dvt,
                        SoLuongTon = @ton, DonGiaBan = @gia, DinhMucTonToiThieu = @min
                    WHERE MaNGK = @ma",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@nh", maNH),
                    new SqlParameter("@ncc", maNCC),
                    new SqlParameter("@dvt", dvt ?? "Thùng"),
                    new SqlParameter("@ton", ton),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@min", minTon));
                return r > 0 ? KetQuaXuLy.Ok("Cập nhật thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NGK.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy Xoa(string ma)
        {
            try
            {
                int r = Db.Execute("DELETE FROM NuocGiaiKhat WHERE MaNGK = @ma", new SqlParameter("@ma", ma));
                return r > 0 ? KetQuaXuLy.Ok("Xóa thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã NGK.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa NGK: " + ex.Message);
            }
        }
    }
}
