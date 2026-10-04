using System;
using System.Windows.Forms;
using QuanLyCuaHangEShopping.Models;
using QuanLyCuaHangEShopping.Services;

namespace QuanLyCuaHangEShopping.Forms
{
    public partial class FrmSanPham : Form
    {
        readonly SanPhamService s = new SanPhamService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmSanPham() { InitializeComponent(); }

        private void FrmSanPham_Load(object a, EventArgs e)
        {
            cboNhom.DataSource = dm.LayNhomSanPham();
            cboNhom.DisplayMember = "TenNhom";
            cboNhom.ValueMember = "MaNhom";

            cboTinhTrang.Items.AddRange(new object[] { "Còn hàng", "Hết hàng" });
            cboTinhTrang.SelectedIndex = 0;

            Tai();
        }

        void Tai() { dgvSanPham.DataSource = s.LaySanPham(); }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThemSP_Click(object a, EventArgs e)
        {
            string maNhom = cboNhom.SelectedValue == null ? "" : cboNhom.SelectedValue.ToString();
            H(s.ThemSanPham(txtMaSP.Text.Trim(), maNhom, txtTenSP.Text.Trim(), txtNSX.Text.Trim(),
                numGia.Value, cboTinhTrang.Text, txtMoTa.Text.Trim(), txtThongSo.Text.Trim()));
        }

        private void dgvSanPham_SelectionChanged(object a, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            txtMoTaChiTiet.Text = Convert.ToString(dgvSanPham.CurrentRow.Cells["MoTa"].Value);
            txtThongSoChiTiet.Text = Convert.ToString(dgvSanPham.CurrentRow.Cells["ThongSoKyThuat"].Value);
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }
    }
}