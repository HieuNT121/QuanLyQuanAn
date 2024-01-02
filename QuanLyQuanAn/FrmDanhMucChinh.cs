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
    public partial class FrmDanhMucChinh : Form
    {
        public FrmDanhMucChinh()
        {
            InitializeComponent();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }
    }
}
