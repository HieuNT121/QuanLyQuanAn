using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class DanhSachNhaCungCap
    {
        private static DanhSachNhaCungCap instance;

        public static DanhSachNhaCungCap Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachNhaCungCap();
                return instance;
            }
            set => instance = value;
        }

        List<NhaCungCap> listNhaCungCap;
        public List<NhaCungCap> ListNhaCungCap { get => listNhaCungCap; set => listNhaCungCap = value; }

        DanhSachNhaCungCap()
        {
            ListNhaCungCap = new List<NhaCungCap>();
            ListNhaCungCap.Add(new NhaCungCap("1", "name", "1000", "123456789"));
        }


    }

    public class NhaCungCap
    {
        private string maNhaCungCap;
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }

        private string tenNhaCungCap;
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }

        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string soDienThoai;
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

    }


}
