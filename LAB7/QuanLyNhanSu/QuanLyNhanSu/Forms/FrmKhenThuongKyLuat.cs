using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        private readonly KhenThuongKyLuatService _service = new KhenThuongKyLuatService();
        private readonly DanhMucService _danhMucService = new DanhMucService();

        public FrmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            cboLoaiQD.SelectedIndex = 0; // Khen thưởng
            cboHinhThuc.SelectedIndex = 0; // Chuyển Bảng lương
            NapDanhMuc();
            LoadData();
        }

        private void NapDanhMuc()
        {
            try
            {
                var dtNV = _danhMucService.LayDanhSachNhanVien();
                cboNhanVien.DataSource = dtNV;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Truy vấn hợp nhất Quyết định khen thưởng và kỷ luật
                string sql = @"
                    SELECT 
                        kt.SoQDKhenThuong AS SoQuyetDinh,
                        kt.MaNV,
                        nv.HoTen,
                        pb.TenPhongBan,
                        N'Khen thưởng' AS LoaiQD,
                        kt.LyDoKhenThuong AS LyDo,
                        kt.SoTienKhenThuong AS SoTien,
                        kt.HinhThucChiTra AS HinhThuc,
                        kt.TrangThai
                    FROM QuyetDinhKhenThuong kt
                    JOIN NhanVien nv ON kt.MaNV = nv.MaNV
                    JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan

                    UNION ALL

                    SELECT 
                        kl.SoQDKyLuat AS SoQuyetDinh,
                        kl.MaNV,
                        nv.HoTen,
                        pb.TenPhongBan,
                        N'Kỷ luật' AS LoaiQD,
                        kl.LyDoKyLuat AS LyDo,
                        kl.SoTienNopPhat AS SoTien,
                        kl.HinhThucNopPhat AS HinhThuc,
                        kl.TrangThai
                    FROM QuyetDinhKyLuat kl
                    JOIN NhanVien nv ON kl.MaNV = nv.MaNV
                    JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                    ORDER BY SoQuyetDinh DESC";

                DataTable dt = Db.Query(sql);
                dgvKhenThuong.DataSource = dt;

                // Format columns
                if (dgvKhenThuong.Columns["SoQuyetDinh"] != null)
                {
                    dgvKhenThuong.Columns["SoQuyetDinh"].HeaderText = "Số Quyết Định";
                    dgvKhenThuong.Columns["SoQuyetDinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvKhenThuong.Columns["MaNV"] != null)
                {
                    dgvKhenThuong.Columns["MaNV"].HeaderText = "Mã NV";
                    dgvKhenThuong.Columns["MaNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvKhenThuong.Columns["HoTen"] != null) dgvKhenThuong.Columns["HoTen"].HeaderText = "Họ và Tên";
                if (dgvKhenThuong.Columns["TenPhongBan"] != null) dgvKhenThuong.Columns["TenPhongBan"].HeaderText = "Bộ phận / Phân xưởng";
                if (dgvKhenThuong.Columns["LoaiQD"] != null)
                {
                    dgvKhenThuong.Columns["LoaiQD"].HeaderText = "Loại QĐ";
                    dgvKhenThuong.Columns["LoaiQD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvKhenThuong.Columns["LyDo"] != null) dgvKhenThuong.Columns["LyDo"].HeaderText = "Nội dung / Lý do cụ thể";
                if (dgvKhenThuong.Columns["SoTien"] != null)
                {
                    dgvKhenThuong.Columns["SoTien"].HeaderText = "Số tiền (VNĐ)";
                    dgvKhenThuong.Columns["SoTien"].DefaultCellStyle.Format = "#,##0";
                    dgvKhenThuong.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvKhenThuong.Columns["HinhThuc"] != null) dgvKhenThuong.Columns["HinhThuc"].HeaderText = "Hình thức nhận";
                if (dgvKhenThuong.Columns["TrangThai"] != null)
                {
                    dgvKhenThuong.Columns["TrangThai"].HeaderText = "Trạng thái";
                    dgvKhenThuong.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu khen thưởng/kỷ luật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDuyetQD_Click(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.SelectedValue != null ? cboNhanVien.SelectedValue.ToString() : null;
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soQD = txtSoQD.Text.Trim();
            string loai = cboLoaiQD.SelectedItem != null ? cboLoaiQD.SelectedItem.ToString() : "Khen thưởng";
            decimal soTien;
            decimal.TryParse(txtSoTien.Text.Replace(",", "").Replace(".", ""), out soTien);
            string hinhThuc = cboHinhThuc.SelectedItem != null ? cboHinhThuc.SelectedItem.ToString() : "Chuyển Bảng lương";

            KetQuaXuLy kq;
            if (loai == "Khen thưởng")
            {
                kq = _service.BanHanhQDKhenThuong(soQD, DateTime.Now.Date, "Thưởng năng suất chất lượng", maNV, null, txtLyDo.Text.Trim(), soTien, hinhThuc);
            }
            else
            {
                kq = _service.BanHanhQDKyLuat(soQD, DateTime.Now.Date, "Kỷ luật vi phạm quy trình", maNV, null, txtLyDo.Text.Trim(), soTien, hinhThuc);
            }

            MessageBox.Show(kq.ThongBao, "Duyệt Quyết Định", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadData();
        }

        private void BtnXuatPhieu_Click(object sender, EventArgs e)
        {
            string soQD = txtSoQD.Text.Trim();
            decimal soTien;
            decimal.TryParse(txtSoTien.Text.Replace(",", "").Replace(".", ""), out soTien);
            string nguoiNhan = cboNhanVien.Text;

            string soPhieu = "PC-" + DateTime.Now.ToString("yyyyMMdd-HHmm");
            var kq = _service.LapPhieuChiThuong(soPhieu, soQD, soTien, nguoiNhan, "Chi tiền mặt trực tiếp theo quyết định");

            MessageBox.Show(kq.ThongBao + "\nSố phiếu: " + soPhieu + " - Số tiền: " + soTien.ToString("#,##0") + " VNĐ",
                "Xuất Phiếu Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
