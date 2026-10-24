using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                cboDat.DataSource = s.LayPhieuDangO();
                cboDat.DisplayMember = "SoPhieuDat";
                cboDat.ValueMember = "SoPhieuDat";

                cboNV.DataSource = dm.LayNhanVien();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";

                cboNV2.DataSource = dm.LayNhanVien();
                cboNV2.DisplayMember = "HoTen";
                cboNV2.ValueMember = "MaNV";

                cboHT.Items.Clear();
                cboHT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" });
                cboHT.SelectedIndex = 0;

                dgvDBChon.DataSource = db;
                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu trả phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        void Tai()
        {
            try
            {
                if (cboDat.SelectedValue != null)
                {
                    string so = V(cboDat);
                    dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
                }
                dgvHD.DataSource = s.LayHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDat.SelectedValue != null)
            {
                string so = V(cboDat);
                try
                {
                    dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
                }
                catch { }
            }
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            try
            {
                dgvTN.DataSource = s.LayTienNghiPhong(txtPhong.Text);
            }
            catch { }
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
            string ten = dgvTN.Columns.Contains("TenLoaiTN") ? Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value) : "";

            foreach (var x in db)
            {
                if (x.MaTienNghi == ma)
                {
                    MessageBox.Show("Tiện nghi đã có trong phiếu đền bù.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            db.Add(new DenBuItem
            {
                MaTienNghi = ma,
                TenLoaiTN = ten,
                MucDoThietHai = txtMucDo.Text.Trim(),
                SoTien = numDenBu.Value
            });
        }

        private void btnLapDB_Click(object sender, EventArgs e)
        {
            var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), txtPhong.Text.Trim(), DateTime.Now, V(cboNV), new List<DenBuItem>(db));
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                db.Clear();
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, V(cboNV2), (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHD.CurrentRow != null && dgvHD.Columns.Contains("SoHoaDon"))
            {
                txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
                if (dgvHD.Columns.Contains("TongTien") && dgvHD.CurrentRow.Cells["TongTien"].Value != DBNull.Value)
                {
                    numTienTT.Value = Convert.ToDecimal(dgvHD.CurrentRow.Cells["TongTien"].Value);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var k = s.ThanhToan(txtMaTT.Text.Trim(), txtHDChon.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
