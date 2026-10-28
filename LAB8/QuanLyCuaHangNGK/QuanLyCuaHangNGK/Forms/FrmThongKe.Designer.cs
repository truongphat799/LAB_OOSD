namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnXem;

        private System.Windows.Forms.Panel pnlKPI;
        private System.Windows.Forms.Label lblKpiDoanhThu;
        private System.Windows.Forms.Label lblKpiSoHD;
        private System.Windows.Forms.Label lblKpiCongNo;
        private System.Windows.Forms.Label lblKpiSapHet;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvTonKho;
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
            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblTu = new System.Windows.Forms.Label();
            this.pnlKPI = new System.Windows.Forms.Panel();
            this.lblKpiSapHet = new System.Windows.Forms.Label();
            this.lblKpiCongNo = new System.Windows.Forms.Label();
            this.lblKpiSoHD = new System.Windows.Forms.Label();
            this.lblKpiDoanhThu = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpBoLoc.SuspendLayout();
            this.pnlKPI.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
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
            this.lblTieuDe.Text = "BÁO CÁO THỐNG KÊ & DOANH THU BÁN HÀNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoLoc
            // 
            this.grpBoLoc.Controls.Add(this.btnXem);
            this.grpBoLoc.Controls.Add(this.dtDen);
            this.grpBoLoc.Controls.Add(this.lblDen);
            this.grpBoLoc.Controls.Add(this.dtTu);
            this.grpBoLoc.Controls.Add(this.lblTu);
            this.grpBoLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpBoLoc.Location = new System.Drawing.Point(12, 45);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Size = new System.Drawing.Size(860, 65);
            this.grpBoLoc.TabIndex = 1;
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "Thời Gian Thống Kê";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(545, 20);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(160, 32);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "📊 Xem Báo Cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(345, 22);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(160, 29);
            this.dtDen.TabIndex = 3;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(265, 26);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(80, 21);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(85, 22);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(160, 29);
            this.dtTu.TabIndex = 1;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(15, 26);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(69, 21);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // pnlKPI
            // 
            this.pnlKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnlKPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKPI.Controls.Add(this.lblKpiSapHet);
            this.pnlKPI.Controls.Add(this.lblKpiCongNo);
            this.pnlKPI.Controls.Add(this.lblKpiSoHD);
            this.pnlKPI.Controls.Add(this.lblKpiDoanhThu);
            this.pnlKPI.Location = new System.Drawing.Point(12, 118);
            this.pnlKPI.Name = "pnlKPI";
            this.pnlKPI.Size = new System.Drawing.Size(860, 45);
            this.pnlKPI.TabIndex = 2;
            // 
            // lblKpiSapHet
            // 
            this.lblKpiSapHet.AutoSize = true;
            this.lblKpiSapHet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiSapHet.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKpiSapHet.Location = new System.Drawing.Point(670, 11);
            this.lblKpiSapHet.Name = "lblKpiSapHet";
            this.lblKpiSapHet.Size = new System.Drawing.Size(125, 21);
            this.lblKpiSapHet.TabIndex = 3;
            this.lblKpiSapHet.Text = "Hàng sắp hết: 0";
            // 
            // lblKpiCongNo
            // 
            this.lblKpiCongNo.AutoSize = true;
            this.lblKpiCongNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiCongNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKpiCongNo.Location = new System.Drawing.Point(420, 11);
            this.lblKpiCongNo.Name = "lblKpiCongNo";
            this.lblKpiCongNo.Size = new System.Drawing.Size(149, 21);
            this.lblKpiCongNo.TabIndex = 2;
            this.lblKpiCongNo.Text = "Dư nợ chưa thu: 0đ";
            // 
            // lblKpiSoHD
            // 
            this.lblKpiSoHD.AutoSize = true;
            this.lblKpiSoHD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiSoHD.ForeColor = System.Drawing.Color.Green;
            this.lblKpiSoHD.Location = new System.Drawing.Point(250, 11);
            this.lblKpiSoHD.Name = "lblKpiSoHD";
            this.lblKpiSoHD.Size = new System.Drawing.Size(107, 21);
            this.lblKpiSoHD.TabIndex = 1;
            this.lblKpiSoHD.Text = "Số hóa đơn: 0";
            // 
            // lblKpiDoanhThu
            // 
            this.lblKpiDoanhThu.AutoSize = true;
            this.lblKpiDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblKpiDoanhThu.Location = new System.Drawing.Point(15, 11);
            this.lblKpiDoanhThu.Name = "lblKpiDoanhThu";
            this.lblKpiDoanhThu.Size = new System.Drawing.Size(155, 21);
            this.lblKpiDoanhThu.TabIndex = 0;
            this.lblKpiDoanhThu.Text = "Tổng doanh thu: 0đ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDoanhThu);
            this.tabControl1.Controls.Add(this.tabTonKho);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(12, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 275);
            this.tabControl1.TabIndex = 3;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 30);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(852, 241);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu Chi Tiết Theo Nước Giải Khát";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(846, 235);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.dgvTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 30);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(852, 241);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "Cảnh Báo Tồn Kho Dưới Định Mức Tối Thiểu";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKho.Location = new System.Drawing.Point(3, 3);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.RowTemplate.Height = 24;
            this.dgvTonKho.Size = new System.Drawing.Size(846, 235);
            this.dgvTonKho.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(772, 455);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlKPI);
            this.Controls.Add(this.grpBoLoc);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê & Doanh Thu Bán Hàng";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.grpBoLoc.ResumeLayout(false);
            this.grpBoLoc.PerformLayout();
            this.pnlKPI.ResumeLayout(false);
            this.pnlKPI.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
