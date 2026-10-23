namespace QuanLyNhanSu.Forms
{
    partial class FrmChamCongPhuTroi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label lblTabs;

        private System.Windows.Forms.GroupBox grpDieuKhien;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblCongChuan;
        private System.Windows.Forms.TextBox txtCongChuan;
        private System.Windows.Forms.Button btnChotCong;
        private System.Windows.Forms.Button btnKhoiTao;

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblSoGio;
        private System.Windows.Forms.NumericUpDown nudSoGio;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Button btnLuuPhuTroi;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvChamCong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.lblTabs = new System.Windows.Forms.Label();
            this.grpDieuKhien = new System.Windows.Forms.GroupBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.txtThangNam = new System.Windows.Forms.TextBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblCongChuan = new System.Windows.Forms.Label();
            this.txtCongChuan = new System.Windows.Forms.TextBox();
            this.btnChotCong = new System.Windows.Forms.Button();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblSoGio = new System.Windows.Forms.Label();
            this.nudSoGio = new System.Windows.Forms.NumericUpDown();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.btnLuuPhuTroi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.grpDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.pnlTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitleBar.Controls.Add(this.lblWindowTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(984, 45);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblWindowTitle.Location = new System.Drawing.Point(12, 12);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(465, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "📁 Kế hoạch tuần, Chấm công máy tính & Phụ trội ngoài giờ";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlTabs.Controls.Add(this.lblTabs);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 45);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(984, 32);
            this.pnlTabs.TabIndex = 1;
            // 
            // lblTabs
            // 
            this.lblTabs.AutoSize = true;
            this.lblTabs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTabs.Location = new System.Drawing.Point(12, 7);
            this.lblTabs.Name = "lblTabs";
            this.lblTabs.Size = new System.Drawing.Size(760, 17);
            this.lblTabs.TabIndex = 0;
            this.lblTabs.Text = "[ Kế hoạch làm việc tuần ]   [ Phân ca kíp xưởng sản xuất ]   [ ▶ Bảng chấm công tháng (26 công) (Đang chọn) ]   [ Đăng ký phụ trội (x1.5) ]";
            // 
            // grpDieuKhien
            // 
            this.grpDieuKhien.Controls.Add(this.lblThangNam);
            this.grpDieuKhien.Controls.Add(this.txtThangNam);
            this.grpDieuKhien.Controls.Add(this.lblPhongBan);
            this.grpDieuKhien.Controls.Add(this.cboPhongBan);
            this.grpDieuKhien.Controls.Add(this.lblCongChuan);
            this.grpDieuKhien.Controls.Add(this.txtCongChuan);
            this.grpDieuKhien.Controls.Add(this.btnChotCong);
            this.grpDieuKhien.Controls.Add(this.btnKhoiTao);
            this.grpDieuKhien.Controls.Add(this.lblNhanVien);
            this.grpDieuKhien.Controls.Add(this.cboNhanVien);
            this.grpDieuKhien.Controls.Add(this.lblSoGio);
            this.grpDieuKhien.Controls.Add(this.nudSoGio);
            this.grpDieuKhien.Controls.Add(this.lblHeSo);
            this.grpDieuKhien.Controls.Add(this.txtHeSo);
            this.grpDieuKhien.Controls.Add(this.btnLuuPhuTroi);
            this.grpDieuKhien.Controls.Add(this.btnLamMoi);
            this.grpDieuKhien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDieuKhien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpDieuKhien.Location = new System.Drawing.Point(12, 85);
            this.grpDieuKhien.Name = "grpDieuKhien";
            this.grpDieuKhien.Size = new System.Drawing.Size(960, 130);
            this.grpDieuKhien.TabIndex = 2;
            this.grpDieuKhien.TabStop = false;
            this.grpDieuKhien.Text = "Điều Khiển Bảng Chấm Công Tháng && Phụ Trội";
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThangNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblThangNam.Location = new System.Drawing.Point(15, 28);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(76, 15);
            this.lblThangNam.TabIndex = 0;
            this.lblThangNam.Text = "Tháng/Năm:";
            // 
            // txtThangNam
            // 
            this.txtThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThangNam.Location = new System.Drawing.Point(95, 25);
            this.txtThangNam.Name = "txtThangNam";
            this.txtThangNam.Size = new System.Drawing.Size(80, 23);
            this.txtThangNam.TabIndex = 1;
            this.txtThangNam.Text = "10/2026";
            this.txtThangNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPhongBan.Location = new System.Drawing.Point(190, 28);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(78, 15);
            this.lblPhongBan.TabIndex = 2;
            this.lblPhongBan.Text = "Phân xưởng:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(275, 25);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(210, 23);
            this.cboPhongBan.TabIndex = 3;
            // 
            // lblCongChuan
            // 
            this.lblCongChuan.AutoSize = true;
            this.lblCongChuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCongChuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCongChuan.Location = new System.Drawing.Point(500, 28);
            this.lblCongChuan.Name = "lblCongChuan";
            this.lblCongChuan.Size = new System.Drawing.Size(78, 15);
            this.lblCongChuan.TabIndex = 4;
            this.lblCongChuan.Text = "Công chuẩn:";
            // 
            // txtCongChuan
            // 
            this.txtCongChuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCongChuan.Location = new System.Drawing.Point(585, 25);
            this.txtCongChuan.Name = "txtCongChuan";
            this.txtCongChuan.ReadOnly = true;
            this.txtCongChuan.Size = new System.Drawing.Size(75, 23);
            this.txtCongChuan.TabIndex = 5;
            this.txtCongChuan.Text = "26 ngày";
            this.txtCongChuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChotCong
            // 
            this.btnChotCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnChotCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChotCong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnChotCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChotCong.ForeColor = System.Drawing.Color.White;
            this.btnChotCong.Location = new System.Drawing.Point(675, 22);
            this.btnChotCong.Name = "btnChotCong";
            this.btnChotCong.Size = new System.Drawing.Size(130, 28);
            this.btnChotCong.TabIndex = 6;
            this.btnChotCong.Text = "✔ Chốt Bảng Công";
            this.btnChotCong.UseVisualStyleBackColor = false;
            this.btnChotCong.Click += new System.EventHandler(this.BtnChotCong_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.BackColor = System.Drawing.Color.White;
            this.btnKhoiTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiTao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnKhoiTao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKhoiTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnKhoiTao.Location = new System.Drawing.Point(815, 22);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(130, 28);
            this.btnKhoiTao.TabIndex = 7;
            this.btnKhoiTao.Text = "+ Khởi Tạo Công";
            this.btnKhoiTao.UseVisualStyleBackColor = false;
            this.btnKhoiTao.Click += new System.EventHandler(this.BtnKhoiTao_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNhanVien.Location = new System.Drawing.Point(15, 75);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(81, 15);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "NV phụ trội:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(95, 72);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(200, 23);
            this.cboNhanVien.TabIndex = 9;
            // 
            // lblSoGio
            // 
            this.lblSoGio.AutoSize = true;
            this.lblSoGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSoGio.Location = new System.Drawing.Point(310, 75);
            this.lblSoGio.Name = "lblSoGio";
            this.lblSoGio.Size = new System.Drawing.Size(100, 15);
            this.lblSoGio.TabIndex = 10;
            this.lblSoGio.Text = "Số giờ phụ trội:";
            // 
            // nudSoGio
            // 
            this.nudSoGio.DecimalPlaces = 1;
            this.nudSoGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoGio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSoGio.Location = new System.Drawing.Point(415, 72);
            this.nudSoGio.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSoGio.Name = "nudSoGio";
            this.nudSoGio.Size = new System.Drawing.Size(70, 23);
            this.nudSoGio.TabIndex = 11;
            this.nudSoGio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoGio.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblHeSo
            // 
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblHeSo.Location = new System.Drawing.Point(500, 75);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(89, 15);
            this.lblHeSo.TabIndex = 12;
            this.lblHeSo.Text = "Hệ số phụ trội:";
            // 
            // txtHeSo
            // 
            this.txtHeSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtHeSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtHeSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.txtHeSo.Location = new System.Drawing.Point(595, 72);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.ReadOnly = true;
            this.txtHeSo.Size = new System.Drawing.Size(65, 23);
            this.txtHeSo.TabIndex = 13;
            this.txtHeSo.Text = "1.5";
            this.txtHeSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuuPhuTroi
            // 
            this.btnLuuPhuTroi.BackColor = System.Drawing.Color.White;
            this.btnLuuPhuTroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuPhuTroi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLuuPhuTroi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhuTroi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLuuPhuTroi.Location = new System.Drawing.Point(675, 68);
            this.btnLuuPhuTroi.Name = "btnLuuPhuTroi";
            this.btnLuuPhuTroi.Size = new System.Drawing.Size(130, 28);
            this.btnLuuPhuTroi.TabIndex = 14;
            this.btnLuuPhuTroi.Text = "💾 Lưu Phụ Trội";
            this.btnLuuPhuTroi.UseVisualStyleBackColor = false;
            this.btnLuuPhuTroi.Click += new System.EventHandler(this.BtnLuuPhuTroi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLamMoi.Location = new System.Drawing.Point(815, 68);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 28);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "⟳ Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamCong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamCong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChamCong.EnableHeadersVisualStyles = false;
            this.dgvChamCong.Location = new System.Drawing.Point(12, 225);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.RowTemplate.Height = 26;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(960, 325);
            this.dgvChamCong.TabIndex = 3;
            // 
            // FrmChamCongPhuTroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.grpDieuKhien);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmChamCongPhuTroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kế hoạch tuần, Chấm công máy tính & Phụ trội ngoài giờ";
            this.Load += new System.EventHandler(this.FrmChamCongPhuTroi_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.grpDieuKhien.ResumeLayout(false);
            this.grpDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
