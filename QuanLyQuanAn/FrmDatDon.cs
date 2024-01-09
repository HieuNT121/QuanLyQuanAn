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
    public partial class FrmDatDon : Form
    {
        DataAccess dataAccess =new DataAccess();
        public FrmDatDon()
        {
            InitializeComponent();
            LoadDataBan();
        }

        private void FrmDatDon_Load(object sender, EventArgs e)
        {
           
        }

        void LoadThongTinHoaDon(string idBan)
        {
            //string query = string.Format("SELECT * FROM HoaDon WHERE MaBan = ("idBan") ");
            

        }
        void LoadDataBan()
        {
            try
            {
                string query = string.Format("SELECT * FROM dbo.Ban");
                DataTable table = dataAccess.GetDataTable(query);
                foreach(DataRow row in table.Rows)
                {
                    Button btn = new Button() { Width = 95, Height = 95 };
                    btn.Text = row[1] + Environment.NewLine + row[2];
                    btn.Tag = row;
                    btn.Click += new EventHandler(btn_Click);
                    switch (row[2])
                    {
                        case "Trống":
                            btn.BackColor = Color.Azure;
                            break;
                        default:
                            btn.BackColor = Color.Chartreuse;
                            break;
                    }
                    flpBan.Controls.Add(btn);
                }
            }
            catch
            {

            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            //HienThiHoaDon(1);
        }


        void HienThiHoaDon(string id)
        {
            
        }

    }
}
