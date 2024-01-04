﻿using System;
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

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachNhanVien());
        }

        private void btnDanhSachMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachMonAn());
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachKhachHang());
        }

        private void btnDanhSachDatCho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachDatCho());
        }

        private void btnDanhSachNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachNhaCungCap());
        }

        private void btnDanhSachPhanLoaiMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachPhanLoaiMonAn());
        }
    }
}
