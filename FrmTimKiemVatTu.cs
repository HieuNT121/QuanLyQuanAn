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
    public partial class FrmTimKiemVatTu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-CEQKQIM;Initial Catalog=master;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            string TimKiem = "MaHangHoa";
            if (cbLuaChon.Text == "Tên Vật Tư") TimKiem = "TenVatTu";
            else if (cbLuaChon.Text == "NhaCungCap") TimKiem = "MaNhaCungCap";
            command = connection.CreateCommand();
            command.CommandText = "select MaHangHoa,TenVatTu,SoLuong,MaNhaCungCap from KhoHang where " +TimKiem+ "='"+tbThongTinTimKiem.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTimKiem.DataSource = table;
        }

        public FrmTimKiemVatTu()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
