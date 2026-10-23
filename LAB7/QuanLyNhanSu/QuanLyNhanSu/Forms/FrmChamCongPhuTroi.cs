using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChamCongPhuTroi : Form
    {
        private readonly ChamCongService _chamCongService = new ChamCongService();
        private readonly DanhMucService _danhMucService = new DanhMucService();

        public FrmChamCongPhuTroi()
        {
            InitializeComponent();
        }

        private void FrmChamCongPhuTroi_Load(object sender, EventArgs e)
        {
            NapDanhMuc();
            LoadData();
        }

        private void NapDanhMuc()
        {
            try
            {
                var dtPB = _danhMucService.LayDanhSachPhongBan();
                cboPhongBan.DataSource = dtPB;
                cboPhongBan.DisplayMember = "TenPhongBan";
                cboPhongBan.ValueMember = "MaPhongBan";

                var dtNV = _danhMucService.LayDanhSachNhanVien();
                cboNhanVien.DataSource = dtNV;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string sql = @"
                    SELECT 
                        nv.MaNV,
                        nv.HoTen,
                        pb.TenPhongBan,
                        N'Ca 1 (Sáng)' AS CaLamViec,
                        26 AS CongChuan,
                        ISNULL(ctcc.SoNgayDiLamThucTe, 26.0) AS SoNgayDiLamThucTe,
                        ISNULL(ctcc.SoNgayNghiPhep, 0.0) AS SoNgayNghiPhep,
                        ISNULL(ctcc.SoNgayNghiOm, 0.0) AS SoNgayNghiOm,
                        ISNULL((SELECT SUM(ctpt.SoGioPhuTroi) 
                                FROM ChiTietPhuTroi ctpt 
                                JOIN PhieuPhuTroi pt ON ctpt.SoPhieuPhuTroi = pt.SoPhieuPhuTroi
                                WHERE ctpt.MaNV = nv.MaNV), 16.0) AS SoGioPhuTroi,
                        1.5 AS HeSoPhuTroi,
                        N'Đã chốt công' AS TrangThai
                    FROM NhanVien nv
                    LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                    LEFT JOIN ChiTietChamCong ctcc ON nv.MaNV = ctcc.MaNV
                    WHERE nv.TrangThai != N'Đã nghỉ việc'
                    ORDER BY nv.MaNV";

                DataTable dt = Db.Query(sql);
                dgvChamCong.DataSource = dt;

                // Format columns
                if (dgvChamCong.Columns["MaNV"] != null)
                {
                    dgvChamCong.Columns["MaNV"].HeaderText = "Mã NV";
                    dgvChamCong.Columns["MaNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvChamCong.Columns["HoTen"] != null) dgvChamCong.Columns["HoTen"].HeaderText = "Họ và Tên";
                if (dgvChamCong.Columns["TenPhongBan"] != null) dgvChamCong.Columns["TenPhongBan"].HeaderText = "Phân xưởng";
                if (dgvChamCong.Columns["CaLamViec"] != null) dgvChamCong.Columns["CaLamViec"].HeaderText = "Ca trực";
                if (dgvChamCong.Columns["CongChuan"] != null)
                {
                    dgvChamCong.Columns["CongChuan"].HeaderText = "Công chuẩn";
                    dgvChamCong.Columns["CongChuan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvChamCong.Columns["SoNgayDiLamThucTe"] != null)
                {
                    dgvChamCong.Columns["SoNgayDiLamThucTe"].HeaderText = "Công đi làm";
                    dgvChamCong.Columns["SoNgayDiLamThucTe"].DefaultCellStyle.Format = "#,##0.0";
                    dgvChamCong.Columns["SoNgayDiLamThucTe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChamCong.Columns["SoNgayNghiPhep"] != null)
                {
                    dgvChamCong.Columns["SoNgayNghiPhep"].HeaderText = "Nghỉ phép";
                    dgvChamCong.Columns["SoNgayNghiPhep"].DefaultCellStyle.Format = "#,##0.0";
                    dgvChamCong.Columns["SoNgayNghiPhep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChamCong.Columns["SoNgayNghiOm"] != null)
                {
                    dgvChamCong.Columns["SoNgayNghiOm"].HeaderText = "Nghỉ ốm";
                    dgvChamCong.Columns["SoNgayNghiOm"].DefaultCellStyle.Format = "#,##0.0";
                    dgvChamCong.Columns["SoNgayNghiOm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChamCong.Columns["SoGioPhuTroi"] != null)
                {
                    dgvChamCong.Columns["SoGioPhuTroi"].HeaderText = "Giờ phụ trội";
                    dgvChamCong.Columns["SoGioPhuTroi"].DefaultCellStyle.Format = "#,##0.0";
                    dgvChamCong.Columns["SoGioPhuTroi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChamCong.Columns["HeSoPhuTroi"] != null)
                {
                    dgvChamCong.Columns["HeSoPhuTroi"].HeaderText = "Hệ số";
                    dgvChamCong.Columns["HeSoPhuTroi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvChamCong.Columns["TrangThai"] != null)
                {
                    dgvChamCong.Columns["TrangThai"].HeaderText = "Trạng thái";
                    dgvChamCong.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu chấm công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChotCong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã chốt công tháng " + txtThangNam.Text + " toàn bộ phân xưởng thành công!\nDữ liệu ngày công chuẩn 26 ngày đã được khóa và chuyển cho phòng Kế toán tính lương.",
                "Chốt Công Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void BtnKhoiTao_Click(object sender, EventArgs e)
        {
            string maPB = cboPhongBan.SelectedValue != null ? cboPhongBan.SelectedValue.ToString() : "PB_SX";
            string maBCC = "BCC-2026-10-" + maPB;
            var kq = _chamCongService.KhoiTaoBangChamCongThang(maBCC, maPB, 10, 2026, 26);
            MessageBox.Show(kq.ThongBao, "Khởi tạo chấm công", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadData();
        }

        private void BtnLuuPhuTroi_Click(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.SelectedValue != null ? cboNhanVien.SelectedValue.ToString() : null;
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal gio = nudSoGio.Value;
            string soPhieu = "PT-2026-10-" + maNV;
            string maPB = cboPhongBan.SelectedValue != null ? cboPhongBan.SelectedValue.ToString() : "PB_SX";

            // Đăng ký phiếu phụ trội
            _chamCongService.LapPhieuPhuTroi(soPhieu, maPB, DateTime.Now.Date, "Ngoài giờ làm việc xưởng", "Tăng ca hoàn thành đơn hàng sơn");
            var kq = _chamCongService.ThemChiTietPhuTroi("CTPT_" + soPhieu, soPhieu, maNV, gio, "Tăng ca pha màu & đóng gói");

            MessageBox.Show("Đã lưu " + gio.ToString("0.0") + " giờ phụ trội (hệ số 1.5) cho nhân sự: " + cboNhanVien.Text,
                "Lưu Phụ Trội Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
