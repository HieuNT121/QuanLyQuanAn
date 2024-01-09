namespace QuanLyQuanAn
{
    partial class FrmTimKiemVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemVatTu));
            this.label1 = new System.Windows.Forms.Label();
            this.cbLuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.tbThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvTimKiemVatTu = new System.Windows.Forms.DataGridView();
            this.ColumnMaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiemVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn tìm kiếm";
            // 
            // cbLuaChonTimKiem
            // 
            this.cbLuaChonTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLuaChonTimKiem.FormattingEnabled = true;
            this.cbLuaChonTimKiem.Items.AddRange(new object[] {
            "Mã Vật Tư",
            "Tên Vật Tư",
            "Nhà Cung Cấp",
            "Số Lượng"});
            this.cbLuaChonTimKiem.Location = new System.Drawing.Point(215, 77);
            this.cbLuaChonTimKiem.Name = "cbLuaChonTimKiem";
            this.cbLuaChonTimKiem.Size = new System.Drawing.Size(258, 31);
            this.cbLuaChonTimKiem.TabIndex = 2;
            // 
            // tbThongTinTimKiem
            // 
            this.tbThongTinTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThongTinTimKiem.Location = new System.Drawing.Point(215, 123);
            this.tbThongTinTimKiem.Name = "tbThongTinTimKiem";
            this.tbThongTinTimKiem.Size = new System.Drawing.Size(258, 30);
            this.tbThongTinTimKiem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin tìm kiếm";
            // 
            // dtgvTimKiemVatTu
            // 
            this.dtgvTimKiemVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimKiemVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVatTu,
            this.ColumnTenVatTu,
            this.ColumnNhaCungCap,
            this.ColumnSoLuong});
            this.dtgvTimKiemVatTu.Location = new System.Drawing.Point(45, 203);
            this.dtgvTimKiemVatTu.Name = "dtgvTimKiemVatTu";
            this.dtgvTimKiemVatTu.RowHeadersWidth = 51;
            this.dtgvTimKiemVatTu.RowTemplate.Height = 24;
            this.dtgvTimKiemVatTu.Size = new System.Drawing.Size(554, 373);
            this.dtgvTimKiemVatTu.TabIndex = 5;
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
            // ColumnNhaCungCap
            // 
            this.ColumnNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.ColumnNhaCungCap.MinimumWidth = 6;
            this.ColumnNhaCungCap.Name = "ColumnNhaCungCap";
            this.ColumnNhaCungCap.Width = 125;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.Width = 125;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(37, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(329, 38);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Tìm kiếm thông tin vật tư";
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Image = ((System.Drawing.Image)(resources.GetObject("btTim.Image")));
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(496, 113);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(103, 40);
            this.btTim.TabIndex = 23;
            this.btTim.Text = "    Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // FrmTimKiemVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtgvTimKiemVatTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbThongTinTimKiem);
            this.Controls.Add(this.cbLuaChonTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimKiemVatTu";
            this.Text = "FrmSapXepHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiemVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLuaChonTimKiem;
        private System.Windows.Forms.TextBox tbThongTinTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTimKiemVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btTim;
    }
}