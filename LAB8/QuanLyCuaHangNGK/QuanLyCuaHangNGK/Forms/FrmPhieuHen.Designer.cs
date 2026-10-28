namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmPhieuHen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDSPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuHen;
        private System.Windows.Forms.Label lblDSMatHang;
        private System.Windows.Forms.DataGridView dgvCTHen;
        private System.Windows.Forms.GroupBox grpGiaoDot;
        private System.Windows.Forms.Label lblMaPH;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label lblMaNGK;
        private System.Windows.Forms.TextBox txtMaNGK;
        private System.Windows.Forms.Label lblSLGiao;
        private System.Windows.Forms.NumericUpDown numSLGiao;
        private System.Windows.Forms.Button btnGiaoDot;
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
            this.lblDSPhieu = new System.Windows.Forms.Label();
            this.dgvPhieuHen = new System.Windows.Forms.DataGridView();
            this.lblDSMatHang = new System.Windows.Forms.Label();
            this.dgvCTHen = new System.Windows.Forms.DataGridView();
            this.grpGiaoDot = new System.Windows.Forms.GroupBox();
            this.btnGiaoDot = new System.Windows.Forms.Button();
            this.numSLGiao = new System.Windows.Forms.NumericUpDown();
            this.lblSLGiao = new System.Windows.Forms.Label();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.lblMaNGK = new System.Windows.Forms.Label();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.lblMaPH = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHen)).BeginInit();
            this.grpGiaoDot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(860, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ PHIẾU HẸN GIAO HÀNG & GIAO HÀNG NHIỀU ĐỢT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSPhieu
            // 
            this.lblDSPhieu.AutoSize = true;
            this.lblDSPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDSPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSPhieu.Location = new System.Drawing.Point(12, 45);
            this.lblDSPhieu.Name = "lblDSPhieu";
            this.lblDSPhieu.Size = new System.Drawing.Size(263, 21);
            this.lblDSPhieu.TabIndex = 1;
            this.lblDSPhieu.Text = "1. Danh sách phiếu hẹn giao hàng:";
            // 
            // dgvPhieuHen
            // 
            this.dgvPhieuHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuHen.Location = new System.Drawing.Point(12, 70);
            this.dgvPhieuHen.Name = "dgvPhieuHen";
            this.dgvPhieuHen.RowHeadersWidth = 51;
            this.dgvPhieuHen.RowTemplate.Height = 24;
            this.dgvPhieuHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuHen.Size = new System.Drawing.Size(860, 160);
            this.dgvPhieuHen.TabIndex = 2;
            this.dgvPhieuHen.SelectionChanged += new System.EventHandler(this.dgvPhieuHen_SelectionChanged);
            // 
            // lblDSMatHang
            // 
            this.lblDSMatHang.AutoSize = true;
            this.lblDSMatHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDSMatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblDSMatHang.Location = new System.Drawing.Point(12, 238);
            this.lblDSMatHang.Name = "lblDSMatHang";
            this.lblDSMatHang.Size = new System.Drawing.Size(359, 21);
            this.lblDSMatHang.TabIndex = 3;
            this.lblDSMatHang.Text = "2. Chi tiết các mặt hàng trong phiếu hẹn chọn:";
            // 
            // dgvCTHen
            // 
            this.dgvCTHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHen.Location = new System.Drawing.Point(12, 263);
            this.dgvCTHen.Name = "dgvCTHen";
            this.dgvCTHen.RowHeadersWidth = 51;
            this.dgvCTHen.RowTemplate.Height = 24;
            this.dgvCTHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHen.Size = new System.Drawing.Size(860, 140);
            this.dgvCTHen.TabIndex = 4;
            this.dgvCTHen.SelectionChanged += new System.EventHandler(this.dgvCTHen_SelectionChanged);
            // 
            // grpGiaoDot
            // 
            this.grpGiaoDot.Controls.Add(this.btnGiaoDot);
            this.grpGiaoDot.Controls.Add(this.numSLGiao);
            this.grpGiaoDot.Controls.Add(this.lblSLGiao);
            this.grpGiaoDot.Controls.Add(this.txtMaNGK);
            this.grpGiaoDot.Controls.Add(this.lblMaNGK);
            this.grpGiaoDot.Controls.Add(this.txtMaPH);
            this.grpGiaoDot.Controls.Add(this.lblMaPH);
            this.grpGiaoDot.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpGiaoDot.Location = new System.Drawing.Point(12, 410);
            this.grpGiaoDot.Name = "grpGiaoDot";
            this.grpGiaoDot.Size = new System.Drawing.Size(750, 70);
            this.grpGiaoDot.TabIndex = 5;
            this.grpGiaoDot.TabStop = false;
            this.grpGiaoDot.Text = "Xác Nhận Giao Hàng Đợt Này (Kho Có Hàng Về)";
            // 
            // btnGiaoDot
            // 
            this.btnGiaoDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnGiaoDot.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGiaoDot.ForeColor = System.Drawing.Color.White;
            this.btnGiaoDot.Location = new System.Drawing.Point(545, 23);
            this.btnGiaoDot.Name = "btnGiaoDot";
            this.btnGiaoDot.Size = new System.Drawing.Size(190, 35);
            this.btnGiaoDot.TabIndex = 6;
            this.btnGiaoDot.Text = "✓ Giao Hàng Đợt Này";
            this.btnGiaoDot.UseVisualStyleBackColor = false;
            this.btnGiaoDot.Click += new System.EventHandler(this.btnGiaoDot_Click);
            // 
            // numSLGiao
            // 
            this.numSLGiao.Location = new System.Drawing.Point(440, 27);
            this.numSLGiao.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSLGiao.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSLGiao.Name = "numSLGiao";
            this.numSLGiao.Size = new System.Drawing.Size(85, 29);
            this.numSLGiao.TabIndex = 5;
            this.numSLGiao.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblSLGiao
            // 
            this.lblSLGiao.AutoSize = true;
            this.lblSLGiao.Location = new System.Drawing.Point(375, 30);
            this.lblSLGiao.Name = "lblSLGiao";
            this.lblSLGiao.Size = new System.Drawing.Size(66, 21);
            this.lblSLGiao.TabIndex = 4;
            this.lblSLGiao.Text = "SL Giao:";
            // 
            // txtMaNGK
            // 
            this.txtMaNGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaNGK.Location = new System.Drawing.Point(265, 27);
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.ReadOnly = true;
            this.txtMaNGK.Size = new System.Drawing.Size(95, 29);
            this.txtMaNGK.TabIndex = 3;
            // 
            // lblMaNGK
            // 
            this.lblMaNGK.AutoSize = true;
            this.lblMaNGK.Location = new System.Drawing.Point(195, 30);
            this.lblMaNGK.Name = "lblMaNGK";
            this.lblMaNGK.Size = new System.Drawing.Size(71, 21);
            this.lblMaNGK.TabIndex = 2;
            this.lblMaNGK.Text = "Mã NGK:";
            // 
            // txtMaPH
            // 
            this.txtMaPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaPH.Location = new System.Drawing.Point(75, 27);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.ReadOnly = true;
            this.txtMaPH.Size = new System.Drawing.Size(105, 29);
            this.txtMaPH.TabIndex = 1;
            // 
            // lblMaPH
            // 
            this.lblMaPH.AutoSize = true;
            this.lblMaPH.Location = new System.Drawing.Point(15, 30);
            this.lblMaPH.Name = "lblMaPH";
            this.lblMaPH.Size = new System.Drawing.Size(58, 21);
            this.lblMaPH.TabIndex = 0;
            this.lblMaPH.Text = "Mã PH:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(772, 435);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpGiaoDot);
            this.Controls.Add(this.dgvCTHen);
            this.Controls.Add(this.lblDSMatHang);
            this.Controls.Add(this.dgvPhieuHen);
            this.Controls.Add(this.lblDSPhieu);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Hẹn Giao Hàng & Giao Hàng Nhiều Đợt";
            this.Load += new System.EventHandler(this.FrmPhieuHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHen)).EndInit();
            this.grpGiaoDot.ResumeLayout(false);
            this.grpGiaoDot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLGiao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
