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

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection =new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd =new SqlCommand(query, connection);
            DataTable data =new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            connection.Close();

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
