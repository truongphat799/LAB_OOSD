using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangEShopping.Adapters;
using QuanLyCuaHangEShopping.Data;
using QuanLyCuaHangEShopping.Models;

namespace QuanLyCuaHangEShopping.Services
{
    public class DatHangService
    {
        readonly PaymentAdapter paymentAdapter = new PaymentAdapter();
        readonly EmailAdapter emailAdapter = new EmailAdapter();

        public DataTable LayKhachHang() { return Db.Query("SELECT * FROM KhachHang ORDER BY HoTen"); }
        public DataTable LayLoaiPhieu() { return Db.Query("SELECT * FROM LoaiPhieuDatHang ORDER BY MaLoaiPhieu"); }
        public DataTable LayKhuVuc() { return Db.Query("SELECT * FROM KhuVucGiaoHang ORDER BY MaKhuVuc"); }
        public DataTable LayLoaiThe() { return Db.Query("SELECT * FROM LoaiTheTinDung ORDER BY MaLoaiThe"); }
        public DataTable LayDonHang() { return Db.Query(@"SELECT d.*, k.HoTen AS TenKhach, n.HoTen AS TenNguoiNhan, l.TenLoaiPhieu 
                                                          FROM DonDatHang d 
                                                          JOIN KhachHang k ON d.MaKH=k.MaKH 
                                                          JOIN NguoiNhanHang n ON d.MaNguoiNhan=n.MaNguoiNhan 
                                                          JOIN LoaiPhieuDatHang l ON d.MaLoaiPhieu=l.MaLoaiPhieu 
                                                          ORDER BY d.NgayDat DESC"); }
        public DataTable LayChiTiet(string maDon) { return Db.Query("SELECT c.*, s.TenSP FROM ChiTietDonHang c JOIN SanPham s ON c.MaSP=s.MaSP WHERE c.MaDonHang=@d", new SqlParameter("@d", maDon)); }

        // Tính cước giao hàng kèm chính sách miễn cước (BR05, BR06, BR07)
        public decimal TinhChiPhiGiaoHang(string maKV, string maLoaiPhieu, decimal tongTienHang)
        {
            // BR06: Đơn từ 5.000.000 đ trở lên -> Miễn phí CPN trong ngày (LP03)
            if (tongTienHang >= 5000000 && maLoaiPhieu == "LP03") return 0;

            // BR05: Đơn từ 1.000.000 đ trở lên -> Miễn phí CPN (LP02)
            if (tongTienHang >= 1000000 && maLoaiPhieu == "LP02") return 0;

            // Tính cước theo bảng Phí giao hàng (Khu vực x Loại phiếu)
            object o = Db.Scalar("SELECT ChiPhi FROM PhiGiaoHang WHERE MaKhuVuc=@kv AND MaLoaiPhieu=@lp",
                new SqlParameter("@kv", maKV), new SqlParameter("@lp", maLoaiPhieu));

            return o == null ? 0 : Convert.ToDecimal(o);
        }

        // Tạo đơn đặt hàng và thanh toán bằng Transaction
        public KetQuaXuLy TaoDonHangVaThanhToan(
            string maDon, string maKH,
            string tenNguoiNhan, string diaChiNhan, string sdtNhan,
            string maLoaiPhieu, string maKV,
            string loaiThe, string soThe, string expDate, string csv, string tenChuThe,
            List<GioHangItem> dsItem)
        {
            if (string.IsNullOrWhiteSpace(maDon) || string.IsNullOrWhiteSpace(maKH) || dsItem == null || dsItem.Count == 0)
                return KetQuaXuLy.Fail("Thông tin đơn hàng chưa đầy đủ hoặc giỏ hàng trống.");

            if (string.IsNullOrWhiteSpace(tenNguoiNhan) || string.IsNullOrWhiteSpace(diaChiNhan) || string.IsNullOrWhiteSpace(sdtNhan))
                return KetQuaXuLy.Fail("Vui lòng nhập đầy đủ thông tin người nhận hàng.");

            decimal tongTienHang = 0;
            foreach (var item in dsItem) tongTienHang += item.ThanhTien;

            decimal phiGiaoHang = TinhChiPhiGiaoHang(maKV, maLoaiPhieu, tongTienHang);
            decimal tongTriGia = tongTienHang + phiGiaoHang;

            // Gọi Adapter xác minh thẻ tín dụng (OPS)
            var kqThe = paymentAdapter.XacMinhThe(loaiThe, soThe, expDate, csv, tongTriGia);
            if (!kqThe.ThanhCong) return KetQuaXuLy.Fail("Xác minh thẻ thất bại: " + kqThe.ThongBao);

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // A. Tạo người nhận hàng (BR08)
                    string maNguoiNhan = "NN" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    var cmdNN = new SqlCommand("INSERT INTO NguoiNhanHang VALUES(@m,@t,@dc,@sdt)", cn, tx);
                    cmdNN.Parameters.AddWithValue("@m", maNguoiNhan);
                    cmdNN.Parameters.AddWithValue("@t", tenNguoiNhan);
                    cmdNN.Parameters.AddWithValue("@dc", diaChiNhan);
                    cmdNN.Parameters.AddWithValue("@sdt", sdtNhan);
                    cmdNN.ExecuteNonQuery();

                    // B. Tạo đơn đặt hàng
                    var cmdDH = new SqlCommand(@"INSERT INTO DonDatHang(MaDonHang,MaKH,MaNguoiNhan,MaLoaiPhieu,NgayDat,TongTienHang,ChiPhiGiaoHang,TrangThai) 
                                                  VALUES(@md,@mkh,@mnn,@mlp,@ngay,@tth,@phi,N'Đã xác nhận')", cn, tx);
                    cmdDH.Parameters.AddWithValue("@md", maDon);
                    cmdDH.Parameters.AddWithValue("@mkh", maKH);
                    cmdDH.Parameters.AddWithValue("@mnn", maNguoiNhan);
                    cmdDH.Parameters.AddWithValue("@mlp", maLoaiPhieu);
                    cmdDH.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdDH.Parameters.AddWithValue("@tth", tongTienHang);
                    cmdDH.Parameters.AddWithValue("@phi", phiGiaoHang);
                    cmdDH.ExecuteNonQuery();

                    // C. Lưu chi tiết đơn hàng (Snapshot đơn giá - BR03)
                    foreach (var item in dsItem)
                    {
                        var cmdCT = new SqlCommand("INSERT INTO ChiTietDonHang(MaDonHang,MaSP,SoLuong,DonGia) VALUES(@md,@sp,@sl,@g)", cn, tx);
                        cmdCT.Parameters.AddWithValue("@md", maDon);
                        cmdCT.Parameters.AddWithValue("@sp", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@sl", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@g", item.DonGia);
                        cmdCT.ExecuteNonQuery();
                    }

                    // D. Lưu thông tin thanh toán (Chỉ lưu mặt nạ thẻ, KHÔNG lưu CSV - BR12)
                    string soTheAn = "************" + soThe.Substring(soThe.Length - 4);
                    string maTT = "TT" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    var cmdGetThe = new SqlCommand("SELECT MaLoaiThe FROM LoaiTheTinDung WHERE TenLoaiThe=@ten", cn, tx);
                    cmdGetThe.Parameters.AddWithValue("@ten", loaiThe);
                    string maLoaiThe = Convert.ToString(cmdGetThe.ExecuteScalar());

                    var cmdTT = new SqlCommand(@"INSERT INTO ThanhToan(MaThanhToan,MaDonHang,MaLoaiThe,NgayThanhToan,SoTheAn,TenChuThe,NgayHetHan,SoTien,TrangThai)
                                                 VALUES(@mtt,@md,@mlt,@ngay,@the,@chu,@exp,@tien,N'Thành công')", cn, tx);
                    cmdTT.Parameters.AddWithValue("@mtt", maTT);
                    cmdTT.Parameters.AddWithValue("@md", maDon);
                    cmdTT.Parameters.AddWithValue("@mlt", maLoaiThe);
                    cmdTT.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdTT.Parameters.AddWithValue("@the", soTheAn);
                    cmdTT.Parameters.AddWithValue("@chu", tenChuThe);
                    cmdTT.Parameters.AddWithValue("@exp", expDate);
                    cmdTT.Parameters.AddWithValue("@tien", tongTriGia);
                    cmdTT.ExecuteNonQuery();

                    tx.Commit();

                    // Gửi email xác nhận qua EmailAdapter (nếu có email)
                    string email = Convert.ToString(Db.Scalar("SELECT Email FROM KhachHang WHERE MaKH=@m", new SqlParameter("@m", maKH)));
                    emailAdapter.GuiEmailXacNhan(email, maDon, tongTriGia);

                    return KetQuaXuLy.Ok($"Đặt hàng thành công! Đơn hàng {maDon} đã được thanh toán và xác nhận.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi xử lý đơn hàng: " + ex.Message);
                }
            }
        }
    }
}