using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class TheLoaiSach
    {
        private int maTheLoai;
        private String tenTheLoai;
        private int soLuong;

        public TheLoaiSach(int maTheLoai, String tenTheLoai, int soLuong)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
            this.soLuong = soLuong;
        }

        public TheLoaiSach(DataRow row)
        {
            this.maTheLoai = (int)row["ma"];
            this.tenTheLoai = row["ten"].ToString();
            this.soLuong = (int)row["soLuong"];
        }

        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
