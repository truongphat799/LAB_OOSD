using System;
using System.Windows.Forms;
using QuanLyCuaHangEShopping.Models;
using QuanLyCuaHangEShopping.Services;

namespace QuanLyCuaHangEShopping.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc() { InitializeComponent(); }

        private void FrmDanhMuc_Load(object a, EventArgs e) { Tai(); }

        void Tai()
        {
            dgvNhom.DataSource = s.LayNhomSanPham();
            dgvKhuVuc.DataSource = s.LayKhuVuc();
            dgvLoaiPhieu.DataSource = s.LayLoaiPhieu();
            dgvLoaiThe.DataSource = s.LayLoaiThe();
            dgvChinhSach.DataSource = s.LayChinhSach();

            cboCSLoaiPhieu.DataSource = s.LayLoaiPhieu();
            cboCSLoaiPhieu.DisplayMember = "TenLoaiPhieu";
            cboCSLoaiPhieu.ValueMember = "MaLoaiPhieu";
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThemNhom_Click(object a, EventArgs e)
        {
            H(s.ThemNhomSP(txtMaNhom.Text.Trim(), txtTenNhom.Text.Trim()));
        }

        private void btnThemKhuVuc_Click(object a, EventArgs e)
        {
            H(s.ThemKhuVuc(txtMaKV.Text.Trim(), txtTenKV.Text.Trim()));
        }

        private void btnThemLoaiPhieu_Click(object a, EventArgs e)
        {
            H(s.ThemLoaiPhieu(txtMaLP.Text.Trim(), txtTenLP.Text.Trim(), numGiaLP.Value, txtThoiGianLP.Text.Trim()));
        }

        private void btnThemChinhSach_Click(object a, EventArgs e)
        {
            string maLP = cboCSLoaiPhieu.SelectedValue == null ? "" : cboCSLoaiPhieu.SelectedValue.ToString();
            H(s.ThemChinhSach(txtMaCS.Text.Trim(), maLP, numGiaTriToiThieu.Value, txtHinhThucCS.Text.Trim()));
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }
    }
}