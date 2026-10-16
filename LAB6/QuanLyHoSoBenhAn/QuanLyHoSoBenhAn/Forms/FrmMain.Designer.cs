namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnXuatVien;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnXuatVien = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTieuDe.Location = new System.Drawing.Point(12, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(760, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BỆNH VIỆN ĐA KHOA QUỐC TẾ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhuDe.Location = new System.Drawing.Point(12, 55);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(760, 25);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN ĐIỆN TỬ & CHĂM SÓC ĐỊNH KỲ";
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BackColor = System.Drawing.Color.White;
            this.btnTiepNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(180, 100);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(420, 50);
            this.btnTiepNhan.TabIndex = 2;
            this.btnTiepNhan.Text = "Tiếp Nhận Bệnh Nhân, Thu Lệ Phí Năm & Cấp HSBA";
            this.btnTiepNhan.UseVisualStyleBackColor = false;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.BackColor = System.Drawing.Color.White;
            this.btnKhamBenh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhamBenh.Location = new System.Drawing.Point(180, 160);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(420, 50);
            this.btnKhamBenh.TabIndex = 3;
            this.btnKhamBenh.Text = "Khám Bệnh, Xét Nghiệm & Lập Toa Thuốc";
            this.btnKhamBenh.UseVisualStyleBackColor = false;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnXuatVien
            // 
            this.btnXuatVien.BackColor = System.Drawing.Color.White;
            this.btnXuatVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatVien.Location = new System.Drawing.Point(180, 220);
            this.btnXuatVien.Name = "btnXuatVien";
            this.btnXuatVien.Size = new System.Drawing.Size(420, 50);
            this.btnXuatVien.TabIndex = 4;
            this.btnXuatVien.Text = "Thanh Toán Viện Phí & CSKH Khóa Hồ Sơ";
            this.btnXuatVien.UseVisualStyleBackColor = false;
            this.btnXuatVien.Click += new System.EventHandler(this.btnXuatVien_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDanhMuc.Location = new System.Drawing.Point(180, 280);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(420, 45);
            this.btnDanhMuc.TabIndex = 5;
            this.btnDanhMuc.Text = "Quản Lý Danh Mục Y Tế & Dược Phẩm";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.Location = new System.Drawing.Point(180, 335);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(420, 45);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Báo Cáo Thống Kê Viện Phí & Khám Bệnh";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.Location = new System.Drawing.Point(290, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát Hệ Thống";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblPhuDe);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.btnKhamBenh);
            this.Controls.Add(this.btnXuatVien);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Hồ Sơ Bệnh Án - Bệnh Viện Đa Khoa Quốc Tế";
            this.ResumeLayout(false);

        }
    }
}
