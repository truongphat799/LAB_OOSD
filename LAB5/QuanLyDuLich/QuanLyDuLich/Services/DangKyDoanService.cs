using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class DangKyDoanService
    {
        public DataTable LayDanhSachPhieuDoan()
        {
            return Db.Query(@"SELECT p.SoPhieuDK, k.HoTen AS TenKhachHang, kd.TenCoQuan, kd.DienThoaiCoQuan,
                                     t.TenTour, p.NgayLap, p.NgayDiYeuCau, p.DiaDiemDon, p.SoNguoiDi, 
                                     p.CoBaoHiem, p.TongKinhPhi, p.TienCoc, p.TienConLai, p.TrangThai
                              FROM PhieuDangKyDoan p
                              JOIN KhachHang k ON p.MaKhachHang = k.MaKhachHang
                              LEFT JOIN KhachDoan kd ON k.MaKhachHang = kd.MaKhachHang
                              JOIN TourDuLich t ON p.MaTour = t.MaTour
                              ORDER BY p.NgayLap DESC");
        }

        public DataTable LayThanhVienBaoHiem(string soPhieuDK)
        {
            return Db.Query("SELECT * FROM ThanhVienDoan WHERE SoPhieuDK = @sp ORDER BY MaThanhVien",
                new SqlParameter("@sp", soPhieuDK));
        }

        public DataTable LayKhachDoan()
        {
            return Db.Query(@"SELECT k.MaKhachHang, kd.TenCoQuan, kd.NguoiDaiDien, kd.DienThoaiCoQuan, kd.DiaChiCoQuan 
                              FROM KhachHang k 
                              JOIN KhachDoan kd ON k.MaKhachHang = kd.MaKhachHang 
                              ORDER BY kd.TenCoQuan");
        }

        // Lập phiếu đăng ký đoàn bám sát BR01, BR04, BR05
        public KetQuaXuLy LapPhieuDangKyDoan(
            string soPhieu, string maKH, string maTour,
            DateTime ngayDiYeuCau, string diaDiemDonYeuCau,
            int soNguoiDi, bool coBaoHiem, decimal tienCoc)
        {
            // BR01: Số lượng khách theo đoàn phải từ 12 người trở lên
            if (soNguoiDi < 12)
                return KetQuaXuLy.Fail("Quy định (BR01): Đăng ký tour theo đoàn phải có từ 12 khách trở lên.");

            if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maTour))
                return KetQuaXuLy.Fail("Thông tin phiếu đăng ký chưa đầy đủ.");

            if (string.IsNullOrWhiteSpace(diaDiemDonYeuCau))
                return KetQuaXuLy.Fail("Vui lòng nhập địa điểm đón tận nơi theo yêu cầu của đoàn.");

            // Lấy đơn giá tour
            object objGia = Db.Scalar("SELECT DonGiaKhach FROM TourDuLich WHERE MaTour = @t", new SqlParameter("@t", maTour));
            if (objGia == null) return KetQuaXuLy.Fail("Không tìm thấy tour được chọn.");

            decimal donGia = Convert.ToDecimal(objGia);
            decimal tongKinhPhi = donGia * soNguoiDi;

            // BR05: Tiền cọc tối thiểu là 30% tổng kinh phí
            decimal tienCocToiThieu = tongKinhPhi * 0.3m;
            if (tienCoc < tienCocToiThieu)
                return KetQuaXuLy.Fail($"Quy định (BR05): Khách đoàn phải đặt cọc tối thiểu 30% ({tienCocToiThieu:N0} đ).");

            try
            {
                Db.Execute(@"INSERT INTO PhieuDangKyDoan(SoPhieuDK, MaKhachHang, MaTour, NgayLap, NgayDiYeuCau, DiaDiemDon, SoNguoiDi, CoBaoHiem, TongKinhPhi, TienCoc, TrangThai)
                             VALUES(@sp, @kh, @mt, GETDATE(), @ndi, @dd, @sn, @bh, @tkp, @tc, N'Đã đặt cọc')",
                    new SqlParameter("@sp", soPhieu.Trim()),
                    new SqlParameter("@kh", maKH.Trim()),
                    new SqlParameter("@mt", maTour.Trim()),
                    new SqlParameter("@ndi", ngayDiYeuCau.Date),
                    new SqlParameter("@dd", diaDiemDonYeuCau.Trim()),
                    new SqlParameter("@sn", soNguoiDi),
                    new SqlParameter("@bh", coBaoHiem),
                    new SqlParameter("@tkp", tongKinhPhi),
                    new SqlParameter("@tc", tienCoc));

                return KetQuaXuLy.Ok($"Lập phiếu đăng ký đoàn thành công. Đã ghi nhận tiền cọc: {tienCoc:N0} đ.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi lập phiếu đăng ký đoàn: " + ex.Message);
            }
        }

        // BR05: Nếu hủy tour, công ty giữ lại 100% tiền đặt cọc
        public KetQuaXuLy HuyTourMatCoc(string soPhieuDK)
        {
            try
            {
                int r = Db.Execute(@"UPDATE PhieuDangKyDoan 
                                     SET TrangThai = N'Hủy tour (Mất cọc)' 
                                     WHERE SoPhieuDK = @sp",
                    new SqlParameter("@sp", soPhieuDK));

                return r > 0 
                    ? KetQuaXuLy.Ok("Quy định (BR05): Đã hủy tour đoàn. Toàn bộ số tiền cọc được giữ lại cho công ty.") 
                    : KetQuaXuLy.Fail("Không tìm thấy số phiếu đăng ký.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // BR04: Thêm thành viên đoàn mua bảo hiểm
        public KetQuaXuLy ThemThanhVienBaoHiem(string maTV, string soPhieuDK, string hoTen, DateTime ngaySinh, string soCCCD, string gioiTinh, string sdt)
        {
            if (string.IsNullOrWhiteSpace(maTV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(soCCCD))
                return KetQuaXuLy.Fail("Thông tin thành viên mua bảo hiểm (Họ tên, CCCD) không được để trống.");

            try
            {
                Db.Execute(@"INSERT INTO ThanhVienDoan(MaThanhVien, SoPhieuDK, HoTen, NgaySinh, SoCCCD, GioiTinh, SoDienThoai)
                             VALUES(@mtv, @sp, @ht, @ns, @cccd, @gt, @sdt)",
                    new SqlParameter("@mtv", maTV.Trim()),
                    new SqlParameter("@sp", soPhieuDK.Trim()),
                    new SqlParameter("@ht", hoTen.Trim()),
                    new SqlParameter("@ns", ngaySinh.Date),
                    new SqlParameter("@cccd", soCCCD.Trim()),
                    new SqlParameter("@gt", gioiTinh.Trim()),
                    new SqlParameter("@sdt", sdt ?? (object)DBNull.Value));

                return KetQuaXuLy.Ok("Đã thêm thành viên vào danh sách mua bảo hiểm.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }
    }
}
