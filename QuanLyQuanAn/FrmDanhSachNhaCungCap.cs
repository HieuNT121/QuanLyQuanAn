using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyQuanAn
{
    public partial class FrmDanhSachNhaCungCap : Form
    {
        string connectionStr = @"Data Source=TRUNG-HIEU\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        int index = -1;
        public FrmDanhSachNhaCungCap()
        {
            InitializeComponent();
            LoadDataNhaCungCap();
        }

        void LoadDataNhaCungCap()
        {
            dtgvNhaCungCap.DataSource = null;
            dtgvNhaCungCap.DataSource = DanhSachNhaCungCap.Instance.ListNhaCungCap;
            dtgvNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dtgvNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dtgvNhaCungCap.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvNhaCungCap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvNhaCungCap.Refresh();
        }

        private void dtgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtMaNhaCungCap.Text = dtgvNhaCungCap.Rows[index].Cells[0].Value.ToString();
            txtTenNhaCungCap.Text = dtgvNhaCungCap.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvNhaCungCap.Rows[index].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dtgvNhaCungCap.Rows[index].Cells[3].Value.ToString();

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            LoadDataNhaCungCap();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DanhSachNhaCungCap.Instance.ListNhaCungCap.RemoveAt(index);
            string maNCC = txtMaNhaCungCap.Text;
            DataNhaCungCap.Xoa(connectionStr, maNCC );
            LoadDataNhaCungCap();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int checkedIsNull = 0;
            int checkIsDuplictated = 0;
            string[] bien = new string[4];
            bien[0] = txtMaNhaCungCap.Text;
            bien[1] = txtTenNhaCungCap.Text;
            bien[2] = txtDiaChi.Text;
            bien[3] = txtSoDienThoai.Text;

            foreach (string item in bien)
            {
                if(item == "")
                {
                    checkedIsNull = 1;
                }
            }
            if (checkedIsNull != 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ!");
            }
            else
            {
                foreach (NhaCungCap NCC in DanhSachNhaCungCap.Instance.ListNhaCungCap)
                {
                    if (bien[1] == NCC.TenNhaCungCap)
                    {
                        checkIsDuplictated = 1;
                    }
                }
                if (checkIsDuplictated == 1)
                {
                    MessageBox.Show("Đã tồn tại nhà cung cấp này!");
                }
                else
                {
                    DanhSachNhaCungCap.Instance.ListNhaCungCap.Add(new NhaCungCap(bien[0], bien[1], bien[2], bien[3]));
                    LoadDataNhaCungCap();
                }
            }
            DataNhaCungCap.CapNhatvaThemDuLieu(DanhSachNhaCungCap.Instance.ListNhaCungCap, connectionStr);
            LoadDataNhaCungCap();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int checkedIsNull = 0;
            string[] bien = new string[4];
            bien[0] = txtMaNhaCungCap.Text;
            bien[1] = txtTenNhaCungCap.Text;
            bien[2] = txtDiaChi.Text;
            bien[3] = txtSoDienThoai.Text;

            if(index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng!");
            }
            else
            {
                foreach (string item in bien)
                {
                    if (item == "")
                    {
                        checkedIsNull = 1;
                    }
                }
                if (checkedIsNull != 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ!");
                }
                else
                {                   
                        DanhSachNhaCungCap.Instance.ListNhaCungCap[index].MaNhaCungCap = bien[0];
                        DanhSachNhaCungCap.Instance.ListNhaCungCap[index].TenNhaCungCap = bien[1];
                        DanhSachNhaCungCap.Instance.ListNhaCungCap[index].DiaChi = bien[2];
                        DanhSachNhaCungCap.Instance.ListNhaCungCap[index].SoDienThoai = bien[3];
                        LoadDataNhaCungCap();
                }
            }
            DataNhaCungCap.CapNhatvaThemDuLieu(DanhSachNhaCungCap.Instance.ListNhaCungCap, connectionStr);
            LoadDataNhaCungCap();
        }

        
    }
}
