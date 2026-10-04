using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyCuaHangEShopping.Models;
using QuanLyCuaHangEShopping.Services;

namespace QuanLyCuaHangEShopping.Forms
{
    public partial class FrmDatHang : Form
    {
        readonly DatHangService s = new DatHangService();
        readonly SanPhamService spSvc = new SanPhamService();
        BindingList<GioHangItem> gioHang = new BindingList<GioHangItem>();

        public FrmDatHang() { InitializeComponent(); }

        private void FrmDatHang_Load(object a, EventArgs e)
        {
            cboKhach.DataSource = s.LayKhachHang();
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKH";

            cboLoaiPhieu.DataSource = s.LayLoaiPhieu();
            cboLoaiPhieu.DisplayMember = "TenLoaiPhieu";
            cboLoaiPhieu.ValueMember = "MaLoaiPhieu";

            cboKhuVuc.DataSource = s.LayKhuVuc();
            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "MaKhuVuc";

            cboLoaiThe.DataSource = s.LayLoaiThe();
            cboLoaiThe.DisplayMember = "TenLoaiThe";
            cboLoaiThe.ValueMember = "TenLoaiThe";

            dgvSanPham.DataSource = spSvc.LaySanPham();
            dgvGioHang.DataSource = gioHang;

            TaiDonHang();
        }

        void TaiDonHang() { dgvDonHang.DataSource = s.LayDonHang(); }

        string V(ComboBox c) { return c.SelectedValue == null ? "" : c.SelectedValue.ToString(); }

        void CapNhatTongTien()
        {
            decimal tienHang = 0;
            foreach (var item in gioHang) tienHang += item.ThanhTien;

            decimal phi = s.TinhChiPhiGiaoHang(V(cboKhuVuc), V(cboLoaiPhieu), tienHang);
            lblTienHang.Text = $"Tiền hàng: {tienHang:N0} đ";
            lblPhiShip.Text = $"Cước giao hàng: {phi:N0} đ";
            lblTongTriGia.Text = $"TỔNG CỘNG: {(tienHang + phi):N0} đ";
        }

        private void btnThemVaoGio_Click(object a, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            string ma = Convert.ToString(dgvSanPham.CurrentRow.Cells["MaSP"].Value);
            string ten = Convert.ToString(dgvSanPham.CurrentRow.Cells["TenSP"].Value);
            decimal gia = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["GiaHienHanh"].Value);

            foreach (var item in gioHang)
            {
                if (item.MaSP == ma)
                {
                    item.SoLuong += (int)numSoLuong.Value;
                    CapNhatTongTien();
                    dgvGioHang.Refresh();
                    return;
                }
            }

            gioHang.Add(new GioHangItem { MaSP = ma, TenSP = ten, DonGia = gia, SoLuong = (int)numSoLuong.Value });
            CapNhatTongTien();
        }

        private void btnXoaKhoiGio_Click(object a, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.CurrentRow.Index >= 0)
            {
                gioHang.RemoveAt(dgvGioHang.CurrentRow.Index);
                CapNhatTongTien();
            }
        }

        private void cboLoaiPhieu_SelectedIndexChanged(object a, EventArgs e) { CapNhatTongTien(); }
        private void cboKhuVuc_SelectedIndexChanged(object a, EventArgs e) { CapNhatTongTien(); }

        private void btnXacNhanDatHang_Click(object a, EventArgs e)
        {
            var kq = s.TaoDonHangVaThanhToan(
                txtMaDon.Text.Trim(), V(cboKhach),
                txtTenNguoiNhan.Text.Trim(), txtDiaChiNhan.Text.Trim(), txtSDTNhan.Text.Trim(),
                V(cboLoaiPhieu), V(cboKhuVuc),
                cboLoaiThe.Text, txtSoThe.Text.Trim(), txtExpDate.Text.Trim(), txtCSV.Text.Trim(), txtChuThe.Text.Trim(),
                new List<GioHangItem>(gioHang));

            MessageBox.Show(kq.ThongBao, "Kết quả đặt hàng", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                gioHang.Clear();
                CapNhatTongTien();
                TaiDonHang();
            }
        }

        private void dgvDonHang_SelectionChanged(object a, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null) return;
            string maDon = Convert.ToString(dgvDonHang.CurrentRow.Cells["MaDonHang"].Value);
            dgvChiTiet.DataSource = s.LayChiTiet(maDon);
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }
    }
}