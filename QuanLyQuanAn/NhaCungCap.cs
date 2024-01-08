using System;
using System.Collections.Generic;
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
                    instance = new DanhSachNhaCungCap);
                return instance;
            }
            set => instance = value;
        }

        List<NhaCungCap> danhSachNhaCungCap;

        public List<NhaCungCap> DanhSachNhaCungCap { get => danhSachNhaCungCap; set => danhSachNhaCungCap = value; }

        DanhSachNhaCungCap()
        {
            danhSachNhaCungCap = new List<NhaCungCap>();
            danhSachNhaCungCap.Add(new NhaCungCap(1, "name", 100, 0123456789));
        }
    }

    public class NhaCungCap
    {
        private int maNhaCungCap;
        public int MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }

        private string tenNhaCungCap;
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }

        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string soDienThoai;
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public NhaCungCap(int maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

    }
}
