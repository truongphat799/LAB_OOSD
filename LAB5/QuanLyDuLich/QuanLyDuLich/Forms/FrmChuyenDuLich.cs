using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmChuyenDuLich : Form
    {
        private readonly ChuyenService chuyenService = new ChuyenService();

        public FrmChuyenDuLich()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboTour.DataSource = chuyenService.LayDanhSachTour();
                cboTour.DisplayMember = "TenTour";
                cboTour.ValueMember = "MaTour";

                dgvChuyen.DataSource = chuyenService.LayDanhSachChuyen();
                if (dgvChuyen.Columns["DonGiaKhach"] != null)
                {
                    dgvChuyen.Columns["DonGiaKhach"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu chuyến: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaChuyen.Text = "CH" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            dtpNgayDi.Value = DateTime.Today.AddDays(7);
            dtpNgayVe.Value = DateTime.Today.AddDays(10);
            numSoCho.Value = 45;
            txtMaChuyen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChuyen.Text) || cboTour.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập mã chuyến và chọn tour.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = chuyenService.ThemChuyen(txtMaChuyen.Text.Trim(), cboTour.SelectedValue.ToString(), 
                dtpNgayDi.Value, dtpNgayVe.Value, (int)numSoCho.Value);

            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Thông báo", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) LoadData();
        }

        private void btnDongChuyen_Click(object sender, EventArgs e)
        {
            if (dgvChuyen.CurrentRow == null) return;
            string maChuyen = dgvChuyen.CurrentRow.Cells["MaChuyen"].Value.ToString();

            var kq = chuyenService.DongChuyen(maChuyen);
            MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (kq.ThanhCong) LoadData();
        }

        private void btnInDSKhach_Click(object sender, EventArgs e)
        {
            if (dgvChuyen.CurrentRow == null) return;
            string maChuyen = dgvChuyen.CurrentRow.Cells["MaChuyen"].Value.ToString();
            MessageBox.Show($"Đã xuất lệnh in danh sách hành khách cho chuyến {maChuyen} (Gồm danh sách điểm đón cố định và số vé đã bán).",
                "In danh sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChuyen.CurrentRow != null)
            {
                var r = dgvChuyen.CurrentRow;
                txtMaChuyen.Text = r.Cells["MaChuyen"].Value?.ToString();
                cboTour.SelectedValue = r.Cells["MaTour"].Value?.ToString();
                if (DateTime.TryParse(r.Cells["NgayDi"].Value?.ToString(), out var ndi)) dtpNgayDi.Value = ndi;
                if (DateTime.TryParse(r.Cells["NgayVe"].Value?.ToString(), out var nve)) dtpNgayVe.Value = nve;
                if (int.TryParse(r.Cells["SoChoToiDa"].Value?.ToString(), out int sc)) numSoCho.Value = sc;
            }
        }
    }
}
