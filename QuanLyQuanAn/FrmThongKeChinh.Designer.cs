namespace QuanLyQuanAn
{
    partial class FrmThongKeChinh
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
            this.btnDoanhSo = new System.Windows.Forms.Button();
            this.btnChiTieu = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnLuongKhach = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btnDoanhSo);
            this.panel_top.Controls.Add(this.btnChiTieu);
            this.panel_top.Controls.Add(this.btnLuong);
            this.panel_top.Controls.Add(this.btnLuongKhach);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 110);
            this.panel_top.TabIndex = 0;
            // 
            // btnDoanhSo
            // 
            this.btnDoanhSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDoanhSo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhSo.Location = new System.Drawing.Point(555, 24);
            this.btnDoanhSo.Name = "btnDoanhSo";
            this.btnDoanhSo.Size = new System.Drawing.Size(128, 58);
            this.btnDoanhSo.TabIndex = 1;
            this.btnDoanhSo.Text = "Doanh số";
            this.btnDoanhSo.UseVisualStyleBackColor = false;
            this.btnDoanhSo.Click += new System.EventHandler(this.btnDoanhSo_Click);
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTieu.Location = new System.Drawing.Point(209, 24);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.Size = new System.Drawing.Size(128, 58);
            this.btnChiTieu.TabIndex = 2;
            this.btnChiTieu.Text = "Chi tiêu";
            this.btnChiTieu.UseVisualStyleBackColor = false;
            this.btnChiTieu.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.Location = new System.Drawing.Point(385, 24);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(128, 58);
            this.btnLuong.TabIndex = 1;
            this.btnLuong.Text = "Lương";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnLuongKhach
            // 
            this.btnLuongKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuongKhach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuongKhach.Location = new System.Drawing.Point(28, 24);
            this.btnLuongKhach.Name = "btnLuongKhach";
            this.btnLuongKhach.Size = new System.Drawing.Size(128, 58);
            this.btnLuongKhach.TabIndex = 0;
            this.btnLuongKhach.Text = "Lượng khách";
            this.btnLuongKhach.UseVisualStyleBackColor = false;
            this.btnLuongKhach.Click += new System.EventHandler(this.btnLuongKhach_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 110);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1034, 600);
            this.panel_body.TabIndex = 1;
            // 
            // FrmThongKeChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmThongKeChinh";
            this.Text = "FrmThongKeChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnDoanhSo;
        private System.Windows.Forms.Button btnChiTieu;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnLuongKhach;
    }
}