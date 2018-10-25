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
    public partial class frmThemAccount : Form
    {
        public frmThemAccount()
        {
            InitializeComponent();
        }
        List<ThemAccount> CreateAC()
        {
            string cnsql = "Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnsql);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM TaiKhoanNhanVien";
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            List<ThemAccount> list = new List<ThemAccount>();
            string tk, mk;
            while (dr.Read())
            {
                tk = dr[0].ToString();
                mk = dr[1].ToString();             

                ThemAccount them = new ThemAccount(tk,mk);
                list.Add(them);
            }
            dr.Close();
            cn.Close();

            return list;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string themTK = "insert into TaiKhoanNhanVien values('" + txtNewAC.Text + "',N'" + txtnewPW.Text + "')";
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");           
                conn.Open();
                SqlCommand cmd = new SqlCommand(themTK, conn);
                if (string.IsNullOrEmpty(txtNewAC.Text))
                    return;
                string cfpw = txtConfirmPW.Text;
                if (cfpw != txtnewPW.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int numOfRows = cmd.ExecuteNonQuery();
                    if (numOfRows > 0)
                    {
                        if (MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
                        {
                            txtNewAC.Text = "";
                            txtnewPW.Text = "";
                            txtConfirmPW.Text = "";
                            txtNewAC.Focus();
                        }
                        
                    }
                }
                List<ThemAccount> list = new List<ThemAccount>();
                list = CreateAC();
                conn.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Tài khoản đã có người sử dụng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNewAC.Text = "";
                txtnewPW.Text = "";
                txtConfirmPW.Text = "";
                txtNewAC.Focus();

            }

            

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtNewAC.Text = "";
            txtnewPW.Text = "";
            txtConfirmPW.Text = "";
            txtNewAC.Focus();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}
