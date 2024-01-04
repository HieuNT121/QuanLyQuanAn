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
}
