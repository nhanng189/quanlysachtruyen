using QuanLyLopVe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DAO
{
    class QuanLiDAO
    {
        private static QuanLiDAO instance;

        public static QuanLiDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuanLiDAO(); return instance;
            }
            private set
            {
                QuanLiDAO.instance = value;
            }
        }

        private QuanLiDAO() { }

        public int IsQuanli(string fDangNhap, string fMatKhau)
        {
            fDangNhap.Replace("-", "");
            fMatKhau.Replace("-", "");

            String query = "SELECT ma FROM Quanli where tenHienThi = @tenHienThi and matKhau = @matKhau ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { fDangNhap, fMatKhau });

            if (data == null || data.Rows.Count < 1)
            {
                return -1;
            }
            DataRow row = data.Rows[0];

            return (int)row["ma"];

            // k xóa cmt này
            //foreach (DataRow row in data.Rows)
            //{
            //    int ma = (int)row["ma"];
            //    string tenHienThi = row["tenHienThi"].ToString().Trim();
            //    string matKhau = row["matKhau"].ToString().Trim();
            //    string hoTen = row["hoTen"].ToString().Trim();
            //    string diaChi = row["diaChi"].ToString().Trim();
            //    string email = row["email"].ToString().Trim();
            //    string soDienThoai = row["soDienThoai"].ToString().Trim();
            //    string soCMND = row["soCMND"].ToString().Trim();
            //}
        }
    }
}
