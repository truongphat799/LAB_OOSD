using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmDanhMucTour
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaTour;
        private TextBox txtMaTour;
        private Label lblTenTour;
        private TextBox txtTenTour;
        private Label lblSoNgay;
        private NumericUpDown numSoNgay;
        private Label lblSoDem;
        private NumericUpDown numSoDem;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblKhoiHanh;
        private TextBox txtKhoiHanh;
        private FlowLayoutPanel panelButtons;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnXuatBanWeb;
        private Button btnDong;
        private DataGridView dgvTour;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpThongTin = new GroupBox();
            this.lblMaTour = new Label();
            this.txtMaTour = new TextBox();
            this.lblTenTour = new Label();
            this.txtTenTour = new TextBox();
            this.lblSoNgay = new Label();
            this.numSoNgay = new NumericUpDown();
            this.lblSoDem = new Label();
            this.numSoDem = new NumericUpDown();
            this.lblDonGia = new Label();
            this.txtDonGia = new TextBox();
            this.lblKhoiHanh = new Label();
            this.txtKhoiHanh = new TextBox();
            this.panelButtons = new FlowLayoutPanel();
            this.btnThem = new Button();
            this.btnLuu = new Button();
            this.btnXoa = new Button();
            this.btnXuatBanWeb = new Button();
            this.btnDong = new Button();
            this.dgvTour = new DataGridView();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC TOUR DU LỊCH & LỘ TRÌNH";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Chi Tiết Tour";
            this.grpThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThongTin.Dock = DockStyle.Top;
            this.grpThongTin.Height = 125;
            this.grpThongTin.Padding = new Padding(15, 10, 15, 10);

            this.lblMaTour.Text = "Mã Tour:"; this.lblMaTour.Location = new Point(25, 28); this.lblMaTour.AutoSize = true;
            this.txtMaTour.Location = new Point(110, 25); this.txtMaTour.Size = new Size(130, 23);

            this.lblTenTour.Text = "Tên Tour:"; this.lblTenTour.Location = new Point(270, 28); this.lblTenTour.AutoSize = true;
            this.txtTenTour.Location = new Point(350, 25); this.txtTenTour.Size = new Size(260, 23);

            this.lblDonGia.Text = "Đơn Giá/Khách:"; this.lblDonGia.Location = new Point(635, 28); this.lblDonGia.AutoSize = true;
            this.txtDonGia.Location = new Point(740, 25); this.txtDonGia.Size = new Size(130, 23);

            this.lblSoNgay.Text = "Số Ngày:"; this.lblSoNgay.Location = new Point(25, 65); this.lblSoNgay.AutoSize = true;
            this.numSoNgay.Location = new Point(110, 62); this.numSoNgay.Size = new Size(60, 23); this.numSoNgay.Value = 3;

            this.lblSoDem.Text = "Số Đêm:"; this.lblSoDem.Location = new Point(185, 65); this.lblSoDem.AutoSize = true;
            this.numSoDem.Location = new Point(245, 62); this.numSoDem.Size = new Size(60, 23); this.numSoDem.Value = 2;

            this.lblKhoiHanh.Text = "Khởi Hành & Kết Thúc:"; this.lblKhoiHanh.Location = new Point(320, 65); this.lblKhoiHanh.AutoSize = true;
            this.txtKhoiHanh.Text = "TP.HCM (Cố định theo quy định)"; this.txtKhoiHanh.ReadOnly = true;
            this.txtKhoiHanh.Location = new Point(465, 62); this.txtKhoiHanh.Size = new Size(405, 23);

            this.grpThongTin.Controls.AddRange(new Control[] {
                this.lblMaTour, this.txtMaTour, this.lblTenTour, this.txtTenTour,
                this.lblDonGia, this.txtDonGia, this.lblSoNgay, this.numSoNgay,
                this.lblSoDem, this.numSoDem, this.lblKhoiHanh, this.txtKhoiHanh
            });

            // panelButtons
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 45;
            this.panelButtons.Padding = new Padding(20, 5, 20, 5);

            void StyleBtn(Button b, string txt, Color bg)
            {
                b.Text = txt; b.Size = new Size(125, 32);
                b.BackColor = bg; b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.FlatStyle = FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
            }

            StyleBtn(this.btnThem, "➕ Thêm mới", Color.FromArgb(37, 99, 235));
            StyleBtn(this.btnLuu, "💾 Lưu dữ liệu", Color.FromArgb(22, 163, 74));
            StyleBtn(this.btnXoa, "🗑️ Xóa Tour", Color.FromArgb(220, 38, 38));
            StyleBtn(this.btnXuatBanWeb, "🌐 Xuất bản Web", Color.FromArgb(124, 58, 237));
            StyleBtn(this.btnDong, "❌ Đóng Form", Color.FromArgb(100, 116, 139));

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXuatBanWeb.Click += new System.EventHandler(this.btnXuatBanWeb_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.panelButtons.Controls.AddRange(new Control[] {
                this.btnThem, this.btnLuu, this.btnXoa, this.btnXuatBanWeb, this.btnDong
            });

            // dgvTour
            this.dgvTour.Dock = DockStyle.Fill;
            this.dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.BackgroundColor = Color.White;
            this.dgvTour.ReadOnly = true;
            this.dgvTour.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.CellClick += new DataGridViewCellEventHandler(this.dgvTour_CellClick);

            // Form Properties
            this.ClientSize = new Size(920, 540);
            this.Text = "Quản lý Danh mục Tour - FrmDanhMucTour";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
        }
    }
}
