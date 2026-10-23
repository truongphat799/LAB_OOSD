namespace QuanLyNhanSu.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;

        private System.Windows.Forms.Panel pnlActor;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblChonActor;
        private System.Windows.Forms.ComboBox cboChonActor;

        private System.Windows.Forms.Button btnNavTuyenDung;
        private System.Windows.Forms.Button btnNavChamCong;
        private System.Windows.Forms.Button btnNavKhenThuong;
        private System.Windows.Forms.Button btnNavTinhLuong;
        private System.Windows.Forms.Button btnNavDanhMuc;
        private System.Windows.Forms.Button btnNavThongKe;
        private System.Windows.Forms.Button btnThoat;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.pnlActor = new System.Windows.Forms.Panel();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblChonActor = new System.Windows.Forms.Label();
            this.cboChonActor = new System.Windows.Forms.ComboBox();
            this.btnNavTuyenDung = new System.Windows.Forms.Button();
            this.btnNavChamCong = new System.Windows.Forms.Button();
            this.btnNavKhenThuong = new System.Windows.Forms.Button();
            this.btnNavTinhLuong = new System.Windows.Forms.Button();
            this.btnNavDanhMuc = new System.Windows.Forms.Button();
            this.btnNavThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlActor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblPhuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(818, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblPhuDe.Location = new System.Drawing.Point(0, 45);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(818, 33);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "CÔNG TY CỔ PHẦN SƠN ĐÔNG Á";
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActor
            // 
            this.pnlActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlActor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActor.Controls.Add(this.lblNguoiDung);
            this.pnlActor.Controls.Add(this.lblVaiTro);
            this.pnlActor.Controls.Add(this.lblThoiGian);
            this.pnlActor.Controls.Add(this.lblChonActor);
            this.pnlActor.Controls.Add(this.cboChonActor);
            this.pnlActor.Location = new System.Drawing.Point(30, 92);
            this.pnlActor.Name = "pnlActor";
            this.pnlActor.Size = new System.Drawing.Size(760, 68);
            this.pnlActor.TabIndex = 1;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblNguoiDung.Location = new System.Drawing.Point(12, 10);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(250, 17);
            this.lblNguoiDung.TabIndex = 0;
            this.lblNguoiDung.Text = "Người dùng: Trương Gia Phát (Giám Đốc)";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblVaiTro.Location = new System.Drawing.Point(12, 38);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(155, 15);
            this.lblVaiTro.TabIndex = 1;
            this.lblVaiTro.Text = "Vai trò hiện tại: GIAM_DOC";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblThoiGian.Location = new System.Drawing.Point(230, 38);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(107, 15);
            this.lblThoiGian.TabIndex = 2;
            this.lblThoiGian.Text = "Ngày: 23/10/2026";
            // 
            // lblChonActor
            // 
            this.lblChonActor.AutoSize = true;
            this.lblChonActor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChonActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.lblChonActor.Location = new System.Drawing.Point(390, 10);
            this.lblChonActor.Name = "lblChonActor";
            this.lblChonActor.Size = new System.Drawing.Size(130, 17);
            this.lblChonActor.TabIndex = 3;
            this.lblChonActor.Text = "Chuyển Đổi Actor:";
            // 
            // cboChonActor
            // 
            this.cboChonActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonActor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChonActor.FormattingEnabled = true;
            this.cboChonActor.Items.AddRange(new object[] {
            "Trưởng phòng / Quản đốc (Trần Văn Thắng)",
            "Nhân sự HR (Phạm Hoàng Nam)",
            "Ban Chấm Công (Ban Chấm Công)",
            "Kế toán trưởng (Lê Thị Hồng Vân)",
            "Tổng Giám Đốc (Trương Gia Phát)"});
            this.cboChonActor.Location = new System.Drawing.Point(393, 33);
            this.cboChonActor.Name = "cboChonActor";
            this.cboChonActor.Size = new System.Drawing.Size(350, 23);
            this.cboChonActor.TabIndex = 4;
            this.cboChonActor.SelectedIndexChanged += new System.EventHandler(this.CboChonActor_SelectedIndexChanged);
            // 
            // btnNavTuyenDung
            // 
            this.btnNavTuyenDung.BackColor = System.Drawing.Color.White;
            this.btnNavTuyenDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTuyenDung.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavTuyenDung.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavTuyenDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavTuyenDung.Location = new System.Drawing.Point(60, 175);
            this.btnNavTuyenDung.Name = "btnNavTuyenDung";
            this.btnNavTuyenDung.Size = new System.Drawing.Size(330, 60);
            this.btnNavTuyenDung.TabIndex = 2;
            this.btnNavTuyenDung.Text = "Tuyển dụng && Hợp đồng lao động";
            this.btnNavTuyenDung.UseVisualStyleBackColor = false;
            this.btnNavTuyenDung.Click += new System.EventHandler(this.BtnNavTuyenDung_Click);
            // 
            // btnNavChamCong
            // 
            this.btnNavChamCong.BackColor = System.Drawing.Color.White;
            this.btnNavChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavChamCong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavChamCong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavChamCong.Location = new System.Drawing.Point(430, 175);
            this.btnNavChamCong.Name = "btnNavChamCong";
            this.btnNavChamCong.Size = new System.Drawing.Size(330, 60);
            this.btnNavChamCong.TabIndex = 3;
            this.btnNavChamCong.Text = "Kế hoạch làm việc && Chấm công";
            this.btnNavChamCong.UseVisualStyleBackColor = false;
            this.btnNavChamCong.Click += new System.EventHandler(this.BtnNavChamCong_Click);
            // 
            // btnNavKhenThuong
            // 
            this.btnNavKhenThuong.BackColor = System.Drawing.Color.White;
            this.btnNavKhenThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKhenThuong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavKhenThuong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavKhenThuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavKhenThuong.Location = new System.Drawing.Point(60, 250);
            this.btnNavKhenThuong.Name = "btnNavKhenThuong";
            this.btnNavKhenThuong.Size = new System.Drawing.Size(330, 60);
            this.btnNavKhenThuong.TabIndex = 4;
            this.btnNavKhenThuong.Text = "Khen thưởng && Kỷ luật";
            this.btnNavKhenThuong.UseVisualStyleBackColor = false;
            this.btnNavKhenThuong.Click += new System.EventHandler(this.BtnNavKhenThuong_Click);
            // 
            // btnNavTinhLuong
            // 
            this.btnNavTinhLuong.BackColor = System.Drawing.Color.White;
            this.btnNavTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTinhLuong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavTinhLuong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavTinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavTinhLuong.Location = new System.Drawing.Point(430, 250);
            this.btnNavTinhLuong.Name = "btnNavTinhLuong";
            this.btnNavTinhLuong.Size = new System.Drawing.Size(330, 60);
            this.btnNavTinhLuong.TabIndex = 5;
            this.btnNavTinhLuong.Text = "Tính lương && Quyết toán tháng";
            this.btnNavTinhLuong.UseVisualStyleBackColor = false;
            this.btnNavTinhLuong.Click += new System.EventHandler(this.BtnNavTinhLuong_Click);
            // 
            // btnNavDanhMuc
            // 
            this.btnNavDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnNavDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavDanhMuc.Location = new System.Drawing.Point(60, 325);
            this.btnNavDanhMuc.Name = "btnNavDanhMuc";
            this.btnNavDanhMuc.Size = new System.Drawing.Size(330, 60);
            this.btnNavDanhMuc.TabIndex = 6;
            this.btnNavDanhMuc.Text = "Quản lý Danh mục cơ sở";
            this.btnNavDanhMuc.UseVisualStyleBackColor = false;
            this.btnNavDanhMuc.Click += new System.EventHandler(this.BtnNavDanhMuc_Click);
            // 
            // btnNavThongKe
            // 
            this.btnNavThongKe.BackColor = System.Drawing.Color.White;
            this.btnNavThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnNavThongKe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnNavThongKe.Location = new System.Drawing.Point(430, 325);
            this.btnNavThongKe.Name = "btnNavThongKe";
            this.btnNavThongKe.Size = new System.Drawing.Size(330, 60);
            this.btnNavThongKe.TabIndex = 7;
            this.btnNavThongKe.Text = "Báo cáo Thống kê nhân sự";
            this.btnNavThongKe.UseVisualStyleBackColor = false;
            this.btnNavThongKe.Click += new System.EventHandler(this.BtnNavThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnThoat.Location = new System.Drawing.Point(430, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(330, 45);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát hệ thống";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNavThongKe);
            this.Controls.Add(this.btnNavDanhMuc);
            this.Controls.Add(this.btnNavTinhLuong);
            this.Controls.Add(this.btnNavKhenThuong);
            this.Controls.Add(this.btnNavChamCong);
            this.Controls.Add(this.btnNavTuyenDung);
            this.Controls.Add(this.pnlActor);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự - Công ty sơn Đông Á";
            this.pnlHeader.ResumeLayout(false);
            this.pnlActor.ResumeLayout(false);
            this.pnlActor.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
