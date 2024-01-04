namespace QuanLyQuanAn
{
    partial class FrmDanhMucChinh
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.btnDanhSachMonAn = new System.Windows.Forms.Button();
            this.btnDanhSachLoaiMonAn = new System.Windows.Forms.Button();
            this.btnDanhSachNhaCungCap = new System.Windows.Forms.Button();
            this.btnDanhSachDatCho = new System.Windows.Forms.Button();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btnDanhSachNhanVien = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btnDanhSachMonAn);
            this.panel_top.Controls.Add(this.btnDanhSachLoaiMonAn);
            this.panel_top.Controls.Add(this.btnDanhSachNhaCungCap);
            this.panel_top.Controls.Add(this.btnDanhSachDatCho);
            this.panel_top.Controls.Add(this.btnDanhSachKhachHang);
            this.panel_top.Controls.Add(this.btnDanhSachNhanVien);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 110);
            this.panel_top.TabIndex = 0;
            // 
            // btnDanhSachMonAn
            // 
            this.btnDanhSachMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachMonAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachMonAn.Location = new System.Drawing.Point(869, 12);
            this.btnDanhSachMonAn.Name = "btnDanhSachMonAn";
            this.btnDanhSachMonAn.Size = new System.Drawing.Size(132, 76);
            this.btnDanhSachMonAn.TabIndex = 3;
            this.btnDanhSachMonAn.Text = "Danh sách món ăn";
            this.btnDanhSachMonAn.UseVisualStyleBackColor = false;
            this.btnDanhSachMonAn.Click += new System.EventHandler(this.btnDanhSachMonAn_Click);
            // 
            // btnDanhSachLoaiMonAn
            // 
            this.btnDanhSachLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachLoaiMonAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachLoaiMonAn.Location = new System.Drawing.Point(691, 12);
            this.btnDanhSachLoaiMonAn.Name = "btnDanhSachLoaiMonAn";
            this.btnDanhSachLoaiMonAn.Size = new System.Drawing.Size(141, 76);
            this.btnDanhSachLoaiMonAn.TabIndex = 2;
            this.btnDanhSachLoaiMonAn.Text = "Danh sách loại món ăn";
            this.btnDanhSachLoaiMonAn.UseVisualStyleBackColor = false;
            this.btnDanhSachLoaiMonAn.Click += new System.EventHandler(this.btnDanhSachPhanLoaiMonAn_Click);
            // 
            // btnDanhSachNhaCungCap
            // 
            this.btnDanhSachNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhaCungCap.Location = new System.Drawing.Point(525, 12);
            this.btnDanhSachNhaCungCap.Name = "btnDanhSachNhaCungCap";
            this.btnDanhSachNhaCungCap.Size = new System.Drawing.Size(132, 76);
            this.btnDanhSachNhaCungCap.TabIndex = 1;
            this.btnDanhSachNhaCungCap.Text = "Danh sách nhà cung cấp";
            this.btnDanhSachNhaCungCap.UseVisualStyleBackColor = false;
            this.btnDanhSachNhaCungCap.Click += new System.EventHandler(this.btnDanhSachNhaCungCap_Click);
            // 
            // btnDanhSachDatCho
            // 
            this.btnDanhSachDatCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachDatCho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachDatCho.Location = new System.Drawing.Point(358, 12);
            this.btnDanhSachDatCho.Name = "btnDanhSachDatCho";
            this.btnDanhSachDatCho.Size = new System.Drawing.Size(132, 76);
            this.btnDanhSachDatCho.TabIndex = 1;
            this.btnDanhSachDatCho.Text = "Danh sách đặt chỗ";
            this.btnDanhSachDatCho.UseVisualStyleBackColor = false;
            this.btnDanhSachDatCho.Click += new System.EventHandler(this.btnDanhSachDatCho_Click);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(192, 12);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(132, 76);
            this.btnDanhSachKhachHang.TabIndex = 1;
            this.btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDanhSachNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhanVien.Location = new System.Drawing.Point(25, 12);
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.Size = new System.Drawing.Size(141, 76);
            this.btnDanhSachNhanVien.TabIndex = 0;
            this.btnDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.UseVisualStyleBackColor = false;
            this.btnDanhSachNhanVien.Click += new System.EventHandler(this.btnDanhSachNhanVien_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 110);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1034, 600);
            this.panel_body.TabIndex = 1;
            // 
            // FrmDanhMucChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmDanhMucChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDanhMucChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnDanhSachDatCho;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnDanhSachNhanVien;
        private System.Windows.Forms.Button btnDanhSachNhaCungCap;
        private System.Windows.Forms.Button btnDanhSachMonAn;
        private System.Windows.Forms.Button btnDanhSachLoaiMonAn;
        private System.Windows.Forms.Panel panel_body;
    }
}