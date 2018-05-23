using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class LoaiSach
    {
        private int maLoai;
        private String tenLoai;
        private int soLuong;

        public LoaiSach(int maLoai, String tenLoai, int soLuong)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.soLuong = soLuong;
        }

        public LoaiSach(DataRow row)
        {
            this.maLoai = (int)row["ma"];
            this.tenLoai = row["ten"].ToString();
            this.soLuong = (int)row["soLuong"];
        }

        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
