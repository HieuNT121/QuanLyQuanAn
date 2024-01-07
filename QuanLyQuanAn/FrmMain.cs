using QuanLyQuanAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        //private void FrmMain_Load(object sender, EventArgs e)
        //{
        //    loginUser.Text = MainClass.USER;
        //}

        bool sideBarExpand;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
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
        private void OpenChildForm(Form childForm)
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

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhMucChinh());
            sideBarTimer.Start();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKeChinh());
            sideBarTimer.Start();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHeThongChinh());
            sideBarTimer.Start();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonChinh());
            sideBarTimer.Start();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoChinh());
            sideBarTimer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
