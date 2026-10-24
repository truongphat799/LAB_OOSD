using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                cboLuot.DataSource = s.LayPhieuDangO();
                cboLuot.DisplayMember = "SoPhieuDat";
                cboLuot.ValueMember = "SoPhieuDat";

                cboDV.DataSource = s.LayDichVu();
                cboDV.DisplayMember = "TenDV";
                cboDV.ValueMember = "MaDV";

                cboNV.DataSource = dm.LayNhanVien();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";

                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Tai()
        {
            try
            {
                if (cboLuot.SelectedValue != null)
                {
                    dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        private void cboLuot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r && r.Row.Table.Columns.Contains("SoPhong"))
            {
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            }
            Tai();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, V(cboNV), V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
