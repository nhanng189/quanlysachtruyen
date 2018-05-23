using QuanLyLopVe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAO(); return instance;
            }
            private set
            {
                KhachHangDAO.instance = value;
            }
        }

        private KhachHangDAO() { }

        public DataTable GetListKhachHangByMa(int ma)
        {
            String query = "SELECT * FROM khachHang WHERE ma = " + ma;

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetListKhachHangByTen(String ten)
        {
            string pattern = "., ";
            List<String> substrings = Regex.Split(ten, pattern).ToList();

            String query = "SELECT * FROM khachHang WHERE ";

            StringBuilder que = new StringBuilder(query);

            foreach (String substring in substrings)
            {
                que.Append("ten LIKE '%" + substring + "%' OR ");
            }
            que.Append("1!=1");

            query = que.ToString();

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool InsertKhachHang(string hoTen, string diaChi, string soDienThoai, string soCMND)
        {
            string query = "Exec USP_InsertKhachHang @hoTen , @diaChi , @soDienThoai , @soCMND";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { hoTen, diaChi, soDienThoai, soCMND });
            return res > 0;
        }

        public bool EditKhachHang(int ma, string hoTen, string diaChi, string soDienThoai, string soCMND)
        {
            string query = "Exec USP_EditKhachHang @ma , @hoTen , @diaChi , @soDienThoai , @soCMND";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma, hoTen, diaChi, soDienThoai, soCMND });
            return res > 0;
        }

        public bool DeleteKhachHang(int ma)
        {
            string query = "Exec USP_DeleteKhachHang @ma";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            return res > 0;
        }
    }
}
