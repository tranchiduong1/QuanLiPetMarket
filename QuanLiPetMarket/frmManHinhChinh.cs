using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPetMarket
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Visible = false;
            dn.Show();           
            
        }

        private void btLienhe_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            lh.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Pink;
            label2.ForeColor = Color.Black;
        }
    }
}
