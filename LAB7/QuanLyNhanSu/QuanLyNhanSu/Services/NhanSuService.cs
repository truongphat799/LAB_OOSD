using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Services
{
    public class NhanSuService
    {
        public DataTable LayDanhSachQDTuyenDung()
        {
            return Db.Query(@"SELECT qd.*, nv.HoTen, pb.TenPhongBan 
                              FROM QuyetDinhTuyenDung qd
                              JOIN NhanVien nv ON qd.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              ORDER BY qd.NgayBanHanh DESC");
        }

        public DataTable LayDanhSachHopDong()
        {
            return Db.Query(@"SELECT hd.*, nv.HoTen, pb.TenPhongBan, bh.MaSoBHXH, bh.SoTheBHYT
                              FROM HopDongLaoDong hd
                              JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN HoSoBaoHiem bh ON hd.SoHopDong = bh.SoHopDong
                              ORDER BY hd.NgayKy DESC");
        }

        public DataTable LayDanhSachQDLuong()
        {
            return Db.Query(@"SELECT ql.*, nv.HoTen, pb.TenPhongBan
                              FROM QuyetDinhLuong ql
                              JOIN NhanVien nv ON ql.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              ORDER BY ql.NgayHieuLuc DESC");
        }

        public DataTable LayDanhSachQDChucVu()
        {
            return Db.Query(@"SELECT qc.*, nv.HoTen, cv.TenChucVu
                              FROM QuyetDinhChucVu qc
                              JOIN NhanVien nv ON qc.MaNV = nv.MaNV
                              JOIN ChucVu cv ON qc.MaChucVu = cv.MaChucVu
                              ORDER BY qc.NgayHieuLuc DESC");
        }

        // TRANSACTION: TIẾP NHẬN ỨNG VIÊN & BAN HÀNH QUYẾT ĐỊNH TUYỂN DỤNG THỬ VIỆC
        public KetQuaXuLy TiepNhanVaLapQDTuyenDung(
            string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string cccd,
            string diaChi, string sdt, string email, string maPhongBan,
            string soQDTD, DateTime tuNgay, DateTime denNgay, decimal luongThuViec, string dieuKhoan)
        {
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(cccd))
                return KetQuaXuLy.Fail("Vui lòng điền đầy đủ Mã nhân viên, Họ tên và Số CCCD.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Kiểm tra trùng
                    var cmdCheck = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE MaNV = @m OR SoCCCD = @c OR SoDienThoai = @s", cn, tx);
                    cmdCheck.Parameters.AddWithValue("@m", maNV);
                    cmdCheck.Parameters.AddWithValue("@c", cccd);
                    cmdCheck.Parameters.AddWithValue("@s", sdt);
                    if ((int)cmdCheck.ExecuteScalar() > 0)
                        return KetQuaXuLy.Fail("Mã NV, số CCCD hoặc số điện thoại đã tồn tại trong hệ thống.");

                    // 2. Thêm Nhân viên thử việc
                    var cmdNV = new SqlCommand(@"INSERT INTO NhanVien(MaNV, MaPhongBan, HoTen, NgaySinh, GioiTinh, SoCCCD, DiaChi, SoDienThoai, Email, NgayVaoLam, TrangThai)
                                                 VALUES(@m, @pb, @t, @ns, @gt, @cccd, @dc, @sdt, @em, @nvl, N'Thử việc')", cn, tx);
                    cmdNV.Parameters.AddWithValue("@m", maNV);
                    cmdNV.Parameters.AddWithValue("@pb", maPhongBan);
                    cmdNV.Parameters.AddWithValue("@t", hoTen);
                    cmdNV.Parameters.AddWithValue("@ns", ngaySinh.Date);
                    cmdNV.Parameters.AddWithValue("@gt", gioiTinh);
                    cmdNV.Parameters.AddWithValue("@cccd", cccd);
                    cmdNV.Parameters.AddWithValue("@dc", diaChi);
                    cmdNV.Parameters.AddWithValue("@sdt", sdt);
                    cmdNV.Parameters.AddWithValue("@em", (object)email ?? DBNull.Value);
                    cmdNV.Parameters.AddWithValue("@nvl", DateTime.Now.Date);
                    cmdNV.ExecuteNonQuery();

                    // 3. Lấy hoặc gắn Mã đề xuất tuyển dụng tương ứng phòng ban
                    object maDeXuatObj = (new SqlCommand("SELECT TOP 1 MaDeXuat FROM PhieuDeXuatTuyenDung WHERE MaPhongBan = '" + maPhongBan + "'", cn, tx)).ExecuteScalar();
                    string maDeXuat = maDeXuatObj != null ? maDeXuatObj.ToString() : "DX01";

                    // 4. Thêm Quyết định tuyển dụng thử việc (bám sát schema QuyetDinhTuyenDung)
                    var cmdQD = new SqlCommand(@"INSERT INTO QuyetDinhTuyenDung(SoQDTuyenDung, MaNV, MaDeXuat, NgayBanHanh, ThoiGianThuViecTu, ThoiGianThuViecDen, MucLuongThuViec, DieuKhoanThoaThuan, TrangThai)
                                                 VALUES(@so, @m, @dx, @nbh, @tu, @den, @luong, @dk, N'Đang thử việc')", cn, tx);
                    cmdQD.Parameters.AddWithValue("@so", soQDTD);
                    cmdQD.Parameters.AddWithValue("@m", maNV);
                    cmdQD.Parameters.AddWithValue("@dx", maDeXuat);
                    cmdQD.Parameters.AddWithValue("@nbh", DateTime.Now.Date);
                    cmdQD.Parameters.AddWithValue("@tu", tuNgay.Date);
                    cmdQD.Parameters.AddWithValue("@den", denNgay.Date);
                    cmdQD.Parameters.AddWithValue("@luong", luongThuViec);
                    cmdQD.Parameters.AddWithValue("@dk", dieuKhoan ?? "Thử việc theo quy chế công ty sơn Đông Á");
                    cmdQD.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Tiếp nhận ứng viên và ban hành Quyết định tuyển dụng thử việc thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail("Lỗi tiếp nhận tuyển dụng: " + ex.Message);
                }
            }
        }

        // TRANSACTION: ĐÁNH GIÁ THỬ VIỆC, KÝ HỢP ĐỒNG LAO ĐỘNG & LÀM HỒ SƠ BẢO HIỂM NẾU DÀI HẠN
        public KetQuaXuLy KyHopDongVaBanHanhQuyetDinh(
            string maNV, string soQDTD, string ketQuaDG, string nhanXet,
            string soHD, string loaiHD, DateTime ngayKy, DateTime ngayHieuLuc, DateTime? ngayHetHan,
            string chucDanh, string diaDiem, string quyenLoi,
            string maSoBHXH, string soTheBHYT, string noiKCB,
            string soQDChucVu, string maChucVu, decimal phuCapChucVu,
            string soQDLuong, decimal luongCoBan, decimal phuCapLuong, decimal phuCapDocHai)
        {
            if (ketQuaDG != "Đạt")
            {
                Db.Execute("UPDATE QuyetDinhTuyenDung SET TrangThai = N'Không đạt' WHERE SoQDTuyenDung = @so", new SqlParameter("@so", soQDTD));
                Db.Execute("UPDATE NhanVien SET TrangThai = N'Đã nghỉ việc' WHERE MaNV = @m", new SqlParameter("@m", maNV));
                return KetQuaXuLy.Fail("Kết quả thử việc Không đạt. Hệ thống đã cập nhật chấm dứt thử việc.");
            }

            // Quy tắc: Hợp đồng dài hạn bắt buộc có BHYT và BHXH
            if (loaiHD == "Dài hạn")
            {
                if (string.IsNullOrWhiteSpace(maSoBHXH) || string.IsNullOrWhiteSpace(soTheBHYT))
                    return KetQuaXuLy.Fail("QUY TẮC BẮT BUỘC: Hợp đồng dài hạn bắt buộc công ty phải làm hồ sơ BHYT và BHXH cho nhân viên.");
            }

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Thêm bản ghi Đánh giá thử việc (bám sát schema DanhGiaThuViec)
                    string maDG = "DG_" + maNV + "_" + DateTime.Now.ToString("yyyyMMdd");
                    var cmdDG = new SqlCommand(@"INSERT INTO DanhGiaThuViec(MaDanhGia, SoQDTuyenDung, NgayDanhGia, KetQuaDanhGia, NhanXetChuyenMon, DeXuatHopDong)
                                                 VALUES(@mdg, @sqd, @ndg, @kq, @nx, @dx)", cn, tx);
                    cmdDG.Parameters.AddWithValue("@mdg", maDG);
                    cmdDG.Parameters.AddWithValue("@sqd", soQDTD);
                    cmdDG.Parameters.AddWithValue("@ndg", DateTime.Now.Date);
                    cmdDG.Parameters.AddWithValue("@kq", ketQuaDG);
                    cmdDG.Parameters.AddWithValue("@nx", nhanXet);
                    cmdDG.Parameters.AddWithValue("@dx", loaiHD == "Dài hạn" ? "Ký HĐ dài hạn" : "Ký HĐ ngắn hạn");
                    cmdDG.ExecuteNonQuery();

                    // 2. Thêm Hợp đồng lao động (bám sát schema HopDongLaoDong)
                    var cmdHD = new SqlCommand(@"INSERT INTO HopDongLaoDong(SoHopDong, MaNV, LoaiHopDong, NgayKy, NgayHieuLuc, NgayHetHan, DiaDiemLamViec, QuyenLoiNghiaVu, TrangThai)
                                                 VALUES(@shd, @m, @lhd, @nk, @nhl, @nhh, @dd, @ql, N'Còn hiệu lực')", cn, tx);
                    cmdHD.Parameters.AddWithValue("@shd", soHD);
                    cmdHD.Parameters.AddWithValue("@m", maNV);
                    cmdHD.Parameters.AddWithValue("@lhd", loaiHD);
                    cmdHD.Parameters.AddWithValue("@nk", ngayKy.Date);
                    cmdHD.Parameters.AddWithValue("@nhl", ngayHieuLuc.Date);
                    cmdHD.Parameters.AddWithValue("@nhh", (object)ngayHetHan ?? DBNull.Value);
                    cmdHD.Parameters.AddWithValue("@dd", diaDiem);
                    cmdHD.Parameters.AddWithValue("@ql", quyenLoi);
                    cmdHD.ExecuteNonQuery();

                    // 3. Nếu là HĐ Dài hạn -> Tạo hồ sơ Bảo hiểm y tế & Bảo hiểm xã hội
                    if (loaiHD == "Dài hạn")
                    {
                        string maBH = "BH_" + maNV;
                        var cmdBH = new SqlCommand(@"INSERT INTO HoSoBaoHiem(MaHoSoBH, SoHopDong, MaNV, MaSoBHXH, SoTheBHYT, NoiKhamChuaBenh, NgayBatDauBH, TyLeDongNV, TyLeDongCongTy, TrangThai)
                                                     VALUES(@mbh, @shd, @m, @bhxh, @bhyt, @kcb, @nbd, 10.50, 21.50, N'Đang tham gia')", cn, tx);
                        cmdBH.Parameters.AddWithValue("@mbh", maBH);
                        cmdBH.Parameters.AddWithValue("@shd", soHD);
                        cmdBH.Parameters.AddWithValue("@m", maNV);
                        cmdBH.Parameters.AddWithValue("@bhxh", maSoBHXH);
                        cmdBH.Parameters.AddWithValue("@bhyt", soTheBHYT);
                        cmdBH.Parameters.AddWithValue("@kcb", string.IsNullOrEmpty(noiKCB) ? "Bệnh viện Đa Khoa TP.HCM" : noiKCB);
                        cmdBH.Parameters.AddWithValue("@nbd", ngayHieuLuc.Date);
                        cmdBH.ExecuteNonQuery();
                    }

                    // 4. Quyết định chức vụ & phụ cấp chức vụ
                    var cmdCV = new SqlCommand(@"INSERT INTO QuyetDinhChucVu(SoQDChucVu, MaNV, MaChucVu, NgayBanHanh, NgayHieuLuc, PhuCapChucVu, LyDoBoNhiem, TrangThai)
                                                 VALUES(@scv, @m, @mcv, @nbh, @nhl, @pccv, N'Bổ nhiệm khi ký HĐLĐ chính thức', N'Hiện hành')", cn, tx);
                    cmdCV.Parameters.AddWithValue("@scv", soQDChucVu);
                    cmdCV.Parameters.AddWithValue("@m", maNV);
                    cmdCV.Parameters.AddWithValue("@mcv", maChucVu);
                    cmdCV.Parameters.AddWithValue("@nbh", DateTime.Now.Date);
                    cmdCV.Parameters.AddWithValue("@nhl", ngayHieuLuc.Date);
                    cmdCV.Parameters.AddWithValue("@pccv", phuCapChucVu);
                    cmdCV.ExecuteNonQuery();

                    // 5. Quyết định lương & phụ cấp độc hại (ngành sơn)
                    var cmdL = new SqlCommand(@"INSERT INTO QuyetDinhLuong(SoQDLuong, MaNV, NgayBanHanh, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, LyDoDieuChinh, TrangThai)
                                                VALUES(@sl, @m, @nbh, @nhl, @lcb, @pcl, @pcdh, N'Xác lập bậc lương khi ký HĐLĐ chính thức', N'Hiện hành')", cn, tx);
                    cmdL.Parameters.AddWithValue("@sl", soQDLuong);
                    cmdL.Parameters.AddWithValue("@m", maNV);
                    cmdL.Parameters.AddWithValue("@nbh", DateTime.Now.Date);
                    cmdL.Parameters.AddWithValue("@nhl", ngayHieuLuc.Date);
                    cmdL.Parameters.AddWithValue("@lcb", luongCoBan);
                    cmdL.Parameters.AddWithValue("@pcl", phuCapLuong);
                    cmdL.Parameters.AddWithValue("@pcdh", phuCapDocHai);
                    cmdL.ExecuteNonQuery();

                    // 6. Cập nhật trạng thái nhân viên thành Chính thức
                    var cmdUp = new SqlCommand("UPDATE NhanVien SET TrangThai = N'Chính thức' WHERE MaNV = @m", cn, tx);
                    cmdUp.Parameters.AddWithValue("@m", maNV);
                    cmdUp.ExecuteNonQuery();

                    // Cập nhật trạng thái quyết định tuyển dụng
                    var cmdUpQD = new SqlCommand("UPDATE QuyetDinhTuyenDung SET TrangThai = N'Đã ký hợp đồng' WHERE SoQDTuyenDung = @so", cn, tx);
                    cmdUpQD.Parameters.AddWithValue("@so", soQDTD);
                    cmdUpQD.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Ký Hợp đồng lao động chính thức, lập hồ sơ bảo hiểm và ban hành Quyết định chức vụ/lương thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail("Lỗi ký hợp đồng: " + ex.Message);
                }
            }
        }
    }
}
