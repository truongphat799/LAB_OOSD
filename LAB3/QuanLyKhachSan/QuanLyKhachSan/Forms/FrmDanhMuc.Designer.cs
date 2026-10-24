namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKhu;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.TabPage tabDV;
        private System.Windows.Forms.TabPage tabQD;

        // Tab Khu vực
        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Label lblKhuTen;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.DataGridView dgvKhu;

        // Tab Nhân viên
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNV;

        // Tab Loại tiện nghi
        private System.Windows.Forms.Label lblLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label lblLoaiTen;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.DataGridView dgvLoaiTN;

        // Tab Dịch vụ
        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label lblDVGia;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDV;

        // Tab Quy định đền bù
        private System.Windows.Forms.Label lblQDMa;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.Label lblQDMucDo;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label lblQDTien;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.DataGridView dgvQD;

        private System.Windows.Forms.Button btnDong;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhu = new System.Windows.Forms.TabPage();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.tabQD = new System.Windows.Forms.TabPage();

            // Tab Khu
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.dgvKhu = new System.Windows.Forms.DataGridView();

            // Tab NV
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();

            // Tab LoaiTN
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.lblLoaiTen = new System.Windows.Forms.Label();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();

            // Tab DV
            this.lblDVMa = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();

            // Tab QD
            this.lblQDMa = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.dgvQD = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabKhu.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.tabLoaiTN.SuspendLayout();
            this.tabDV.SuspendLayout();
            this.tabQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhu);
            this.tabControl.Controls.Add(this.tabNV);
            this.tabControl.Controls.Add(this.tabLoaiTN);
            this.tabControl.Controls.Add(this.tabDV);
            this.tabControl.Controls.Add(this.tabQD);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 470);
            this.tabControl.TabIndex = 0;

            // 
            // tabKhu
            // 
            this.tabKhu.Controls.Add(this.lblKhuMa);
            this.tabKhu.Controls.Add(this.txtKhuMa);
            this.tabKhu.Controls.Add(this.lblKhuTen);
            this.tabKhu.Controls.Add(this.txtKhuTen);
            this.tabKhu.Controls.Add(this.btnThemKhu);
            this.tabKhu.Controls.Add(this.dgvKhu);
            this.tabKhu.Location = new System.Drawing.Point(4, 30);
            this.tabKhu.Name = "tabKhu";
            this.tabKhu.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhu.Size = new System.Drawing.Size(852, 436);
            this.tabKhu.Text = "Khu Vực";
            this.tabKhu.UseVisualStyleBackColor = true;

            this.lblKhuMa.Location = new System.Drawing.Point(20, 20);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(100, 25);
            this.lblKhuMa.Text = "Mã khu vực:";
            this.txtKhuMa.Location = new System.Drawing.Point(120, 18);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(160, 29);

            this.lblKhuTen.Location = new System.Drawing.Point(300, 20);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(100, 25);
            this.lblKhuTen.Text = "Tên khu vực:";
            this.txtKhuTen.Location = new System.Drawing.Point(400, 18);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(220, 29);

            this.btnThemKhu.Location = new System.Drawing.Point(640, 15);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(120, 34);
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);

            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhu.Location = new System.Drawing.Point(20, 65);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.RowHeadersWidth = 30;
            this.dgvKhu.Size = new System.Drawing.Size(810, 350);

            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.lblNVVaiTro);
            this.tabNV.Controls.Add(this.txtNVVaiTro);
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.btnThemNV);
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Location = new System.Drawing.Point(4, 30);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(852, 436);
            this.tabNV.Text = "Nhân Viên";
            this.tabNV.UseVisualStyleBackColor = true;

            this.lblNVMa.Location = new System.Drawing.Point(15, 15);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(65, 25);
            this.lblNVMa.Text = "Mã NV:";
            this.txtNVMa.Location = new System.Drawing.Point(80, 12);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(100, 29);

            this.lblNVTen.Location = new System.Drawing.Point(195, 15);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(65, 25);
            this.lblNVTen.Text = "Họ tên:";
            this.txtNVTen.Location = new System.Drawing.Point(260, 12);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(140, 29);

            this.lblNVVaiTro.Location = new System.Drawing.Point(415, 15);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(65, 25);
            this.lblNVVaiTro.Text = "Vai trò:";
            this.txtNVVaiTro.Location = new System.Drawing.Point(480, 12);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(100, 29);

            this.lblNVSDT.Location = new System.Drawing.Point(595, 15);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(55, 25);
            this.lblNVSDT.Text = "SĐT:";
            this.txtNVSDT.Location = new System.Drawing.Point(650, 12);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(95, 29);

            this.btnThemNV.Location = new System.Drawing.Point(755, 10);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(80, 33);
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);

            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNV.Location = new System.Drawing.Point(15, 55);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersWidth = 30;
            this.dgvNV.Size = new System.Drawing.Size(820, 365);

            // 
            // tabLoaiTN
            // 
            this.tabLoaiTN.Controls.Add(this.lblLoaiMa);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(this.lblLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Location = new System.Drawing.Point(4, 30);
            this.tabLoaiTN.Name = "tabLoaiTN";
            this.tabLoaiTN.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiTN.Size = new System.Drawing.Size(852, 436);
            this.tabLoaiTN.Text = "Loại Tiện Nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;

            this.lblLoaiMa.Location = new System.Drawing.Point(20, 20);
            this.lblLoaiMa.Name = "lblLoaiMa";
            this.lblLoaiMa.Size = new System.Drawing.Size(100, 25);
            this.lblLoaiMa.Text = "Mã loại TN:";
            this.txtLoaiMa.Location = new System.Drawing.Point(120, 18);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(160, 29);

            this.lblLoaiTen.Location = new System.Drawing.Point(300, 20);
            this.lblLoaiTen.Name = "lblLoaiTen";
            this.lblLoaiTen.Size = new System.Drawing.Size(100, 25);
            this.lblLoaiTen.Text = "Tên loại TN:";
            this.txtLoaiTen.Location = new System.Drawing.Point(400, 18);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(220, 29);

            this.btnThemLoaiTN.Location = new System.Drawing.Point(640, 15);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(120, 34);
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);

            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoaiTN.Location = new System.Drawing.Point(20, 65);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.ReadOnly = true;
            this.dgvLoaiTN.RowHeadersWidth = 30;
            this.dgvLoaiTN.Size = new System.Drawing.Size(810, 350);

            // 
            // tabDV
            // 
            this.tabDV.Controls.Add(this.lblDVMa);
            this.tabDV.Controls.Add(this.txtDVMa);
            this.tabDV.Controls.Add(this.lblDVTen);
            this.tabDV.Controls.Add(this.txtDVTen);
            this.tabDV.Controls.Add(this.lblDVDVT);
            this.tabDV.Controls.Add(this.txtDVDVT);
            this.tabDV.Controls.Add(this.lblDVGia);
            this.tabDV.Controls.Add(this.numDVGia);
            this.tabDV.Controls.Add(this.btnThemDV);
            this.tabDV.Controls.Add(this.dgvDV);
            this.tabDV.Location = new System.Drawing.Point(4, 30);
            this.tabDV.Name = "tabDV";
            this.tabDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDV.Size = new System.Drawing.Size(852, 436);
            this.tabDV.Text = "Dịch Vụ";
            this.tabDV.UseVisualStyleBackColor = true;

            this.lblDVMa.Location = new System.Drawing.Point(15, 15);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(65, 25);
            this.lblDVMa.Text = "Mã DV:";
            this.txtDVMa.Location = new System.Drawing.Point(80, 12);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(90, 29);

            this.lblDVTen.Location = new System.Drawing.Point(180, 15);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(60, 25);
            this.lblDVTen.Text = "Tên DV:";
            this.txtDVTen.Location = new System.Drawing.Point(240, 12);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(140, 29);

            this.lblDVDVT.Location = new System.Drawing.Point(390, 15);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(55, 25);
            this.lblDVDVT.Text = "ĐVT:";
            this.txtDVDVT.Location = new System.Drawing.Point(445, 12);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(85, 29);

            this.lblDVGia.Location = new System.Drawing.Point(540, 15);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(65, 25);
            this.lblDVGia.Text = "Đơn giá:";
            this.numDVGia.Location = new System.Drawing.Point(605, 12);
            this.numDVGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(120, 29);

            this.btnThemDV.Location = new System.Drawing.Point(745, 10);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(90, 33);
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);

            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDV.Location = new System.Drawing.Point(15, 55);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 30;
            this.dgvDV.Size = new System.Drawing.Size(820, 365);

            // 
            // tabQD
            // 
            this.tabQD.Controls.Add(this.lblQDMa);
            this.tabQD.Controls.Add(this.txtQDMa);
            this.tabQD.Controls.Add(this.lblQDLoai);
            this.tabQD.Controls.Add(this.cboQDLoai);
            this.tabQD.Controls.Add(this.lblQDMucDo);
            this.tabQD.Controls.Add(this.txtQDMucDo);
            this.tabQD.Controls.Add(this.lblQDTien);
            this.tabQD.Controls.Add(this.numQDTien);
            this.tabQD.Controls.Add(this.btnThemQD);
            this.tabQD.Controls.Add(this.dgvQD);
            this.tabQD.Location = new System.Drawing.Point(4, 30);
            this.tabQD.Name = "tabQD";
            this.tabQD.Padding = new System.Windows.Forms.Padding(3);
            this.tabQD.Size = new System.Drawing.Size(852, 436);
            this.tabQD.Text = "Quy Định Đền Bù";
            this.tabQD.UseVisualStyleBackColor = true;

            this.lblQDMa.Location = new System.Drawing.Point(15, 15);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(65, 25);
            this.lblQDMa.Text = "Mã QĐ:";
            this.txtQDMa.Location = new System.Drawing.Point(80, 12);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(90, 29);

            this.lblQDLoai.Location = new System.Drawing.Point(180, 15);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(70, 25);
            this.lblQDLoai.Text = "Loại TN:";
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.Location = new System.Drawing.Point(250, 12);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(140, 29);

            this.lblQDMucDo.Location = new System.Drawing.Point(400, 15);
            this.lblQDMucDo.Name = "lblQDMucDo";
            this.lblQDMucDo.Size = new System.Drawing.Size(75, 25);
            this.lblQDMucDo.Text = "Mức độ:";
            this.txtQDMucDo.Location = new System.Drawing.Point(475, 12);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(110, 29);

            this.lblQDTien.Location = new System.Drawing.Point(595, 15);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(45, 25);
            this.lblQDTien.Text = "Tiền:";
            this.numQDTien.Location = new System.Drawing.Point(640, 12);
            this.numQDTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(100, 29);

            this.btnThemQD.Location = new System.Drawing.Point(755, 10);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(80, 33);
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);

            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvQD.Location = new System.Drawing.Point(15, 55);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.ReadOnly = true;
            this.dgvQD.RowHeadersWidth = 30;
            this.dgvQD.Size = new System.Drawing.Size(820, 365);

            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(750, 490);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục & Quy Định";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhu.ResumeLayout(false);
            this.tabKhu.PerformLayout();
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();
            this.tabDV.ResumeLayout(false);
            this.tabDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            this.tabQD.ResumeLayout(false);
            this.tabQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
