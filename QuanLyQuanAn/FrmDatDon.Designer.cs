namespace QuanLyQuanAn
{
    partial class FrmDatDon
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
            this.components = new System.ComponentModel.Container();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.order = new System.Windows.Forms.Label();
            this.cbxLoaiMon = new System.Windows.Forms.ComboBox();
            this.cbxTenMon = new System.Windows.Forms.ComboBox();
            this.soLuong = new System.Windows.Forms.Label();
            this.soLuongMon = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxBan = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.elipseControl1 = new QuanLyQuanAn.elipseControl();
            this.elipseControl2 = new QuanLyQuanAn.elipseControl();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpBan.Location = new System.Drawing.Point(0, 0);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(417, 610);
            this.flpBan.TabIndex = 1;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(440, 11);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(124, 38);
            this.order.TabIndex = 3;
            this.order.Text = "Đặt món";
            // 
            // cbxLoaiMon
            // 
            this.cbxLoaiMon.AccessibleDescription = "Loại món";
            this.cbxLoaiMon.AccessibleName = "Loại món";
            this.cbxLoaiMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiMon.FormattingEnabled = true;
            this.cbxLoaiMon.Items.AddRange(new object[] {
            "",
            "Món Trung",
            "Món Hàn",
            "Món Âu",
            "Món Việt"});
            this.cbxLoaiMon.Location = new System.Drawing.Point(447, 72);
            this.cbxLoaiMon.Name = "cbxLoaiMon";
            this.cbxLoaiMon.Size = new System.Drawing.Size(184, 36);
            this.cbxLoaiMon.TabIndex = 4;
            this.cbxLoaiMon.Text = "Loại món";
            // 
            // cbxTenMon
            // 
            this.cbxTenMon.AccessibleDescription = "";
            this.cbxTenMon.AccessibleName = "";
            this.cbxTenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenMon.FormattingEnabled = true;
            this.cbxTenMon.Items.AddRange(new object[] {
            "",
            "Vịt chiên",
            "Gà chiên",
            "Rau xào",
            "Cơm rang",
            "Đỗ luộc"});
            this.cbxTenMon.Location = new System.Drawing.Point(447, 129);
            this.cbxTenMon.Name = "cbxTenMon";
            this.cbxTenMon.Size = new System.Drawing.Size(184, 36);
            this.cbxTenMon.TabIndex = 5;
            this.cbxTenMon.Text = "Tên món";
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.Location = new System.Drawing.Point(805, 78);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(85, 25);
            this.soLuong.TabIndex = 6;
            this.soLuong.Text = "Số lượng";
            // 
            // soLuongMon
            // 
            this.soLuongMon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongMon.Location = new System.Drawing.Point(896, 76);
            this.soLuongMon.Name = "soLuongMon";
            this.soLuongMon.Size = new System.Drawing.Size(42, 31);
            this.soLuongMon.TabIndex = 7;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(810, 124);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(128, 45);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.so_luong,
            this.Don_Gia,
            this.Thanh_tien});
            this.dataGridView1.Location = new System.Drawing.Point(447, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 288);
            this.dataGridView1.TabIndex = 9;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 125;
            // 
            // so_luong
            // 
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 90;
            // 
            // Don_Gia
            // 
            this.Don_Gia.HeaderText = "Đơn giá";
            this.Don_Gia.MinimumWidth = 6;
            this.Don_Gia.Name = "Don_Gia";
            this.Don_Gia.Width = 125;
            // 
            // Thanh_tien
            // 
            this.Thanh_tien.HeaderText = "Thành tiền";
            this.Thanh_tien.MinimumWidth = 6;
            this.Thanh_tien.Name = "Thanh_tien";
            this.Thanh_tien.Width = 125;
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.Location = new System.Drawing.Point(449, 492);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(115, 31);
            this.tongTien.TabIndex = 10;
            this.tongTien.Text = "Tổng Tiền";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(590, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 31);
            this.textBox1.TabIndex = 11;
            // 
            // cbxBan
            // 
            this.cbxBan.AccessibleDescription = "";
            this.cbxBan.AccessibleName = "";
            this.cbxBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBan.FormattingEnabled = true;
            this.cbxBan.Items.AddRange(new object[] {
            "",
            "Món Trung",
            "Món Hàn",
            "Món Âu",
            "Món Việt"});
            this.cbxBan.Location = new System.Drawing.Point(447, 541);
            this.cbxBan.Name = "cbxBan";
            this.cbxBan.Size = new System.Drawing.Size(127, 36);
            this.cbxBan.TabIndex = 12;
            this.cbxBan.Text = "Bàn";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(661, 21);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(93, 28);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Thời gian";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(810, 532);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 45);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 25;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(666, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá món";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FrmDatDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 610);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.cbxBan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tongTien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.soLuongMon);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.cbxTenMon);
            this.Controls.Add(this.cbxLoaiMon);
            this.Controls.Add(this.order);
            this.Controls.Add(this.flpBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDatDon";
            this.Text = "Quản lý Đặt Đơn";
            this.Load += new System.EventHandler(this.FrmDatDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soLuongMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private elipseControl elipseControl1;
        private elipseControl elipseControl2;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.ComboBox cbxLoaiMon;
        private System.Windows.Forms.ComboBox cbxTenMon;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown soLuongMon;
        private System.Windows.Forms.Label soLuong;
        private System.Windows.Forms.ComboBox cbxBan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanh_tien;
        private System.Windows.Forms.Button btnXoa;
    }
}