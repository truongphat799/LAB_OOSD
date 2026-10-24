namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblLuot = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnGhi = new System.Windows.Forms.Button();

            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.grpLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblLuot);
            this.grpThongTin.Controls.Add(this.cboLuot);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.txtPhong);
            this.grpThongTin.Controls.Add(this.lblDV);
            this.grpThongTin.Controls.Add(this.cboDV);
            this.grpThongTin.Controls.Add(this.lblSL);
            this.grpThongTin.Controls.Add(this.numSL);
            this.grpThongTin.Controls.Add(this.lblNgay);
            this.grpThongTin.Controls.Add(this.dtNgay);
            this.grpThongTin.Controls.Add(this.lblNV);
            this.grpThongTin.Controls.Add(this.cboNV);
            this.grpThongTin.Controls.Add(this.btnGhi);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(860, 135);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Ghi Nhận Sử Dụng Dịch Vụ";

            this.lblLuot.Location = new System.Drawing.Point(15, 32);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(85, 25);
            this.lblLuot.Text = "Phiếu đặt:";
            this.cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuot.Location = new System.Drawing.Point(100, 29);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(130, 29);
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);

            this.lblPhong.Location = new System.Drawing.Point(245, 32);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(55, 25);
            this.lblPhong.Text = "Phòng:";
            this.txtPhong.Location = new System.Drawing.Point(300, 29);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 29);

            this.lblDV.Location = new System.Drawing.Point(415, 32);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(65, 25);
            this.lblDV.Text = "Dịch vụ:";
            this.cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDV.Location = new System.Drawing.Point(480, 29);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(150, 29);

            this.lblSL.Location = new System.Drawing.Point(645, 32);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(70, 25);
            this.lblSL.Text = "Số lượng:";
            this.numSL.Location = new System.Drawing.Point(720, 29);
            this.numSL.Minimum = 1;
            this.numSL.Value = 1;
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(60, 29);

            this.lblNgay.Location = new System.Drawing.Point(15, 82);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(85, 25);
            this.lblNgay.Text = "Ngày dùng:";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(100, 79);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(130, 29);

            this.lblNV.Location = new System.Drawing.Point(245, 82);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(75, 25);
            this.lblNV.Text = "Nhân viên:";
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(325, 79);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(160, 29);

            this.btnGhi.Location = new System.Drawing.Point(520, 74);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(180, 38);
            this.btnGhi.Text = "Ghi Nhận Sử Dụng";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);

            // 
            // grpLichSu
            // 
            this.grpLichSu.Controls.Add(this.dgvLichSu);
            this.grpLichSu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpLichSu.Location = new System.Drawing.Point(12, 160);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(860, 290);
            this.grpLichSu.TabIndex = 1;
            this.grpLichSu.TabStop = false;
            this.grpLichSu.Text = "Lịch Sử Sử Dụng Dịch Vụ Của Phiếu Đang Ở";

            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLichSu.Location = new System.Drawing.Point(15, 30);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 30;
            this.dgvLichSu.Size = new System.Drawing.Size(830, 245);

            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(750, 465);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 515);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpLichSu);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sử Dụng Dịch Vụ";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.grpLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
