namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.GroupBox grpTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.GroupBox grpDV;
        private System.Windows.Forms.DataGridView dgvDV;
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();

            this.grpTongHop = new System.Windows.Forms.GroupBox();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();

            this.grpDV = new System.Windows.Forms.GroupBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.pnlFilter.SuspendLayout();
            this.grpTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.grpDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblTu);
            this.pnlFilter.Controls.Add(this.dtTu);
            this.pnlFilter.Controls.Add(this.lblDen);
            this.pnlFilter.Controls.Add(this.dtDen);
            this.pnlFilter.Controls.Add(this.btnTK);
            this.pnlFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.pnlFilter.Location = new System.Drawing.Point(12, 12);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(860, 60);
            this.pnlFilter.TabIndex = 0;

            this.lblTu.Location = new System.Drawing.Point(20, 18);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(70, 25);
            this.lblTu.Text = "Từ ngày:";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(95, 15);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(140, 29);

            this.lblDen.Location = new System.Drawing.Point(260, 18);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(80, 25);
            this.lblDen.Text = "Đến ngày:";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(345, 15);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(140, 29);

            this.btnTK.Location = new System.Drawing.Point(520, 12);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(180, 35);
            this.btnTK.Text = "Xem Thống Kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);

            // 
            // grpTongHop
            // 
            this.grpTongHop.Controls.Add(this.dgvTongHop);
            this.grpTongHop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpTongHop.Location = new System.Drawing.Point(12, 85);
            this.grpTongHop.Name = "grpTongHop";
            this.grpTongHop.Size = new System.Drawing.Size(860, 150);
            this.grpTongHop.TabIndex = 1;
            this.grpTongHop.TabStop = false;
            this.grpTongHop.Text = "1. Thống Kê Tổng Hợp";

            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTongHop.Location = new System.Drawing.Point(15, 30);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.RowHeadersWidth = 30;
            this.dgvTongHop.Size = new System.Drawing.Size(830, 105);

            // 
            // grpDV
            // 
            this.grpDV.Controls.Add(this.dgvDV);
            this.grpDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpDV.Location = new System.Drawing.Point(12, 245);
            this.grpDV.Name = "grpDV";
            this.grpDV.Size = new System.Drawing.Size(860, 220);
            this.grpDV.TabIndex = 2;
            this.grpDV.TabStop = false;
            this.grpDV.Text = "2. Thống Kê Doanh Thu Theo Dịch Vụ";

            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDV.Location = new System.Drawing.Point(15, 30);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 30;
            this.dgvDV.Size = new System.Drawing.Size(830, 175);

            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(750, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDV);
            this.Controls.Add(this.grpTongHop);
            this.Controls.Add(this.pnlFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo & Thống Kê Khách Sạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.pnlFilter.ResumeLayout(false);
            this.grpTongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.grpDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
