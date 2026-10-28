using System;
using System.Windows.Forms;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc())
            {
                f.ShowDialog(this);
            }
        }

        private void btnNuocGiaiKhat_Click(object sender, EventArgs e)
        {
            using (var f = new FrmNuocGiaiKhat())
            {
                f.ShowDialog(this);
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhachHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            using (var f = new FrmNhapHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            using (var f = new FrmBanHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnPhieuHen_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhieuHen())
            {
                f.ShowDialog(this);
            }
        }

        private void btnPhieuGhiNo_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhieuGhiNo())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
