using System;
using System.Windows.Forms;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            cboChonActor.SelectedIndex = 4; // Mặc định Giám Đốc
            CapNhatTrangThaiActor();
        }

        private void CapNhatTrangThaiActor()
        {
            lblNguoiDung.Text = "Người dùng: " + NguoiDungHienTai.HoTen;
            lblVaiTro.Text = "Vai trò hiện tại: " + NguoiDungHienTai.VaiTro;
            lblThoiGian.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Phân quyền kích hoạt/vô hiệu hóa các nút chức năng theo Actor
            string role = NguoiDungHienTai.VaiTro;
            if (role == "GIAM_DOC")
            {
                btnNavTuyenDung.Enabled = true;
                btnNavChamCong.Enabled = true;
                btnNavKhenThuong.Enabled = true;
                btnNavTinhLuong.Enabled = true;
                btnNavDanhMuc.Enabled = true;
                btnNavThongKe.Enabled = true;
            }
            else if (role == "TRUONG_PHONG")
            {
                btnNavTuyenDung.Enabled = true;
                btnNavChamCong.Enabled = true;
                btnNavKhenThuong.Enabled = true;
                btnNavTinhLuong.Enabled = false; // Trưởng phòng không duyệt bảng lương toàn công ty
                btnNavDanhMuc.Enabled = true;
                btnNavThongKe.Enabled = true;
            }
            else if (role == "NHAN_SU")
            {
                btnNavTuyenDung.Enabled = true;
                btnNavChamCong.Enabled = false;
                btnNavKhenThuong.Enabled = true;
                btnNavTinhLuong.Enabled = false;
                btnNavDanhMuc.Enabled = true;
                btnNavThongKe.Enabled = true;
            }
            else if (role == "BAN_CHAM_CONG")
            {
                btnNavTuyenDung.Enabled = false;
                btnNavChamCong.Enabled = true;
                btnNavKhenThuong.Enabled = false;
                btnNavTinhLuong.Enabled = false;
                btnNavDanhMuc.Enabled = false;
                btnNavThongKe.Enabled = true;
            }
            else if (role == "KE_TOAN")
            {
                btnNavTuyenDung.Enabled = false;
                btnNavChamCong.Enabled = false;
                btnNavKhenThuong.Enabled = true;
                btnNavTinhLuong.Enabled = true;
                btnNavDanhMuc.Enabled = true;
                btnNavThongKe.Enabled = true;
            }
        }

        private void CboChonActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboChonActor.SelectedIndex)
            {
                case 0: // TRUONG_PHONG
                    NguoiDungHienTai.MaNguoiDung = "ND02";
                    NguoiDungHienTai.TenDangNhap = "truongphong";
                    NguoiDungHienTai.HoTen = "Trần Văn Thắng (Quản Đốc SX)";
                    NguoiDungHienTai.VaiTro = "TRUONG_PHONG";
                    NguoiDungHienTai.MaPhongBan = "PB_SX";
                    break;
                case 1: // NHAN_SU
                    NguoiDungHienTai.MaNguoiDung = "ND03";
                    NguoiDungHienTai.TenDangNhap = "nhansu";
                    NguoiDungHienTai.HoTen = "Phạm Hoàng Nam (HR)";
                    NguoiDungHienTai.VaiTro = "NHAN_SU";
                    NguoiDungHienTai.MaPhongBan = "PB_TCHC";
                    break;
                case 2: // BAN_CHAM_CONG
                    NguoiDungHienTai.MaNguoiDung = "ND04";
                    NguoiDungHienTai.TenDangNhap = "chamcong";
                    NguoiDungHienTai.HoTen = "Ban Chấm Công Công Ty";
                    NguoiDungHienTai.VaiTro = "BAN_CHAM_CONG";
                    NguoiDungHienTai.MaPhongBan = "PB_TCHC";
                    break;
                case 3: // KE_TOAN
                    NguoiDungHienTai.MaNguoiDung = "ND05";
                    NguoiDungHienTai.TenDangNhap = "ketoan";
                    NguoiDungHienTai.HoTen = "Lê Thị Hồng Vân (Kế Toán Trưởng)";
                    NguoiDungHienTai.VaiTro = "KE_TOAN";
                    NguoiDungHienTai.MaPhongBan = "PB_TCKT";
                    break;
                case 4: // GIAM_DOC
                default:
                    NguoiDungHienTai.MaNguoiDung = "ND01";
                    NguoiDungHienTai.TenDangNhap = "giamdoc";
                    NguoiDungHienTai.HoTen = "Trương Gia Phát (Tổng Giám Đốc)";
                    NguoiDungHienTai.VaiTro = "GIAM_DOC";
                    NguoiDungHienTai.MaPhongBan = "PB_BGD";
                    break;
            }
            CapNhatTrangThaiActor();
        }

        private void BtnNavTuyenDung_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTuyenDungHopDong())
            {
                f.ShowDialog();
            }
        }

        private void BtnNavChamCong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmChamCongPhuTroi())
            {
                f.ShowDialog();
            }
        }

        private void BtnNavKhenThuong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhenThuongKyLuat())
            {
                f.ShowDialog();
            }
        }

        private void BtnNavTinhLuong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTinhLuong())
            {
                f.ShowDialog();
            }
        }

        private void BtnNavDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc())
            {
                f.ShowDialog();
            }
        }

        private void BtnNavThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe())
            {
                f.ShowDialog();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
