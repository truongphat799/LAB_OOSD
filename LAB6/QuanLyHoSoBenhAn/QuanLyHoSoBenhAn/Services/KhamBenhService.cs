using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Services
{
    public class KhamBenhService
    {
        public DataTable LayDanhSachChoKham()
        {
            return Db.Query(@"SELECT p.*, h.MaBenhNhan, b.HoTen, b.NgaySinh, b.GioiTinh, b.SoDienThoai, k.TenKhoa, u.HoTen AS TenBacSi
                              FROM PhieuKhamBenh p
                              JOIN HoSoBenhAn h ON p.MaHoSo=h.MaHoSo
                              JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                              JOIN KhoaDieuTri k ON p.MaKhoa=k.MaKhoa
                              JOIN NguoiDung u ON p.MaBacSi=u.MaNguoiDung
                              WHERE p.TrangThai IN (N'Đang khám', N'Chờ xét nghiệm', N'Đã có kết quả', N'Đã kê toa')
                              ORDER BY p.NgayGioKham DESC");
        }

        public DataTable LayLichSuKham(string maHoSo)
        {
            return Db.Query(@"SELECT p.*, k.TenKhoa, u.HoTen AS TenBacSi
                              FROM PhieuKhamBenh p
                              JOIN KhoaDieuTri k ON p.MaKhoa=k.MaKhoa
                              JOIN NguoiDung u ON p.MaBacSi=u.MaNguoiDung
                              WHERE p.MaHoSo=@hs
                              ORDER BY p.NgayGioKham DESC", new SqlParameter("@hs", maHoSo));
        }

        public DataTable LayChiDinhVaKetQuaXN(string maPhieuKham)
        {
            return Db.Query(@"SELECT c.*, d.TenDichVuXN, d.LoaiXN, d.DonGia, cd.NgayChiDinh, u.HoTen AS TenKTV
                              FROM ChiTietKetQuaXN c
                              JOIN PhieuChiDinhXN cd ON c.MaPhieuCD=cd.MaPhieuCD
                              JOIN DichVuXetNghiem d ON c.MaDichVuXN=d.MaDichVuXN
                              LEFT JOIN NguoiDung u ON c.MaKTVThucHien=u.MaNguoiDung
                              WHERE cd.MaPhieuKham=@pk
                              ORDER BY c.MaKetQua", new SqlParameter("@pk", maPhieuKham));
        }

        // Tạo đợt khám bệnh mới (thêm trang khám vào hồ sơ bệnh án)
        public KetQuaXuLy TaoPhieuKham(
            string maPK, string maHoSo, string maBS, string maKhoa,
            string trieuChung, decimal? thanNhiet, string huyetAp, int? mach,
            decimal? chieuCao, decimal? canNang, string loaiKham, string chanDoanSoBo)
        {
            if (string.IsNullOrWhiteSpace(maPK) || string.IsNullOrWhiteSpace(maHoSo) || string.IsNullOrWhiteSpace(maBS))
                return KetQuaXuLy.Fail("Thông tin phiếu khám chưa đầy đủ.");

            try
            {
                Db.Execute(@"INSERT INTO PhieuKhamBenh(MaPhieuKham,MaHoSo,MaBacSi,MaKhoa,NgayGioKham,TrieuChung,ThanNhiet,HuyetAp,Mach,ChieuCao,CanNang,ChanDoanSoBo,LoaiKham,TrangThai)
                             VALUES(@pk,@hs,@bs,@khoa,@ngay,@tc,@tn,@ha,@m,@cc,@cn,@cdsb,@loai,N'Đang khám')",
                    new SqlParameter("@pk", maPK),
                    new SqlParameter("@hs", maHoSo),
                    new SqlParameter("@bs", maBS),
                    new SqlParameter("@khoa", maKhoa),
                    new SqlParameter("@ngay", DateTime.Now),
                    new SqlParameter("@tc", trieuChung),
                    new SqlParameter("@tn", (object)thanNhiet ?? DBNull.Value),
                    new SqlParameter("@ha", (object)huyetAp ?? DBNull.Value),
                    new SqlParameter("@m", (object)mach ?? DBNull.Value),
                    new SqlParameter("@cc", (object)chieuCao ?? DBNull.Value),
                    new SqlParameter("@cn", (object)canNang ?? DBNull.Value),
                    new SqlParameter("@cdsb", (object)chanDoanSoBo ?? DBNull.Value),
                    new SqlParameter("@loai", loaiKham));

                return KetQuaXuLy.Ok(string.Format("Đã tạo phiếu khám bệnh {0} thành công.", maPK), maPK);
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Lỗi tạo phiếu khám: " + ex.Message); }
        }

        // Bác sĩ chỉ định cận lâm sàng / xét nghiệm
        public KetQuaXuLy ChiDinhXetNghiem(string maPK, string maBS, string yeuCau, List<string> dsMaXN)
        {
            if (string.IsNullOrWhiteSpace(maPK) || dsMaXN == null || dsMaXN.Count == 0)
                return KetQuaXuLy.Fail("Vui lòng chọn ít nhất một dịch vụ xét nghiệm.");

            string maPCD = "PCD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Tạo phiếu chỉ định
                    var cmdCD = new SqlCommand(@"INSERT INTO PhieuChiDinhXN(MaPhieuCD,MaPhieuKham,MaBacSi,NgayChiDinh,YeuCauXN,TrangThai)
                                                 VALUES(@pcd,@pk,@bs,@ngay,@yc,N'Chờ thực hiện')", cn, tx);
                    cmdCD.Parameters.AddWithValue("@pcd", maPCD);
                    cmdCD.Parameters.AddWithValue("@pk", maPK);
                    cmdCD.Parameters.AddWithValue("@bs", maBS);
                    cmdCD.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdCD.Parameters.AddWithValue("@yc", (object)yeuCau ?? DBNull.Value);
                    cmdCD.ExecuteNonQuery();

                    // 2. Thêm từng xét nghiệm vào Chi tiết
                    int idx = 1;
                    foreach (var maXN in dsMaXN)
                    {
                        string maKQ = string.Format("KQ{0}_{1}", DateTime.Now.ToString("yyMMddHHmmss"), idx++);
                        var cmdCT = new SqlCommand(@"INSERT INTO ChiTietKetQuaXN(MaKetQua,MaPhieuCD,MaDichVuXN,TrangThai)
                                                     VALUES(@kq,@pcd,@mxn,N'Chưa có kết quả')", cn, tx);
                        cmdCT.Parameters.AddWithValue("@kq", maKQ);
                        cmdCT.Parameters.AddWithValue("@pcd", maPCD);
                        cmdCT.Parameters.AddWithValue("@mxn", maXN);
                        cmdCT.ExecuteNonQuery();
                    }

                    // 3. Đổi trạng thái phiếu khám sang Chờ xét nghiệm
                    var cmdPK = new SqlCommand("UPDATE PhieuKhamBenh SET TrangThai=N'Chờ xét nghiệm' WHERE MaPhieuKham=@pk", cn, tx);
                    cmdPK.Parameters.AddWithValue("@pk", maPK);
                    cmdPK.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã gửi chỉ định xét nghiệm cận lâm sàng thành công!");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi chỉ định xét nghiệm: " + ex.Message);
                }
            }
        }

        // Cập nhật kết quả xét nghiệm (Kỹ thuật viên xét nghiệm trả kết quả)
        public KetQuaXuLy CapNhatKetQuaXN(string maKetQua, string triSo, string thamChieu, string ketLuan, string maKTV)
        {
            try
            {
                Db.Execute(@"UPDATE ChiTietKetQuaXN 
                             SET TriSoDo=@ts, KhoangThamChieu=@tc, KetLuan=@kl, MaKTVThucHien=@ktv, NgayGioTraKQ=@ngay, TrangThai=N'Đã duyệt'
                             WHERE MaKetQua=@kq",
                    new SqlParameter("@ts", triSo),
                    new SqlParameter("@tc", thamChieu),
                    new SqlParameter("@kl", ketLuan),
                    new SqlParameter("@ktv", maKTV),
                    new SqlParameter("@ngay", DateTime.Now),
                    new SqlParameter("@kq", maKetQua));

                return KetQuaXuLy.Ok("Đã cập nhật kết quả xét nghiệm thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}
