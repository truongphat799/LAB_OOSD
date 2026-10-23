using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmTuyenDungHopDong : Form
    {
        private readonly NhanSuService _nhanSuService = new NhanSuService();
        private readonly DanhMucService _danhMucService = new DanhMucService();

        public FrmTuyenDungHopDong()
        {
            InitializeComponent();
        }

        private void FrmTuyenDungHopDong_Load(object sender, EventArgs e)
        {
            NapDanhMuc();
            cboLoaiHD.SelectedIndex = 0; // Dài hạn
            LoadData();
        }

        private void NapDanhMuc()
        {
            try
            {
                var dtPB = _danhMucService.LayDanhSachPhongBan();
                cboPhongBan.DataSource = dtPB;
                cboPhongBan.DisplayMember = "TenPhongBan";
                cboPhongBan.ValueMember = "MaPhongBan";

                var dtCV = _danhMucService.LayDanhSachChucVu();
                cboChucVu.DataSource = dtCV;
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaChucVu";
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
                // Truy vấn hợp đồng lao động kết hợp thông tin nhân viên, chức vụ, mức lương, phụ cấp độc hại
                string sql = @"
                    SELECT 
                        nv.MaNV,
                        nv.HoTen,
                        pb.TenPhongBan,
                        ISNULL(cv.TenChucVu, N'Chuyên viên') AS ChucDanh,
                        ISNULL(hd.LoaiHopDong, N'Thử việc') AS LoaiHopDong,
                        hd.NgayKy,
                        ISNULL(ql.LuongCoBan, 8500000) AS LuongCoBan,
                        ISNULL(ql.PhuCapDocHai, 1800000) AS PhuCapDocHai,
                        CASE 
                            WHEN hd.LoaiHopDong = N'Dài hạn' THEN CAST(ROUND(ISNULL(ql.LuongCoBan, 8500000) * 0.105, 0) AS decimal(18,0))
                            ELSE 0 
                        END AS TienBaoHiem,
                        nv.TrangThai
                    FROM NhanVien nv
                    LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                    LEFT JOIN HopDongLaoDong hd ON nv.MaNV = hd.MaNV AND hd.TrangThai = N'Còn hiệu lực'
                    LEFT JOIN QuyetDinhLuong ql ON nv.MaNV = ql.MaNV AND ql.TrangThai = N'Hiện hành'
                    LEFT JOIN QuyetDinhChucVu qc ON nv.MaNV = qc.MaNV AND qc.TrangThai = N'Hiện hành'
                    LEFT JOIN ChucVu cv ON qc.MaChucVu = cv.MaChucVu
                    ORDER BY nv.MaNV";

                DataTable dt = Db.Query(sql);
                dgvHopDong.DataSource = dt;

                // Format Headers and Column styles
                if (dgvHopDong.Columns["MaNV"] != null) dgvHopDong.Columns["MaNV"].HeaderText = "Mã NV";
                if (dgvHopDong.Columns["HoTen"] != null) dgvHopDong.Columns["HoTen"].HeaderText = "Họ và Tên";
                if (dgvHopDong.Columns["TenPhongBan"] != null) dgvHopDong.Columns["TenPhongBan"].HeaderText = "Phân xưởng / Bộ phận";
                if (dgvHopDong.Columns["ChucDanh"] != null) dgvHopDong.Columns["ChucDanh"].HeaderText = "Chức vụ";
                if (dgvHopDong.Columns["LoaiHopDong"] != null) dgvHopDong.Columns["LoaiHopDong"].HeaderText = "Loại HĐLĐ";
                if (dgvHopDong.Columns["NgayKy"] != null)
                {
                    dgvHopDong.Columns["NgayKy"].HeaderText = "Ngày ký";
                    dgvHopDong.Columns["NgayKy"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvHopDong.Columns["NgayKy"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvHopDong.Columns["LuongCoBan"] != null)
                {
                    dgvHopDong.Columns["LuongCoBan"].HeaderText = "Lương CB (VNĐ)";
                    dgvHopDong.Columns["LuongCoBan"].DefaultCellStyle.Format = "#,##0";
                    dgvHopDong.Columns["LuongCoBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvHopDong.Columns["PhuCapDocHai"] != null)
                {
                    dgvHopDong.Columns["PhuCapDocHai"].HeaderText = "PC Độc hại";
                    dgvHopDong.Columns["PhuCapDocHai"].DefaultCellStyle.Format = "#,##0";
                    dgvHopDong.Columns["PhuCapDocHai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvHopDong.Columns["TienBaoHiem"] != null)
                {
                    dgvHopDong.Columns["TienBaoHiem"].HeaderText = "Trích BH 10.5%";
                    dgvHopDong.Columns["TienBaoHiem"].DefaultCellStyle.Format = "#,##0";
                    dgvHopDong.Columns["TienBaoHiem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvHopDong.Columns["TrangThai"] != null)
                {
                    dgvHopDong.Columns["TrangThai"].HeaderText = "Trạng thái";
                    dgvHopDong.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hợp đồng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhToanBaoHiem()
        {
            decimal luongCB;
            decimal.TryParse(txtLuongCB.Text.Replace(",", "").Replace(".", ""), out luongCB);
            bool isDaiHan = cboLoaiHD.SelectedItem != null && cboLoaiHD.SelectedItem.ToString().Contains("Dài hạn");

            if (isDaiHan)
            {
                decimal bh = luongCB * 0.105m;
                txtTrichBH.Text = bh.ToString("#,##0");
            }
            else
            {
                txtTrichBH.Text = "0"; // Hợp đồng ngắn hạn không trích đóng BHXH
            }
        }

        private void CboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhToanBaoHiem();
        }

        private void TxtLuongCB_TextChanged(object sender, EventArgs e)
        {
            TinhToanBaoHiem();
        }

        private void DgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHopDong.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value != null ? row.Cells["MaNV"].Value.ToString() : "";
                txtHoTen.Text = row.Cells["HoTen"].Value != null ? row.Cells["HoTen"].Value.ToString() : "";

                string loaiHD = row.Cells["LoaiHopDong"].Value != null ? row.Cells["LoaiHopDong"].Value.ToString() : "";
                if (loaiHD.Contains("Ngắn")) cboLoaiHD.SelectedIndex = 1;
                else cboLoaiHD.SelectedIndex = 0;

                txtLuongCB.Text = Convert.ToDecimal(row.Cells["LuongCoBan"].Value != null ? row.Cells["LuongCoBan"].Value : 0).ToString("#,##0");
                txtPCDocHai.Text = Convert.ToDecimal(row.Cells["PhuCapDocHai"].Value != null ? row.Cells["PhuCapDocHai"].Value : 0).ToString("#,##0");
                txtTrichBH.Text = Convert.ToDecimal(row.Cells["TienBaoHiem"].Value != null ? row.Cells["TienBaoHiem"].Value : 0).ToString("#,##0");
            }
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã NV và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPB = cboPhongBan.SelectedValue != null ? cboPhongBan.SelectedValue.ToString() : "PB_SX";
            string soQDTD = "QD-TD-" + txtMaNV.Text.Trim();
            decimal luongTV;
            decimal.TryParse(txtLuongCB.Text.Replace(",", "").Replace(".", ""), out luongTV);

            var kq = _nhanSuService.TiepNhanVaLapQDTuyenDung(
                txtMaNV.Text.Trim(), txtHoTen.Text.Trim(),
                new DateTime(1995, 1, 1), "Nam", "079095" + (new Random()).Next(100000, 999999),
                "TP. Hồ Chí Minh", "090" + (new Random()).Next(1000000, 9999999),
                txtMaNV.Text.Trim().ToLower() + "@sondonga.com.vn",
                maPB, soQDTD, DateTime.Now.Date, DateTime.Now.Date.AddMonths(2),
                luongTV > 0 ? luongTV * 0.85m : 7000000, "Thử việc tại xưởng sản xuất sơn Đông Á");

            MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (kq.ThanhCong) LoadData();
        }

        private void BtnKyHopDong_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã NV cần ký hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiHD = (cboLoaiHD.SelectedItem != null && cboLoaiHD.SelectedItem.ToString().Contains("Dài")) ? "Dài hạn" : "Ngắn hạn";
            string soHD = "HD-" + (loaiHD == "Dài hạn" ? "DH" : "NH") + "-" + maNV;
            string soQDTD = "QD-TD-" + maNV;
            string chucDanh = cboChucVu.Text;
            string maCV = cboChucVu.SelectedValue != null ? cboChucVu.SelectedValue.ToString() : "CV_KTV";

            decimal luongCB, pcDocHai;
            decimal.TryParse(txtLuongCB.Text.Replace(",", "").Replace(".", ""), out luongCB);
            decimal.TryParse(txtPCDocHai.Text.Replace(",", "").Replace(".", ""), out pcDocHai);

            var kq = _nhanSuService.KyHopDongVaBanHanhQuyetDinh(
                maNV, soQDTD, "Đạt", "Đáp ứng chuyên môn vận hành xưởng sơn",
                soHD, loaiHD, DateTime.Now.Date, DateTime.Now.Date,
                loaiHD == "Dài hạn" ? DateTime.Now.Date.AddYears(3) : DateTime.Now.Date.AddMonths(3),
                chucDanh, "Phân xưởng sơn Đông Á", "Đầy đủ quyền lợi BHYT, BHXH và BHTN theo luật lao động",
                "BHXH_" + maNV, "BHYT_" + maNV, "Bệnh Viện Đa Khoa TP.HCM",
                "QD-CV-" + maNV, maCV, 500000,
                "QD-L-" + maNV, luongCB, 0, pcDocHai);

            MessageBox.Show(kq.ThongBao, "Kết quả ký hợp đồng", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadData();
        }

        private void BtnDanhGia_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần đánh giá thử việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Đã ghi nhận kết quả đánh giá Thử việc: [ĐẠT YÊU CẦU] cho nhân sự " + txtHoTen.Text + ".\nĐủ điều kiện ký kết Hợp đồng lao động chính thức!",
                "Đánh Giá Thử Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
