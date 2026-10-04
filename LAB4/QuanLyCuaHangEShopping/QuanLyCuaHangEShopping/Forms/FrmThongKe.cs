using System;
using System.Windows.Forms;
using QuanLyCuaHangEShopping.Services;

namespace QuanLyCuaHangEShopping.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe() { InitializeComponent(); }

        private void btnThongKe_Click(object a, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước Từ ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvBanChay.DataSource = s.SanPhamBanChay(dtTu.Value, dtDen.Value);
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }
    }
}