namespace QuanLyNhanSu.Forms
{
    partial class FrmKhenThuongKyLuat
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label lblTabs;

        private System.Windows.Forms.GroupBox grpDieuKhien;
        private System.Windows.Forms.Label lblSoQD;
        private System.Windows.Forms.TextBox txtSoQD;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblLoaiQD;
        private System.Windows.Forms.ComboBox cboLoaiQD;
        private System.Windows.Forms.Button btnDuyetQD;

        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Button btnXuatPhieu;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvKhenThuong;

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
            this.grpDieuKhien = new System.Windows.Forms.GroupBox();
            this.lblSoQD = new System.Windows.Forms.Label();
            this.txtSoQD = new System.Windows.Forms.TextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblLoaiQD = new System.Windows.Forms.Label();
            this.cboLoaiQD = new System.Windows.Forms.ComboBox();
            this.btnDuyetQD = new System.Windows.Forms.Button();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.btnXuatPhieu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.grpDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
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
            this.pnlTitleBar.Size = new System.Drawing.Size(984, 45);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblWindowTitle.Location = new System.Drawing.Point(12, 12);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(340, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "📁 Quản lý Khen thưởng & Xử lý Kỷ luật";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlTabs.Controls.Add(this.lblTabs);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 45);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(984, 32);
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
            this.lblTabs.Text = "[ Đề xuất khen thưởng/kỷ luật ]   [ ▶ Quyết định khen thưởng (Đang chọn) ]   [ Quyết định kỷ luật ]   [ Phiếu chi/thu tiền mặt ]";
            // 
            // grpDieuKhien
            // 
            this.grpDieuKhien.Controls.Add(this.lblSoQD);
            this.grpDieuKhien.Controls.Add(this.txtSoQD);
            this.grpDieuKhien.Controls.Add(this.lblNhanVien);
            this.grpDieuKhien.Controls.Add(this.cboNhanVien);
            this.grpDieuKhien.Controls.Add(this.lblLoaiQD);
            this.grpDieuKhien.Controls.Add(this.cboLoaiQD);
            this.grpDieuKhien.Controls.Add(this.btnDuyetQD);
            this.grpDieuKhien.Controls.Add(this.lblLyDo);
            this.grpDieuKhien.Controls.Add(this.txtLyDo);
            this.grpDieuKhien.Controls.Add(this.lblSoTien);
            this.grpDieuKhien.Controls.Add(this.txtSoTien);
            this.grpDieuKhien.Controls.Add(this.lblHinhThuc);
            this.grpDieuKhien.Controls.Add(this.cboHinhThuc);
            this.grpDieuKhien.Controls.Add(this.btnXuatPhieu);
            this.grpDieuKhien.Controls.Add(this.btnLamMoi);
            this.grpDieuKhien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDieuKhien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpDieuKhien.Location = new System.Drawing.Point(12, 85);
            this.grpDieuKhien.Name = "grpDieuKhien";
            this.grpDieuKhien.Size = new System.Drawing.Size(960, 130);
            this.grpDieuKhien.TabIndex = 2;
            this.grpDieuKhien.TabStop = false;
            this.grpDieuKhien.Text = "Ban Hành && Quản Lý Quyết Định Khen Thưởng / Kỷ Luật";
            // 
            // lblSoQD
            // 
            this.lblSoQD.AutoSize = true;
            this.lblSoQD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoQD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSoQD.Location = new System.Drawing.Point(15, 28);
            this.lblSoQD.Name = "lblSoQD";
            this.lblSoQD.Size = new System.Drawing.Size(46, 15);
            this.lblSoQD.TabIndex = 0;
            this.lblSoQD.Text = "Số QĐ:";
            // 
            // txtSoQD
            // 
            this.txtSoQD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoQD.Location = new System.Drawing.Point(65, 25);
            this.txtSoQD.Name = "txtSoQD";
            this.txtSoQD.Size = new System.Drawing.Size(120, 23);
            this.txtSoQD.TabIndex = 1;
            this.txtSoQD.Text = "QD-KT-2026-10";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNhanVien.Location = new System.Drawing.Point(200, 28);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(66, 15);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(270, 25);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(220, 23);
            this.cboNhanVien.TabIndex = 3;
            // 
            // lblLoaiQD
            // 
            this.lblLoaiQD.AutoSize = true;
            this.lblLoaiQD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiQD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLoaiQD.Location = new System.Drawing.Point(505, 28);
            this.lblLoaiQD.Name = "lblLoaiQD";
            this.lblLoaiQD.Size = new System.Drawing.Size(55, 15);
            this.lblLoaiQD.TabIndex = 4;
            this.lblLoaiQD.Text = "Loại QĐ:";
            // 
            // cboLoaiQD
            // 
            this.cboLoaiQD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiQD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiQD.FormattingEnabled = true;
            this.cboLoaiQD.Items.AddRange(new object[] {
            "Khen thưởng",
            "Kỷ luật"});
            this.cboLoaiQD.Location = new System.Drawing.Point(565, 25);
            this.cboLoaiQD.Name = "cboLoaiQD";
            this.cboLoaiQD.Size = new System.Drawing.Size(120, 23);
            this.cboLoaiQD.TabIndex = 5;
            // 
            // btnDuyetQD
            // 
            this.btnDuyetQD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnDuyetQD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyetQD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnDuyetQD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDuyetQD.ForeColor = System.Drawing.Color.White;
            this.btnDuyetQD.Location = new System.Drawing.Point(700, 22);
            this.btnDuyetQD.Name = "btnDuyetQD";
            this.btnDuyetQD.Size = new System.Drawing.Size(120, 28);
            this.btnDuyetQD.TabIndex = 6;
            this.btnDuyetQD.Text = "✔ Duyệt QĐ";
            this.btnDuyetQD.UseVisualStyleBackColor = false;
            this.btnDuyetQD.Click += new System.EventHandler(this.BtnDuyetQD_Click);
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLyDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLyDo.Location = new System.Drawing.Point(15, 75);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(95, 15);
            this.lblLyDo.TabIndex = 7;
            this.lblLyDo.Text = "Lý do / Vi phạm:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLyDo.Location = new System.Drawing.Point(115, 72);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(250, 23);
            this.txtLyDo.TabIndex = 8;
            this.txtLyDo.Text = "Vượt 120% định mức mẻ sơn chất lượng cao";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSoTien.Location = new System.Drawing.Point(375, 75);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(78, 15);
            this.lblSoTien.TabIndex = 9;
            this.lblSoTien.Text = "Số tiền (VNĐ):";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoTien.Location = new System.Drawing.Point(455, 72);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(100, 23);
            this.txtSoTien.TabIndex = 10;
            this.txtSoTien.Text = "2000000";
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHinhThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblHinhThuc.Location = new System.Drawing.Point(565, 75);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(65, 15);
            this.lblHinhThuc.TabIndex = 11;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Chuyển Bảng lương",
            "Tiền mặt (Phiếu chi/thu)"});
            this.cboHinhThuc.Location = new System.Drawing.Point(635, 72);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(160, 23);
            this.cboHinhThuc.TabIndex = 12;
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.BackColor = System.Drawing.Color.White;
            this.btnXuatPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatPhieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnXuatPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnXuatPhieu.Location = new System.Drawing.Point(805, 22);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(140, 28);
            this.btnXuatPhieu.TabIndex = 13;
            this.btnXuatPhieu.Text = "📄 Xuất Phiếu Chi/Thu";
            this.btnXuatPhieu.UseVisualStyleBackColor = false;
            this.btnXuatPhieu.Click += new System.EventHandler(this.BtnXuatPhieu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLamMoi.Location = new System.Drawing.Point(805, 68);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 28);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "⟳ Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.AllowUserToAddRows = false;
            this.dgvKhenThuong.AllowUserToDeleteRows = false;
            this.dgvKhenThuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhenThuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhenThuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhenThuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhenThuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhenThuong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhenThuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhenThuong.EnableHeadersVisualStyles = false;
            this.dgvKhenThuong.Location = new System.Drawing.Point(12, 225);
            this.dgvKhenThuong.MultiSelect = false;
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.ReadOnly = true;
            this.dgvKhenThuong.RowHeadersVisible = false;
            this.dgvKhenThuong.RowTemplate.Height = 26;
            this.dgvKhenThuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhenThuong.Size = new System.Drawing.Size(960, 325);
            this.dgvKhenThuong.TabIndex = 3;
            // 
            // FrmKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.dgvKhenThuong);
            this.Controls.Add(this.grpDieuKhien);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKhenThuongKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Khen thưởng & Xử lý Kỷ luật";
            this.Load += new System.EventHandler(this.FrmKhenThuongKyLuat_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.grpDieuKhien.ResumeLayout(false);
            this.grpDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
