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
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.soLuong = new System.Windows.Forms.Label();
            this.numericUpDownSoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.btThemMon = new System.Windows.Forms.Button();
            this.cbxBan = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btXoaMon = new System.Windows.Forms.Button();
            this.dtpkThoiGian = new System.Windows.Forms.DateTimePicker();
            this.elipseControl1 = new QuanLyQuanAn.elipseControl();
            this.elipseControl2 = new QuanLyQuanAn.elipseControl();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuongMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.BackColor = System.Drawing.Color.White;
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpBan.Location = new System.Drawing.Point(0, 0);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(417, 600);
            this.flpBan.TabIndex = 1;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Black;
            this.order.Location = new System.Drawing.Point(440, 11);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(124, 38);
            this.order.TabIndex = 3;
            this.order.Text = "Đặt món";
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.AccessibleDescription = "Loại món";
            this.cbLoaiMon.AccessibleName = "Loại món";
            this.cbLoaiMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Items.AddRange(new object[] {
            "Món Trung",
            "Món Hàn",
            "Món Âu",
            "Món Việt"});
            this.cbLoaiMon.Location = new System.Drawing.Point(447, 72);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(184, 36);
            this.cbLoaiMon.TabIndex = 4;
            this.cbLoaiMon.Text = "Loại món";
            // 
            // cbTenMon
            // 
            this.cbTenMon.AccessibleDescription = "";
            this.cbTenMon.AccessibleName = "";
            this.cbTenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Items.AddRange(new object[] {
            "Vịt chiên",
            "Gà chiên",
            "Rau xào",
            "Cơm rang",
            "Đỗ luộc"});
            this.cbTenMon.Location = new System.Drawing.Point(447, 129);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(184, 36);
            this.cbTenMon.TabIndex = 5;
            this.cbTenMon.Text = "Tên món";
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.ForeColor = System.Drawing.Color.Black;
            this.soLuong.Location = new System.Drawing.Point(683, 125);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(92, 28);
            this.soLuong.TabIndex = 6;
            this.soLuong.Text = "Số lượng";
            // 
            // numericUpDownSoLuongMon
            // 
            this.numericUpDownSoLuongMon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoLuongMon.Location = new System.Drawing.Point(781, 129);
            this.numericUpDownSoLuongMon.Name = "numericUpDownSoLuongMon";
            this.numericUpDownSoLuongMon.Size = new System.Drawing.Size(42, 31);
            this.numericUpDownSoLuongMon.TabIndex = 7;
            // 
            // btThemMon
            // 
            this.btThemMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.Location = new System.Drawing.Point(688, 179);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(128, 45);
            this.btThemMon.TabIndex = 8;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.UseVisualStyleBackColor = true;
            // 
            // cbxBan
            // 
            this.cbxBan.AccessibleDescription = "";
            this.cbxBan.AccessibleName = "";
            this.cbxBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBan.FormattingEnabled = true;
            this.cbxBan.Items.AddRange(new object[] {
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
            // btXoaMon
            // 
            this.btXoaMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMon.Location = new System.Drawing.Point(446, 179);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(128, 45);
            this.btXoaMon.TabIndex = 15;
            this.btXoaMon.Text = "Xoá món";
            this.btXoaMon.UseVisualStyleBackColor = true;
            // 
            // dtpkThoiGian
            // 
            this.dtpkThoiGian.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkThoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkThoiGian.Location = new System.Drawing.Point(688, 72);
            this.dtpkThoiGian.Name = "dtpkThoiGian";
            this.dtpkThoiGian.Size = new System.Drawing.Size(224, 34);
            this.dtpkThoiGian.TabIndex = 16;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 25;
            this.elipseControl2.TargetControl = null;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(447, 244);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(549, 291);
            this.dtgvHoaDon.TabIndex = 17;
            // 
            // FrmDatDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.dtpkThoiGian);
            this.Controls.Add(this.btXoaMon);
            this.Controls.Add(this.cbxBan);
            this.Controls.Add(this.btThemMon);
            this.Controls.Add(this.numericUpDownSoLuongMon);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.cbTenMon);
            this.Controls.Add(this.cbLoaiMon);
            this.Controls.Add(this.order);
            this.Controls.Add(this.flpBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDatDon";
            this.Text = "Quản lý Đặt Đơn";
            this.Load += new System.EventHandler(this.FrmDatDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuongMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private elipseControl elipseControl1;
        private elipseControl elipseControl2;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuongMon;
        private System.Windows.Forms.Label soLuong;
        private System.Windows.Forms.ComboBox cbxBan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btXoaMon;
        private System.Windows.Forms.DateTimePicker dtpkThoiGian;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
    }
}