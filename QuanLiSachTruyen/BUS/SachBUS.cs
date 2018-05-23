using MetroFramework.Controls;
using QuanLiSachTruyen.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSachTruyen.BUS
{
    class SachBUS
    {
        private static SachBUS instance;

        public static SachBUS Instance
        {
            get
            {
                if (instance == null) instance = new SachBUS();
                return instance;
            }
        }

        private SachBUS() { }

        //Lấy danh sách sách
        //OK
        public void GetListSach(MetroGrid gridSach)
        {
            gridSach.DataSource = SachDAO.Instance.GetListSach();
        }

        // Xóa sách
        // OK
        public bool DeleteSach(MetroGrid gridSach)
        {
            if (gridSach.CurrentCell == null)
                return false;

            DataGridViewRow row = gridSach.SelectedCells[0].OwningRow;

            int ma = (int)row.Cells["ma"].Value;

            return SachDAO.Instance.DeleteSach(ma);
        }

        //Tìm kiếm sách theo tên sách
        //OK
        public static bool GetListSachByTen(MetroTextBox txtTimKiem, MetroGrid gridSach)
        {
            string timKiem = txtTimKiem.Text.ToString().Trim();

            gridSach.DataSource = SachDAO.Instance.GetListSachByTen(timKiem);

            //Không có sách thỏa yêu cầu
            if (gridSach.Rows.Count == 0) return false;
            //Có sách
            else return true;
        }
    }
}