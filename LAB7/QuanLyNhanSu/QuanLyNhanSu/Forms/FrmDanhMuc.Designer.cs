namespace QuanLyNhanSu.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label lblTabs;

        private System.Windows.Forms.GroupBox grpDieuKhien;
        private System.Windows.Forms.Label lblMaDonVi;
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.Label lblTenDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Label lblPCDocHai;
        private System.Windows.Forms.TextBox txtPCDocHai;

        private System.Windows.Forms.Label lblTruongDonVi;
        private System.Windows.Forms.TextBox txtTruongDonVi;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvDanhMuc;

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
            this.lblMaDonVi = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.lblTenDonVi = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.lblPCDocHai = new System.Windows.Forms.Label();
            this.txtPCDocHai = new System.Windows.Forms.TextBox();
            this.lblTruongDonVi = new System.Windows.Forms.Label();
            this.txtTruongDonVi = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.grpDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
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
            this.lblWindowTitle.Size = new System.Drawing.Size(465, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "📁 Quản lý Danh mục Cơ sở & Định mức Phụ cấp độc hại";
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
            this.lblTabs.Size = new System.Drawing.Size(760, 17);
            this.lblTabs.TabIndex = 0;
            this.lblTabs.Text = "[ ▶ Phòng ban & Phân xưởng (Đang chọn) ]   [ Chức vụ & Định biên ]   [ Bậc lương công ty ]   [ Quy định Phụ cấp độc hại hóa chất ]";
            // 
            // grpDieuKhien
            // 
            this.grpDieuKhien.Controls.Add(this.lblMaDonVi);
            this.grpDieuKhien.Controls.Add(this.txtMaDonVi);
            this.grpDieuKhien.Controls.Add(this.lblTenDonVi);
            this.grpDieuKhien.Controls.Add(this.txtTenDonVi);
            this.grpDieuKhien.Controls.Add(this.lblPCDocHai);
            this.grpDieuKhien.Controls.Add(this.txtPCDocHai);
            this.grpDieuKhien.Controls.Add(this.lblTruongDonVi);
            this.grpDieuKhien.Controls.Add(this.txtTruongDonVi);
            this.grpDieuKhien.Controls.Add(this.lblDiaDiem);
            this.grpDieuKhien.Controls.Add(this.txtDiaDiem);
            this.grpDieuKhien.Controls.Add(this.lblDienThoai);
            this.grpDieuKhien.Controls.Add(this.txtDienThoai);
            this.grpDieuKhien.Controls.Add(this.btnLuu);
            this.grpDieuKhien.Controls.Add(this.btnLamMoi);
            this.grpDieuKhien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDieuKhien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpDieuKhien.Location = new System.Drawing.Point(12, 85);
            this.grpDieuKhien.Name = "grpDieuKhien";
            this.grpDieuKhien.Size = new System.Drawing.Size(960, 130);
            this.grpDieuKhien.TabIndex = 2;
            this.grpDieuKhien.TabStop = false;
            this.grpDieuKhien.Text = "Thông Tin Phân Xưởng / Phòng Ban && Định Mức Phụ Cấp";
            // 
            // lblMaDonVi
            // 
            this.lblMaDonVi.AutoSize = true;
            this.lblMaDonVi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMaDonVi.Location = new System.Drawing.Point(15, 28);
            this.lblMaDonVi.Name = "lblMaDonVi";
            this.lblMaDonVi.Size = new System.Drawing.Size(68, 15);
            this.lblMaDonVi.TabIndex = 0;
            this.lblMaDonVi.Text = "Mã Đơn Vị:";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDonVi.Location = new System.Drawing.Point(90, 25);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Size = new System.Drawing.Size(90, 23);
            this.txtMaDonVi.TabIndex = 1;
            this.txtMaDonVi.Text = "PX01";
            // 
            // lblTenDonVi
            // 
            this.lblTenDonVi.AutoSize = true;
            this.lblTenDonVi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTenDonVi.Location = new System.Drawing.Point(190, 28);
            this.lblTenDonVi.Name = "lblTenDonVi";
            this.lblTenDonVi.Size = new System.Drawing.Size(126, 15);
            this.lblTenDonVi.TabIndex = 2;
            this.lblTenDonVi.Text = "Tên Phân xưởng / Ban:";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDonVi.Location = new System.Drawing.Point(320, 25);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(240, 23);
            this.txtTenDonVi.TabIndex = 3;
            this.txtTenDonVi.Text = "Phân xưởng Pha màu sơn";
            // 
            // lblPCDocHai
            // 
            this.lblPCDocHai.AutoSize = true;
            this.lblPCDocHai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPCDocHai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPCDocHai.Location = new System.Drawing.Point(575, 28);
            this.lblPCDocHai.Name = "lblPCDocHai";
            this.lblPCDocHai.Size = new System.Drawing.Size(73, 15);
            this.lblPCDocHai.TabIndex = 4;
            this.lblPCDocHai.Text = "PC Độc hại:";
            // 
            // txtPCDocHai
            // 
            this.txtPCDocHai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPCDocHai.Location = new System.Drawing.Point(655, 25);
            this.txtPCDocHai.Name = "txtPCDocHai";
            this.txtPCDocHai.Size = new System.Drawing.Size(120, 23);
            this.txtPCDocHai.TabIndex = 5;
            this.txtPCDocHai.Text = "1800000";
            this.txtPCDocHai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTruongDonVi
            // 
            this.lblTruongDonVi.AutoSize = true;
            this.lblTruongDonVi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTruongDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTruongDonVi.Location = new System.Drawing.Point(15, 75);
            this.lblTruongDonVi.Name = "lblTruongDonVi";
            this.lblTruongDonVi.Size = new System.Drawing.Size(96, 15);
            this.lblTruongDonVi.TabIndex = 6;
            this.lblTruongDonVi.Text = "Quản đốc / TP:";
            // 
            // txtTruongDonVi
            // 
            this.txtTruongDonVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTruongDonVi.Location = new System.Drawing.Point(115, 72);
            this.txtTruongDonVi.Name = "txtTruongDonVi";
            this.txtTruongDonVi.Size = new System.Drawing.Size(150, 23);
            this.txtTruongDonVi.TabIndex = 7;
            this.txtTruongDonVi.Text = "KS. Trần Văn Thắng";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDiaDiem.Location = new System.Drawing.Point(275, 75);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(59, 15);
            this.lblDiaDiem.TabIndex = 8;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaDiem.Location = new System.Drawing.Point(340, 72);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(220, 23);
            this.txtDiaDiem.TabIndex = 9;
            this.txtDiaDiem.Text = "Khu B - Dãy xưởng pha chế dung môi";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDienThoai.Location = new System.Drawing.Point(575, 75);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(43, 15);
            this.lblDienThoai.TabIndex = 10;
            this.lblDienThoai.Text = "Số ĐT:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDienThoai.Location = new System.Drawing.Point(625, 72);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 23);
            this.txtDienThoai.TabIndex = 11;
            this.txtDienThoai.Text = "028.3831.01";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(795, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 32);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "💾 Thêm / Lưu Đơn Vị";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLamMoi.Location = new System.Drawing.Point(795, 68);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 32);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "⟳ Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMuc.EnableHeadersVisualStyles = false;
            this.dgvDanhMuc.Location = new System.Drawing.Point(12, 225);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowTemplate.Height = 26;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(960, 325);
            this.dgvDanhMuc.TabIndex = 3;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhMuc_CellClick);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.grpDieuKhien);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Danh mục Cơ sở & Định mức Phụ cấp độc hại";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.grpDieuKhien.ResumeLayout(false);
            this.grpDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
