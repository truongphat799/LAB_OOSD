namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnNuocGiaiKhat;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnPhieuHen;
        private System.Windows.Forms.Button btnPhieuGhiNo;
        private System.Windows.Forms.Button btnThongKe;
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnNuocGiaiKhat = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnPhieuHen = new System.Windows.Forms.Button();
            this.btnPhieuGhiNo = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(780, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CỬA HÀNG KINH DOANH NƯỚC GIẢI KHÁT PHÁT ĐẠT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblPhuDe.Location = new System.Drawing.Point(12, 55);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(780, 25);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG, ĐẶT HÀNG & THEO DÕI CÔNG NỢ";
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnDanhMuc.Location = new System.Drawing.Point(70, 95);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(310, 55);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Text = "Quản Lý Danh Mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnNuocGiaiKhat
            // 
            this.btnNuocGiaiKhat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuocGiaiKhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnNuocGiaiKhat.Location = new System.Drawing.Point(420, 95);
            this.btnNuocGiaiKhat.Name = "btnNuocGiaiKhat";
            this.btnNuocGiaiKhat.Size = new System.Drawing.Size(310, 55);
            this.btnNuocGiaiKhat.TabIndex = 3;
            this.btnNuocGiaiKhat.Text = "Quản Lý Nước Giải Khát & Tồn Kho";
            this.btnNuocGiaiKhat.UseVisualStyleBackColor = true;
            this.btnNuocGiaiKhat.Click += new System.EventHandler(this.btnNuocGiaiKhat_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnKhachHang.Location = new System.Drawing.Point(70, 165);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(310, 55);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = "Quản Lý Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnNhapHang.Location = new System.Drawing.Point(420, 165);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(310, 55);
            this.btnNhapHang.TabIndex = 5;
            this.btnNhapHang.Text = "Quản Lý Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBanHang.Location = new System.Drawing.Point(70, 235);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(310, 55);
            this.btnBanHang.TabIndex = 6;
            this.btnBanHang.Text = "Tiếp Nhận Mua Hàng Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnPhieuHen
            // 
            this.btnPhieuHen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuHen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnPhieuHen.Location = new System.Drawing.Point(420, 235);
            this.btnPhieuHen.Name = "btnPhieuHen";
            this.btnPhieuHen.Size = new System.Drawing.Size(310, 55);
            this.btnPhieuHen.TabIndex = 7;
            this.btnPhieuHen.Text = "Quản Lý Phiếu Hẹn Giao Hàng";
            this.btnPhieuHen.UseVisualStyleBackColor = true;
            this.btnPhieuHen.Click += new System.EventHandler(this.btnPhieuHen_Click);
            // 
            // btnPhieuGhiNo
            // 
            this.btnPhieuGhiNo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuGhiNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnPhieuGhiNo.Location = new System.Drawing.Point(70, 305);
            this.btnPhieuGhiNo.Name = "btnPhieuGhiNo";
            this.btnPhieuGhiNo.Size = new System.Drawing.Size(310, 55);
            this.btnPhieuGhiNo.TabIndex = 8;
            this.btnPhieuGhiNo.Text = "Quản Lý Công Nợ";
            this.btnPhieuGhiNo.UseVisualStyleBackColor = true;
            this.btnPhieuGhiNo.Click += new System.EventHandler(this.btnPhieuGhiNo_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnThongKe.Location = new System.Drawing.Point(420, 305);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(310, 55);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Báo Cáo Thống Kê Doanh Thu";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(260, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(280, 48);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát Hệ Thống";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 473);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnPhieuGhiNo);
            this.Controls.Add(this.btnPhieuHen);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNuocGiaiKhat);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblPhuDe);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Cửa Hàng Nước Giải Khát";
            this.ResumeLayout(false);

        }
    }
}
