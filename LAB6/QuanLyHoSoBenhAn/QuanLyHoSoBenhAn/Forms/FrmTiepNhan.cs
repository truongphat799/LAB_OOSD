using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Models;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmTiepNhan : Form
    {
        readonly BenhNhanService s = new BenhNhanService();

        public FrmTiepNhan()
        {
            InitializeComponent();
        }

        private void FrmTiepNhan_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.SelectedIndex = 0;
            numNamApDung.Value = DateTime.Now.Year;
            TaiDuLieu();
        }

        void TaiDuLieu()
        {
            dgvBenhNhan.DataSource = s.LayDanhSachBenhNhan();
        }

        private void btnChupAnh_Click(object sender, EventArgs e)
        {
            string ma = txtMaBN.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng nhập Mã bệnh nhân trước khi chụp ảnh 3x4.", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string path = s.ChupAnh3x4(ma);
            txtAnh3x4.Text = path;
            MessageBox.Show("Camera đã chụp ảnh chân dung 3x4 thành công:\n" + path, "Thông báo Camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string anh3x4 = txtAnh3x4.Text.Trim();
            string tienSuBenh = txtTienSuBenh.Text.Trim();
            string tienSuDiUng = txtTienSuDiUng.Text.Trim();
            decimal lePhi = numLePhi.Value;
            int nam = (int)numNamApDung.Value;

            var kq = s.DangKyMoiVaCapHoSo(
                maBN, hoTen, dtNgaySinh.Value, cboGioiTinh.Text,
                diaChi, sdt, anh3x4, "ND_CSKH_LAN", lePhi, nam, tienSuBenh, tienSuDiUng);

            MessageBox.Show(kq.ThongBao, "Kết quả tiếp nhận", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDuLieu();
                txtMaBN.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtAnh3x4.Clear();
                txtTienSuBenh.Clear();
                txtTienSuDiUng.Clear();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
                TaiDuLieu();
            else
                dgvBenhNhan.DataSource = s.TimKiemBenhNhan(tuKhoa);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
