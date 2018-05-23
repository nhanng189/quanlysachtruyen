using QuanLyLopVe.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DAO
{
    class SachDAO
    {
        private static SachDAO instance;

        public static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO(); return instance;
            }
            private set
            {
                SachDAO.instance = value;
            }
        }

        private SachDAO() { }

        //Lấy danh sách sách
        //OK
        public DataTable GetListSach()
        {
            String query = "SELECT * FROM sach";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetListSachByMa(int ma)
        {
            String query = "SELECT * FROM sach WHERE ma = " + ma;

            return DataProvider.Instance.ExcuteQuery(query);
        }

        //Tìm sách theo tên sách
        //OK
        public DataTable GetListSachByTen(String ten)
        {
            ten.Replace("--", " ");
            List<String> substrings = Regex.Matches(ten, @"[^\W\d](\w|[-']{1,2}(?=\w))*").Cast<Match>().Select(m => m.Value).ToList();

            String query = "SELECT * FROM sach WHERE ";

            StringBuilder que = new StringBuilder(query);

            foreach (String substring in substrings)
            {
                que.Append("ten LIKE '%" + substring + "%' OR ");
            }
            que.Append("1!=1");

            query = que.ToString();

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetListSachByTenVaTheLoai(String ten, String tenTheLoai)
        {
            ten.Replace("--", " ");
            List<String> substrings = Regex.Matches(ten, @"[^\W\d](\w|[-']{1,2}(?=\w))*").Cast<Match>().Select(m => m.Value).ToList();

            String query = "SELECT sach.* FROM sach, theLoaiSach WHERE theLoaiSach.ten = '" + tenTheLoai + "' AND sach.theLoaiSach = theLoaiSach.ma and(";

            StringBuilder que = new StringBuilder(query);

            foreach (String substring in substrings)
            {
                que.Append("sach.ten LIKE '%" + substring + "%' OR ");
            }
            que.Append("1!=1)");

            query = que.ToString();

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool InsertSach(string ten, string theLoaiSach, string loaiSach, string tacGia, float giaThanh, float giaChoThue)
        {
            string query = "Exec USP_InsertSach @ten , @theLoaiSach , @loaiSach , @tacGia , @giaThanh , @giaChoThue";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ten, theLoaiSach, loaiSach, tacGia, giaThanh, giaChoThue });
            return res > 0;
        }

        public bool EditSach(int ma, string ten, string theLoaiSach, string loaiSach, string tacGia, float giaThanh, float giaChoThue)
        {
            string query = "Exec USP_EditSach @ma , @ten , @theLoaiSach , @loaiSach , @tacGia , @giaThanh , @giaChoThue";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma, ten, theLoaiSach, loaiSach, tacGia, giaThanh, giaChoThue });
            return res > 0;
        }

        //Xóa sách
        //OK
        public bool DeleteSach(int ma)
        {
            string query = "DELETE FROM sach WHERE ma = @ma and sach.soLuongThuc = sach.soLuongCon";
            int res = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            return res > 0;
        }
    }
}
