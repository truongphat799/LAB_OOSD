using System;

namespace QuanLyDuLich.Models
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
}