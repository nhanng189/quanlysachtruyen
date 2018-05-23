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
    public partial class fGiaoDien : Form
    {
        public fGiaoDien()
        {
            InitializeComponent();
            SidePanel.Height = btnSach.Height;
            SidePanel.Top = btnSach.Top;
            colorButton();
            btnSach.BackColor = Color.MediumOrchid;
            sach1.BringToFront();
            panelSach.BringToFront();
        }

        private void colorButton()
        {
            btnKhachHang.BackColor = Color.DarkOrchid;
            btnSach.BackColor = Color.DarkOrchid;
            btnTaiKhoan.BackColor = Color.DarkOrchid;
            btnThueSach.BackColor = Color.DarkOrchid;
            btnThongKe.BackColor = Color.DarkOrchid;
            btnSachChoThue.BackColor = Color.DarkOrchid;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSach.Height;
            SidePanel.Top = btnSach.Top;
            colorButton();
            btnSach.BackColor = Color.MediumOrchid;
            sach1.BringToFront();
            panelSach.BringToFront();
            //Re InitializeComponent();
        }

        private void btnThueSach_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThueSach.Height;
            SidePanel.Top = btnThueSach.Top;
            colorButton();
            btnThueSach.BackColor = Color.MediumOrchid;
            thueSach1.BringToFront();
            panelThueSach.BringToFront();
            //Re InitializeComponent();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThongKe.Height;
            SidePanel.Top = btnThongKe.Top;
            colorButton();
            btnThongKe.BackColor = Color.MediumOrchid;
            thongKe1.BringToFront();
            panelThongKe.BringToFront();
            //Re InitializeComponent();

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTaiKhoan.Height;
            SidePanel.Top = btnTaiKhoan.Top;
            colorButton();
            btnTaiKhoan.BackColor = Color.MediumOrchid;
            taiKhoan1.BringToFront();
            panelTaiKhoan.BringToFront();
            //Re InitializeComponent();

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnKhachHang.Height;
            SidePanel.Top = btnKhachHang.Top;
            colorButton();
            btnKhachHang.BackColor = Color.MediumOrchid;
            khachHang1.BringToFront();
            panelKhachHang.BringToFront();
            //Re InitializeComponent();

        }

        private void btnSachChoThue_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSachChoThue.Height;
            SidePanel.Top = btnSachChoThue.Top;
            colorButton();
            btnSachChoThue.BackColor = Color.MediumOrchid;
            sachChoThue1.BringToFront();
            panelSachChoThue.BringToFront();
            //Re InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
