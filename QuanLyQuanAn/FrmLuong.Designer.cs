namespace QuanLyQuanAn
{
    partial class FrmLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLuong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.dtgvLuong = new System.Windows.Forms.DataGridView();
            this.ColumnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê tiền lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(172, 108);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(34, 24);
            this.cbThang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbNam.Location = new System.Drawing.Point(339, 107);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(73, 24);
            this.cbNam.TabIndex = 4;
            // 
            // dtgvLuong
            // 
            this.dtgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaNhanVien,
            this.ColumnTenNhanVien,
            this.ColumnChucVu,
            this.ColumnLuongCoBan,
            this.ColumnSoGio,
            this.ColumnTongLuong});
            this.dtgvLuong.Location = new System.Drawing.Point(77, 189);
            this.dtgvLuong.Name = "dtgvLuong";
            this.dtgvLuong.RowHeadersWidth = 51;
            this.dtgvLuong.RowTemplate.Height = 24;
            this.dtgvLuong.Size = new System.Drawing.Size(849, 350);
            this.dtgvLuong.TabIndex = 5;
            // 
            // ColumnMaNhanVien
            // 
            this.ColumnMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.ColumnMaNhanVien.MinimumWidth = 6;
            this.ColumnMaNhanVien.Name = "ColumnMaNhanVien";
            this.ColumnMaNhanVien.Width = 125;
            // 
            // ColumnTenNhanVien
            // 
            this.ColumnTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.ColumnTenNhanVien.MinimumWidth = 6;
            this.ColumnTenNhanVien.Name = "ColumnTenNhanVien";
            this.ColumnTenNhanVien.Width = 125;
            // 
            // ColumnChucVu
            // 
            this.ColumnChucVu.HeaderText = "Chức vụ";
            this.ColumnChucVu.MinimumWidth = 6;
            this.ColumnChucVu.Name = "ColumnChucVu";
            this.ColumnChucVu.Width = 125;
            // 
            // ColumnLuongCoBan
            // 
            this.ColumnLuongCoBan.HeaderText = "Lương Cơ Bản";
            this.ColumnLuongCoBan.MinimumWidth = 6;
            this.ColumnLuongCoBan.Name = "ColumnLuongCoBan";
            this.ColumnLuongCoBan.Width = 125;
            // 
            // ColumnSoGio
            // 
            this.ColumnSoGio.HeaderText = "Số Giờ";
            this.ColumnSoGio.MinimumWidth = 6;
            this.ColumnSoGio.Name = "ColumnSoGio";
            this.ColumnSoGio.Width = 125;
            // 
            // ColumnTongLuong
            // 
            this.ColumnTongLuong.HeaderText = "Tổng Tiền Nhận được";
            this.ColumnTongLuong.MinimumWidth = 6;
            this.ColumnTongLuong.Name = "ColumnTongLuong";
            this.ColumnTongLuong.Width = 170;
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btHienThi.Image")));
            this.btHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienThi.Location = new System.Drawing.Point(463, 108);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(115, 31);
            this.btHienThi.TabIndex = 7;
            this.btHienThi.Text = "      Hiển Thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            // 
            // FrmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.dtgvLuong);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLuong";
            this.Text = "FrmLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.DataGridView dtgvLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongLuong;
        private System.Windows.Forms.Button btHienThi;
    }
}