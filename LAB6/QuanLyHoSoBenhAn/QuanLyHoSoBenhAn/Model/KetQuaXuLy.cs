using System;

namespace QuanLyHoSoBenhAn.Models
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public object DuLieu { get; set; }

        public static KetQuaXuLy Ok(string msg = "Thao tác thành công.", object data = null)
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = msg, DuLieu = data };
        }

        public static KetQuaXuLy Fail(string msg)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = msg, DuLieu = null };
        }
    }

    public class ToaThuocItem
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string HoatChat { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string LieuDung { get; set; }
        public string CachDung { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }
    }

    public class XetNghiemItem
    {
        public string MaDichVuXN { get; set; }
        public string TenDichVuXN { get; set; }
        public string LoaiXN { get; set; }
        public decimal DonGia { get; set; }
        public string PhongThucHien { get; set; }
        public string TriSoDo { get; set; }
        public string KetLuan { get; set; }
    }

    public class BenhNhanItem
    {
        public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string AnhChup3x4 { get; set; }
        public string MaHoSo { get; set; }
    }
}
