using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSachTruyen.UI
{
    public partial class ThemSach : UserControl
    {
        public ThemSach()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clearTxb();
        }

        void clearTxb()
        {
            txbTenSach.Text = "";
            txbTheLoai.Text = "";
            txbLoai.Text = "";
            txbTacGia.Text = "";
            txbSoLuong.Text = "";
            txbGiaChoThue.Text = "";
            txbGiaThanh.Text = "";
        }
    }
}
