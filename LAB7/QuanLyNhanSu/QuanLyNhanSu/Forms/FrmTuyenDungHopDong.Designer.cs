namespace QuanLyNhanSu.Forms
{
    partial class FrmTuyenDungHopDong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label lblTabs;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Button btnThemMoi;

        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.ComboBox cboLoaiHD;
        private System.Windows.Forms.Label lblLuongCB;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label lblPCDocHai;
        private System.Windows.Forms.TextBox txtPCDocHai;
        private System.Windows.Forms.Label lblTrichBH;
        private System.Windows.Forms.TextBox txtTrichBH;

        private System.Windows.Forms.Button btnKyHopDong;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvHopDong;

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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.lblLuongCB = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.lblPCDocHai = new System.Windows.Forms.Label();
            this.txtPCDocHai = new System.Windows.Forms.TextBox();
            this.lblTrichBH = new System.Windows.Forms.Label();
            this.txtTrichBH = new System.Windows.Forms.TextBox();
            this.btnKyHopDong = new System.Windows.Forms.Button();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
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
            this.lblWindowTitle.Size = new System.Drawing.Size(433, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "📁 Quản lý Tuyển dụng, Thử việc & Hợp đồng lao động";
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
            this.lblTabs.Text = "[ Đề xuất tuyển dụng ]   [ Quyết định thử việc ]   [ Đánh giá thử việc ]   [ ▶ Hợp đồng lao động (Đang chọn) ]   [ Hồ sơ BHYT & BHXH ]";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaNV);
            this.grpThongTin.Controls.Add(this.txtMaNV);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblPhongBan);
            this.grpThongTin.Controls.Add(this.cboPhongBan);
            this.grpThongTin.Controls.Add(this.lblChucVu);
            this.grpThongTin.Controls.Add(this.cboChucVu);
            this.grpThongTin.Controls.Add(this.btnThemMoi);
            this.grpThongTin.Controls.Add(this.lblLoaiHD);
            this.grpThongTin.Controls.Add(this.cboLoaiHD);
            this.grpThongTin.Controls.Add(this.lblLuongCB);
            this.grpThongTin.Controls.Add(this.txtLuongCB);
            this.grpThongTin.Controls.Add(this.lblPCDocHai);
            this.grpThongTin.Controls.Add(this.txtPCDocHai);
            this.grpThongTin.Controls.Add(this.lblTrichBH);
            this.grpThongTin.Controls.Add(this.txtTrichBH);
            this.grpThongTin.Controls.Add(this.btnKyHopDong);
            this.grpThongTin.Controls.Add(this.btnDanhGia);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpThongTin.Location = new System.Drawing.Point(12, 85);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(960, 150);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Nhân Sự && Hợp Đồng Lao Động Sơn Đông Á";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMaNV.Location = new System.Drawing.Point(15, 28);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(48, 15);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(70, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(90, 23);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.Text = "NV0101";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblHoTen.Location = new System.Drawing.Point(170, 28);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(65, 15);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(240, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 23);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.Text = "Trần Quốc Toản";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPhongBan.Location = new System.Drawing.Point(410, 28);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(78, 15);
            this.lblPhongBan.TabIndex = 4;
            this.lblPhongBan.Text = "Phân xưởng:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(495, 25);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(185, 23);
            this.cboPhongBan.TabIndex = 5;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblChucVu.Location = new System.Drawing.Point(690, 28);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(55, 15);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(750, 25);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(195, 23);
            this.cboChucVu.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnThemMoi.Location = new System.Drawing.Point(750, 105);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(95, 32);
            this.btnThemMoi.TabIndex = 17;
            this.btnThemMoi.Text = "+ Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.BtnThemMoi_Click);
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLoaiHD.Location = new System.Drawing.Point(15, 68);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(54, 15);
            this.lblLoaiHD.TabIndex = 8;
            this.lblLoaiHD.Text = "Loại HĐ:";
            // 
            // cboLoaiHD
            // 
            this.cboLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiHD.FormattingEnabled = true;
            this.cboLoaiHD.Items.AddRange(new object[] {
            "Dài hạn",
            "Ngắn hạn"});
            this.cboLoaiHD.Location = new System.Drawing.Point(70, 65);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.Size = new System.Drawing.Size(90, 23);
            this.cboLoaiHD.TabIndex = 9;
            this.cboLoaiHD.SelectedIndexChanged += new System.EventHandler(this.CboLoaiHD_SelectedIndexChanged);
            // 
            // lblLuongCB
            // 
            this.lblLuongCB.AutoSize = true;
            this.lblLuongCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLuongCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLuongCB.Location = new System.Drawing.Point(170, 68);
            this.lblLuongCB.Name = "lblLuongCB";
            this.lblLuongCB.Size = new System.Drawing.Size(65, 15);
            this.lblLuongCB.TabIndex = 10;
            this.lblLuongCB.Text = "Lương CB:";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLuongCB.Location = new System.Drawing.Point(240, 65);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(120, 23);
            this.txtLuongCB.TabIndex = 11;
            this.txtLuongCB.Text = "10500000";
            this.txtLuongCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLuongCB.TextChanged += new System.EventHandler(this.TxtLuongCB_TextChanged);
            // 
            // lblPCDocHai
            // 
            this.lblPCDocHai.AutoSize = true;
            this.lblPCDocHai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPCDocHai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPCDocHai.Location = new System.Drawing.Point(380, 68);
            this.lblPCDocHai.Name = "lblPCDocHai";
            this.lblPCDocHai.Size = new System.Drawing.Size(107, 15);
            this.lblPCDocHai.TabIndex = 12;
            this.lblPCDocHai.Text = "PC Độc hại sơn:";
            // 
            // txtPCDocHai
            // 
            this.txtPCDocHai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPCDocHai.Location = new System.Drawing.Point(495, 65);
            this.txtPCDocHai.Name = "txtPCDocHai";
            this.txtPCDocHai.Size = new System.Drawing.Size(115, 23);
            this.txtPCDocHai.TabIndex = 13;
            this.txtPCDocHai.Text = "1800000";
            this.txtPCDocHai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrichBH
            // 
            this.lblTrichBH.AutoSize = true;
            this.lblTrichBH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrichBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTrichBH.Location = new System.Drawing.Point(630, 68);
            this.lblTrichBH.Name = "lblTrichBH";
            this.lblTrichBH.Size = new System.Drawing.Size(114, 15);
            this.lblTrichBH.TabIndex = 14;
            this.lblTrichBH.Text = "Trích BH (10.5%):";
            // 
            // txtTrichBH
            // 
            this.txtTrichBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtTrichBH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTrichBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.txtTrichBH.Location = new System.Drawing.Point(750, 65);
            this.txtTrichBH.Name = "txtTrichBH";
            this.txtTrichBH.ReadOnly = true;
            this.txtTrichBH.Size = new System.Drawing.Size(115, 23);
            this.txtTrichBH.TabIndex = 15;
            this.txtTrichBH.Text = "1,102,500";
            this.txtTrichBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKyHopDong
            // 
            this.btnKyHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnKyHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyHopDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnKyHopDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKyHopDong.ForeColor = System.Drawing.Color.White;
            this.btnKyHopDong.Location = new System.Drawing.Point(70, 105);
            this.btnKyHopDong.Name = "btnKyHopDong";
            this.btnKyHopDong.Size = new System.Drawing.Size(260, 32);
            this.btnKyHopDong.TabIndex = 16;
            this.btnKyHopDong.Text = "✍ Ký Hợp Đồng && Cấp Hồ Sơ BHXH";
            this.btnKyHopDong.UseVisualStyleBackColor = false;
            this.btnKyHopDong.Click += new System.EventHandler(this.BtnKyHopDong_Click);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.White;
            this.btnDanhGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhGia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDanhGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnDanhGia.Location = new System.Drawing.Point(345, 105);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(210, 32);
            this.btnDanhGia.TabIndex = 18;
            this.btnDanhGia.Text = "★ Đánh Giá Thử Việc (Đạt)";
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.BtnDanhGia_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLamMoi.Location = new System.Drawing.Point(570, 105);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 32);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "⟳ Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHopDong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHopDong.EnableHeadersVisualStyles = false;
            this.dgvHopDong.Location = new System.Drawing.Point(12, 245);
            this.dgvHopDong.MultiSelect = false;
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowTemplate.Height = 26;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(960, 310);
            this.dgvHopDong.TabIndex = 3;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHopDong_CellClick);
            // 
            // FrmTuyenDungHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTuyenDungHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Tuyển dụng, Thử việc & Hợp đồng lao động";
            this.Load += new System.EventHandler(this.FrmTuyenDungHopDong_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
