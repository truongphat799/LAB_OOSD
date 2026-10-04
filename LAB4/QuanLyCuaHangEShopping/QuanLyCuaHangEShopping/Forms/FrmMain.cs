using System;
using System.Windows.Forms;

namespace QuanLyCuaHangEShopping.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }

        private void btnDanhMuc_Click(object s, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        private void btnSanPham_Click(object s, EventArgs e)
        {
            using (var f = new FrmSanPham()) f.ShowDialog(this);
        }

        private void btnDatHang_Click(object s, EventArgs e)
        {
            using (var f = new FrmDatHang()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object s, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng e-Shopping?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}