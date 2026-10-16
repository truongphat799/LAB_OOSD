namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmXuatVienCSKH
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpXuatVien, grpLichHen, grpChoXuatVien, grpLichSu;
        private System.Windows.Forms.Label lblMaPK, lblMaHD, lblPTTT, lblTongTien, lblDienBien, lblPhanUng, lblDanhGia;
        private System.Windows.Forms.TextBox txtMaPK, txtMaHD, txtDienBien, txtPhanUngPhu, txtDanhGia;
        private System.Windows.Forms.ComboBox cboPTTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvChiTietVienPhi, dgvChoXuatVien, dgvDaXuatVien;

        private System.Windows.Forms.Label lblHoSoHen, lblQuy, lblNam, lblNgayHen, lblGhiChu;
        private System.Windows.Forms.ComboBox cboHoSoHen, cboQuyKham;
        private System.Windows.Forms.NumericUpDown numNamKham;
        private System.Windows.Forms.DateTimePicker dtNgayGioHen;
        private System.Windows.Forms.TextBox txtGhiChuHen;
        private System.Windows.Forms.Button btnDatLichHen;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpXuatVien = new System.Windows.Forms.GroupBox();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.cboPTTT = new System.Windows.Forms.ComboBox();
            this.dgvChiTietVienPhi = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDienBien = new System.Windows.Forms.Label();
            this.txtDienBien = new System.Windows.Forms.TextBox();
            this.lblPhanUng = new System.Windows.Forms.Label();
            this.txtPhanUngPhu = new System.Windows.Forms.TextBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.txtDanhGia = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();

            this.grpLichHen = new System.Windows.Forms.GroupBox();
            this.lblHoSoHen = new System.Windows.Forms.Label();
            this.cboHoSoHen = new System.Windows.Forms.ComboBox();
            this.lblQuy = new System.Windows.Forms.Label();
            this.cboQuyKham = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.numNamKham = new System.Windows.Forms.NumericUpDown();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtNgayGioHen = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChuHen = new System.Windows.Forms.TextBox();
            this.btnDatLichHen = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();

            this.grpChoXuatVien = new System.Windows.Forms.GroupBox();
            this.dgvChoXuatVien = new System.Windows.Forms.DataGridView();

            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvDaXuatVien = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpXuatVien.SuspendLayout();
            this.grpLichHen.SuspendLayout();
            this.grpChoXuatVien.SuspendLayout();
            this.grpLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietVienPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoXuatVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaXuatVien)).BeginInit();
            this.SuspendLayout();

            // grpXuatVien (Transaction 3)
            this.grpXuatVien.Text = "Thanh Toán Viện Phí & CSKH Khóa Hồ Sơ Điều Trị (Transaction 3)";
            this.grpXuatVien.Location = new System.Drawing.Point(12, 12);
            this.grpXuatVien.Size = new System.Drawing.Size(560, 360);

            this.lblMaPK.Text = "Mã Phiếu:";
            this.lblMaPK.Location = new System.Drawing.Point(10, 25);
            this.lblMaPK.Size = new System.Drawing.Size(65, 20);
            this.txtMaPK.Location = new System.Drawing.Point(80, 22);
            this.txtMaPK.Size = new System.Drawing.Size(90, 22);
            this.txtMaPK.ReadOnly = true;

            this.lblMaHD.Text = "Mã Hóa Đơn:";
            this.lblMaHD.Location = new System.Drawing.Point(180, 25);
            this.lblMaHD.Size = new System.Drawing.Size(80, 20);
            this.txtMaHD.Location = new System.Drawing.Point(265, 22);
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);

            this.lblPTTT.Text = "Phương thức:";
            this.lblPTTT.Location = new System.Drawing.Point(375, 25);
            this.lblPTTT.Size = new System.Drawing.Size(80, 20);
            this.cboPTTT.Location = new System.Drawing.Point(455, 22);
            this.cboPTTT.Size = new System.Drawing.Size(95, 22);

            this.dgvChiTietVienPhi.Location = new System.Drawing.Point(10, 52);
            this.dgvChiTietVienPhi.Size = new System.Drawing.Size(540, 115);
            this.dgvChiTietVienPhi.ReadOnly = true;
            this.dgvChiTietVienPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.lblTongTien.Text = "TỔNG THANH TOÁN: 0 VNĐ";
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongTien.Location = new System.Drawing.Point(10, 172);
            this.lblTongTien.Size = new System.Drawing.Size(540, 25);
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblDienBien.Text = "Diễn biến sức khỏe:";
            this.lblDienBien.Location = new System.Drawing.Point(10, 205);
            this.lblDienBien.Size = new System.Drawing.Size(120, 20);
            this.txtDienBien.Location = new System.Drawing.Point(135, 202);
            this.txtDienBien.Size = new System.Drawing.Size(415, 22);
            this.txtDienBien.Text = "Bệnh nhân đã ổn định, giảm đau rõ rệt, thân nhiệt bình thường";

            this.lblPhanUng.Text = "Phản ứng phụ:";
            this.lblPhanUng.Location = new System.Drawing.Point(10, 235);
            this.lblPhanUng.Size = new System.Drawing.Size(120, 20);
            this.txtPhanUngPhu.Location = new System.Drawing.Point(135, 232);
            this.txtPhanUngPhu.Size = new System.Drawing.Size(415, 22);
            this.txtPhanUngPhu.Text = "Không ghi nhận phản ứng phụ của thuốc";

            this.lblDanhGia.Text = "Đánh giá hiệu quả:";
            this.lblDanhGia.Location = new System.Drawing.Point(10, 265);
            this.lblDanhGia.Size = new System.Drawing.Size(120, 20);
            this.txtDanhGia.Location = new System.Drawing.Point(135, 262);
            this.txtDanhGia.Size = new System.Drawing.Size(415, 22);
            this.txtDanhGia.Text = "Điều trị đúng phác đồ, đạt hiệu quả tốt";

            this.btnThanhToan.Text = "THANH TOÁN XUẤT VIỆN & KHÓA HỒ SƠ ĐỢT ĐIỀU TRỊ";
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(10, 300);
            this.btnThanhToan.Size = new System.Drawing.Size(540, 48);
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            this.grpXuatVien.Controls.Add(this.lblMaPK);
            this.grpXuatVien.Controls.Add(this.txtMaPK);
            this.grpXuatVien.Controls.Add(this.lblMaHD);
            this.grpXuatVien.Controls.Add(this.txtMaHD);
            this.grpXuatVien.Controls.Add(this.lblPTTT);
            this.grpXuatVien.Controls.Add(this.cboPTTT);
            this.grpXuatVien.Controls.Add(this.dgvChiTietVienPhi);
            this.grpXuatVien.Controls.Add(this.lblTongTien);
            this.grpXuatVien.Controls.Add(this.lblDienBien);
            this.grpXuatVien.Controls.Add(this.txtDienBien);
            this.grpXuatVien.Controls.Add(this.lblPhanUng);
            this.grpXuatVien.Controls.Add(this.txtPhanUngPhu);
            this.grpXuatVien.Controls.Add(this.lblDanhGia);
            this.grpXuatVien.Controls.Add(this.txtDanhGia);
            this.grpXuatVien.Controls.Add(this.btnThanhToan);

            // grpLichHen
            this.grpLichHen.Text = "Đặt Lịch Khám Định Kỳ Theo Quý (Gửi SMS Tự Động)";
            this.grpLichHen.Location = new System.Drawing.Point(585, 12);
            this.grpLichHen.Size = new System.Drawing.Size(485, 360);

            this.lblHoSoHen.Text = "Mã Hồ Sơ:";
            this.lblHoSoHen.Location = new System.Drawing.Point(10, 25);
            this.lblHoSoHen.Size = new System.Drawing.Size(70, 20);
            this.cboHoSoHen.Location = new System.Drawing.Point(85, 22);
            this.cboHoSoHen.Size = new System.Drawing.Size(150, 22);

            this.lblQuy.Text = "Quý:";
            this.lblQuy.Location = new System.Drawing.Point(245, 25);
            this.lblQuy.Size = new System.Drawing.Size(35, 20);
            this.cboQuyKham.Location = new System.Drawing.Point(285, 22);
            this.cboQuyKham.Size = new System.Drawing.Size(50, 22);

            this.lblNam.Text = "Năm:";
            this.lblNam.Location = new System.Drawing.Point(345, 25);
            this.lblNam.Size = new System.Drawing.Size(40, 20);
            this.numNamKham.Location = new System.Drawing.Point(390, 22);
            this.numNamKham.Size = new System.Drawing.Size(80, 22);
            this.numNamKham.Maximum = 2050;
            this.numNamKham.Minimum = 2020;

            this.lblNgayHen.Text = "Ngày giờ hẹn:";
            this.lblNgayHen.Location = new System.Drawing.Point(10, 58);
            this.lblNgayHen.Size = new System.Drawing.Size(85, 20);
            this.dtNgayGioHen.Location = new System.Drawing.Point(100, 55);
            this.dtNgayGioHen.Size = new System.Drawing.Size(200, 22);
            this.dtNgayGioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";

            this.lblGhiChu.Text = "Ghi chú hẹn:";
            this.lblGhiChu.Location = new System.Drawing.Point(10, 90);
            this.lblGhiChu.Size = new System.Drawing.Size(85, 20);
            this.txtGhiChuHen.Location = new System.Drawing.Point(100, 87);
            this.txtGhiChuHen.Size = new System.Drawing.Size(370, 22);
            this.txtGhiChuHen.Text = "Khám tổng quát định kỳ quý theo gói chăm sóc hằng năm";

            this.btnDatLichHen.Text = "ĐẶT LỊCH HẸN & GỬI SMS BRANDNAME NHẮC BỆNH NHÂN";
            this.btnDatLichHen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnDatLichHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDatLichHen.Location = new System.Drawing.Point(10, 120);
            this.btnDatLichHen.Size = new System.Drawing.Size(460, 40);
            this.btnDatLichHen.UseVisualStyleBackColor = false;
            this.btnDatLichHen.Click += new System.EventHandler(this.btnDatLichHen_Click);

            this.dgvLichHen.Location = new System.Drawing.Point(10, 170);
            this.dgvLichHen.Size = new System.Drawing.Size(460, 175);
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.grpLichHen.Controls.Add(this.lblHoSoHen);
            this.grpLichHen.Controls.Add(this.cboHoSoHen);
            this.grpLichHen.Controls.Add(this.lblQuy);
            this.grpLichHen.Controls.Add(this.cboQuyKham);
            this.grpLichHen.Controls.Add(this.lblNam);
            this.grpLichHen.Controls.Add(this.numNamKham);
            this.grpLichHen.Controls.Add(this.lblNgayHen);
            this.grpLichHen.Controls.Add(this.dtNgayGioHen);
            this.grpLichHen.Controls.Add(this.lblGhiChu);
            this.grpLichHen.Controls.Add(this.txtGhiChuHen);
            this.grpLichHen.Controls.Add(this.btnDatLichHen);
            this.grpLichHen.Controls.Add(this.dgvLichHen);

            // grpChoXuatVien
            this.grpChoXuatVien.Text = "Danh Sách Chờ Xuất Viện (Đã Kê Toa)";
            this.grpChoXuatVien.Location = new System.Drawing.Point(12, 380);
            this.grpChoXuatVien.Size = new System.Drawing.Size(560, 160);

            this.dgvChoXuatVien.Location = new System.Drawing.Point(10, 22);
            this.dgvChoXuatVien.Size = new System.Drawing.Size(540, 128);
            this.dgvChoXuatVien.ReadOnly = true;
            this.dgvChoXuatVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoXuatVien.SelectionChanged += new System.EventHandler(this.dgvChoXuatVien_SelectionChanged);

            this.grpChoXuatVien.Controls.Add(this.dgvChoXuatVien);

            // grpLichSu
            this.grpLichSu.Text = "Lịch Sử Xuất Viện & Đợt Khám Đã Khóa Hồ Sơ";
            this.grpLichSu.Location = new System.Drawing.Point(585, 380);
            this.grpLichSu.Size = new System.Drawing.Size(485, 160);

            this.dgvDaXuatVien.Location = new System.Drawing.Point(10, 22);
            this.dgvDaXuatVien.Size = new System.Drawing.Size(460, 128);
            this.dgvDaXuatVien.ReadOnly = true;
            this.dgvDaXuatVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.grpLichSu.Controls.Add(this.dgvDaXuatVien);

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(970, 550);
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(1084, 595);
            this.Controls.Add(this.grpXuatVien);
            this.Controls.Add(this.grpLichHen);
            this.Controls.Add(this.grpChoXuatVien);
            this.Controls.Add(this.grpLichSu);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Viện Phí & CSKH Hoàn Tất Đợt Điều Trị";
            this.Load += new System.EventHandler(this.FrmXuatVienCSKH_Load);

            this.grpXuatVien.ResumeLayout(false);
            this.grpXuatVien.PerformLayout();
            this.grpLichHen.ResumeLayout(false);
            this.grpLichHen.PerformLayout();
            this.grpChoXuatVien.ResumeLayout(false);
            this.grpLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietVienPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoXuatVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaXuatVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
