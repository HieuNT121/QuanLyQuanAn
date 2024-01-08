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
    public partial class FrmDanhSachNhaCungCap : Form
    {
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
            Danhsachtaikhoan.Instance.ListTaiKhoan.RemoveAt(index);
            LoadDataNhaCungCap();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }
    }
}
