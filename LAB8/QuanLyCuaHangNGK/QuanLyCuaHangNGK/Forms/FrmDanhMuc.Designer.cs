namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNCC;
        private System.Windows.Forms.TabPage tabNH;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.Button btnDong;

        // Controls for NCC
        private System.Windows.Forms.Label lblNCCMa;
        private System.Windows.Forms.TextBox txtNCCMa;
        private System.Windows.Forms.Label lblNCCTen;
        private System.Windows.Forms.TextBox txtNCCTen;
        private System.Windows.Forms.Label lblNCCDiaChi;
        private System.Windows.Forms.TextBox txtNCCDiaChi;
        private System.Windows.Forms.Label lblNCCSDT;
        private System.Windows.Forms.TextBox txtNCCSDT;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.DataGridView dgvNCC;

        // Controls for NhanHieu
        private System.Windows.Forms.Label lblNHMa;
        private System.Windows.Forms.TextBox txtNHMa;
        private System.Windows.Forms.Label lblNHTen;
        private System.Windows.Forms.TextBox txtNHTen;
        private System.Windows.Forms.Label lblNHXuatXu;
        private System.Windows.Forms.TextBox txtNHXuatXu;
        private System.Windows.Forms.Button btnThemNH;
        private System.Windows.Forms.Button btnSuaNH;
        private System.Windows.Forms.Button btnXoaNH;
        private System.Windows.Forms.DataGridView dgvNH;

        // Controls for NhanVien
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dgvNV;

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
            this.tabNCC = new System.Windows.Forms.TabPage();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtNCCSDT = new System.Windows.Forms.TextBox();
            this.lblNCCSDT = new System.Windows.Forms.Label();
            this.txtNCCDiaChi = new System.Windows.Forms.TextBox();
            this.lblNCCDiaChi = new System.Windows.Forms.Label();
            this.txtNCCTen = new System.Windows.Forms.TextBox();
            this.lblNCCTen = new System.Windows.Forms.Label();
            this.txtNCCMa = new System.Windows.Forms.TextBox();
            this.lblNCCMa = new System.Windows.Forms.Label();
            this.tabNH = new System.Windows.Forms.TabPage();
            this.dgvNH = new System.Windows.Forms.DataGridView();
            this.btnXoaNH = new System.Windows.Forms.Button();
            this.btnSuaNH = new System.Windows.Forms.Button();
            this.btnThemNH = new System.Windows.Forms.Button();
            this.txtNHXuatXu = new System.Windows.Forms.TextBox();
            this.lblNHXuatXu = new System.Windows.Forms.Label();
            this.txtNHTen = new System.Windows.Forms.TextBox();
            this.lblNHTen = new System.Windows.Forms.Label();
            this.txtNHMa = new System.Windows.Forms.TextBox();
            this.lblNHMa = new System.Windows.Forms.Label();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.tabNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNCC);
            this.tabControl1.Controls.Add(this.tabNH);
            this.tabControl1.Controls.Add(this.tabNV);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNCC
            // 
            this.tabNCC.Controls.Add(this.dgvNCC);
            this.tabNCC.Controls.Add(this.btnXoaNCC);
            this.tabNCC.Controls.Add(this.btnSuaNCC);
            this.tabNCC.Controls.Add(this.btnThemNCC);
            this.tabNCC.Controls.Add(this.txtNCCSDT);
            this.tabNCC.Controls.Add(this.lblNCCSDT);
            this.tabNCC.Controls.Add(this.txtNCCDiaChi);
            this.tabNCC.Controls.Add(this.lblNCCDiaChi);
            this.tabNCC.Controls.Add(this.txtNCCTen);
            this.tabNCC.Controls.Add(this.lblNCCTen);
            this.tabNCC.Controls.Add(this.txtNCCMa);
            this.tabNCC.Controls.Add(this.lblNCCMa);
            this.tabNCC.Location = new System.Drawing.Point(4, 30);
            this.tabNCC.Name = "tabNCC";
            this.tabNCC.Padding = new System.Windows.Forms.Padding(3);
            this.tabNCC.Size = new System.Drawing.Size(752, 406);
            this.tabNCC.TabIndex = 0;
            this.tabNCC.Text = "Nhà Cung Ứng";
            this.tabNCC.UseVisualStyleBackColor = true;
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(15, 95);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(720, 295);
            this.dgvNCC.TabIndex = 11;
            this.dgvNCC.SelectionChanged += new System.EventHandler(this.dgvNCC_SelectionChanged);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Location = new System.Drawing.Point(645, 52);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(90, 32);
            this.btnXoaNCC.TabIndex = 10;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Location = new System.Drawing.Point(545, 52);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(90, 32);
            this.btnSuaNCC.TabIndex = 9;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(445, 52);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(90, 32);
            this.btnThemNCC.TabIndex = 8;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtNCCSDT
            // 
            this.txtNCCSDT.Location = new System.Drawing.Point(485, 15);
            this.txtNCCSDT.Name = "txtNCCSDT";
            this.txtNCCSDT.Size = new System.Drawing.Size(250, 29);
            this.txtNCCSDT.TabIndex = 7;
            // 
            // lblNCCSDT
            // 
            this.lblNCCSDT.AutoSize = true;
            this.lblNCCSDT.Location = new System.Drawing.Point(405, 18);
            this.lblNCCSDT.Name = "lblNCCSDT";
            this.lblNCCSDT.Size = new System.Drawing.Size(83, 21);
            this.lblNCCSDT.TabIndex = 6;
            this.lblNCCSDT.Text = "Điện thoại:";
            // 
            // txtNCCDiaChi
            // 
            this.txtNCCDiaChi.Location = new System.Drawing.Point(90, 53);
            this.txtNCCDiaChi.Name = "txtNCCDiaChi";
            this.txtNCCDiaChi.Size = new System.Drawing.Size(340, 29);
            this.txtNCCDiaChi.TabIndex = 5;
            // 
            // lblNCCDiaChi
            // 
            this.lblNCCDiaChi.AutoSize = true;
            this.lblNCCDiaChi.Location = new System.Drawing.Point(15, 56);
            this.lblNCCDiaChi.Name = "lblNCCDiaChi";
            this.lblNCCDiaChi.Size = new System.Drawing.Size(60, 21);
            this.lblNCCDiaChi.TabIndex = 4;
            this.lblNCCDiaChi.Text = "Địa chỉ:";
            // 
            // txtNCCTen
            // 
            this.txtNCCTen.Location = new System.Drawing.Point(235, 15);
            this.txtNCCTen.Name = "txtNCCTen";
            this.txtNCCTen.Size = new System.Drawing.Size(160, 29);
            this.txtNCCTen.TabIndex = 3;
            // 
            // lblNCCTen
            // 
            this.lblNCCTen.AutoSize = true;
            this.lblNCCTen.Location = new System.Drawing.Point(165, 18);
            this.lblNCCTen.Name = "lblNCCTen";
            this.lblNCCTen.Size = new System.Drawing.Size(71, 21);
            this.lblNCCTen.TabIndex = 2;
            this.lblNCCTen.Text = "Tên NCC:";
            // 
            // txtNCCMa
            // 
            this.txtNCCMa.Location = new System.Drawing.Point(90, 15);
            this.txtNCCMa.Name = "txtNCCMa";
            this.txtNCCMa.Size = new System.Drawing.Size(65, 29);
            this.txtNCCMa.TabIndex = 1;
            // 
            // lblNCCMa
            // 
            this.lblNCCMa.AutoSize = true;
            this.lblNCCMa.Location = new System.Drawing.Point(15, 18);
            this.lblNCCMa.Name = "lblNCCMa";
            this.lblNCCMa.Size = new System.Drawing.Size(70, 21);
            this.lblNCCMa.TabIndex = 0;
            this.lblNCCMa.Text = "Mã NCC:";
            // 
            // tabNH
            // 
            this.tabNH.Controls.Add(this.dgvNH);
            this.tabNH.Controls.Add(this.btnXoaNH);
            this.tabNH.Controls.Add(this.btnSuaNH);
            this.tabNH.Controls.Add(this.btnThemNH);
            this.tabNH.Controls.Add(this.txtNHXuatXu);
            this.tabNH.Controls.Add(this.lblNHXuatXu);
            this.tabNH.Controls.Add(this.txtNHTen);
            this.tabNH.Controls.Add(this.lblNHTen);
            this.tabNH.Controls.Add(this.txtNHMa);
            this.tabNH.Controls.Add(this.lblNHMa);
            this.tabNH.Location = new System.Drawing.Point(4, 30);
            this.tabNH.Name = "tabNH";
            this.tabNH.Padding = new System.Windows.Forms.Padding(3);
            this.tabNH.Size = new System.Drawing.Size(752, 406);
            this.tabNH.TabIndex = 1;
            this.tabNH.Text = "Nhãn Hiệu";
            this.tabNH.UseVisualStyleBackColor = true;
            // 
            // dgvNH
            // 
            this.dgvNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Location = new System.Drawing.Point(15, 65);
            this.dgvNH.Name = "dgvNH";
            this.dgvNH.RowHeadersWidth = 51;
            this.dgvNH.RowTemplate.Height = 24;
            this.dgvNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNH.Size = new System.Drawing.Size(720, 325);
            this.dgvNH.TabIndex = 9;
            this.dgvNH.SelectionChanged += new System.EventHandler(this.dgvNH_SelectionChanged);
            // 
            // btnXoaNH
            // 
            this.btnXoaNH.Location = new System.Drawing.Point(650, 15);
            this.btnXoaNH.Name = "btnXoaNH";
            this.btnXoaNH.Size = new System.Drawing.Size(85, 32);
            this.btnXoaNH.TabIndex = 8;
            this.btnXoaNH.Text = "Xóa";
            this.btnXoaNH.UseVisualStyleBackColor = true;
            this.btnXoaNH.Click += new System.EventHandler(this.btnXoaNH_Click);
            // 
            // btnSuaNH
            // 
            this.btnSuaNH.Location = new System.Drawing.Point(555, 15);
            this.btnSuaNH.Name = "btnSuaNH";
            this.btnSuaNH.Size = new System.Drawing.Size(85, 32);
            this.btnSuaNH.TabIndex = 7;
            this.btnSuaNH.Text = "Sửa";
            this.btnSuaNH.UseVisualStyleBackColor = true;
            this.btnSuaNH.Click += new System.EventHandler(this.btnSuaNH_Click);
            // 
            // btnThemNH
            // 
            this.btnThemNH.Location = new System.Drawing.Point(460, 15);
            this.btnThemNH.Name = "btnThemNH";
            this.btnThemNH.Size = new System.Drawing.Size(85, 32);
            this.btnThemNH.TabIndex = 6;
            this.btnThemNH.Text = "Thêm";
            this.btnThemNH.UseVisualStyleBackColor = true;
            this.btnThemNH.Click += new System.EventHandler(this.btnThemNH_Click);
            // 
            // txtNHXuatXu
            // 
            this.txtNHXuatXu.Location = new System.Drawing.Point(355, 16);
            this.txtNHXuatXu.Name = "txtNHXuatXu";
            this.txtNHXuatXu.Size = new System.Drawing.Size(95, 29);
            this.txtNHXuatXu.TabIndex = 5;
            // 
            // lblNHXuatXu
            // 
            this.lblNHXuatXu.AutoSize = true;
            this.lblNHXuatXu.Location = new System.Drawing.Point(285, 19);
            this.lblNHXuatXu.Name = "lblNHXuatXu";
            this.lblNHXuatXu.Size = new System.Drawing.Size(65, 21);
            this.lblNHXuatXu.TabIndex = 4;
            this.lblNHXuatXu.Text = "Xuất xứ:";
            // 
            // txtNHTen
            // 
            this.txtNHTen.Location = new System.Drawing.Point(185, 16);
            this.txtNHTen.Name = "txtNHTen";
            this.txtNHTen.Size = new System.Drawing.Size(95, 29);
            this.txtNHTen.TabIndex = 3;
            // 
            // lblNHTen
            // 
            this.lblNHTen.AutoSize = true;
            this.lblNHTen.Location = new System.Drawing.Point(125, 19);
            this.lblNHTen.Name = "lblNHTen";
            this.lblNHTen.Size = new System.Drawing.Size(60, 21);
            this.lblNHTen.TabIndex = 2;
            this.lblNHTen.Text = "Tên NH:";
            // 
            // txtNHMa
            // 
            this.txtNHMa.Location = new System.Drawing.Point(65, 16);
            this.txtNHMa.Name = "txtNHMa";
            this.txtNHMa.Size = new System.Drawing.Size(55, 29);
            this.txtNHMa.TabIndex = 1;
            // 
            // lblNHMa
            // 
            this.lblNHMa.AutoSize = true;
            this.lblNHMa.Location = new System.Drawing.Point(10, 19);
            this.lblNHMa.Name = "lblNHMa";
            this.lblNHMa.Size = new System.Drawing.Size(59, 21);
            this.lblNHMa.TabIndex = 0;
            this.lblNHMa.Text = "Mã NH:";
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Controls.Add(this.btnXoaNV);
            this.tabNV.Controls.Add(this.btnSuaNV);
            this.tabNV.Controls.Add(this.btnThemNV);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVVaiTro);
            this.tabNV.Controls.Add(this.lblNVVaiTro);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Location = new System.Drawing.Point(4, 30);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(752, 406);
            this.tabNV.TabIndex = 2;
            this.tabNV.Text = "Nhân Viên";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(15, 65);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(720, 325);
            this.dgvNV.TabIndex = 11;
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(650, 15);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(85, 32);
            this.btnXoaNV.TabIndex = 10;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(555, 15);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(85, 32);
            this.btnSuaNV.TabIndex = 9;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(460, 15);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(85, 32);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(355, 16);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(95, 29);
            this.txtNVSDT.TabIndex = 7;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(315, 19);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(41, 21);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(225, 16);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(85, 29);
            this.txtNVVaiTro.TabIndex = 5;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(165, 19);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(59, 21);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(90, 16);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(70, 29);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(55, 19);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(36, 21);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(5, 16);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(45, 29);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(1, 19);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(0, 21);
            this.lblNVMa.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(670, 460);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục & Quy Định Cửa Hàng";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNCC.ResumeLayout(false);
            this.tabNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.tabNH.ResumeLayout(false);
            this.tabNH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
