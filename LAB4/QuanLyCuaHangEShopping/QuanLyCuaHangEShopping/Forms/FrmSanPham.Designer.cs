namespace QuanLyCuaHangEShopping.Forms
{
    partial class FrmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtThongSo;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtMoTaChiTiet;
        private System.Windows.Forms.TextBox txtThongSoChiTiet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtThongSo = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtMoTaChiTiet = new System.Windows.Forms.TextBox();
            this.txtThongSoChiTiet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();

            this.txtMaSP.Location = new System.Drawing.Point(12, 20);
            this.txtMaSP.Size = new System.Drawing.Size(250, 22);

            this.cboNhom.Location = new System.Drawing.Point(12, 60);
            this.cboNhom.Size = new System.Drawing.Size(250, 24);

            this.txtTenSP.Location = new System.Drawing.Point(12, 100);
            this.txtTenSP.Size = new System.Drawing.Size(250, 22);

            this.txtNSX.Location = new System.Drawing.Point(12, 140);
            this.txtNSX.Size = new System.Drawing.Size(250, 22);

            this.numGia.Location = new System.Drawing.Point(12, 180);
            this.numGia.Size = new System.Drawing.Size(250, 22);
            this.numGia.Maximum = 1000000000;

            this.cboTinhTrang.Location = new System.Drawing.Point(12, 220);
            this.cboTinhTrang.Size = new System.Drawing.Size(250, 24);

            this.txtMoTa.Location = new System.Drawing.Point(12, 260);
            this.txtMoTa.Size = new System.Drawing.Size(250, 45);
            this.txtMoTa.Multiline = true;

            this.txtThongSo.Location = new System.Drawing.Point(12, 320);
            this.txtThongSo.Size = new System.Drawing.Size(250, 45);
            this.txtThongSo.Multiline = true;

            this.btnThemSP.Location = new System.Drawing.Point(12, 380);
            this.btnThemSP.Size = new System.Drawing.Size(130, 32);
            this.btnThemSP.Text = "+ Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

            this.dgvSanPham.Location = new System.Drawing.Point(280, 20);
            this.dgvSanPham.Size = new System.Drawing.Size(590, 285);
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);

            this.txtMoTaChiTiet.Location = new System.Drawing.Point(280, 320);
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(285, 90);
            this.txtMoTaChiTiet.Multiline = true;
            this.txtMoTaChiTiet.ReadOnly = true;

            this.txtThongSoChiTiet.Location = new System.Drawing.Point(585, 320);
            this.txtThongSoChiTiet.Size = new System.Drawing.Size(285, 90);
            this.txtThongSoChiTiet.Multiline = true;
            this.txtThongSoChiTiet.ReadOnly = true;

            this.btnDong.Location = new System.Drawing.Point(770, 420);
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.cboNhom);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.numGia);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtThongSo);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtMoTaChiTiet);
            this.Controls.Add(this.txtThongSoChiTiet);
            this.Controls.Add(this.btnDong);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shopping - Duyệt và Quản lý Sản phẩm";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}