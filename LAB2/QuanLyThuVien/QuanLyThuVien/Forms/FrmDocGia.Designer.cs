namespace QuanLyThuVien.Forms
{
    partial class FrmDocGia
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.chkLePhi = new System.Windows.Forms.CheckBox();
            this.dtHan = new System.Windows.Forms.DateTimePicker();
            this.lblHan = new System.Windows.Forms.Label();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.lblPhai = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.Controls.Add(this.btnLamMoi);
            this.panelTop.Controls.Add(this.btnGiaHan);
            this.panelTop.Controls.Add(this.btnCapThe);
            this.panelTop.Controls.Add(this.btnCapNhat);
            this.panelTop.Controls.Add(this.btnThem);
            this.panelTop.Controls.Add(this.chkLePhi);
            this.panelTop.Controls.Add(this.dtHan);
            this.panelTop.Controls.Add(this.lblHan);
            this.panelTop.Controls.Add(this.dtNgayCap);
            this.panelTop.Controls.Add(this.lblNgayCap);
            this.panelTop.Controls.Add(this.txtAnh);
            this.panelTop.Controls.Add(this.lblAnh);
            this.panelTop.Controls.Add(this.txtEmail);
            this.panelTop.Controls.Add(this.lblEmail);
            this.panelTop.Controls.Add(this.txtDiaChi);
            this.panelTop.Controls.Add(this.lblDiaChi);
            this.panelTop.Controls.Add(this.txtSDT);
            this.panelTop.Controls.Add(this.lblSDT);
            this.panelTop.Controls.Add(this.cboPhai);
            this.panelTop.Controls.Add(this.lblPhai);
            this.panelTop.Controls.Add(this.dtNgaySinh);
            this.panelTop.Controls.Add(this.lblNgaySinh);
            this.panelTop.Controls.Add(this.txtTen);
            this.panelTop.Controls.Add(this.lblTen);
            this.panelTop.Controls.Add(this.txtHo);
            this.panelTop.Controls.Add(this.lblHo);
            this.panelTop.Controls.Add(this.txtMa);
            this.panelTop.Controls.Add(this.lblMa);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1190, 210);
            this.panelTop.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(495, 160);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 35);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(375, 160);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(105, 35);
            this.btnGiaHan.TabIndex = 26;
            this.btnGiaHan.Text = "Gia hạn thẻ";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnCapThe
            // 
            this.btnCapThe.Location = new System.Drawing.Point(255, 160);
            this.btnCapThe.Name = "btnCapThe";
            this.btnCapThe.Size = new System.Drawing.Size(105, 35);
            this.btnCapThe.TabIndex = 25;
            this.btnCapThe.Text = "Cấp thẻ mới";
            this.btnCapThe.UseVisualStyleBackColor = true;
            this.btnCapThe.Click += new System.EventHandler(this.btnCapThe_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(135, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 35);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm độc giả";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkLePhi
            // 
            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Checked = true;
            this.chkLePhi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLePhi.Location = new System.Drawing.Point(740, 113);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(143, 21);
            this.chkLePhi.TabIndex = 22;
            this.chkLePhi.Text = "Đã đóng lệ phí năm";
            this.chkLePhi.UseVisualStyleBackColor = true;
            // 
            // dtHan
            // 
            this.dtHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHan.Location = new System.Drawing.Point(450, 110);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(180, 25);
            this.dtHan.TabIndex = 21;
            // 
            // lblHan
            // 
            this.lblHan.AutoSize = true;
            this.lblHan.Location = new System.Drawing.Point(365, 113);
            this.lblHan.Name = "lblHan";
            this.lblHan.Size = new System.Drawing.Size(86, 17);
            this.lblHan.TabIndex = 20;
            this.lblHan.Text = "Hạn sử dụng:";
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayCap.Location = new System.Drawing.Point(110, 110);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(160, 25);
            this.dtNgayCap.TabIndex = 19;
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(20, 113);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(66, 17);
            this.lblNgayCap.TabIndex = 18;
            this.lblNgayCap.Text = "Ngày cấp:";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(740, 65);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(250, 25);
            this.txtAnh.TabIndex = 17;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(660, 68);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(57, 17);
            this.lblAnh.TabIndex = 16;
            this.lblAnh.Text = "Ảnh 3x4:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(450, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 25);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(365, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 25);
            this.txtDiaChi.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 68);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 17);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1005, 20);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(160, 25);
            this.txtSDT.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(955, 23);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(34, 17);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "SĐT:";
            // 
            // cboPhai
            // 
            this.cboPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Location = new System.Drawing.Point(845, 20);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(95, 25);
            this.cboPhai.TabIndex = 9;
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(800, 23);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(36, 17);
            this.lblPhai.TabIndex = 8;
            this.lblPhai.Text = "Phái:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(645, 20);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(140, 25);
            this.dtNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(565, 23);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(450, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(95, 25);
            this.txtTen.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(410, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 17);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(295, 20);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 25);
            this.txtHo.TabIndex = 3;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(260, 23);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(28, 17);
            this.lblHo.TabIndex = 2;
            this.lblHo.Text = "Họ:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(110, 20);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(130, 25);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 23);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(77, 17);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã độc giả:";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(0, 210);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 30;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(1190, 525);
            this.dgvDocGia.TabIndex = 1;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDong);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 735);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1190, 55);
            this.panelBottom.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1075, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 790);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Độc giả và thẻ";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.Label lblHan;
        private System.Windows.Forms.DateTimePicker dtHan;
        private System.Windows.Forms.CheckBox chkLePhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDong;
    }
}
