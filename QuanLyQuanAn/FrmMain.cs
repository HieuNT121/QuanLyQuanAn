using FormCalculator;
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
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        bool sideBarExpand;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                sideBar.Width -= 10; 
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private Form currentFormChild;
        private void OpenChildForm (Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm (new FrmDanhMucNhanVien() );
            sideBarTimer.Start ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoanhThu() );
            sideBarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatDon() );
            sideBarTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThucDon());
            sideBarTimer.Start();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            sideBarTimer.Start();
        }
    }
}
