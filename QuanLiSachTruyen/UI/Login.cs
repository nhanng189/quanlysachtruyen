using QuanLiSachTruyen.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSachTruyen.UI
{
    public partial class Login : Form
    {
        private int ma = -1;

        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            fGiaoDien formGiaoDien = new fGiaoDien();

            if (QuanliBUS.Instance.IsQuanLi(txtDangNhap, txtMatKhau) > 0)
            {
                ma = QuanliBUS.Instance.IsQuanLi(txtDangNhap, txtMatKhau);
                formGiaoDien.Show();
                MessageBox.Show("mã quản lí là " + ma.ToString());
                this.Hide();
            }
            else
            {
                // thêm UI thông báo mật khẩu hoặc tên đăng nhập k đúng
                MessageBox.Show("tên và mật khẩu không hợp lệ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
