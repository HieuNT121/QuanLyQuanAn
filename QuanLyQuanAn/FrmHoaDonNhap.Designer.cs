namespace QuanLyQuanAn
{
    partial class FrmHoaDonNhap
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btXuatHoaDon = new System.Windows.Forms.Button();
            this.tbMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.dtgvChiTieu = new System.Windows.Forms.DataGridView();
            this.ColumnMaVatTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã nhân viên";
            // 
            // btXuatHoaDon
            // 
            this.btXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatHoaDon.Location = new System.Drawing.Point(721, 513);
            this.btXuatHoaDon.Name = "btXuatHoaDon";
            this.btXuatHoaDon.Size = new System.Drawing.Size(183, 34);
            this.btXuatHoaDon.TabIndex = 9;
            this.btXuatHoaDon.Text = "Xuất hóa đơn";
            this.btXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // tbMaNhaCungCap
            // 
            this.tbMaNhaCungCap.Location = new System.Drawing.Point(186, 28);
            this.tbMaNhaCungCap.Name = "tbMaNhaCungCap";
            this.tbMaNhaCungCap.Size = new System.Drawing.Size(225, 30);
            this.tbMaNhaCungCap.TabIndex = 18;
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Location = new System.Drawing.Point(186, 80);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(225, 30);
            this.tbMaNhanVien.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tổng tiền";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(198, 515);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(286, 30);
            this.tbTongTien.TabIndex = 21;
            // 
            // dtgvChiTieu
            // 
            this.dtgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVatTU,
            this.ColumnTenVatTu,
            this.ColumnTenNhaCungCap,
            this.ColumnTenNhanVien,
            this.ColumnSoLuong,
            this.ColumnDonGia,
            this.ColumnTongTien});
            this.dtgvChiTieu.Location = new System.Drawing.Point(42, 135);
            this.dtgvChiTieu.Name = "dtgvChiTieu";
            this.dtgvChiTieu.RowHeadersWidth = 51;
            this.dtgvChiTieu.RowTemplate.Height = 24;
            this.dtgvChiTieu.Size = new System.Drawing.Size(926, 348);
            this.dtgvChiTieu.TabIndex = 22;
            // 
            // ColumnMaVatTU
            // 
            this.ColumnMaVatTU.HeaderText = "Mã Vật Tư";
            this.ColumnMaVatTU.MinimumWidth = 6;
            this.ColumnMaVatTU.Name = "ColumnMaVatTU";
            this.ColumnMaVatTU.Width = 80;
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
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.dtgvChiTieu);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.tbMaNhaCungCap);
            this.Controls.Add(this.btXuatHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDonNhap";
            this.Text = "FrmHoaDonThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btXuatHoaDon;
        private System.Windows.Forms.TextBox tbMaNhaCungCap;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.DataGridView dtgvChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVatTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongTien;
    }
}