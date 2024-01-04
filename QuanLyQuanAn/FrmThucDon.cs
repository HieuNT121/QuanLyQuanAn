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

    public partial class FrmThucDon : Form
    {
        int index = -1;
        List<MonAn> ListMonAn = new List<MonAn>();
        List<Category> ListCategory = new List<Category>();
        public FrmThucDon()
        {
            InitializeComponent();
            ListMonAn.Add(new MonAn("1", "cá hồi", "1", "45000"));
            ListMonAn.Add(new MonAn("2", "Khoa", "1", "90000"));
            ListMonAn.Add(new MonAn("3", "Bo", "2", "180000"));

            ListCategory.Add(new Category("1", "Hai san"));
            ListCategory.Add(new Category("2", "Nong San"));

            LoadDataMon();
        }
        void LoadDataMon()
        {
            dtgvMonAn.DataSource = null;
            dtgvMonAn.DataSource = (from mon in ListMonAn
                                   from cate in ListCategory
                                   where mon.IdCategory == cate.Id
                                   select new
                                   {
                                       ID = mon.Id,
                                       Tên = mon.Name,
                                       Category = cate.Name,
                                       Giá = mon.Price
                                   }).ToList();
            dtgvMonAn.Refresh();
        }

        private void FrmThucDon_Load(object sender, EventArgs e)
        {
            //LoadDataMon();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataMon() ;
            dtgvMonAn.DataSource = (from mon in ListMonAn
                                    from cate in ListCategory
                                    where mon.IdCategory == cate.Id
                                    && mon.Name == tenTimKiem.Text 
                                    select new
                                    {
                                        ID = mon.Id,
                                        Tên = mon.Name,
                                        Category = cate.Name,
                                        Giá = mon.Price
                                    }).ToList();
            dtgvMonAn.Refresh();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDataMon();
        }

        private void dtgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            tbxIdFood.Text = dtgvMonAn.Rows[index].Cells[0].Value.ToString();
            tbxFoodName.Text = dtgvMonAn.Rows[index].Cells[1].Value.ToString();
            tbxCategory.Text = dtgvMonAn.Rows[index].Cells[2].Value.ToString();
            tbxFoodPrice.Text = dtgvMonAn.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int check = 0;
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            for (int i =0; i<4; i++){
                if (bien[i] == null)
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }

            foreach (Category a in ListCategory)
            {
                if (bien[2] == a.Name)
                {
                    bien[4] = a.Id;
                    check = 1;
                }
            }

            if (check == 0)
            {
                MessageBox.Show("Không có loại món này trong cửa hàng");
            }
           
            ListMonAn.Add(new MonAn(bien[0], bien[1], bien[4], bien[3]));
            LoadDataMon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 cột trong bảng");
            }
            int check = 0;
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            for (int i = 0; i < 4; i++)
            {
                if (bien[i] == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }

            foreach (Category a in ListCategory)
            {
                if (bien[2] == a.Name)
                {
                    bien[4] = a.Id;
                    check = 1;
                }
            }

            if (check == 0)
            {
                MessageBox.Show("Không có loại món này trong cửa hàng");
            }
            else
            {
                ListMonAn[index].Id = bien[0];
                ListMonAn[index].Name = bien[1];
                ListMonAn[index].IdCategory = bien[4];
                ListMonAn[index].Price = bien[3];
            }
            LoadDataMon();
        }
    }
}
