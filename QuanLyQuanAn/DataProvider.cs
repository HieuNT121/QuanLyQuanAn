using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
