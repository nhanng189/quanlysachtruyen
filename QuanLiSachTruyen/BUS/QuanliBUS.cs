using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using QuanLiSachTruyen.DAO;

namespace QuanLiSachTruyen.BUS
{
    class QuanliBUS
    {
        private static QuanliBUS instance;

        public static QuanliBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuanliBUS();
                return instance;
            }
        }

        private QuanliBUS() { }

        public int IsQuanLi(MetroTextBox txtDangNhap, MetroTextBox txtMatKhau)
        {
            String dangNhap = txtDangNhap.Text.ToString().Trim();
            String matKhau = txtMatKhau.Text.ToString().Trim();

            return QuanLiDAO.Instance.IsQuanli(dangNhap, matKhau);
        }
    }
}
