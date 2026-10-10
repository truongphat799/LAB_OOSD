using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmKhaoSatThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpKhaoSat;
        private Label lblSoPhieuKS;
        private TextBox txtSoPhieuKS;
        private Label lblTour;
        private ComboBox cboTour;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblDiemDV;
        private NumericUpDown numDiemDV;
        private Label lblDiemHDV;
        private NumericUpDown numDiemHDV;
        private Label lblDiemAnO;
        private NumericUpDown numDiemAnO;
        private Label lblYKien;
        private TextBox txtYKien;
        private Button btnThem;
        private Button btnLuu;
        private DataGridView dgvKhaoSat;
        private GroupBox grpBaoCao;
        private Label lblNam;
        private NumericUpDown numNam;
        private Button btnXemBaoCao;
        private DataGridView dgvBaoCao;
        private Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpKhaoSat = new GroupBox();
            this.lblSoPhieuKS = new Label();
            this.txtSoPhieuKS = new TextBox();
            this.lblTour = new Label();
            this.cboTour = new ComboBox();
            this.lblKhachHang = new Label();
            this.cboKhachHang = new ComboBox();
            this.lblDiemDV = new Label();
            this.numDiemDV = new NumericUpDown();
            this.lblDiemHDV = new Label();
            this.numDiemHDV = new NumericUpDown();
            this.lblDiemAnO = new Label();
            this.numDiemAnO = new NumericUpDown();
            this.lblYKien = new Label();
            this.txtYKien = new TextBox();
            this.btnThem = new Button();
            this.btnLuu = new Button();
            this.dgvKhaoSat = new DataGridView();
            this.grpBaoCao = new GroupBox();
            this.lblNam = new Label();
            this.numNam = new NumericUpDown();
            this.btnXemBaoCao = new Button();
            this.dgvBaoCao = new DataGridView();
            this.btnDong = new Button();

            // lblTitle
            this.lblTitle.Text = "KHẢO SÁT CHẤT LƯỢNG SAU TOUR & THỐNG KÊ";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpKhaoSat
            this.grpKhaoSat.Text = "1. Ghi Nhận Phiếu Khảo Sát Ý Kiến Khách Hàng";
            this.grpKhaoSat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpKhaoSat.Location = new Point(15, 55);
            this.grpKhaoSat.Size = new Size(910, 240);

            this.lblSoPhieuKS.Text = "Mã Phiếu:"; this.lblSoPhieuKS.Location = new Point(15, 25); this.lblSoPhieuKS.AutoSize = true;
            this.txtSoPhieuKS.Location = new Point(80, 22); this.txtSoPhieuKS.Size = new Size(110, 23);

            this.lblTour.Text = "Tour:"; this.lblTour.Location = new Point(205, 25); this.lblTour.AutoSize = true;
            this.cboTour.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTour.Location = new Point(245, 22); this.cboTour.Size = new Size(180, 23);

            this.lblKhachHang.Text = "Khách Hàng:"; this.lblKhachHang.Location = new Point(440, 25); this.lblKhachHang.AutoSize = true;
            this.cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new Point(525, 22); this.cboKhachHang.Size = new Size(180, 23);

            this.lblDiemDV.Text = "Dịch Vụ:"; this.lblDiemDV.Location = new Point(720, 25); this.lblDiemDV.AutoSize = true;
            this.numDiemDV.Location = new Point(775, 22); this.numDiemDV.Size = new Size(40, 23); this.numDiemDV.Minimum = 1; this.numDiemDV.Maximum = 5; this.numDiemDV.Value = 5;

            this.lblDiemHDV.Text = "HDV:"; this.lblDiemHDV.Location = new Point(825, 25); this.lblDiemHDV.AutoSize = true;
            this.numDiemHDV.Location = new Point(865, 22); this.numDiemHDV.Size = new Size(40, 23); this.numDiemHDV.Minimum = 1; this.numDiemHDV.Maximum = 5; this.numDiemHDV.Value = 5;

            this.lblDiemAnO.Text = "Ăn Ở & KS:"; this.lblDiemAnO.Location = new Point(15, 58); this.lblDiemAnO.AutoSize = true;
            this.numDiemAnO.Location = new Point(80, 55); this.numDiemAnO.Size = new Size(40, 23); this.numDiemAnO.Minimum = 1; this.numDiemAnO.Maximum = 5; this.numDiemAnO.Value = 4;

            this.lblYKien.Text = "Ý Kiến Đóng Góp:"; this.lblYKien.Location = new Point(135, 58); this.lblYKien.AutoSize = true;
            this.txtYKien.Location = new Point(245, 55); this.txtYKien.Size = new Size(420, 23);

            this.btnThem.Text = "➕ Nhập mới";
            this.btnThem.Location = new Point(680, 52); this.btnThem.Size = new Size(100, 28);
            this.btnThem.BackColor = Color.FromArgb(37, 99, 235); this.btnThem.ForeColor = Color.White;
            this.btnThem.FlatStyle = FlatStyle.Flat; this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnLuu.Text = "💾 Lưu Khảo Sát";
            this.btnLuu.Location = new Point(790, 52); this.btnLuu.Size = new Size(115, 28);
            this.btnLuu.BackColor = Color.FromArgb(22, 163, 74); this.btnLuu.ForeColor = Color.White;
            this.btnLuu.FlatStyle = FlatStyle.Flat; this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.dgvKhaoSat.Location = new Point(15, 88);
            this.dgvKhaoSat.Size = new Size(880, 140);
            this.dgvKhaoSat.BackgroundColor = Color.White;
            this.dgvKhaoSat.ReadOnly = true;
            this.dgvKhaoSat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.grpKhaoSat.Controls.AddRange(new Control[] {
                this.lblSoPhieuKS, this.txtSoPhieuKS, this.lblTour, this.cboTour,
                this.lblKhachHang, this.cboKhachHang, this.lblDiemDV, this.numDiemDV,
                this.lblDiemHDV, this.numDiemHDV, this.lblDiemAnO, this.numDiemAnO,
                this.lblYKien, this.txtYKien, this.btnThem, this.btnLuu, this.dgvKhaoSat
            });

            // grpBaoCao
            this.grpBaoCao.Text = "2. Báo Cáo Thống Kê Đánh Giá Chất Lượng Tour Trong Năm";
            this.grpBaoCao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpBaoCao.Location = new Point(15, 305);
            this.grpBaoCao.Size = new Size(910, 240);

            this.lblNam.Text = "Năm Thống Kê:"; this.lblNam.Location = new Point(15, 25); this.lblNam.AutoSize = true;
            this.numNam.Location = new Point(115, 22); this.numNam.Size = new Size(70, 23); this.numNam.Minimum = 2020; this.numNam.Maximum = 2035;

            this.btnXemBaoCao.Text = "📊 Xem Báo Cáo";
            this.btnXemBaoCao.Location = new Point(205, 20); this.btnXemBaoCao.Size = new Size(120, 28);
            this.btnXemBaoCao.BackColor = Color.FromArgb(37, 99, 235); this.btnXemBaoCao.ForeColor = Color.White;
            this.btnXemBaoCao.FlatStyle = FlatStyle.Flat; this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            this.btnDong.Text = "❌ Đóng Form";
            this.btnDong.Location = new Point(785, 20); this.btnDong.Size = new Size(110, 28);
            this.btnDong.BackColor = Color.FromArgb(100, 116, 139); this.btnDong.ForeColor = Color.White;
            this.btnDong.FlatStyle = FlatStyle.Flat; this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvBaoCao.Location = new Point(15, 55);
            this.dgvBaoCao.Size = new Size(880, 175);
            this.dgvBaoCao.BackgroundColor = Color.White;
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.grpBaoCao.Controls.AddRange(new Control[] {
                this.lblNam, this.numNam, this.btnXemBaoCao, this.btnDong, this.dgvBaoCao
            });

            // Form Properties
            this.ClientSize = new Size(940, 560);
            this.Text = "Khảo Sát Ý Kiến & Thống Kê - FrmKhaoSatThongKe";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.grpBaoCao);
            this.Controls.Add(this.grpKhaoSat);
            this.Controls.Add(this.lblTitle);
        }
    }
}
