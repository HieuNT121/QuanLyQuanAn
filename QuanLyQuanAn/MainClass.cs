using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn 
{
    internal class MainClass
    {
        public static readonly string con_string = @"Data Source=DESKTOP-MC\SQLEXPRESS;Initial Catalog=RM demo;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        public static bool isValidUser(string username, string pass)
        {
            bool isValid = false;

            string qry = @"select * from users where username = '" + username + "' and userpass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["username"].ToString();
            }

            return isValid;
        }

        public static string user;

        public static string USER
        {
            get { return user; }
            set { user = value; }
        }
    }
}
