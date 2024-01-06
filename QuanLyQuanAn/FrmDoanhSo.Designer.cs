namespace QuanLyQuanAn
{
    partial class FrmDoanhSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoanhSo));
            this.elipseControl1 = new QuanLyQuanAn.elipseControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtgvDoanhSo = new System.Windows.Forms.DataGridView();
            this.Ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoi_gian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThongKe = new System.Windows.Forms.Button();
            this.TongDoanhThu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.dtpkNgayBatDau);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dtpkNgayKetThuc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh thu từ ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpkNgayBatDau
            // 
            this.dtpkNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayBatDau.Location = new System.Drawing.Point(185, 3);
            this.dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            this.dtpkNgayBatDau.Size = new System.Drawing.Size(299, 28);
            this.dtpkNgayBatDau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(490, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(589, 3);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(292, 28);
            this.dtpkNgayKetThuc.TabIndex = 4;
            // 
            // dtgvDoanhSo
            // 
            this.dtgvDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ban,
            this.Tong_Tien,
            this.Thoi_gian,
            this.Ngay});
            this.dtgvDoanhSo.Location = new System.Drawing.Point(172, 135);
            this.dtgvDoanhSo.Name = "dtgvDoanhSo";
            this.dtgvDoanhSo.RowHeadersWidth = 51;
            this.dtgvDoanhSo.RowTemplate.Height = 24;
            this.dtgvDoanhSo.Size = new System.Drawing.Size(677, 339);
            this.dtgvDoanhSo.TabIndex = 1;
            // 
            // Ban
            // 
            this.Ban.HeaderText = "Bàn số";
            this.Ban.MinimumWidth = 6;
            this.Ban.Name = "Ban";
            this.Ban.Width = 90;
            // 
            // Tong_Tien
            // 
            this.Tong_Tien.HeaderText = "Tổng Tiền";
            this.Tong_Tien.MinimumWidth = 6;
            this.Tong_Tien.Name = "Tong_Tien";
            this.Tong_Tien.Width = 170;
            // 
            // Thoi_gian
            // 
            this.Thoi_gian.HeaderText = "Thời gian";
            this.Thoi_gian.MinimumWidth = 6;
            this.Thoi_gian.Name = "Thoi_gian";
            this.Thoi_gian.Width = 150;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 210;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btThongKe.Image")));
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.Location = new System.Drawing.Point(436, 81);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(130, 36);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "   Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSize = true;
            this.TongDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.TongDoanhThu.Location = new System.Drawing.Point(271, 517);
            this.TongDoanhThu.Name = "TongDoanhThu";
            this.TongDoanhThu.Size = new System.Drawing.Size(145, 25);
            this.TongDoanhThu.TabIndex = 3;
            this.TongDoanhThu.Text = "Tổng doanh thu";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(422, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 31);
            this.textBox1.TabIndex = 4;
            // 
            // FrmDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TongDoanhThu);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.dtgvDoanhSo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoanhSo";
            this.Text = "FrmDoanhThu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private elipseControl elipseControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkNgayBatDau;
        private System.Windows.Forms.DataGridView dtgvDoanhSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.Label TongDoanhThu;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoi_gian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.TextBox textBox1;
    }
}