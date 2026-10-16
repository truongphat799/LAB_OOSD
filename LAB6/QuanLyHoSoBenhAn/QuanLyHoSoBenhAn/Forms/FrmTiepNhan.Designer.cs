namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmTiepNhan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaBN, lblHoTen, lblNgaySinh, lblGioiTinh, lblSDT, lblDiaChi, lblAnh, lblLePhi, lblNam, lblTSB, lblTSDU;
        private System.Windows.Forms.TextBox txtMaBN, txtHoTen, txtSDT, txtDiaChi, txtAnh3x4, txtTienSuBenh, txtTienSuDiUng;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.NumericUpDown numLePhi, numNamApDung;
        private System.Windows.Forms.Button btnChupAnh, btnDangKy;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem, btnLamMoi, btnDong;
        private System.Windows.Forms.DataGridView dgvBenhNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh3x4 = new System.Windows.Forms.TextBox();
            this.btnChupAnh = new System.Windows.Forms.Button();
            this.lblLePhi = new System.Windows.Forms.Label();
            this.numLePhi = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.numNamApDung = new System.Windows.Forms.NumericUpDown();
            this.lblTSB = new System.Windows.Forms.Label();
            this.txtTienSuBenh = new System.Windows.Forms.TextBox();
            this.lblTSDU = new System.Windows.Forms.Label();
            this.txtTienSuDiUng = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();

            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLePhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamApDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();

            // grpThongTin
            this.grpThongTin.Text = "Thông Tin Đăng Ký Khám & Hồ Sơ Bệnh Án";
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Size = new System.Drawing.Size(960, 215);

            this.lblMaBN.Text = "Mã BN:";
            this.lblMaBN.Location = new System.Drawing.Point(15, 25);
            this.lblMaBN.Size = new System.Drawing.Size(65, 20);
            this.txtMaBN.Location = new System.Drawing.Point(85, 22);
            this.txtMaBN.Size = new System.Drawing.Size(120, 22);

            this.lblHoTen.Text = "Họ và Tên:";
            this.lblHoTen.Location = new System.Drawing.Point(220, 25);
            this.lblHoTen.Size = new System.Drawing.Size(75, 20);
            this.txtHoTen.Location = new System.Drawing.Point(300, 22);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);

            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(520, 25);
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 20);
            this.dtNgaySinh.Location = new System.Drawing.Point(595, 22);
            this.dtNgaySinh.Size = new System.Drawing.Size(130, 22);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(745, 25);
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 20);
            this.cboGioiTinh.Location = new System.Drawing.Point(815, 22);
            this.cboGioiTinh.Size = new System.Drawing.Size(120, 22);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblSDT.Text = "Số ĐT:";
            this.lblSDT.Location = new System.Drawing.Point(15, 60);
            this.lblSDT.Size = new System.Drawing.Size(65, 20);
            this.txtSDT.Location = new System.Drawing.Point(85, 57);
            this.txtSDT.Size = new System.Drawing.Size(120, 22);

            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.Location = new System.Drawing.Point(220, 60);
            this.lblDiaChi.Size = new System.Drawing.Size(75, 20);
            this.txtDiaChi.Location = new System.Drawing.Point(300, 57);
            this.txtDiaChi.Size = new System.Drawing.Size(325, 22);

            this.lblAnh.Text = "Ảnh 3x4:";
            this.lblAnh.Location = new System.Drawing.Point(640, 60);
            this.lblAnh.Size = new System.Drawing.Size(60, 20);
            this.txtAnh3x4.Location = new System.Drawing.Point(705, 57);
            this.txtAnh3x4.Size = new System.Drawing.Size(130, 22);
            this.txtAnh3x4.ReadOnly = true;

            this.btnChupAnh.Text = "Chụp 3x4";
            this.btnChupAnh.Location = new System.Drawing.Point(845, 55);
            this.btnChupAnh.Size = new System.Drawing.Size(90, 26);
            this.btnChupAnh.Click += new System.EventHandler(this.btnChupAnh_Click);

            this.lblLePhi.Text = "Lệ phí năm:";
            this.lblLePhi.Location = new System.Drawing.Point(15, 95);
            this.lblLePhi.Size = new System.Drawing.Size(70, 20);
            this.numLePhi.Location = new System.Drawing.Point(85, 92);
            this.numLePhi.Size = new System.Drawing.Size(120, 22);
            this.numLePhi.Maximum = 100000000;
            this.numLePhi.Value = 1200000;

            this.lblNam.Text = "Năm:";
            this.lblNam.Location = new System.Drawing.Point(220, 95);
            this.lblNam.Size = new System.Drawing.Size(50, 20);
            this.numNamApDung.Location = new System.Drawing.Point(300, 92);
            this.numNamApDung.Size = new System.Drawing.Size(90, 22);
            this.numNamApDung.Maximum = 2050;
            this.numNamApDung.Minimum = 2000;

            this.lblTSB.Text = "Tiền sử bệnh:";
            this.lblTSB.Location = new System.Drawing.Point(410, 95);
            this.lblTSB.Size = new System.Drawing.Size(85, 20);
            this.txtTienSuBenh.Location = new System.Drawing.Point(500, 92);
            this.txtTienSuBenh.Size = new System.Drawing.Size(435, 22);

            this.lblTSDU.Text = "Dị ứng thuốc:";
            this.lblTSDU.Location = new System.Drawing.Point(15, 130);
            this.lblTSDU.Size = new System.Drawing.Size(80, 20);
            this.txtTienSuDiUng.Location = new System.Drawing.Point(100, 127);
            this.txtTienSuDiUng.Size = new System.Drawing.Size(400, 22);

            this.btnDangKy.Text = "ĐĂNG KÝ BỆNH NHÂN, THU LỆ PHÍ NĂM & CẤP HỒ SƠ BỆNH ÁN";
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangKy.Location = new System.Drawing.Point(100, 165);
            this.btnDangKy.Size = new System.Drawing.Size(550, 38);
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.grpThongTin.Controls.Add(this.lblMaBN);
            this.grpThongTin.Controls.Add(this.txtMaBN);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtNgaySinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblSDT);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.lblAnh);
            this.grpThongTin.Controls.Add(this.txtAnh3x4);
            this.grpThongTin.Controls.Add(this.btnChupAnh);
            this.grpThongTin.Controls.Add(this.lblLePhi);
            this.grpThongTin.Controls.Add(this.numLePhi);
            this.grpThongTin.Controls.Add(this.lblNam);
            this.grpThongTin.Controls.Add(this.numNamApDung);
            this.grpThongTin.Controls.Add(this.lblTSB);
            this.grpThongTin.Controls.Add(this.txtTienSuBenh);
            this.grpThongTin.Controls.Add(this.lblTSDU);
            this.grpThongTin.Controls.Add(this.txtTienSuDiUng);
            this.grpThongTin.Controls.Add(this.btnDangKy);

            // grpDanhSach
            this.grpDanhSach.Text = "Danh Sách Bệnh Nhân & Hồ Sơ Đã Cấp";
            this.grpDanhSach.Location = new System.Drawing.Point(12, 235);
            this.grpDanhSach.Size = new System.Drawing.Size(960, 310);

            this.lblTimKiem.Text = "Tìm kiếm nhanh (Tên, SĐT, Mã HS):";
            this.lblTimKiem.Location = new System.Drawing.Point(15, 25);
            this.lblTimKiem.Size = new System.Drawing.Size(220, 20);
            this.txtTimKiem.Location = new System.Drawing.Point(240, 22);
            this.txtTimKiem.Size = new System.Drawing.Size(250, 22);

            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Location = new System.Drawing.Point(500, 20);
            this.btnTimKiem.Size = new System.Drawing.Size(90, 26);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Location = new System.Drawing.Point(600, 20);
            this.btnLamMoi.Size = new System.Drawing.Size(90, 26);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.dgvBenhNhan.Location = new System.Drawing.Point(15, 55);
            this.dgvBenhNhan.Size = new System.Drawing.Size(930, 240);
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.btnLamMoi);
            this.grpDanhSach.Controls.Add(this.dgvBenhNhan);

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(870, 555);
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp Nhận Bệnh Nhân & Quản Lý Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.FrmTiepNhan_Load);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLePhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamApDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
