using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class DanhSachBanDatCho
    {
        private static DanhSachBanDatCho instance;
        public static DanhSachBanDatCho Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachBanDatCho();
                return instance;
            }

            set { instance = value; }
        }

        public static int btnWidth = 85;
        public static int btnHeight = 85;

        public List<Ban> ListBan;
        //public List<Ban> ListBan 
        //{ 
        //    get => ListBan;
        //    set => ListBan = value; 
        //}

        DanhSachBanDatCho()
        {
            ListBan = new List<Ban>();
            ListBan.Add(new Ban(1, "Bàn 1", "Còn"));
            ListBan.Add(new Ban(2, "Bàn 2", "Còn"));
            ListBan.Add(new Ban(3, "Bàn 3", "Còn"));
            ListBan.Add(new Ban(4, "Bàn 4", "Còn"));
            ListBan.Add(new Ban(5, "Bàn 5", "Còn"));
        }

    }

    public class Ban
    {
        private int id;

        public int Id
        {
            get => id;
            set => id = value;
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private string status;
        public string Status
        {
            get => status;
            set => status = value;
        }

        public Ban(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
    }
}
