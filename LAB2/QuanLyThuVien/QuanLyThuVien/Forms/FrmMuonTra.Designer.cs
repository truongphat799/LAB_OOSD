namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.panelMuonBooks = new System.Windows.Forms.Panel();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.panelMuonBtns = new System.Windows.Forms.Panel();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.panelMuonTop = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblHenTra = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();
            this.lblNVMuon = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.panelTraBottom = new System.Windows.Forms.Panel();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.panelTraTop = new System.Windows.Forms.Panel();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();
            this.lblNVTra = new System.Windows.Forms.Label();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.lblDocGiaTra = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMuon.SuspendLayout();
            this.panelMuonBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            this.panelMuonBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            this.panelMuonTop.SuspendLayout();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.panelTraBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();
            this.panelTraTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMuon);
            this.tabs.Controls.Add(this.tabTra);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1210, 710);
            this.tabs.TabIndex = 0;
            // 
            // tabMuon
            // 
            this.tabMuon.Controls.Add(this.panelMuonBooks);
            this.tabMuon.Controls.Add(this.btnLapPhieu);
            this.tabMuon.Controls.Add(this.panelMuonTop);
            this.tabMuon.Location = new System.Drawing.Point(4, 26);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1202, 680);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(3, 632);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(1196, 45);
            this.btnLapPhieu.TabIndex = 2;
            this.btnLapPhieu.Text = "LẬP PHIẾU MƯỢN";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // panelMuonBooks
            // 
            this.panelMuonBooks.Controls.Add(this.dgvSachChon);
            this.panelMuonBooks.Controls.Add(this.panelMuonBtns);
            this.panelMuonBooks.Controls.Add(this.dgvSachCon);
            this.panelMuonBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMuonBooks.Location = new System.Drawing.Point(3, 115);
            this.panelMuonBooks.Name = "panelMuonBooks";
            this.panelMuonBooks.Size = new System.Drawing.Size(1196, 517);
            this.panelMuonBooks.TabIndex = 1;
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachChon.Location = new System.Drawing.Point(670, 0);
            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersWidth = 30;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(526, 517);
            this.dgvSachChon.TabIndex = 2;
            // 
            // panelMuonBtns
            // 
            this.panelMuonBtns.Controls.Add(this.btnBoSach);
            this.panelMuonBtns.Controls.Add(this.btnThemSach);
            this.panelMuonBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMuonBtns.Location = new System.Drawing.Point(590, 0);
            this.panelMuonBtns.Name = "panelMuonBtns";
            this.panelMuonBtns.Size = new System.Drawing.Size(80, 517);
            this.panelMuonBtns.TabIndex = 1;
            // 
            // btnBoSach
            // 
            this.btnBoSach.Location = new System.Drawing.Point(10, 260);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(60, 45);
            this.btnBoSach.TabIndex = 1;
            this.btnBoSach.Text = "<<";
            this.btnBoSach.UseVisualStyleBackColor = true;
            this.btnBoSach.Click += new System.EventHandler(this.btnBoSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(10, 200);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(60, 45);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = ">>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // dgvSachCon
            // 
            this.dgvSachCon.AllowUserToAddRows = false;
            this.dgvSachCon.AllowUserToDeleteRows = false;
            this.dgvSachCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSachCon.Location = new System.Drawing.Point(0, 0);
            this.dgvSachCon.MultiSelect = false;
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.RowHeadersWidth = 30;
            this.dgvSachCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachCon.Size = new System.Drawing.Size(590, 517);
            this.dgvSachCon.TabIndex = 0;
            // 
            // panelMuonTop
            // 
            this.panelMuonTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMuonTop.Controls.Add(this.lblTrangThai);
            this.panelMuonTop.Controls.Add(this.btnKiemTra);
            this.panelMuonTop.Controls.Add(this.dtHenTra);
            this.panelMuonTop.Controls.Add(this.lblHenTra);
            this.panelMuonTop.Controls.Add(this.dtNgayMuon);
            this.panelMuonTop.Controls.Add(this.lblNgayMuon);
            this.panelMuonTop.Controls.Add(this.cboNhanVienMuon);
            this.panelMuonTop.Controls.Add(this.lblNVMuon);
            this.panelMuonTop.Controls.Add(this.cboDocGia);
            this.panelMuonTop.Controls.Add(this.lblDocGia);
            this.panelMuonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMuonTop.Location = new System.Drawing.Point(3, 3);
            this.panelMuonTop.Name = "panelMuonTop";
            this.panelMuonTop.Size = new System.Drawing.Size(1196, 112);
            this.panelMuonTop.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTrangThai.Location = new System.Drawing.Point(520, 23);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 17);
            this.lblTrangThai.TabIndex = 9;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(340, 15);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(155, 32);
            this.btnKiemTra.TabIndex = 8;
            this.btnKiemTra.Text = "Kiểm tra điều kiện";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // dtHenTra
            // 
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHenTra.Location = new System.Drawing.Point(740, 65);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(160, 25);
            this.dtHenTra.TabIndex = 7;
            // 
            // lblHenTra
            // 
            this.lblHenTra.AutoSize = true;
            this.lblHenTra.Location = new System.Drawing.Point(650, 68);
            this.lblHenTra.Name = "lblHenTra";
            this.lblHenTra.Size = new System.Drawing.Size(89, 17);
            this.lblHenTra.TabIndex = 6;
            this.lblHenTra.Text = "Ngày hẹn trả:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(430, 65);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(160, 25);
            this.dtNgayMuon.TabIndex = 5;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(345, 68);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(80, 17);
            this.lblNgayMuon.TabIndex = 4;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // cboNhanVienMuon
            // 
            this.cboNhanVienMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(110, 65);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(200, 25);
            this.cboNhanVienMuon.TabIndex = 3;
            // 
            // lblNVMuon
            // 
            this.lblNVMuon.AutoSize = true;
            this.lblNVMuon.Location = new System.Drawing.Point(20, 68);
            this.lblNVMuon.Name = "lblNVMuon";
            this.lblNVMuon.Size = new System.Drawing.Size(68, 17);
            this.lblNVMuon.TabIndex = 2;
            this.lblNVMuon.Text = "NV lập thẻ:";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(110, 18);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(200, 25);
            this.cboDocGia.TabIndex = 1;
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(20, 21);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(56, 17);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // tabTra
            // 
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.panelTraBottom);
            this.tabTra.Controls.Add(this.panelTraTop);
            this.tabTra.Location = new System.Drawing.Point(4, 26);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1202, 680);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách";
            this.tabTra.UseVisualStyleBackColor = true;
            // 
            // dgvDangMuon
            // 
            this.dgvDangMuon.AllowUserToAddRows = false;
            this.dgvDangMuon.AllowUserToDeleteRows = false;
            this.dgvDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangMuon.Location = new System.Drawing.Point(3, 73);
            this.dgvDangMuon.MultiSelect = false;
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.RowHeadersWidth = 30;
            this.dgvDangMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangMuon.Size = new System.Drawing.Size(1196, 524);
            this.dgvDangMuon.TabIndex = 1;
            // 
            // panelTraBottom
            // 
            this.panelTraBottom.BackColor = System.Drawing.Color.MintCream;
            this.panelTraBottom.Controls.Add(this.btnTraSach);
            this.panelTraBottom.Controls.Add(this.numPhiPhat);
            this.panelTraBottom.Controls.Add(this.lblPhiPhat);
            this.panelTraBottom.Controls.Add(this.cboTinhTrang);
            this.panelTraBottom.Controls.Add(this.lblTinhTrang);
            this.panelTraBottom.Controls.Add(this.dtNgayTra);
            this.panelTraBottom.Controls.Add(this.lblNgayTra);
            this.panelTraBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTraBottom.Location = new System.Drawing.Point(3, 597);
            this.panelTraBottom.Name = "panelTraBottom";
            this.panelTraBottom.Size = new System.Drawing.Size(1196, 80);
            this.panelTraBottom.TabIndex = 2;
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(920, 18);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(180, 45);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "XÁC NHẬN TRẢ SÁCH";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // numPhiPhat
            // 
            this.numPhiPhat.Location = new System.Drawing.Point(670, 28);
            this.numPhiPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(160, 25);
            this.numPhiPhat.TabIndex = 5;
            this.numPhiPhat.ThousandsSeparator = true;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Location = new System.Drawing.Point(595, 31);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(59, 17);
            this.lblPhiPhat.TabIndex = 4;
            this.lblPhiPhat.Text = "Phí phạt:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(375, 28);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(170, 25);
            this.cboTinhTrang.TabIndex = 3;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(295, 31);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(71, 17);
            this.lblTinhTrang.TabIndex = 2;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(100, 28);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(150, 25);
            this.dtNgayTra.TabIndex = 1;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(25, 31);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(61, 17);
            this.lblNgayTra.TabIndex = 0;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // panelTraTop
            // 
            this.panelTraTop.BackColor = System.Drawing.Color.FloralWhite;
            this.panelTraTop.Controls.Add(this.cboNhanVienTra);
            this.panelTraTop.Controls.Add(this.lblNVTra);
            this.panelTraTop.Controls.Add(this.btnTaiSachMuon);
            this.panelTraTop.Controls.Add(this.cboDocGiaTra);
            this.panelTraTop.Controls.Add(this.lblDocGiaTra);
            this.panelTraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTraTop.Location = new System.Drawing.Point(3, 3);
            this.panelTraTop.Name = "panelTraTop";
            this.panelTraTop.Size = new System.Drawing.Size(1196, 70);
            this.panelTraTop.TabIndex = 0;
            // 
            // cboNhanVienTra
            // 
            this.cboNhanVienTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(630, 20);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(180, 25);
            this.cboNhanVienTra.TabIndex = 4;
            // 
            // lblNVTra
            // 
            this.lblNVTra.AutoSize = true;
            this.lblNVTra.Location = new System.Drawing.Point(535, 23);
            this.lblNVTra.Name = "lblNVTra";
            this.lblNVTra.Size = new System.Drawing.Size(81, 17);
            this.lblNVTra.TabIndex = 3;
            this.lblNVTra.Text = "NV nhận trả:";
            // 
            // btnTaiSachMuon
            // 
            this.btnTaiSachMuon.Location = new System.Drawing.Point(340, 16);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(150, 32);
            this.btnTaiSachMuon.TabIndex = 2;
            this.btnTaiSachMuon.Text = "Tải sách đang mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            this.btnTaiSachMuon.Click += new System.EventHandler(this.btnTaiSachMuon_Click);
            // 
            // cboDocGiaTra
            // 
            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(120, 20);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(200, 25);
            this.cboDocGiaTra.TabIndex = 1;
            this.cboDocGiaTra.SelectedIndexChanged += new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);
            // 
            // lblDocGiaTra
            // 
            this.lblDocGiaTra.AutoSize = true;
            this.lblDocGiaTra.Location = new System.Drawing.Point(25, 23);
            this.lblDocGiaTra.Name = "lblDocGiaTra";
            this.lblDocGiaTra.Size = new System.Drawing.Size(80, 17);
            this.lblDocGiaTra.TabIndex = 0;
            this.lblDocGiaTra.Text = "Độc giả trả:";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDong);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 710);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1210, 55);
            this.panelBottom.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1095, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 765);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.FrmMuonTra_Load);
            this.tabs.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.panelMuonBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            this.panelMuonBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            this.panelMuonTop.ResumeLayout(false);
            this.panelMuonTop.PerformLayout();
            this.tabTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.panelTraBottom.ResumeLayout(false);
            this.panelTraBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();
            this.panelTraTop.ResumeLayout(false);
            this.panelTraTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.Panel panelMuonTop;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblNVMuon;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label lblHenTra;
        private System.Windows.Forms.DateTimePicker dtHenTra;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Panel panelMuonBooks;
        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.Panel panelMuonBtns;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.Panel panelTraTop;
        private System.Windows.Forms.Label lblDocGiaTra;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.Button btnTaiSachMuon;
        private System.Windows.Forms.Label lblNVTra;
        private System.Windows.Forms.ComboBox cboNhanVienTra;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.Panel panelTraBottom;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.NumericUpDown numPhiPhat;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDong;
    }
}
