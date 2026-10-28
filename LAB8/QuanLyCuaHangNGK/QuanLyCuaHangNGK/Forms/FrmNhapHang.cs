using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmNhapHang : Form
    {
        readonly NhapHangService s = new NhapHangService();
        readonly DanhMucService dm = new DanhMucService();
        readonly NuocGiaiKhatService ngkService = new NuocGiaiKhatService();

        readonly List<ChiTietDatItem> listMonDat = new List<ChiTietDatItem>();
        readonly List<ChiTietGiaoItem> listMonGiao = new List<ChiTietGiaoItem>();

        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            try
            {
                cboNCC.DataSource = dm.LayNhaCungUng();
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";

                cboNV.DataSource = dm.LayNhanVien();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";

                cboNVNhan.DataSource = dm.LayNhanVien();
                cboNVNhan.DisplayMember = "HoTen";
                cboNVNhan.ValueMember = "MaNV";

                cboNGK.DataSource = ngkService.LayNuocGiaiKhat();
                cboNGK.DisplayMember = "TenNGK";
                cboNGK.ValueMember = "MaNGK";

                cboNGKGiao.DataSource = ngkService.LayNuocGiaiKhat();
                cboNGKGiao.DisplayMember = "TenNGK";
                cboNGKGiao.ValueMember = "MaNGK";

                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Tai()
        {
            try
            {
                var dtDDH = s.LayDonDatHang();
                dgvDDH.DataSource = dtDDH;

                cboDDHGiao.DataSource = s.LayDonDatHang();
                cboDDHGiao.DisplayMember = "MaDDH";
                cboDDHGiao.ValueMember = "MaDDH";

                dgvPGH.DataSource = s.LayPhieuGiao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CapNhatBangMonDat()
        {
            dgvMonDat.DataSource = null;
            dgvMonDat.DataSource = new List<ChiTietDatItem>(listMonDat);
        }

        void CapNhatBangMonGiao()
        {
            dgvMonGiao.DataSource = null;
            dgvMonGiao.DataSource = new List<ChiTietGiaoItem>(listMonGiao);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cboNGK.SelectedValue == null) return;
            string ma = cboNGK.SelectedValue.ToString();
            string ten = cboNGK.Text;

            foreach (var x in listMonDat)
            {
                if (x.MaNGK == ma)
                {
                    x.SoLuongDat += (int)numSLDat.Value;
                    CapNhatBangMonDat();
                    return;
                }
            }

            listMonDat.Add(new ChiTietDatItem
            {
                MaNGK = ma,
                TenNGK = ten,
                DonViTinh = "Thùng",
                SoLuongDat = (int)numSLDat.Value,
                DonGiaDat = numGiaDat.Value
            });
            CapNhatBangMonDat();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            string ncc = cboNCC.SelectedValue != null ? cboNCC.SelectedValue.ToString() : "";
            string nv = cboNV.SelectedValue != null ? cboNV.SelectedValue.ToString() : "";
            var k = s.TaoDonDatHang(txtDDHMa.Text.Trim(), ncc, nv, dtNgayDat.Value, dtNgayNhan.Value, listMonDat);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                listMonDat.Clear();
                CapNhatBangMonDat();
                Tai();
            }
        }

        private void dgvDDH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDDH.CurrentRow != null && dgvDDH.Columns.Contains("MaDDH"))
            {
                string ma = Convert.ToString(dgvDDH.CurrentRow.Cells["MaDDH"].Value);
                try
                {
                    dgvMonDat.DataSource = s.LayChiTietDonDat(ma);
                }
                catch { }
            }
        }

        private void btnThemMonGiao_Click(object sender, EventArgs e)
        {
            if (cboNGKGiao.SelectedValue == null) return;
            string ma = cboNGKGiao.SelectedValue.ToString();
            string ten = cboNGKGiao.Text;

            foreach (var x in listMonGiao)
            {
                if (x.MaNGK == ma)
                {
                    x.SoLuongGiao += (int)numSLGiao.Value;
                    CapNhatBangMonGiao();
                    return;
                }
            }

            listMonGiao.Add(new ChiTietGiaoItem
            {
                MaNGK = ma,
                TenNGK = ten,
                SoLuongGiao = (int)numSLGiao.Value,
                DonGiaGiao = numGiaGiao.Value
            });
            CapNhatBangMonGiao();
        }

        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            string ddh = cboDDHGiao.SelectedValue != null ? cboDDHGiao.SelectedValue.ToString() : "";
            string nv = cboNVNhan.SelectedValue != null ? cboNVNhan.SelectedValue.ToString() : "";
            var k = s.NhanHangGiaoDot(txtPGHMa.Text.Trim(), ddh, txtSoPGNCC.Text.Trim(), (int)numDot.Value, dtNgayGiao.Value, nv, listMonGiao);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                listMonGiao.Clear();
                CapNhatBangMonGiao();
                Tai();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
