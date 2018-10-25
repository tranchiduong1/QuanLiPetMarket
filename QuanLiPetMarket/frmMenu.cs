using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLiPetMarket
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void itemMenuContact_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            lh.ShowDialog();
        }
        private void btHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google.com để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://google.com");
        }


        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham lsp = new frmLoaiSanPham();
            lsp.Show();
        }


        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanTri qt = new frmQuanTri();
            qt.Show();
        }

        private void btSP_Click(object sender, EventArgs e)
        {
            frmSanPham lsp = new frmSanPham();
            lsp.Show();
        }

        private void btLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham lsp = new frmLoaiSanPham();
            lsp.Show();
        }

        private void btDonHangChiTiet_Click(object sender, EventArgs e)
        {
            frmDonHang dh = new frmDonHang();
            dh.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
            Application.Exit();
        }



        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemHoaDon hd = new frmXemHoaDon();
            hd.Show();
        }

        private void customerINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonHang dh = new frmDonHang();
            dh.Show();
        }

        private void menuSP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google.com để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
