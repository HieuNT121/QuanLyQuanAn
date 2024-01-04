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
    public partial class FrmKhoChinh : Form
    {
        public FrmKhoChinh()
        {
            InitializeComponent();
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

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhapXuat());
        }

        private void btnXuLyHangTon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmXuLyHangTon());
        }

        private void btnSapXepHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSapXepHang());
        }

        private void btnCapNhatThongTinHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCapNhatThongTinHangHoa());
        }
    }
}
