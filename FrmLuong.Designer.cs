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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 51);
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
            this.label2.Location = new System.Drawing.Point(349, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(424, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBox2.Location = new System.Drawing.Point(561, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaNhanVien,
            this.ColumnTenNhanVien,
            this.ColumnChucVu,
            this.ColumnLuongCoBan,
            this.ColumnSoGio,
            this.ColumnTongLuong});
            this.dataGridView1.Location = new System.Drawing.Point(77, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(849, 350);
            this.dataGridView1.TabIndex = 5;
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
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(709, 107);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 31);
            this.btnHienThi.TabIndex = 6;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // FrmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLuong";
            this.Text = "FrmLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongLuong;
    }
}