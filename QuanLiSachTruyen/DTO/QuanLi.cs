using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class QuanLi
    {
        private int maQuanLi;
        private String hoTen;
        private String diaChi;
        private String email;
        private String soDienThoai;
        private String soCMND;

        public QuanLi(int maQuanLi, String hoTen, String diaChi, String email, String soDienThoai, String soCMND)
        {
            this.maQuanLi = maQuanLi;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.soCMND = SoCMND;
        }

        public QuanLi(DataRow row)
        {
            this.maQuanLi = (int)row["ma"];
            this.hoTen = row["hoTen"].ToString();
            this.diaChi = row["diaChi"].ToString();
            this.email = row["email"].ToString();
            this.soDienThoai = row["soDienThoai"].ToString();
            this.soCMND = row["soCMND"].ToString();
        }

        public int MaQuanLi { get => maQuanLi; set => maQuanLi = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
    }
}
