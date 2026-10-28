using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class NhapHangService
    {
        public DataTable LayDonDatHang()
        {
            return Db.Query(@"
                SELECT d.MaDDH, u.TenNCC, v.HoTen AS NguoiLap, d.NgayDat, d.NgayNhanDuKien, 
                       d.TongTienDat, d.SoDotGiaoDaNhan, d.TrangThai, d.MaNCC, d.MaNVLap
                FROM DonDatHang d
                JOIN NhaCungUng u ON d.MaNCC = u.MaNCC
                JOIN NhanVien v ON d.MaNVLap = v.MaNV
                ORDER BY d.NgayDat DESC");
        }

        public DataTable LayChiTietDonDat(string maDDH)
        {
            return Db.Query(@"
                SELECT c.MaNGK, n.TenNGK, n.DonViTinh, c.SoLuongDat, c.DonGiaDat, c.ThanhTien,
                       ISNULL((
                           SELECT SUM(g.SoLuongGiao) 
                           FROM ChiTietPhieuGiao g 
                           JOIN PhieuGiaoHang p ON g.MaPGH = p.MaPGH 
                           WHERE p.MaDDH = c.MaDDH AND g.MaNGK = c.MaNGK
                       ), 0) AS DaNhan,
                       (c.SoLuongDat - ISNULL((
                           SELECT SUM(g.SoLuongGiao) 
                           FROM ChiTietPhieuGiao g 
                           JOIN PhieuGiaoHang p ON g.MaPGH = p.MaPGH 
                           WHERE p.MaDDH = c.MaDDH AND g.MaNGK = c.MaNGK
                       ), 0)) AS ConThieu
                FROM ChiTietDonDatHang c
                JOIN NuocGiaiKhat n ON c.MaNGK = n.MaNGK
                WHERE c.MaDDH = @ma",
                new SqlParameter("@ma", maDDH));
        }

        public KetQuaXuLy TaoDonDatHang(string maDDH, string maNCC, string maNV, DateTime ngayDat, DateTime ngayNhan, List<ChiTietDatItem> items)
        {
            if (string.IsNullOrWhiteSpace(maDDH))
                return KetQuaXuLy.Fail("Mã đơn đặt hàng không được để trống.");
            if (items == null || items.Count == 0)
                return KetQuaXuLy.Fail("Đơn đặt hàng phải có ít nhất một mặt hàng.");

            decimal tongTien = 0;
            foreach (var it in items) tongTien += it.ThanhTien;

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    using (var cmd = new SqlCommand(@"
                        INSERT INTO DonDatHang(MaDDH, MaNCC, MaNVLap, NgayDat, NgayNhanDuKien, TongTienDat, SoDotGiaoDaNhan, TrangThai)
                        VALUES (@ma, @ncc, @nv, @nd, @nn, @tt, 0, N'Chưa giao')", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@ma", maDDH);
                        cmd.Parameters.AddWithValue("@ncc", maNCC);
                        cmd.Parameters.AddWithValue("@nv", maNV);
                        cmd.Parameters.AddWithValue("@nd", ngayDat);
                        cmd.Parameters.AddWithValue("@nn", ngayNhan);
                        cmd.Parameters.AddWithValue("@tt", tongTien);
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var it in items)
                    {
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO ChiTietDonDatHang(MaDDH, MaNGK, SoLuongDat, DonGiaDat)
                            VALUES (@ddh, @ngk, @sl, @dg)", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@ddh", maDDH);
                            cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                            cmd.Parameters.AddWithValue("@sl", it.SoLuongDat);
                            cmd.Parameters.AddWithValue("@dg", it.DonGiaDat);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok("Tạo đơn đặt hàng thành công.");
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return KetQuaXuLy.Fail("Lỗi tạo ĐĐH: " + ex.Message);
                }
            }
        }

        public DataTable LayPhieuGiao(string maDDH = null)
        {
            if (string.IsNullOrWhiteSpace(maDDH))
            {
                return Db.Query(@"
                    SELECT p.MaPGH, p.MaDDH, p.SoPhieuGiaoNCC, p.DotGiao, p.NgayGiao, 
                           v.HoTen AS NguoiNhan, p.TongTienPhaiTra, p.TrangThai
                    FROM PhieuGiaoHang p
                    JOIN NhanVien v ON p.MaNVNhan = v.MaNV
                    ORDER BY p.NgayGiao DESC");
            }
            return Db.Query(@"
                SELECT p.MaPGH, p.MaDDH, p.SoPhieuGiaoNCC, p.DotGiao, p.NgayGiao, 
                       v.HoTen AS NguoiNhan, p.TongTienPhaiTra, p.TrangThai
                FROM PhieuGiaoHang p
                JOIN NhanVien v ON p.MaNVNhan = v.MaNV
                WHERE p.MaDDH = @ddh
                ORDER BY p.DotGiao",
                new SqlParameter("@ddh", maDDH));
        }

        public KetQuaXuLy NhanHangGiaoDot(string maPGH, string maDDH, string soPGNCC, int dotGiao, DateTime ngayGiao, string maNV, List<ChiTietGiaoItem> items)
        {
            if (string.IsNullOrWhiteSpace(maPGH) || string.IsNullOrWhiteSpace(maDDH))
                return KetQuaXuLy.Fail("Mã phiếu giao và mã đơn đặt hàng không được để trống.");
            if (dotGiao < 1 || dotGiao > 3)
                return KetQuaXuLy.Fail("Mỗi đơn đặt hàng chỉ được giao tối đa 3 đợt.");
            if (items == null || items.Count == 0)
                return KetQuaXuLy.Fail("Phiếu giao hàng phải có mặt hàng giao.");

            decimal tongTien = 0;
            foreach (var it in items) tongTien += it.ThanhTien;

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    // 1. Thêm Phiếu Giao Hàng
                    using (var cmd = new SqlCommand(@"
                        INSERT INTO PhieuGiaoHang(MaPGH, MaDDH, SoPhieuGiaoNCC, DotGiao, NgayGiao, MaNVNhan, TongTienPhaiTra, TrangThai)
                        VALUES (@pgh, @ddh, @sp, @dot, @ngay, @nv, @tt, N'Đã nhập kho')", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@pgh", maPGH);
                        cmd.Parameters.AddWithValue("@ddh", maDDH);
                        cmd.Parameters.AddWithValue("@sp", soPGNCC ?? "");
                        cmd.Parameters.AddWithValue("@dot", dotGiao);
                        cmd.Parameters.AddWithValue("@ngay", ngayGiao);
                        cmd.Parameters.AddWithValue("@nv", maNV);
                        cmd.Parameters.AddWithValue("@tt", tongTien);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Thêm Chi Tiết Phiếu Giao & Tăng Tồn Kho
                    foreach (var it in items)
                    {
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO ChiTietPhieuGiao(MaPGH, MaNGK, SoLuongGiao, DonGiaGiao)
                            VALUES (@pgh, @ngk, @sl, @dg)", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@pgh", maPGH);
                            cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                            cmd.Parameters.AddWithValue("@sl", it.SoLuongGiao);
                            cmd.Parameters.AddWithValue("@dg", it.DonGiaGiao);
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật tăng tồn kho
                        using (var cmd = new SqlCommand(@"
                            UPDATE NuocGiaiKhat 
                            SET SoLuongTon = SoLuongTon + @sl 
                            WHERE MaNGK = @ngk", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@sl", it.SoLuongGiao);
                            cmd.Parameters.AddWithValue("@ngk", it.MaNGK);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 3. Cập nhật tiến độ đợt giao của Đơn đặt hàng
                    using (var cmd = new SqlCommand(@"
                        UPDATE DonDatHang 
                        SET SoDotGiaoDaNhan = @dot,
                            TrangThai = CASE WHEN @dot >= 3 THEN N'Đã hoàn tất' ELSE N'Đang giao' END
                        WHERE MaDDH = @ddh", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@dot", dotGiao);
                        cmd.Parameters.AddWithValue("@ddh", maDDH);
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok(string.Format("Đã tiếp nhận hàng đợt {0} và cập nhật tăng số lượng tồn kho thành công.", dotGiao));
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return KetQuaXuLy.Fail("Lỗi nhận hàng: " + ex.Message);
                }
            }
        }
    }
}
