using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmDangKyDoan : Form
    {
        private readonly DangKyDoanService doanService = new DangKyDoanService();
        private readonly ChuyenService chuyenService = new ChuyenService();

        public FrmDangKyDoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboKhachDoan.DataSource = doanService.LayKhachDoan();
                cboKhachDoan.DisplayMember = "TenCoQuan";
                cboKhachDoan.ValueMember = "MaKhachHang";

                cboTour.DataSource = chuyenService.LayDanhSachTour();
                cboTour.DisplayMember = "TenTour";
                cboTour.ValueMember = "MaTour";

                dgvDoan.DataSource = doanService.LayDanhSachPhieuDoan();
                if (dgvDoan.Columns["TongKinhPhi"] != null) dgvDoan.Columns["TongKinhPhi"].DefaultCellStyle.Format = "N0";
                if (dgvDoan.Columns["TienCoc"] != null) dgvDoan.Columns["TienCoc"].DefaultCellStyle.Format = "N0";
                if (dgvDoan.Columns["TienConLai"] != null) dgvDoan.Columns["TienConLai"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu đăng ký đoàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtSoPhieu.Text = "PDK" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            numSoKhach.Value = 25; // >= 12
            txtDiaDiemDon.Text = "Trụ sở cơ quan / gia đình khách hàng";
            chkCoBaoHiem.Checked = true;
            dtpNgayDi.Value = DateTime.Today.AddDays(14);
            txtTienCoc.Text = "30000000";
            txtSoPhieu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieu.Text) || cboKhachDoan.SelectedValue == null || cboTour.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTienCoc.Text.Replace(",", "").Replace(".", "").Trim(), out decimal tienCoc))
            {
                MessageBox.Show("Số tiền cọc không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = doanService.LapPhieuDangKyDoan(
                txtSoPhieu.Text.Trim(),
                cboKhachDoan.SelectedValue.ToString(),
                cboTour.SelectedValue.ToString(),
                dtpNgayDi.Value,
                txtDiaDiemDon.Text.Trim(),
                (int)numSoKhach.Value,
                chkCoBaoHiem.Checked,
                tienCoc
            );

            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Thông báo", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) LoadData();
        }

        private void btnHuyDoan_Click(object sender, EventArgs e)
        {
            if (dgvDoan.CurrentRow == null) return;
            string soPhieu = dgvDoan.CurrentRow.Cells["SoPhieuDK"].Value.ToString();

            if (MessageBox.Show($"Xác nhận hủy đoàn cho phiếu {soPhieu}?\nLưu ý quy tắc BR05: Công ty sẽ thu giữ 100% tiền đặt cọc và không hoàn lại!",
                "Cảnh báo hủy đoàn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kq = doanService.HuyTourMatCoc(soPhieu);
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (kq.ThanhCong) LoadData();
            }
        }

        private void btnInPhieuCoc_Click(object sender, EventArgs e)
        {
            if (dgvDoan.CurrentRow == null) return;
            string soPhieu = dgvDoan.CurrentRow.Cells["SoPhieuDK"].Value.ToString();
            string tienCoc = Convert.ToDecimal(dgvDoan.CurrentRow.Cells["TienCoc"].Value).ToString("N0");

            MessageBox.Show($"Đã xuất Phiếu Thu Tiền Cọc cho phiếu {soPhieu}:\n• Số tiền cọc đã thu: {tienCoc} VNĐ\n• Quy tắc: Tiền cọc không hoàn lại nếu hủy tour.",
                "Biên nhận đặt cọc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoan.CurrentRow != null)
            {
                var r = dgvDoan.CurrentRow;
                txtSoPhieu.Text = r.Cells["SoPhieuDK"].Value?.ToString();
                txtDiaDiemDon.Text = r.Cells["DiaDiemDon"].Value?.ToString();
                if (int.TryParse(r.Cells["SoNguoiDi"].Value?.ToString(), out int sn)) numSoKhach.Value = sn;
                if (decimal.TryParse(r.Cells["TienCoc"].Value?.ToString(), out decimal tc)) txtTienCoc.Text = tc.ToString("N0");
                if (DateTime.TryParse(r.Cells["NgayDiYeuCau"].Value?.ToString(), out var ndi)) dtpNgayDi.Value = ndi;
            }
        }
    }
}
