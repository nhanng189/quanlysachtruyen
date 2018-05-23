using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSachTruyen.BUS;
using MetroFramework.Controls;

namespace QuanLiSachTruyen.UI
{
    public partial class Sach : UserControl
    {
        public Sach()
        {
            InitializeComponent();
            SachBUS.Instance.GetListSach(gridSach);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themSach1.Visible = true;
        }

        //Xóa sách
        //OK
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                SachBUS.Instance.DeleteSach(gridSach);
            }
            SachBUS.Instance.GetListSach(gridSach);
        }

        //Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!SachBUS.GetListSachByTen(txtTimKiem, gridSach))
            {
                MessageBox.Show("Không có quyển sách nào phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            else SachBUS.Instance.DeleteSach(gridSach);
        }
    }
}
