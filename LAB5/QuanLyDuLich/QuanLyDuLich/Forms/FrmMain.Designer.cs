using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblHeader;
        private Label lblSubHeader;
        private Button btnTour;
        private Button btnChuyen;
        private Button btnDoan;
        private Button btnKhachLe;
        private Button btnPhanCong;
        private Button btnQuyetToan;
        private Button btnThongKe;
        private Button btnThoat;
        private Panel panelHeader;
        private TableLayoutPanel tableMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblHeader = new Label();
            this.lblSubHeader = new Label();
            this.tableMenu = new TableLayoutPanel();
            this.btnTour = new Button();
            this.btnChuyen = new Button();
            this.btnDoan = new Button();
            this.btnKhachLe = new Button();
            this.btnPhanCong = new Button();
            this.btnQuyetToan = new Button();
            this.btnThongKe = new Button();
            this.btnThoat = new Button();

            // Panel Header
            this.panelHeader.BackColor = Color.FromArgb(30, 58, 138); // Deep Navy
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.lblSubHeader);

            // lblHeader
            this.lblHeader.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM";
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.AutoSize = false;
            this.lblHeader.Dock = DockStyle.Top;
            this.lblHeader.Height = 45;
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubHeader
            this.lblSubHeader.Text = "HỆ THỐNG QUẢN LÝ ĐIỀU HÀNH TOUR & BÁN VÉ DU LỊCH";
            this.lblSubHeader.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblSubHeader.ForeColor = Color.FromArgb(224, 231, 255);
            this.lblSubHeader.AutoSize = false;
            this.lblSubHeader.Dock = DockStyle.Bottom;
            this.lblSubHeader.Height = 30;
            this.lblSubHeader.TextAlign = ContentAlignment.MiddleCenter;

            // TableMenu Layout
            this.tableMenu.Dock = DockStyle.Fill;
            this.tableMenu.Padding = new Padding(40, 25, 40, 25);
            this.tableMenu.ColumnCount = 2;
            this.tableMenu.RowCount = 4;
            this.tableMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int i = 0; i < 4; i++) this.tableMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            // Helper to style buttons
            void StyleButton(Button b, string text, Color bg)
            {
                b.Text = text;
                b.Dock = DockStyle.Fill;
                b.Margin = new Padding(12);
                b.BackColor = bg;
                b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Cursor = Cursors.Hand;
            }

            Color cBlue = Color.FromArgb(37, 99, 235);
            Color cGreen = Color.FromArgb(22, 163, 74);
            Color cPurple = Color.FromArgb(124, 58, 237);
            Color cOrange = Color.FromArgb(234, 88, 12);
            Color cTeal = Color.FromArgb(13, 148, 136);
            Color cSlate = Color.FromArgb(71, 85, 105);
            Color cIndigo = Color.FromArgb(79, 70, 229);
            Color cRed = Color.FromArgb(220, 38, 38);

            StyleButton(this.btnTour, "Quản lý Danh mục Tour du lịch", cBlue);
            StyleButton(this.btnChuyen, "Quản lý Chuyến khách lẻ định kỳ", cBlue);
            StyleButton(this.btnDoan, "Đăng ký Tour theo đoàn (>= 12 khách)", cBlue);
            StyleButton(this.btnKhachLe, "Bán vé Tour cho khách lẻ (< 12 khách)", cBlue);
            StyleButton(this.btnPhanCong, "Phân công Hướng dẫn viên du lịch", cBlue);
            StyleButton(this.btnQuyetToan, "Quyết toán kinh phí đoàn & Lương HDV", cBlue);
            StyleButton(this.btnThongKe, "Khảo sát chất lượng & Báo cáo", cBlue);
            StyleButton(this.btnThoat, "Thoát Hệ Thống", cRed);

            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            this.btnDoan.Click += new System.EventHandler(this.btnDoan_Click);
            this.btnKhachLe.Click += new System.EventHandler(this.btnKhachLe_Click);
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            this.btnQuyetToan.Click += new System.EventHandler(this.btnQuyetToan_Click);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.tableMenu.Controls.Add(this.btnTour, 0, 0);
            this.tableMenu.Controls.Add(this.btnChuyen, 1, 0);
            this.tableMenu.Controls.Add(this.btnDoan, 0, 1);
            this.tableMenu.Controls.Add(this.btnKhachLe, 1, 1);
            this.tableMenu.Controls.Add(this.btnPhanCong, 0, 2);
            this.tableMenu.Controls.Add(this.btnQuyetToan, 1, 2);
            this.tableMenu.Controls.Add(this.btnThongKe, 0, 3);
            this.tableMenu.Controls.Add(this.btnThoat, 1, 3);

            // Form Properties
            this.ClientSize = new Size(820, 520);
            this.Text = "Hệ thống Quản lý Tour Du Lịch Văn Hóa Việt - FrmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 250, 252);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Controls.Add(this.tableMenu);
            this.Controls.Add(this.panelHeader);
        }
    }
}