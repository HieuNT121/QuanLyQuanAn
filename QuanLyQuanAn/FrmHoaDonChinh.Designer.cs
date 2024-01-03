namespace QuanLyQuanAn
{
    partial class FrmHoaDonChinh
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
            this.btnCapNhatHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToanVaXuatHoaDon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btnCapNhatHoaDon);
            this.panel_top.Controls.Add(this.btnThanhToanVaXuatHoaDon);
            this.panel_top.Controls.Add(this.btnTaoHoaDon);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(743, 100);
            this.panel_top.TabIndex = 0;
            // 
            // btnCapNhatHoaDon
            // 
            this.btnCapNhatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCapNhatHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatHoaDon.Location = new System.Drawing.Point(397, 21);
            this.btnCapNhatHoaDon.Name = "btnCapNhatHoaDon";
            this.btnCapNhatHoaDon.Size = new System.Drawing.Size(155, 63);
            this.btnCapNhatHoaDon.TabIndex = 1;
            this.btnCapNhatHoaDon.Text = "Cập nhật thông tin";
            this.btnCapNhatHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnThanhToanVaXuatHoaDon
            // 
            this.btnThanhToanVaXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThanhToanVaXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanVaXuatHoaDon.Location = new System.Drawing.Point(217, 21);
            this.btnThanhToanVaXuatHoaDon.Name = "btnThanhToanVaXuatHoaDon";
            this.btnThanhToanVaXuatHoaDon.Size = new System.Drawing.Size(143, 63);
            this.btnThanhToanVaXuatHoaDon.TabIndex = 1;
            this.btnThanhToanVaXuatHoaDon.Text = "Thanh toán và xuất hóa đơn";
            this.btnThanhToanVaXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHoaDon.Location = new System.Drawing.Point(29, 17);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(145, 70);
            this.btnTaoHoaDon.TabIndex = 0;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            // 
            // FrmHoaDonChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 615);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmHoaDonChinh";
            this.Text = "FrmHoaDonChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnThanhToanVaXuatHoaDon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnCapNhatHoaDon;
    }
}