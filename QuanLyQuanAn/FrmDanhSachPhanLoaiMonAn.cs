using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanAn
{
    public partial class FrmDanhSachPhanLoaiMonAn : Form
    {
        int index = -1;
        public FrmDanhSachPhanLoaiMonAn()
        {
            InitializeComponent();
            LoadDataPhanLoai();
        }

        void LoadDataPhanLoai()
        {
            dtgvCategory.DataSource = null;
            dtgvCategory.DataSource = DanhSachPhanLoai.Instance.ListCategory;
            dtgvCategory.Refresh();
        }

        static void IsNull(string[] a, int b)
        {
            foreach (string item in a)
            {
                if (item == "")
                {
                    b = 1;
                }
            }
            if (b == 1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
        static void IsDuplicated(string a, int b)
        {
            foreach (Category item in DanhSachPhanLoai.Instance.ListCategory)
            {
                if (a == item.Name)
                {
                    MessageBox.Show("Đã tồn tại phân loại món này!");
                    b = 1;
                }
            }
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            tbxID.Text = dtgvCategory.Rows[index].Cells[0].Value.ToString();
            tbxName.Text = dtgvCategory.Rows[index].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int checkIsNull = 0;
            int checkIsDuplicated = 0;
            string[] bien = new string[2];
            bien[0] = tbxID.Text;
            bien[1] = tbxName.Text;

            foreach (string a in bien)
            {
                if (a == "")
                {
                    checkIsNull = 1;
                }
            }
            if (checkIsNull == 1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }

            foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
            {
                if (bien[1] == a.Name)
                {
                    MessageBox.Show("Đã tồn tại phân loại món này!");
                    checkIsDuplicated = 1;
                }
            }
            if (checkIsNull == 0 && checkIsDuplicated == 0)
            {
                DanhSachPhanLoai.Instance.ListCategory.Add(new Category(bien[0], bien[1]));
                LoadDataPhanLoai();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int checkIsNull = 0;
            int checkIsDuplicated = 0;
            string[] bien = new string[2];
            bien[0] = tbxID.Text;
            bien[1] = tbxName.Text;

            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng");
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
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }

                foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
                {
                    if (bien[1] == a.Name)
                    {
                        MessageBox.Show("Đã tồn tại phân loại món này!");
                        checkIsDuplicated = 1;
                    }
                }

                if (checkIsNull == 0 && checkIsDuplicated == 0)
                {
                    DanhSachPhanLoai.Instance.ListCategory[index].Id = bien[0];
                    DanhSachPhanLoai.Instance.ListCategory[index].Name = bien[1];
                    LoadDataPhanLoai();
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDataPhanLoai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng");
            }
            else
            {
                DanhSachPhanLoai.Instance.ListCategory.RemoveAt(index);
                LoadDataPhanLoai();
            }

        }

    }
}
