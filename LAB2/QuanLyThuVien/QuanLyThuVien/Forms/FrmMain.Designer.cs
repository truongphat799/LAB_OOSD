namespace QuanLyThuVien.Forms
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.Controls.Add(this.btnDanhMuc);
            this.panelMenu.Controls.Add(this.btnSach);
            this.panelMenu.Controls.Add(this.btnDocGia);
            this.panelMenu.Controls.Add(this.btnMuonTra);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Location = new System.Drawing.Point(120, 110);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(540, 290);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDanhMuc.Location = new System.Drawing.Point(10, 15);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(240, 65);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục / Nhân viên";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSach.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSach.Location = new System.Drawing.Point(290, 15);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(240, 65);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Quản lý đầu sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnDocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDocGia.Location = new System.Drawing.Point(10, 105);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(240, 65);
            this.btnDocGia.TabIndex = 2;
            this.btnDocGia.Text = "Độc giả và thẻ";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnMuonTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuonTra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMuonTra.Location = new System.Drawing.Point(290, 105);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(240, 65);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.Text = "Mượn - Trả sách";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThongKe.Location = new System.Drawing.Point(10, 195);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(240, 65);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Location = new System.Drawing.Point(290, 195);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(240, 65);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}
