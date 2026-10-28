using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class KhachHangService
    {
        public DataTable LayTatCa()
        {
            return Db.Query(@"
                SELECT MaKH, HoTen, SoDienThoai, DiaChi, LoaiKhach, HanMucNo, TongNoHienTai,
                       (HanMucNo - TongNoHienTai) AS ConDuocNo
                FROM KhachHang
                ORDER BY MaKH");
        }

        public DataTable LayKhachQuen()
        {
            return Db.Query(@"
                SELECT MaKH, HoTen, SoDienThoai, DiaChi, HanMucNo, TongNoHienTai,
                       (HanMucNo - TongNoHienTai) AS ConDuocNo,
                       CASE 
                           WHEN (HanMucNo - TongNoHienTai) <= 1000000 AND TongNoHienTai > 0 THEN N'Cảnh báo nợ cao'
                           WHEN TongNoHienTai = 0 THEN N'Rất tốt'
                           ELSE N'Bình thường'
                       END AS DanhGia
                FROM KhachHang
                WHERE LoaiKhach = N'Khách quen'
                ORDER BY MaKH");
        }

        public DataTable LayKhachVangLai()
        {
            return Db.Query(@"
                SELECT MaKH, HoTen, SoDienThoai, DiaChi
                FROM KhachHang
                WHERE LoaiKhach = N'Vãng lai'
                ORDER BY MaKH");
        }

        public KetQuaXuLy Them(string ma, string ten, string sdt, string diaChi, string loai, decimal hanMuc)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã và họ tên khách hàng không được để trống.");

            try
            {
                Db.Execute(@"
                    INSERT INTO KhachHang(MaKH, HoTen, SoDienThoai, DiaChi, LoaiKhach, HanMucNo, TongNoHienTai)
                    VALUES (@ma, @ten, @sdt, @dc, @loai, @hm, 0)",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@sdt", sdt ?? ""),
                    new SqlParameter("@dc", diaChi ?? ""),
                    new SqlParameter("@loai", loai ?? "Khách quen"),
                    new SqlParameter("@hm", hanMuc));
                return KetQuaXuLy.Ok("Thêm khách hàng thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy Sua(string ma, string ten, string sdt, string diaChi, string loai, decimal hanMuc)
        {
            try
            {
                int r = Db.Execute(@"
                    UPDATE KhachHang
                    SET HoTen = @ten, SoDienThoai = @sdt, DiaChi = @dc, LoaiKhach = @loai, HanMucNo = @hm
                    WHERE MaKH = @ma",
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@sdt", sdt ?? ""),
                    new SqlParameter("@dc", diaChi ?? ""),
                    new SqlParameter("@loai", loai ?? "Khách quen"),
                    new SqlParameter("@hm", hanMuc));
                return r > 0 ? KetQuaXuLy.Ok("Cập nhật khách hàng thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã khách hàng.");
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
                int r = Db.Execute("DELETE FROM KhachHang WHERE MaKH = @ma", new SqlParameter("@ma", ma));
                return r > 0 ? KetQuaXuLy.Ok("Xóa khách hàng thành công.") : KetQuaXuLy.Fail("Không tìm thấy mã khách hàng.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa khách hàng: " + ex.Message);
            }
        }
    }
}
