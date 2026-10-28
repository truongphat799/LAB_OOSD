namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmBanHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblHanMucInfo;

        private System.Windows.Forms.GroupBox grpChonMon;
        private System.Windows.Forms.Label lblNGK;
        private System.Windows.Forms.ComboBox cboNGK;
        private System.Windows.Forms.Label lblTon;
        private System.Windows.Forms.TextBox txtTon;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.DataGridView dgvGioHang;

        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.NumericUpDown numTra;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnLuuIn;
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblHanMucInfo = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.grpChonMon = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtTon = new System.Windows.Forms.TextBox();
            this.lblTon = new System.Windows.Forms.Label();
            this.cboNGK = new System.Windows.Forms.ComboBox();
            this.lblNGK = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnLuuIn = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.numTra = new System.Windows.Forms.NumericUpDown();
            this.lblTra = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpChonMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(910, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TIẾP NHẬN ĐẶT MUA & BÁN HÀNG - LẬP HÓA ĐƠN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblHanMucInfo);
            this.grpThongTin.Controls.Add(this.cboNV);
            this.grpThongTin.Controls.Add(this.lblNV);
            this.grpThongTin.Controls.Add(this.cboKhach);
            this.grpThongTin.Controls.Add(this.lblKhach);
            this.grpThongTin.Controls.Add(this.dtNgayLap);
            this.grpThongTin.Controls.Add(this.lblNgayLap);
            this.grpThongTin.Controls.Add(this.txtSoHD);
            this.grpThongTin.Controls.Add(this.lblSoHD);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThongTin.Location = new System.Drawing.Point(12, 45);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(910, 95);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Hóa Đơn & Khách Hàng";
            // 
            // lblHanMucInfo
            // 
            this.lblHanMucInfo.AutoSize = true;
            this.lblHanMucInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHanMucInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHanMucInfo.Location = new System.Drawing.Point(15, 65);
            this.lblHanMucInfo.Name = "lblHanMucInfo";
            this.lblHanMucInfo.Size = new System.Drawing.Size(269, 20);
            this.lblHanMucInfo.TabIndex = 8;
            this.lblHanMucInfo.Text = "Hạn mức nợ còn lại: Đang kiểm tra...";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(735, 23);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(160, 29);
            this.cboNV.TabIndex = 7;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(670, 26);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(65, 21);
            this.lblNV.TabIndex = 6;
            this.lblNV.Text = "NV Lập:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(445, 23);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(215, 29);
            this.cboKhach.TabIndex = 5;
            this.cboKhach.SelectedIndexChanged += new System.EventHandler(this.cboKhach_SelectedIndexChanged);
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(385, 26);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(55, 21);
            this.lblKhach.TabIndex = 4;
            this.lblKhach.Text = "Khách:";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(265, 23);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(110, 29);
            this.dtNgayLap.TabIndex = 3;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(215, 26);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(50, 21);
            this.lblNgayLap.TabIndex = 2;
            this.lblNgayLap.Text = "Ngày:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(75, 23);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(130, 29);
            this.txtSoHD.TabIndex = 1;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(15, 26);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(58, 21);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số HĐ:";
            // 
            // grpChonMon
            // 
            this.grpChonMon.Controls.Add(this.btnXoa);
            this.grpChonMon.Controls.Add(this.btnThem);
            this.grpChonMon.Controls.Add(this.numGia);
            this.grpChonMon.Controls.Add(this.lblGia);
            this.grpChonMon.Controls.Add(this.numSL);
            this.grpChonMon.Controls.Add(this.lblSL);
            this.grpChonMon.Controls.Add(this.txtTon);
            this.grpChonMon.Controls.Add(this.lblTon);
            this.grpChonMon.Controls.Add(this.cboNGK);
            this.grpChonMon.Controls.Add(this.lblNGK);
            this.grpChonMon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpChonMon.Location = new System.Drawing.Point(12, 145);
            this.grpChonMon.Name = "grpChonMon";
            this.grpChonMon.Size = new System.Drawing.Size(910, 70);
            this.grpChonMon.TabIndex = 2;
            this.grpChonMon.TabStop = false;
            this.grpChonMon.Text = "Chọn Nước Giải Khát & Kiểm Tra Tồn Kho";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(825, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 32);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(715, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "+ Thêm HĐ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numGia
            // 
            this.numGia.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numGia.Location = new System.Drawing.Point(585, 27);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(120, 29);
            this.numGia.TabIndex = 7;
            this.numGia.Value = new decimal(new int[] { 195000, 0, 0, 0 });
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(525, 30);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(66, 21);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Đơn giá:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(445, 27);
            this.numSL.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(70, 29);
            this.numSL.TabIndex = 5;
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(385, 30);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(66, 21);
            this.lblSL.TabIndex = 4;
            this.lblSL.Text = "SL Mua:";
            // 
            // txtTon
            // 
            this.txtTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTon.Location = new System.Drawing.Point(315, 27);
            this.txtTon.Name = "txtTon";
            this.txtTon.ReadOnly = true;
            this.txtTon.Size = new System.Drawing.Size(60, 29);
            this.txtTon.TabIndex = 3;
            // 
            // lblTon
            // 
            this.lblTon.AutoSize = true;
            this.lblTon.Location = new System.Drawing.Point(275, 30);
            this.lblTon.Name = "lblTon";
            this.lblTon.Size = new System.Drawing.Size(38, 21);
            this.lblTon.TabIndex = 2;
            this.lblTon.Text = "Tồn:";
            // 
            // cboNGK
            // 
            this.cboNGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNGK.FormattingEnabled = true;
            this.cboNGK.Location = new System.Drawing.Point(60, 27);
            this.cboNGK.Name = "cboNGK";
            this.cboNGK.Size = new System.Drawing.Size(205, 29);
            this.cboNGK.TabIndex = 1;
            this.cboNGK.SelectedIndexChanged += new System.EventHandler(this.cboNGK_SelectedIndexChanged);
            // 
            // lblNGK
            // 
            this.lblNGK.AutoSize = true;
            this.lblNGK.Location = new System.Drawing.Point(15, 30);
            this.lblNGK.Name = "lblNGK";
            this.lblNGK.Size = new System.Drawing.Size(46, 21);
            this.lblNGK.TabIndex = 0;
            this.lblNGK.Text = "NGK:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 220);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(910, 180);
            this.dgvGioHang.TabIndex = 3;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.btnLuuIn);
            this.grpThanhToan.Controls.Add(this.txtNo);
            this.grpThanhToan.Controls.Add(this.lblNo);
            this.grpThanhToan.Controls.Add(this.numTra);
            this.grpThanhToan.Controls.Add(this.lblTra);
            this.grpThanhToan.Controls.Add(this.cboHT);
            this.grpThanhToan.Controls.Add(this.lblHT);
            this.grpThanhToan.Controls.Add(this.txtTong);
            this.grpThanhToan.Controls.Add(this.lblTong);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThanhToan.Location = new System.Drawing.Point(12, 405);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(910, 75);
            this.grpThanhToan.TabIndex = 4;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh Toán & Xử Lý Tự Động (Tự sinh Phiếu Hẹn / Phiếu Nợ nếu có)";
            // 
            // btnLuuIn
            // 
            this.btnLuuIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnLuuIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuIn.ForeColor = System.Drawing.Color.White;
            this.btnLuuIn.Location = new System.Drawing.Point(745, 23);
            this.btnLuuIn.Name = "btnLuuIn";
            this.btnLuuIn.Size = new System.Drawing.Size(150, 42);
            this.btnLuuIn.TabIndex = 8;
            this.btnLuuIn.Text = "🖨 Lưu & Lập HĐ";
            this.btnLuuIn.UseVisualStyleBackColor = false;
            this.btnLuuIn.Click += new System.EventHandler(this.btnLuuIn_Click);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtNo.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNo.Location = new System.Drawing.Point(620, 30);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(110, 29);
            this.txtNo.TabIndex = 7;
            this.txtNo.Text = "0 đ";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(555, 33);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(64, 21);
            this.lblNo.TabIndex = 6;
            this.lblNo.Text = "Tiền nợ:";
            // 
            // numTra
            // 
            this.numTra.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numTra.Location = new System.Drawing.Point(435, 30);
            this.numTra.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numTra.Name = "numTra";
            this.numTra.Size = new System.Drawing.Size(115, 29);
            this.numTra.TabIndex = 5;
            this.numTra.ValueChanged += new System.EventHandler(this.numTra_ValueChanged);
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(365, 33);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(68, 21);
            this.lblTra.TabIndex = 4;
            this.lblTra.Text = "Trả ngay:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Trả chậm / Ghi nợ"});
            this.cboHT.Location = new System.Drawing.Point(235, 30);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(125, 29);
            this.cboHT.TabIndex = 3;
            this.cboHT.SelectedIndexChanged += new System.EventHandler(this.cboHT_SelectedIndexChanged);
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(195, 33);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(33, 21);
            this.lblHT.TabIndex = 2;
            this.lblHT.Text = "HT:";
            // 
            // txtTong
            // 
            this.txtTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtTong.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTong.Location = new System.Drawing.Point(75, 30);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(115, 29);
            this.txtTong.TabIndex = 1;
            this.txtTong.Text = "0 đ";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(15, 33);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(48, 21);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "Tổng:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(822, 490);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.grpChonMon);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp Nhận Đặt Mua & Bán Hàng - Lập Hóa Đơn";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChonMon.ResumeLayout(false);
            this.grpChonMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTra)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
