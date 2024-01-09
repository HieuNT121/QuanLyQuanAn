﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmLuong : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-CEQKQIM;Initial Catalog=master;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            int iTongCong = 0;
            int temp;
            command = connection.CreateCommand();
            command.CommandText = "select MaNhanVien,HoTen,ChucVu,Luong,SoGioLam from NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            table.Columns.Add("Tong Luong", typeof(int));
            foreach (DataRow row in table.Rows)
            {
                temp = int.Parse(row["Luong"].ToString()) * int.Parse(row["SoGioLam"].ToString());
                row["Tong Luong"] = temp;
                iTongCong += temp;
            }
            dgvLuong.DataSource = table;
            tbTongCong.Text = iTongCong.ToString();
        }
        public FrmLuong()
        {
            InitializeComponent();
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
