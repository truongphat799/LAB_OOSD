using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Adapters;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Services
{
    public class ToaThuocService
    {
        readonly SMSNotificationAdapter sms = new SMSNotificationAdapter();

        public DataTable LayToaThuoc(string maPhieuKham)
        {
            return Db.Query(@"SELECT t.*, u.HoTen AS TenBacSi 
                              FROM ToaThuoc t 
                              JOIN NguoiDung u ON t.MaBacSi=u.MaNguoiDung 
                              WHERE t.MaPhieuKham=@pk", new SqlParameter("@pk", maPhieuKham));
        }

        public DataTable LayChiTietToa(string maToa)
        {
            return Db.Query(@"SELECT c.*, th.TenThuoc, th.HoatChat, th.DonViTinh 
                              FROM ChiTietToaThuoc c 
                              JOIN Thuoc th ON c.MaThuoc=th.MaThuoc 
                              WHERE c.MaToaThuoc=@t", new SqlParameter("@t", maToa));
        }

        // TRANSACTION 2: LẬP TOA THUỐC, KIỂM TRA DỊ ỨNG & CẬP NHẬT TRỪ TỒN KHO DƯỢC
        public KetQuaXuLy LapToaThuocVaTruTonKho(
            string maToa, string maPhieuKham, string maBS,
            string chanDoan, string loiDan, DateTime? ngayTaiKham,
            List<ToaThuocItem> dsThuoc)
        {
            if (string.IsNullOrWhiteSpace(maToa) || string.IsNullOrWhiteSpace(maPhieuKham) || dsThuoc == null || dsThuoc.Count == 0)
                return KetQuaXuLy.Fail("Thông tin toa thuốc chưa đầy đủ hoặc danh sách thuốc trống.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Lấy thông tin đợt khám và tiền sử dị ứng thuốc của bệnh nhân
                    var cmdHS = new SqlCommand(@"SELECT h.MaHoSo, h.TienSuDiUngThuoc, b.HoTen, b.SoDienThoai
                                                 FROM PhieuKhamBenh p
                                                 JOIN HoSoBenhAn h ON p.MaHoSo=h.MaHoSo
                                                 JOIN BenhNhan b ON h.MaBenhNhan=b.MaBenhNhan
                                                 WHERE p.MaPhieuKham=@pk", cn, tx);
                    cmdHS.Parameters.AddWithValue("@pk", maPhieuKham);
                    string tienSuDiUng = "";
                    string hoTenBN = "";
                    string sdtBN = "";

                    using (var reader = cmdHS.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tienSuDiUng = reader["TienSuDiUngThuoc"].ToString();
                            hoTenBN = reader["HoTen"].ToString();
                            sdtBN = reader["SoDienThoai"].ToString();
                        }
                        else
                        {
                            return KetQuaXuLy.Fail("Không tìm thấy thông tin phiếu khám bệnh chỉ định!");
                        }
                    }

                    // 2. Kiểm tra an toàn y khoa và kiểm tra tồn kho cho TỪNG LOẠI THUỐC
                    foreach (var item in dsThuoc)
                    {
                        var cmdThuoc = new SqlCommand("SELECT TenThuoc, HoatChat, SoLuongTon, DonGia FROM Thuoc WITH (UPDLOCK, ROWLOCK) WHERE MaThuoc=@m", cn, tx);
                        cmdThuoc.Parameters.AddWithValue("@m", item.MaThuoc);

                        using (var reader = cmdThuoc.ExecuteReader())
                        {
                            if (!reader.Read())
                                return KetQuaXuLy.Fail(string.Format("Mã thuốc {0} không tồn tại trong danh mục dược!", item.MaThuoc));

                            string tenThuoc = reader["TenThuoc"].ToString();
                            string hoatChat = reader["HoatChat"].ToString();
                            int tonKho = Convert.ToInt32(reader["SoLuongTon"]);
                            decimal gia = Convert.ToDecimal(reader["DonGia"]);

                            item.TenThuoc = tenThuoc;
                            item.HoatChat = hoatChat;
                            item.DonGia = gia;

                            // KIỂM TRA DỊ ỨNG: Ngăn chặn sốc phản vệ y khoa (ví dụ dị ứng Penicillin mà kê Amoxicillin)
                            if ((tienSuDiUng.IndexOf("Penicillin", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 tienSuDiUng.IndexOf("Beta-lactam", StringComparison.OrdinalIgnoreCase) >= 0) &&
                                (tenThuoc.IndexOf("Amoxicillin", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 hoatChat.IndexOf("Amoxicillin", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 hoatChat.IndexOf("Penicillin", StringComparison.OrdinalIgnoreCase) >= 0))
                            {
                                return KetQuaXuLy.Fail(string.Format("CẢNH BÁO AN TOÀN Y KHOA: Bệnh nhân {0} có tiền sử dị ứng với thuốc/hoạt chất {1}. Giao dịch đã bị chặn để bảo vệ an toàn tính mạng bệnh nhân!",
                                    hoTenBN, tenThuoc));
                            }

                            // KIỂM TRA TỒN KHO DƯỢC
                            if (tonKho < item.SoLuong)
                            {
                                return KetQuaXuLy.Fail(string.Format("Thuốc \"{0}\" không đủ tồn kho (Còn {1}, cần kê {2})!", tenThuoc, tonKho, item.SoLuong));
                            }
                        }
                    }

                    // 3. Thêm Toa thuốc (Master)
                    var cmdToa = new SqlCommand(@"INSERT INTO ToaThuoc(MaToaThuoc,MaPhieuKham,MaBacSi,NgayKeToa,ChanDoan,LoiDanBacSi,NgayTaiKham,TrangThai)
                                                  VALUES(@toa,@pk,@bs,@ngay,@cd,@ld,@tk,N'Chưa xuất thuốc')", cn, tx);
                    cmdToa.Parameters.AddWithValue("@toa", maToa);
                    cmdToa.Parameters.AddWithValue("@pk", maPhieuKham);
                    cmdToa.Parameters.AddWithValue("@bs", maBS);
                    cmdToa.Parameters.AddWithValue("@ngay", DateTime.Now);
                    cmdToa.Parameters.AddWithValue("@cd", chanDoan);
                    cmdToa.Parameters.AddWithValue("@ld", (object)loiDan ?? DBNull.Value);
                    cmdToa.Parameters.AddWithValue("@tk", ngayTaiKham.HasValue ? (object)ngayTaiKham.Value.Date : DBNull.Value);
                    cmdToa.ExecuteNonQuery();

                    // 4. Thêm từng dòng Chi tiết toa thuốc & Trừ tồn kho dược
                    foreach (var item in dsThuoc)
                    {
                        var cmdCT = new SqlCommand(@"INSERT INTO ChiTietToaThuoc(MaToaThuoc,MaThuoc,SoLuong,DonGia,LieuDung,CachDung)
                                                     VALUES(@toa,@m,@sl,@gia,@ld,@cd)", cn, tx);
                        cmdCT.Parameters.AddWithValue("@toa", maToa);
                        cmdCT.Parameters.AddWithValue("@m", item.MaThuoc);
                        cmdCT.Parameters.AddWithValue("@sl", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@gia", item.DonGia);
                        cmdCT.Parameters.AddWithValue("@ld", item.LieuDung);
                        cmdCT.Parameters.AddWithValue("@cd", item.CachDung);
                        cmdCT.ExecuteNonQuery();

                        // Trừ tồn kho dược
                        var cmdTruKho = new SqlCommand("UPDATE Thuoc SET SoLuongTon=SoLuongTon-@sl WHERE MaThuoc=@m", cn, tx);
                        cmdTruKho.Parameters.AddWithValue("@sl", item.SoLuong);
                        cmdTruKho.Parameters.AddWithValue("@m", item.MaThuoc);
                        cmdTruKho.ExecuteNonQuery();
                    }

                    // 5. Cập nhật phiếu khám sang trạng thái Đã kê toa
                    var cmdPK = new SqlCommand(@"UPDATE PhieuKhamBenh 
                                                 SET ChanDoanXacDinh=@cd, TrangThai=N'Đã kê toa' 
                                                 WHERE MaPhieuKham=@pk", cn, tx);
                    cmdPK.Parameters.AddWithValue("@cd", chanDoan);
                    cmdPK.Parameters.AddWithValue("@pk", maPhieuKham);
                    cmdPK.ExecuteNonQuery();

                    tx.Commit();

                    // Gửi tin nhắn SMS thông báo toa thuốc
                    sms.GuiTinNhanToaThuoc(sdtBN, hoTenBN, maToa);

                    return KetQuaXuLy.Ok(string.Format("Kê toa thuốc {0} thành công và đã tự động trừ tồn kho dược!", maToa));
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi kê toa thuốc: " + ex.Message);
                }
            }
        }
    }
}
