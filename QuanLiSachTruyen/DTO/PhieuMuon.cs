using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DTO
{
    class PhieuMuon
    {
        private int maPhieu;
        private int maKhachHang;
        private int maSach;
        private int maQuanLi;
        private DateTime ngayMuon;
        private DateTime ngayTra;

        public PhieuMuon(int maPhieu, int maKhachHang, int maSach, int maQuanLi, DateTime ngayMuon, DateTime ngayTra)
        {
            this.maPhieu = maPhieu;
            this.maKhachHang = maKhachHang;
            this.maSach = maSach;
            this.maQuanLi = maQuanLi;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
        }

        public PhieuMuon(DataRow row)
        {
            this.maPhieu = (int)row["ma"];
            this.maKhachHang = (int)row["maKhachHang"];
            this.maSach = (int)row["maSach"];
            this.maQuanLi = (int)row["maQuanLi"];

            if (row["ngayMuon"] != DBNull.Value)
            {
                this.ngayMuon = Convert.ToDateTime(row["ngayMuon"]);
            }

            if (row["ngayTra"] != DBNull.Value)
            {
                this.ngayTra = Convert.ToDateTime(row["ngayTra"]);
            }
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaSach { get => maSach; set => maSach = value; }
        public int MaPhieu { get => maPhieu; set => maPhieu = value; }
        public int MaQuanLi { get => maQuanLi; set => maQuanLi = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
