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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLuaChon = new System.Windows.Forms.ComboBox();
            this.tbThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(488, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn tìm kiếm";
            // 
            // cbLuaChon
            // 
            this.cbLuaChon.FormattingEnabled = true;
            this.cbLuaChon.Items.AddRange(new object[] {
            "Mã Vật Tư",
            "Tên Vật Tư",
            "Nhà Cung Cấp",
            "Số Lượng"});
            this.cbLuaChon.Location = new System.Drawing.Point(181, 67);
            this.cbLuaChon.Name = "cbLuaChon";
            this.cbLuaChon.Size = new System.Drawing.Size(258, 24);
            this.cbLuaChon.TabIndex = 2;
            // 
            // tbThongTinTimKiem
            // 
            this.tbThongTinTimKiem.Location = new System.Drawing.Point(181, 109);
            this.tbThongTinTimKiem.Name = "tbThongTinTimKiem";
            this.tbThongTinTimKiem.Size = new System.Drawing.Size(258, 22);
            this.tbThongTinTimKiem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVatTu,
            this.ColumnTenVatTu,
            this.ColumnNhaCungCap,
            this.ColumnSoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(42, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 373);
            this.dataGridView1.TabIndex = 5;
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
            this.lbTitle.Location = new System.Drawing.Point(54, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(148, 16);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Tìm kiếm thông tin vật tư";
            // 
            // FrmSapXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbThongTinTimKiem);
            this.Controls.Add(this.cbLuaChon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSapXepHang";
            this.Text = "FrmSapXepHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLuaChon;
        private System.Windows.Forms.TextBox tbThongTinTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.Label lbTitle;
    }
}