using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;
using QuanLyDuLich.Models;

namespace QuanLyDuLich.Services
{
    public class BanVeKhachLeService
    {
        public DataTable LayDanhSachVe()
        {
            return Db.Query(@"SELECT v.SoVe, v.MaChuyen, t.TenTour, k.HoTen AS TenKhach, k.SoDienThoai, 
                                     d.TenDiemDon, b.TenDiemBanVe, v.NgayXuatVe, v.GiaVe, v.DaThanhToan
                              FROM VeDuLich v
                              JOIN ChuyenDuLich c ON v.MaChuyen = c.MaChuyen
                              JOIN TourDuLich t ON c.MaTour = t.MaTour
                              JOIN KhachHang k ON v.MaKhachHang = k.MaKhachHang
                              JOIN DiemDon d ON v.MaDiemDon = d.MaDiemDon
                              JOIN DiemBanVe b ON v.MaDiemBanVe = b.MaDiemBanVe
                              ORDER BY v.NgayXuatVe DESC");
        }

        public DataTable LayChuyenKhaDung()
        {
            return Db.Query(@"SELECT c.MaChuyen, c.MaTour, t.TenTour, t.DonGiaKhach, c.NgayDi, c.NgayVe, 
                                     (c.SoChoToiDa - c.SoChoDaDat) AS SoChoTrong
                              FROM ChuyenDuLich c
                              JOIN TourDuLich t ON c.MaTour = t.MaTour
                              WHERE c.TrangThai = N'Còn chỗ' AND (c.SoChoToiDa - c.SoChoDaDat) > 0
                              ORDER BY c.NgayDi");
        }

        public DataTable LayKhachLe()
        {
            return Db.Query("SELECT MaKhachHang, HoTen, SoDienThoai, DiaChi FROM KhachHang WHERE LoaiKhach = 'LE' ORDER BY HoTen");
        }

        // Bán vé cho khách lẻ bám sát BR01, BR05
        public KetQuaXuLy BanVeKhachLe(
            string maVe, string maChuyen, string maKH,
            string maDiemBanVe, string maDiemDon,
            int soLuongVe, decimal donGiaVe)
        {
            // BR01: Khách lẻ phải mua ít hơn 12 vé
            if (soLuongVe >= 12 || soLuongVe <= 0)
                return KetQuaXuLy.Fail("Quy định (BR01): Khách lẻ chỉ được mua từ 1 đến dưới 12 vé (>= 12 vé tính là khách đoàn).");

            if (string.IsNullOrWhiteSpace(maVe) || string.IsNullOrWhiteSpace(maChuyen) || string.IsNullOrWhiteSpace(maKH))
                return KetQuaXuLy.Fail("Vui lòng nhập đầy đủ thông tin vé và khách hàng.");

            // Kiểm tra số chỗ trống trên chuyến
            DataTable dtChuyen = Db.Query("SELECT SoChoToiDa, SoChoDaDat FROM ChuyenDuLich WHERE MaChuyen = @c",
                new SqlParameter("@c", maChuyen));

            if (dtChuyen.Rows.Count == 0) return KetQuaXuLy.Fail("Chuyến du lịch không tồn tại.");

            int choToiDa = Convert.ToInt32(dtChuyen.Rows[0]["SoChoToiDa"]);
            int choDaDat = Convert.ToInt32(dtChuyen.Rows[0]["SoChoDaDat"]);
            int choConLai = choToiDa - choDaDat;

            if (soLuongVe > choConLai)
                return KetQuaXuLy.Fail($"Chuyến đi chỉ còn trống {choConLai} chỗ, không đủ cho {soLuongVe} vé.");

            try
            {
                decimal tongTien = donGiaVe * soLuongVe;

                // Lưu các vé (với DaThanhToan = 1 bắt buộc theo BR05)
                for (int i = 1; i <= soLuongVe; i++)
                {
                    string maVeItem = (soLuongVe == 1) ? maVe : $"{maVe}_{i}";
                    Db.Execute(@"INSERT INTO VeDuLich(SoVe, MaChuyen, MaKhachHang, MaDiemBanVe, MaDiemDon, NgayXuatVe, GiaVe, DaThanhToan)
                                 VALUES(@v, @mc, @kh, @bv, @dd, GETDATE(), @gv, 1)",
                        new SqlParameter("@v", maVeItem.Trim()),
                        new SqlParameter("@mc", maChuyen.Trim()),
                        new SqlParameter("@kh", maKH.Trim()),
                        new SqlParameter("@bv", maDiemBanVe.Trim()),
                        new SqlParameter("@dd", maDiemDon.Trim()),
                        new SqlParameter("@gv", donGiaVe));
                }

                // Cập nhật số chỗ đã đặt trên chuyến
                Db.Execute("UPDATE ChuyenDuLich SET SoChoDaDat = SoChoDaDat + @sl WHERE MaChuyen = @mc",
                    new SqlParameter("@sl", soLuongVe),
                    new SqlParameter("@mc", maChuyen));

                // Nếu đầy chỗ thì cập nhật trạng thái
                if (choDaDat + soLuongVe >= choToiDa)
                {
                    Db.Execute("UPDATE ChuyenDuLich SET TrangThai = N'Hết chỗ' WHERE MaChuyen = @mc",
                        new SqlParameter("@mc", maChuyen));
                }

                return KetQuaXuLy.Ok($"Quy định (BR05): Xuất {soLuongVe} vé thành công. Đã thu đủ 100% tiền vé: {tongTien:N0} đ.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi bán vé: " + ex.Message);
            }
        }
    }
}
