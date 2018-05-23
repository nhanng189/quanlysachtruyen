using QuanLyLopVe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSachTruyen.DAO
{
    class TheLoaiSachDAO
    {
        private static TheLoaiSachDAO instance;

        public static TheLoaiSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiSachDAO(); return instance;
            }
            private set
            {
                TheLoaiSachDAO.instance = value;
            }
        }

        private TheLoaiSachDAO() { }

        public DataTable GetListTheLoaiSach()
        {
            String query = "SELECT * FROM theLoaiSach";

            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
