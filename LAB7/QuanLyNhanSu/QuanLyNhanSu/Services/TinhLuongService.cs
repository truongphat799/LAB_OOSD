using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Services
{
    public class TinhLuongService
    {
        public DataTable LayDanhSachBangLuong()
        {
            return Db.Query("SELECT * FROM BangLuongThang ORDER BY NamLuong DESC, ThangLuong DESC");
        }

        public DataTable LayChiTietBangLuong(string maBangLuong)
        {
            return Db.Query(@"SELECT c.*, nv.HoTen, pb.TenPhongBan, hd.LoaiHopDong, cv.TenChucVu
                              FROM ChiTietBangLuong c
                              JOIN NhanVien nv ON c.MaNV = nv.MaNV
                              JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                              LEFT JOIN HopDongLaoDong hd ON nv.MaNV = hd.MaNV AND hd.TrangThai = N'Còn hiệu lực'
                              LEFT JOIN QuyetDinhChucVu qdc ON nv.MaNV = qdc.MaNV AND qdc.TrangThai = N'Hiện hành'
                              LEFT JOIN ChucVu cv ON qdc.MaChucVu = cv.MaChucVu
                              WHERE c.MaBangLuong = @mbl
                              ORDER BY c.MaNV",
                              new SqlParameter("@mbl", maBangLuong));
        }

        // TÍNH LƯƠNG TOÀN CÔNG TY TRONG THÁNG
        public KetQuaXuLy TinhToanBangLuongThang(int thang, int nam)
        {
            string maBL = "BL-" + nam.ToString() + "-" + thang.ToString("D2");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Khởi tạo hoặc cập nhật bảng lương tháng (bám sát schema BangLuongThang)
                    var cmdCheck = new SqlCommand("SELECT COUNT(*) FROM BangLuongThang WHERE MaBangLuong = @m", cn, tx);
                    cmdCheck.Parameters.AddWithValue("@m", maBL);
                    if ((int)cmdCheck.ExecuteScalar() == 0)
                    {
                        var cmdNew = new SqlCommand(@"INSERT INTO BangLuongThang(MaBangLuong, ThangLuong, NamLuong, NgayLap, TongQuyLuong, TrangThai)
                                                      VALUES(@m, @t, @nam, @ngay, 0, N'Chờ duyệt')", cn, tx);
                        cmdNew.Parameters.AddWithValue("@m", maBL);
                        cmdNew.Parameters.AddWithValue("@t", thang);
                        cmdNew.Parameters.AddWithValue("@nam", nam);
                        cmdNew.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
                        cmdNew.ExecuteNonQuery();
                    }

                    // 2. Lấy danh sách toàn bộ nhân viên có hợp đồng còn hiệu lực hoặc đang thử việc
                    var cmdNV = new SqlCommand("SELECT MaNV FROM NhanVien WHERE TrangThai IN (N'Chính thức', N'Thử việc')", cn, tx);
                    using (var da = new SqlDataAdapter(cmdNV))
                    {
                        var dtNV = new DataTable();
                        da.Fill(dtNV);

                        foreach (DataRow r in dtNV.Rows)
                        {
                            string maNV = r["MaNV"].ToString();

                            // Gọi Stored Procedure tính lương tự động cho nhân viên
                            var cmdProc = new SqlCommand("sp_TinhLuongNhanVienThang", cn, tx);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            cmdProc.Parameters.AddWithValue("@MaNV", maNV);
                            cmdProc.Parameters.AddWithValue("@Thang", thang);
                            cmdProc.Parameters.AddWithValue("@Nam", nam);
                            cmdProc.Parameters.AddWithValue("@MaBangLuong", maBL);
                            cmdProc.ExecuteNonQuery();
                        }
                    }

                    // 3. Cập nhật tổng quỹ lương
                    var cmdSum = new SqlCommand(@"UPDATE BangLuongThang 
                                                  SET TongQuyLuong = (SELECT ISNULL(SUM(LuongThucLanh), 0) FROM ChiTietBangLuong WHERE MaBangLuong = @m)
                                                  WHERE MaBangLuong = @m", cn, tx);
                    cmdSum.Parameters.AddWithValue("@m", maBL);
                    cmdSum.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Tính toán bảng lương tháng " + thang + "/" + nam + " toàn công ty thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail("Lỗi tính toán bảng lương: " + ex.Message);
                }
            }
        }

        // GIÁM ĐỐC PHÊ DUYỆT BẢNG LƯƠNG THÁNG
        public KetQuaXuLy PheDuyetBangLuong(string maBangLuong)
        {
            if (NguoiDungHienTai.VaiTro != "GIAM_DOC")
                return KetQuaXuLy.Fail("Chỉ có Giám đốc mới có quyền phê duyệt bảng lương!");

            try
            {
                Db.Execute("UPDATE BangLuongThang SET TrangThai = N'Đã duyệt' WHERE MaBangLuong = @m",
                    new SqlParameter("@m", maBangLuong));
                return KetQuaXuLy.Ok("Giám đốc đã phê duyệt bảng lương " + maBangLuong + " thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi phê duyệt bảng lương: " + ex.Message);
            }
        }
    }
}
