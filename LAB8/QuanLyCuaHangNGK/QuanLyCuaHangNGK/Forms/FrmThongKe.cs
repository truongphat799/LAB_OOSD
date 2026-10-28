using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
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

        private void btnXem_Click(object sender, EventArgs e)
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
                var dtTongHop = s.TongHop(dtTu.Value, dtDen.Value);
                if (dtTongHop.Rows.Count > 0)
                {
                    var r = dtTongHop.Rows[0];
                    decimal dt = r["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(r["TongDoanhThu"]) : 0;
                    int soHD = r["SoHoaDon"] != DBNull.Value ? Convert.ToInt32(r["SoHoaDon"]) : 0;
                    decimal no = r["TongNoChuaThu"] != DBNull.Value ? Convert.ToDecimal(r["TongNoChuaThu"]) : 0;
                    int sapHet = r["SoMatHangSapHetTon"] != DBNull.Value ? Convert.ToInt32(r["SoMatHangSapHetTon"]) : 0;

                    lblKpiDoanhThu.Text = string.Format("Tổng doanh thu: {0:N0} đ", dt);
                    lblKpiSoHD.Text = string.Format("Số hóa đơn: {0}", soHD);
                    lblKpiCongNo.Text = string.Format("Dư nợ chưa thu: {0:N0} đ", no);
                    lblKpiSapHet.Text = string.Format("Hàng sắp hết: {0} loại", sapHet);
                }

                dgvDoanhThu.DataSource = s.DoanhThuTheoNGK(dtTu.Value, dtDen.Value);
                dgvTonKho.DataSource = s.CanhBaoTonKho();
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
