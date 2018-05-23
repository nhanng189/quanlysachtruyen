using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class KhachHang
    {
        private int maKhachHang;
        private String hoTen;
        private String diaChi;
        private String soDienThoai;
        private String soCMND;

        public KhachHang(int maKhachHang, String hoTen, String diaChi, String soDienThoai, String soCMND)
        {
            this.maKhachHang = maKhachHang;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.soCMND = soCMND;
        }

        public KhachHang(DataRow row)
        {
            this.maKhachHang = (int)row["ma"];
            this.hoTen = row["hoTen"].ToString();
            this.diaChi = row["diaChi"].ToString();
            this.soDienThoai = row["soDienThoai"].ToString();
            this.soCMND = row["soCMND"].ToString();
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
    }
}
