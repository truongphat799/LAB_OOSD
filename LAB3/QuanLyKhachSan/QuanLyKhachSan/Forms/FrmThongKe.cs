using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dtTu.Value = DateTime.Today.AddDays(-30);
            dtDen.Value = DateTime.Today;
            ThucHienThongKe();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        void ThucHienThongKe()
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
                dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
