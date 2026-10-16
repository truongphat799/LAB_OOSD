namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKhoa, tabXN, tabThuoc, tabNhanSu;

        // Khoa
        private System.Windows.Forms.Label lblMaKhoa, lblTenKhoa, lblViTri, lblTruongKhoa, lblSDTKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa, txtTenKhoa, txtViTriKhoa, txtTruongKhoa, txtSDTKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;

        // Xet Nghiem
        private System.Windows.Forms.Label lblMaXN, lblTenXN, lblLoaiXN, lblGiaXN, lblPhongXN;
        private System.Windows.Forms.TextBox txtMaXN, txtTenXN, txtLoaiXN, txtPhongXN;
        private System.Windows.Forms.NumericUpDown numGiaXN;
        private System.Windows.Forms.Button btnThemXN;
        private System.Windows.Forms.DataGridView dgvDichVuXN;

        // Thuoc
        private System.Windows.Forms.Label lblMaThuoc, lblTenThuoc, lblHoatChat, lblDVT, lblGiaThuoc, lblTonKho, lblCCD, lblPUP;
        private System.Windows.Forms.TextBox txtMaThuoc, txtTenThuoc, txtHoatChat, txtDVT, txtChongChiDinh, txtPhanUngPhu;
        private System.Windows.Forms.NumericUpDown numGiaThuoc, numTonKho;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;

        // Nhan su
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.tabXN = new System.Windows.Forms.TabPage();
            this.tabThuoc = new System.Windows.Forms.TabPage();
            this.tabNhanSu = new System.Windows.Forms.TabPage();

            // Controls Khoa
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtViTriKhoa = new System.Windows.Forms.TextBox();
            this.lblTruongKhoa = new System.Windows.Forms.Label();
            this.txtTruongKhoa = new System.Windows.Forms.TextBox();
            this.lblSDTKhoa = new System.Windows.Forms.Label();
            this.txtSDTKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();

            // Controls XN
            this.lblMaXN = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.lblTenXN = new System.Windows.Forms.Label();
            this.txtTenXN = new System.Windows.Forms.TextBox();
            this.lblLoaiXN = new System.Windows.Forms.Label();
            this.txtLoaiXN = new System.Windows.Forms.TextBox();
            this.lblGiaXN = new System.Windows.Forms.Label();
            this.numGiaXN = new System.Windows.Forms.NumericUpDown();
            this.lblPhongXN = new System.Windows.Forms.Label();
            this.txtPhongXN = new System.Windows.Forms.TextBox();
            this.btnThemXN = new System.Windows.Forms.Button();
            this.dgvDichVuXN = new System.Windows.Forms.DataGridView();

            // Controls Thuoc
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblHoatChat = new System.Windows.Forms.Label();
            this.txtHoatChat = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lblGiaThuoc = new System.Windows.Forms.Label();
            this.numGiaThuoc = new System.Windows.Forms.NumericUpDown();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.numTonKho = new System.Windows.Forms.NumericUpDown();
            this.lblCCD = new System.Windows.Forms.Label();
            this.txtChongChiDinh = new System.Windows.Forms.TextBox();
            this.lblPUP = new System.Windows.Forms.Label();
            this.txtPhanUngPhu = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();

            // Controls Nhan su
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            this.tabXN.SuspendLayout();
            this.tabThuoc.SuspendLayout();
            this.tabNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabKhoa);
            this.tabControl.Controls.Add(this.tabXN);
            this.tabControl.Controls.Add(this.tabThuoc);
            this.tabControl.Controls.Add(this.tabNhanSu);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Size = new System.Drawing.Size(860, 480);

            // Tab 1: Khoa
            this.tabKhoa.Text = "Khoa Điều Trị";
            this.lblMaKhoa.Text = "Mã Khoa:";
            this.lblMaKhoa.Location = new System.Drawing.Point(15, 20);
            this.lblMaKhoa.Size = new System.Drawing.Size(65, 20);
            this.txtMaKhoa.Location = new System.Drawing.Point(85, 17);
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 22);

            this.lblTenKhoa.Text = "Tên Khoa:";
            this.lblTenKhoa.Location = new System.Drawing.Point(200, 20);
            this.lblTenKhoa.Size = new System.Drawing.Size(65, 20);
            this.txtTenKhoa.Location = new System.Drawing.Point(270, 17);
            this.txtTenKhoa.Size = new System.Drawing.Size(180, 22);

            this.lblViTri.Text = "Vị trí:";
            this.lblViTri.Location = new System.Drawing.Point(465, 20);
            this.lblViTri.Size = new System.Drawing.Size(45, 20);
            this.txtViTriKhoa.Location = new System.Drawing.Point(515, 17);
            this.txtViTriKhoa.Size = new System.Drawing.Size(150, 22);

            this.lblTruongKhoa.Text = "Trưởng Khoa:";
            this.lblTruongKhoa.Location = new System.Drawing.Point(15, 55);
            this.lblTruongKhoa.Size = new System.Drawing.Size(80, 20);
            this.txtTruongKhoa.Location = new System.Drawing.Point(100, 52);
            this.txtTruongKhoa.Size = new System.Drawing.Size(180, 22);

            this.lblSDTKhoa.Text = "SĐT:";
            this.lblSDTKhoa.Location = new System.Drawing.Point(300, 55);
            this.lblSDTKhoa.Size = new System.Drawing.Size(40, 20);
            this.txtSDTKhoa.Location = new System.Drawing.Point(345, 52);
            this.txtSDTKhoa.Size = new System.Drawing.Size(120, 22);

            this.btnThemKhoa.Text = "+ Thêm Khoa";
            this.btnThemKhoa.Location = new System.Drawing.Point(500, 50);
            this.btnThemKhoa.Size = new System.Drawing.Size(120, 28);
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);

            this.dgvKhoa.Location = new System.Drawing.Point(15, 90);
            this.dgvKhoa.Size = new System.Drawing.Size(820, 340);
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabKhoa.Controls.Add(this.lblMaKhoa);
            this.tabKhoa.Controls.Add(this.txtMaKhoa);
            this.tabKhoa.Controls.Add(this.lblTenKhoa);
            this.tabKhoa.Controls.Add(this.txtTenKhoa);
            this.tabKhoa.Controls.Add(this.lblViTri);
            this.tabKhoa.Controls.Add(this.txtViTriKhoa);
            this.tabKhoa.Controls.Add(this.lblTruongKhoa);
            this.tabKhoa.Controls.Add(this.txtTruongKhoa);
            this.tabKhoa.Controls.Add(this.lblSDTKhoa);
            this.tabKhoa.Controls.Add(this.txtSDTKhoa);
            this.tabKhoa.Controls.Add(this.btnThemKhoa);
            this.tabKhoa.Controls.Add(this.dgvKhoa);

            // Tab 2: XN
            this.tabXN.Text = "Dịch Vụ Xét Nghiệm";
            this.lblMaXN.Text = "Mã XN:";
            this.lblMaXN.Location = new System.Drawing.Point(15, 20);
            this.lblMaXN.Size = new System.Drawing.Size(55, 20);
            this.txtMaXN.Location = new System.Drawing.Point(75, 17);
            this.txtMaXN.Size = new System.Drawing.Size(80, 22);

            this.lblTenXN.Text = "Tên Dịch Vụ:";
            this.lblTenXN.Location = new System.Drawing.Point(170, 20);
            this.lblTenXN.Size = new System.Drawing.Size(80, 20);
            this.txtTenXN.Location = new System.Drawing.Point(255, 17);
            this.txtTenXN.Size = new System.Drawing.Size(220, 22);

            this.lblLoaiXN.Text = "Loại:";
            this.lblLoaiXN.Location = new System.Drawing.Point(490, 20);
            this.lblLoaiXN.Size = new System.Drawing.Size(40, 20);
            this.txtLoaiXN.Location = new System.Drawing.Point(535, 17);
            this.txtLoaiXN.Size = new System.Drawing.Size(120, 22);

            this.lblGiaXN.Text = "Đơn Giá:";
            this.lblGiaXN.Location = new System.Drawing.Point(15, 55);
            this.lblGiaXN.Size = new System.Drawing.Size(60, 20);
            this.numGiaXN.Location = new System.Drawing.Point(80, 52);
            this.numGiaXN.Size = new System.Drawing.Size(120, 22);
            this.numGiaXN.Maximum = 100000000;

            this.lblPhongXN.Text = "Phòng:";
            this.lblPhongXN.Location = new System.Drawing.Point(220, 55);
            this.lblPhongXN.Size = new System.Drawing.Size(50, 20);
            this.txtPhongXN.Location = new System.Drawing.Point(275, 52);
            this.txtPhongXN.Size = new System.Drawing.Size(180, 22);

            this.btnThemXN.Text = "+ Thêm Dịch Vụ XN";
            this.btnThemXN.Location = new System.Drawing.Point(480, 50);
            this.btnThemXN.Size = new System.Drawing.Size(150, 28);
            this.btnThemXN.Click += new System.EventHandler(this.btnThemXN_Click);

            this.dgvDichVuXN.Location = new System.Drawing.Point(15, 90);
            this.dgvDichVuXN.Size = new System.Drawing.Size(820, 340);
            this.dgvDichVuXN.ReadOnly = true;
            this.dgvDichVuXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabXN.Controls.Add(this.lblMaXN);
            this.tabXN.Controls.Add(this.txtMaXN);
            this.tabXN.Controls.Add(this.lblTenXN);
            this.tabXN.Controls.Add(this.txtTenXN);
            this.tabXN.Controls.Add(this.lblLoaiXN);
            this.tabXN.Controls.Add(this.txtLoaiXN);
            this.tabXN.Controls.Add(this.lblGiaXN);
            this.tabXN.Controls.Add(this.numGiaXN);
            this.tabXN.Controls.Add(this.lblPhongXN);
            this.tabXN.Controls.Add(this.txtPhongXN);
            this.tabXN.Controls.Add(this.btnThemXN);
            this.tabXN.Controls.Add(this.dgvDichVuXN);

            // Tab 3: Thuoc
            this.tabThuoc.Text = "Danh Mục Thuốc";
            this.lblMaThuoc.Text = "Mã:";
            this.lblMaThuoc.Location = new System.Drawing.Point(15, 20);
            this.lblMaThuoc.Size = new System.Drawing.Size(35, 20);
            this.txtMaThuoc.Location = new System.Drawing.Point(55, 17);
            this.txtMaThuoc.Size = new System.Drawing.Size(70, 22);

            this.lblTenThuoc.Text = "Tên Thuốc:";
            this.lblTenThuoc.Location = new System.Drawing.Point(135, 20);
            this.lblTenThuoc.Size = new System.Drawing.Size(70, 20);
            this.txtTenThuoc.Location = new System.Drawing.Point(210, 17);
            this.txtTenThuoc.Size = new System.Drawing.Size(180, 22);

            this.lblHoatChat.Text = "Hoạt chất:";
            this.lblHoatChat.Location = new System.Drawing.Point(400, 20);
            this.lblHoatChat.Size = new System.Drawing.Size(65, 20);
            this.txtHoatChat.Location = new System.Drawing.Point(470, 17);
            this.txtHoatChat.Size = new System.Drawing.Size(140, 22);

            this.lblDVT.Text = "ĐVT:";
            this.lblDVT.Location = new System.Drawing.Point(620, 20);
            this.lblDVT.Size = new System.Drawing.Size(40, 20);
            this.txtDVT.Location = new System.Drawing.Point(665, 17);
            this.txtDVT.Size = new System.Drawing.Size(60, 22);
            this.txtDVT.Text = "Viên";

            this.lblGiaThuoc.Text = "Đơn Giá:";
            this.lblGiaThuoc.Location = new System.Drawing.Point(15, 55);
            this.lblGiaThuoc.Size = new System.Drawing.Size(55, 20);
            this.numGiaThuoc.Location = new System.Drawing.Point(75, 52);
            this.numGiaThuoc.Size = new System.Drawing.Size(90, 22);
            this.numGiaThuoc.Maximum = 100000000;

            this.lblTonKho.Text = "Tồn kho:";
            this.lblTonKho.Location = new System.Drawing.Point(175, 55);
            this.lblTonKho.Size = new System.Drawing.Size(55, 20);
            this.numTonKho.Location = new System.Drawing.Point(235, 52);
            this.numTonKho.Size = new System.Drawing.Size(70, 22);
            this.numTonKho.Maximum = 100000;
            this.numTonKho.Value = 100;

            this.lblCCD.Text = "Chống CĐ:";
            this.lblCCD.Location = new System.Drawing.Point(315, 55);
            this.lblCCD.Size = new System.Drawing.Size(65, 20);
            this.txtChongChiDinh.Location = new System.Drawing.Point(385, 52);
            this.txtChongChiDinh.Size = new System.Drawing.Size(180, 22);

            this.btnThemThuoc.Text = "+ Thêm Thuốc";
            this.btnThemThuoc.Location = new System.Drawing.Point(580, 50);
            this.btnThemThuoc.Size = new System.Drawing.Size(120, 28);
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            this.dgvThuoc.Location = new System.Drawing.Point(15, 90);
            this.dgvThuoc.Size = new System.Drawing.Size(820, 340);
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabThuoc.Controls.Add(this.lblMaThuoc);
            this.tabThuoc.Controls.Add(this.txtMaThuoc);
            this.tabThuoc.Controls.Add(this.lblTenThuoc);
            this.tabThuoc.Controls.Add(this.txtTenThuoc);
            this.tabThuoc.Controls.Add(this.lblHoatChat);
            this.tabThuoc.Controls.Add(this.txtHoatChat);
            this.tabThuoc.Controls.Add(this.lblDVT);
            this.tabThuoc.Controls.Add(this.txtDVT);
            this.tabThuoc.Controls.Add(this.lblGiaThuoc);
            this.tabThuoc.Controls.Add(this.numGiaThuoc);
            this.tabThuoc.Controls.Add(this.lblTonKho);
            this.tabThuoc.Controls.Add(this.numTonKho);
            this.tabThuoc.Controls.Add(this.lblCCD);
            this.tabThuoc.Controls.Add(this.txtChongChiDinh);
            this.tabThuoc.Controls.Add(this.btnThemThuoc);
            this.tabThuoc.Controls.Add(this.dgvThuoc);

            // Tab 4: Nhan su
            this.tabNhanSu.Text = "Bác Sĩ & Nhân Viên Y Tế";
            this.dgvNguoiDung.Location = new System.Drawing.Point(15, 15);
            this.dgvNguoiDung.Size = new System.Drawing.Size(820, 415);
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabNhanSu.Controls.Add(this.dgvNguoiDung);

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(770, 500);
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục Y Tế & Dược Phẩm";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);

            this.tabControl.ResumeLayout(false);
            this.tabKhoa.ResumeLayout(false);
            this.tabKhoa.PerformLayout();
            this.tabXN.ResumeLayout(false);
            this.tabXN.PerformLayout();
            this.tabThuoc.ResumeLayout(false);
            this.tabThuoc.PerformLayout();
            this.tabNhanSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
