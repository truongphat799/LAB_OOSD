using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTiepNhan()) f.ShowDialog(this);
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhamBenh()) f.ShowDialog(this);
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            using (var f = new FrmXuatVienCSKH()) f.ShowDialog(this);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đóng hệ thống Quản lý Hồ sơ Bệnh án?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
