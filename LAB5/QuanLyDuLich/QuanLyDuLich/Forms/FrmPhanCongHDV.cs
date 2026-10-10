using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmPhanCongHDV : Form
    {
        private readonly PhanCongHDVService pcService = new PhanCongHDVService();
        private readonly ChuyenService chuyenService = new ChuyenService();
        private readonly DangKyDoanService doanService = new DangKyDoanService();

        public FrmPhanCongHDV()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboHDV.DataSource = pcService.LayDanhSachHDV();
                cboHDV.DisplayMember = "HoTen";
                cboHDV.ValueMember = "MaHDV";

                cboChuyen.DataSource = chuyenService.LayDanhSachChuyen();
                cboChuyen.DisplayMember = "MaChuyen";
                cboChuyen.ValueMember = "MaChuyen";

                cboDoan.DataSource = doanService.LayDanhSachPhieuDoan();
                cboDoan.DisplayMember = "SoPhieuDK";
                cboDoan.ValueMember = "SoPhieuDK";

                dgvPhanCong.DataSource = pcService.LayDanhSachPhanCong();
                if (dgvPhanCong.Columns["LuongTour"] != null) dgvPhanCong.Columns["LuongTour"].DefaultCellStyle.Format = "N0";
                if (dgvPhanCong.Columns["LuongCanBan"] != null) dgvPhanCong.Columns["LuongCanBan"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phân công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPC.Text = "PC" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            dtpTuNgay.Value = DateTime.Today.AddDays(5);
            dtpDenNgay.Value = DateTime.Today.AddDays(8);
            txtLuongTour.Text = "1500000";
            txtVaiTro.Text = "Hướng dẫn viên chính";
            txtMaPC.Focus();
        }

        private void btnKiemTraLich_Click(object sender, EventArgs e)
        {
            if (cboHDV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hướng dẫn viên cần kiểm tra lịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = pcService.KiemTraTrungLich(cboHDV.SelectedValue.ToString(), dtpTuNgay.Value, dtpDenNgay.Value);
            MessageBox.Show(kq.ThongBao, "Kết quả kiểm tra lịch (BR06)", MessageBoxButtons.OK, 
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPC.Text) || cboHDV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập mã phân công và chọn HDV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtLuongTour.Text.Replace(",", "").Replace(".", "").Trim(), out decimal luongTour))
            {
                MessageBox.Show("Thù lao tour không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maChuyen = rdoChuyenLe.Checked ? cboChuyen.SelectedValue?.ToString() : null;
            string soPhieuDK = rdoDoan.Checked ? cboDoan.SelectedValue?.ToString() : null;

            var kq = pcService.PhanCongHDV(
                txtMaPC.Text.Trim(),
                cboHDV.SelectedValue.ToString(),
                maChuyen,
                soPhieuDK,
                dtpTuNgay.Value,
                dtpDenNgay.Value,
                luongTour,
                txtVaiTro.Text.Trim()
            );

            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Cảnh báo trùng lịch", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
