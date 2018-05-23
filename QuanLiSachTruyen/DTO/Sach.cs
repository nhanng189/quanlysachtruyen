using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class Sach
    {
        private int maSach;
        private String tenSach;
        private int maLoaiSach;
        private int maTheLoaiSach;
        private String tacGia;
        private int soLuongThuc;
        private int soLuongCon;
        private float giaThanh;
        private float giaChoThue;   // trên 1 ngày

        public Sach(int maSach, String tenSach, int maLoaiSach, int maTheLoaiSach, String tacGia, int soLuongThuc, int soLuongCon, float giaThanh, float giaChoThue)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.maLoaiSach = maLoaiSach;
            this.maTheLoaiSach = maTheLoaiSach;
            this.tacGia = tacGia;
            this.soLuongThuc = soLuongThuc;
            this.soLuongCon = soLuongCon;
            this.giaThanh = giaThanh;
            this.giaChoThue = giaChoThue;
        }

        public Sach(DataRow row)
        {
            this.maSach = (int)row["ma"];
            this.tenSach = row["ten"].ToString();
            this.maLoaiSach = (int)row["theLoaiSach"];
            this.maTheLoaiSach = (int)row["loaiSach"];
            this.tacGia = row["tacGia"].ToString();
            this.soLuongThuc = (int)row["soLuongThuc"];
            this.soLuongCon = (int)row["soLuongCon"];
            this.giaThanh = (float)row["giaThanh"];
            this.giaChoThue = (float)row["giaChoThue"];
        }

        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public float GiaThanh { get => giaThanh; set => giaThanh = value; }
        public float GiaChoThue { get => giaChoThue; set => giaChoThue = value; }
        public int MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public int MaTheLoaiSach { get => maTheLoaiSach; set => maTheLoaiSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int SoLuongThuc { get => soLuongThuc; set => soLuongThuc = value; }
        public int SoLuongCon { get => soLuongCon; set => soLuongCon = value; }
    }
}
