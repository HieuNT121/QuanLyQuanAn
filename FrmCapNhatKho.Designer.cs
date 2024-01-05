namespace QuanLyQuanAn
{
    partial class FrmCapNhatKho
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
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaVatTu = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbMaNhaCungCap = new System.Windows.Forms.Label();
            this.tbTenVatTu = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Location = new System.Drawing.Point(71, 144);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(96, 16);
            this.lbTenNhanVien.TabIndex = 1;
            this.lbTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // lbMaVatTu
            // 
            this.lbMaVatTu.AutoSize = true;
            this.lbMaVatTu.Location = new System.Drawing.Point(71, 48);
            this.lbMaVatTu.Name = "lbMaVatTu";
            this.lbMaVatTu.Size = new System.Drawing.Size(60, 16);
            this.lbMaVatTu.TabIndex = 2;
            this.lbMaVatTu.Text = "Mã vật tư";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(71, 82);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbMaNhaCungCap
            // 
            this.lbMaNhaCungCap.AutoSize = true;
            this.lbMaNhaCungCap.Location = new System.Drawing.Point(71, 110);
            this.lbMaNhaCungCap.Name = "lbMaNhaCungCap";
            this.lbMaNhaCungCap.Size = new System.Drawing.Size(109, 16);
            this.lbMaNhaCungCap.TabIndex = 4;
            this.lbMaNhaCungCap.Text = "Mã nhà cung cấp";
            // 
            // tbTenVatTu
            // 
            this.tbTenVatTu.Location = new System.Drawing.Point(229, 48);
            this.tbTenVatTu.Name = "tbTenVatTu";
            this.tbTenVatTu.Size = new System.Drawing.Size(370, 22);
            this.tbTenVatTu.TabIndex = 5;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(229, 82);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(370, 22);
            this.tbSoLuong.TabIndex = 6;
            // 
            // tbTenNhaCungCap
            // 
            this.tbTenNhaCungCap.Location = new System.Drawing.Point(229, 110);
            this.tbTenNhaCungCap.Name = "tbTenNhaCungCap";
            this.tbTenNhaCungCap.Size = new System.Drawing.Size(370, 22);
            this.tbTenNhaCungCap.TabIndex = 7;
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(229, 144);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(370, 22);
            this.tbTenNhanVien.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(729, 571);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 44);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVatTu,
            this.ColumnTenVatTu,
            this.ColumnSoLuong,
            this.ColumnMaNhaCungCap,
            this.ColumnTenNhanVien,
            this.ColumnTrangThai,
            this.ColumnThoiGian});
            this.dataGridView1.Location = new System.Drawing.Point(74, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 307);
            this.dataGridView1.TabIndex = 12;
            // 
            // ColumnMaVatTu
            // 
            this.ColumnMaVatTu.HeaderText = "Mã Vật Tư";
            this.ColumnMaVatTu.MinimumWidth = 6;
            this.ColumnMaVatTu.Name = "ColumnMaVatTu";
            this.ColumnMaVatTu.Width = 125;
            // 
            // ColumnTenVatTu
            // 
            this.ColumnTenVatTu.HeaderText = "Tên Vật Tư";
            this.ColumnTenVatTu.MinimumWidth = 6;
            this.ColumnTenVatTu.Name = "ColumnTenVatTu";
            this.ColumnTenVatTu.Width = 125;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.Width = 125;
            // 
            // ColumnMaNhaCungCap
            // 
            this.ColumnMaNhaCungCap.HeaderText = "Mã Nhà cung cấp";
            this.ColumnMaNhaCungCap.MinimumWidth = 6;
            this.ColumnMaNhaCungCap.Name = "ColumnMaNhaCungCap";
            this.ColumnMaNhaCungCap.Width = 125;
            // 
            // ColumnTenNhanVien
            // 
            this.ColumnTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.ColumnTenNhanVien.MinimumWidth = 6;
            this.ColumnTenNhanVien.Name = "ColumnTenNhanVien";
            this.ColumnTenNhanVien.Width = 125;
            // 
            // ColumnTrangThai
            // 
            this.ColumnTrangThai.HeaderText = "Trạng thái";
            this.ColumnTrangThai.MinimumWidth = 6;
            this.ColumnTrangThai.Name = "ColumnTrangThai";
            this.ColumnTrangThai.Width = 125;
            // 
            // ColumnThoiGian
            // 
            this.ColumnThoiGian.HeaderText = "Thời Gian";
            this.ColumnThoiGian.MinimumWidth = 6;
            this.ColumnThoiGian.Name = "ColumnThoiGian";
            this.ColumnThoiGian.Width = 125;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(71, 185);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(118, 16);
            this.lbTinhTrang.TabIndex = 13;
            this.lbTinhTrang.Text = "Trình Trạng Vật Tư";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhập",
            "Xuất",
            "Hết hạn"});
            this.comboBox1.Location = new System.Drawing.Point(229, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(892, 571);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 44);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // FrmNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1140, 688);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTenNhanVien);
            this.Controls.Add(this.tbTenNhaCungCap);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbTenVatTu);
            this.Controls.Add(this.lbMaNhaCungCap);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbMaVatTu);
            this.Controls.Add(this.lbTenNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhapXuat";
            this.Text = "FrmNhapXuat";
            this.Load += new System.EventHandler(this.FrmNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaVatTu;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMaNhaCungCap;
        private System.Windows.Forms.TextBox tbTenVatTu;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbTenNhaCungCap;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThoiGian;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapNhat;
    }
}