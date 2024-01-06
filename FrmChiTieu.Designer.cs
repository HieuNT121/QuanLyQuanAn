namespace QuanLyQuanAn
{
    partial class FrmChiTieu
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTongCong = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ColumnMaVatTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(616, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Những vật tư đã nhập:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVatTU,
            this.ColumnTenVatTu,
            this.ColumnTenNhaCungCap,
            this.ColumnTenNhanVien,
            this.ColumnSoLuong,
            this.ColumnDonGia,
            this.ColumnTongTien});
            this.dataGridView1.Location = new System.Drawing.Point(78, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 365);
            this.dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(833, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng cộng:";
            // 
            // tbTongCong
            // 
            this.tbTongCong.Location = new System.Drawing.Point(972, 587);
            this.tbTongCong.Name = "tbTongCong";
            this.tbTongCong.Size = new System.Drawing.Size(150, 22);
            this.tbTongCong.TabIndex = 9;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(804, 99);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(89, 32);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1138, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "VND";
            // 
            // ColumnMaVatTU
            // 
            this.ColumnMaVatTU.HeaderText = "Mã Vật Tư";
            this.ColumnMaVatTU.MinimumWidth = 6;
            this.ColumnMaVatTU.Name = "ColumnMaVatTU";
            this.ColumnMaVatTU.Width = 75;
            // 
            // ColumnTenVatTu
            // 
            this.ColumnTenVatTu.HeaderText = "Tên Vật Tư";
            this.ColumnTenVatTu.MinimumWidth = 6;
            this.ColumnTenVatTu.Name = "ColumnTenVatTu";
            this.ColumnTenVatTu.Width = 150;
            // 
            // ColumnTenNhaCungCap
            // 
            this.ColumnTenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            this.ColumnTenNhaCungCap.MinimumWidth = 6;
            this.ColumnTenNhaCungCap.Name = "ColumnTenNhaCungCap";
            this.ColumnTenNhaCungCap.Width = 200;
            // 
            // ColumnTenNhanVien
            // 
            this.ColumnTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.ColumnTenNhanVien.MinimumWidth = 6;
            this.ColumnTenNhanVien.Name = "ColumnTenNhanVien";
            this.ColumnTenNhanVien.Width = 150;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.Width = 75;
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.HeaderText = "Đơn Giá";
            this.ColumnDonGia.MinimumWidth = 6;
            this.ColumnDonGia.Name = "ColumnDonGia";
            this.ColumnDonGia.Width = 125;
            // 
            // ColumnTongTien
            // 
            this.ColumnTongTien.HeaderText = "Tổng Tiền";
            this.ColumnTongTien.MinimumWidth = 6;
            this.ColumnTongTien.Name = "ColumnTongTien";
            this.ColumnTongTien.Width = 125;
            // 
            // FrmChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1209, 644);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.tbTongCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChiTieu";
            this.Text = "FrmChiTieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTongCong;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVatTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongTien;
    }
}