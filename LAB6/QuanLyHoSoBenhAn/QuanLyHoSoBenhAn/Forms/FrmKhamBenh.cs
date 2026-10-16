using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Models;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        readonly KhamBenhService sKham = new KhamBenhService();
        readonly ToaThuocService sToa = new ToaThuocService();
        readonly DanhMucService sDM = new DanhMucService();
        readonly BenhNhanService sBN = new BenhNhanService();

        BindingList<ToaThuocItem> dsThuocKe = new BindingList<ToaThuocItem>();

        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        private void FrmKhamBenh_Load(object sender, EventArgs e)
        {
            cboHoSo.DataSource = sBN.LayDanhSachHoSo();
            cboHoSo.DisplayMember = "MaHoSo";
            cboHoSo.ValueMember = "MaHoSo";

            cboBacSi.DataSource = sDM.LayBacSi();
            cboBacSi.DisplayMember = "HoTen";
            cboBacSi.ValueMember = "MaNguoiDung";

            cboKhoa.DataSource = sDM.LayKhoaDieuTri();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            cboLoaiKham.Items.AddRange(new object[] { "Khám bệnh", "Khám định kỳ theo quý", "Tái khám" });
            cboLoaiKham.SelectedIndex = 0;

            cboDichVuXN.DataSource = sDM.LayDichVuXetNghiem();
            cboDichVuXN.DisplayMember = "TenDichVuXN";
            cboDichVuXN.ValueMember = "MaDichVuXN";

            cboThuoc.DataSource = sDM.LayThuoc();
            cboThuoc.DisplayMember = "TenThuoc";
            cboThuoc.ValueMember = "MaThuoc";

            dgvToaThuoc.DataSource = dsThuocKe;

            TaiDanhSachChoKham();
            HienThiCanhBaoDiUng();
        }

        void TaiDanhSachChoKham()
        {
            dgvChoKham.DataSource = sKham.LayDanhSachChoKham();
        }

        private void cboHoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCanhBaoDiUng();
        }

        void HienThiCanhBaoDiUng()
        {
            if (cboHoSo.SelectedItem is DataRowView row)
            {
                lblTenBenhNhan.Text = "Bệnh nhân: " + row["HoTen"].ToString() + " (" + row["GioiTinh"].ToString() + " - " + Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy") + ")";
                lblTienSuBenhNen.Text = "Tiền sử bệnh: " + row["GhiChuTienSuBenh"].ToString();
                string diUng = row["TienSuDiUngThuoc"].ToString();
                lblCanhBaoDiUng.Text = "CẢNH BÁO DỊ ỨNG: " + diUng;

                if (diUng.IndexOf("Dị ứng", StringComparison.OrdinalIgnoreCase) >= 0 || diUng.IndexOf("Penicillin", StringComparison.OrdinalIgnoreCase) >= 0)
                    lblCanhBaoDiUng.ForeColor = Color.Red;
                else
                    lblCanhBaoDiUng.ForeColor = Color.DarkGreen;
            }
        }

        private void btnTaoPhieuKham_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPhieuKham.Text.Trim();
            string maHoSo = cboHoSo.SelectedValue == null ? "" : cboHoSo.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue == null ? "" : cboBacSi.SelectedValue.ToString();
            string maKhoa = cboKhoa.SelectedValue == null ? "" : cboKhoa.SelectedValue.ToString();
            string trieuChung = txtTrieuChung.Text.Trim();
            string chanDoan = txtChanDoanSoBo.Text.Trim();
            string loaiKham = cboLoaiKham.Text;

            decimal? tn = numThanNhiet.Value > 0 ? (decimal?)numThanNhiet.Value : null;
            string ha = txtHuyetAp.Text.Trim();
            int? m = numMach.Value > 0 ? (int?)numMach.Value : null;

            var kq = sKham.TaoPhieuKham(maPK, maHoSo, maBS, maKhoa, trieuChung, tn, ha, m, null, null, loaiKham, chanDoan);
            MessageBox.Show(kq.ThongBao, "Tạo phiếu khám", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong) TaiDanhSachChoKham();
        }

        private void btnChiDinhXN_Click(object sender, EventArgs e)
        {
            if (dgvChoKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đợt khám trong danh sách chờ.", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maPK = dgvChoKham.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
            string maBS = cboBacSi.SelectedValue == null ? "ND_BS_MINH" : cboBacSi.SelectedValue.ToString();
            string maXN = cboDichVuXN.SelectedValue == null ? "" : cboDichVuXN.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(maXN)) return;

            var listXN = new List<string> { maXN };
            var kq = sKham.ChiDinhXetNghiem(maPK, maBS, txtYeuCauXN.Text.Trim(), listXN);
            MessageBox.Show(kq.ThongBao, "Chỉ định xét nghiệm", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDanhSachChoKham();
                dgvKetQuaXN.DataSource = sKham.LayChiDinhVaKetQuaXN(maPK);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedItem is DataRowView row)
            {
                string ma = row["MaThuoc"].ToString();
                string ten = row["TenThuoc"].ToString();
                string hc = row["HoatChat"].ToString();
                decimal gia = Convert.ToDecimal(row["DonGia"]);
                int sl = (int)numSoLuongThuoc.Value;
                string ld = txtLieuDung.Text.Trim();
                string cd = txtCachDung.Text.Trim();

                if (string.IsNullOrWhiteSpace(ld)) ld = "Sáng 1 viên, Chiều 1 viên";
                if (string.IsNullOrWhiteSpace(cd)) cd = "Uống sau ăn no";

                foreach (var it in dsThuocKe)
                {
                    if (it.MaThuoc == ma)
                    {
                        it.SoLuong += sl;
                        dgvToaThuoc.Refresh();
                        return;
                    }
                }

                dsThuocKe.Add(new ToaThuocItem
                {
                    MaThuoc = ma,
                    TenThuoc = ten,
                    HoatChat = hc,
                    DonGia = gia,
                    SoLuong = sl,
                    LieuDung = ld,
                    CachDung = cd
                });
            }
        }

        private void btnXacNhanKeToa_Click(object sender, EventArgs e)
        {
            if (dgvChoKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đợt khám để kê toa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPK = dgvChoKham.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
            string maToa = txtMaToa.Text.Trim();
            string maBS = cboBacSi.SelectedValue == null ? "ND_BS_MINH" : cboBacSi.SelectedValue.ToString();
            string chanDoan = txtChanDoanXacDinh.Text.Trim();
            string loiDan = txtLoiDan.Text.Trim();
            DateTime? ngayTK = chkTaiKham.Checked ? (DateTime?)dtNgayTaiKham.Value : null;

            var kq = sToa.LapToaThuocVaTruTonKho(maToa, maPK, maBS, chanDoan, loiDan, ngayTK, new List<ToaThuocItem>(dsThuocKe));
            MessageBox.Show(kq.ThongBao, "Kê toa thuốc", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (kq.ThanhCong)
            {
                dsThuocKe.Clear();
                TaiDanhSachChoKham();
            }
        }

        private void dgvChoKham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChoKham.CurrentRow == null) return;
            string maPK = dgvChoKham.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
            dgvKetQuaXN.DataSource = sKham.LayChiDinhVaKetQuaXN(maPK);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
