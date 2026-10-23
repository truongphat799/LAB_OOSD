using System;

namespace QuanLyNhanSu.Model
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

    public class NguoiDungHienTai
    {
        private static string _maNguoiDung = "ND01";
        private static string _tenDangNhap = "giamdoc";
        private static string _hoTen = "Trương Gia Phát (Tổng Giám Đốc)";
        private static string _vaiTro = "GIAM_DOC";
        private static string _maPhongBan = "PB_BGD";

        public static string MaNguoiDung { get { return _maNguoiDung; } set { _maNguoiDung = value; } }
        public static string TenDangNhap { get { return _tenDangNhap; } set { _tenDangNhap = value; } }
        public static string HoTen { get { return _hoTen; } set { _hoTen = value; } }
        public static string VaiTro { get { return _vaiTro; } set { _vaiTro = value; } }
        public static string MaPhongBan { get { return _maPhongBan; } set { _maPhongBan = value; } }
    }

    public class NhanVienItem
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string TrangThai { get; set; }
    }

    public class LuongThangItem
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal PhuCapChucVu { get; set; }
        public decimal PhuCapLuong { get; set; }
        public decimal PhuCapDocHai { get; set; }
        public decimal SoCongThucTe { get; set; }
        public decimal LuongThoiGian { get; set; }
        public decimal TongGioPhuTroi { get; set; }
        public decimal TienPhuTroi { get; set; }
        public decimal TienKhenThuong { get; set; }
        public decimal TienTrichBaoHiem { get; set; }
        public decimal TienKyLuatPhat { get; set; }
        public decimal TongThuNhap { get; set; }
        public decimal TongTrichTru { get; set; }
        public decimal LuongThucLanh { get; set; }
    }
}
