namespace QuanLyQuanAn
{
    partial class FrmKhoChinh
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
            this.btLienHeNhaCungCap = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btTrinhTrang = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btLienHeNhaCungCap);
            this.panel_top.Controls.Add(this.btTimKiem);
            this.panel_top.Controls.Add(this.btTrinhTrang);
            this.panel_top.Controls.Add(this.btCapNhat);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 112);
            this.panel_top.TabIndex = 0;
            // 
            // btLienHeNhaCungCap
            // 
            this.btLienHeNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLienHeNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLienHeNhaCungCap.Location = new System.Drawing.Point(638, 12);
            this.btLienHeNhaCungCap.Name = "btLienHeNhaCungCap";
            this.btLienHeNhaCungCap.Size = new System.Drawing.Size(146, 76);
            this.btLienHeNhaCungCap.TabIndex = 1;
            this.btLienHeNhaCungCap.Text = "Liên hệ nhà cung cấp";
            this.btLienHeNhaCungCap.UseVisualStyleBackColor = false;
            this.btLienHeNhaCungCap.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(240, 12);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(141, 76);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btTrinhTrang
            // 
            this.btTrinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btTrinhTrang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrinhTrang.Location = new System.Drawing.Point(435, 12);
            this.btTrinhTrang.Name = "btTrinhTrang";
            this.btTrinhTrang.Size = new System.Drawing.Size(141, 76);
            this.btTrinhTrang.TabIndex = 3;
            this.btTrinhTrang.Text = "Tình Trạng";
            this.btTrinhTrang.UseVisualStyleBackColor = false;
            this.btTrinhTrang.Click += new System.EventHandler(this.btnTrinhTrang_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(37, 12);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(141, 76);
            this.btCapNhat.TabIndex = 1;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 112);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1034, 598);
            this.panel_body.TabIndex = 1;
            // 
            // FrmKhoChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmKhoChinh";
            this.Text = "FrmKhoChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btLienHeNhaCungCap;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btTrinhTrang;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Panel panel_body;
    }
}