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

        public List<Ban> ListBan;
        public DatabaseExtract amn = new DatabaseExtract();
        DanhSachBanDatCho()
        {
            ListBan = amn.GetAllBans();
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
