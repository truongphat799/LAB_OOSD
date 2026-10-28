using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmKhachHang : Form
    {
        readonly KhachHangService s = new KhachHangService();

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            cboLoai.SelectedIndex = 0;
            Tai();
        }

        void Tai()
        {
            try
            {
                dgvKhachQuen.DataSource = s.LayKhachQuen();
                dgvVangLai.DataSource = s.LayKhachVangLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            H(s.Them(txtMa.Text.Trim(), txtTen.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim(), cboLoai.Text, numHanMuc.Value));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            H(s.Sua(txtMa.Text.Trim(), txtTen.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim(), cboLoai.Text, numHanMuc.Value));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                H(s.Xoa(txtMa.Text.Trim()));
            }
        }

        private void dgvKhachQuen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachQuen.CurrentRow != null && dgvKhachQuen.Columns.Contains("MaKH"))
            {
                txtMa.Text = Convert.ToString(dgvKhachQuen.CurrentRow.Cells["MaKH"].Value);
                txtTen.Text = Convert.ToString(dgvKhachQuen.CurrentRow.Cells["HoTen"].Value);
                txtSDT.Text = Convert.ToString(dgvKhachQuen.CurrentRow.Cells["SoDienThoai"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKhachQuen.CurrentRow.Cells["DiaChi"].Value);
                cboLoai.Text = "Khách quen";
                if (dgvKhachQuen.Columns.Contains("HanMucNo") && dgvKhachQuen.CurrentRow.Cells["HanMucNo"].Value != DBNull.Value)
                    numHanMuc.Value = Convert.ToDecimal(dgvKhachQuen.CurrentRow.Cells["HanMucNo"].Value);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
