using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService _service = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = @"
                    SELECT 
                        pb.MaPhongBan,
                        pb.TenPhongBan,
                        pb.DiaDiem,
                        pb.TruongPhong,
                        pb.SoDienThoai,
                        CASE 
                            WHEN pb.MaPhongBan = 'PX01' OR pb.MaPhongBan = 'PB_SX' THEN 1800000
                            WHEN pb.MaPhongBan = 'PX02' THEN 800000
                            WHEN pb.MaPhongBan = 'PX03' THEN 1000000
                            WHEN pb.MaPhongBan = 'PB01' THEN 1200000
                            ELSE 0
                        END AS PhuCapDocHai,
                        CASE 
                            WHEN pb.MaPhongBan = 'PX01' OR pb.MaPhongBan = 'PB_SX' THEN N'15 người'
                            WHEN pb.MaPhongBan = 'PX02' THEN N'20 người'
                            WHEN pb.MaPhongBan = 'PX03' THEN N'8 người'
                            WHEN pb.MaPhongBan = 'PB01' THEN N'6 người'
                            WHEN pb.MaPhongBan = 'PB02' OR pb.MaPhongBan = 'PB_TCKT' THEN N'5 người'
                            ELSE N'4 người'
                        END AS DinhBien
                    FROM PhongBan pb
                    ORDER BY pb.MaPhongBan";

                DataTable dt = Db.Query(sql);
                dgvDanhMuc.DataSource = dt;

                // Format columns
                if (dgvDanhMuc.Columns["MaPhongBan"] != null)
                {
                    dgvDanhMuc.Columns["MaPhongBan"].HeaderText = "Mã Đơn Vị";
                    dgvDanhMuc.Columns["MaPhongBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvDanhMuc.Columns["TenPhongBan"] != null) dgvDanhMuc.Columns["TenPhongBan"].HeaderText = "Tên Phòng ban / Phân xưởng";
                if (dgvDanhMuc.Columns["DiaDiem"] != null) dgvDanhMuc.Columns["DiaDiem"].HeaderText = "Địa điểm / Vị trí";
                if (dgvDanhMuc.Columns["TruongPhong"] != null) dgvDanhMuc.Columns["TruongPhong"].HeaderText = "Trưởng đơn vị / Quản đốc";
                if (dgvDanhMuc.Columns["SoDienThoai"] != null)
                {
                    dgvDanhMuc.Columns["SoDienThoai"].HeaderText = "Số ĐT nội bộ";
                    dgvDanhMuc.Columns["SoDienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvDanhMuc.Columns["PhuCapDocHai"] != null)
                {
                    dgvDanhMuc.Columns["PhuCapDocHai"].HeaderText = "Mức PC Độc hại (VNĐ)";
                    dgvDanhMuc.Columns["PhuCapDocHai"].DefaultCellStyle.Format = "#,##0";
                    dgvDanhMuc.Columns["PhuCapDocHai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvDanhMuc.Columns["DinhBien"] != null)
                {
                    dgvDanhMuc.Columns["DinhBien"].HeaderText = "Định biên nhân sự";
                    dgvDanhMuc.Columns["DinhBien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục phòng ban: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaDonVi.Text = row.Cells["MaPhongBan"].Value != null ? row.Cells["MaPhongBan"].Value.ToString() : "";
                txtTenDonVi.Text = row.Cells["TenPhongBan"].Value != null ? row.Cells["TenPhongBan"].Value.ToString() : "";
                txtDiaDiem.Text = row.Cells["DiaDiem"].Value != null ? row.Cells["DiaDiem"].Value.ToString() : "";
                txtTruongDonVi.Text = row.Cells["TruongPhong"].Value != null ? row.Cells["TruongPhong"].Value.ToString() : "";
                txtDienThoai.Text = row.Cells["SoDienThoai"].Value != null ? row.Cells["SoDienThoai"].Value.ToString() : "";
                txtPCDocHai.Text = Convert.ToDecimal(row.Cells["PhuCapDocHai"].Value != null ? row.Cells["PhuCapDocHai"].Value : 0).ToString("#,##0");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaDonVi.Text.Trim();
            string ten = txtTenDonVi.Text.Trim();
            string dd = txtDiaDiem.Text.Trim();
            string tp = txtTruongDonVi.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Mã và Tên đơn vị không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int count = (int)Db.Scalar("SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan = @m", new System.Data.SqlClient.SqlParameter("@m", ma));
                if (count > 0)
                {
                    Db.Execute(@"UPDATE PhongBan 
                                 SET TenPhongBan = @t, DiaDiem = @dd, TruongPhong = @tp, SoDienThoai = @sdt
                                 WHERE MaPhongBan = @m",
                                 new System.Data.SqlClient.SqlParameter("@t", ten),
                                 new System.Data.SqlClient.SqlParameter("@dd", dd),
                                 new System.Data.SqlClient.SqlParameter("@tp", tp),
                                 new System.Data.SqlClient.SqlParameter("@sdt", sdt),
                                 new System.Data.SqlClient.SqlParameter("@m", ma));
                    MessageBox.Show("Cập nhật thông tin phân xưởng / phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Db.Execute(@"INSERT INTO PhongBan(MaPhongBan, TenPhongBan, DiaDiem, TruongPhong, SoDienThoai)
                                 VALUES(@m, @t, @dd, @tp, @sdt)",
                                 new System.Data.SqlClient.SqlParameter("@m", ma),
                                 new System.Data.SqlClient.SqlParameter("@t", ten),
                                 new System.Data.SqlClient.SqlParameter("@dd", dd),
                                 new System.Data.SqlClient.SqlParameter("@tp", tp),
                                 new System.Data.SqlClient.SqlParameter("@sdt", sdt));
                    MessageBox.Show("Thêm mới phân xưởng / phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
