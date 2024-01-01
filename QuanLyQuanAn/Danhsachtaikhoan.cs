using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance 
        {
            get 
            { 
                if (instance == null)
                    instance = new Danhsachtaikhoan();
                return instance; 
            } 
            set => instance = value; 
        }

        List<Taikhoan> listTaiKhoan;

        public List<Taikhoan> ListTaiKhoan 
        { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }


        Danhsachtaikhoan()
        {
            listTaiKhoan = new List<Taikhoan>();
            listTaiKhoan.Add(new Taikhoan("admin", "admin123", true));
            listTaiKhoan.Add(new Taikhoan("A", "123", false));
            listTaiKhoan.Add(new Taikhoan("B", "456", false));
        }
    }
}
