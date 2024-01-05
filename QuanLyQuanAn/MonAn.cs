using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class MonAn
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string idCategory;
        public string IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public MonAn(string id, string tenMon, string phanLoai, string price)
        {
            this.id = id;
            this.name = tenMon;
            this.idCategory = phanLoai;
            this.price = price;
        }
    }

    public class Category
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Category (string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class DanhSachPhanLoai
    {
        private static DanhSachPhanLoai instance;
        public static DanhSachPhanLoai Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachPhanLoai();
                return instance;
            }
            set => instance = value;
        }

        List<MonAn> listMonAn;

        public List<MonAn> ListMonAn
        {
            get => listMonAn;
            set => listMonAn = value;
        }

        List<Category> listCategory;

        public List<Category> ListCategory
        {
            get => listCategory;
            set => listCategory = value;
        }

        DanhSachPhanLoai()
        {
            listMonAn = new List<MonAn>();
            listCategory = new List<Category>();
            listMonAn.Add(new MonAn("1", "cá hồi", "1", "45000"));
            listMonAn.Add(new MonAn("2", "Khoa", "1", "90000"));
            listMonAn.Add(new MonAn("3", "Bo", "2", "180000"));

            listCategory.Add(new Category("1", "Hai san"));
            listCategory.Add(new Category("2", "Nong San"));
        }
    }
    
}
