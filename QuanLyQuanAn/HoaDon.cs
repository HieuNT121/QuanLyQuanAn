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

        public List<HoaDon> ListHoaDon;
        public DatabaseExtract cmd = new DatabaseExtract();

        DanhSachHoaDon()
        {
            ListHoaDon = cmd.LayHoaDon();
        }
    }

    public class HoaDon
    {
        private int id;

        public int Id { get => id; set => id = value; }

        private string dateCheckIn;

        public string DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        private int idBan;
        public int IdBan { get => idBan; set => idBan = value; }

        private int status;
        public int Status { get => status; set => status = value; }

        private List<thongTin> thongTin;
        public List<thongTin> ThongTin { get => thongTin; set => thongTin = value; }

        public HoaDon(int id, string dateCheckIn, int idBan, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.IdBan = idBan;
            this.Status = status;
            ThongTin = new List<thongTin>() ;
        }

        public void ThemMon(thongTin mon)
        {
            ThongTin.Add(mon);
        }
    }

    public class thongTin
    {
        private int idBill;
        public int IdBill { get => idBill; set => idBill = value; }

        private string tenMon;
        public string TenMon { get => tenMon; set => tenMon = value; }

        private float price;
        public float Price { get => price; set => price = value; }

        private int soLuong;
        public int SoLuong { get => soLuong; set => soLuong = value; }

        private float thanhTien;
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }


        public thongTin(int idBill, string tenMon, float price, int soLuong, float thanhTien)
        {
            this.IdBill = idBill;
            this.TenMon = tenMon;
            this.Price = price;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
    }
}