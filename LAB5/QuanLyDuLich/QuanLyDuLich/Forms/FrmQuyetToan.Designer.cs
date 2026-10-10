using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmQuyetToan
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpDoan;
        private Label lblSoPhieu;
        private TextBox txtSoPhieu;
        private Label lblTenDoan;
        private TextBox txtTenDoan;
        private Label lblTongKinhPhi;
        private TextBox txtTongKinhPhi;
        private Label lblTienCoc;
        private TextBox txtTienCoc;
        private Label lblConLai;
        private TextBox txtConLai;
        private Button btnQuyetToan;
        private DataGridView dgvDoan;
        private GroupBox grpLuong;
        private Label lblThang;
        private NumericUpDown numThang;
        private Label lblNam;
        private NumericUpDown numNam;
        private Button btnXemLuong;
        private DataGridView dgvLuong;
        private Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpDoan = new GroupBox();
            this.lblSoPhieu = new Label();
            this.txtSoPhieu = new TextBox();
            this.lblTenDoan = new Label();
            this.txtTenDoan = new TextBox();
            this.lblTongKinhPhi = new Label();
            this.txtTongKinhPhi = new TextBox();
            this.lblTienCoc = new Label();
            this.txtTienCoc = new TextBox();
            this.lblConLai = new Label();
            this.txtConLai = new TextBox();
            this.btnQuyetToan = new Button();
            this.dgvDoan = new DataGridView();
            this.grpLuong = new GroupBox();
            this.lblThang = new Label();
            this.numThang = new NumericUpDown();
            this.lblNam = new Label();
            this.numNam = new NumericUpDown();
            this.btnXemLuong = new Button();
            this.dgvLuong = new DataGridView();
            this.btnDong = new Button();

            // lblTitle
            this.lblTitle.Text = "QUYẾT TOÁN KINH PHÍ ĐOÀN & TÍNH LƯƠNG HDV";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpDoan
            this.grpDoan.Text = "1. Quyết Toán Kinh Phí Đoàn Sau Tour";
            this.grpDoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpDoan.Location = new Point(15, 55);
            this.grpDoan.Size = new Size(910, 240);

            this.lblSoPhieu.Text = "Số Phiếu:"; this.lblSoPhieu.Location = new Point(15, 25); this.lblSoPhieu.AutoSize = true;
            this.txtSoPhieu.Location = new Point(80, 22); this.txtSoPhieu.Size = new Size(110, 23); this.txtSoPhieu.ReadOnly = true;

            this.lblTenDoan.Text = "Cơ Quan:"; this.lblTenDoan.Location = new Point(205, 25); this.lblTenDoan.AutoSize = true;
            this.txtTenDoan.Location = new Point(275, 22); this.txtTenDoan.Size = new Size(160, 23); this.txtTenDoan.ReadOnly = true;

            this.lblTongKinhPhi.Text = "Tổng Kinh Phí:"; this.lblTongKinhPhi.Location = new Point(445, 25); this.lblTongKinhPhi.AutoSize = true;
            this.txtTongKinhPhi.Location = new Point(535, 22); this.txtTongKinhPhi.Size = new Size(95, 23); this.txtTongKinhPhi.ReadOnly = true;

            this.lblTienCoc.Text = "Đã Cọc:"; this.lblTienCoc.Location = new Point(640, 25); this.lblTienCoc.AutoSize = true;
            this.txtTienCoc.Location = new Point(695, 22); this.txtTienCoc.Size = new Size(85, 23); this.txtTienCoc.ReadOnly = true;

            this.lblConLai.Text = "Còn Lại:"; this.lblConLai.Location = new Point(785, 25); this.lblConLai.AutoSize = true;
            this.txtConLai.Location = new Point(835, 22); this.txtConLai.Size = new Size(65, 23); this.txtConLai.ReadOnly = true;
            this.txtConLai.ForeColor = Color.Red;

            this.btnQuyetToan.Text = "💰 Quyết Toán (Thu tiền còn lại)";
            this.btnQuyetToan.Location = new Point(15, 52); this.btnQuyetToan.Size = new Size(200, 28);
            this.btnQuyetToan.BackColor = Color.FromArgb(22, 163, 74); this.btnQuyetToan.ForeColor = Color.White;
            this.btnQuyetToan.FlatStyle = FlatStyle.Flat; this.btnQuyetToan.FlatAppearance.BorderSize = 0;
            this.btnQuyetToan.Click += new System.EventHandler(this.btnQuyetToan_Click);

            this.dgvDoan.Location = new Point(15, 85);
            this.dgvDoan.Size = new Size(880, 145);
            this.dgvDoan.BackgroundColor = Color.White;
            this.dgvDoan.ReadOnly = true;
            this.dgvDoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoan.CellClick += new DataGridViewCellEventHandler(this.dgvDoan_CellClick);

            this.grpDoan.Controls.AddRange(new Control[] {
                this.lblSoPhieu, this.txtSoPhieu, this.lblTenDoan, this.txtTenDoan,
                this.lblTongKinhPhi, this.txtTongKinhPhi, this.lblTienCoc, this.txtTienCoc,
                this.lblConLai, this.txtConLai, this.btnQuyetToan, this.dgvDoan
            });

            // grpLuong
            this.grpLuong.Text = "2. Bảng Tính Lương Tháng HDV (BR07: Lương = Lương CB + Thù lao tour)";
            this.grpLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpLuong.Location = new Point(15, 305);
            this.grpLuong.Size = new Size(910, 240);

            this.lblThang.Text = "Tháng:"; this.lblThang.Location = new Point(15, 25); this.lblThang.AutoSize = true;
            this.numThang.Location = new Point(65, 22); this.numThang.Size = new Size(50, 23); this.numThang.Minimum = 1; this.numThang.Maximum = 12;

            this.lblNam.Text = "Năm:"; this.lblNam.Location = new Point(130, 25); this.lblNam.AutoSize = true;
            this.numNam.Location = new Point(175, 22); this.numNam.Size = new Size(70, 23); this.numNam.Minimum = 2020; this.numNam.Maximum = 2035;

            this.btnXemLuong.Text = "📊 Tính Lương";
            this.btnXemLuong.Location = new Point(265, 20); this.btnXemLuong.Size = new Size(110, 28);
            this.btnXemLuong.BackColor = Color.FromArgb(37, 99, 235); this.btnXemLuong.ForeColor = Color.White;
            this.btnXemLuong.FlatStyle = FlatStyle.Flat; this.btnXemLuong.FlatAppearance.BorderSize = 0;
            this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);

            this.btnDong.Text = "❌ Đóng Form";
            this.btnDong.Location = new Point(785, 20); this.btnDong.Size = new Size(110, 28);
            this.btnDong.BackColor = Color.FromArgb(100, 116, 139); this.btnDong.ForeColor = Color.White;
            this.btnDong.FlatStyle = FlatStyle.Flat; this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvLuong.Location = new Point(15, 55);
            this.dgvLuong.Size = new Size(880, 175);
            this.dgvLuong.BackgroundColor = Color.White;
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.grpLuong.Controls.AddRange(new Control[] {
                this.lblThang, this.numThang, this.lblNam, this.numNam,
                this.btnXemLuong, this.btnDong, this.dgvLuong
            });

            // Form Properties
            this.ClientSize = new Size(940, 560);
            this.Text = "Quyết Toán Đoàn & Tính Lương HDV - FrmQuyetToan";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.grpLuong);
            this.Controls.Add(this.grpDoan);
            this.Controls.Add(this.lblTitle);
        }
    }
}
