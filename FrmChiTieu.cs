using System;
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
    public partial class FrmChiTieu : Form
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
            command.CommandText = "select * into #temp from ChiTietKho where ChiTietCapNhat = 'Nhap' and ThoiGian between '"+dtpStart+"' and '"+dtpEnd+ ";select #temp.MaVatTu,KhoHang.TenVatTu,#temp.SoLuong,#temp.DonGia,NhanVien.HoTen,NhaCungCap.TenNhaCungCap\r\n\tfrom ((#temp left join KhoHang on #temp.MaVatTu = KhoHang.MaHangHoa) left join NhanVien on #temp.MaNhanVien = NhanVien.MaNhanVien) \r\n\tleft join NhaCungCap on #temp.MaNhaCungCap = NhaCungCap.MaNhaCungCap;";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            table.Columns.Add("Tong Cong", typeof(int));
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                DataRow dataRow = table.Rows[i];
                temp = int.Parse(dataRow["DonGia"].ToString()) * int.Parse(dataRow["SoLuong"].ToString());
                dataRow["Tong Luong"] = temp;
                iTongCong += temp;
            }
            tbTongCong.Text = iTongCong.ToString();
        }
        public FrmChiTieu()
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
