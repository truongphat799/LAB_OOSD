using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmPhieuHen : Form
    {
        readonly PhieuHenService s = new PhieuHenService();

        public FrmPhieuHen()
        {
            InitializeComponent();
        }

        private void FrmPhieuHen_Load(object sender, EventArgs e)
        {
            TaiPhieu();
        }

        void TaiPhieu()
        {
            try
            {
                dgvPhieuHen.DataSource = s.LayPhieuHen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuHen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuHen.CurrentRow != null && dgvPhieuHen.Columns.Contains("MaPhieuHen"))
            {
                string ma = Convert.ToString(dgvPhieuHen.CurrentRow.Cells["MaPhieuHen"].Value);
                txtMaPH.Text = ma;
                try
                {
                    dgvCTHen.DataSource = s.LayChiTietPhieuHen(ma);
                }
                catch { }
            }
        }

        private void dgvCTHen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTHen.CurrentRow != null && dgvCTHen.Columns.Contains("MaNGK"))
            {
                txtMaNGK.Text = Convert.ToString(dgvCTHen.CurrentRow.Cells["MaNGK"].Value);
                if (dgvCTHen.Columns.Contains("ConLai") && dgvCTHen.CurrentRow.Cells["ConLai"].Value != DBNull.Value)
                {
                    decimal con = Convert.ToDecimal(dgvCTHen.CurrentRow.Cells["ConLai"].Value);
                    if (con > 0)
                        numSLGiao.Value = con;
                }
            }
        }

        private void btnGiaoDot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPH.Text) || string.IsNullOrWhiteSpace(txtMaNGK.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu hẹn và mặt hàng cần giao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var k = s.GiaoHangDot(txtMaPH.Text.Trim(), txtMaNGK.Text.Trim(), (int)numSLGiao.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                TaiPhieu();
                if (!string.IsNullOrWhiteSpace(txtMaPH.Text))
                {
                    dgvCTHen.DataSource = s.LayChiTietPhieuHen(txtMaPH.Text.Trim());
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
