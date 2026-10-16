namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTu, lblDen;
        private System.Windows.Forms.DateTimePicker dtTu, dtDen;
        private System.Windows.Forms.Button btnThongKe, btnDong;
        private System.Windows.Forms.GroupBox grpTongHop, grpThuoc, grpKhoa;
        private System.Windows.Forms.DataGridView dgvTongHop, dgvThuocNhieu, dgvTheoKhoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpTongHop = new System.Windows.Forms.GroupBox();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();

            this.grpThuoc = new System.Windows.Forms.GroupBox();
            this.dgvThuocNhieu = new System.Windows.Forms.DataGridView();

            this.grpKhoa = new System.Windows.Forms.GroupBox();
            this.dgvTheoKhoa = new System.Windows.Forms.DataGridView();

            this.grpTongHop.SuspendLayout();
            this.grpThuoc.SuspendLayout();
            this.grpKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocNhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoKhoa)).BeginInit();
            this.SuspendLayout();

            // Filters
            this.lblTu.Text = "Từ ngày:";
            this.lblTu.Location = new System.Drawing.Point(15, 18);
            this.lblTu.Size = new System.Drawing.Size(60, 20);
            this.dtTu.Location = new System.Drawing.Point(80, 15);
            this.dtTu.Size = new System.Drawing.Size(120, 22);
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblDen.Text = "Đến ngày:";
            this.lblDen.Location = new System.Drawing.Point(220, 18);
            this.lblDen.Size = new System.Drawing.Size(65, 20);
            this.dtDen.Location = new System.Drawing.Point(290, 15);
            this.dtDen.Size = new System.Drawing.Size(120, 22);
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnThongKe.Text = "Xem Báo Cáo";
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Location = new System.Drawing.Point(430, 12);
            this.btnThongKe.Size = new System.Drawing.Size(120, 28);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // grpTongHop
            this.grpTongHop.Text = "Tổng Hợp Lượt Khám & Doanh Thu";
            this.grpTongHop.Location = new System.Drawing.Point(15, 50);
            this.grpTongHop.Size = new System.Drawing.Size(850, 100);

            this.dgvTongHop.Location = new System.Drawing.Point(10, 22);
            this.dgvTongHop.Size = new System.Drawing.Size(830, 68);
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grpTongHop.Controls.Add(this.dgvTongHop);

            // grpThuoc
            this.grpThuoc.Text = "Top Thuốc Được Kê Nhiều Nhất";
            this.grpThuoc.Location = new System.Drawing.Point(15, 160);
            this.grpThuoc.Size = new System.Drawing.Size(420, 280);

            this.dgvThuocNhieu.Location = new System.Drawing.Point(10, 22);
            this.dgvThuocNhieu.Size = new System.Drawing.Size(400, 245);
            this.dgvThuocNhieu.ReadOnly = true;
            this.dgvThuocNhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grpThuoc.Controls.Add(this.dgvThuocNhieu);

            // grpKhoa
            this.grpKhoa.Text = "Thống Kê Số Ca Khám Theo Khoa";
            this.grpKhoa.Location = new System.Drawing.Point(445, 160);
            this.grpKhoa.Size = new System.Drawing.Size(420, 280);

            this.dgvTheoKhoa.Location = new System.Drawing.Point(10, 22);
            this.dgvTheoKhoa.Size = new System.Drawing.Size(400, 245);
            this.dgvTheoKhoa.ReadOnly = true;
            this.dgvTheoKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grpKhoa.Controls.Add(this.dgvTheoKhoa);

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(765, 450);
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(884, 495);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.grpTongHop);
            this.Controls.Add(this.grpThuoc);
            this.Controls.Add(this.grpKhoa);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê Viện Phí & Khám Bệnh";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);

            this.grpTongHop.ResumeLayout(false);
            this.grpThuoc.ResumeLayout(false);
            this.grpKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocNhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoKhoa)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
