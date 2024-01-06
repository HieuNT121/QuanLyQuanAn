namespace QuanLyQuanAn
{
    partial class FrmLuongKhach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.tbTongCong = new System.Windows.Forms.TextBox();
            this.dgvLuongKhach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDoanhThu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê số lượng khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(717, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng cộng ";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(354, 43);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(2024, 1, 6, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(626, 46);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2024, 1, 6, 0, 0, 0, 0);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(751, 94);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHienThi.Size = new System.Drawing.Size(84, 31);
            this.btnHienThi.TabIndex = 6;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // tbTongCong
            // 
            this.tbTongCong.Location = new System.Drawing.Point(858, 528);
            this.tbTongCong.Name = "tbTongCong";
            this.tbTongCong.ReadOnly = true;
            this.tbTongCong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTongCong.Size = new System.Drawing.Size(150, 22);
            this.tbTongCong.TabIndex = 7;
            // 
            // dgvLuongKhach
            // 
            this.dgvLuongKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvLuongKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongKhach.Location = new System.Drawing.Point(60, 133);
            this.dgvLuongKhach.Name = "dgvLuongKhach";
            this.dgvLuongKhach.RowHeadersWidth = 51;
            this.dgvLuongKhach.RowTemplate.Height = 24;
            this.dgvLuongKhach.Size = new System.Drawing.Size(871, 392);
            this.dgvLuongKhach.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(717, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doanh Thu";
            // 
            // tbDoanhThu
            // 
            this.tbDoanhThu.Location = new System.Drawing.Point(858, 563);
            this.tbDoanhThu.Name = "tbDoanhThu";
            this.tbDoanhThu.ReadOnly = true;
            this.tbDoanhThu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDoanhThu.Size = new System.Drawing.Size(150, 22);
            this.tbDoanhThu.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1014, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1014, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "VND";
            // 
            // FrmLuongKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1107, 611);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDoanhThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLuongKhach);
            this.Controls.Add(this.tbTongCong);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLuongKhach";
            this.Text = "FrmLuongKhach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox tbTongCong;
        private System.Windows.Forms.DataGridView dgvLuongKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDoanhThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}