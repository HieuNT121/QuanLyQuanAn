namespace QuanLyQuanAn
{
    partial class FrmDanhSachMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachMonAn));
            this.dtgvMonAn = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.txtGiaCa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMon,
            this.PhanLoai,
            this.GiaCa});
            this.dtgvMonAn.Location = new System.Drawing.Point(40, 55);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.RowHeadersWidth = 51;
            this.dtgvMonAn.RowTemplate.Height = 24;
            this.dtgvMonAn.Size = new System.Drawing.Size(559, 395);
            this.dtgvMonAn.TabIndex = 0;
            // 
            // MaMonAn
            // 
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.MinimumWidth = 6;
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Width = 125;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 125;
            // 
            // PhanLoai
            // 
            this.PhanLoai.HeaderText = "Phân loại";
            this.PhanLoai.MinimumWidth = 6;
            this.PhanLoai.Name = "PhanLoai";
            this.PhanLoai.Width = 125;
            // 
            // GiaCa
            // 
            this.GiaCa.HeaderText = "Giá cả";
            this.GiaCa.MinimumWidth = 6;
            this.GiaCa.Name = "GiaCa";
            this.GiaCa.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Món ăn";
            // 
            // txtTenTimKiem
            // 
            this.txtTenTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTimKiem.Location = new System.Drawing.Point(639, 84);
            this.txtTenTimKiem.Name = "txtTenTimKiem";
            this.txtTenTimKiem.Size = new System.Drawing.Size(219, 30);
            this.txtTenTimKiem.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(640, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 42);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã món";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(640, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 42);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên món";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(640, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 42);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phân loại";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(640, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 42);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá cả";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(760, 232);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(219, 30);
            this.txtMaMon.TabIndex = 12;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(760, 288);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(219, 30);
            this.txtTenMon.TabIndex = 13;
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanLoai.Location = new System.Drawing.Point(760, 346);
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.Size = new System.Drawing.Size(219, 30);
            this.txtPhanLoai.TabIndex = 14;
            // 
            // txtGiaCa
            // 
            this.txtGiaCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaCa.Location = new System.Drawing.Point(760, 403);
            this.txtGiaCa.Name = "txtGiaCa";
            this.txtGiaCa.Size = new System.Drawing.Size(219, 30);
            this.txtGiaCa.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel18);
            this.flowLayoutPanel2.Controls.Add(this.panel19);
            this.flowLayoutPanel2.Controls.Add(this.panel20);
            this.flowLayoutPanel2.Controls.Add(this.panel21);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(51, 477);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(619, 57);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnXem);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(107, 56);
            this.panel18.TabIndex = 8;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(9, 5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(83, 40);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "    Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnThem);
            this.panel19.Location = new System.Drawing.Point(116, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(114, 56);
            this.panel19.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(13, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnXoa);
            this.panel20.Location = new System.Drawing.Point(236, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(106, 56);
            this.panel20.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(3, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnSua);
            this.panel21.Location = new System.Drawing.Point(348, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(87, 56);
            this.panel21.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(0, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(639, 149);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 40);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "    Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // FrmDanhSachMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.txtGiaCa);
            this.Controls.Add(this.txtPhanLoai);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachMonAn";
            this.Text = "FrmDanhSachMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.TextBox txtGiaCa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaCa;
    }
}