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
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.lbTenNhaCungCap = new System.Windows.Forms.Label();
            this.tbTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(62, 90);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(550, 395);
            this.dgvNhaCungCap.TabIndex = 1;
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
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            // FrmLienHeNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tbTenNhaCungCap);
            this.Controls.Add(this.lbTenNhaCungCap);
            this.Controls.Add(this.dgvNhaCungCap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLienHeNhaCungCap";
            this.Text = "FrmCapNhatThongTinHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.Label lbTenNhaCungCap;
        private System.Windows.Forms.TextBox tbTenNhaCungCap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
    }
}