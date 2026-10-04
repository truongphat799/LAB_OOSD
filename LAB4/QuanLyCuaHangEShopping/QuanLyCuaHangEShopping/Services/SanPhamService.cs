using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangEShopping.Data;
using QuanLyCuaHangEShopping.Models;

namespace QuanLyCuaHangEShopping.Services
{
    public class SanPhamService
    {
        public DataTable LaySanPham()
        {
            return Db.Query(@"SELECT s.*, n.TenNhom 
                              FROM SanPham s 
                              JOIN NhomSanPham n ON s.MaNhom=n.MaNhom 
                              ORDER BY s.MaSP");
        }

        public DataTable LaySanPhamTheoNhom(string maNhom)
        {
            return Db.Query(@"SELECT s.*, n.TenNhom 
                              FROM SanPham s 
                              JOIN NhomSanPham n ON s.MaNhom=n.MaNhom 
                              WHERE s.MaNhom=@m 
                              ORDER BY s.MaSP", new SqlParameter("@m", maNhom));
        }

        public KetQuaXuLy ThemSanPham(string ma, string nhom, string ten, string nsx, decimal gia, string tinhTrang, string moTa, string thongSo)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(nhom) || string.IsNullOrWhiteSpace(ten) || gia < 0)
                return KetQuaXuLy.Fail("Thông tin sản phẩm không hợp lệ.");

            try
            {
                Db.Execute(@"INSERT INTO SanPham(MaSP,MaNhom,TenSP,NhaSanXuat,GiaHienHanh,TinhTrang,MoTa,ThongSoKyThuat) 
                             VALUES(@m,@nhom,@ten,@nsx,@gia,@tt,@mt,@ts)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@nhom", nhom),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@nsx", nsx),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@tt", tinhTrang),
                    new SqlParameter("@mt", (object)moTa ?? DBNull.Value),
                    new SqlParameter("@ts", (object)thongSo ?? DBNull.Value));

                return KetQuaXuLy.Ok("Đã thêm sản phẩm thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}