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
    public partial class FrmCapNhatKho : Form
    {
        SqlConnection connection = new SqlConnection();
        //SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tableTemp = new DataTable();
        DataRow row;
        int iTong = 0;

        public FrmCapNhatKho()
        {
            InitializeComponent();
            connection.ConnectionString = str;
            connection.Open();
        }

        private void FrmNhapXuat_Load(object sender, EventArgs e)
        {
            //dgvCapNhat.AllowUserToOrderColumnsChanged = false;
            table.Columns.Add("Mã Nguyên Liệu", typeof(string));
            table.Columns.Add("Tên Nguyên Liệu", typeof(string));
            table.Columns.Add("Số Lượng", typeof(int));
            table.Columns.Add("Đơn Giá", typeof(int));
            table.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
            table.Columns.Add("Mã Nhân Viên", typeof(string));
            table.Columns.Add("Ngày Nhập", typeof(string));
            tableTemp.Columns.Add("TenNguenLieu", typeof(string));
            tableTemp.Columns.Add("DonGia", typeof(string));
            tableTemp.Columns.Add("MaNhaCungCap", typeof(string));
            tableTemp.Columns.Add("SoLuong", typeof(string));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //connection.ConnectionString = str;
            //connection.Open();
            string sql = "Select TenNguenLieu,DonGia,MaNhaCungCap,SoLuong from KhoHang where MaNguyenLieu = '" + tbMaHangHoa.Text + "'";
            //string sql = "Select * from KhoHang";
            adapter = new SqlDataAdapter(sql, connection);
            tableTemp.Clear();
            adapter.Fill(tableTemp);
            if (tableTemp.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Không tìm thấy nguyên liệu, bạn có muốn thêm mới???", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    sql = "INSERT INTO KhoHang(MaNguyenLieu,TenNguenLieu,SoLuong,DonGia,MaNhaCungCap,MaNhanVien,NgayNhap) Values ('";
                    sql += tbMaHangHoa.Text + "',N'" + tbTenHangHoa.Text + "'," + tbSoLuong.Text + ",'" + tbDonGia.Text + "','" + tbMaNhaCungCap.Text + "','" + tbMaNhanVien.Text + "','" + dtp.Text + "');";
                }
                else return;
            }
            else
            {
                row = tableTemp.Rows[0];
                if (row[0].ToString() != tbTenHangHoa.Text || row[1].ToString() != tbDonGia.Text || row[2].ToString() != tbMaNhaCungCap.Text)
                {
                    DialogResult result = MessageBox.Show("Dữ liệu của bạn có sự thay đổi, Bạn có muốn cập nhật lại thông tin không???", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int SoLuongMoi = int.Parse(row[3].ToString()) + int.Parse(tbSoLuong.Text);
                        sql = "UPDATE KhoHang SET TenNguenLieu = N'";
                        sql += tbTenHangHoa.Text + "',SoLuong = " + SoLuongMoi.ToString() + ",DonGia = '" + tbDonGia.Text + "',MaNhanVien = '" + tbMaNhanVien.Text + "',MaNhaCungCap = '"
                            + tbMaNhaCungCap.Text + "', NgayNhap = '" + dtp.Text + "' Where MaNguyenLieu = '" + tbMaHangHoa.Text + "'";
                    }
                    else return;
                }
                else
                {
                    int SoLuongMoi = int.Parse(row[3].ToString()) + int.Parse(tbSoLuong.Text);
                    sql = "UPDATE KhoHang SET  SoLuong = ";
                    sql += SoLuongMoi.ToString() + ",MaNhanVien = '" + tbMaNhanVien.Text + "', NgayNhap = '" + dtp.Text + "' Where MaNguyenLieu = '" + tbMaHangHoa.Text + "'";
                }
            }
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            row = table.NewRow();

            iTong += int.Parse(tbSoLuong.Text.ToString()) * int.Parse(tbDonGia.Text.ToString());

            row["Mã Nguyên Liệu"] = tbMaHangHoa.Text;
            row["Tên Nguyên Liệu"] = tbTenHangHoa.Text;
            row["Số Lượng"] = tbSoLuong.Text;
            row["Đơn Giá"] = tbDonGia.Text;
            row["Mã Nhà Cung Cấp"] = tbMaNhaCungCap.Text;
            row["Mã Nhân Viên"] = tbMaNhanVien.Text;
            row["Ngày Nhập"] = dtp.Text;
            table.Rows.Add(row);
            dgvCapNhat.DataSource = table;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ThongKeDoanhSo Where ThoiGian = '" + dtp.Text + "'";
            tableTemp.Clear();
            adapter = new SqlDataAdapter(sql, connection);
            tableTemp.Clear();
            adapter.Fill(tableTemp);
            //row = table.Rows[0];
            if (tableTemp.Rows.Count == 0)
            {
                sql = "INSERT INTO ThongKeDoanhSo (ThoiGian,TongChi) VALUES ('";
                sql += dtp.Text + "'," + iTong.ToString() + ");";
            }
            else
            {
                sql = "UPDATE ThongKeDoanhSo SET TongChi = " + iTong.ToString() + "Where ThoiGian = '" + dtp.Text + "'"; ;
            }
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
