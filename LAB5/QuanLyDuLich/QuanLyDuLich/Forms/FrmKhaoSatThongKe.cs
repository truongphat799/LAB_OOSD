using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmKhaoSatThongKe : Form
    {
        private readonly ThongKeService tkService = new ThongKeService();
        private readonly TourService tourService = new TourService();
        private readonly BanVeKhachLeService veService = new BanVeKhachLeService();

        public FrmKhaoSatThongKe()
        {
            InitializeComponent();
            numNam.Value = DateTime.Today.Year;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboTour.DataSource = tourService.LayDanhSachTour();
                cboTour.DisplayMember = "TenTour";
                cboTour.ValueMember = "MaTour";

                cboKhachHang.DataSource = veService.LayKhachLe();
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKhachHang";

                dgvKhaoSat.DataSource = tkService.LayDanhSachKhaoSat();
                dgvBaoCao.DataSource = tkService.BaoCaoChatLuongTour((int)numNam.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu khảo sát & báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtSoPhieuKS.Text = "KS" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            numDiemDV.Value = 5;
            numDiemHDV.Value = 5;
            numDiemAnO.Value = 4;
            txtYKien.Text = "Chuyến đi rất chu đáo, HDV nhiệt tình và thuyết minh hay. Khách sạn sạch sẽ gần biển.";
            txtSoPhieuKS.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieuKS.Text) || cboTour.SelectedValue == null || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu khảo sát, chọn tour và khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = tkService.ThemKhaoSat(
                txtSoPhieuKS.Text.Trim(),
                cboTour.SelectedValue.ToString(),
                cboKhachHang.SelectedValue.ToString(),
                null,
                null,
                (int)numDiemDV.Value,
                (int)numDiemHDV.Value,
                (int)numDiemAnO.Value,
                txtYKien.Text.Trim()
            );

            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thành công" : "Lỗi", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (kq.ThanhCong) LoadData();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBaoCao.DataSource = tkService.BaoCaoChatLuongTour((int)numNam.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
