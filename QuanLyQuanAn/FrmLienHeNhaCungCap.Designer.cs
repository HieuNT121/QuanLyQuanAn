namespace QuanLyQuanAn
{
    partial class FrmLienHeNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLienHeNhaCungCap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenNhaCungCap = new System.Windows.Forms.Label();
            this.tbTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaNhaCungCap,
            this.ColumnTenNhaCungCap,
            this.ColumnSoDienThoai,
            this.ColumnDiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(62, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnMaNhaCungCap
            // 
            this.ColumnMaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.ColumnMaNhaCungCap.MinimumWidth = 6;
            this.ColumnMaNhaCungCap.Name = "ColumnMaNhaCungCap";
            this.ColumnMaNhaCungCap.Width = 125;
            // 
            // ColumnTenNhaCungCap
            // 
            this.ColumnTenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.ColumnTenNhaCungCap.MinimumWidth = 6;
            this.ColumnTenNhaCungCap.Name = "ColumnTenNhaCungCap";
            this.ColumnTenNhaCungCap.Width = 125;
            // 
            // ColumnSoDienThoai
            // 
            this.ColumnSoDienThoai.HeaderText = "Số điện thoại";
            this.ColumnSoDienThoai.MinimumWidth = 6;
            this.ColumnSoDienThoai.Name = "ColumnSoDienThoai";
            this.ColumnSoDienThoai.Width = 125;
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.HeaderText = "Địa chỉ";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            this.ColumnDiaChi.Width = 125;
            // 
            // lbTenNhaCungCap
            // 
            this.lbTenNhaCungCap.AutoSize = true;
            this.lbTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhaCungCap.Location = new System.Drawing.Point(659, 54);
            this.lbTenNhaCungCap.Name = "lbTenNhaCungCap";
            this.lbTenNhaCungCap.Size = new System.Drawing.Size(172, 28);
            this.lbTenNhaCungCap.TabIndex = 7;
            this.lbTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // tbTenNhaCungCap
            // 
            this.tbTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhaCungCap.Location = new System.Drawing.Point(664, 105);
            this.tbTenNhaCungCap.Name = "tbTenNhaCungCap";
            this.tbTenNhaCungCap.Size = new System.Drawing.Size(219, 30);
            this.tbTenNhaCungCap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin nhà cung cấp";
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Image = ((System.Drawing.Image)(resources.GetObject("btTim.Image")));
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(664, 177);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(103, 40);
            this.btTim.TabIndex = 22;
            this.btTim.Text = "    Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // FrmLienHeNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenNhaCungCap);
            this.Controls.Add(this.lbTenNhaCungCap);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLienHeNhaCungCap";
            this.Text = "FrmCapNhatThongTinHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTenNhaCungCap;
        private System.Windows.Forms.TextBox tbTenNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
        private System.Windows.Forms.Button btTim;
    }
}