using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmChuyenDuLich
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaChuyen;
        private TextBox txtMaChuyen;
        private Label lblTour;
        private ComboBox cboTour;
        private Label lblNgayDi;
        private DateTimePicker dtpNgayDi;
        private Label lblNgayVe;
        private DateTimePicker dtpNgayVe;
        private Label lblSoCho;
        private NumericUpDown numSoCho;
        private Label lblDiemDonGhiChu;
        private TextBox txtDiemDonGhiChu;
        private FlowLayoutPanel panelButtons;
        private Button btnThem;
        private Button btnLuu;
        private Button btnDongChuyen;
        private Button btnInDSKhach;
        private Button btnDong;
        private DataGridView dgvChuyen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpThongTin = new GroupBox();
            this.lblMaChuyen = new Label();
            this.txtMaChuyen = new TextBox();
            this.lblTour = new Label();
            this.cboTour = new ComboBox();
            this.lblNgayDi = new Label();
            this.dtpNgayDi = new DateTimePicker();
            this.lblNgayVe = new Label();
            this.dtpNgayVe = new DateTimePicker();
            this.lblSoCho = new Label();
            this.numSoCho = new NumericUpDown();
            this.lblDiemDonGhiChu = new Label();
            this.txtDiemDonGhiChu = new TextBox();
            this.panelButtons = new FlowLayoutPanel();
            this.btnThem = new Button();
            this.btnLuu = new Button();
            this.btnDongChuyen = new Button();
            this.btnInDSKhach = new Button();
            this.btnDong = new Button();
            this.dgvChuyen = new DataGridView();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ CHUYẾN DU LỊCH CHO KHÁCH LẺ";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Chuyến Định Kỳ Khách Lẻ";
            this.grpThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThongTin.Dock = DockStyle.Top;
            this.grpThongTin.Height = 125;
            this.grpThongTin.Padding = new Padding(15, 10, 15, 10);

            this.lblMaChuyen.Text = "Mã Chuyến:"; this.lblMaChuyen.Location = new Point(25, 28); this.lblMaChuyen.AutoSize = true;
            this.txtMaChuyen.Location = new Point(115, 25); this.txtMaChuyen.Size = new Size(130, 23);

            this.lblTour.Text = "Chọn Tour:"; this.lblTour.Location = new Point(270, 28); this.lblTour.AutoSize = true;
            this.cboTour.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTour.Location = new Point(350, 25); this.cboTour.Size = new Size(260, 23);

            this.lblSoCho.Text = "Số Chỗ Xe:"; this.lblSoCho.Location = new Point(635, 28); this.lblSoCho.AutoSize = true;
            this.numSoCho.Location = new Point(715, 25); this.numSoCho.Size = new Size(70, 23); this.numSoCho.Value = 45;

            this.lblNgayDi.Text = "Ngày Khởi Hành:"; this.lblNgayDi.Location = new Point(25, 65); this.lblNgayDi.AutoSize = true;
            this.dtpNgayDi.Format = DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new Point(135, 62); this.dtpNgayDi.Size = new Size(110, 23);

            this.lblNgayVe.Text = "Ngày Về:"; this.lblNgayVe.Location = new Point(270, 65); this.lblNgayVe.AutoSize = true;
            this.dtpNgayVe.Format = DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new Point(350, 62); this.dtpNgayVe.Size = new Size(110, 23);

            this.lblDiemDonGhiChu.Text = "Điểm Đón Cố Định:"; this.lblDiemDonGhiChu.Location = new Point(480, 65); this.lblDiemDonGhiChu.AutoSize = true;
            this.txtDiemDonGhiChu.Text = "Bến xe Miền Đông, NVH Thanh Niên, Ngã 4 Hàng Xanh";
            this.txtDiemDonGhiChu.ReadOnly = true;
            this.txtDiemDonGhiChu.Location = new Point(600, 62); this.txtDiemDonGhiChu.Size = new Size(290, 23);

            this.grpThongTin.Controls.AddRange(new Control[] {
                this.lblMaChuyen, this.txtMaChuyen, this.lblTour, this.cboTour,
                this.lblSoCho, this.numSoCho, this.lblNgayDi, this.dtpNgayDi,
                this.lblNgayVe, this.dtpNgayVe, this.lblDiemDonGhiChu, this.txtDiemDonGhiChu
            });

            // panelButtons
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 45;
            this.panelButtons.Padding = new Padding(20, 5, 20, 5);

            void StyleBtn(Button b, string txt, Color bg)
            {
                b.Text = txt; b.Size = new Size(135, 32);
                b.BackColor = bg; b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.FlatStyle = FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
            }

            StyleBtn(this.btnThem, "➕ Mở chuyến mới", Color.FromArgb(37, 99, 235));
            StyleBtn(this.btnLuu, "💾 Lưu chuyến", Color.FromArgb(22, 163, 74));
            StyleBtn(this.btnDongChuyen, "🚫 Đóng nhận khách", Color.FromArgb(220, 38, 38));
            StyleBtn(this.btnInDSKhach, "🖨️ In DS hành khách", Color.FromArgb(124, 58, 237));
            StyleBtn(this.btnDong, "❌ Đóng Form", Color.FromArgb(100, 116, 139));

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnDongChuyen.Click += new System.EventHandler(this.btnDongChuyen_Click);
            this.btnInDSKhach.Click += new System.EventHandler(this.btnInDSKhach_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.panelButtons.Controls.AddRange(new Control[] {
                this.btnThem, this.btnLuu, this.btnDongChuyen, this.btnInDSKhach, this.btnDong
            });

            // dgvChuyen
            this.dgvChuyen.Dock = DockStyle.Fill;
            this.dgvChuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyen.BackgroundColor = Color.White;
            this.dgvChuyen.ReadOnly = true;
            this.dgvChuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyen.CellClick += new DataGridViewCellEventHandler(this.dgvChuyen_CellClick);

            // Form Properties
            this.ClientSize = new Size(920, 540);
            this.Text = "Quản lý Chuyến Khách Lẻ - FrmChuyenDuLich";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.dgvChuyen);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
        }
    }
}
