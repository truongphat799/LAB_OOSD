using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Adapters;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Services
{
    public class BenhNhanService
    {
        readonly CameraCaptureAdapter camera = new CameraCaptureAdapter();

        public DataTable LayDanhSachBenhNhan()
        {
            return Db.Query(@"SELECT b.*, h.MaHoSo, h.GhiChuTienSuBenh, h.TienSuDiUngThuoc, h.TrangThai AS TrangThaiHoSo
                              FROM BenhNhan b
                              LEFT JOIN HoSoBenhAn h ON b.MaBenhNhan=h.MaBenhNhan
                              ORDER BY b.NgayDangKy DESC");
        }

        public DataTable LayDanhSachHoSo()
        {
            return Db.Query(@"SELECT h.*, b.HoTen, b.NgaySinh, b.GioiTinh, b.SoDienThoai, b.DiaChi, b.AnhChup3x4
                              FROM HoSoBenhAn h
                              JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                              ORDER BY h.NgayTao DESC");
        }

        public DataTable TimKiemBenhNhan(string tuKhoa)
        {
            string sql = @"SELECT b.*, h.MaHoSo, h.GhiChuTienSuBenh, h.TienSuDiUngThuoc, h.TrangThai AS TrangThaiHoSo
                           FROM BenhNhan b
                           LEFT JOIN HoSoBenhAn h ON b.MaBenhNhan=h.MaBenhNhan
                           WHERE b.MaBenhNhan LIKE @k OR b.HoTen LIKE @k OR b.SoDienThoai LIKE @k OR h.MaHoSo LIKE @k
                           ORDER BY b.NgayDangKy DESC";
            return Db.Query(sql, new SqlParameter("@k", "%" + tuKhoa + "%"));
        }

        public string ChupAnh3x4(string maBN)
        {
            return camera.ChupAnhChanDung(maBN);
        }

        // TRANSACTION 1: TIẾP NHẬN BỆNH NHÂN, THU LỆ PHÍ NĂM & CẤP HỒ SƠ BỆNH ÁN
        public KetQuaXuLy DangKyMoiVaCapHoSo(
            string maBN, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sdt, string anh3x4, string maNguoiLap,
            decimal soTienLePhi, int namApDung, string tienSuBenh, string tienSuDiUng)
        {
            if (string.IsNullOrWhiteSpace(maBN) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sdt))
                return KetQuaXuLy.Fail("Vui lòng nhập đầy đủ Mã bệnh nhân, Họ tên và Số điện thoại.");

            if (string.IsNullOrWhiteSpace(anh3x4))
                anh3x4 = camera.ChupAnhChanDung(maBN);

            string maPhieuDK = "PDK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string maBienLai = "LPN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string maHoSo = "HSBA_" + maBN;

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Kiểm tra trùng số điện thoại hoặc mã bệnh nhân
                    var cmdCheck = new SqlCommand("SELECT COUNT(*) FROM BenhNhan WHERE MaBenhNhan=@m OR SoDienThoai=@s", cn, tx);
                    cmdCheck.Parameters.AddWithValue("@m", maBN);
                    cmdCheck.Parameters.AddWithValue("@s", sdt);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                        return KetQuaXuLy.Fail("Mã bệnh nhân hoặc Số điện thoại này đã tồn tại trong hệ thống.");

                    // 2. Thêm bệnh nhân
                    var cmdBN = new SqlCommand(@"INSERT INTO BenhNhan(MaBenhNhan,HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,AnhChup3x4,NgayDangKy)
                                                 VALUES(@m,@t,@ns,@gt,@dc,@sdt,@anh,@ngay)", cn, tx);
                    cmdBN.Parameters.AddWithValue("@m", maBN);
                    cmdBN.Parameters.AddWithValue("@t", hoTen);
                    cmdBN.Parameters.AddWithValue("@ns", ngaySinh.Date);
                    cmdBN.Parameters.AddWithValue("@gt", gioiTinh);
                    cmdBN.Parameters.AddWithValue("@dc", diaChi);
                    cmdBN.Parameters.AddWithValue("@sdt", sdt);
                    cmdBN.Parameters.AddWithValue("@anh", (object)anh3x4 ?? DBNull.Value);
                    cmdBN.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
                    cmdBN.ExecuteNonQuery();

                    // 3. Thêm phiếu đăng ký
                    var cmdDK = new SqlCommand(@"INSERT INTO PhieuDangKy(MaPhieuDK,MaBenhNhan,MaNguoiDungLap,NgayDangKy,ThongTinKham,TrangThai)
                                                 VALUES(@pdk,@m,@nd,@ngay,N'Đăng ký chăm sóc định kỳ & cấp hồ sơ mới',N'Đã cấp hồ sơ')", cn, tx);
                    cmdDK.Parameters.AddWithValue("@pdk", maPhieuDK);
                    cmdDK.Parameters.AddWithValue("@m", maBN);
                    cmdDK.Parameters.AddWithValue("@nd", maNguoiLap);
                    cmdDK.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdDK.ExecuteNonQuery();

                    // 4. Thu lệ phí chăm sóc sức khỏe hằng năm (1.200.000 VNĐ, thời hạn 1 năm)
                    DateTime ngayDong = DateTime.Now.Date;
                    DateTime ngayHetHan = ngayDong.AddYears(1);
                    var cmdLP = new SqlCommand(@"INSERT INTO LePhiNam(MaBienLai,MaBenhNhan,MaNguoiDungThu,SoTien,NgayDong,NgayHetHan,NamApDung,TrangThai)
                                                 VALUES(@bl,@m,@nd,@tien,@dong,@han,@nam,N'Còn hiệu lực')", cn, tx);
                    cmdLP.Parameters.AddWithValue("@bl", maBienLai);
                    cmdLP.Parameters.AddWithValue("@m", maBN);
                    cmdLP.Parameters.AddWithValue("@nd", maNguoiLap);
                    cmdLP.Parameters.AddWithValue("@tien", soTienLePhi);
                    cmdLP.Parameters.AddWithValue("@dong", ngayDong);
                    cmdLP.Parameters.AddWithValue("@han", ngayHetHan);
                    cmdLP.Parameters.AddWithValue("@nam", namApDung);
                    cmdLP.ExecuteNonQuery();

                    // 5. Khởi tạo Hồ sơ bệnh án điện tử (1-1 với Bệnh nhân, dùng suốt đời)
                    var cmdHS = new SqlCommand(@"INSERT INTO HoSoBenhAn(MaHoSo,MaBenhNhan,MaNguoiDungTao,NgayTao,GhiChuTienSuBenh,TienSuDiUngThuoc,TrangThai)
                                                 VALUES(@hs,@m,@nd,@ngay,@tsb,@diung,N'Đang theo dõi')", cn, tx);
                    cmdHS.Parameters.AddWithValue("@hs", maHoSo);
                    cmdHS.Parameters.AddWithValue("@m", maBN);
                    cmdHS.Parameters.AddWithValue("@nd", maNguoiLap);
                    cmdHS.Parameters.AddWithValue("@ngay", ngayDong);
                    cmdHS.Parameters.AddWithValue("@tsb", string.IsNullOrWhiteSpace(tienSuBenh) ? "Chưa ghi nhận bệnh lý nền" : (object)tienSuBenh);
                    cmdHS.Parameters.AddWithValue("@diung", string.IsNullOrWhiteSpace(tienSuDiUng) ? "Không có tiền sử dị ứng thuốc" : (object)tienSuDiUng);
                    cmdHS.ExecuteNonQuery();

                    tx.Commit();

                    string msgSuccess = string.Format("Đăng ký thành công! Bệnh nhân {0} đã nộp lệ phí năm {1:N0} đ và được cấp Mã Hồ Sơ: {2}", hoTen, soTienLePhi, maHoSo);
                    return KetQuaXuLy.Ok(msgSuccess, maHoSo);
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi tiếp nhận bệnh nhân: " + ex.Message);
                }
            }
        }
    }
}
