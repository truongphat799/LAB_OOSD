namespace QuanLyCuaHangEShopping.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridView dgvBanChay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            this.SuspendLayout();

            this.dtTu.Location = new System.Drawing.Point(80, 20);
            this.dtTu.Size = new System.Drawing.Size(160, 22);

            this.dtDen.Location = new System.Drawing.Point(320, 20);
            this.dtDen.Size = new System.Drawing.Size(160, 22);

            this.btnThongKe.Location = new System.Drawing.Point(500, 16);
            this.btnThongKe.Size = new System.Drawing.Size(120, 30);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            this.dgvTongHop.Location = new System.Drawing.Point(12, 60);
            this.dgvTongHop.Size = new System.Drawing.Size(760, 120);
            this.dgvTongHop.ReadOnly = true;

            this.dgvBanChay.Location = new System.Drawing.Point(12, 200);
            this.dgvBanChay.Size = new System.Drawing.Size(760, 200);
            this.dgvBanChay.ReadOnly = true;

            this.btnDong.Location = new System.Drawing.Point(670, 415);
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.dgvBanChay);
            this.Controls.Add(this.btnDong);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shopping - Báo cáo & Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            this.ResumeLayout(false);
        }
    }
}