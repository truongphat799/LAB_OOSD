namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmNuocGiaiKhat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNGK;
        private System.Windows.Forms.TabPage tabCanhBao;
        private System.Windows.Forms.Button btnDong;

        // Input controls
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNH;
        private System.Windows.Forms.ComboBox cboNH;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label lblTon;
        private System.Windows.Forms.NumericUpDown numTon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label lblMinTon;
        private System.Windows.Forms.NumericUpDown numMinTon;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvNGK;
        private System.Windows.Forms.DataGridView dgvCanhBao;

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
            this.tabNGK = new System.Windows.Forms.TabPage();
            this.dgvNGK = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numMinTon = new System.Windows.Forms.NumericUpDown();
            this.lblMinTon = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numTon = new System.Windows.Forms.NumericUpDown();
            this.lblTon = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNH = new System.Windows.Forms.ComboBox();
            this.lblNH = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.tabCanhBao = new System.Windows.Forms.TabPage();
            this.dgvCanhBao = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabNGK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTon)).BeginInit();
            this.tabCanhBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNGK);
            this.tabControl1.Controls.Add(this.tabCanhBao);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNGK
            // 
            this.tabNGK.Controls.Add(this.dgvNGK);
            this.tabNGK.Controls.Add(this.btnLamMoi);
            this.tabNGK.Controls.Add(this.btnTim);
            this.tabNGK.Controls.Add(this.txtTim);
            this.tabNGK.Controls.Add(this.btnXoa);
            this.tabNGK.Controls.Add(this.btnSua);
            this.tabNGK.Controls.Add(this.btnThem);
            this.tabNGK.Controls.Add(this.numMinTon);
            this.tabNGK.Controls.Add(this.lblMinTon);
            this.tabNGK.Controls.Add(this.numGia);
            this.tabNGK.Controls.Add(this.lblGia);
            this.tabNGK.Controls.Add(this.numTon);
            this.tabNGK.Controls.Add(this.lblTon);
            this.tabNGK.Controls.Add(this.cboDVT);
            this.tabNGK.Controls.Add(this.lblDVT);
            this.tabNGK.Controls.Add(this.cboNCC);
            this.tabNGK.Controls.Add(this.lblNCC);
            this.tabNGK.Controls.Add(this.cboNH);
            this.tabNGK.Controls.Add(this.lblNH);
            this.tabNGK.Controls.Add(this.txtTen);
            this.tabNGK.Controls.Add(this.lblTen);
            this.tabNGK.Controls.Add(this.txtMa);
            this.tabNGK.Controls.Add(this.lblMa);
            this.tabNGK.Location = new System.Drawing.Point(4, 30);
            this.tabNGK.Name = "tabNGK";
            this.tabNGK.Padding = new System.Windows.Forms.Padding(3);
            this.tabNGK.Size = new System.Drawing.Size(852, 436);
            this.tabNGK.TabIndex = 0;
            this.tabNGK.Text = "Thông Tin Nước Giải Khát";
            this.tabNGK.UseVisualStyleBackColor = true;
            // 
            // dgvNGK
            // 
            this.dgvNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNGK.Location = new System.Drawing.Point(15, 130);
            this.dgvNGK.Name = "dgvNGK";
            this.dgvNGK.RowHeadersWidth = 51;
            this.dgvNGK.RowTemplate.Height = 24;
            this.dgvNGK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNGK.Size = new System.Drawing.Size(820, 290);
            this.dgvNGK.TabIndex = 22;
            this.dgvNGK.SelectionChanged += new System.EventHandler(this.dgvNGK_SelectionChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(745, 90);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.TabIndex = 21;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(645, 90);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 30);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "🔍 Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(400, 91);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(235, 29);
            this.txtTim.TabIndex = 19;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numMinTon
            // 
            this.numMinTon.Location = new System.Drawing.Point(745, 52);
            this.numMinTon.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numMinTon.Name = "numMinTon";
            this.numMinTon.Size = new System.Drawing.Size(90, 29);
            this.numMinTon.TabIndex = 15;
            this.numMinTon.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblMinTon
            // 
            this.lblMinTon.AutoSize = true;
            this.lblMinTon.Location = new System.Drawing.Point(675, 55);
            this.lblMinTon.Name = "lblMinTon";
            this.lblMinTon.Size = new System.Drawing.Size(73, 21);
            this.lblMinTon.TabIndex = 14;
            this.lblMinTon.Text = "Tồn min:";
            // 
            // numGia
            // 
            this.numGia.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numGia.Location = new System.Drawing.Point(525, 52);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(140, 29);
            this.numGia.TabIndex = 13;
            this.numGia.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(455, 55);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(68, 21);
            this.lblGia.TabIndex = 12;
            this.lblGia.Text = "Giá bán:";
            // 
            // numTon
            // 
            this.numTon.Location = new System.Drawing.Point(345, 52);
            this.numTon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numTon.Name = "numTon";
            this.numTon.Size = new System.Drawing.Size(95, 29);
            this.numTon.TabIndex = 11;
            this.numTon.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblTon
            // 
            this.lblTon.AutoSize = true;
            this.lblTon.Location = new System.Drawing.Point(280, 55);
            this.lblTon.Name = "lblTon";
            this.lblTon.Size = new System.Drawing.Size(62, 21);
            this.lblTon.TabIndex = 10;
            this.lblTon.Text = "SL Tồn:";
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Thùng (24 lon)",
            "Thùng (24 chai)",
            "Két (24 chai)",
            "Lốc (6 lon)",
            "Chai",
            "Lon"});
            this.cboDVT.Location = new System.Drawing.Point(90, 52);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(175, 29);
            this.cboDVT.TabIndex = 9;
            this.cboDVT.Text = "Thùng (24 lon)";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(15, 55);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(43, 21);
            this.lblDVT.TabIndex = 8;
            this.lblDVT.Text = "ĐVT:";
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(625, 12);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(210, 29);
            this.cboNCC.TabIndex = 7;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(555, 15);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(71, 21);
            this.lblNCC.TabIndex = 6;
            this.lblNCC.Text = "Tên NCC:";
            // 
            // cboNH
            // 
            this.cboNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNH.FormattingEnabled = true;
            this.cboNH.Location = new System.Drawing.Point(415, 12);
            this.cboNH.Name = "cboNH";
            this.cboNH.Size = new System.Drawing.Size(125, 29);
            this.cboNH.TabIndex = 5;
            // 
            // lblNH
            // 
            this.lblNH.AutoSize = true;
            this.lblNH.Location = new System.Drawing.Point(340, 15);
            this.lblNH.Name = "lblNH";
            this.lblNH.Size = new System.Drawing.Size(84, 21);
            this.lblNH.TabIndex = 4;
            this.lblNH.Text = "Nhãn hiệu:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(175, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(155, 29);
            this.txtTen.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(135, 15);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 21);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(55, 12);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(70, 29);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 15);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(35, 21);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã:";
            // 
            // tabCanhBao
            // 
            this.tabCanhBao.Controls.Add(this.dgvCanhBao);
            this.tabCanhBao.Location = new System.Drawing.Point(4, 30);
            this.tabCanhBao.Name = "tabCanhBao";
            this.tabCanhBao.Padding = new System.Windows.Forms.Padding(3);
            this.tabCanhBao.Size = new System.Drawing.Size(852, 436);
            this.tabCanhBao.TabIndex = 1;
            this.tabCanhBao.Text = "Cảnh Báo Tồn Kho Dưới Định Mức";
            this.tabCanhBao.UseVisualStyleBackColor = true;
            // 
            // dgvCanhBao
            // 
            this.dgvCanhBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanhBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanhBao.Location = new System.Drawing.Point(3, 3);
            this.dgvCanhBao.Name = "dgvCanhBao";
            this.dgvCanhBao.RowHeadersWidth = 51;
            this.dgvCanhBao.RowTemplate.Height = 24;
            this.dgvCanhBao.Size = new System.Drawing.Size(846, 430);
            this.dgvCanhBao.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(765, 490);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNuocGiaiKhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNuocGiaiKhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nước Giải Khát & Tra Cứu Tồn Kho";
            this.Load += new System.EventHandler(this.FrmNuocGiaiKhat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNGK.ResumeLayout(false);
            this.tabNGK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTon)).EndInit();
            this.tabCanhBao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
