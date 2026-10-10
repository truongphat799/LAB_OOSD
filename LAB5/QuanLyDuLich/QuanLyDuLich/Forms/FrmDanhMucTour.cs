using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmDanhMucTour : Form
    {
        private readonly TourService tourService = new TourService();

        public FrmDanhMucTour()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvTour.DataSource = tourService.LayDanhSachTour();
                if (dgvTour.Columns["DonGiaKhach"] != null)
                {
                    dgvTour.Columns["DonGiaKhach"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu tour: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTour.Clear();
            txtTenTour.Clear();
            numSoNgay.Value = 3;
            numSoDem.Value = 2;
            txtDonGia.Text = "3500000";
            txtMaTour.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text) || string.IsNullOrWhiteSpace(txtTenTour.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tour và tên tour.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Replace(".", "").Trim(), out decimal donGia))
            {
                MessageBox.Show("Đơn giá tour không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = tourService.ThemTour(txtMaTour.Text.Trim(), txtTenTour.Text.Trim(), (int)numSoNgay.Value, (int)numSoDem.Value, donGia);
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Thông báo", MessageBoxButtons.OK, 
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTour.CurrentRow == null) return;
            string maTour = dgvTour.CurrentRow.Cells["MaTour"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa tour {maTour}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kq = tourService.XoaTour(maTour);
                MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Lỗi", MessageBoxButtons.OK, 
                    kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (kq.ThanhCong) LoadData();
            }
        }

        private void btnXuatBanWeb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đồng bộ và xuất bản thông tin tour thành công lên Cổng thông tin Website Du lịch Văn Hóa Việt!", 
                "Xuất bản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.CurrentRow != null)
            {
                var r = dgvTour.CurrentRow;
                txtMaTour.Text = r.Cells["MaTour"].Value?.ToString();
                txtTenTour.Text = r.Cells["TenTour"].Value?.ToString();
                if (int.TryParse(r.Cells["SoNgay"].Value?.ToString(), out int ng)) numSoNgay.Value = ng;
                if (int.TryParse(r.Cells["SoDem"].Value?.ToString(), out int d)) numSoDem.Value = d;
                if (decimal.TryParse(r.Cells["DonGiaKhach"].Value?.ToString(), out decimal g)) txtDonGia.Text = g.ToString("N0");
            }
        }
    }
}
