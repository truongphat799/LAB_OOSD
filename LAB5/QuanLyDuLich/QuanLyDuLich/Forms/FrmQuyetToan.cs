using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmQuyetToan : Form
    {
        private readonly QuyetToanService qtService = new QuyetToanService();

        public FrmQuyetToan()
        {
            InitializeComponent();
            numThang.Value = DateTime.Today.Month;
            numNam.Value = DateTime.Today.Year;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvDoan.DataSource = qtService.LayDoanChoQuyetToan();
                if (dgvDoan.Columns["TongKinhPhi"] != null) dgvDoan.Columns["TongKinhPhi"].DefaultCellStyle.Format = "N0";
                if (dgvDoan.Columns["TienCoc"] != null) dgvDoan.Columns["TienCoc"].DefaultCellStyle.Format = "N0";
                if (dgvDoan.Columns["TienConLai"] != null) dgvDoan.Columns["TienConLai"].DefaultCellStyle.Format = "N0";

                LoadLuongHDV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu quyết toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLuongHDV()
        {
            try
            {
                dgvLuong.DataSource = qtService.TinhLuongHDV((int)numThang.Value, (int)numNam.Value);
                if (dgvLuong.Columns["LuongCanBan"] != null) dgvLuong.Columns["LuongCanBan"].DefaultCellStyle.Format = "N0";
                if (dgvLuong.Columns["TongThuLaoTour"] != null) dgvLuong.Columns["TongThuLaoTour"].DefaultCellStyle.Format = "N0";
                if (dgvLuong.Columns["TongLuongThucLinh"] != null) dgvLuong.Columns["TongLuongThucLinh"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính lương HDV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuyetToan_Click(object sender, EventArgs e)
        {
            if (dgvDoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu đoàn cần quyết toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhieu = dgvDoan.CurrentRow.Cells["SoPhieuDK"].Value.ToString();
            string trangThai = dgvDoan.CurrentRow.Cells["TrangThai"].Value?.ToString();

            if (trangThai == "Đã quyết toán")
            {
                MessageBox.Show("Phiếu đoàn này đã được quyết toán hoàn tất trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var kq = qtService.QuyetToanDoan(soPhieu);
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Lỗi", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (kq.ThanhCong) LoadData();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            LoadLuongHDV();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoan.CurrentRow != null)
            {
                var r = dgvDoan.CurrentRow;
                txtSoPhieu.Text = r.Cells["SoPhieuDK"].Value?.ToString();
                txtTenDoan.Text = r.Cells["TenCoQuan"].Value?.ToString();
                if (decimal.TryParse(r.Cells["TongKinhPhi"].Value?.ToString(), out decimal tkp)) txtTongKinhPhi.Text = tkp.ToString("N0");
                if (decimal.TryParse(r.Cells["TienCoc"].Value?.ToString(), out decimal tc)) txtTienCoc.Text = tc.ToString("N0");
                if (decimal.TryParse(r.Cells["TienConLai"].Value?.ToString(), out decimal cl)) txtConLai.Text = cl.ToString("N0");
            }
        }
    }
}
