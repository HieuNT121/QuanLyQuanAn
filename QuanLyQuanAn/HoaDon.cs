using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class DanhSachHoaDon
    {
        private static DanhSachHoaDon instance;
        public static DanhSachHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachHoaDon();
                return instance;
            }
            set => instance = value;
        }

        List<HoaDon> danhSachHoaDon;
    }

    public class HoaDon
    {

    }
}