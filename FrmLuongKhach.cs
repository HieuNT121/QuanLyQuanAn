using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyQuanAn
{
    public partial class FrmLuongKhach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-CEQKQIM;Initial Catalog=master;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            int iTongCong = 0;
            command = connection.CreateCommand();
            command.CommandText = "select MaKhachHang,TenKhachHang,ThoiGianThanhToan, TongTien from HoaDonThanhToan HD left join KhachHang KH on HD.MaKhachHang = KH.MaKhachHang where ThoiGianThanhToan between '"+ dtpStart.ToString() +"' and '"+ dtpEnd.ToString() +"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvLuongKhach.DataSource = table;

            tbTongCong.Text = dgvLuongKhach.Rows.Count.ToString();
            for (int i = 0; i < dgvLuongKhach.Rows.Count - 1; i++)
            {
                iTongCong += int.Parse(dgvLuongKhach.Rows[i].Cells["Tổng Tiền"].Value.ToString());
            }
            tbDoanhThu.Text = iTongCong.ToString();
        }

        public FrmLuongKhach()
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
