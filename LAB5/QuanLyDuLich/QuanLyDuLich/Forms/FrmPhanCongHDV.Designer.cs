using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmPhanCongHDV
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaPC;
        private TextBox txtMaPC;
        private Label lblHDV;
        private ComboBox cboHDV;
        private RadioButton rdoChuyenLe;
        private ComboBox cboChuyen;
        private RadioButton rdoDoan;
        private ComboBox cboDoan;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Label lblLuongTour;
        private TextBox txtLuongTour;
        private Label lblVaiTro;
        private TextBox txtVaiTro;
        private FlowLayoutPanel panelButtons;
        private Button btnThem;
        private Button btnKiemTraLich;
        private Button btnLuu;
        private Button btnDong;
        private DataGridView dgvPhanCong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpThongTin = new GroupBox();
            this.lblMaPC = new Label();
            this.txtMaPC = new TextBox();
            this.lblHDV = new Label();
            this.cboHDV = new ComboBox();
            this.rdoChuyenLe = new RadioButton();
            this.cboChuyen = new ComboBox();
            this.rdoDoan = new RadioButton();
            this.cboDoan = new ComboBox();
            this.lblTuNgay = new Label();
            this.dtpTuNgay = new DateTimePicker();
            this.lblDenNgay = new Label();
            this.dtpDenNgay = new DateTimePicker();
            this.lblLuongTour = new Label();
            this.txtLuongTour = new TextBox();
            this.lblVaiTro = new Label();
            this.txtVaiTro = new TextBox();
            this.panelButtons = new FlowLayoutPanel();
            this.btnThem = new Button();
            this.btnKiemTraLich = new Button();
            this.btnLuu = new Button();
            this.btnDong = new Button();
            this.dgvPhanCong = new DataGridView();

            // lblTitle
            this.lblTitle.Text = "PHÂN CÔNG HƯỚNG DẪN VIÊN & CHỐNG TRÙNG LỊCH";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Phân Công & Tránh Trùng Lịch Công Tác";
            this.grpThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThongTin.Dock = DockStyle.Top;
            this.grpThongTin.Height = 145;
            this.grpThongTin.Padding = new Padding(15, 10, 15, 10);

            this.lblMaPC.Text = "Mã Phân Công:"; this.lblMaPC.Location = new Point(20, 28); this.lblMaPC.AutoSize = true;
            this.txtMaPC.Location = new Point(125, 25); this.txtMaPC.Size = new Size(130, 23);

            this.lblHDV.Text = "Chọn HDV:"; this.lblHDV.Location = new Point(275, 28); this.lblHDV.AutoSize = true;
            this.cboHDV.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboHDV.Location = new Point(365, 25); this.cboHDV.Size = new Size(200, 23);

            this.lblLuongTour.Text = "Thù Lao Tour:"; this.lblLuongTour.Location = new Point(590, 28); this.lblLuongTour.AutoSize = true;
            this.txtLuongTour.Location = new Point(690, 25); this.txtLuongTour.Size = new Size(180, 23);

            this.rdoChuyenLe.Text = "Chuyến lẻ:"; this.rdoChuyenLe.Checked = true;
            this.rdoChuyenLe.Location = new Point(20, 65); this.rdoChuyenLe.AutoSize = true;
            this.cboChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChuyen.Location = new Point(125, 62); this.cboChuyen.Size = new Size(160, 23);

            this.rdoDoan.Text = "Khách đoàn:";
            this.rdoDoan.Location = new Point(300, 65); this.rdoDoan.AutoSize = true;
            this.cboDoan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDoan.Location = new Point(410, 62); this.cboDoan.Size = new Size(180, 23);

            this.lblVaiTro.Text = "Vai Trò:"; this.lblVaiTro.Location = new Point(610, 65); this.lblVaiTro.AutoSize = true;
            this.txtVaiTro.Text = "Hướng dẫn viên chính";
            this.txtVaiTro.Location = new Point(690, 62); this.txtVaiTro.Size = new Size(180, 23);

            this.lblTuNgay.Text = "Từ Ngày:"; this.lblTuNgay.Location = new Point(20, 102); this.lblTuNgay.AutoSize = true;
            this.dtpTuNgay.Format = DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new Point(125, 99); this.dtpTuNgay.Size = new Size(120, 23);

            this.lblDenNgay.Text = "Đến Ngày:"; this.lblDenNgay.Location = new Point(275, 102); this.lblDenNgay.AutoSize = true;
            this.dtpDenNgay.Format = DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new Point(365, 99); this.dtpDenNgay.Size = new Size(120, 23);

            this.grpThongTin.Controls.AddRange(new Control[] {
                this.lblMaPC, this.txtMaPC, this.lblHDV, this.cboHDV,
                this.lblLuongTour, this.txtLuongTour, this.rdoChuyenLe, this.cboChuyen,
                this.rdoDoan, this.cboDoan, this.lblVaiTro, this.txtVaiTro,
                this.lblTuNgay, this.dtpTuNgay, this.lblDenNgay, this.dtpDenNgay
            });

            // panelButtons
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 45;
            this.panelButtons.Padding = new Padding(20, 5, 20, 5);

            void StyleBtn(Button b, string txt, Color bg)
            {
                b.Text = txt; b.Size = new Size(150, 32);
                b.BackColor = bg; b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.FlatStyle = FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
            }

            StyleBtn(this.btnThem, "➕ Nhập phân công", Color.FromArgb(37, 99, 235));
            StyleBtn(this.btnKiemTraLich, "🔍 Kiểm tra trùng lịch", Color.FromArgb(234, 88, 12));
            StyleBtn(this.btnLuu, "💾 Lưu phân công", Color.FromArgb(22, 163, 74));
            StyleBtn(this.btnDong, "❌ Đóng Form", Color.FromArgb(100, 116, 139));

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnKiemTraLich.Click += new System.EventHandler(this.btnKiemTraLich_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.panelButtons.Controls.AddRange(new Control[] {
                this.btnThem, this.btnKiemTraLich, this.btnLuu, this.btnDong
            });

            // dgvPhanCong
            this.dgvPhanCong.Dock = DockStyle.Fill;
            this.dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.BackgroundColor = Color.White;
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form Properties
            this.ClientSize = new Size(940, 560);
            this.Text = "Phân Công Hướng Dẫn Viên - FrmPhanCongHDV";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
        }
    }
}
