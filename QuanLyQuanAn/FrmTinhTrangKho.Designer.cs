namespace QuanLyQuanAn
{
    partial class FrmTinhTrangKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTinhTrangKho));
            this.lbThongBao = new System.Windows.Forms.Label();
            this.dtgvTinhTrangKho = new System.Windows.Forms.DataGridView();
            this.ColumnMaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuhnTenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuongToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.BackColor = System.Drawing.Color.White;
            this.lbThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbThongBao.Location = new System.Drawing.Point(121, 42);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(225, 28);
            this.lbThongBao.TabIndex = 0;
            this.lbThongBao.Text = "Danh sách vật tư sắp hết";
            // 
            // dtgvTinhTrangKho
            // 
            this.dtgvTinhTrangKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTinhTrangKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaHangHoa,
            this.ColuhnTenHangHoa,
            this.ColumnMaNhaCungCap,
            this.ColumnSoLuong,
            this.ColumnSoLuongToiThieu});
            this.dtgvTinhTrangKho.Location = new System.Drawing.Point(115, 94);
            this.dtgvTinhTrangKho.Name = "dtgvTinhTrangKho";
            this.dtgvTinhTrangKho.RowHeadersWidth = 51;
            this.dtgvTinhTrangKho.RowTemplate.Height = 24;
            this.dtgvTinhTrangKho.Size = new System.Drawing.Size(698, 346);
            this.dtgvTinhTrangKho.TabIndex = 2;
            // 
            // ColumnMaHangHoa
            // 
            this.ColumnMaHangHoa.HeaderText = "Mã hàng hóa";
            this.ColumnMaHangHoa.MinimumWidth = 6;
            this.ColumnMaHangHoa.Name = "ColumnMaHangHoa";
            this.ColumnMaHangHoa.Width = 125;
            // 
            // ColuhnTenHangHoa
            // 
            this.ColuhnTenHangHoa.HeaderText = "Tên hàng hóa";
            this.ColuhnTenHangHoa.MinimumWidth = 6;
            this.ColuhnTenHangHoa.Name = "ColuhnTenHangHoa";
            this.ColuhnTenHangHoa.Width = 125;
            // 
            // ColumnMaNhaCungCap
            // 
            this.ColumnMaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.ColumnMaNhaCungCap.MinimumWidth = 6;
            this.ColumnMaNhaCungCap.Name = "ColumnMaNhaCungCap";
            this.ColumnMaNhaCungCap.Width = 145;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.Width = 125;
            // 
            // ColumnSoLuongToiThieu
            // 
            this.ColumnSoLuongToiThieu.HeaderText = "Số lượng tối thiểu";
            this.ColumnSoLuongToiThieu.MinimumWidth = 6;
            this.ColumnSoLuongToiThieu.Name = "ColumnSoLuongToiThieu";
            this.ColumnSoLuongToiThieu.Width = 125;
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btHienThi.Image")));
            this.btHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienThi.Location = new System.Drawing.Point(698, 463);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(115, 31);
            this.btHienThi.TabIndex = 7;
            this.btHienThi.Text = "      Hiển Thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            // 
            // FrmTinhTrangKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.dtgvTinhTrangKho);
            this.Controls.Add(this.lbThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTinhTrangKho";
            this.Text = "FrmXuLyHangTon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.DataGridView dtgvTinhTrangKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuhnTenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuongToiThieu;
        private System.Windows.Forms.Button btHienThi;
    }
}