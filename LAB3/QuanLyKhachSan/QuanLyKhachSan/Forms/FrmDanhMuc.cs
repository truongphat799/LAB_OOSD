using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
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
            Tai();
        }

        void Tai()
        {
            try
            {
                dgvKhu.DataSource = s.LayKhuVuc();
                dgvNV.DataSource = s.LayNhanVien();
                dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
                dgvDV.DataSource = s.LayDichVu();
                dgvQD.DataSource = s.LayQuyDinhDenBu();

                cboQDLoai.DataSource = s.LayLoaiTienNghi();
                cboQDLoai.DisplayMember = "TenLoaiTN";
                cboQDLoai.ValueMember = "MaLoaiTN";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            H(s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim()));
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            H(s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim()));
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            H(s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(), txtDVDVT.Text.Trim(), numDVGia.Value));
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string maLoai = cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString();
            H(s.ThemQuyDinh(txtQDMa.Text.Trim(), maLoai, txtQDMucDo.Text.Trim(), numQDTien.Value));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
