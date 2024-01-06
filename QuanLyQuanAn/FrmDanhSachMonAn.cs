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

    public partial class FrmDanhSachMonAn : Form
    {
        int index = -1;
        public FrmDanhSachMonAn()
        {
            InitializeComponent();
            LoadDataMon();
        }
        void LoadDataMon()
        {
            dtgvDanhSachMonAn.DataSource = null;
            dtgvDanhSachMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                    from cate in DanhSachPhanLoai.Instance.ListCategory
                                    where mon.IdCategory == cate.Id
                                    select new
                                    {
                                        ID = mon.Id,
                                        Tên = mon.Name,
                                        Category = cate.Name,
                                        Giá = mon.Price
                                    }).ToList();
            dtgvDanhSachMonAn.Refresh();
        }

        private void FrmThucDon_Load(object sender, EventArgs e)
        {
            //LoadDataMon();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataMon();
            dtgvDanhSachMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                    from cate in DanhSachPhanLoai.Instance.ListCategory
                                    where mon.IdCategory == cate.Id
                                    && mon.Name == txtMonAn.Text
                                    select new
                                    {
                                        ID = mon.Id,
                                        Tên = mon.Name,
                                        Category = cate.Name,
                                        Giá = mon.Price
                                    }).ToList();
            dtgvDanhSachMonAn.Refresh();
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

            tbMaMon.Text = dtgvDanhSachMonAn.Rows[index].Cells[0].Value.ToString();
            tbTenMon.Text = dtgvDanhSachMonAn.Rows[index].Cells[1].Value.ToString();
            tbPhanLoai.Text = dtgvDanhSachMonAn.Rows[index].Cells[2].Value.ToString();
            tbGiaCa.Text = dtgvDanhSachMonAn.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int check = 0;
            string[] bien = new string[5];
            bien[0] = tbMaMon.Text;
            bien[1] = tbTenMon.Text;
            bien[2] = tbPhanLoai.Text;
            bien[3] = tbGiaCa.Text;

            foreach (string a in bien)
            {
                if (a == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }

            foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
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

            DanhSachPhanLoai.Instance.ListMonAn.Add(new MonAn(bien[0], bien[1], bien[4], bien[3]));
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
            bien[0] = tbMaMon.Text;
            bien[1] = tbTenMon.Text;
            bien[2] = tbPhanLoai.Text;
            bien[3] = tbGiaCa.Text;

            for (int i = 0; i < 4; i++)
            {
                if (bien[i] == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }

            foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
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
                DanhSachPhanLoai.Instance.ListMonAn[index].Id = bien[0];
                DanhSachPhanLoai.Instance.ListMonAn[index].Name = bien[1];
                DanhSachPhanLoai.Instance.ListMonAn[index].IdCategory = bien[4];
                DanhSachPhanLoai.Instance.ListMonAn[index].Price = bien[3];
            }
            LoadDataMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

    }
}
