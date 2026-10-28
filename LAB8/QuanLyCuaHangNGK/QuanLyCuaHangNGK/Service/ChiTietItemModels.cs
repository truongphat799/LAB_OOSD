using System;

namespace QuanLyCuaHangNGK.Services
{
    public class ChiTietDatItem
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongDat { get; set; }
        public decimal DonGiaDat { get; set; }
        public decimal ThanhTien 
        { 
            get { return SoLuongDat * DonGiaDat; } 
        }
    }

    public class ChiTietBanItem
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongMua { get; set; }
        public decimal DonGiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public int SoLuongGiaoNgay { get; set; }
        public int SoLuongHenGiao { get; set; }
        public decimal ThanhTien 
        { 
            get { return SoLuongMua * DonGiaBan; } 
        }
    }

    public class ChiTietGiaoItem
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public int SoLuongGiao { get; set; }
        public decimal DonGiaGiao { get; set; }
        public decimal ThanhTien 
        { 
            get { return SoLuongGiao * DonGiaGiao; } 
        }
    }
}
