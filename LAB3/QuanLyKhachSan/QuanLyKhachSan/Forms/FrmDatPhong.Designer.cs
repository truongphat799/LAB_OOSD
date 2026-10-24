namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKhach;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage tabNhanPhong;

        // Tab Khách hàng
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridView dgvKhach;

        // Tab Đặt phòng
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblDSPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label lblPhongChon;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnLapPhieu;

        // Tab Nhận phòng / Lưu trú
        private System.Windows.Forms.Label lblDSPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Label lblPhieuChon;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Label lblNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label lblNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.Label lblNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label lblNguoiQT;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Label lblDSNguoi;
        private System.Windows.Forms.DataGridView dgvNguoi;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhach = new System.Windows.Forms.TabPage();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.tabNhanPhong = new System.Windows.Forms.TabPage();

            // Khach
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();

            // Dat Phong
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblLap = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblKenh = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblDSPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.lblPhongChon = new System.Windows.Forms.Label();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();

            // Nhan Phong
            this.lblDSPhieu = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.lblCT = new System.Windows.Forms.Label();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.lblDSNguoi = new System.Windows.Forms.Label();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabKhach.SuspendLayout();
            this.tabDatPhong.SuspendLayout();
            this.tabNhanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhach);
            this.tabControl.Controls.Add(this.tabDatPhong);
            this.tabControl.Controls.Add(this.tabNhanPhong);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 520);
            this.tabControl.TabIndex = 0;

            // 
            // tabKhach
            // 
            this.tabKhach.Controls.Add(this.lblMaKH);
            this.tabKhach.Controls.Add(this.txtMaKH);
            this.tabKhach.Controls.Add(this.lblTenKH);
            this.tabKhach.Controls.Add(this.txtTenKH);
            this.tabKhach.Controls.Add(this.lblCMND);
            this.tabKhach.Controls.Add(this.txtCMND);
            this.tabKhach.Controls.Add(this.lblQT);
            this.tabKhach.Controls.Add(this.txtQT);
            this.tabKhach.Controls.Add(this.lblSDT);
            this.tabKhach.Controls.Add(this.txtSDT);
            this.tabKhach.Controls.Add(this.btnThemKhach);
            this.tabKhach.Controls.Add(this.dgvKhach);
            this.tabKhach.Location = new System.Drawing.Point(4, 30);
            this.tabKhach.Name = "tabKhach";
            this.tabKhach.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhach.Size = new System.Drawing.Size(942, 486);
            this.tabKhach.Text = "1. Khách Hàng";
            this.tabKhach.UseVisualStyleBackColor = true;

            this.lblMaKH.Location = new System.Drawing.Point(15, 15);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(65, 25);
            this.lblMaKH.Text = "Mã KH:";
            this.txtMaKH.Location = new System.Drawing.Point(80, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 29);

            this.lblTenKH.Location = new System.Drawing.Point(195, 15);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(65, 25);
            this.lblTenKH.Text = "Họ tên:";
            this.txtTenKH.Location = new System.Drawing.Point(260, 12);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(150, 29);

            this.lblCMND.Location = new System.Drawing.Point(425, 15);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(60, 25);
            this.lblCMND.Text = "CMND:";
            this.txtCMND.Location = new System.Drawing.Point(485, 12);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(120, 29);

            this.lblQT.Location = new System.Drawing.Point(615, 15);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(75, 25);
            this.lblQT.Text = "Quốc tịch:";
            this.txtQT.Location = new System.Drawing.Point(690, 12);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(100, 29);

            this.lblSDT.Location = new System.Drawing.Point(15, 55);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(55, 25);
            this.lblSDT.Text = "SĐT:";
            this.txtSDT.Location = new System.Drawing.Point(80, 52);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(120, 29);

            this.btnThemKhach.Location = new System.Drawing.Point(220, 50);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(160, 33);
            this.btnThemKhach.Text = "Thêm Khách Hàng";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);

            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhach.Location = new System.Drawing.Point(15, 95);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.RowHeadersWidth = 30;
            this.dgvKhach.Size = new System.Drawing.Size(910, 375);

            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.lblSoPhieu);
            this.tabDatPhong.Controls.Add(this.txtSoPhieu);
            this.tabDatPhong.Controls.Add(this.lblKhach);
            this.tabDatPhong.Controls.Add(this.cboKhach);
            this.tabDatPhong.Controls.Add(this.lblNV);
            this.tabDatPhong.Controls.Add(this.cboNV);
            this.tabDatPhong.Controls.Add(this.lblLap);
            this.tabDatPhong.Controls.Add(this.dtLap);
            this.tabDatPhong.Controls.Add(this.lblNhan);
            this.tabDatPhong.Controls.Add(this.dtNhan);
            this.tabDatPhong.Controls.Add(this.lblTra);
            this.tabDatPhong.Controls.Add(this.dtTra);
            this.tabDatPhong.Controls.Add(this.lblCoc);
            this.tabDatPhong.Controls.Add(this.numCoc);
            this.tabDatPhong.Controls.Add(this.lblKenh);
            this.tabDatPhong.Controls.Add(this.cboKenh);
            this.tabDatPhong.Controls.Add(this.lblDSPhong);
            this.tabDatPhong.Controls.Add(this.dgvPhong);
            this.tabDatPhong.Controls.Add(this.lblSoNguoi);
            this.tabDatPhong.Controls.Add(this.numSoNguoi);
            this.tabDatPhong.Controls.Add(this.btnThemPhong);
            this.tabDatPhong.Controls.Add(this.lblPhongChon);
            this.tabDatPhong.Controls.Add(this.dgvChon);
            this.tabDatPhong.Controls.Add(this.btnBoPhong);
            this.tabDatPhong.Controls.Add(this.btnLapPhieu);
            this.tabDatPhong.Location = new System.Drawing.Point(4, 30);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatPhong.Size = new System.Drawing.Size(942, 486);
            this.tabDatPhong.Text = "2. Đặt Phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;

            this.lblSoPhieu.Location = new System.Drawing.Point(15, 12);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(70, 25);
            this.lblSoPhieu.Text = "Số phiếu:";
            this.txtSoPhieu.Location = new System.Drawing.Point(85, 9);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 29);

            this.lblKhach.Location = new System.Drawing.Point(195, 12);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(55, 25);
            this.lblKhach.Text = "Khách:";
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.Location = new System.Drawing.Point(250, 9);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(150, 29);

            this.lblNV.Location = new System.Drawing.Point(410, 12);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(65, 25);
            this.lblNV.Text = "Lễ tân:";
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(475, 9);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(130, 29);

            this.lblLap.Location = new System.Drawing.Point(615, 12);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(75, 25);
            this.lblLap.Text = "Ngày lập:";
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(690, 9);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(115, 29);

            this.lblNhan.Location = new System.Drawing.Point(15, 50);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(85, 25);
            this.lblNhan.Text = "Ngày nhận:";
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(100, 47);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(115, 29);

            this.lblTra.Location = new System.Drawing.Point(225, 50);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(70, 25);
            this.lblTra.Text = "Ngày trả:";
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(295, 47);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(115, 29);

            this.lblCoc.Location = new System.Drawing.Point(420, 50);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(65, 25);
            this.lblCoc.Text = "Tiền cọc:";
            this.numCoc.Location = new System.Drawing.Point(485, 47);
            this.numCoc.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(120, 29);

            this.lblKenh.Location = new System.Drawing.Point(615, 50);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(70, 25);
            this.lblKenh.Text = "Kênh đặt:";
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.Location = new System.Drawing.Point(690, 47);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(115, 29);

            this.btnLapPhieu.Location = new System.Drawing.Point(815, 44);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(115, 35);
            this.btnLapPhieu.Text = "Lập Phiếu Đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);

            this.lblDSPhong.Location = new System.Drawing.Point(15, 90);
            this.lblDSPhong.Name = "lblDSPhong";
            this.lblDSPhong.Size = new System.Drawing.Size(200, 25);
            this.lblDSPhong.Text = "Danh sách phòng:";

            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.Location = new System.Drawing.Point(15, 118);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.Size = new System.Drawing.Size(430, 310);

            this.lblSoNguoi.Location = new System.Drawing.Point(15, 442);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(70, 25);
            this.lblSoNguoi.Text = "Số người:";
            this.numSoNguoi.Location = new System.Drawing.Point(90, 440);
            this.numSoNguoi.Minimum = 1;
            this.numSoNguoi.Value = 1;
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(60, 29);

            this.btnThemPhong.Location = new System.Drawing.Point(170, 436);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(150, 35);
            this.btnThemPhong.Text = "Chọn Phòng >>";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);

            this.lblPhongChon.Location = new System.Drawing.Point(495, 90);
            this.lblPhongChon.Name = "lblPhongChon";
            this.lblPhongChon.Size = new System.Drawing.Size(200, 25);
            this.lblPhongChon.Text = "Các phòng đã chọn vào phiếu:";

            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChon.Location = new System.Drawing.Point(495, 118);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.ReadOnly = true;
            this.dgvChon.RowHeadersWidth = 30;
            this.dgvChon.Size = new System.Drawing.Size(435, 310);

            this.btnBoPhong.Location = new System.Drawing.Point(495, 436);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(140, 35);
            this.btnBoPhong.Text = "<< Bỏ Chọn";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);

            // 
            // tabNhanPhong
            // 
            this.tabNhanPhong.Controls.Add(this.lblDSPhieu);
            this.tabNhanPhong.Controls.Add(this.dgvPhieu);
            this.tabNhanPhong.Controls.Add(this.lblPhieuChon);
            this.tabNhanPhong.Controls.Add(this.txtPhieuChon);
            this.tabNhanPhong.Controls.Add(this.btnNhanPhong);
            this.tabNhanPhong.Controls.Add(this.btnNoShow);
            this.tabNhanPhong.Controls.Add(this.lblCT);
            this.tabNhanPhong.Controls.Add(this.dgvCT);
            this.tabNhanPhong.Controls.Add(this.lblNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.txtNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.lblNguoiTen);
            this.tabNhanPhong.Controls.Add(this.txtNguoiTen);
            this.tabNhanPhong.Controls.Add(this.lblNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.txtNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.lblNguoiQT);
            this.tabNhanPhong.Controls.Add(this.txtNguoiQT);
            this.tabNhanPhong.Controls.Add(this.btnThemNguoi);
            this.tabNhanPhong.Controls.Add(this.lblDSNguoi);
            this.tabNhanPhong.Controls.Add(this.dgvNguoi);
            this.tabNhanPhong.Location = new System.Drawing.Point(4, 30);
            this.tabNhanPhong.Name = "tabNhanPhong";
            this.tabNhanPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanPhong.Size = new System.Drawing.Size(942, 486);
            this.tabNhanPhong.Text = "3. Nhận Phòng & Người Lưu Trú";
            this.tabNhanPhong.UseVisualStyleBackColor = true;

            this.lblDSPhieu.Location = new System.Drawing.Point(15, 10);
            this.lblDSPhieu.Name = "lblDSPhieu";
            this.lblDSPhieu.Size = new System.Drawing.Size(200, 22);
            this.lblDSPhieu.Text = "Danh sách phiếu đặt phòng:";

            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhieu.Location = new System.Drawing.Point(15, 35);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 30;
            this.dgvPhieu.Size = new System.Drawing.Size(910, 160);
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);

            this.lblPhieuChon.Location = new System.Drawing.Point(15, 208);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(85, 25);
            this.lblPhieuChon.Text = "Phiếu chọn:";
            this.txtPhieuChon.Location = new System.Drawing.Point(100, 205);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(120, 29);

            this.btnNhanPhong.Location = new System.Drawing.Point(235, 203);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(120, 33);
            this.btnNhanPhong.Text = "Nhận Phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);

            this.btnNoShow.Location = new System.Drawing.Point(365, 203);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(100, 33);
            this.btnNoShow.Text = "No-Show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);

            this.lblCT.Location = new System.Drawing.Point(15, 245);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(200, 22);
            this.lblCT.Text = "Chi tiết phòng trong phiếu:";

            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCT.Location = new System.Drawing.Point(15, 270);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.ReadOnly = true;
            this.dgvCT.RowHeadersWidth = 30;
            this.dgvCT.Size = new System.Drawing.Size(430, 200);

            this.lblNguoiPhong.Location = new System.Drawing.Point(470, 248);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(55, 25);
            this.lblNguoiPhong.Text = "Phòng:";
            this.txtNguoiPhong.Location = new System.Drawing.Point(525, 245);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(75, 29);

            this.lblNguoiTen.Location = new System.Drawing.Point(605, 248);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(55, 25);
            this.lblNguoiTen.Text = "Họ tên:";
            this.txtNguoiTen.Location = new System.Drawing.Point(660, 245);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(120, 29);

            this.lblNguoiCMND.Location = new System.Drawing.Point(470, 285);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(55, 25);
            this.lblNguoiCMND.Text = "CMND:";
            this.txtNguoiCMND.Location = new System.Drawing.Point(525, 282);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(100, 29);

            this.lblNguoiQT.Location = new System.Drawing.Point(630, 285);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(75, 25);
            this.lblNguoiQT.Text = "Quốc tịch:";
            this.txtNguoiQT.Location = new System.Drawing.Point(705, 282);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(90, 29);

            this.btnThemNguoi.Location = new System.Drawing.Point(805, 260);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(120, 45);
            this.btnThemNguoi.Text = "Thêm Lưu Trú";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);

            this.lblDSNguoi.Location = new System.Drawing.Point(470, 318);
            this.lblDSNguoi.Name = "lblDSNguoi";
            this.lblDSNguoi.Size = new System.Drawing.Size(200, 22);
            this.lblDSNguoi.Text = "Danh sách người lưu trú:";

            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNguoi.Location = new System.Drawing.Point(470, 342);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.ReadOnly = true;
            this.dgvNguoi.RowHeadersWidth = 30;
            this.dgvNguoi.Size = new System.Drawing.Size(455, 128);

            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(840, 540);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 585);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đặt Phòng & Nhận Phòng";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhach.ResumeLayout(false);
            this.tabKhach.PerformLayout();
            this.tabDatPhong.ResumeLayout(false);
            this.tabDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            this.tabNhanPhong.ResumeLayout(false);
            this.tabNhanPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
