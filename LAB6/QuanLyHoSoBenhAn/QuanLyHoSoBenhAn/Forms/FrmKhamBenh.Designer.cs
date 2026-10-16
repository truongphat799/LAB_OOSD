namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmKhamBenh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpPhieuKham, grpXetNghiem, grpToaThuoc, grpDanhSach;
        private System.Windows.Forms.Label lblHoSo, lblTenBenhNhan, lblTienSuBenhNen, lblCanhBaoDiUng;
        private System.Windows.Forms.Label lblMaPK, lblBacSi, lblKhoa, lblLoaiKham, lblTrieuChung, lblSinhHieu, lblChanDoanSB;
        private System.Windows.Forms.ComboBox cboHoSo, cboBacSi, cboKhoa, cboLoaiKham;
        private System.Windows.Forms.TextBox txtMaPhieuKham, txtTrieuChung, txtHuyetAp, txtChanDoanSoBo;
        private System.Windows.Forms.NumericUpDown numThanNhiet, numMach;
        private System.Windows.Forms.Button btnTaoPhieuKham;

        private System.Windows.Forms.Label lblDichVuXN, lblYeuCauXN;
        private System.Windows.Forms.ComboBox cboDichVuXN;
        private System.Windows.Forms.TextBox txtYeuCauXN;
        private System.Windows.Forms.Button btnChiDinhXN;
        private System.Windows.Forms.DataGridView dgvKetQuaXN;

        private System.Windows.Forms.Label lblMaToa, lblThuoc, lblSoLuong, lblLieuDung, lblCachDung, lblChanDoanXD, lblLoiDan;
        private System.Windows.Forms.TextBox txtMaToa, txtLieuDung, txtCachDung, txtChanDoanXacDinh, txtLoiDan;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.NumericUpDown numSoLuongThuoc;
        private System.Windows.Forms.CheckBox chkTaiKham;
        private System.Windows.Forms.DateTimePicker dtNgayTaiKham;
        private System.Windows.Forms.Button btnThemThuoc, btnXacNhanKeToa;
        private System.Windows.Forms.DataGridView dgvToaThuoc;

        private System.Windows.Forms.DataGridView dgvChoKham;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpPhieuKham = new System.Windows.Forms.GroupBox();
            this.lblHoSo = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.lblTienSuBenhNen = new System.Windows.Forms.Label();
            this.lblCanhBaoDiUng = new System.Windows.Forms.Label();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblLoaiKham = new System.Windows.Forms.Label();
            this.cboLoaiKham = new System.Windows.Forms.ComboBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblSinhHieu = new System.Windows.Forms.Label();
            this.numThanNhiet = new System.Windows.Forms.NumericUpDown();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.numMach = new System.Windows.Forms.NumericUpDown();
            this.lblChanDoanSB = new System.Windows.Forms.Label();
            this.txtChanDoanSoBo = new System.Windows.Forms.TextBox();
            this.btnTaoPhieuKham = new System.Windows.Forms.Button();

            this.grpXetNghiem = new System.Windows.Forms.GroupBox();
            this.lblDichVuXN = new System.Windows.Forms.Label();
            this.cboDichVuXN = new System.Windows.Forms.ComboBox();
            this.lblYeuCauXN = new System.Windows.Forms.Label();
            this.txtYeuCauXN = new System.Windows.Forms.TextBox();
            this.btnChiDinhXN = new System.Windows.Forms.Button();
            this.dgvKetQuaXN = new System.Windows.Forms.DataGridView();

            this.grpToaThuoc = new System.Windows.Forms.GroupBox();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuongThuoc = new System.Windows.Forms.NumericUpDown();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.lblChanDoanXD = new System.Windows.Forms.Label();
            this.txtChanDoanXacDinh = new System.Windows.Forms.TextBox();
            this.lblLoiDan = new System.Windows.Forms.Label();
            this.txtLoiDan = new System.Windows.Forms.TextBox();
            this.chkTaiKham = new System.Windows.Forms.CheckBox();
            this.dtNgayTaiKham = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhanKeToa = new System.Windows.Forms.Button();

            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChoKham = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpPhieuKham.SuspendLayout();
            this.grpXetNghiem.SuspendLayout();
            this.grpToaThuoc.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoKham)).BeginInit();
            this.SuspendLayout();

            // grpPhieuKham
            this.grpPhieuKham.Text = "Khám Lâm Sàng & Hồ Sơ Sức Khỏe";
            this.grpPhieuKham.Location = new System.Drawing.Point(12, 12);
            this.grpPhieuKham.Size = new System.Drawing.Size(560, 290);

            this.lblHoSo.Text = "Chọn Hồ Sơ:";
            this.lblHoSo.Location = new System.Drawing.Point(10, 25);
            this.lblHoSo.Size = new System.Drawing.Size(80, 20);
            this.cboHoSo.Location = new System.Drawing.Point(95, 22);
            this.cboHoSo.Size = new System.Drawing.Size(160, 22);
            this.cboHoSo.SelectedIndexChanged += new System.EventHandler(this.cboHoSo_SelectedIndexChanged);

            this.lblTenBenhNhan.Text = "Bệnh nhân: ...";
            this.lblTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenBenhNhan.Location = new System.Drawing.Point(265, 25);
            this.lblTenBenhNhan.Size = new System.Drawing.Size(285, 20);

            this.lblTienSuBenhNen.Text = "Tiền sử bệnh: ...";
            this.lblTienSuBenhNen.Location = new System.Drawing.Point(10, 50);
            this.lblTienSuBenhNen.Size = new System.Drawing.Size(540, 20);

            this.lblCanhBaoDiUng.Text = "CẢNH BÁO DỊ ỨNG: Không có dị ứng";
            this.lblCanhBaoDiUng.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCanhBaoDiUng.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCanhBaoDiUng.Location = new System.Drawing.Point(10, 72);
            this.lblCanhBaoDiUng.Size = new System.Drawing.Size(540, 20);

            this.lblMaPK.Text = "Mã Phiếu:";
            this.lblMaPK.Location = new System.Drawing.Point(10, 100);
            this.lblMaPK.Size = new System.Drawing.Size(70, 20);
            this.txtMaPhieuKham.Location = new System.Drawing.Point(85, 97);
            this.txtMaPhieuKham.Size = new System.Drawing.Size(100, 22);

            this.lblBacSi.Text = "Bác sĩ:";
            this.lblBacSi.Location = new System.Drawing.Point(195, 100);
            this.lblBacSi.Size = new System.Drawing.Size(50, 20);
            this.cboBacSi.Location = new System.Drawing.Point(250, 97);
            this.cboBacSi.Size = new System.Drawing.Size(130, 22);

            this.lblKhoa.Text = "Khoa:";
            this.lblKhoa.Location = new System.Drawing.Point(390, 100);
            this.lblKhoa.Size = new System.Drawing.Size(45, 20);
            this.cboKhoa.Location = new System.Drawing.Point(440, 97);
            this.cboKhoa.Size = new System.Drawing.Size(110, 22);

            this.lblLoaiKham.Text = "Loại khám:";
            this.lblLoaiKham.Location = new System.Drawing.Point(10, 130);
            this.lblLoaiKham.Size = new System.Drawing.Size(70, 20);
            this.cboLoaiKham.Location = new System.Drawing.Point(85, 127);
            this.cboLoaiKham.Size = new System.Drawing.Size(170, 22);

            this.lblSinhHieu.Text = "Sinh hiệu (Nhiệt/HA/Mạch):";
            this.lblSinhHieu.Location = new System.Drawing.Point(265, 130);
            this.lblSinhHieu.Size = new System.Drawing.Size(160, 20);
            this.numThanNhiet.Location = new System.Drawing.Point(425, 127);
            this.numThanNhiet.Size = new System.Drawing.Size(40, 22);
            this.numThanNhiet.DecimalPlaces = 1;
            this.numThanNhiet.Value = (decimal)37.0;
            this.txtHuyetAp.Location = new System.Drawing.Point(470, 127);
            this.txtHuyetAp.Size = new System.Drawing.Size(45, 22);
            this.txtHuyetAp.Text = "120/80";
            this.numMach.Location = new System.Drawing.Point(520, 127);
            this.numMach.Size = new System.Drawing.Size(35, 22);
            this.numMach.Maximum = 200;
            this.numMach.Value = 75;

            this.lblTrieuChung.Text = "Triệu chứng:";
            this.lblTrieuChung.Location = new System.Drawing.Point(10, 160);
            this.lblTrieuChung.Size = new System.Drawing.Size(75, 20);
            this.txtTrieuChung.Location = new System.Drawing.Point(90, 157);
            this.txtTrieuChung.Size = new System.Drawing.Size(460, 22);

            this.lblChanDoanSB.Text = "CĐ sơ bộ:";
            this.lblChanDoanSB.Location = new System.Drawing.Point(10, 190);
            this.lblChanDoanSB.Size = new System.Drawing.Size(75, 20);
            this.txtChanDoanSoBo.Location = new System.Drawing.Point(90, 187);
            this.txtChanDoanSoBo.Size = new System.Drawing.Size(460, 22);

            this.btnTaoPhieuKham.Text = "BẮT ĐẦU ĐỢT KHÁM MỚI (TẠO TRANG BỆNH ÁN)";
            this.btnTaoPhieuKham.BackColor = System.Drawing.Color.LightCyan;
            this.btnTaoPhieuKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieuKham.Location = new System.Drawing.Point(90, 225);
            this.btnTaoPhieuKham.Size = new System.Drawing.Size(460, 45);
            this.btnTaoPhieuKham.UseVisualStyleBackColor = false;
            this.btnTaoPhieuKham.Click += new System.EventHandler(this.btnTaoPhieuKham_Click);

            this.grpPhieuKham.Controls.Add(this.lblHoSo);
            this.grpPhieuKham.Controls.Add(this.cboHoSo);
            this.grpPhieuKham.Controls.Add(this.lblTenBenhNhan);
            this.grpPhieuKham.Controls.Add(this.lblTienSuBenhNen);
            this.grpPhieuKham.Controls.Add(this.lblCanhBaoDiUng);
            this.grpPhieuKham.Controls.Add(this.lblMaPK);
            this.grpPhieuKham.Controls.Add(this.txtMaPhieuKham);
            this.grpPhieuKham.Controls.Add(this.lblBacSi);
            this.grpPhieuKham.Controls.Add(this.cboBacSi);
            this.grpPhieuKham.Controls.Add(this.lblKhoa);
            this.grpPhieuKham.Controls.Add(this.cboKhoa);
            this.grpPhieuKham.Controls.Add(this.lblLoaiKham);
            this.grpPhieuKham.Controls.Add(this.cboLoaiKham);
            this.grpPhieuKham.Controls.Add(this.lblSinhHieu);
            this.grpPhieuKham.Controls.Add(this.numThanNhiet);
            this.grpPhieuKham.Controls.Add(this.txtHuyetAp);
            this.grpPhieuKham.Controls.Add(this.numMach);
            this.grpPhieuKham.Controls.Add(this.lblTrieuChung);
            this.grpPhieuKham.Controls.Add(this.txtTrieuChung);
            this.grpPhieuKham.Controls.Add(this.lblChanDoanSB);
            this.grpPhieuKham.Controls.Add(this.txtChanDoanSoBo);
            this.grpPhieuKham.Controls.Add(this.btnTaoPhieuKham);

            // grpXetNghiem
            this.grpXetNghiem.Text = "Chỉ Định Cận Lâm Sàng & Kết Quả Xét Nghiệm";
            this.grpXetNghiem.Location = new System.Drawing.Point(585, 12);
            this.grpXetNghiem.Size = new System.Drawing.Size(485, 290);

            this.lblDichVuXN.Text = "Dịch vụ:";
            this.lblDichVuXN.Location = new System.Drawing.Point(10, 25);
            this.lblDichVuXN.Size = new System.Drawing.Size(60, 20);
            this.cboDichVuXN.Location = new System.Drawing.Point(75, 22);
            this.cboDichVuXN.Size = new System.Drawing.Size(260, 22);

            this.btnChiDinhXN.Text = "Chỉ Định XN";
            this.btnChiDinhXN.Location = new System.Drawing.Point(345, 20);
            this.btnChiDinhXN.Size = new System.Drawing.Size(125, 26);
            this.btnChiDinhXN.Click += new System.EventHandler(this.btnChiDinhXN_Click);

            this.lblYeuCauXN.Text = "Yêu cầu:";
            this.lblYeuCauXN.Location = new System.Drawing.Point(10, 55);
            this.lblYeuCauXN.Size = new System.Drawing.Size(60, 20);
            this.txtYeuCauXN.Location = new System.Drawing.Point(75, 52);
            this.txtYeuCauXN.Size = new System.Drawing.Size(395, 22);

            this.dgvKetQuaXN.Location = new System.Drawing.Point(10, 85);
            this.dgvKetQuaXN.Size = new System.Drawing.Size(460, 190);
            this.dgvKetQuaXN.ReadOnly = true;
            this.dgvKetQuaXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.grpXetNghiem.Controls.Add(this.lblDichVuXN);
            this.grpXetNghiem.Controls.Add(this.cboDichVuXN);
            this.grpXetNghiem.Controls.Add(this.btnChiDinhXN);
            this.grpXetNghiem.Controls.Add(this.lblYeuCauXN);
            this.grpXetNghiem.Controls.Add(this.txtYeuCauXN);
            this.grpXetNghiem.Controls.Add(this.dgvKetQuaXN);

            // grpToaThuoc (Transaction 2)
            this.grpToaThuoc.Text = "Lập Toa Thuốc, Kiểm Tra Dị Ứng & Trừ Kho Dược (Transaction 2)";
            this.grpToaThuoc.Location = new System.Drawing.Point(12, 308);
            this.grpToaThuoc.Size = new System.Drawing.Size(1058, 260);

            this.lblMaToa.Text = "Mã Toa:";
            this.lblMaToa.Location = new System.Drawing.Point(10, 25);
            this.lblMaToa.Size = new System.Drawing.Size(55, 20);
            this.txtMaToa.Location = new System.Drawing.Point(70, 22);
            this.txtMaToa.Size = new System.Drawing.Size(90, 22);

            this.lblThuoc.Text = "Thuốc:";
            this.lblThuoc.Location = new System.Drawing.Point(170, 25);
            this.lblThuoc.Size = new System.Drawing.Size(50, 20);
            this.cboThuoc.Location = new System.Drawing.Point(225, 22);
            this.cboThuoc.Size = new System.Drawing.Size(200, 22);

            this.lblSoLuong.Text = "SL:";
            this.lblSoLuong.Location = new System.Drawing.Point(435, 25);
            this.lblSoLuong.Size = new System.Drawing.Size(30, 20);
            this.numSoLuongThuoc.Location = new System.Drawing.Point(470, 22);
            this.numSoLuongThuoc.Size = new System.Drawing.Size(50, 22);
            this.numSoLuongThuoc.Minimum = 1;
            this.numSoLuongThuoc.Value = 10;

            this.lblLieuDung.Text = "Liều dùng:";
            this.lblLieuDung.Location = new System.Drawing.Point(530, 25);
            this.lblLieuDung.Size = new System.Drawing.Size(65, 20);
            this.txtLieuDung.Location = new System.Drawing.Point(600, 22);
            this.txtLieuDung.Size = new System.Drawing.Size(150, 22);
            this.txtLieuDung.Text = "Sáng 1, Chiều 1";

            this.lblCachDung.Text = "Cách dùng:";
            this.lblCachDung.Location = new System.Drawing.Point(760, 25);
            this.lblCachDung.Size = new System.Drawing.Size(70, 20);
            this.txtCachDung.Location = new System.Drawing.Point(835, 22);
            this.txtCachDung.Size = new System.Drawing.Size(120, 22);
            this.txtCachDung.Text = "Uống sau ăn no";

            this.btnThemThuoc.Text = "+ Thêm";
            this.btnThemThuoc.Location = new System.Drawing.Point(965, 20);
            this.btnThemThuoc.Size = new System.Drawing.Size(80, 26);
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            this.dgvToaThuoc.Location = new System.Drawing.Point(10, 52);
            this.dgvToaThuoc.Size = new System.Drawing.Size(640, 195);
            this.dgvToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.lblChanDoanXD.Text = "CĐ Xác định:";
            this.lblChanDoanXD.Location = new System.Drawing.Point(660, 55);
            this.lblChanDoanXD.Size = new System.Drawing.Size(85, 20);
            this.txtChanDoanXacDinh.Location = new System.Drawing.Point(750, 52);
            this.txtChanDoanXacDinh.Size = new System.Drawing.Size(295, 22);

            this.lblLoiDan.Text = "Lời dặn BS:";
            this.lblLoiDan.Location = new System.Drawing.Point(660, 85);
            this.lblLoiDan.Size = new System.Drawing.Size(85, 20);
            this.txtLoiDan.Location = new System.Drawing.Point(750, 82);
            this.txtLoiDan.Size = new System.Drawing.Size(295, 22);
            this.txtLoiDan.Text = "Uống nhiều nước, tái khám đúng hẹn";

            this.chkTaiKham.Text = "Hẹn tái khám sau 7 ngày:";
            this.chkTaiKham.Location = new System.Drawing.Point(660, 115);
            this.chkTaiKham.Size = new System.Drawing.Size(180, 22);
            this.chkTaiKham.Checked = true;

            this.dtNgayTaiKham.Location = new System.Drawing.Point(845, 115);
            this.dtNgayTaiKham.Size = new System.Drawing.Size(200, 22);
            this.dtNgayTaiKham.Value = System.DateTime.Now.AddDays(7);

            this.btnXacNhanKeToa.Text = "XÁC NHẬN KÊ TOA & TRỪ TỒN KHO DƯỢC";
            this.btnXacNhanKeToa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXacNhanKeToa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanKeToa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXacNhanKeToa.Location = new System.Drawing.Point(660, 155);
            this.btnXacNhanKeToa.Size = new System.Drawing.Size(385, 50);
            this.btnXacNhanKeToa.UseVisualStyleBackColor = false;
            this.btnXacNhanKeToa.Click += new System.EventHandler(this.btnXacNhanKeToa_Click);

            this.grpToaThuoc.Controls.Add(this.lblMaToa);
            this.grpToaThuoc.Controls.Add(this.txtMaToa);
            this.grpToaThuoc.Controls.Add(this.lblThuoc);
            this.grpToaThuoc.Controls.Add(this.cboThuoc);
            this.grpToaThuoc.Controls.Add(this.lblSoLuong);
            this.grpToaThuoc.Controls.Add(this.numSoLuongThuoc);
            this.grpToaThuoc.Controls.Add(this.lblLieuDung);
            this.grpToaThuoc.Controls.Add(this.txtLieuDung);
            this.grpToaThuoc.Controls.Add(this.lblCachDung);
            this.grpToaThuoc.Controls.Add(this.txtCachDung);
            this.grpToaThuoc.Controls.Add(this.btnThemThuoc);
            this.grpToaThuoc.Controls.Add(this.dgvToaThuoc);
            this.grpToaThuoc.Controls.Add(this.lblChanDoanXD);
            this.grpToaThuoc.Controls.Add(this.txtChanDoanXacDinh);
            this.grpToaThuoc.Controls.Add(this.lblLoiDan);
            this.grpToaThuoc.Controls.Add(this.txtLoiDan);
            this.grpToaThuoc.Controls.Add(this.chkTaiKham);
            this.grpToaThuoc.Controls.Add(this.dtNgayTaiKham);
            this.grpToaThuoc.Controls.Add(this.btnXacNhanKeToa);

            // grpDanhSach
            this.grpDanhSach.Text = "Danh Sách Đợt Khám Đang Điều Trị (Chọn dòng để thao tác)";
            this.grpDanhSach.Location = new System.Drawing.Point(12, 575);
            this.grpDanhSach.Size = new System.Drawing.Size(950, 140);

            this.dgvChoKham.Location = new System.Drawing.Point(10, 20);
            this.dgvChoKham.Size = new System.Drawing.Size(930, 110);
            this.dgvChoKham.ReadOnly = true;
            this.dgvChoKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoKham.SelectionChanged += new System.EventHandler(this.dgvChoKham_SelectionChanged);

            this.grpDanhSach.Controls.Add(this.dgvChoKham);

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(970, 680);
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(1084, 725);
            this.Controls.Add(this.grpPhieuKham);
            this.Controls.Add(this.grpXetNghiem);
            this.Controls.Add(this.grpToaThuoc);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Khám Bệnh - Chỉ Định Xét Nghiệm & Lập Toa Thuốc";
            this.Load += new System.EventHandler(this.FrmKhamBenh_Load);

            this.grpPhieuKham.ResumeLayout(false);
            this.grpPhieuKham.PerformLayout();
            this.grpXetNghiem.ResumeLayout(false);
            this.grpXetNghiem.PerformLayout();
            this.grpToaThuoc.ResumeLayout(false);
            this.grpToaThuoc.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoKham)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
