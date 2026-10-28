using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmNuocGiaiKhat : Form
    {
        readonly NuocGiaiKhatService s = new NuocGiaiKhatService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmNuocGiaiKhat()
        {
            InitializeComponent();
        }

        private void FrmNuocGiaiKhat_Load(object sender, EventArgs e)
        {
            try
            {
                cboNH.DataSource = dm.LayNhanHieu();
                cboNH.DisplayMember = "TenNhanHieu";
                cboNH.ValueMember = "MaNhanHieu";

                cboNCC.DataSource = dm.LayNhaCungUng();
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";

                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Tai()
        {
            try
            {
                dgvNGK.DataSource = s.LayNuocGiaiKhat();
                dgvCanhBao.DataSource = s.LayCanhBaoTonKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string nh = cboNH.SelectedValue != null ? cboNH.SelectedValue.ToString() : "";
            string ncc = cboNCC.SelectedValue != null ? cboNCC.SelectedValue.ToString() : "";
            H(s.Them(txtMa.Text.Trim(), txtTen.Text.Trim(), nh, ncc, cboDVT.Text, (int)numTon.Value, numGia.Value, (int)numMinTon.Value));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string nh = cboNH.SelectedValue != null ? cboNH.SelectedValue.ToString() : "";
            string ncc = cboNCC.SelectedValue != null ? cboNCC.SelectedValue.ToString() : "";
            H(s.Sua(txtMa.Text.Trim(), txtTen.Text.Trim(), nh, ncc, cboDVT.Text, (int)numTon.Value, numGia.Value, (int)numMinTon.Value));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                H(s.Xoa(txtMa.Text.Trim()));
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNGK.DataSource = s.TimKiem(txtTim.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            Tai();
        }

        private void dgvNGK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNGK.CurrentRow != null && dgvNGK.Columns.Contains("MaNGK"))
            {
                txtMa.Text = Convert.ToString(dgvNGK.CurrentRow.Cells["MaNGK"].Value);
                txtTen.Text = Convert.ToString(dgvNGK.CurrentRow.Cells["TenNGK"].Value);
                cboDVT.Text = Convert.ToString(dgvNGK.CurrentRow.Cells["DonViTinh"].Value);
                if (dgvNGK.Columns.Contains("MaNhanHieu") && dgvNGK.CurrentRow.Cells["MaNhanHieu"].Value != DBNull.Value)
                    cboNH.SelectedValue = dgvNGK.CurrentRow.Cells["MaNhanHieu"].Value;
                if (dgvNGK.Columns.Contains("MaNCC") && dgvNGK.CurrentRow.Cells["MaNCC"].Value != DBNull.Value)
                    cboNCC.SelectedValue = dgvNGK.CurrentRow.Cells["MaNCC"].Value;
                if (dgvNGK.Columns.Contains("SoLuongTon") && dgvNGK.CurrentRow.Cells["SoLuongTon"].Value != DBNull.Value)
                    numTon.Value = Convert.ToDecimal(dgvNGK.CurrentRow.Cells["SoLuongTon"].Value);
                if (dgvNGK.Columns.Contains("DonGiaBan") && dgvNGK.CurrentRow.Cells["DonGiaBan"].Value != DBNull.Value)
                    numGia.Value = Convert.ToDecimal(dgvNGK.CurrentRow.Cells["DonGiaBan"].Value);
                if (dgvNGK.Columns.Contains("DinhMucTonToiThieu") && dgvNGK.CurrentRow.Cells["DinhMucTonToiThieu"].Value != DBNull.Value)
                    numMinTon.Value = Convert.ToDecimal(dgvNGK.CurrentRow.Cells["DinhMucTonToiThieu"].Value);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
