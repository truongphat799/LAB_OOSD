namespace QuanLyThuVien.Forms
{
    partial class FrmSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.Controls.Add(this.btnLamMoi);
            this.panelTop.Controls.Add(this.btnXoa);
            this.panelTop.Controls.Add(this.btnCapNhat);
            this.panelTop.Controls.Add(this.btnThem);
            this.panelTop.Controls.Add(this.cboNXB);
            this.panelTop.Controls.Add(this.lblNXB);
            this.panelTop.Controls.Add(this.cboTheLoai);
            this.panelTop.Controls.Add(this.lblTheLoai);
            this.panelTop.Controls.Add(this.numSoLuong);
            this.panelTop.Controls.Add(this.lblSoLuong);
            this.panelTop.Controls.Add(this.numNam);
            this.panelTop.Controls.Add(this.lblNam);
            this.panelTop.Controls.Add(this.txtTen);
            this.panelTop.Controls.Add(this.lblTen);
            this.panelTop.Controls.Add(this.txtMa);
            this.panelTop.Controls.Add(this.lblMa);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1120, 160);
            this.panelTop.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(340, 110);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 35);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(235, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(130, 110);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 35);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboNXB
            // 
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(740, 60);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(200, 25);
            this.cboNXB.TabIndex = 11;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(650, 63);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(60, 17);
            this.lblNXB.TabIndex = 10;
            this.lblNXB.Text = "Mã NXB:";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(400, 60);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(200, 25);
            this.cboTheLoai.TabIndex = 9;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(325, 63);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(57, 17);
            this.lblTheLoai.TabIndex = 8;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(110, 60);
            this.numSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(160, 25);
            this.numSoLuong.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 63);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(740, 20);
            this.numNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(120, 25);
            this.numNam.TabIndex = 5;
            this.numNam.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(650, 23);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(59, 17);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Năm XB:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(400, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 25);
            this.txtTen.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(325, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(61, 17);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên sách:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(110, 20);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(160, 25);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 23);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(86, 17);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã đầu sách:";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Lavender;
            this.panelSearch.Controls.Add(this.btnTim);
            this.panelSearch.Controls.Add(this.txtTim);
            this.panelSearch.Controls.Add(this.lblTim);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 160);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1120, 50);
            this.panelSearch.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(400, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 32);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(140, 12);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(240, 25);
            this.txtTim.TabIndex = 1;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(20, 15);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(115, 17);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Từ khóa tìm kiếm:";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 210);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 30;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1120, 475);
            this.dgvSach.TabIndex = 2;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDong);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 685);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1120, 55);
            this.panelBottom.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1005, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý đầu sách";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDong;
    }
}
