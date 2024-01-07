using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public class DataProvider
    {
        
        private string connectionSTR = @"Data Source=.\\sqlexpress;Initial Catalog=QuanlyQuanAn;Integrated Security=True";
        
        private DataProvider instance;

        public static DataProvider Instance 
        {
            get
            {
                if(Instance == null)
                    Instance = new DataProvider();
                return Instance;
            }
            set { DataProvider.Instance = value; }
        }

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable data =new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (param != null)
                {
                    string[] listPara =query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                    data = cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                    data = cmd.ExecuteScalar();
                    connection.Close();
                }
            }
            return data;
        }
    }

    public class DatabaseExtract
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog = QuanlyQuanAn; Integrated Security = True"; // Thay thế bằng chuỗi kết nối của bạn

        public List<Ban> GetAllBans()
        {
            List<Ban> ListBan = new List<Ban>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM ListBan", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["status"].ToString();
                            string name = reader["name"].ToString();
                            int id = Convert.ToInt32(reader["id"]);
                            Ban table = new Ban(id, name, status);
                            ListBan.Add(table);
                        }
                    }
                }
            }

            return ListBan;
        }

        public List<HoaDon> LayHoaDon()
        {
            List<HoaDon> HoaDon = new List<HoaDon>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Bill", connection))
                {
                    List<thongTin> DanhSachMon = LayThongTin();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string dateCheckIn = reader["Date"].ToString();
                            int status = Convert.ToInt32(reader["status"]); ;
                            int idTable = Convert.ToInt32(reader["idTable"]);
                            HoaDon hoaDon = new HoaDon (id, dateCheckIn, idTable, status);
                            foreach (thongTin info in DanhSachMon)
                            {
                                if(info.IdBill == id)
                                {
                                    hoaDon.ThemMon(info);
                                }
                            }
                            HoaDon.Add(hoaDon);
                        }
                    }
                }
            }

            return HoaDon;
        }

        public List<thongTin> LayThongTin()
        {
            List<thongTin> ListThongTin = new List<thongTin>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT dbo.BillInfo.idBill, dbo.Food.name, dbo.Food.price, dbo.BillInfo.count" +
                                "FROM dbo.BillInfo" +
                                "JOIN dbo.Food ON dbo.Food.id = dbo.BillInfo.idFood;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idBill = Convert.ToInt32(reader["idBill"]);
                            string tenMon = reader["name"].ToString();
                            float price = Convert.ToInt32(reader["price"]);
                            int soLuong = Convert.ToInt32(reader["count"]);
                            float thanhTien = price * soLuong;

                            thongTin info = new thongTin(idBill, tenMon, price, soLuong, thanhTien);
                            ListThongTin.Add(info);
                        }
                    }
                }
            }

            return ListThongTin;
        }
    }
}
