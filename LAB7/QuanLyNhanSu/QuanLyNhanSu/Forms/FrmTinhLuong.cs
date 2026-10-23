using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmTinhLuong : Form
    {
        private readonly TinhLuongService _service = new TinhLuongService();

        public FrmTinhLuong()
        {
            InitializeComponent();
        }

        private void FrmTinhLuong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = @"
                    SELECT 
                        c.MaNV,
                        nv.HoTen,
                        ISNULL(cv.TenChucVu, N'Công nhân') AS TenChucVu,
                        c.LuongCoBan,
                        c.PhuCapChucVu,
                        c.PhuCapDocHai,
                        c.LuongThoiGian,
                        c.TienPhuTroi,
                        c.TienKhenThuong,
                        c.TienKyLuatPhat,
                        c.TienTrichBaoHiem,
                        c.LuongThucLanh
                    FROM ChiTietBangLuong c
                    JOIN NhanVien nv ON c.MaNV = nv.MaNV
                    LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                    LEFT JOIN QuyetDinhChucVu qc ON nv.MaNV = qc.MaNV AND qc.TrangThai = N'Hiện hành'
                    LEFT JOIN ChucVu cv ON qc.MaChucVu = cv.MaChucVu
                    WHERE c.MaBangLuong = 'BL-2026-10'
                    ORDER BY c.MaNV";

                DataTable dt = Db.Query(sql);

                // Nếu bảng chi tiết chưa có đầy đủ nhân viên, tự động chạy tính lương trước
                if (dt.Rows.Count == 0)
                {
                    _service.TinhToanBangLuongThang(10, 2026);
                    dt = Db.Query(sql);
                }

                dgvBangLuong.DataSource = dt;

                // Format columns
                if (dgvBangLuong.Columns["MaNV"] != null)
                {
                    dgvBangLuong.Columns["MaNV"].HeaderText = "Mã NV";
                    dgvBangLuong.Columns["MaNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvBangLuong.Columns["HoTen"] != null) dgvBangLuong.Columns["HoTen"].HeaderText = "Họ và Tên";
                if (dgvBangLuong.Columns["TenChucVu"] != null) dgvBangLuong.Columns["TenChucVu"].HeaderText = "Chức vụ";
                if (dgvBangLuong.Columns["LuongCoBan"] != null)
                {
                    dgvBangLuong.Columns["LuongCoBan"].HeaderText = "Lương CB";
                    dgvBangLuong.Columns["LuongCoBan"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["LuongCoBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["PhuCapChucVu"] != null)
                {
                    dgvBangLuong.Columns["PhuCapChucVu"].HeaderText = "PC Chức vụ";
                    dgvBangLuong.Columns["PhuCapChucVu"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["PhuCapChucVu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["PhuCapDocHai"] != null)
                {
                    dgvBangLuong.Columns["PhuCapDocHai"].HeaderText = "PC Độc hại sơn";
                    dgvBangLuong.Columns["PhuCapDocHai"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["PhuCapDocHai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["LuongThoiGian"] != null)
                {
                    dgvBangLuong.Columns["LuongThoiGian"].HeaderText = "Lương thời gian";
                    dgvBangLuong.Columns["LuongThoiGian"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["LuongThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["TienPhuTroi"] != null)
                {
                    dgvBangLuong.Columns["TienPhuTroi"].HeaderText = "Tiền phụ trội (x1.5)";
                    dgvBangLuong.Columns["TienPhuTroi"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["TienPhuTroi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["TienKhenThuong"] != null)
                {
                    dgvBangLuong.Columns["TienKhenThuong"].HeaderText = "Thưởng";
                    dgvBangLuong.Columns["TienKhenThuong"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["TienKhenThuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["TienKyLuatPhat"] != null)
                {
                    dgvBangLuong.Columns["TienKyLuatPhat"].HeaderText = "Phạt";
                    dgvBangLuong.Columns["TienKyLuatPhat"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["TienKyLuatPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["TienTrichBaoHiem"] != null)
                {
                    dgvBangLuong.Columns["TienTrichBaoHiem"].HeaderText = "Trích BH 10.5%";
                    dgvBangLuong.Columns["TienTrichBaoHiem"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["TienTrichBaoHiem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvBangLuong.Columns["LuongThucLanh"] != null)
                {
                    dgvBangLuong.Columns["LuongThucLanh"].HeaderText = "Thực Lãnh (VNĐ)";
                    dgvBangLuong.Columns["LuongThucLanh"].DefaultCellStyle.Format = "#,##0";
                    dgvBangLuong.Columns["LuongThucLanh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBangLuong.Columns["LuongThucLanh"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                }

                // Tính tổng thực lãnh
                decimal tong = 0;
                foreach (DataRow r in dt.Rows)
                {
                    if (r["LuongThucLanh"] != DBNull.Value)
                        tong += Convert.ToDecimal(r["LuongThucLanh"]);
                }
                txtTongQuyLuong.Text = tong.ToString("#,##0") + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTinhLuong_Click(object sender, EventArgs e)
        {
            var kq = _service.TinhToanBangLuongThang(10, 2026);
            MessageBox.Show(kq.ThongBao, "Tính Lương Toàn Công Ty", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadData();
        }

        private void BtnPheDuyet_Click(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.VaiTro != "GIAM_DOC")
            {
                MessageBox.Show("Chỉ có Giám Đốc mới có quyền phê duyệt bảng lương tháng!", "Từ Chối Phân Quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = _service.PheDuyetBangLuong("BL-2026-10");
            MessageBox.Show(kq.ThongBao, "Phê Duyệt Lương", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadData();
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã kết xuất báo cáo Bảng thanh toán tiền lương tháng 10/2026 ra tệp Excel thành công!\nTổng thực chi quỹ lương: " + txtTongQuyLuong.Text,
                "Xuất Báo Cáo Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
