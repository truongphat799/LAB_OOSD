namespace QuanLyCuaHangEShopping.Forms
{
    partial class FrmDatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.ComboBox cboLoaiThe;
        private System.Windows.Forms.TextBox txtTenNguoiNhan;
        private System.Windows.Forms.TextBox txtDiaChiNhan;
        private System.Windows.Forms.TextBox txtSDTNhan;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.TextBox txtChuThe;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label lblTienHang;
        private System.Windows.Forms.Label lblPhiShip;
        private System.Windows.Forms.Label lblTongTriGia;
        private System.Windows.Forms.Button btnXacNhanDatHang;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.cboLoaiThe = new System.Windows.Forms.ComboBox();
            this.txtTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtDiaChiNhan = new System.Windows.Forms.TextBox();
            this.txtSDTNhan = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.txtChuThe = new System.Windows.Forms.TextBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblTienHang = new System.Windows.Forms.Label();
            this.lblPhiShip = new System.Windows.Forms.Label();
            this.lblTongTriGia = new System.Windows.Forms.Label();
            this.btnXacNhanDatHang = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 12);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(380, 180);
            this.dgvSanPham.TabIndex = 0;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeight = 29;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 235);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.Size = new System.Drawing.Size(380, 180);
            this.dgvGioHang.TabIndex = 4;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeight = 29;
            this.dgvDonHang.Location = new System.Drawing.Point(12, 430);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.Size = new System.Drawing.Size(560, 200);
            this.dgvDonHang.TabIndex = 22;
            this.dgvDonHang.SelectionChanged += new System.EventHandler(this.dgvDonHang_SelectionChanged);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeight = 29;
            this.dgvChiTiet.Location = new System.Drawing.Point(580, 430);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.Size = new System.Drawing.Size(320, 200);
            this.dgvChiTiet.TabIndex = 23;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(12, 202);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(70, 22);
            this.numSoLuong.TabIndex = 1;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Location = new System.Drawing.Point(90, 200);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(140, 28);
            this.btnThemVaoGio.TabIndex = 2;
            this.btnThemVaoGio.Text = "+ Thêm vào giỏ";
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(240, 200);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(120, 28);
            this.btnXoaKhoiGio.TabIndex = 3;
            this.btnXoaKhoiGio.Text = "- Xóa khỏi giỏ";
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            // 
            // cboKhach
            // 
            this.cboKhach.Location = new System.Drawing.Point(410, 30);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(250, 24);
            this.cboKhach.TabIndex = 5;
            // 
            // cboLoaiPhieu
            // 
            this.cboLoaiPhieu.Location = new System.Drawing.Point(410, 230);
            this.cboLoaiPhieu.Name = "cboLoaiPhieu";
            this.cboLoaiPhieu.Size = new System.Drawing.Size(250, 24);
            this.cboLoaiPhieu.TabIndex = 9;
            this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhieu_SelectedIndexChanged);
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Location = new System.Drawing.Point(410, 280);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(250, 24);
            this.cboKhuVuc.TabIndex = 10;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // cboLoaiThe
            // 
            this.cboLoaiThe.Location = new System.Drawing.Point(680, 30);
            this.cboLoaiThe.Name = "cboLoaiThe";
            this.cboLoaiThe.Size = new System.Drawing.Size(220, 24);
            this.cboLoaiThe.TabIndex = 11;
            // 
            // txtTenNguoiNhan
            // 
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(410, 80);
            this.txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            this.txtTenNguoiNhan.Size = new System.Drawing.Size(250, 22);
            this.txtTenNguoiNhan.TabIndex = 6;
            // 
            // txtDiaChiNhan
            // 
            this.txtDiaChiNhan.Location = new System.Drawing.Point(410, 130);
            this.txtDiaChiNhan.Name = "txtDiaChiNhan";
            this.txtDiaChiNhan.Size = new System.Drawing.Size(250, 22);
            this.txtDiaChiNhan.TabIndex = 7;
            // 
            // txtSDTNhan
            // 
            this.txtSDTNhan.Location = new System.Drawing.Point(410, 180);
            this.txtSDTNhan.Name = "txtSDTNhan";
            this.txtSDTNhan.Size = new System.Drawing.Size(250, 22);
            this.txtSDTNhan.TabIndex = 8;
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(680, 80);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(220, 22);
            this.txtSoThe.TabIndex = 12;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(680, 130);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(100, 22);
            this.txtExpDate.TabIndex = 13;
            // 
            // txtCSV
            // 
            this.txtCSV.Location = new System.Drawing.Point(800, 130);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(100, 22);
            this.txtCSV.TabIndex = 14;
            // 
            // txtChuThe
            // 
            this.txtChuThe.Location = new System.Drawing.Point(680, 180);
            this.txtChuThe.Name = "txtChuThe";
            this.txtChuThe.Size = new System.Drawing.Size(220, 22);
            this.txtChuThe.TabIndex = 15;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(680, 230);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(220, 22);
            this.txtMaDon.TabIndex = 16;
            // 
            // lblTienHang
            // 
            this.lblTienHang.Location = new System.Drawing.Point(410, 330);
            this.lblTienHang.Name = "lblTienHang";
            this.lblTienHang.Size = new System.Drawing.Size(250, 20);
            this.lblTienHang.TabIndex = 17;
            this.lblTienHang.Text = "Tiền hàng: 0 đ";
            // 
            // lblPhiShip
            // 
            this.lblPhiShip.Location = new System.Drawing.Point(410, 360);
            this.lblPhiShip.Name = "lblPhiShip";
            this.lblPhiShip.Size = new System.Drawing.Size(250, 20);
            this.lblPhiShip.TabIndex = 18;
            this.lblPhiShip.Text = "Cước giao hàng: 0 đ";
            // 
            // lblTongTriGia
            // 
            this.lblTongTriGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTriGia.ForeColor = System.Drawing.Color.Black;
            this.lblTongTriGia.Location = new System.Drawing.Point(410, 390);
            this.lblTongTriGia.Name = "lblTongTriGia";
            this.lblTongTriGia.Size = new System.Drawing.Size(300, 25);
            this.lblTongTriGia.TabIndex = 19;
            this.lblTongTriGia.Text = "TỔNG CỘNG: 0 đ";
            // 
            // btnXacNhanDatHang
            // 
            this.btnXacNhanDatHang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXacNhanDatHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhanDatHang.Location = new System.Drawing.Point(680, 280);
            this.btnXacNhanDatHang.Name = "btnXacNhanDatHang";
            this.btnXacNhanDatHang.Size = new System.Drawing.Size(220, 50);
            this.btnXacNhanDatHang.TabIndex = 20;
            this.btnXacNhanDatHang.Text = "XÁC NHẬN ĐẶT HÀNG";
            this.btnXacNhanDatHang.UseVisualStyleBackColor = false;
            this.btnXacNhanDatHang.Click += new System.EventHandler(this.btnXacNhanDatHang_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(800, 385);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDatHang
            // 
            this.ClientSize = new System.Drawing.Size(920, 645);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.btnXoaKhoiGio);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.cboKhach);
            this.Controls.Add(this.txtTenNguoiNhan);
            this.Controls.Add(this.txtDiaChiNhan);
            this.Controls.Add(this.txtSDTNhan);
            this.Controls.Add(this.cboLoaiPhieu);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.cboLoaiThe);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtCSV);
            this.Controls.Add(this.txtChuThe);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.lblTienHang);
            this.Controls.Add(this.lblPhiShip);
            this.Controls.Add(this.lblTongTriGia);
            this.Controls.Add(this.btnXacNhanDatHang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.dgvChiTiet);
            this.Name = "FrmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shopping - Đặt hàng và Thanh toán trực tuyến";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}