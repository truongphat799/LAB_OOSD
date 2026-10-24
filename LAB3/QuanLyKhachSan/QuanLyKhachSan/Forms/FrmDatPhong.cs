using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        readonly DatPhongService s = new DatPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<PhongDatItem> chon = new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                cboKhach.DataSource = s.LayKhach();
                cboKhach.DisplayMember = "HoTen";
                cboKhach.ValueMember = "MaKhach";

                cboNV.DataSource = dm.LayNhanVien();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";

                cboKenh.Items.Clear();
                cboKenh.Items.AddRange(new object[] { "Điện thoại", "Website", "Trực tiếp" });
                cboKenh.SelectedIndex = 0;

                dgvChon.DataSource = chon;
                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Tai()
        {
            try
            {
                dgvKhach.DataSource = s.LayKhach();
                dgvPhong.DataSource = s.LayPhong();
                dgvPhieu.DataSource = s.LayPhieuDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            H(s.ThemKhach(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtCMND.Text.Trim(), txtQT.Text.Trim(), txtSDT.Text.Trim()));
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            string p = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            foreach (var x in chon)
            {
                if (x.SoPhong == p)
                {
                    MessageBox.Show("Phòng đã có trong phiếu đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int n = (int)numSoNguoi.Value;
            decimal g = 0;
            if (dgvPhong.Columns.Contains("DonGiaNgay") && dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value != DBNull.Value)
            {
                g = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);
            }

            chon.Add(new PhongDatItem { SoPhong = p, SoNguoi = n, DonGiaNgay = g });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null && dgvChon.CurrentRow.Index >= 0 && dgvChon.CurrentRow.Index < chon.Count)
            {
                chon.RemoveAt(dgvChon.CurrentRow.Index);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var k = s.TaoDatPhong(txtSoPhieu.Text.Trim(), V(cboKhach), V(cboNV), dtLap.Value, dtNhan.Value, dtTra.Value, numCoc.Value, cboKenh.Text, new List<PhongDatItem>(chon));
            H(k);
            if (k.ThanhCong && chon.Count > 0)
            {
                chon.Clear();
            }
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) return;
            string so = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);
            txtPhieuChon.Text = so;
            try
            {
                dgvCT.DataSource = s.LayChiTiet(so);
                dgvNguoi.DataSource = s.LayNguoiLuuTru(so);
            }
            catch { }
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            H(s.ThemNguoiLuuTru(txtPhieuChon.Text.Trim(), txtNguoiPhong.Text.Trim(), txtNguoiTen.Text.Trim(), txtNguoiCMND.Text.Trim(), txtNguoiQT.Text.Trim()));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            H(s.NhanPhong(txtPhieuChon.Text.Trim(), DateTime.Now));
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            H(s.DanhDauNoShow(txtPhieuChon.Text.Trim()));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
