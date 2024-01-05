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
            this.lbThongBao = new System.Windows.Forms.Label();
            this.dGVThongBao = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.ColumnMaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuhnTenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuongToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.BackColor = System.Drawing.Color.White;
            this.lbThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbThongBao.Location = new System.Drawing.Point(123, 41);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(152, 16);
            this.lbThongBao.TabIndex = 0;
            this.lbThongBao.Text = "Danh sách vật tư sắp hết";
            // 
            // dGVThongBao
            // 
            this.dGVThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaHangHoa,
            this.ColuhnTenHangHoa,
            this.ColumnMaNhaCungCap,
            this.ColumnSoLuong,
            this.ColumnSoLuongToiThieu});
            this.dGVThongBao.Location = new System.Drawing.Point(115, 94);
            this.dGVThongBao.Name = "dGVThongBao";
            this.dGVThongBao.RowHeadersWidth = 51;
            this.dGVThongBao.RowTemplate.Height = 24;
            this.dGVThongBao.Size = new System.Drawing.Size(698, 346);
            this.dGVThongBao.TabIndex = 2;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(609, 482);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(136, 36);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
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
            // FrmXuLyHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dGVThongBao);
            this.Controls.Add(this.lbThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXuLyHangTon";
            this.Text = "FrmXuLyHangTon";
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.DataGridView dGVThongBao;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuhnTenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuongToiThieu;
    }
}