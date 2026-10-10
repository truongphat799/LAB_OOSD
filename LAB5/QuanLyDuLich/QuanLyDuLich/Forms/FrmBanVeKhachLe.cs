using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmBanVeKhachLe : Form
    {
        private readonly BanVeKhachLeService veService = new BanVeKhachLeService();
        private readonly ChuyenService chuyenService = new ChuyenService();

        public FrmBanVeKhachLe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboChuyen.DataSource = veService.LayChuyenKhaDung();
                cboChuyen.DisplayMember = "MaChuyen";
                cboChuyen.ValueMember = "MaChuyen";

                cboKhachHang.DataSource = veService.LayKhachLe();
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKhachHang";

                cboDiemDon.DataSource = chuyenService.LayDiemDon();
                cboDiemDon.DisplayMember = "TenDiemDon";
                cboDiemDon.ValueMember = "MaDiemDon";

                cboDiemBanVe.DataSource = chuyenService.LayDiemBanVe();
                cboDiemBanVe.DisplayMember = "TenDiemBanVe";
                cboDiemBanVe.ValueMember = "MaDiemBanVe";

                dgvVe.DataSource = veService.LayDanhSachVe();
                if (dgvVe.Columns["GiaVe"] != null) dgvVe.Columns["GiaVe"].DefaultCellStyle.Format = "N0";

                CapNhatGiaVe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatGiaVe()
        {
            if (cboChuyen.SelectedItem is DataRowView row)
            {
                if (decimal.TryParse(row["DonGiaKhach"]?.ToString(), out decimal donGia))
                {
                    txtDonGia.Text = donGia.ToString("N0");
                    txtThanhTien.Text = (donGia * numSoLuongVe.Value).ToString("N0");
                }
            }
        }

        private void cboChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGiaVe();
        }

        private void numSoLuongVe_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGiaVe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaVe.Text = "VE" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            numSoLuongVe.Value = 2; // < 12
            CapNhatGiaVe();
            txtMaVe.Focus();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVe.Text) || cboChuyen.SelectedValue == null ||
                cboKhachHang.SelectedValue == null || cboDiemDon.SelectedValue == null || cboDiemBanVe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bán vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Replace(".", "").Trim(), out decimal donGia))
            {
                MessageBox.Show("Đơn giá vé không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = veService.BanVeKhachLe(
                txtMaVe.Text.Trim(),
                cboChuyen.SelectedValue.ToString(),
                cboKhachHang.SelectedValue.ToString(),
                cboDiemBanVe.SelectedValue.ToString(),
                cboDiemDon.SelectedValue.ToString(),
                (int)numSoLuongVe.Value,
                donGia
            );

            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Bán vé thành công" : "Thông báo", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) LoadData();
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null) return;
            string maVe = dgvVe.CurrentRow.Cells["SoVe"].Value.ToString();
            string tenKhach = dgvVe.CurrentRow.Cells["TenKhach"].Value.ToString();
            string diemDon = dgvVe.CurrentRow.Cells["TenDiemDon"].Value.ToString();
            string giaVe = Convert.ToDecimal(dgvVe.CurrentRow.Cells["GiaVe"].Value).ToString("N0");

            MessageBox.Show($"🎫 VÉ DU LỊCH ĐIỆN TỬ (ĐÃ THANH TOÁN 100%)\n" +
                            $"--------------------------------------------------\n" +
                            $"• Mã vé: {maVe}\n" +
                            $"• Hành khách: {tenKhach}\n" +
                            $"• Điểm đón cố định: {diemDon}\n" +
                            $"• Giá vé: {giaVe} VNĐ (ĐÃ THU ĐỦ)\n" +
                            $"• Chúc quý khách một chuyến đi vui vẻ!",
                "In Vé Du Lịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
