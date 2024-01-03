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
            this.btnCapNhatHangHoa = new System.Windows.Forms.Button();
            this.btnSapXepHang = new System.Windows.Forms.Button();
            this.btnXuLyHangTon = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btnCapNhatHangHoa);
            this.panel_top.Controls.Add(this.btnSapXepHang);
            this.panel_top.Controls.Add(this.btnXuLyHangTon);
            this.panel_top.Controls.Add(this.btnNhapXuat);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(743, 100);
            this.panel_top.TabIndex = 0;
            // 
            // btnCapNhatHangHoa
            // 
            this.btnCapNhatHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCapNhatHangHoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatHangHoa.Location = new System.Drawing.Point(566, 12);
            this.btnCapNhatHangHoa.Name = "btnCapNhatHangHoa";
            this.btnCapNhatHangHoa.Size = new System.Drawing.Size(146, 76);
            this.btnCapNhatHangHoa.TabIndex = 1;
            this.btnCapNhatHangHoa.Text = "Cập nhật thông tin hàng hóa";
            this.btnCapNhatHangHoa.UseVisualStyleBackColor = false;
            // 
            // btnSapXepHang
            // 
            this.btnSapXepHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSapXepHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepHang.Location = new System.Drawing.Point(388, 12);
            this.btnSapXepHang.Name = "btnSapXepHang";
            this.btnSapXepHang.Size = new System.Drawing.Size(141, 76);
            this.btnSapXepHang.TabIndex = 2;
            this.btnSapXepHang.Text = "Sắp xếp hàng";
            this.btnSapXepHang.UseVisualStyleBackColor = false;
            // 
            // btnXuLyHangTon
            // 
            this.btnXuLyHangTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXuLyHangTon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyHangTon.Location = new System.Drawing.Point(216, 12);
            this.btnXuLyHangTon.Name = "btnXuLyHangTon";
            this.btnXuLyHangTon.Size = new System.Drawing.Size(141, 76);
            this.btnXuLyHangTon.TabIndex = 3;
            this.btnXuLyHangTon.Text = "Xử lý hàng tồn";
            this.btnXuLyHangTon.UseVisualStyleBackColor = false;
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNhapXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat.Location = new System.Drawing.Point(37, 12);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(141, 76);
            this.btnNhapXuat.TabIndex = 1;
            this.btnNhapXuat.Text = "Nhập, xuất";
            this.btnNhapXuat.UseVisualStyleBackColor = false;
            // 
            // FrmKhoChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 615);
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
        private System.Windows.Forms.Button btnCapNhatHangHoa;
        private System.Windows.Forms.Button btnSapXepHang;
        private System.Windows.Forms.Button btnXuLyHangTon;
        private System.Windows.Forms.Button btnNhapXuat;
    }
}