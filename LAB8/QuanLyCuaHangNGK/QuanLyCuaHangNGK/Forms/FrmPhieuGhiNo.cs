using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmPhieuGhiNo : Form
    {
        readonly CongNoService s = new CongNoService();
        readonly DanhMucService dmService = new DanhMucService();

        public FrmPhieuGhiNo()
        {
            InitializeComponent();
        }

        private void FrmPhieuGhiNo_Load(object sender, EventArgs e)
        {
            try
            {
                cboNVThu.DataSource = dmService.LayNhanVien();
                cboNVThu.DisplayMember = "HoTen";
                cboNVThu.ValueMember = "MaNV";

                cboHT.SelectedIndex = 0;
                txtMaPTN.Text = "PTN" + DateTime.Now.ToString("yyMMddHHmm");

                TaiPhieuNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nợ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TaiPhieuNo()
        {
            try
            {
                dgvPhieuNo.DataSource = s.LayPhieuNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu nợ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuNo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNo.CurrentRow != null && dgvPhieuNo.Columns.Contains("MaPhieuNo"))
            {
                string ma = Convert.ToString(dgvPhieuNo.CurrentRow.Cells["MaPhieuNo"].Value);
                txtMaPN.Text = ma;
                if (dgvPhieuNo.Columns.Contains("SoTienConLai") && dgvPhieuNo.CurrentRow.Cells["SoTienConLai"].Value != DBNull.Value)
                {
                    decimal con = Convert.ToDecimal(dgvPhieuNo.CurrentRow.Cells["SoTienConLai"].Value);
                    numTienThu.Value = con;
                }
                try
                {
                    dgvThuNo.DataSource = s.LayChiTietThuNo(ma);
                }
                catch { }
            }
        }

        private void btnThuNo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPN.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu nợ cần thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nv = cboNVThu.SelectedValue != null ? cboNVThu.SelectedValue.ToString() : "";
            var k = s.ThuTienNo(txtMaPTN.Text.Trim(), txtMaPN.Text.Trim(), numTienThu.Value, cboHT.Text, nv, txtGhiChu.Text.Trim());
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                TaiPhieuNo();
                txtMaPTN.Text = "PTN" + DateTime.Now.ToString("yyMMddHHmm");
                if (!string.IsNullOrWhiteSpace(txtMaPN.Text))
                    dgvThuNo.DataSource = s.LayChiTietThuNo(txtMaPN.Text.Trim());
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
