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
            this.btDoanhSo = new System.Windows.Forms.Button();
            this.btChiTieu = new System.Windows.Forms.Button();
            this.btLuong = new System.Windows.Forms.Button();
            this.btLuongKhach = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btDoanhSo);
            this.panel_top.Controls.Add(this.btChiTieu);
            this.panel_top.Controls.Add(this.btLuong);
            this.panel_top.Controls.Add(this.btLuongKhach);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 110);
            this.panel_top.TabIndex = 0;
            // 
            // btDoanhSo
            // 
            this.btDoanhSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDoanhSo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoanhSo.Location = new System.Drawing.Point(555, 24);
            this.btDoanhSo.Name = "btDoanhSo";
            this.btDoanhSo.Size = new System.Drawing.Size(128, 58);
            this.btDoanhSo.TabIndex = 1;
            this.btDoanhSo.Text = "Doanh số";
            this.btDoanhSo.UseVisualStyleBackColor = false;
            this.btDoanhSo.Click += new System.EventHandler(this.btDoanhSo_Click);
            // 
            // btChiTieu
            // 
            this.btChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiTieu.Location = new System.Drawing.Point(209, 24);
            this.btChiTieu.Name = "btChiTieu";
            this.btChiTieu.Size = new System.Drawing.Size(128, 58);
            this.btChiTieu.TabIndex = 2;
            this.btChiTieu.Text = "Chi tiêu";
            this.btChiTieu.UseVisualStyleBackColor = false;
            this.btChiTieu.Click += new System.EventHandler(this.btChiTieu_Click);
            // 
            // btLuong
            // 
            this.btLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuong.Location = new System.Drawing.Point(385, 24);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(128, 58);
            this.btLuong.TabIndex = 1;
            this.btLuong.Text = "Lương";
            this.btLuong.UseVisualStyleBackColor = false;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // btLuongKhach
            // 
            this.btLuongKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLuongKhach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuongKhach.Location = new System.Drawing.Point(28, 24);
            this.btLuongKhach.Name = "btLuongKhach";
            this.btLuongKhach.Size = new System.Drawing.Size(128, 58);
            this.btLuongKhach.TabIndex = 0;
            this.btLuongKhach.Text = "Lượng khách";
            this.btLuongKhach.UseVisualStyleBackColor = false;
            this.btLuongKhach.Click += new System.EventHandler(this.btLuongKhach_Click);
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
        private System.Windows.Forms.Button btDoanhSo;
        private System.Windows.Forms.Button btChiTieu;
        private System.Windows.Forms.Button btLuong;
        private System.Windows.Forms.Button btLuongKhach;
    }
}