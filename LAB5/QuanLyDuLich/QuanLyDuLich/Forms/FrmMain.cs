using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMucTour()) f.ShowDialog(this);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            using (var f = new FrmChuyenDuLich()) f.ShowDialog(this);
        }

        private void btnDoan_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDangKyDoan()) f.ShowDialog(this);
        }

        private void btnKhachLe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmBanVeKhachLe()) f.ShowDialog(this);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhanCongHDV()) f.ShowDialog(this);
        }

        private void btnQuyetToan_Click(object sender, EventArgs e)
        {
            using (var f = new FrmQuyetToan()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhaoSatThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hệ thống?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1) { btnTour_Click(null, null); return true; }
            if (keyData == Keys.F2) { btnChuyen_Click(null, null); return true; }
            if (keyData == Keys.F3) { btnDoan_Click(null, null); return true; }
            if (keyData == Keys.F4) { btnKhachLe_Click(null, null); return true; }
            if (keyData == Keys.F5) { btnPhanCong_Click(null, null); return true; }
            if (keyData == Keys.F6) { btnQuyetToan_Click(null, null); return true; }
            if (keyData == Keys.F7) { btnThongKe_Click(null, null); return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}