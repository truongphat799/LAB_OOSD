using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
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

        private void btnPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu())
            {
                f.ShowDialog(this);
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong())
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
