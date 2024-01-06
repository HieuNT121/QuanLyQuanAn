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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        List<string> listAccountType = new List<string>() { "Quản lý", "Nhân viên" };
        int index = -1;

        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            dtvgUser.DataSource = null;
            dtvgUser.DataSource = Danhsachtaikhoan.Instance.ListTaiKhoan;
            dtvgUser.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbLoaiTaiKhoan.DataSource = listAccountType;
            LoadListUser();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string userName = tbTenTaiKhoan.Text;
            string password = tbMatKhau.Text;
            bool accountType = false;
            switch (cbLoaiTaiKhoan.Text)
            {
                case "Quản lý":
                    accountType = true;
                    break;
                case "Nhân viên":
                    accountType = false;
                    break;
            }
            Danhsachtaikhoan.Instance.ListTaiKhoan.Add(new Taikhoan(userName, password, accountType));
            LoadListUser();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string userName = tbTenTaiKhoan.Text;
            string password = tbMatKhau.Text;
            bool accountType = false;
            switch (cbLoaiTaiKhoan.Text)
            {
                case "Quản lý":
                    accountType = true;
                    break;
                case "Nhân viên":
                    accountType = false;
                    break;
            }
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].TenTaikhoan = userName;
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].MatKhau = password;
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].LoaiTaiKhoan = accountType;
            LoadListUser();
        }

        private void dtvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            tbTenTaiKhoan.Text = dtvgUser.Rows[index].Cells[0].Value.ToString();
            tbMatKhau.Text = dtvgUser.Rows[index].Cells[1].Value.ToString();
            switch (Danhsachtaikhoan.Instance.ListTaiKhoan[index].LoaiTaiKhoan)
            {
                case true:
                    cbLoaiTaiKhoan.Text = "Quản lý";
                    break;
                case false:
                    cbLoaiTaiKhoan.Text = "Nhân viên";
                    break;
            }
        }

    }
}
