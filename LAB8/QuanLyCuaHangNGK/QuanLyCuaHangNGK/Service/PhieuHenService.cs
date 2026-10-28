using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class PhieuHenService
    {
        public DataTable LayPhieuHen()
        {
            return Db.Query(@"
                SELECT p.MaPhieuHen, p.MaHD, k.HoTen AS TenKhach, k.DiaChi, k.SoDienThoai,
                       p.NgayLap, p.NgayHenGiao, p.NgayGiaoThucTe, p.DotHen, p.TrangThai,
                       v.HoTen AS NhanVienLap
                FROM PhieuHenGiaoHang p
                JOIN HoaDon h ON p.MaHD = h.MaHD
                JOIN KhachHang k ON h.MaKH = k.MaKH
                JOIN NhanVien v ON p.MaNVLap = v.MaNV
                ORDER BY p.NgayHenGiao");
        }

        public DataTable LayChiTietPhieuHen(string maPH)
        {
            return Db.Query(@"
                SELECT c.MaNGK, n.TenNGK, n.DonViTinh, c.SoLuongHen, c.SoLuongDaGiao,
                       (c.SoLuongHen - c.SoLuongDaGiao) AS ConLai, c.GhiChu, n.SoLuongTon AS TonKhoHienTai
                FROM ChiTietPhieuHen c
                JOIN NuocGiaiKhat n ON c.MaNGK = n.MaNGK
                WHERE c.MaPhieuHen = @ph",
                new SqlParameter("@ph", maPH));
        }

        public KetQuaXuLy GiaoHangDot(string maPH, string maNGK, int slGiao)
        {
            if (slGiao <= 0)
                return KetQuaXuLy.Fail("Số lượng giao phải lớn hơn 0.");

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    // 1. Kiểm tra tồn kho
                    int tonKho = Convert.ToInt32(new SqlCommand(string.Format("SELECT SoLuongTon FROM NuocGiaiKhat WHERE MaNGK = '{0}'", maNGK), cn, tr).ExecuteScalar());
                    if (tonKho < slGiao)
                        return KetQuaXuLy.Fail(string.Format("Số lượng trong kho ({0}) không đủ để giao ({1}). Hãy nhập thêm hàng trước khi giao.", tonKho, slGiao));

                    // 2. Cập nhật số lượng đã giao
                    using (var cmd = new SqlCommand(@"
                        UPDATE ChiTietPhieuHen 
                        SET SoLuongDaGiao = SoLuongDaGiao + @sl 
                        WHERE MaPhieuHen = @ph AND MaNGK = @ngk", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@sl", slGiao);
                        cmd.Parameters.AddWithValue("@ph", maPH);
                        cmd.Parameters.AddWithValue("@ngk", maNGK);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Trừ tồn kho
                    using (var cmd = new SqlCommand(@"
                        UPDATE NuocGiaiKhat 
                        SET SoLuongTon = SoLuongTon - @sl 
                        WHERE MaNGK = @ngk", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@sl", slGiao);
                        cmd.Parameters.AddWithValue("@ngk", maNGK);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Kiểm tra xem toàn bộ phiếu hẹn đã giao đủ chưa
                    int conThieu = Convert.ToInt32(new SqlCommand(@"
                        SELECT ISNULL(SUM(SoLuongHen - SoLuongDaGiao), 0) 
                        FROM ChiTietPhieuHen 
                        WHERE MaPhieuHen = @ph", cn, tr)
                    {
                        Parameters = { new SqlParameter("@ph", maPH) }
                    }.ExecuteScalar());

                    if (conThieu <= 0)
                    {
                        using (var cmd = new SqlCommand(@"
                            UPDATE PhieuHenGiaoHang 
                            SET TrangThai = N'Đã giao đủ', NgayGiaoThucTe = GETDATE() 
                            WHERE MaPhieuHen = @ph", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@ph", maPH);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var cmd = new SqlCommand(@"
                            UPDATE PhieuHenGiaoHang 
                            SET TrangThai = N'Đang giao' 
                            WHERE MaPhieuHen = @ph", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@ph", maPH);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok(conThieu <= 0 ? "Giao hàng hoàn tất toàn bộ phiếu hẹn!" : "Giao hàng đợt thành công! Phiếu hẹn vẫn còn hàng cần giao tiếp.");
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return KetQuaXuLy.Fail("Lỗi cập nhật giao hàng: " + ex.Message);
                }
            }
        }
    }
}
