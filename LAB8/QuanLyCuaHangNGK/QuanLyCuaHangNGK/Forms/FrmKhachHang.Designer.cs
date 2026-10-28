namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKhachQuen;
        private System.Windows.Forms.TabPage tabVangLai;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblHanMuc;
        private System.Windows.Forms.NumericUpDown numHanMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvKhachQuen;
        private System.Windows.Forms.DataGridView dgvVangLai;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKhachQuen = new System.Windows.Forms.TabPage();
            this.dgvKhachQuen = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numHanMuc = new System.Windows.Forms.NumericUpDown();
            this.lblHanMuc = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.tabVangLai = new System.Windows.Forms.TabPage();
            this.dgvVangLai = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKhachQuen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachQuen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanMuc)).BeginInit();
            this.tabVangLai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangLai)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKhachQuen);
            this.tabControl1.Controls.Add(this.tabVangLai);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKhachQuen
            // 
            this.tabKhachQuen.Controls.Add(this.dgvKhachQuen);
            this.tabKhachQuen.Controls.Add(this.btnXoa);
            this.tabKhachQuen.Controls.Add(this.btnSua);
            this.tabKhachQuen.Controls.Add(this.btnThem);
            this.tabKhachQuen.Controls.Add(this.numHanMuc);
            this.tabKhachQuen.Controls.Add(this.lblHanMuc);
            this.tabKhachQuen.Controls.Add(this.cboLoai);
            this.tabKhachQuen.Controls.Add(this.lblLoai);
            this.tabKhachQuen.Controls.Add(this.txtDiaChi);
            this.tabKhachQuen.Controls.Add(this.lblDiaChi);
            this.tabKhachQuen.Controls.Add(this.txtSDT);
            this.tabKhachQuen.Controls.Add(this.lblSDT);
            this.tabKhachQuen.Controls.Add(this.txtTen);
            this.tabKhachQuen.Controls.Add(this.lblTen);
            this.tabKhachQuen.Controls.Add(this.txtMa);
            this.tabKhachQuen.Controls.Add(this.lblMa);
            this.tabKhachQuen.Location = new System.Drawing.Point(4, 30);
            this.tabKhachQuen.Name = "tabKhachQuen";
            this.tabKhachQuen.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachQuen.Size = new System.Drawing.Size(852, 426);
            this.tabKhachQuen.TabIndex = 0;
            this.tabKhachQuen.Text = "Khách Quen (Hạn Mức Nợ)";
            this.tabKhachQuen.UseVisualStyleBackColor = true;
            // 
            // dgvKhachQuen
            // 
            this.dgvKhachQuen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachQuen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachQuen.Location = new System.Drawing.Point(15, 95);
            this.dgvKhachQuen.Name = "dgvKhachQuen";
            this.dgvKhachQuen.RowHeadersWidth = 51;
            this.dgvKhachQuen.RowTemplate.Height = 24;
            this.dgvKhachQuen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachQuen.Size = new System.Drawing.Size(820, 315);
            this.dgvKhachQuen.TabIndex = 15;
            this.dgvKhachQuen.SelectionChanged += new System.EventHandler(this.dgvKhachQuen_SelectionChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(745, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(645, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(545, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numHanMuc
            // 
            this.numHanMuc.Increment = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numHanMuc.Location = new System.Drawing.Point(375, 53);
            this.numHanMuc.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            this.numHanMuc.Name = "numHanMuc";
            this.numHanMuc.Size = new System.Drawing.Size(150, 29);
            this.numHanMuc.TabIndex = 11;
            this.numHanMuc.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // lblHanMuc
            // 
            this.lblHanMuc.AutoSize = true;
            this.lblHanMuc.Location = new System.Drawing.Point(275, 56);
            this.lblHanMuc.Name = "lblHanMuc";
            this.lblHanMuc.Size = new System.Drawing.Size(99, 21);
            this.lblHanMuc.TabIndex = 10;
            this.lblHanMuc.Text = "Hạn mức nợ:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Khách quen",
            "Vãng lai"});
            this.cboLoai.Location = new System.Drawing.Point(95, 53);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(160, 29);
            this.cboLoai.TabIndex = 9;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(15, 56);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(69, 21);
            this.lblLoai.TabIndex = 8;
            this.lblLoai.Text = "Loại KH:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(585, 15);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 29);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(525, 18);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 21);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(385, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 29);
            this.txtSDT.TabIndex = 5;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(340, 18);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 21);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(195, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(135, 29);
            this.txtTen.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(135, 18);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(61, 21);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên KH:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(55, 15);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(70, 29);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 18);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(35, 21);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã:";
            // 
            // tabVangLai
            // 
            this.tabVangLai.Controls.Add(this.dgvVangLai);
            this.tabVangLai.Location = new System.Drawing.Point(4, 30);
            this.tabVangLai.Name = "tabVangLai";
            this.tabVangLai.Padding = new System.Windows.Forms.Padding(3);
            this.tabVangLai.Size = new System.Drawing.Size(852, 426);
            this.tabVangLai.TabIndex = 1;
            this.tabVangLai.Text = "Khách Vãng Lai";
            this.tabVangLai.UseVisualStyleBackColor = true;
            // 
            // dgvVangLai
            // 
            this.dgvVangLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVangLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVangLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVangLai.Location = new System.Drawing.Point(3, 3);
            this.dgvVangLai.Name = "dgvVangLai";
            this.dgvVangLai.RowHeadersWidth = 51;
            this.dgvVangLai.RowTemplate.Height = 24;
            this.dgvVangLai.Size = new System.Drawing.Size(846, 420);
            this.dgvVangLai.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(765, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng & Hạn Mức Tín Dụng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKhachQuen.ResumeLayout(false);
            this.tabKhachQuen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachQuen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanMuc)).EndInit();
            this.tabVangLai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangLai)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
