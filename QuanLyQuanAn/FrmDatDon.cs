using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmDatDon : Form
    {
        public FrmDatDon()
        {
            InitializeComponent();
            LoadDataDatCho();
        }

        private void FrmDatDon_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss tt");
            TimeLabel.Text = formattedTime;
        }

        void LoadDataDatCho()
        {
            List<Ban> ListBan = DanhSachBanDatCho.Instance.ListBan;
            foreach (Ban item in ListBan)
            {
                Button btn = new Button() { Width = 95, Height = 95 };
                btn.Text = item.Name + Environment.NewLine + item.Status ;
                switch (item.Status)
                {
                    case "Còn":
                        btn.BackColor = Color.Azure;
                        break;
                    default:
                        btn.BackColor = Color.Chartreuse;
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }
    }
}
