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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        List<LoaiSanPham> GetLoaiSP()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM LoaiSanPham";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            List<LoaiSanPham> list = new List<LoaiSanPham>();
            string MaLoaiSanPham, TenLoaiSanPham;
            while (dr.Read())
            {
                MaLoaiSanPham = dr[0].ToString();
                TenLoaiSanPham = dr[1].ToString();

                LoaiSanPham lsp = new LoaiSanPham(MaLoaiSanPham,TenLoaiSanPham);
                list.Add(lsp);
            }
            dr.Close();
            cn.Close();

            return list;

        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            GridLoaiSP.DataSource = GetLoaiSP();
        }
        public void Reset()
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
            txtMaloai.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "INSERT INTO LoaiSanPham VALUES('" + txtMaloai.Text + "',N'" + txtTenloai.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaloai.Text))
                    return;
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                GridLoaiSP.DataSource = GetLoaiSP();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, mã loại bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string cnsql = "Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "DELETE FROM LoaiSanPham WHERE MaLoaiSanPham = '" + txtMaloai.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            if (string.IsNullOrEmpty(txtMaloai.Text))
            {
                return;
            }

            int numOfRows = cmd.ExecuteNonQuery();
            if (numOfRows == 0)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GridLoaiSP.DataSource = GetLoaiSP();
            cn.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
         
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "UPDATE LoaiSanPham SET TenLoaiSanPham = @TenLoaiSanPham WHERE  MaLoaiSanPham = @MaLoaiSanPham";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("MaLoaiSanPham", txtMaloai.Text);
                cmd.Parameters.AddWithValue("TenLoaiSanPham", txtTenloai.Text);
                cmd.ExecuteNonQuery();
                GridLoaiSP.DataSource = GetLoaiSP();
                cn.Close();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM LoaiSanPham WHERE  MaLoaiSanPham = @MaLoaiSanPham";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaLoaiSanPham", txtTimLSP.Text);
            cmd.Parameters.AddWithValue("TenLoaiSanPham", txtTenloai.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridLoaiSP.DataSource = dt;
            cn.Close();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightSteelBlue;
            label5.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
