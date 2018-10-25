using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiPetMarket
{
    public partial class frmXacNhanXoaNV : Form
    {
        public frmXacNhanXoaNV()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string tk, mk;
            tk = txtTK.Text;
            mk = txtMK.Text;
            if (tk == "1651010034duong" && mk == "duong123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
