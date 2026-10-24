namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabTN;
        private System.Windows.Forms.TabPage tabLapDat;

        // Tab Phòng
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblKhu;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;

        // Tab Tiện nghi
        private System.Windows.Forms.Label lblMaTN;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.DataGridView dgvTN;

        // Tab Lắp đặt
        private System.Windows.Forms.Label lblSoLD;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.Label lblChonPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblTTLD;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.DataGridView dgvLD;

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
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.tabLapDat = new System.Windows.Forms.TabPage();

            // Tab Phong
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblKhu = new System.Windows.Forms.Label();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();

            // Tab TN
            this.lblMaTN = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.dgvTN = new System.Windows.Forms.DataGridView();

            // Tab Lap Dat
            this.lblSoLD = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblTN = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.lblChonPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.dgvLD = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabTN.SuspendLayout();
            this.tabLapDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhong);
            this.tabControl.Controls.Add(this.tabTN);
            this.tabControl.Controls.Add(this.tabLapDat);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(910, 480);
            this.tabControl.TabIndex = 0;

            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.lblPhong);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.lblKhu);
            this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(this.lblMax);
            this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(this.lblGia);
            this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 30);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(902, 446);
            this.tabPhong.Text = "1. Quản Lý Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;

            this.lblPhong.Location = new System.Drawing.Point(15, 18);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(75, 25);
            this.lblPhong.Text = "Số phòng:";
            this.txtPhong.Location = new System.Drawing.Point(95, 15);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 29);

            this.lblKhu.Location = new System.Drawing.Point(210, 18);
            this.lblKhu.Name = "lblKhu";
            this.lblKhu.Size = new System.Drawing.Size(65, 25);
            this.lblKhu.Text = "Khu vực:";
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.Location = new System.Drawing.Point(280, 15);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(130, 29);

            this.lblMax.Location = new System.Drawing.Point(425, 18);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(70, 25);
            this.lblMax.Text = "Sức chứa:";
            this.numMax.Location = new System.Drawing.Point(500, 15);
            this.numMax.Minimum = 1;
            this.numMax.Value = 2;
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(60, 29);

            this.lblGia.Location = new System.Drawing.Point(575, 18);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(65, 25);
            this.lblGia.Text = "Đơn giá:";
            this.numGia.Location = new System.Drawing.Point(645, 15);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Value = 300000;
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(115, 29);

            this.btnThemPhong.Location = new System.Drawing.Point(775, 12);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(110, 35);
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);

            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.Location = new System.Drawing.Point(15, 60);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.Size = new System.Drawing.Size(870, 370);

            // 
            // tabTN
            // 
            this.tabTN.Controls.Add(this.lblMaTN);
            this.tabTN.Controls.Add(this.txtMaTN);
            this.tabTN.Controls.Add(this.lblLoai);
            this.tabTN.Controls.Add(this.cboLoai);
            this.tabTN.Controls.Add(this.lblSTT);
            this.tabTN.Controls.Add(this.numSTT);
            this.tabTN.Controls.Add(this.lblTinhTrang);
            this.tabTN.Controls.Add(this.txtTinhTrang);
            this.tabTN.Controls.Add(this.btnThemTN);
            this.tabTN.Controls.Add(this.dgvTN);
            this.tabTN.Location = new System.Drawing.Point(4, 30);
            this.tabTN.Name = "tabTN";
            this.tabTN.Padding = new System.Windows.Forms.Padding(3);
            this.tabTN.Size = new System.Drawing.Size(902, 446);
            this.tabTN.Text = "2. Tiện Nghi";
            this.tabTN.UseVisualStyleBackColor = true;

            this.lblMaTN.Location = new System.Drawing.Point(15, 18);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(60, 25);
            this.lblMaTN.Text = "Mã TN:";
            this.txtMaTN.Location = new System.Drawing.Point(80, 15);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(100, 29);

            this.lblLoai.Location = new System.Drawing.Point(195, 18);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(65, 25);
            this.lblLoai.Text = "Loại TN:";
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Location = new System.Drawing.Point(265, 15);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(140, 29);

            this.lblSTT.Location = new System.Drawing.Point(420, 18);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(40, 25);
            this.lblSTT.Text = "STT:";
            this.numSTT.Location = new System.Drawing.Point(465, 15);
            this.numSTT.Minimum = 1;
            this.numSTT.Value = 1;
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(60, 29);

            this.lblTinhTrang.Location = new System.Drawing.Point(540, 18);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(80, 25);
            this.lblTinhTrang.Text = "Tình trạng:";
            this.txtTinhTrang.Location = new System.Drawing.Point(625, 15);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(130, 29);

            this.btnThemTN.Location = new System.Drawing.Point(770, 12);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(115, 35);
            this.btnThemTN.Text = "Thêm TN";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);

            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTN.Location = new System.Drawing.Point(15, 60);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersWidth = 30;
            this.dgvTN.Size = new System.Drawing.Size(870, 370);

            // 
            // tabLapDat
            // 
            this.tabLapDat.Controls.Add(this.lblSoLD);
            this.tabLapDat.Controls.Add(this.txtSoLD);
            this.tabLapDat.Controls.Add(this.lblTN);
            this.tabLapDat.Controls.Add(this.cboTN);
            this.tabLapDat.Controls.Add(this.lblChonPhong);
            this.tabLapDat.Controls.Add(this.cboPhong);
            this.tabLapDat.Controls.Add(this.lblNgay);
            this.tabLapDat.Controls.Add(this.dtNgay);
            this.tabLapDat.Controls.Add(this.lblNV);
            this.tabLapDat.Controls.Add(this.cboNV);
            this.tabLapDat.Controls.Add(this.lblTTLD);
            this.tabLapDat.Controls.Add(this.txtTTLD);
            this.tabLapDat.Controls.Add(this.lblGhiChu);
            this.tabLapDat.Controls.Add(this.txtGhiChu);
            this.tabLapDat.Controls.Add(this.btnLapDat);
            this.tabLapDat.Controls.Add(this.dgvLD);
            this.tabLapDat.Location = new System.Drawing.Point(4, 30);
            this.tabLapDat.Name = "tabLapDat";
            this.tabLapDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLapDat.Size = new System.Drawing.Size(902, 446);
            this.tabLapDat.Text = "3. Lắp Đặt / Luân Chuyển";
            this.tabLapDat.UseVisualStyleBackColor = true;

            this.lblSoLD.Location = new System.Drawing.Point(15, 15);
            this.lblSoLD.Name = "lblSoLD";
            this.lblSoLD.Size = new System.Drawing.Size(70, 25);
            this.lblSoLD.Text = "Số phiếu:";
            this.txtSoLD.Location = new System.Drawing.Point(90, 12);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(100, 29);

            this.lblTN.Location = new System.Drawing.Point(205, 15);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(70, 25);
            this.lblTN.Text = "Tiện nghi:";
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.Location = new System.Drawing.Point(280, 12);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(110, 29);

            this.lblChonPhong.Location = new System.Drawing.Point(405, 15);
            this.lblChonPhong.Name = "lblChonPhong";
            this.lblChonPhong.Size = new System.Drawing.Size(55, 25);
            this.lblChonPhong.Text = "Phòng:";
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(465, 12);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(100, 29);

            this.lblNgay.Location = new System.Drawing.Point(580, 15);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(75, 25);
            this.lblNgay.Text = "Ngày lắp:";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(660, 12);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(120, 29);

            this.lblNV.Location = new System.Drawing.Point(15, 55);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(70, 25);
            this.lblNV.Text = "Nhân viên:";
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(90, 52);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(140, 29);

            this.lblTTLD.Location = new System.Drawing.Point(245, 55);
            this.lblTTLD.Name = "lblTTLD";
            this.lblTTLD.Size = new System.Drawing.Size(75, 25);
            this.lblTTLD.Text = "Tình trạng:";
            this.txtTTLD.Location = new System.Drawing.Point(325, 52);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(120, 29);

            this.lblGhiChu.Location = new System.Drawing.Point(460, 55);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(65, 25);
            this.lblGhiChu.Text = "Ghi chú:";
            this.txtGhiChu.Location = new System.Drawing.Point(530, 52);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(170, 29);

            this.btnLapDat.Location = new System.Drawing.Point(720, 48);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(165, 35);
            this.btnLapDat.Text = "Lập Phiếu Lắp Đặt";
            this.btnLapDat.UseVisualStyleBackColor = true;
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);

            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLD.Location = new System.Drawing.Point(15, 95);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.ReadOnly = true;
            this.dgvLD.RowHeadersWidth = 30;
            this.dgvLD.Size = new System.Drawing.Size(870, 335);

            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(800, 500);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 545);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng & Tiện Nghi";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabTN.ResumeLayout(false);
            this.tabTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.tabLapDat.ResumeLayout(false);
            this.tabLapDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
