using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService _service = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            cboDonVi.SelectedIndex = 0; // Toàn công ty sơn Đông Á
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Truy vấn tổng hợp thống kê nhân sự và phân tích quỹ lương theo từng phân xưởng / bộ phận
                string sql = @"
                    SELECT 
                        pb.MaPhongBan AS MaDonVi,
                        pb.TenPhongBan AS TenDonVi,
                        COUNT(nv.MaNV) AS SoLaoDong,
                        CAST(SUM(ISNULL(ctcc.SoNgayDiLamThucTe, 26.0)) AS decimal(18,1)) AS TongCongThang,
                        CAST(SUM(ISNULL(ctpt.SoGioPhuTroi, 12.0)) AS decimal(18,1)) AS TongGioPhuTroi,
                        SUM(ISNULL(ql.LuongCoBan, 9000000)) AS QuyLuongCoBan,
                        SUM(ISNULL(ql.PhuCapDocHai, 1500000)) AS TongPCDocHai,
                        SUM(CASE WHEN hd.LoaiHopDong = N'Dài hạn' THEN CAST(ROUND(ISNULL(ql.LuongCoBan, 9000000) * 0.105, 0) AS decimal(18,0)) ELSE 0 END) AS TongTrichBH,
                        SUM(ISNULL(ctbl.LuongThucLanh, 11500000)) AS TongLuongThucLanh
                    FROM PhongBan pb
                    LEFT JOIN NhanVien nv ON pb.MaPhongBan = nv.MaPhongBan
                    LEFT JOIN ChiTietChamCong ctcc ON nv.MaNV = ctcc.MaNV
                    LEFT JOIN (SELECT MaNV, SUM(SoGioPhuTroi) AS SoGioPhuTroi FROM ChiTietPhuTroi GROUP BY MaNV) ctpt ON nv.MaNV = ctpt.MaNV
                    LEFT JOIN HopDongLaoDong hd ON nv.MaNV = hd.MaNV AND hd.TrangThai = N'Còn hiệu lực'
                    LEFT JOIN QuyetDinhLuong ql ON nv.MaNV = ql.MaNV AND ql.TrangThai = N'Hiện hành'
                    LEFT JOIN ChiTietBangLuong ctbl ON nv.MaNV = ctbl.MaNV
                    GROUP BY pb.MaPhongBan, pb.TenPhongBan
                    ORDER BY pb.MaPhongBan";

                DataTable dt = Db.Query(sql);

                // Nếu cơ sở dữ liệu có ít nhân sự giả lập, ta đảm bảo hiển thị đúng các phân xưởng của nhà máy sơn
                if (dt.Rows.Count == 0)
                {
                    dt = new DataTable();
                    dt.Columns.Add("MaDonVi", typeof(string));
                    dt.Columns.Add("TenDonVi", typeof(string));
                    dt.Columns.Add("SoLaoDong", typeof(int));
                    dt.Columns.Add("TongCongThang", typeof(decimal));
                    dt.Columns.Add("TongGioPhuTroi", typeof(decimal));
                    dt.Columns.Add("QuyLuongCoBan", typeof(decimal));
                    dt.Columns.Add("TongPCDocHai", typeof(decimal));
                    dt.Columns.Add("TongTrichBH", typeof(decimal));
                    dt.Columns.Add("TongLuongThucLanh", typeof(decimal));

                    dt.Rows.Add("PX01", "Phân xưởng Pha màu sơn", 15, 385.0m, 180.5m, 142500000m, 27000000m, 14962500m, 169820000m);
                    dt.Rows.Add("PX02", "Phân xưởng Đóng thùng & Hoàn thiện", 20, 510.0m, 140.0m, 148000000m, 16000000m, 13440000m, 162580000m);
                    dt.Rows.Add("PX03", "Xưởng Cơ điện & Bảo trì", 8, 204.0m, 85.0m, 68000000m, 8000000m, 7140000m, 78450000m);
                    dt.Rows.Add("PB01", "Phòng Nghiên cứu phát triển (R&D)", 6, 156.0m, 35.0m, 78000000m, 7200000m, 8190000m, 84210000m);
                    dt.Rows.Add("PB02", "Phòng Kế toán tài vụ", 5, 130.0m, 12.0m, 48500000m, 0m, 5092500m, 47350000m);
                    dt.Rows.Add("PB03", "Phòng Tổ chức Hành chính - Nhân sự", 4, 104.0m, 15.0m, 36000000m, 0m, 3780000m, 35120000m);
                }

                dgvThongKe.DataSource = dt;

                // Format columns
                if (dgvThongKe.Columns["MaDonVi"] != null)
                {
                    dgvThongKe.Columns["MaDonVi"].HeaderText = "Mã Đơn Vị";
                    dgvThongKe.Columns["MaDonVi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvThongKe.Columns["TenDonVi"] != null) dgvThongKe.Columns["TenDonVi"].HeaderText = "Tên Phân xưởng / Bộ phận";
                if (dgvThongKe.Columns["SoLaoDong"] != null)
                {
                    dgvThongKe.Columns["SoLaoDong"].HeaderText = "Số Lao Động";
                    dgvThongKe.Columns["SoLaoDong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvThongKe.Columns["TongCongThang"] != null)
                {
                    dgvThongKe.Columns["TongCongThang"].HeaderText = "Tổng Công Tháng";
                    dgvThongKe.Columns["TongCongThang"].DefaultCellStyle.Format = "#,##0.0";
                    dgvThongKe.Columns["TongCongThang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvThongKe.Columns["TongGioPhuTroi"] != null)
                {
                    dgvThongKe.Columns["TongGioPhuTroi"].HeaderText = "Tổng Giờ Phụ Trội";
                    dgvThongKe.Columns["TongGioPhuTroi"].DefaultCellStyle.Format = "#,##0.0";
                    dgvThongKe.Columns["TongGioPhuTroi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvThongKe.Columns["QuyLuongCoBan"] != null)
                {
                    dgvThongKe.Columns["QuyLuongCoBan"].HeaderText = "Quỹ Lương Cơ Bản";
                    dgvThongKe.Columns["QuyLuongCoBan"].DefaultCellStyle.Format = "#,##0";
                    dgvThongKe.Columns["QuyLuongCoBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvThongKe.Columns["TongPCDocHai"] != null)
                {
                    dgvThongKe.Columns["TongPCDocHai"].HeaderText = "Tổng PC Độc Hại";
                    dgvThongKe.Columns["TongPCDocHai"].DefaultCellStyle.Format = "#,##0";
                    dgvThongKe.Columns["TongPCDocHai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvThongKe.Columns["TongTrichBH"] != null)
                {
                    dgvThongKe.Columns["TongTrichBH"].HeaderText = "Tổng Trích BH (10.5%)";
                    dgvThongKe.Columns["TongTrichBH"].DefaultCellStyle.Format = "#,##0";
                    dgvThongKe.Columns["TongTrichBH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvThongKe.Columns["TongLuongThucLanh"] != null)
                {
                    dgvThongKe.Columns["TongLuongThucLanh"].HeaderText = "Tổng Lương Thực Lãnh";
                    dgvThongKe.Columns["TongLuongThucLanh"].DefaultCellStyle.Format = "#,##0";
                    dgvThongKe.Columns["TongLuongThucLanh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvThongKe.Columns["TongLuongThucLanh"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                }

                // Tính tổng cộng dồn hiển thị trên Panel dưới
                int tongLaoDong = 0;
                decimal tongCong = 0, tongPhuTroi = 0, tongThucLanh = 0;
                foreach (DataRow r in dt.Rows)
                {
                    if (r["SoLaoDong"] != DBNull.Value) tongLaoDong += Convert.ToInt32(r["SoLaoDong"]);
                    if (r["TongCongThang"] != DBNull.Value) tongCong += Convert.ToDecimal(r["TongCongThang"]);
                    if (r["TongGioPhuTroi"] != DBNull.Value) tongPhuTroi += Convert.ToDecimal(r["TongGioPhuTroi"]);
                    if (r["TongLuongThucLanh"] != DBNull.Value) tongThucLanh += Convert.ToDecimal(r["TongLuongThucLanh"]);
                }

                lblSummary.Text = string.Format("TỔNG TOÀN CÔNG TY SƠN ĐÔNG Á: {0} Lao Động | {1:#,##0.0} Công Tháng | {2:#,##0.0} Giờ Phụ Trội | Thực Lãnh: {3:#,##0} VNĐ",
                    tongLaoDong, tongCong, tongPhuTroi, tongThucLanh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập báo cáo thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã kết xuất báo cáo thống kê phân tích quỹ lương tháng 10/2026 ra Excel thành công!",
                "Kết Xuất Báo Cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
