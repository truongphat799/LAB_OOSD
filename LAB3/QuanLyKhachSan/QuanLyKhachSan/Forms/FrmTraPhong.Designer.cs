namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDenBu;
        private System.Windows.Forms.TabPage tabThanhToan;

        // Tab Đền bù
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblDSPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblDSTN;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.Label lblDBChon;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Button btnLapDB;

        // Tab Thanh toán & Trả phòng
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblNV2;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Label lblDSHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label lblHDChon;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.Label lblMaTT;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblTienTT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;

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
            this.tabDenBu = new System.Windows.Forms.TabPage();
            this.tabThanhToan = new System.Windows.Forms.TabPage();

            // Den bu
            this.lblDat = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblDSPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lblDSTN = new System.Windows.Forms.Label();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.lblDBChon = new System.Windows.Forms.Label();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.btnLapDB = new System.Windows.Forms.Button();

            // Thanh toan
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblNV2 = new System.Windows.Forms.Label();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.lblDSHD = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblHDChon = new System.Windows.Forms.Label();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.lblMaTT = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabDenBu.SuspendLayout();
            this.tabThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDenBu);
            this.tabControl.Controls.Add(this.tabThanhToan);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 520);
            this.tabControl.TabIndex = 0;

            // 
            // tabDenBu
            // 
            this.tabDenBu.Controls.Add(this.lblDat);
            this.tabDenBu.Controls.Add(this.cboDat);
            this.tabDenBu.Controls.Add(this.lblNV);
            this.tabDenBu.Controls.Add(this.cboNV);
            this.tabDenBu.Controls.Add(this.lblDSPhong);
            this.tabDenBu.Controls.Add(this.dgvPhong);
            this.tabDenBu.Controls.Add(this.lblDSTN);
            this.tabDenBu.Controls.Add(this.dgvTN);
            this.tabDenBu.Controls.Add(this.lblPhong);
            this.tabDenBu.Controls.Add(this.txtPhong);
            this.tabDenBu.Controls.Add(this.lblMucDo);
            this.tabDenBu.Controls.Add(this.txtMucDo);
            this.tabDenBu.Controls.Add(this.lblDenBu);
            this.tabDenBu.Controls.Add(this.numDenBu);
            this.tabDenBu.Controls.Add(this.btnThemDB);
            this.tabDenBu.Controls.Add(this.lblDBChon);
            this.tabDenBu.Controls.Add(this.dgvDBChon);
            this.tabDenBu.Controls.Add(this.lblSoDB);
            this.tabDenBu.Controls.Add(this.txtSoDB);
            this.tabDenBu.Controls.Add(this.btnLapDB);
            this.tabDenBu.Location = new System.Drawing.Point(4, 30);
            this.tabDenBu.Name = "tabDenBu";
            this.tabDenBu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDenBu.Size = new System.Drawing.Size(942, 486);
            this.tabDenBu.Text = "1. Kiểm Tra & Lập Phiếu Đền Bù";
            this.tabDenBu.UseVisualStyleBackColor = true;

            this.lblDat.Location = new System.Drawing.Point(15, 15);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(120, 25);
            this.lblDat.Text = "Phiếu đang ở:";
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.Location = new System.Drawing.Point(140, 12);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(140, 29);
            this.cboDat.SelectedIndexChanged += new System.EventHandler(this.cboDat_SelectedIndexChanged);

            this.lblNV.Location = new System.Drawing.Point(300, 15);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(75, 25);
            this.lblNV.Text = "Nhân viên:";
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(380, 12);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(160, 29);

            this.lblDSPhong.Location = new System.Drawing.Point(15, 52);
            this.lblDSPhong.Name = "lblDSPhong";
            this.lblDSPhong.Size = new System.Drawing.Size(200, 22);
            this.lblDSPhong.Text = "Phòng trong phiếu đặt:";

            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.Location = new System.Drawing.Point(15, 75);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.Size = new System.Drawing.Size(430, 160);
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);

            this.lblDSTN.Location = new System.Drawing.Point(15, 245);
            this.lblDSTN.Name = "lblDSTN";
            this.lblDSTN.Size = new System.Drawing.Size(200, 22);
            this.lblDSTN.Text = "Tiện nghi thuộc phòng đã chọn:";

            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTN.Location = new System.Drawing.Point(15, 270);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersWidth = 30;
            this.dgvTN.Size = new System.Drawing.Size(430, 200);

            this.lblPhong.Location = new System.Drawing.Point(470, 52);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(55, 25);
            this.lblPhong.Text = "Phòng:";
            this.txtPhong.Location = new System.Drawing.Point(530, 49);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(85, 29);

            this.lblMucDo.Location = new System.Drawing.Point(625, 52);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(65, 25);
            this.lblMucDo.Text = "Thiệt hại:";
            this.txtMucDo.Location = new System.Drawing.Point(695, 49);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(100, 29);

            this.lblDenBu.Location = new System.Drawing.Point(470, 90);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(55, 25);
            this.lblDenBu.Text = "Số tiền:";
            this.numDenBu.Location = new System.Drawing.Point(530, 87);
            this.numDenBu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(120, 29);

            this.btnThemDB.Location = new System.Drawing.Point(665, 84);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(130, 35);
            this.btnThemDB.Text = "Thêm Đền Bù";
            this.btnThemDB.UseVisualStyleBackColor = true;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);

            this.lblDBChon.Location = new System.Drawing.Point(470, 125);
            this.lblDBChon.Name = "lblDBChon";
            this.lblDBChon.Size = new System.Drawing.Size(250, 22);
            this.lblDBChon.Text = "Danh sách tiện nghi cần đền bù:";

            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDBChon.Location = new System.Drawing.Point(470, 150);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.ReadOnly = true;
            this.dgvDBChon.RowHeadersWidth = 30;
            this.dgvDBChon.Size = new System.Drawing.Size(455, 260);

            this.lblSoDB.Location = new System.Drawing.Point(470, 428);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(85, 25);
            this.lblSoDB.Text = "Số phiếu ĐB:";
            this.txtSoDB.Location = new System.Drawing.Point(560, 425);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(120, 29);

            this.btnLapDB.Location = new System.Drawing.Point(695, 421);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(160, 35);
            this.btnLapDB.Text = "Lập Phiếu Đền Bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);

            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Controls.Add(this.lblSoHD);
            this.tabThanhToan.Controls.Add(this.txtSoHD);
            this.tabThanhToan.Controls.Add(this.lblSoNgay);
            this.tabThanhToan.Controls.Add(this.numSoNgay);
            this.tabThanhToan.Controls.Add(this.lblNV2);
            this.tabThanhToan.Controls.Add(this.cboNV2);
            this.tabThanhToan.Controls.Add(this.btnLapHD);
            this.tabThanhToan.Controls.Add(this.lblDSHD);
            this.tabThanhToan.Controls.Add(this.dgvHD);
            this.tabThanhToan.Controls.Add(this.lblHDChon);
            this.tabThanhToan.Controls.Add(this.txtHDChon);
            this.tabThanhToan.Controls.Add(this.lblMaTT);
            this.tabThanhToan.Controls.Add(this.txtMaTT);
            this.tabThanhToan.Controls.Add(this.lblHT);
            this.tabThanhToan.Controls.Add(this.cboHT);
            this.tabThanhToan.Controls.Add(this.lblTienTT);
            this.tabThanhToan.Controls.Add(this.numTienTT);
            this.tabThanhToan.Controls.Add(this.btnThanhToan);
            this.tabThanhToan.Controls.Add(this.btnTraPhong);
            this.tabThanhToan.Location = new System.Drawing.Point(4, 30);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanhToan.Size = new System.Drawing.Size(942, 486);
            this.tabThanhToan.Text = "2. Hóa Đơn - Thanh Toán - Trả Phòng";
            this.tabThanhToan.UseVisualStyleBackColor = true;

            this.lblSoHD.Location = new System.Drawing.Point(15, 18);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(60, 25);
            this.lblSoHD.Text = "Số HĐ:";
            this.txtSoHD.Location = new System.Drawing.Point(75, 15);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(100, 29);

            this.lblSoNgay.Location = new System.Drawing.Point(190, 18);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(65, 25);
            this.lblSoNgay.Text = "Số ngày:";
            this.numSoNgay.Location = new System.Drawing.Point(260, 15);
            this.numSoNgay.Minimum = 1;
            this.numSoNgay.Value = 1;
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(60, 29);

            this.lblNV2.Location = new System.Drawing.Point(335, 18);
            this.lblNV2.Name = "lblNV2";
            this.lblNV2.Size = new System.Drawing.Size(75, 25);
            this.lblNV2.Text = "Nhân viên:";
            this.cboNV2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV2.Location = new System.Drawing.Point(415, 15);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(150, 29);

            this.btnLapHD.Location = new System.Drawing.Point(585, 12);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(140, 35);
            this.btnLapHD.Text = "Lập Hóa Đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);

            this.lblDSHD.Location = new System.Drawing.Point(15, 58);
            this.lblDSHD.Name = "lblDSHD";
            this.lblDSHD.Size = new System.Drawing.Size(200, 22);
            this.lblDSHD.Text = "Danh sách hóa đơn:";

            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHD.Location = new System.Drawing.Point(15, 83);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 30;
            this.dgvHD.Size = new System.Drawing.Size(910, 280);
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);

            this.lblHDChon.Location = new System.Drawing.Point(15, 385);
            this.lblHDChon.Name = "lblHDChon";
            this.lblHDChon.Size = new System.Drawing.Size(70, 25);
            this.lblHDChon.Text = "HĐ chọn:";
            this.txtHDChon.Location = new System.Drawing.Point(85, 382);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.ReadOnly = true;
            this.txtHDChon.Size = new System.Drawing.Size(100, 29);

            this.lblMaTT.Location = new System.Drawing.Point(200, 385);
            this.lblMaTT.Name = "lblMaTT";
            this.lblMaTT.Size = new System.Drawing.Size(55, 25);
            this.lblMaTT.Text = "Mã TT:";
            this.txtMaTT.Location = new System.Drawing.Point(260, 382);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(100, 29);

            this.lblHT.Location = new System.Drawing.Point(375, 385);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(75, 25);
            this.lblHT.Text = "Hình thức:";
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.Location = new System.Drawing.Point(455, 382);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(130, 29);

            this.lblTienTT.Location = new System.Drawing.Point(600, 385);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(65, 25);
            this.lblTienTT.Text = "Tiền TT:";
            this.numTienTT.Location = new System.Drawing.Point(670, 382);
            this.numTienTT.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(120, 29);

            this.btnThanhToan.Location = new System.Drawing.Point(800, 378);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(125, 35);
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTraPhong.Location = new System.Drawing.Point(350, 430);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(240, 45);
            this.btnTraPhong.Text = "XÁC NHẬN TRẢ PHÒNG";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);

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
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 585);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Phòng & Thanh Toán";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDenBu.ResumeLayout(false);
            this.tabDenBu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            this.tabThanhToan.ResumeLayout(false);
            this.tabThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
