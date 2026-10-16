using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Adapters;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Services
{
    public class VienPhiVaCSKHService
    {
        readonly SMSNotificationAdapter sms = new SMSNotificationAdapter();

        public DataTable LayDanhSachChoXuatVien()
        {
            return Db.Query(@"SELECT p.*, h.MaBenhNhan, b.HoTen, b.SoDienThoai, k.TenKhoa, u.HoTen AS TenBacSi
                              FROM PhieuKhamBenh p
                              JOIN HoSoBenhAn h ON p.MaHoSo=h.MaHoSo
                              JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                              JOIN KhoaDieuTri k ON p.MaKhoa=k.MaKhoa
                              JOIN NguoiDung u ON p.MaBacSi=u.MaNguoiDung
                              WHERE p.TrangThai = N'Đã kê toa'
                              ORDER BY p.NgayGioKham DESC");
        }

        public DataTable LayDanhSachXuatVienVaKhoaHoSo()
        {
            return Db.Query(@"SELECT hd.*, p.MaHoSo, b.HoTen AS TenBenhNhan, b.SoDienThoai, td.DanhGiaHieuQua, td.DienBienSucKhoe, td.TrachNhiemBacSi, u.HoTen AS TenBacSi
                              FROM HoaDonVienPhi hd
                              JOIN PhieuKhamBenh p ON hd.MaPhieuKham=p.MaPhieuKham
                              JOIN HoSoBenhAn h ON p.MaHoSo=h.MaHoSo
                              JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                              LEFT JOIN TheoDoiSauDieuTri td ON p.MaPhieuKham=td.MaPhieuKham
                              LEFT JOIN NguoiDung u ON td.TrachNhiemBacSi=u.MaNguoiDung
                              ORDER BY hd.NgayThanhToan DESC");
        }

        public DataTable LayLichHenDinhKy()
        {
            return Db.Query(@"SELECT lh.*, b.HoTen, b.SoDienThoai, u.HoTen AS TenNVCSKH
                              FROM LichHenKhamDinhKy lh
                              JOIN HoSoBenhAn h ON lh.MaHoSo=h.MaHoSo
                              JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                              JOIN NguoiDung u ON lh.MaNVCSKH=u.MaNguoiDung
                              ORDER BY lh.NgayGioHen ASC");
        }

        // Tính toán viện phí chi tiết theo quy chế bệnh viện
        public DataTable TinhChiTietVienPhi(string maPK, out decimal tongKham, out decimal tongXN, out decimal tongThuoc, out decimal giamTru, out decimal tongCong)
        {
            tongKham = 150000;
            tongXN = 0;
            tongThuoc = 0;
            giamTru = 0;

            // Kiểm tra loại khám
            string loaiKham = Convert.ToString(Db.Scalar("SELECT LoaiKham FROM PhieuKhamBenh WHERE MaPhieuKham=@pk", new SqlParameter("@pk", maPK)));
            if (loaiKham == "Khám định kỳ theo quý")
            {
                giamTru = tongKham;
                tongKham = 0;
            }

            // Tính tiền xét nghiệm
            object oXN = Db.Scalar(@"SELECT SUM(d.DonGia) 
                                     FROM ChiTietKetQuaXN c 
                                     JOIN PhieuChiDinhXN cd ON c.MaPhieuCD=cd.MaPhieuCD 
                                     JOIN DichVuXetNghiem d ON c.MaDichVuXN=d.MaDichVuXN 
                                     WHERE cd.MaPhieuKham=@pk", new SqlParameter("@pk", maPK));
            if (oXN != null && oXN != DBNull.Value) tongXN = Convert.ToDecimal(oXN);

            // Tính tiền thuốc
            object oThuoc = Db.Scalar(@"SELECT SUM(c.ThanhTien) 
                                        FROM ChiTietToaThuoc c 
                                        JOIN ToaThuoc t ON c.MaToaThuoc=t.MaToaThuoc 
                                        WHERE t.MaPhieuKham=@pk", new SqlParameter("@pk", maPK));
            if (oThuoc != null && oThuoc != DBNull.Value) tongThuoc = Convert.ToDecimal(oThuoc);

            tongCong = tongKham + tongXN + tongThuoc - giamTru;

            return Db.Query(@"SELECT 'Tiền khám bệnh' AS KhoanMuc, @k AS SoTien
                              UNION ALL
                              SELECT 'Tiền xét nghiệm cận lâm sàng', @xn
                              UNION ALL
                              SELECT 'Tiền thuốc điều trị', @th
                              UNION ALL
                              SELECT 'Giảm trừ lệ phí năm (Khám định kỳ)', -@gt
                              UNION ALL
                              SELECT 'TỔNG CỘNG THANH TOÁN', @tc",
                new SqlParameter("@k", tongKham),
                new SqlParameter("@xn", tongXN),
                new SqlParameter("@th", tongThuoc),
                new SqlParameter("@gt", giamTru),
                new SqlParameter("@tc", tongCong));
        }

        // TRANSACTION 3: THANH TOÁN VIỆN PHÍ, HOÀN TẤT XUẤT VIỆN & CSKH KHÓA HỒ SƠ
        public KetQuaXuLy ThanhToanXuatVienVaKhoaHoSo(
            string maHD, string maPK, string maThuNgan, string maCSKH,
            string phuongThucTT, string dienBien, string phanUngPhu, string danhGiaHieuQua)
        {
            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(maPK))
                return KetQuaXuLy.Fail("Thông tin thanh toán viện phí chưa đầy đủ.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Lấy thông tin đợt khám
                    var cmdPK = new SqlCommand("SELECT MaHoSo, MaBacSi, LoaiKham FROM PhieuKhamBenh WHERE MaPhieuKham=@pk", cn, tx);
                    cmdPK.Parameters.AddWithValue("@pk", maPK);
                    string maHoSo = "";
                    string maBacSi = "";
                    string loaiKham = "";

                    using (var reader = cmdPK.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maHoSo = reader["MaHoSo"].ToString();
                            maBacSi = reader["MaBacSi"].ToString();
                            loaiKham = reader["LoaiKham"].ToString();
                        }
                        else return KetQuaXuLy.Fail("Không tìm thấy thông tin phiếu khám bệnh!");
                    }

                    // 2. Tính toán viện phí
                    decimal tienKham = 150000;
                    decimal tienXN = 0;
                    decimal tienThuoc = 0;
                    decimal giamTru = 0;

                    if (loaiKham == "Khám định kỳ theo quý")
                    {
                        giamTru = tienKham;
                        tienKham = 0;
                    }

                    var cmdXN = new SqlCommand(@"SELECT ISNULL(SUM(d.DonGia),0) 
                                                 FROM ChiTietKetQuaXN c 
                                                 JOIN PhieuChiDinhXN cd ON c.MaPhieuCD=cd.MaPhieuCD 
                                                 JOIN DichVuXetNghiem d ON c.MaDichVuXN=d.MaDichVuXN 
                                                 WHERE cd.MaPhieuKham=@pk", cn, tx);
                    cmdXN.Parameters.AddWithValue("@pk", maPK);
                    tienXN = Convert.ToDecimal(cmdXN.ExecuteScalar());

                    var cmdTH = new SqlCommand(@"SELECT ISNULL(SUM(c.ThanhTien),0) 
                                                 FROM ChiTietToaThuoc c 
                                                 JOIN ToaThuoc t ON c.MaToaThuoc=t.MaToaThuoc 
                                                 WHERE t.MaPhieuKham=@pk", cn, tx);
                    cmdTH.Parameters.AddWithValue("@pk", maPK);
                    tienThuoc = Convert.ToDecimal(cmdTH.ExecuteScalar());

                    // 3. Tạo Hóa đơn viện phí xuất viện (TongThanhToan là cột PERSISTED)
                    var cmdHD = new SqlCommand(@"INSERT INTO HoaDonVienPhi(MaHoaDon,MaPhieuKham,MaThuNgan,NgayThanhToan,TongTienKham,TongTienXN,TongTienThuoc,GiamTruLePhi,PhuongThucTT,TrangThai)
                                                 VALUES(@hd,@pk,@tn,@ngay,@tk,@txn,@tth,@gt,@pt,N'Đã thanh toán')", cn, tx);
                    cmdHD.Parameters.AddWithValue("@hd", maHD);
                    cmdHD.Parameters.AddWithValue("@pk", maPK);
                    cmdHD.Parameters.AddWithValue("@tn", maThuNgan);
                    cmdHD.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdHD.Parameters.AddWithValue("@tk", tienKham);
                    cmdHD.Parameters.AddWithValue("@txn", tienXN);
                    cmdHD.Parameters.AddWithValue("@tth", tienThuoc);
                    cmdHD.Parameters.AddWithValue("@gt", giamTru);
                    cmdHD.Parameters.AddWithValue("@pt", phuongThucTT);
                    cmdHD.ExecuteNonQuery();

                    // 4. Cập nhật phiếu khám sang Đã xuất viện
                    var cmdUpdatePK = new SqlCommand("UPDATE PhieuKhamBenh SET TrangThai=N'Đã xuất viện' WHERE MaPhieuKham=@pk", cn, tx);
                    cmdUpdatePK.Parameters.AddWithValue("@pk", maPK);
                    cmdUpdatePK.ExecuteNonQuery();

                    // 5. Cập nhật Toa thuốc sang Đã xuất thuốc
                    var cmdUpdateToa = new SqlCommand("UPDATE ToaThuoc SET TrangThai=N'Đã xuất thuốc' WHERE MaPhieuKham=@pk", cn, tx);
                    cmdUpdateToa.Parameters.AddWithValue("@pk", maPK);
                    cmdUpdateToa.ExecuteNonQuery();

                    // 6. Phòng CSKH nhập đánh giá hiệu quả, quy trách nhiệm bác sĩ và khóa hồ sơ đợt điều trị
                    string maTD = "TD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    var cmdTD = new SqlCommand(@"INSERT INTO TheoDoiSauDieuTri(MaTheoDoi,MaHoSo,MaPhieuKham,MaNVCSKH,NgayGhiNhan,DienBienSucKhoe,PhanUngPhuThuoc,DanhGiaHieuQua,TrachNhiemBacSi,TrangThai)
                                                 VALUES(@td,@hs,@pk,@cskh,@ngay,@db,@pup,@dg,@bs,N'Đã khóa hồ sơ')", cn, tx);
                    cmdTD.Parameters.AddWithValue("@td", maTD);
                    cmdTD.Parameters.AddWithValue("@hs", maHoSo);
                    cmdTD.Parameters.AddWithValue("@pk", maPK);
                    cmdTD.Parameters.AddWithValue("@cskh", maCSKH);
                    cmdTD.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdTD.Parameters.AddWithValue("@db", (object)dienBien ?? DBNull.Value);
                    cmdTD.Parameters.AddWithValue("@pup", (object)phanUngPhu ?? DBNull.Value);
                    cmdTD.Parameters.AddWithValue("@dg", (object)danhGiaHieuQua ?? DBNull.Value);
                    cmdTD.Parameters.AddWithValue("@bs", maBacSi);
                    cmdTD.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok(string.Format("Đã thanh toán viện phí xuất viện và CSKH đã khóa đợt điều trị cho Hồ sơ {0}!", maHoSo));
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi xuất viện & khóa hồ sơ: " + ex.Message);
                }
            }
        }

        // Đặt lịch hẹn khám định kỳ theo quý
        public KetQuaXuLy DatLichHenDinhKy(string maHoSo, string maCSKH, DateTime ngayGioHen, int quyKham, int namKham, string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maHoSo))
                return KetQuaXuLy.Fail("Chưa chọn hồ sơ bệnh án để đặt lịch hẹn.");

            try
            {
                string maLH = "LH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                Db.Execute(@"INSERT INTO LichHenKhamDinhKy(MaLichHen,MaHoSo,MaNVCSKH,NgayGioHen,QuyKham,NamKham,GhiChu,TrangThai)
                             VALUES(@lh,@hs,@cskh,@ngay,@quy,@nam,@gc,N'Đã đặt lịch')",
                    new SqlParameter("@lh", maLH),
                    new SqlParameter("@hs", maHoSo),
                    new SqlParameter("@cskh", maCSKH),
                    new SqlParameter("@ngay", ngayGioHen),
                    new SqlParameter("@quy", quyKham),
                    new SqlParameter("@nam", namKham),
                    new SqlParameter("@gc", (object)ghiChu ?? DBNull.Value));

                // Lấy số điện thoại và họ tên bệnh nhân để gửi SMS tự động
                var dtBN = Db.Query(@"SELECT b.HoTen, b.SoDienThoai FROM HoSoBenhAn h JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan WHERE h.MaHoSo=@hs", new SqlParameter("@hs", maHoSo));
                if (dtBN.Rows.Count > 0)
                {
                    string hoTen = dtBN.Rows[0]["HoTen"].ToString();
                    string sdt = dtBN.Rows[0]["SoDienThoai"].ToString();
                    sms.GuiTinNhanNhacLichHen(sdt, hoTen, ngayGioHen, quyKham, namKham);
                }

                return KetQuaXuLy.Ok(string.Format("Đã đặt lịch khám định kỳ Quý {0}/{1} và gửi tin nhắn SMS tới bệnh nhân!", quyKham, namKham));
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Lỗi đặt lịch hẹn: " + ex.Message); }
        }
    }
}
