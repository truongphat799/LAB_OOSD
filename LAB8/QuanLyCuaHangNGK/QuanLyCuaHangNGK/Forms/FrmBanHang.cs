using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmBanHang : Form
    {
        readonly BanHangService s = new BanHangService();
        readonly KhachHangService khService = new KhachHangService();
        readonly DanhMucService dmService = new DanhMucService();
        readonly NuocGiaiKhatService ngkService = new NuocGiaiKhatService();

        readonly List<ChiTietBanItem> gioHang = new List<ChiTietBanItem>();
        decimal tongTien = 0;

        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                cboKhach.DataSource = khService.LayTatCa();
                cboKhach.DisplayMember = "HoTen";
                cboKhach.ValueMember = "MaKH";

                cboNV.DataSource = dmService.LayNhanVien();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";

                cboNGK.DataSource = ngkService.LayNuocGiaiKhat();
                cboNGK.DisplayMember = "TenNGK";
                cboNGK.ValueMember = "MaNGK";

                cboHT.SelectedIndex = 0;
                txtSoHD.Text = "HD" + DateTime.Now.ToString("yyMMddHHmm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = cboKhach.SelectedItem as DataRowView;
            if (row != null)
            {
                string loai = Convert.ToString(row["LoaiKhach"]);
                decimal hanMuc = row["HanMucNo"] != DBNull.Value ? Convert.ToDecimal(row["HanMucNo"]) : 0;
                decimal noHienTai = row["TongNoHienTai"] != DBNull.Value ? Convert.ToDecimal(row["TongNoHienTai"]) : 0;
                decimal conDuocNo = hanMuc - noHienTai;

                lblHanMucInfo.Text = string.Format("Loại KH: {0} | Hạn mức nợ: {1:N0} đ | Dư nợ hiện tại: {2:N0} đ | Còn được nợ: {3:N0} đ", loai, hanMuc, noHienTai, conDuocNo);
            }
        }

        private void cboNGK_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = cboNGK.SelectedItem as DataRowView;
            if (row != null)
            {
                int ton = row["SoLuongTon"] != DBNull.Value ? Convert.ToInt32(row["SoLuongTon"]) : 0;
                decimal gia = row["DonGiaBan"] != DBNull.Value ? Convert.ToDecimal(row["DonGiaBan"]) : 0;

                txtTon.Text = ton.ToString();
                numGia.Value = gia;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var row = cboNGK.SelectedItem as DataRowView;
            if (row != null)
            {
                string ma = row["MaNGK"].ToString();
                string ten = row["TenNGK"].ToString();
                string dvt = row["DonViTinh"].ToString();
                int ton = row["SoLuongTon"] != DBNull.Value ? Convert.ToInt32(row["SoLuongTon"]) : 0;
                int slMua = (int)numSL.Value;
                decimal gia = numGia.Value;

                // Tách hàng giao ngay và hàng hẹn giao nếu thiếu
                int giaoNgay = (ton >= slMua) ? slMua : ton;
                int henGiao = (slMua > ton) ? (slMua - ton) : 0;

                foreach (var x in gioHang)
                {
                    if (x.MaNGK == ma)
                    {
                        MessageBox.Show("Mặt hàng đã có trong giỏ hàng. Hãy xóa để thêm lại nếu muốn đổi số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                gioHang.Add(new ChiTietBanItem
                {
                    MaNGK = ma,
                    TenNGK = ten,
                    DonViTinh = dvt,
                    SoLuongMua = slMua,
                    DonGiaBan = gia,
                    SoLuongTon = ton,
                    SoLuongGiaoNgay = giaoNgay,
                    SoLuongHenGiao = henGiao
                });

                CapNhatGioHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.Columns.Contains("MaNGK"))
            {
                string ma = Convert.ToString(dgvGioHang.CurrentRow.Cells["MaNGK"].Value);
                gioHang.RemoveAll(x => x.MaNGK == ma);
                CapNhatGioHang();
            }
        }

        void CapNhatGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = new List<ChiTietBanItem>(gioHang);

            tongTien = 0;
            foreach (var x in gioHang) tongTien += x.ThanhTien;

            txtTong.Text = string.Format("{0:N0} đ", tongTien);

            if (cboHT.Text == "Trả chậm / Ghi nợ")
            {
                numTra.Value = 0;
                TinhTienNo();
            }
            else
            {
                numTra.Value = tongTien;
                TinhTienNo();
            }
        }

        void TinhTienNo()
        {
            decimal tra = numTra.Value;
            decimal no = (tongTien > tra) ? (tongTien - tra) : 0;
            txtNo.Text = string.Format("{0:N0} đ", no);
        }

        private void numTra_ValueChanged(object sender, EventArgs e)
        {
            TinhTienNo();
        }

        private void cboHT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHT.Text == "Trả chậm / Ghi nợ")
            {
                numTra.Value = 0;
            }
            else
            {
                numTra.Value = tongTien;
            }
            TinhTienNo();
        }

        private void btnLuuIn_Click(object sender, EventArgs e)
        {
            string kh = cboKhach.SelectedValue != null ? cboKhach.SelectedValue.ToString() : "";
            string nv = cboNV.SelectedValue != null ? cboNV.SelectedValue.ToString() : "";

            var k = s.LapHoaDon(
                txtSoHD.Text.Trim(), kh, nv, dtNgayLap.Value,
                cboHT.Text, numTra.Value, gioHang,
                dtNgayLap.Value.AddDays(2), dtNgayLap.Value.AddDays(15), "Khách mua nước giải khát");

            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                gioHang.Clear();
                CapNhatGioHang();
                txtSoHD.Text = "HD" + DateTime.Now.ToString("yyMMddHHmm");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
