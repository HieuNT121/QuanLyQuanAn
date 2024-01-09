using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class HoaDon
    {
        
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }

        private string maHoaDon;
        private string maNhanVien;
        private string maBan;
        private string maKhachHang;
        private DateTime ngayThanhToan;
        private int tongTien;

        public HoaDon(string maHoaDon, string maNhanVien, string maBan, string maKhachHang, DateTime ngayThanhToan, int tongTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaNhanVien = maNhanVien;
            this.MaBan = maBan;
            this.MaKhachHang = maKhachHang;
            this.NgayThanhToan = ngayThanhToan;
            this.TongTien = tongTien;
        }

        public HoaDon(DataRow row)
        {
            this.MaHoaDon = row["MaHoaDon"].ToString();
            this.MaNhanVien =  row["MaNhanVien"].ToString();
            this.MaBan = row["MaBan"].ToString();
            this.MaKhachHang = row["MaKhachHang"].ToString();
            this.NgayThanhToan = (DateTime)row["NgayThanhToan"];
            this.TongTien = (int)row["TongTien"];
        }
    }

    public class DanhSachHoaDon
    {

    }
}
