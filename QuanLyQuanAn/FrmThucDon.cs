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

    public partial class FrmThucDon : Form
    {
        int index = -1;
        public FrmThucDon()
        {
            InitializeComponent();
            LoadDataMon();
        }

        void LoadDataMon()
        {
            dtgvMonAn.DataSource = null;
            dtgvMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                   from cate in DanhSachPhanLoai.Instance.ListCategory
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
            dtgvMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                    from cate in DanhSachPhanLoai.Instance.ListCategory
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
            int checkIsNull = 0;
            int checkIsExist = 0;
            int checkIsDuplicated = 0;
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            foreach (string a in bien){
                if ( a == "")
                {
                    checkIsNull = 1;
                }
            }
            if (checkIsNull == 1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                foreach (Category type in DanhSachPhanLoai.Instance.ListCategory)
                {
                    if (bien[2] == type.Name)
                    {
                        bien[4] = type.Id;
                        checkIsExist = 1;
                    }
                }

                if (checkIsExist == 0)
                {
                    MessageBox.Show("Không có loại món này trong nhà hàng");
                }
                else
                {
                    foreach (MonAn food in DanhSachPhanLoai.Instance.ListMonAn)
                    {
                        if (bien[1] == food.Name)
                        {
                            checkIsDuplicated = 1;
                        }
                    }
                    if(checkIsDuplicated == 1)
                    {
                        MessageBox.Show("Đã có món này trong nhà hàng");
                    }
                    else
                    {
                        DanhSachPhanLoai.Instance.ListMonAn.Add(new MonAn(bien[0], bien[1], bien[4], bien[3]));
                        LoadDataMon();
                    } 
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int checkIsNull = 0;
            int checkIsExist = 0;
            int checkIsDuplicated = 0;
            
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 cột trong bảng");
            }
            else
            {
                foreach (string a in bien)
                {
                    if (a == "")
                    {
                        checkIsNull = 1;
                    }
                }
                if (checkIsNull == 1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    foreach (Category type in DanhSachPhanLoai.Instance.ListCategory)
                    {
                        if (bien[2] == type.Name)
                        {
                            bien[4] = type.Id;
                            checkIsExist = 1;
                        }
                    }

                    if (checkIsExist == 0)
                    {
                        MessageBox.Show("Không có loại món này trong nhà hàng");
                    }
                    else
                    {
                        foreach (MonAn food in DanhSachPhanLoai.Instance.ListMonAn)
                        {
                            if (bien[1] == food.Name)
                            {
                                checkIsDuplicated = 1;
                            }
                        }
                        if (checkIsDuplicated == 1)
                        {
                            MessageBox.Show("Đã có món này trong nhà hàng");
                        }
                        else
                        {
                            DanhSachPhanLoai.Instance.ListMonAn[index].Id = bien[0];
                            DanhSachPhanLoai.Instance.ListMonAn[index].Name = bien[1];
                            DanhSachPhanLoai.Instance.ListMonAn[index].IdCategory = bien[4];
                            DanhSachPhanLoai.Instance.ListMonAn[index].Price = bien[3];
                            LoadDataMon();
                        }
                    }
                }
            }
            LoadDataMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng");
            }
            else
            {
                DanhSachPhanLoai.Instance.ListMonAn.RemoveAt(index);
                LoadDataMon();
            }
        }
    }
}
