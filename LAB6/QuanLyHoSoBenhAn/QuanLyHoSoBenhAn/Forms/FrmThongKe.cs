using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
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
            dtTu.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtDen.Value = DateTime.Now;
            TaiBaoCao();
        }

        void TaiBaoCao()
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước Từ ngày.", "Lỗi khoảng ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvThuocNhieu.DataSource = s.ThuocKeNhieuNhat(dtTu.Value, dtDen.Value);
            dgvTheoKhoa.DataSource = s.ThongKeTheoKhoa(dtTu.Value, dtDen.Value);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TaiBaoCao();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
