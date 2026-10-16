using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Models;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmXuatVienCSKH : Form
    {
        readonly VienPhiVaCSKHService s = new VienPhiVaCSKHService();
        readonly BenhNhanService sBN = new BenhNhanService();

        public FrmXuatVienCSKH()
        {
            InitializeComponent();
        }

        private void FrmXuatVienCSKH_Load(object sender, EventArgs e)
        {
            cboPTTT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản QR", "Thẻ ATM/Visa", "Bảo lãnh viện phí" });
            cboPTTT.SelectedIndex = 1;

            cboQuyKham.Items.AddRange(new object[] { 1, 2, 3, 4 });
            cboQuyKham.SelectedIndex = 3; // Quý 4
            numNamKham.Value = DateTime.Now.Year;

            cboHoSoHen.DataSource = sBN.LayDanhSachHoSo();
            cboHoSoHen.DisplayMember = "MaHoSo";
            cboHoSoHen.ValueMember = "MaHoSo";

            TaiDanhSach();
        }

        void TaiDanhSach()
        {
            dgvChoXuatVien.DataSource = s.LayDanhSachChoXuatVien();
            dgvDaXuatVien.DataSource = s.LayDanhSachXuatVienVaKhoaHoSo();
            dgvLichHen.DataSource = s.LayLichHenDinhKy();
        }

        private void dgvChoXuatVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChoXuatVien.CurrentRow == null) return;
            string maPK = dgvChoXuatVien.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
            txtMaPK.Text = maPK;
            txtMaHD.Text = "HD" + DateTime.Now.ToString("yyMMddHHmmss");

            decimal tk, txn, tth, gt, tc;
            dgvChiTietVienPhi.DataSource = s.TinhChiTietVienPhi(maPK, out tk, out txn, out tth, out gt, out tc);

            lblTongTien.Text = string.Format("TỔNG THANH TOÁN: {0:N0} VNĐ", tc);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPK.Text.Trim();
            string maHD = txtMaHD.Text.Trim();
            if (string.IsNullOrWhiteSpace(maPK) || string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Vui lòng chọn phiếu khám cần thanh toán xuất viện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pttt = cboPTTT.Text;
            string dienBien = txtDienBien.Text.Trim();
            string phanUng = txtPhanUngPhu.Text.Trim();
            string danhGia = txtDanhGia.Text.Trim();

            var kq = s.ThanhToanXuatVienVaKhoaHoSo(maHD, maPK, "ND_TN_BICH", "ND_CSKH_LAN", pttt, dienBien, phanUng, danhGia);
            MessageBox.Show(kq.ThongBao, "Kết quả thanh toán & khóa hồ sơ", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) TaiDanhSach();
        }

        private void btnDatLichHen_Click(object sender, EventArgs e)
        {
            string maHoSo = cboHoSoHen.SelectedValue == null ? "" : cboHoSoHen.SelectedValue.ToString();
            int quy = Convert.ToInt32(cboQuyKham.Text);
            int nam = (int)numNamKham.Value;
            DateTime ngayHen = dtNgayGioHen.Value;
            string ghiChu = txtGhiChuHen.Text.Trim();

            var kq = s.DatLichHenDinhKy(maHoSo, "ND_CSKH_LAN", ngayHen, quy, nam, ghiChu);
            MessageBox.Show(kq.ThongBao, "Đặt lịch định kỳ", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) dgvLichHen.DataSource = s.LayLichHenDinhKy();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
