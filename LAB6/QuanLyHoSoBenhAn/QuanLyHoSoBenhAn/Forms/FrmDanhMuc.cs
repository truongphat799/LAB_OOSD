using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Models;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
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
            TaiDuLieu();
        }

        void TaiDuLieu()
        {
            dgvKhoa.DataSource = s.LayKhoaDieuTri();
            dgvDichVuXN.DataSource = s.LayDichVuXetNghiem();
            dgvThuoc.DataSource = s.LayThuoc();
            dgvNguoiDung.DataSource = s.LayNguoiDung();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) TaiDuLieu();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            H(s.ThemKhoa(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim(), txtViTriKhoa.Text.Trim(), txtTruongKhoa.Text.Trim(), txtSDTKhoa.Text.Trim()));
        }

        private void btnThemXN_Click(object sender, EventArgs e)
        {
            H(s.ThemDichVuXN(txtMaXN.Text.Trim(), txtTenXN.Text.Trim(), txtLoaiXN.Text.Trim(), numGiaXN.Value, txtPhongXN.Text.Trim()));
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            H(s.ThemThuoc(txtMaThuoc.Text.Trim(), txtTenThuoc.Text.Trim(), txtHoatChat.Text.Trim(), txtDVT.Text.Trim(),
                numGiaThuoc.Value, (int)numTonKho.Value, txtChongChiDinh.Text.Trim(), txtPhanUngPhu.Text.Trim()));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
