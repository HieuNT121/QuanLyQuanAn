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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTenNhaCungCap = new System.Windows.Forms.Label();
            this.tbTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.ColumnMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaNhaCungCap,
            this.ColumnTenNhaCungCap,
            this.ColumnSDT,
            this.ColumnDiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(62, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbTenNhaCungCap
            // 
            this.lbTenNhaCungCap.AutoSize = true;
            this.lbTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhaCungCap.Location = new System.Drawing.Point(659, 63);
            this.lbTenNhaCungCap.Name = "lbTenNhaCungCap";
            this.lbTenNhaCungCap.Size = new System.Drawing.Size(172, 28);
            this.lbTenNhaCungCap.TabIndex = 7;
            this.lbTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // tbTenNhaCungCap
            // 
            this.tbTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhaCungCap.Location = new System.Drawing.Point(664, 106);
            this.tbTenNhaCungCap.Name = "tbTenNhaCungCap";
            this.tbTenNhaCungCap.Size = new System.Drawing.Size(219, 30);
            this.tbTenNhaCungCap.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(664, 167);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 40);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // ColumnMaNhaCungCap
            // 
            this.ColumnMaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.ColumnMaNhaCungCap.MinimumWidth = 6;
            this.ColumnMaNhaCungCap.Name = "ColumnMaNhaCungCap";
            this.ColumnMaNhaCungCap.Width = 125;
            // 
            // ColumnTenNhaCungCap
            // 
            this.ColumnTenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            this.ColumnTenNhaCungCap.MinimumWidth = 6;
            this.ColumnTenNhaCungCap.Name = "ColumnTenNhaCungCap";
            this.ColumnTenNhaCungCap.Width = 125;
            // 
            // ColumnSDT
            // 
            this.ColumnSDT.HeaderText = "SĐT";
            this.ColumnSDT.MinimumWidth = 6;
            this.ColumnSDT.Name = "ColumnSDT";
            this.ColumnSDT.Width = 125;
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.HeaderText = "Địa Chỉ";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            this.ColumnDiaChi.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin nhà cung cấp";
            // 
            // FrmCapNhatThongTinHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tbTenNhaCungCap);
            this.Controls.Add(this.lbTenNhaCungCap);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapNhatThongTinHangHoa";
            this.Text = "FrmCapNhatThongTinHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTenNhaCungCap;
        private System.Windows.Forms.TextBox tbTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
    }
}