namespace QuanLyCuaHangEShopping.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNhom;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.TabPage tabLoaiPhieu;
        private System.Windows.Forms.TabPage tabChinhSach;
        private System.Windows.Forms.TabPage tabLoaiThe;

        // Tab Nhóm
        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button btnThemNhom;

        // Tab Khu vực
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private System.Windows.Forms.TextBox txtMaKV;
        private System.Windows.Forms.TextBox txtTenKV;
        private System.Windows.Forms.Button btnThemKhuVuc;

        // Tab Loại phiếu
        private System.Windows.Forms.DataGridView dgvLoaiPhieu;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.NumericUpDown numGiaLP;
        private System.Windows.Forms.TextBox txtThoiGianLP;
        private System.Windows.Forms.Button btnThemLoaiPhieu;

        // Tab Loại thẻ
        private System.Windows.Forms.DataGridView dgvLoaiThe;

        // Tab Chính sách
        private System.Windows.Forms.DataGridView dgvChinhSach;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.ComboBox cboCSLoaiPhieu;
        private System.Windows.Forms.NumericUpDown numGiaTriToiThieu;
        private System.Windows.Forms.TextBox txtHinhThucCS;
        private System.Windows.Forms.Button btnThemChinhSach;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNhom = new System.Windows.Forms.TabPage();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.tabLoaiPhieu = new System.Windows.Forms.TabPage();
            this.tabChinhSach = new System.Windows.Forms.TabPage();
            this.tabLoaiThe = new System.Windows.Forms.TabPage();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.txtMaKV = new System.Windows.Forms.TextBox();
            this.txtTenKV = new System.Windows.Forms.TextBox();
            this.btnThemKhuVuc = new System.Windows.Forms.Button();
            this.dgvLoaiPhieu = new System.Windows.Forms.DataGridView();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.numGiaLP = new System.Windows.Forms.NumericUpDown();
            this.txtThoiGianLP = new System.Windows.Forms.TextBox();
            this.btnThemLoaiPhieu = new System.Windows.Forms.Button();
            this.dgvLoaiThe = new System.Windows.Forms.DataGridView();
            this.dgvChinhSach = new System.Windows.Forms.DataGridView();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.cboCSLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.numGiaTriToiThieu = new System.Windows.Forms.NumericUpDown();
            this.txtHinhThucCS = new System.Windows.Forms.TextBox();
            this.btnThemChinhSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabNhom.SuspendLayout();
            this.tabKhuVuc.SuspendLayout();
            this.tabLoaiPhieu.SuspendLayout();
            this.tabChinhSach.SuspendLayout();
            this.tabLoaiThe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTriToiThieu)).BeginInit();
            this.SuspendLayout();

            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Size = new System.Drawing.Size(760, 400);

            // Tab 1: Nhóm SP
            this.tabNhom.Text = "Nhóm SP";
            this.dgvNhom.Location = new System.Drawing.Point(10, 10);
            this.dgvNhom.Size = new System.Drawing.Size(450, 340);
            this.txtMaNhom.Location = new System.Drawing.Point(480, 20);
            this.txtMaNhom.Size = new System.Drawing.Size(240, 22);
            this.txtTenNhom.Location = new System.Drawing.Point(480, 60);
            this.txtTenNhom.Size = new System.Drawing.Size(240, 22);
            this.btnThemNhom.Location = new System.Drawing.Point(480, 100);
            this.btnThemNhom.Size = new System.Drawing.Size(120, 30);
            this.btnThemNhom.Text = "+ Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            this.tabNhom.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvNhom, this.txtMaNhom, this.txtTenNhom, this.btnThemNhom });

            // Tab 2: Khu vực
            this.tabKhuVuc.Text = "Khu vực giao hàng";
            this.dgvKhuVuc.Location = new System.Drawing.Point(10, 10);
            this.dgvKhuVuc.Size = new System.Drawing.Size(450, 340);
            this.txtMaKV.Location = new System.Drawing.Point(480, 20);
            this.txtMaKV.Size = new System.Drawing.Size(240, 22);
            this.txtTenKV.Location = new System.Drawing.Point(480, 60);
            this.txtTenKV.Size = new System.Drawing.Size(240, 22);
            this.btnThemKhuVuc.Location = new System.Drawing.Point(480, 100);
            this.btnThemKhuVuc.Size = new System.Drawing.Size(120, 30);
            this.btnThemKhuVuc.Text = "+ Thêm khu vực";
            this.btnThemKhuVuc.Click += new System.EventHandler(this.btnThemKhuVuc_Click);
            this.tabKhuVuc.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvKhuVuc, this.txtMaKV, this.txtTenKV, this.btnThemKhuVuc });

            // Tab 3: Loại phiếu
            this.tabLoaiPhieu.Text = "Loại phiếu đặt hàng";
            this.dgvLoaiPhieu.Location = new System.Drawing.Point(10, 10);
            this.dgvLoaiPhieu.Size = new System.Drawing.Size(420, 340);
            this.txtMaLP.Location = new System.Drawing.Point(450, 20);
            this.txtMaLP.Size = new System.Drawing.Size(270, 22);
            this.txtTenLP.Location = new System.Drawing.Point(450, 60);
            this.txtTenLP.Size = new System.Drawing.Size(270, 22);
            this.numGiaLP.Location = new System.Drawing.Point(450, 100);
            this.numGiaLP.Size = new System.Drawing.Size(270, 22);
            this.numGiaLP.Maximum = 100000000;
            this.txtThoiGianLP.Location = new System.Drawing.Point(450, 140);
            this.txtThoiGianLP.Size = new System.Drawing.Size(270, 22);
            this.btnThemLoaiPhieu.Location = new System.Drawing.Point(450, 180);
            this.btnThemLoaiPhieu.Size = new System.Drawing.Size(140, 30);
            this.btnThemLoaiPhieu.Text = "+ Thêm loại phiếu";
            this.btnThemLoaiPhieu.Click += new System.EventHandler(this.btnThemLoaiPhieu_Click);
            this.tabLoaiPhieu.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvLoaiPhieu, this.txtMaLP, this.txtTenLP, this.numGiaLP, this.txtThoiGianLP, this.btnThemLoaiPhieu });

            // Tab 4: Loại thẻ
            this.tabLoaiThe.Text = "Cấu hình loại thẻ";
            this.dgvLoaiThe.Location = new System.Drawing.Point(10, 10);
            this.dgvLoaiThe.Size = new System.Drawing.Size(720, 340);
            this.tabLoaiThe.Controls.Add(this.dgvLoaiThe);

            // Tab 5: Chính sách miễn cước
            this.tabChinhSach.Text = "Chính sách miễn cước";
            this.dgvChinhSach.Location = new System.Drawing.Point(10, 10);
            this.dgvChinhSach.Size = new System.Drawing.Size(420, 340);
            this.txtMaCS.Location = new System.Drawing.Point(450, 20);
            this.txtMaCS.Size = new System.Drawing.Size(270, 22);
            this.cboCSLoaiPhieu.Location = new System.Drawing.Point(450, 60);
            this.cboCSLoaiPhieu.Size = new System.Drawing.Size(270, 24);
            this.numGiaTriToiThieu.Location = new System.Drawing.Point(450, 100);
            this.numGiaTriToiThieu.Size = new System.Drawing.Size(270, 22);
            this.numGiaTriToiThieu.Maximum = 1000000000;
            this.txtHinhThucCS.Location = new System.Drawing.Point(450, 140);
            this.txtHinhThucCS.Size = new System.Drawing.Size(270, 22);
            this.btnThemChinhSach.Location = new System.Drawing.Point(450, 180);
            this.btnThemChinhSach.Size = new System.Drawing.Size(140, 30);
            this.btnThemChinhSach.Text = "+ Thêm chính sách";
            this.btnThemChinhSach.Click += new System.EventHandler(this.btnThemChinhSach_Click);
            this.tabChinhSach.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvChinhSach, this.txtMaCS, this.cboCSLoaiPhieu, this.numGiaTriToiThieu, this.txtHinhThucCS, this.btnThemChinhSach });

            this.tabControl.Controls.AddRange(new System.Windows.Forms.TabPage[] { this.tabNhom, this.tabKhuVuc, this.tabLoaiPhieu, this.tabLoaiThe, this.tabChinhSach });

            this.btnDong.Location = new System.Drawing.Point(670, 420);
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDong);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shopping - Quản lý Danh mục & Cấu hình";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabNhom.ResumeLayout(false);
            this.tabNhom.PerformLayout();
            this.tabKhuVuc.ResumeLayout(false);
            this.tabKhuVuc.PerformLayout();
            this.tabLoaiPhieu.ResumeLayout(false);
            this.tabLoaiPhieu.PerformLayout();
            this.tabChinhSach.ResumeLayout(false);
            this.tabChinhSach.PerformLayout();
            this.tabLoaiThe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGiaLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTriToiThieu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}