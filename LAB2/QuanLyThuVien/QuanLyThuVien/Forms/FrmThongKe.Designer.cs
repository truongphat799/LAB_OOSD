namespace QuanLyThuVien.Forms
{
    partial class FrmThongKe
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblTu = new System.Windows.Forms.Label();
            this.panelKPI = new System.Windows.Forms.Panel();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblMuon = new System.Windows.Forms.Label();
            this.dgvPhat = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelKPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.Controls.Add(this.btnThongKe);
            this.panelTop.Controls.Add(this.dtDen);
            this.panelTop.Controls.Add(this.lblDen);
            this.panelTop.Controls.Add(this.dtTu);
            this.panelTop.Controls.Add(this.lblTu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1070, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(540, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 36);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(340, 18);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(160, 25);
            this.dtDen.TabIndex = 3;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(270, 21);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(66, 17);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(85, 18);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(160, 25);
            this.dtTu.TabIndex = 1;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(20, 21);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(58, 17);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // panelKPI
            // 
            this.panelKPI.BackColor = System.Drawing.Color.GhostWhite;
            this.panelKPI.Controls.Add(this.lblPhiPhat);
            this.panelKPI.Controls.Add(this.lblHuHong);
            this.panelKPI.Controls.Add(this.lblMat);
            this.panelKPI.Controls.Add(this.lblQuaHan);
            this.panelKPI.Controls.Add(this.lblMuon);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKPI.Location = new System.Drawing.Point(0, 60);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Size = new System.Drawing.Size(1070, 70);
            this.panelKPI.TabIndex = 1;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPhiPhat.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhiPhat.Location = new System.Drawing.Point(750, 25);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(125, 19);
            this.lblPhiPhat.TabIndex = 4;
            this.lblPhiPhat.Text = "Tổng phí phạt: 0 đ";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHuHong.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHuHong.Location = new System.Drawing.Point(580, 25);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(117, 19);
            this.lblHuHong.TabIndex = 3;
            this.lblHuHong.Text = "Sách hư hỏng: 0";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMat.ForeColor = System.Drawing.Color.Crimson;
            this.lblMat.Location = new System.Drawing.Point(440, 25);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(84, 19);
            this.lblMat.TabIndex = 2;
            this.lblMat.Text = "Sách mất: 0";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuaHan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblQuaHan.Location = new System.Drawing.Point(260, 25);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(111, 19);
            this.lblQuaHan.TabIndex = 1;
            this.lblQuaHan.Text = "Sách quá hạn: 0";
            // 
            // lblMuon
            // 
            this.lblMuon.AutoSize = true;
            this.lblMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMuon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMuon.Location = new System.Drawing.Point(25, 25);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(155, 19);
            this.lblMuon.TabIndex = 0;
            this.lblMuon.Text = "Lượt sách mượn: 0";
            // 
            // dgvPhat
            // 
            this.dgvPhat.AllowUserToAddRows = false;
            this.dgvPhat.AllowUserToDeleteRows = false;
            this.dgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhat.Location = new System.Drawing.Point(0, 130);
            this.dgvPhat.MultiSelect = false;
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.ReadOnly = true;
            this.dgvPhat.RowHeadersWidth = 30;
            this.dgvPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhat.Size = new System.Drawing.Size(1070, 515);
            this.dgvPhat.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDong);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 645);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1070, 55);
            this.panelBottom.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(955, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.panelKPI);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelKPI.ResumeLayout(false);
            this.panelKPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panelKPI;
        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.DataGridView dgvPhat;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDong;
    }
}
