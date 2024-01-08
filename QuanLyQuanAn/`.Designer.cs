namespace QuanLyQuanAn
{
    partial class FrmHeThongChinh
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
            this.btQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btPhanQuyen = new System.Windows.Forms.Button();
            this.btBaoTri = new System.Windows.Forms.Button();
            this.btCapNhatTaiKhoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btQuanLyTaiKhoan);
            this.panel_top.Controls.Add(this.btPhanQuyen);
            this.panel_top.Controls.Add(this.btBaoTri);
            this.panel_top.Controls.Add(this.btCapNhatTaiKhoan);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(743, 100);
            this.panel_top.TabIndex = 0;
            // 
            // btQuanLyTaiKhoan
            // 
            this.btQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyTaiKhoan.Location = new System.Drawing.Point(34, 12);
            this.btQuanLyTaiKhoan.Name = "btQuanLyTaiKhoan";
            this.btQuanLyTaiKhoan.Size = new System.Drawing.Size(141, 76);
            this.btQuanLyTaiKhoan.TabIndex = 4;
            this.btQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btPhanQuyen
            // 
            this.btPhanQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhanQuyen.Location = new System.Drawing.Point(222, 12);
            this.btPhanQuyen.Name = "btPhanQuyen";
            this.btPhanQuyen.Size = new System.Drawing.Size(141, 76);
            this.btPhanQuyen.TabIndex = 3;
            this.btPhanQuyen.Text = "Phân quyền";
            this.btPhanQuyen.UseVisualStyleBackColor = false;
            // 
            // btBaoTri
            // 
            this.btBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBaoTri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoTri.Location = new System.Drawing.Point(578, 12);
            this.btBaoTri.Name = "btBaoTri";
            this.btBaoTri.Size = new System.Drawing.Size(141, 76);
            this.btBaoTri.TabIndex = 2;
            this.btBaoTri.Text = "Bảo trì";
            this.btBaoTri.UseVisualStyleBackColor = false;
            // 
            // btCapNhatTaiKhoan
            // 
            this.btCapNhatTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCapNhatTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatTaiKhoan.Location = new System.Drawing.Point(406, 12);
            this.btCapNhatTaiKhoan.Name = "btCapNhatTaiKhoan";
            this.btCapNhatTaiKhoan.Size = new System.Drawing.Size(141, 76);
            this.btCapNhatTaiKhoan.TabIndex = 1;
            this.btCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            this.btCapNhatTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_body);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 515);
            this.panel2.TabIndex = 1;
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(743, 515);
            this.panel_body.TabIndex = 0;
            // 
            // FrmHeThongChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmHeThongChinh";
            this.Text = "FrmHeThongChinh";
            this.panel_top.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btQuanLyTaiKhoan;
        private System.Windows.Forms.Button btPhanQuyen;
        private System.Windows.Forms.Button btBaoTri;
        private System.Windows.Forms.Button btCapNhatTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
    }
}