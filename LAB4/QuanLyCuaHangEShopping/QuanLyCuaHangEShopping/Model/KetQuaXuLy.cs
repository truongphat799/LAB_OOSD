using System;

namespace QuanLyCuaHangEShopping.Models
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string msg = "Thao tác thành công.")
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = msg };
        }

        public static KetQuaXuLy Fail(string msg)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = msg };
        }
    }

    public class GioHangItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }
    }
}