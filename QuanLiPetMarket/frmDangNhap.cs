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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtID.Text;
                string mk = txtPW.Text;
                string sql = " Select * from TaiKhoanNhanVien where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu frmMenu = new frmMenu();
                    this.Visible = false;
                    frmMenu.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtID.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void checkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPW.Checked)
            {
                txtPW.UseSystemPasswordChar = true;
            }
            else
            {
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Pink;
            label4.ForeColor = Color.Black;
        }
    }
}
