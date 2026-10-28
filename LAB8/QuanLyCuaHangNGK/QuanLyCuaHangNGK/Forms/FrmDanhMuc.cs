using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiTatCa();
        }

        void TaiTatCa()
        {
            try
            {
                dgvNCC.DataSource = s.LayNhaCungUng();
                dgvNH.DataSource = s.LayNhanHieu();
                dgvNV.DataSource = s.LayNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) TaiTatCa();
        }

        // NCC Events
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            H(s.ThemNhaCungUng(txtNCCMa.Text.Trim(), txtNCCTen.Text.Trim(), txtNCCDiaChi.Text.Trim(), txtNCCSDT.Text.Trim()));
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            H(s.SuaNhaCungUng(txtNCCMa.Text.Trim(), txtNCCTen.Text.Trim(), txtNCCDiaChi.Text.Trim(), txtNCCSDT.Text.Trim()));
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung ứng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                H(s.XoaNhaCungUng(txtNCCMa.Text.Trim()));
            }
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow != null && dgvNCC.Columns.Contains("MaNCC"))
            {
                txtNCCMa.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["MaNCC"].Value);
                txtNCCTen.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["TenNCC"].Value);
                txtNCCDiaChi.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["DiaChi"].Value);
                txtNCCSDT.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["SoDienThoai"].Value);
            }
        }

        // Nhãn Hiệu Events
        private void btnThemNH_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanHieu(txtNHMa.Text.Trim(), txtNHTen.Text.Trim(), txtNHXuatXu.Text.Trim()));
        }

        private void btnSuaNH_Click(object sender, EventArgs e)
        {
            H(s.SuaNhanHieu(txtNHMa.Text.Trim(), txtNHTen.Text.Trim(), txtNHXuatXu.Text.Trim()));
        }

        private void btnXoaNH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhãn hiệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                H(s.XoaNhanHieu(txtNHMa.Text.Trim()));
            }
        }

        private void dgvNH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNH.CurrentRow != null && dgvNH.Columns.Contains("MaNhanHieu"))
            {
                txtNHMa.Text = Convert.ToString(dgvNH.CurrentRow.Cells["MaNhanHieu"].Value);
                txtNHTen.Text = Convert.ToString(dgvNH.CurrentRow.Cells["TenNhanHieu"].Value);
                txtNHXuatXu.Text = Convert.ToString(dgvNH.CurrentRow.Cells["XuatXu"].Value);
            }
        }

        // Nhân Viên Events
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            H(s.SuaNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                H(s.XoaNhanVien(txtNVMa.Text.Trim()));
            }
        }

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.CurrentRow != null && dgvNV.Columns.Contains("MaNV"))
            {
                txtNVMa.Text = Convert.ToString(dgvNV.CurrentRow.Cells["MaNV"].Value);
                txtNVTen.Text = Convert.ToString(dgvNV.CurrentRow.Cells["HoTen"].Value);
                txtNVVaiTro.Text = Convert.ToString(dgvNV.CurrentRow.Cells["VaiTro"].Value);
                txtNVSDT.Text = Convert.ToString(dgvNV.CurrentRow.Cells["SoDienThoai"].Value);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
