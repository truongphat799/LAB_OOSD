namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmNhapHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDat;
        private System.Windows.Forms.TabPage tabGiao;
        private System.Windows.Forms.Button btnDong;

        // Tab Dat Hang Controls
        private System.Windows.Forms.Label lblDDHMa;
        private System.Windows.Forms.TextBox txtDDHMa;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.Label lblNGK;
        private System.Windows.Forms.ComboBox cboNGK;
        private System.Windows.Forms.Label lblSLDat;
        private System.Windows.Forms.NumericUpDown numSLDat;
        private System.Windows.Forms.Label lblGiaDat;
        private System.Windows.Forms.NumericUpDown numGiaDat;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.DataGridView dgvMonDat;
        private System.Windows.Forms.DataGridView dgvDDH;
        private System.Windows.Forms.Label lblDSDon;
        private System.Windows.Forms.Label lblDSMon;

        // Tab Giao Hang Controls
        private System.Windows.Forms.Label lblPGHMa;
        private System.Windows.Forms.TextBox txtPGHMa;
        private System.Windows.Forms.Label lblDDHGiao;
        private System.Windows.Forms.ComboBox cboDDHGiao;
        private System.Windows.Forms.Label lblSoPGNCC;
        private System.Windows.Forms.TextBox txtSoPGNCC;
        private System.Windows.Forms.Label lblDot;
        private System.Windows.Forms.NumericUpDown numDot;
        private System.Windows.Forms.Label lblNVNhan;
        private System.Windows.Forms.ComboBox cboNVNhan;
        private System.Windows.Forms.Label lblNgayGiao;
        private System.Windows.Forms.DateTimePicker dtNgayGiao;
        private System.Windows.Forms.Label lblNGKGiao;
        private System.Windows.Forms.ComboBox cboNGKGiao;
        private System.Windows.Forms.Label lblSLGiao;
        private System.Windows.Forms.NumericUpDown numSLGiao;
        private System.Windows.Forms.Label lblGiaGiao;
        private System.Windows.Forms.NumericUpDown numGiaGiao;
        private System.Windows.Forms.Button btnThemMonGiao;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.DataGridView dgvMonGiao;
        private System.Windows.Forms.DataGridView dgvPGH;
        private System.Windows.Forms.Label lblDSPGH;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDat = new System.Windows.Forms.TabPage();
            this.lblDSMon = new System.Windows.Forms.Label();
            this.lblDSDon = new System.Windows.Forms.Label();
            this.dgvDDH = new System.Windows.Forms.DataGridView();
            this.dgvMonDat = new System.Windows.Forms.DataGridView();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.numGiaDat = new System.Windows.Forms.NumericUpDown();
            this.lblGiaDat = new System.Windows.Forms.Label();
            this.numSLDat = new System.Windows.Forms.NumericUpDown();
            this.lblSLDat = new System.Windows.Forms.Label();
            this.cboNGK = new System.Windows.Forms.ComboBox();
            this.lblNGK = new System.Windows.Forms.Label();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.txtDDHMa = new System.Windows.Forms.TextBox();
            this.lblDDHMa = new System.Windows.Forms.Label();
            this.tabGiao = new System.Windows.Forms.TabPage();
            this.lblDSPGH = new System.Windows.Forms.Label();
            this.dgvPGH = new System.Windows.Forms.DataGridView();
            this.dgvMonGiao = new System.Windows.Forms.DataGridView();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.btnThemMonGiao = new System.Windows.Forms.Button();
            this.numGiaGiao = new System.Windows.Forms.NumericUpDown();
            this.lblGiaGiao = new System.Windows.Forms.Label();
            this.numSLGiao = new System.Windows.Forms.NumericUpDown();
            this.lblSLGiao = new System.Windows.Forms.Label();
            this.cboNGKGiao = new System.Windows.Forms.ComboBox();
            this.lblNGKGiao = new System.Windows.Forms.Label();
            this.dtNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.lblNgayGiao = new System.Windows.Forms.Label();
            this.cboNVNhan = new System.Windows.Forms.ComboBox();
            this.lblNVNhan = new System.Windows.Forms.Label();
            this.numDot = new System.Windows.Forms.NumericUpDown();
            this.lblDot = new System.Windows.Forms.Label();
            this.txtSoPGNCC = new System.Windows.Forms.TextBox();
            this.lblSoPGNCC = new System.Windows.Forms.Label();
            this.cboDDHGiao = new System.Windows.Forms.ComboBox();
            this.lblDDHGiao = new System.Windows.Forms.Label();
            this.txtPGHMa = new System.Windows.Forms.TextBox();
            this.lblPGHMa = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLDat)).BeginInit();
            this.tabGiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDot)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDat);
            this.tabControl1.Controls.Add(this.tabGiao);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDat
            // 
            this.tabDat.Controls.Add(this.lblDSMon);
            this.tabDat.Controls.Add(this.lblDSDon);
            this.tabDat.Controls.Add(this.dgvDDH);
            this.tabDat.Controls.Add(this.dgvMonDat);
            this.tabDat.Controls.Add(this.btnTaoDon);
            this.tabDat.Controls.Add(this.btnThemMon);
            this.tabDat.Controls.Add(this.numGiaDat);
            this.tabDat.Controls.Add(this.lblGiaDat);
            this.tabDat.Controls.Add(this.numSLDat);
            this.tabDat.Controls.Add(this.lblSLDat);
            this.tabDat.Controls.Add(this.cboNGK);
            this.tabDat.Controls.Add(this.lblNGK);
            this.tabDat.Controls.Add(this.dtNgayNhan);
            this.tabDat.Controls.Add(this.lblNgayNhan);
            this.tabDat.Controls.Add(this.dtNgayDat);
            this.tabDat.Controls.Add(this.lblNgayDat);
            this.tabDat.Controls.Add(this.cboNV);
            this.tabDat.Controls.Add(this.lblNV);
            this.tabDat.Controls.Add(this.cboNCC);
            this.tabDat.Controls.Add(this.lblNCC);
            this.tabDat.Controls.Add(this.txtDDHMa);
            this.tabDat.Controls.Add(this.lblDDHMa);
            this.tabDat.Location = new System.Drawing.Point(4, 30);
            this.tabDat.Name = "tabDat";
            this.tabDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDat.Size = new System.Drawing.Size(882, 466);
            this.tabDat.TabIndex = 0;
            this.tabDat.Text = "Đơn Đặt Hàng Nhà Cung Ứng";
            this.tabDat.UseVisualStyleBackColor = true;
            // 
            // lblDSMon
            // 
            this.lblDSMon.AutoSize = true;
            this.lblDSMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSMon.Location = new System.Drawing.Point(15, 88);
            this.lblDSMon.Name = "lblDSMon";
            this.lblDSMon.Size = new System.Drawing.Size(271, 20);
            this.lblDSMon.TabIndex = 21;
            this.lblDSMon.Text = "Danh sách mặt hàng đặt trong đơn này:";
            // 
            // lblDSDon
            // 
            this.lblDSDon.AutoSize = true;
            this.lblDSDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSDon.Location = new System.Drawing.Point(15, 275);
            this.lblDSDon.Name = "lblDSDon";
            this.lblDSDon.Size = new System.Drawing.Size(262, 20);
            this.lblDSDon.TabIndex = 20;
            this.lblDSDon.Text = "Lịch sử các đơn đặt hàng đã gửi NCC:";
            // 
            // dgvDDH
            // 
            this.dgvDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDDH.Location = new System.Drawing.Point(15, 298);
            this.dgvDDH.Name = "dgvDDH";
            this.dgvDDH.RowHeadersWidth = 51;
            this.dgvDDH.RowTemplate.Height = 24;
            this.dgvDDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDDH.Size = new System.Drawing.Size(850, 155);
            this.dgvDDH.TabIndex = 19;
            this.dgvDDH.SelectionChanged += new System.EventHandler(this.dgvDDH_SelectionChanged);
            // 
            // dgvMonDat
            // 
            this.dgvMonDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonDat.Location = new System.Drawing.Point(15, 145);
            this.dgvMonDat.Name = "dgvMonDat";
            this.dgvMonDat.RowHeadersWidth = 51;
            this.dgvMonDat.RowTemplate.Height = 24;
            this.dgvMonDat.Size = new System.Drawing.Size(850, 120);
            this.dgvMonDat.TabIndex = 18;
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnTaoDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Location = new System.Drawing.Point(715, 108);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(150, 32);
            this.btnTaoDon.TabIndex = 17;
            this.btnTaoDon.Text = "✓ Lưu Đơn Đặt";
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(595, 108);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(110, 32);
            this.btnThemMon.TabIndex = 16;
            this.btnThemMon.Text = "+ Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // numGiaDat
            // 
            this.numGiaDat.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numGiaDat.Location = new System.Drawing.Point(465, 110);
            this.numGiaDat.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGiaDat.Name = "numGiaDat";
            this.numGiaDat.Size = new System.Drawing.Size(120, 29);
            this.numGiaDat.TabIndex = 15;
            this.numGiaDat.Value = new decimal(new int[] { 150000, 0, 0, 0 });
            // 
            // lblGiaDat
            // 
            this.lblGiaDat.AutoSize = true;
            this.lblGiaDat.Location = new System.Drawing.Point(395, 113);
            this.lblGiaDat.Name = "lblGiaDat";
            this.lblGiaDat.Size = new System.Drawing.Size(76, 21);
            this.lblGiaDat.TabIndex = 14;
            this.lblGiaDat.Text = "Giá nhập:";
            // 
            // numSLDat
            // 
            this.numSLDat.Location = new System.Drawing.Point(315, 110);
            this.numSLDat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSLDat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSLDat.Name = "numSLDat";
            this.numSLDat.Size = new System.Drawing.Size(70, 29);
            this.numSLDat.TabIndex = 13;
            this.numSLDat.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblSLDat
            // 
            this.lblSLDat.AutoSize = true;
            this.lblSLDat.Location = new System.Drawing.Point(255, 113);
            this.lblSLDat.Name = "lblSLDat";
            this.lblSLDat.Size = new System.Drawing.Size(61, 21);
            this.lblSLDat.TabIndex = 12;
            this.lblSLDat.Text = "SL Đặt:";
            // 
            // cboNGK
            // 
            this.cboNGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNGK.FormattingEnabled = true;
            this.cboNGK.Location = new System.Drawing.Point(60, 110);
            this.cboNGK.Name = "cboNGK";
            this.cboNGK.Size = new System.Drawing.Size(185, 29);
            this.cboNGK.TabIndex = 11;
            // 
            // lblNGK
            // 
            this.lblNGK.AutoSize = true;
            this.lblNGK.Location = new System.Drawing.Point(15, 113);
            this.lblNGK.Name = "lblNGK";
            this.lblNGK.Size = new System.Drawing.Size(46, 21);
            this.lblNGK.TabIndex = 10;
            this.lblNGK.Text = "NGK:";
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhan.Location = new System.Drawing.Point(645, 50);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(220, 29);
            this.dtNgayNhan.TabIndex = 9;
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Location = new System.Drawing.Point(540, 53);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(111, 21);
            this.lblNgayNhan.TabIndex = 8;
            this.lblNgayNhan.Text = "Ngày nhận DK:";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(380, 50);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(150, 29);
            this.dtNgayDat.TabIndex = 7;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(305, 53);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(76, 21);
            this.lblNgayDat.TabIndex = 6;
            this.lblNgayDat.Text = "Ngày đặt:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(90, 50);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(200, 29);
            this.cboNV.TabIndex = 5;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(15, 53);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(82, 21);
            this.lblNV.TabIndex = 4;
            this.lblNV.Text = "Người lập:";
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(340, 12);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(525, 29);
            this.cboNCC.TabIndex = 3;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(235, 15);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(109, 21);
            this.lblNCC.TabIndex = 2;
            this.lblNCC.Text = "Nhà cung ứng:";
            // 
            // txtDDHMa
            // 
            this.txtDDHMa.Location = new System.Drawing.Point(90, 12);
            this.txtDDHMa.Name = "txtDDHMa";
            this.txtDDHMa.Size = new System.Drawing.Size(130, 29);
            this.txtDDHMa.TabIndex = 1;
            // 
            // lblDDHMa
            // 
            this.lblDDHMa.AutoSize = true;
            this.lblDDHMa.Location = new System.Drawing.Point(15, 15);
            this.lblDDHMa.Name = "lblDDHMa";
            this.lblDDHMa.Size = new System.Drawing.Size(68, 21);
            this.lblDDHMa.TabIndex = 0;
            this.lblDDHMa.Text = "Số ĐĐH:";
            // 
            // tabGiao
            // 
            this.tabGiao.Controls.Add(this.lblDSPGH);
            this.tabGiao.Controls.Add(this.dgvPGH);
            this.tabGiao.Controls.Add(this.dgvMonGiao);
            this.tabGiao.Controls.Add(this.btnNhanHang);
            this.tabGiao.Controls.Add(this.btnThemMonGiao);
            this.tabGiao.Controls.Add(this.numGiaGiao);
            this.tabGiao.Controls.Add(this.lblGiaGiao);
            this.tabGiao.Controls.Add(this.numSLGiao);
            this.tabGiao.Controls.Add(this.lblSLGiao);
            this.tabGiao.Controls.Add(this.cboNGKGiao);
            this.tabGiao.Controls.Add(this.lblNGKGiao);
            this.tabGiao.Controls.Add(this.dtNgayGiao);
            this.tabGiao.Controls.Add(this.lblNgayGiao);
            this.tabGiao.Controls.Add(this.cboNVNhan);
            this.tabGiao.Controls.Add(this.lblNVNhan);
            this.tabGiao.Controls.Add(this.numDot);
            this.tabGiao.Controls.Add(this.lblDot);
            this.tabGiao.Controls.Add(this.txtSoPGNCC);
            this.tabGiao.Controls.Add(this.lblSoPGNCC);
            this.tabGiao.Controls.Add(this.cboDDHGiao);
            this.tabGiao.Controls.Add(this.lblDDHGiao);
            this.tabGiao.Controls.Add(this.txtPGHMa);
            this.tabGiao.Controls.Add(this.lblPGHMa);
            this.tabGiao.Location = new System.Drawing.Point(4, 30);
            this.tabGiao.Name = "tabGiao";
            this.tabGiao.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiao.Size = new System.Drawing.Size(882, 466);
            this.tabGiao.TabIndex = 1;
            this.tabGiao.Text = "Phiếu Giao Hàng NCC (Tối Đa 3 Đợt)";
            this.tabGiao.UseVisualStyleBackColor = true;
            // 
            // lblDSPGH
            // 
            this.lblDSPGH.AutoSize = true;
            this.lblDSPGH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSPGH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSPGH.Location = new System.Drawing.Point(15, 275);
            this.lblDSPGH.Name = "lblDSPGH";
            this.lblDSPGH.Size = new System.Drawing.Size(277, 20);
            this.lblDSPGH.TabIndex = 22;
            this.lblDSPGH.Text = "Danh sách các phiếu giao hàng đã nhận:";
            // 
            // dgvPGH
            // 
            this.dgvPGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPGH.Location = new System.Drawing.Point(15, 298);
            this.dgvPGH.Name = "dgvPGH";
            this.dgvPGH.RowHeadersWidth = 51;
            this.dgvPGH.RowTemplate.Height = 24;
            this.dgvPGH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPGH.Size = new System.Drawing.Size(850, 155);
            this.dgvPGH.TabIndex = 21;
            // 
            // dgvMonGiao
            // 
            this.dgvMonGiao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonGiao.Location = new System.Drawing.Point(15, 145);
            this.dgvMonGiao.Name = "dgvMonGiao";
            this.dgvMonGiao.RowHeadersWidth = 51;
            this.dgvMonGiao.RowTemplate.Height = 24;
            this.dgvMonGiao.Size = new System.Drawing.Size(850, 120);
            this.dgvMonGiao.TabIndex = 20;
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnNhanHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNhanHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanHang.Location = new System.Drawing.Point(695, 108);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(170, 32);
            this.btnNhanHang.TabIndex = 19;
            this.btnNhanHang.Text = "✓ Nhập Kho Đợt Này";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // btnThemMonGiao
            // 
            this.btnThemMonGiao.Location = new System.Drawing.Point(575, 108);
            this.btnThemMonGiao.Name = "btnThemMonGiao";
            this.btnThemMonGiao.Size = new System.Drawing.Size(110, 32);
            this.btnThemMonGiao.TabIndex = 18;
            this.btnThemMonGiao.Text = "+ Thêm Món";
            this.btnThemMonGiao.UseVisualStyleBackColor = true;
            this.btnThemMonGiao.Click += new System.EventHandler(this.btnThemMonGiao_Click);
            // 
            // numGiaGiao
            // 
            this.numGiaGiao.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numGiaGiao.Location = new System.Drawing.Point(450, 110);
            this.numGiaGiao.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGiaGiao.Name = "numGiaGiao";
            this.numGiaGiao.Size = new System.Drawing.Size(115, 29);
            this.numGiaGiao.TabIndex = 17;
            this.numGiaGiao.Value = new decimal(new int[] { 150000, 0, 0, 0 });
            // 
            // lblGiaGiao
            // 
            this.lblGiaGiao.AutoSize = true;
            this.lblGiaGiao.Location = new System.Drawing.Point(380, 113);
            this.lblGiaGiao.Name = "lblGiaGiao";
            this.lblGiaGiao.Size = new System.Drawing.Size(73, 21);
            this.lblGiaGiao.TabIndex = 16;
            this.lblGiaGiao.Text = "Giá giao:";
            // 
            // numSLGiao
            // 
            this.numSLGiao.Location = new System.Drawing.Point(305, 110);
            this.numSLGiao.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSLGiao.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSLGiao.Name = "numSLGiao";
            this.numSLGiao.Size = new System.Drawing.Size(65, 29);
            this.numSLGiao.TabIndex = 15;
            this.numSLGiao.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblSLGiao
            // 
            this.lblSLGiao.AutoSize = true;
            this.lblSLGiao.Location = new System.Drawing.Point(245, 113);
            this.lblSLGiao.Name = "lblSLGiao";
            this.lblSLGiao.Size = new System.Drawing.Size(66, 21);
            this.lblSLGiao.TabIndex = 14;
            this.lblSLGiao.Text = "SL Giao:";
            // 
            // cboNGKGiao
            // 
            this.cboNGKGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNGKGiao.FormattingEnabled = true;
            this.cboNGKGiao.Location = new System.Drawing.Point(60, 110);
            this.cboNGKGiao.Name = "cboNGKGiao";
            this.cboNGKGiao.Size = new System.Drawing.Size(175, 29);
            this.cboNGKGiao.TabIndex = 13;
            // 
            // lblNGKGiao
            // 
            this.lblNGKGiao.AutoSize = true;
            this.lblNGKGiao.Location = new System.Drawing.Point(15, 113);
            this.lblNGKGiao.Name = "lblNGKGiao";
            this.lblNGKGiao.Size = new System.Drawing.Size(46, 21);
            this.lblNGKGiao.TabIndex = 12;
            this.lblNGKGiao.Text = "NGK:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGiao.Location = new System.Drawing.Point(665, 50);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Size = new System.Drawing.Size(200, 29);
            this.dtNgayGiao.TabIndex = 11;
            // 
            // lblNgayGiao
            // 
            this.lblNgayGiao.AutoSize = true;
            this.lblNgayGiao.Location = new System.Drawing.Point(585, 53);
            this.lblNgayGiao.Name = "lblNgayGiao";
            this.lblNgayGiao.Size = new System.Drawing.Size(84, 21);
            this.lblNgayGiao.TabIndex = 10;
            this.lblNgayGiao.Text = "Ngày giao:";
            // 
            // cboNVNhan
            // 
            this.cboNVNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVNhan.FormattingEnabled = true;
            this.cboNVNhan.Location = new System.Drawing.Point(365, 50);
            this.cboNVNhan.Name = "cboNVNhan";
            this.cboNVNhan.Size = new System.Drawing.Size(210, 29);
            this.cboNVNhan.TabIndex = 9;
            // 
            // lblNVNhan
            // 
            this.lblNVNhan.AutoSize = true;
            this.lblNVNhan.Location = new System.Drawing.Point(275, 53);
            this.lblNVNhan.Name = "lblNVNhan";
            this.lblNVNhan.Size = new System.Drawing.Size(95, 21);
            this.lblNVNhan.TabIndex = 8;
            this.lblNVNhan.Text = "Người nhận:";
            // 
            // numDot
            // 
            this.numDot.Location = new System.Drawing.Point(195, 50);
            this.numDot.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numDot.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDot.Name = "numDot";
            this.numDot.Size = new System.Drawing.Size(65, 29);
            this.numDot.TabIndex = 7;
            this.numDot.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDot
            // 
            this.lblDot.AutoSize = true;
            this.lblDot.Location = new System.Drawing.Point(15, 53);
            this.lblDot.Name = "lblDot";
            this.lblDot.Size = new System.Drawing.Size(183, 21);
            this.lblDot.TabIndex = 6;
            this.lblDot.Text = "Đợt giao (tối đa 3 đợt):";
            // 
            // txtSoPGNCC
            // 
            this.txtSoPGNCC.Location = new System.Drawing.Point(620, 12);
            this.txtSoPGNCC.Name = "txtSoPGNCC";
            this.txtSoPGNCC.Size = new System.Drawing.Size(245, 29);
            this.txtSoPGNCC.TabIndex = 5;
            // 
            // lblSoPGNCC
            // 
            this.lblSoPGNCC.AutoSize = true;
            this.lblSoPGNCC.Location = new System.Drawing.Point(495, 15);
            this.lblSoPGNCC.Name = "lblSoPGNCC";
            this.lblSoPGNCC.Size = new System.Drawing.Size(130, 21);
            this.lblSoPGNCC.TabIndex = 4;
            this.lblSoPGNCC.Text = "Số Phiếu NCC:";
            // 
            // cboDDHGiao
            // 
            this.cboDDHGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDDHGiao.FormattingEnabled = true;
            this.cboDDHGiao.Location = new System.Drawing.Point(325, 12);
            this.cboDDHGiao.Name = "cboDDHGiao";
            this.cboDDHGiao.Size = new System.Drawing.Size(160, 29);
            this.cboDDHGiao.TabIndex = 3;
            // 
            // lblDDHGiao
            // 
            this.lblDDHGiao.AutoSize = true;
            this.lblDDHGiao.Location = new System.Drawing.Point(235, 15);
            this.lblDDHGiao.Name = "lblDDHGiao";
            this.lblDDHGiao.Size = new System.Drawing.Size(95, 21);
            this.lblDDHGiao.TabIndex = 2;
            this.lblDDHGiao.Text = "Thuộc ĐĐH:";
            // 
            // txtPGHMa
            // 
            this.txtPGHMa.Location = new System.Drawing.Point(90, 12);
            this.txtPGHMa.Name = "txtPGHMa";
            this.txtPGHMa.Size = new System.Drawing.Size(130, 29);
            this.txtPGHMa.TabIndex = 1;
            // 
            // lblPGHMa
            // 
            this.lblPGHMa.AutoSize = true;
            this.lblPGHMa.Location = new System.Drawing.Point(15, 15);
            this.lblPGHMa.Name = "lblPGHMa";
            this.lblPGHMa.Size = new System.Drawing.Size(66, 21);
            this.lblPGHMa.TabIndex = 0;
            this.lblPGHMa.Text = "Số PGH:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(795, 520);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đơn Đặt Hàng & Phiếu Nhập Hàng Tối Đa 3 Đợt";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDat.ResumeLayout(false);
            this.tabDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLDat)).EndInit();
            this.tabGiao.ResumeLayout(false);
            this.tabGiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDot)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
