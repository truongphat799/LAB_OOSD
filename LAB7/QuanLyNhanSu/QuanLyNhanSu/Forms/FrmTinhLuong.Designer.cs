namespace QuanLyNhanSu.Forms
{
    partial class FrmTinhLuong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label lblTabs;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblKyLuong;
        private System.Windows.Forms.TextBox txtKyLuong;
        private System.Windows.Forms.Label lblCongChuan;
        private System.Windows.Forms.TextBox txtCongChuan;
        private System.Windows.Forms.Label lblTongQuyLuong;
        private System.Windows.Forms.TextBox txtTongQuyLuong;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnPheDuyet;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvBangLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.lblTabs = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblKyLuong = new System.Windows.Forms.Label();
            this.txtKyLuong = new System.Windows.Forms.TextBox();
            this.lblCongChuan = new System.Windows.Forms.Label();
            this.txtCongChuan = new System.Windows.Forms.TextBox();
            this.lblTongQuyLuong = new System.Windows.Forms.Label();
            this.txtTongQuyLuong = new System.Windows.Forms.TextBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnPheDuyet = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.pnlTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitleBar.Controls.Add(this.lblWindowTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1084, 45);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblWindowTitle.Location = new System.Drawing.Point(12, 12);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(434, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "📁 Bảng thanh toán tiền lương tháng & Quyết toán chi trả";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlTabs.Controls.Add(this.lblTabs);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 45);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1084, 32);
            this.pnlTabs.TabIndex = 1;
            // 
            // lblTabs
            // 
            this.lblTabs.AutoSize = true;
            this.lblTabs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTabs.Location = new System.Drawing.Point(12, 7);
            this.lblTabs.Name = "lblTabs";
            this.lblTabs.Size = new System.Drawing.Size(730, 17);
            this.lblTabs.TabIndex = 0;
            this.lblTabs.Text = "[ Tổng hợp công & phụ trội ]   [ ▶ Bảng tính lương tự động (Đang chọn) ]   [ Phê duyệt bảng lương ]   [ Phiếu lương cá nhân ]";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblKyLuong);
            this.pnlFilter.Controls.Add(this.txtKyLuong);
            this.pnlFilter.Controls.Add(this.lblCongChuan);
            this.pnlFilter.Controls.Add(this.txtCongChuan);
            this.pnlFilter.Controls.Add(this.lblTongQuyLuong);
            this.pnlFilter.Controls.Add(this.txtTongQuyLuong);
            this.pnlFilter.Controls.Add(this.btnTinhLuong);
            this.pnlFilter.Controls.Add(this.btnPheDuyet);
            this.pnlFilter.Controls.Add(this.btnXuatExcel);
            this.pnlFilter.Controls.Add(this.btnLamMoi);
            this.pnlFilter.Location = new System.Drawing.Point(12, 85);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1060, 60);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblKyLuong
            // 
            this.lblKyLuong.AutoSize = true;
            this.lblKyLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKyLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblKyLuong.Location = new System.Drawing.Point(10, 20);
            this.lblKyLuong.Name = "lblKyLuong";
            this.lblKyLuong.Size = new System.Drawing.Size(60, 15);
            this.lblKyLuong.TabIndex = 0;
            this.lblKyLuong.Text = "Kỳ lương:";
            // 
            // txtKyLuong
            // 
            this.txtKyLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtKyLuong.Location = new System.Drawing.Point(75, 17);
            this.txtKyLuong.Name = "txtKyLuong";
            this.txtKyLuong.Size = new System.Drawing.Size(95, 23);
            this.txtKyLuong.TabIndex = 1;
            this.txtKyLuong.Text = "10/2026";
            this.txtKyLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCongChuan
            // 
            this.lblCongChuan.AutoSize = true;
            this.lblCongChuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCongChuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCongChuan.Location = new System.Drawing.Point(180, 20);
            this.lblCongChuan.Name = "lblCongChuan";
            this.lblCongChuan.Size = new System.Drawing.Size(78, 15);
            this.lblCongChuan.TabIndex = 2;
            this.lblCongChuan.Text = "Công chuẩn:";
            // 
            // txtCongChuan
            // 
            this.txtCongChuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCongChuan.Location = new System.Drawing.Point(265, 17);
            this.txtCongChuan.Name = "txtCongChuan";
            this.txtCongChuan.ReadOnly = true;
            this.txtCongChuan.Size = new System.Drawing.Size(70, 23);
            this.txtCongChuan.TabIndex = 3;
            this.txtCongChuan.Text = "26 ngày";
            this.txtCongChuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTongQuyLuong
            // 
            this.lblTongQuyLuong.AutoSize = true;
            this.lblTongQuyLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongQuyLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTongQuyLuong.Location = new System.Drawing.Point(345, 20);
            this.lblTongQuyLuong.Name = "lblTongQuyLuong";
            this.lblTongQuyLuong.Size = new System.Drawing.Size(96, 15);
            this.lblTongQuyLuong.TabIndex = 4;
            this.lblTongQuyLuong.Text = "Tổng quỹ lương:";
            // 
            // txtTongQuyLuong
            // 
            this.txtTongQuyLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtTongQuyLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTongQuyLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.txtTongQuyLuong.Location = new System.Drawing.Point(445, 17);
            this.txtTongQuyLuong.Name = "txtTongQuyLuong";
            this.txtTongQuyLuong.ReadOnly = true;
            this.txtTongQuyLuong.Size = new System.Drawing.Size(130, 23);
            this.txtTongQuyLuong.TabIndex = 5;
            this.txtTongQuyLuong.Text = "73,732,500 VNĐ";
            this.txtTongQuyLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnTinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(590, 14);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(160, 30);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "⚡ Tính Lương Toàn Cty";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.BtnTinhLuong_Click);
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.BackColor = System.Drawing.Color.White;
            this.btnPheDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPheDuyet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnPheDuyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPheDuyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnPheDuyet.Location = new System.Drawing.Point(755, 14);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(110, 30);
            this.btnPheDuyet.TabIndex = 7;
            this.btnPheDuyet.Text = "✔ Duyệt Lương";
            this.btnPheDuyet.UseVisualStyleBackColor = false;
            this.btnPheDuyet.Click += new System.EventHandler(this.BtnPheDuyet_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.White;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(870, 14);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 30);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.Text = "📄 Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.BtnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLamMoi.Location = new System.Drawing.Point(975, 14);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "⟳ Tải lại";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangLuong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangLuong.EnableHeadersVisualStyles = false;
            this.dgvBangLuong.Location = new System.Drawing.Point(12, 155);
            this.dgvBangLuong.MultiSelect = false;
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersVisible = false;
            this.dgvBangLuong.RowTemplate.Height = 26;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1060, 395);
            this.dgvBangLuong.TabIndex = 3;
            // 
            // FrmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1084, 565);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng thanh toán tiền lương tháng & Quyết toán chi trả";
            this.Load += new System.EventHandler(this.FrmTinhLuong_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
