using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class Taikhoan
    {
        private string tenTaikhoan;

        public string TenTaikhoan
        { 
            get => tenTaikhoan; 
            set => tenTaikhoan = value; 
        }

        private string matKhau;
        public string MatKhau 
        { 
            get => matKhau; 
            set => matKhau = value; 
        }

        private bool loaiTaiKhoan;
        public bool LoaiTaiKhoan 
        { 
            get => loaiTaiKhoan; 
            set => loaiTaiKhoan = value; 
        }


        public Taikhoan(string tenTaikhoan, string matKhau, bool loaiTaiKhoan)
        {
            this.TenTaikhoan = tenTaikhoan;
            this.MatKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }
    }
}
