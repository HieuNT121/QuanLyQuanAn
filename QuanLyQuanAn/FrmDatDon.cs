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
        }

        private void FrmDatDon_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss tt");
            TimeLabel.Text = formattedTime;
        }
    }
}
