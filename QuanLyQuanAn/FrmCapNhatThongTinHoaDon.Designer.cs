namespace QuanLyQuanAn
{
    partial class FrmCapNhatThongTinHoaDon
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
            this.BtnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapNhat.Location = new System.Drawing.Point(459, 536);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(110, 41);
            this.BtnCapNhat.TabIndex = 0;
            this.BtnCapNhat.Text = "Cập nhật";
            this.BtnCapNhat.UseVisualStyleBackColor = false;
            // 
            // FrmCapNhatThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.BtnCapNhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapNhatThongTinHoaDon";
            this.Text = "FrmCapNhatThongTinHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCapNhat;
    }
}