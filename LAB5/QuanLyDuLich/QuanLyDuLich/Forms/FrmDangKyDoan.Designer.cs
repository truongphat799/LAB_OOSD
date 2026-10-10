using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblSoPhieu;
        private TextBox txtSoPhieu;
        private Label lblKhachDoan;
        private ComboBox cboKhachDoan;
        private Label lblTour;
        private ComboBox cboTour;
        private Label lblNgayDi;
        private DateTimePicker dtpNgayDi;
        private Label lblSoKhach;
        private NumericUpDown numSoKhach;
        private Label lblDiaDiemDon;
        private TextBox txtDiaDiemDon;
        private CheckBox chkCoBaoHiem;
        private Label lblTienCoc;
        private TextBox txtTienCoc;
        private FlowLayoutPanel panelButtons;
        private Button btnThem;
        private Button btnLuu;
        private Button btnInPhieuCoc;
        private Button btnHuyDoan;
        private Button btnDong;
        private DataGridView dgvDoan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpThongTin = new GroupBox();
            this.lblSoPhieu = new Label();
            this.txtSoPhieu = new TextBox();
            this.lblKhachDoan = new Label();
            this.cboKhachDoan = new ComboBox();
            this.lblTour = new Label();
            this.cboTour = new ComboBox();
            this.lblNgayDi = new Label();
            this.dtpNgayDi = new DateTimePicker();
            this.lblSoKhach = new Label();
            this.numSoKhach = new NumericUpDown();
            this.lblDiaDiemDon = new Label();
            this.txtDiaDiemDon = new TextBox();
            this.chkCoBaoHiem = new CheckBox();
            this.lblTienCoc = new Label();
            this.txtTienCoc = new TextBox();
            this.panelButtons = new FlowLayoutPanel();
            this.btnThem = new Button();
            this.btnLuu = new Button();
            this.btnInPhieuCoc = new Button();
            this.btnHuyDoan = new Button();
            this.btnDong = new Button();
            this.dgvDoan = new DataGridView();

            // lblTitle
            this.lblTitle.Text = "ĐĂNG KÝ TOUR THEO ĐOÀN (>= 12 KHÁCH)";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Đăng Ký Đoàn";
            this.grpThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThongTin.Dock = DockStyle.Top;
            this.grpThongTin.Height = 140;
            this.grpThongTin.Padding = new Padding(15, 10, 15, 10);

            this.lblSoPhieu.Text = "Số Phiếu ĐK:"; this.lblSoPhieu.Location = new Point(20, 28); this.lblSoPhieu.AutoSize = true;
            this.txtSoPhieu.Location = new Point(110, 25); this.txtSoPhieu.Size = new Size(130, 23);

            this.lblKhachDoan.Text = "Cơ Quan / Đoàn:"; this.lblKhachDoan.Location = new Point(255, 28); this.lblKhachDoan.AutoSize = true;
            this.cboKhachDoan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboKhachDoan.Location = new Point(360, 25); this.cboKhachDoan.Size = new Size(240, 23);

            this.lblTour.Text = "Tour Đăng Ký:"; this.lblTour.Location = new Point(615, 28); this.lblTour.AutoSize = true;
            this.cboTour.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTour.Location = new Point(710, 25); this.cboTour.Size = new Size(180, 23);

            this.lblNgayDi.Text = "Ngày Khởi Hành:"; this.lblNgayDi.Location = new Point(20, 65); this.lblNgayDi.AutoSize = true;
            this.dtpNgayDi.Format = DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new Point(130, 62); this.dtpNgayDi.Size = new Size(110, 23);

            this.lblSoKhach.Text = "Số Khách (>=12):"; this.lblSoKhach.Location = new Point(255, 65); this.lblSoKhach.AutoSize = true;
            this.numSoKhach.Location = new Point(360, 62); this.numSoKhach.Size = new Size(70, 23); this.numSoKhach.Minimum = 12; this.numSoKhach.Maximum = 500; this.numSoKhach.Value = 25;

            this.lblTienCoc.Text = "Tiền Cọc (>=30%):"; this.lblTienCoc.Location = new Point(450, 65); this.lblTienCoc.AutoSize = true;
            this.txtTienCoc.Location = new Point(565, 62); this.txtTienCoc.Size = new Size(130, 23);

            this.chkCoBaoHiem.Text = "Mua bảo hiểm (Kèm DS)"; this.chkCoBaoHiem.Checked = true;
            this.chkCoBaoHiem.Location = new Point(710, 63); this.chkCoBaoHiem.AutoSize = true;

            this.lblDiaDiemDon.Text = "Đón Tận Nơi Theo Yêu Cầu:"; this.lblDiaDiemDon.Location = new Point(20, 102); this.lblDiaDiemDon.AutoSize = true;
            this.txtDiaDiemDon.Location = new Point(190, 99); this.txtDiaDiemDon.Size = new Size(700, 23);

            this.grpThongTin.Controls.AddRange(new Control[] {
                this.lblSoPhieu, this.txtSoPhieu, this.lblKhachDoan, this.cboKhachDoan,
                this.lblTour, this.cboTour, this.lblNgayDi, this.dtpNgayDi,
                this.lblSoKhach, this.numSoKhach, this.lblTienCoc, this.txtTienCoc,
                this.chkCoBaoHiem, this.lblDiaDiemDon, this.txtDiaDiemDon
            });

            // panelButtons
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 45;
            this.panelButtons.Padding = new Padding(20, 5, 20, 5);

            void StyleBtn(Button b, string txt, Color bg)
            {
                b.Text = txt; b.Size = new Size(140, 32);
                b.BackColor = bg; b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.FlatStyle = FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
            }

            StyleBtn(this.btnThem, "➕ Lập phiếu mới", Color.FromArgb(37, 99, 235));
            StyleBtn(this.btnLuu, "💾 Lưu & Nhận cọc", Color.FromArgb(22, 163, 74));
            StyleBtn(this.btnInPhieuCoc, "🖨️ In Phiếu Cọc", Color.FromArgb(124, 58, 237));
            StyleBtn(this.btnHuyDoan, "❌ Hủy đoàn (Mất cọc)", Color.FromArgb(220, 38, 38));
            StyleBtn(this.btnDong, "❌ Đóng Form", Color.FromArgb(100, 116, 139));

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnInPhieuCoc.Click += new System.EventHandler(this.btnInPhieuCoc_Click);
            this.btnHuyDoan.Click += new System.EventHandler(this.btnHuyDoan_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.panelButtons.Controls.AddRange(new Control[] {
                this.btnThem, this.btnLuu, this.btnInPhieuCoc, this.btnHuyDoan, this.btnDong
            });

            // dgvDoan
            this.dgvDoan.Dock = DockStyle.Fill;
            this.dgvDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoan.BackgroundColor = Color.White;
            this.dgvDoan.ReadOnly = true;
            this.dgvDoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoan.CellClick += new DataGridViewCellEventHandler(this.dgvDoan_CellClick);

            // Form Properties
            this.ClientSize = new Size(940, 560);
            this.Text = "Đăng Ký Tour Theo Đoàn - FrmDangKyDoan";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.dgvDoan);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
        }
    }
}
