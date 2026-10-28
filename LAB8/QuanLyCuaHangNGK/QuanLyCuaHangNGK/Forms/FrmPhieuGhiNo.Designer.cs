namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmPhieuGhiNo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDSNo;
        private System.Windows.Forms.DataGridView dgvPhieuNo;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.DataGridView dgvThuNo;
        private System.Windows.Forms.GroupBox grpThuNo;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label lblMaPTN;
        private System.Windows.Forms.TextBox txtMaPTN;
        private System.Windows.Forms.Label lblTienThu;
        private System.Windows.Forms.NumericUpDown numTienThu;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblNVThu;
        private System.Windows.Forms.ComboBox cboNVThu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThuNo;
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
            this.lblDSNo = new System.Windows.Forms.Label();
            this.dgvPhieuNo = new System.Windows.Forms.DataGridView();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.dgvThuNo = new System.Windows.Forms.DataGridView();
            this.grpThuNo = new System.Windows.Forms.GroupBox();
            this.btnThuNo = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboNVThu = new System.Windows.Forms.ComboBox();
            this.lblNVThu = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.numTienThu = new System.Windows.Forms.NumericUpDown();
            this.lblTienThu = new System.Windows.Forms.Label();
            this.txtMaPTN = new System.Windows.Forms.TextBox();
            this.lblMaPTN = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNo)).BeginInit();
            this.grpThuNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienThu)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ CÔNG NỢ & LẬP PHIẾU GHI NỢ (KHÁCH QUEN TRẢ CHẬM)";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSNo
            // 
            this.lblDSNo.AutoSize = true;
            this.lblDSNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDSNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSNo.Location = new System.Drawing.Point(12, 45);
            this.lblDSNo.Name = "lblDSNo";
            this.lblDSNo.Size = new System.Drawing.Size(262, 21);
            this.lblDSNo.TabIndex = 1;
            this.lblDSNo.Text = "1. Danh sách phiếu ghi nợ hiện tại:";
            // 
            // dgvPhieuNo
            // 
            this.dgvPhieuNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNo.Location = new System.Drawing.Point(12, 70);
            this.dgvPhieuNo.Name = "dgvPhieuNo";
            this.dgvPhieuNo.RowHeadersWidth = 51;
            this.dgvPhieuNo.RowTemplate.Height = 24;
            this.dgvPhieuNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNo.Size = new System.Drawing.Size(910, 160);
            this.dgvPhieuNo.TabIndex = 2;
            this.dgvPhieuNo.SelectionChanged += new System.EventHandler(this.dgvPhieuNo_SelectionChanged);
            // 
            // lblLichSu
            // 
            this.lblLichSu.AutoSize = true;
            this.lblLichSu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLichSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblLichSu.Location = new System.Drawing.Point(12, 238);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(341, 21);
            this.lblLichSu.TabIndex = 3;
            this.lblLichSu.Text = "2. Lịch sử các lần thu nợ của phiếu nợ chọn:";
            // 
            // dgvThuNo
            // 
            this.dgvThuNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuNo.Location = new System.Drawing.Point(12, 263);
            this.dgvThuNo.Name = "dgvThuNo";
            this.dgvThuNo.RowHeadersWidth = 51;
            this.dgvThuNo.RowTemplate.Height = 24;
            this.dgvThuNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuNo.Size = new System.Drawing.Size(910, 130);
            this.dgvThuNo.TabIndex = 4;
            // 
            // grpThuNo
            // 
            this.grpThuNo.Controls.Add(this.btnThuNo);
            this.grpThuNo.Controls.Add(this.txtGhiChu);
            this.grpThuNo.Controls.Add(this.lblGhiChu);
            this.grpThuNo.Controls.Add(this.cboNVThu);
            this.grpThuNo.Controls.Add(this.lblNVThu);
            this.grpThuNo.Controls.Add(this.cboHT);
            this.grpThuNo.Controls.Add(this.lblHT);
            this.grpThuNo.Controls.Add(this.numTienThu);
            this.grpThuNo.Controls.Add(this.lblTienThu);
            this.grpThuNo.Controls.Add(this.txtMaPTN);
            this.grpThuNo.Controls.Add(this.lblMaPTN);
            this.grpThuNo.Controls.Add(this.txtMaPN);
            this.grpThuNo.Controls.Add(this.lblMaPN);
            this.grpThuNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThuNo.Location = new System.Drawing.Point(12, 400);
            this.grpThuNo.Name = "grpThuNo";
            this.grpThuNo.Size = new System.Drawing.Size(800, 105);
            this.grpThuNo.TabIndex = 5;
            this.grpThuNo.TabStop = false;
            this.grpThuNo.Text = "Ghi Nhận Thu Tiền Nợ Từng Lần";
            // 
            // btnThuNo
            // 
            this.btnThuNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnThuNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThuNo.ForeColor = System.Drawing.Color.White;
            this.btnThuNo.Location = new System.Drawing.Point(630, 60);
            this.btnThuNo.Name = "btnThuNo";
            this.btnThuNo.Size = new System.Drawing.Size(160, 35);
            this.btnThuNo.TabIndex = 12;
            this.btnThuNo.Text = "💵 Thu Nợ & In Biên Lai";
            this.btnThuNo.UseVisualStyleBackColor = false;
            this.btnThuNo.Click += new System.EventHandler(this.btnThuNo_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(265, 63);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 29);
            this.txtGhiChu.TabIndex = 11;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(200, 66);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(66, 21);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboNVThu
            // 
            this.cboNVThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVThu.FormattingEnabled = true;
            this.cboNVThu.Location = new System.Drawing.Point(65, 63);
            this.cboNVThu.Name = "cboNVThu";
            this.cboNVThu.Size = new System.Drawing.Size(125, 29);
            this.cboNVThu.TabIndex = 9;
            // 
            // lblNVThu
            // 
            this.lblNVThu.AutoSize = true;
            this.lblNVThu.Location = new System.Drawing.Point(5, 66);
            this.lblNVThu.Name = "lblNVThu";
            this.lblNVThu.Size = new System.Drawing.Size(65, 21);
            this.lblNVThu.TabIndex = 8;
            this.lblNVThu.Text = "NV Thu:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Ví điện tử"});
            this.cboHT.Location = new System.Drawing.Point(665, 23);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(125, 29);
            this.cboHT.TabIndex = 7;
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(585, 26);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(81, 21);
            this.lblHT.TabIndex = 6;
            this.lblHT.Text = "Hình thức:";
            // 
            // numTienThu
            // 
            this.numTienThu.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numTienThu.Location = new System.Drawing.Point(445, 24);
            this.numTienThu.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numTienThu.Name = "numTienThu";
            this.numTienThu.Size = new System.Drawing.Size(130, 29);
            this.numTienThu.TabIndex = 5;
            // 
            // lblTienThu
            // 
            this.lblTienThu.AutoSize = true;
            this.lblTienThu.Location = new System.Drawing.Point(375, 26);
            this.lblTienThu.Name = "lblTienThu";
            this.lblTienThu.Size = new System.Drawing.Size(70, 21);
            this.lblTienThu.TabIndex = 4;
            this.lblTienThu.Text = "Tiền thu:";
            // 
            // txtMaPTN
            // 
            this.txtMaPTN.Location = new System.Drawing.Point(265, 23);
            this.txtMaPTN.Name = "txtMaPTN";
            this.txtMaPTN.Size = new System.Drawing.Size(95, 29);
            this.txtMaPTN.TabIndex = 3;
            // 
            // lblMaPTN
            // 
            this.lblMaPTN.AutoSize = true;
            this.lblMaPTN.Location = new System.Drawing.Point(195, 26);
            this.lblMaPTN.Name = "lblMaPTN";
            this.lblMaPTN.Size = new System.Drawing.Size(68, 21);
            this.lblMaPTN.TabIndex = 2;
            this.lblMaPTN.Text = "Mã PTN:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaPN.Location = new System.Drawing.Point(65, 23);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(115, 29);
            this.txtMaPN.TabIndex = 1;
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Location = new System.Drawing.Point(5, 26);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(60, 21);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã PN:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(822, 460);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhieuGhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 516);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpThuNo);
            this.Controls.Add(this.dgvThuNo);
            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.dgvPhieuNo);
            this.Controls.Add(this.lblDSNo);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhieuGhiNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Công Nợ & Lập Phiếu Ghi Nợ (Khách Quen)";
            this.Load += new System.EventHandler(this.FrmPhieuGhiNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNo)).EndInit();
            this.grpThuNo.ResumeLayout(false);
            this.grpThuNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
