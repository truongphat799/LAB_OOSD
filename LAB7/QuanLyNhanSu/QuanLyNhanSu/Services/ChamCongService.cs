using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Services
{
    public class ChamCongService
    {
        public DataTable LayDanhSachKeHoachTuan()
        {
            return Db.Query(@"SELECT kh.*, pb.TenPhongBan 
                              FROM KeHoachLamViecTuan kh
                              JOIN PhongBan pb ON kh.MaPhongBan = pb.MaPhongBan
                              ORDER BY kh.NamKeHoach DESC, kh.TuanThu DESC");
        }

        public DataTable LayChiTietKeHoachCa(string maKeHoach)
        {
            return Db.Query(@"SELECT ct.*, nv.HoTen, pb.TenPhongBan
                              FROM ChiTietKeHoachCa ct
                              JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              WHERE ct.MaKeHoach = @mkh
                              ORDER BY ct.NgayTrongTuan, ct.CaLamViec",
                              new SqlParameter("@mkh", maKeHoach));
        }

        public DataTable LayDanhSachBangChamCong()
        {
            return Db.Query(@"SELECT bc.*, pb.TenPhongBan
                              FROM BangChamCong bc
                              JOIN PhongBan pb ON bc.MaPhongBan = pb.MaPhongBan
                              ORDER BY bc.NamChamCong DESC, bc.ThangChamCong DESC");
        }

        public DataTable LayChiTietChamCong(string maBangChamCong)
        {
            return Db.Query(@"SELECT ct.*, nv.HoTen, pb.TenPhongBan
                              FROM ChiTietChamCong ct
                              JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              WHERE ct.MaBangChamCong = @mbc
                              ORDER BY ct.MaNV",
                              new SqlParameter("@mbc", maBangChamCong));
        }

        public DataTable LayDanhSachPhieuPhuTroi()
        {
            return Db.Query(@"SELECT pt.SoPhieuPhuTroi, pt.MaPhongBan, pt.NgayPhuTroi, pt.HinhThucPhuTroi, pt.HeSoPhuTroi, pt.LyDoPhuTroi, pt.TrangThai,
                                     pb.TenPhongBan, ISNULL(SUM(ct.SoGioPhuTroi), 0) AS TongGioPhuTroi
                              FROM PhieuPhuTroi pt
                              JOIN PhongBan pb ON pt.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN ChiTietPhuTroi ct ON pt.SoPhieuPhuTroi = ct.SoPhieuPhuTroi
                              GROUP BY pt.SoPhieuPhuTroi, pt.MaPhongBan, pt.NgayPhuTroi, pt.HinhThucPhuTroi, pt.HeSoPhuTroi, pt.LyDoPhuTroi, pt.TrangThai, pb.TenPhongBan
                              ORDER BY pt.NgayPhuTroi DESC");
        }

        public DataTable LayChiTietPhuTroi(string soPhieuPhuTroi)
        {
            return Db.Query(@"SELECT ct.*, nv.HoTen, qd.LuongCoBan, qd.PhuCapDocHai
                              FROM ChiTietPhuTroi ct
                              JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                              LEFT JOIN QuyetDinhLuong qd ON nv.MaNV = qd.MaNV AND qd.TrangThai = N'Hiện hành'
                              WHERE ct.SoPhieuPhuTroi = @so
                              ORDER BY ct.MaNV",
                              new SqlParameter("@so", soPhieuPhuTroi));
        }

        // LẬP KẾ HOẠCH LÀM VIỆC TUẦN
        public KetQuaXuLy LapKeHoachTuan(string maKH, string maPB, int tuan, int nam, DateTime tuNgay, DateTime denNgay, string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maKH)) return KetQuaXuLy.Fail("Mã kế hoạch không được để trống.");

            try
            {
                Db.Execute(@"INSERT INTO KeHoachLamViecTuan(MaKeHoach, MaPhongBan, TuanThu, NamKeHoach, TuNgay, DenNgay, NgayLap, GhiChuPhuTroiDuKien, TrangThai)
                             VALUES(@m, @pb, @t, @nam, @tu, @den, @ngay, @gc, N'Đã chuyển Ban chấm công')",
                             new SqlParameter("@m", maKH),
                             new SqlParameter("@pb", maPB),
                             new SqlParameter("@t", tuan),
                             new SqlParameter("@nam", nam),
                             new SqlParameter("@tu", tuNgay.Date),
                             new SqlParameter("@den", denNgay.Date),
                             new SqlParameter("@ngay", DateTime.Now.Date),
                             new SqlParameter("@gc", ghiChu ?? ""));
                return KetQuaXuLy.Ok("Lập kế hoạch tuần và chuyển cho Ban chấm công thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi lập kế hoạch tuần: " + ex.Message);
            }
        }

        // PHÂN CÔNG CA LÀM VIỆC CHO NHÂN VIÊN
        public KetQuaXuLy PhanCongCaNhanVien(string maChiTietCa, string maKH, string maNV, DateTime ngay, string caLamViec, string nhiemVu)
        {
            try
            {
                Db.Execute(@"INSERT INTO ChiTietKeHoachCa(MaChiTietCa, MaKeHoach, MaNV, NgayTrongTuan, CaLamViec, NhiemVuPhanCong)
                             VALUES(@mct, @mkh, @mnv, @ngay, @ca, @nv)",
                             new SqlParameter("@mct", maChiTietCa),
                             new SqlParameter("@mkh", maKH),
                             new SqlParameter("@mnv", maNV),
                             new SqlParameter("@ngay", ngay.Date),
                             new SqlParameter("@ca", caLamViec),
                             new SqlParameter("@nv", nhiemVu ?? ""));
                return KetQuaXuLy.Ok("Phân công ca làm việc thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi phân công ca: " + ex.Message);
            }
        }

        // LẬP BẢNG CHẤM CÔNG THÁNG & NHẬP VÀO MÁY TÍNH
        public KetQuaXuLy KhoiTaoBangChamCongThang(string maBCC, string maPB, int thang, int nam, int soCongChuan = 26)
        {
            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Tạo bảng chấm công
                    var cmdBCC = new SqlCommand(@"INSERT INTO BangChamCong(MaBangChamCong, MaPhongBan, ThangChamCong, NamChamCong, NgayChotCong, SoCongChuan, TrangThai)
                                                  VALUES(@mbc, @pb, @t, @nam, @ngay, @scc, N'Đang chấm')", cn, tx);
                    cmdBCC.Parameters.AddWithValue("@mbc", maBCC);
                    cmdBCC.Parameters.AddWithValue("@pb", maPB);
                    cmdBCC.Parameters.AddWithValue("@t", thang);
                    cmdBCC.Parameters.AddWithValue("@nam", nam);
                    cmdBCC.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
                    cmdBCC.Parameters.AddWithValue("@scc", soCongChuan);
                    cmdBCC.ExecuteNonQuery();

                    // 2. Tự động lấy danh sách nhân viên thuộc phòng ban để tạo chi tiết chấm công
                    var cmdNV = new SqlCommand("SELECT MaNV FROM NhanVien WHERE MaPhongBan = @pb AND TrangThai IN (N'Chính thức', N'Thử việc')", cn, tx);
                    cmdNV.Parameters.AddWithValue("@pb", maPB);
                    using (var da = new SqlDataAdapter(cmdNV))
                    {
                        var dtNV = new DataTable();
                        da.Fill(dtNV);
                        foreach (DataRow r in dtNV.Rows)
                        {
                            string maNV = r["MaNV"].ToString();
                            string maCTCC = "CTCC_" + maBCC + "_" + maNV;
                            var cmdCT = new SqlCommand(@"INSERT INTO ChiTietChamCong(MaCTCC, MaBangChamCong, MaNV, SoNgayDiLamThucTe, SoNgayNghiPhep, SoNgayNghiOm, SoNgayNghiKhongPhep, GhiChu)
                                                         VALUES(@mct, @mbc, @mnv, @scc, 0, 0, 0, N'Chấm công chuẩn')", cn, tx);
                            cmdCT.Parameters.AddWithValue("@mct", maCTCC);
                            cmdCT.Parameters.AddWithValue("@mbc", maBCC);
                            cmdCT.Parameters.AddWithValue("@mnv", maNV);
                            cmdCT.Parameters.AddWithValue("@scc", soCongChuan);
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Khởi tạo bảng chấm công tháng thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail("Lỗi khởi tạo bảng chấm công: " + ex.Message);
                }
            }
        }

        // CẬP NHẬT CHI TIẾT NGÀY CÔNG NHÂN VIÊN
        public KetQuaXuLy CapNhatCongNhanVien(string maCTCC, decimal diLam, decimal phep, decimal om, decimal khongPhep, string ghiChu)
        {
            try
            {
                Db.Execute(@"UPDATE ChiTietChamCong 
                             SET SoNgayDiLamThucTe = @dl, SoNgayNghiPhep = @p, SoNgayNghiOm = @o, SoNgayNghiKhongPhep = @kp, GhiChu = @gc
                             WHERE MaCTCC = @m",
                             new SqlParameter("@dl", diLam),
                             new SqlParameter("@p", phep),
                             new SqlParameter("@o", om),
                             new SqlParameter("@kp", khongPhep),
                             new SqlParameter("@gc", ghiChu ?? ""),
                             new SqlParameter("@m", maCTCC));
                return KetQuaXuLy.Ok("Cập nhật ngày công nhân viên thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi cập nhật công: " + ex.Message);
            }
        }

        // LẬP PHIẾU GHI NHẬN GIỜ PHỤ TRỘI (HỆ SỐ 1.5)
        public KetQuaXuLy LapPhieuPhuTroi(string soPhieu, string maPB, DateTime ngay, string hinhThuc, string lyDo)
        {
            try
            {
                Db.Execute(@"INSERT INTO PhieuPhuTroi(SoPhieuPhuTroi, MaPhongBan, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, LyDoPhuTroi, TrangThai)
                             VALUES(@so, @pb, @ngay, @ht, 1.50, @ld, N'Đã xác nhận')",
                             new SqlParameter("@so", soPhieu),
                             new SqlParameter("@pb", maPB),
                             new SqlParameter("@ngay", ngay.Date),
                             new SqlParameter("@ht", hinhThuc),
                             new SqlParameter("@ld", lyDo));
                return KetQuaXuLy.Ok("Lập Phiếu ghi nhận giờ phụ trội (hệ số 1.5) thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi lập phiếu phụ trội: " + ex.Message);
            }
        }

        // THÊM CHI TIẾT GIỜ PHỤ TRỘI TỪNG NHÂN VIÊN
        public KetQuaXuLy ThemChiTietPhuTroi(string maCT, string soPhieu, string maNV, decimal soGio, string nhiemVu)
        {
            try
            {
                Db.Execute(@"INSERT INTO ChiTietPhuTroi(MaCTPhuTroi, SoPhieuPhuTroi, MaNV, SoGioPhuTroi, NhiemVuCuThe)
                             VALUES(@mct, @so, @mnv, @gio, @nv)",
                             new SqlParameter("@mct", maCT),
                             new SqlParameter("@so", soPhieu),
                             new SqlParameter("@mnv", maNV),
                             new SqlParameter("@gio", soGio),
                             new SqlParameter("@nv", nhiemVu ?? ""));
                return KetQuaXuLy.Ok("Ghi nhận số giờ phụ trội cho nhân viên thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi thêm chi tiết phụ trội: " + ex.Message);
            }
        }
    }
}
