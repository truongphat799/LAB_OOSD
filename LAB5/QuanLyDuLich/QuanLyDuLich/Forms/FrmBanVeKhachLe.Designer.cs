using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    partial class FrmBanVeKhachLe
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaVe;
        private TextBox txtMaVe;
        private Label lblChuyen;
        private ComboBox cboChuyen;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblDiemDon;
        private ComboBox cboDiemDon;
        private Label lblDiemBanVe;
        private ComboBox cboDiemBanVe;
        private Label lblSoLuongVe;
        private NumericUpDown numSoLuongVe;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblThanhTien;
        private TextBox txtThanhTien;
        private FlowLayoutPanel panelButtons;
        private Button btnThem;
        private Button btnBanVe;
        private Button btnInVe;
        private Button btnDong;
        private DataGridView dgvVe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.grpThongTin = new GroupBox();
            this.lblMaVe = new Label();
            this.txtMaVe = new TextBox();
            this.lblChuyen = new Label();
            this.cboChuyen = new ComboBox();
            this.lblKhachHang = new Label();
            this.cboKhachHang = new ComboBox();
            this.lblDiemDon = new Label();
            this.cboDiemDon = new ComboBox();
            this.lblDiemBanVe = new Label();
            this.cboDiemBanVe = new ComboBox();
            this.lblSoLuongVe = new Label();
            this.numSoLuongVe = new NumericUpDown();
            this.lblDonGia = new Label();
            this.txtDonGia = new TextBox();
            this.lblThanhTien = new Label();
            this.txtThanhTien = new TextBox();
            this.panelButtons = new FlowLayoutPanel();
            this.btnThem = new Button();
            this.btnBanVe = new Button();
            this.btnInVe = new Button();
            this.btnDong = new Button();
            this.dgvVe = new DataGridView();

            // lblTitle
            this.lblTitle.Text = "BÁN VÉ CHO KHÁCH LẺ (< 12 NGƯỜI)";
            this.lblTitle.BackColor = Color.FromArgb(30, 58, 138);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 45;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Bán Vé & Điểm Đón Cố Định";
            this.grpThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpThongTin.Dock = DockStyle.Top;
            this.grpThongTin.Height = 140;
            this.grpThongTin.Padding = new Padding(15, 10, 15, 10);

            this.lblMaVe.Text = "Mã Vé:"; this.lblMaVe.Location = new Point(20, 28); this.lblMaVe.AutoSize = true;
            this.txtMaVe.Location = new Point(95, 25); this.txtMaVe.Size = new Size(130, 23);

            this.lblChuyen.Text = "Chọn Chuyến:"; this.lblChuyen.Location = new Point(245, 28); this.lblChuyen.AutoSize = true;
            this.cboChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChuyen.Location = new Point(340, 25); this.cboChuyen.Size = new Size(180, 23);
            this.cboChuyen.SelectedIndexChanged += new System.EventHandler(this.cboChuyen_SelectedIndexChanged);

            this.lblKhachHang.Text = "Khách Hàng:"; this.lblKhachHang.Location = new Point(540, 28); this.lblKhachHang.AutoSize = true;
            this.cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new Point(630, 25); this.cboKhachHang.Size = new Size(260, 23);

            this.lblDiemDon.Text = "Điểm Đón Cố Định:"; this.lblDiemDon.Location = new Point(20, 65); this.lblDiemDon.AutoSize = true;
            this.cboDiemDon.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDiemDon.Location = new Point(145, 62); this.cboDiemDon.Size = new Size(220, 23);

            this.lblDiemBanVe.Text = "Điểm Bán Vé:"; this.lblDiemBanVe.Location = new Point(380, 65); this.lblDiemBanVe.AutoSize = true;
            this.cboDiemBanVe.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDiemBanVe.Location = new Point(475, 62); this.cboDiemBanVe.Size = new Size(200, 23);

            this.lblSoLuongVe.Text = "Số Vé (<12):"; this.lblSoLuongVe.Location = new Point(690, 65); this.lblSoLuongVe.AutoSize = true;
            this.numSoLuongVe.Location = new Point(780, 62); this.numSoLuongVe.Size = new Size(60, 23);
            this.numSoLuongVe.Minimum = 1; this.numSoLuongVe.Maximum = 11; this.numSoLuongVe.Value = 2;
            this.numSoLuongVe.ValueChanged += new System.EventHandler(this.numSoLuongVe_ValueChanged);

            this.lblDonGia.Text = "Đơn Giá:"; this.lblDonGia.Location = new Point(20, 102); this.lblDonGia.AutoSize = true;
            this.txtDonGia.Location = new Point(95, 99); this.txtDonGia.Size = new Size(130, 23); this.txtDonGia.ReadOnly = true;

            this.lblThanhTien.Text = "Tổng Phải Thu (100%):"; this.lblThanhTien.Location = new Point(245, 102); this.lblThanhTien.AutoSize = true;
            this.txtThanhTien.Location = new Point(400, 99); this.txtThanhTien.Size = new Size(180, 23); this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.ForeColor = Color.FromArgb(185, 28, 28); this.txtThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            this.grpThongTin.Controls.AddRange(new Control[] {
                this.lblMaVe, this.txtMaVe, this.lblChuyen, this.cboChuyen,
                this.lblKhachHang, this.cboKhachHang, this.lblDiemDon, this.cboDiemDon,
                this.lblDiemBanVe, this.cboDiemBanVe, this.lblSoLuongVe, this.numSoLuongVe,
                this.lblDonGia, this.txtDonGia, this.lblThanhTien, this.txtThanhTien
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

            StyleBtn(this.btnThem, "➕ Nhập vé mới", Color.FromArgb(37, 99, 235));
            StyleBtn(this.btnBanVe, "💳 Thu tiền 100% & Xuất vé", Color.FromArgb(22, 163, 74));
            StyleBtn(this.btnInVe, "🖨️ In Vé Du Lịch", Color.FromArgb(124, 58, 237));
            StyleBtn(this.btnDong, "❌ Đóng Form", Color.FromArgb(100, 116, 139));

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.panelButtons.Controls.AddRange(new Control[] {
                this.btnThem, this.btnBanVe, this.btnInVe, this.btnDong
            });

            // dgvVe
            this.dgvVe.Dock = DockStyle.Fill;
            this.dgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.BackgroundColor = Color.White;
            this.dgvVe.ReadOnly = true;
            this.dgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form Properties
            this.ClientSize = new Size(940, 560);
            this.Text = "Bán Vé Cho Khách Lẻ - FrmBanVeKhachLe";
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
        }
    }
}
