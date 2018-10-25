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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        List<KhachHang> GetKhachHang()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM KhachHang";
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<KhachHang> list = new List<KhachHang>();
            string MaKH, HoKH, TenKH, DiaChiKH, DienThoaiKH;
            while (dr.Read())
            {
                MaKH = dr[0].ToString();
                HoKH = dr[1].ToString();
                TenKH = dr[2].ToString();
                DiaChiKH = dr[3].ToString();
                DienThoaiKH = dr[4].ToString();

                KhachHang kh = new KhachHang(MaKH, HoKH, TenKH, DiaChiKH, DienThoaiKH);
                list.Add(kh);
            }
            dr.Close();
            cn.Close();
            return list;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                
                cn.Open();

                string sql = "INSERT INTO KhachHang VALUES('" + txtMaKH.Text + "',N'" + txtHoKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaKH.Text))
                    return;
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtMaKH.Text = "";
                    txtHoKH.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    txtMaKH.Focus();
                }
                GridKH.DataSource = GetKhachHang();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, mã khách hàng đã có người sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            GridKH.DataSource = GetKhachHang();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string cnsql = "Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "DELETE FROM KhachHang WHERE MaKhachHang = '" + txtMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            if (string.IsNullOrEmpty(txtMaKH.Text))
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
            GridKH.DataSource = GetKhachHang();
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
            string sql = "UPDATE KhachHang SET HoKhachHang = @HoKhachHang, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE  MaKhachHang = @MaKhachHang";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaKhachHang", txtMaKH.Text);
            cmd.Parameters.AddWithValue("HoKhachHang", txtHoKH.Text);
            cmd.Parameters.AddWithValue("TenKhachHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDienThoai.Text);
            cmd.ExecuteNonQuery();
            GridKH.DataSource = GetKhachHang();
            cn.Close();
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang = @MaKhachHang ";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaKhachHang", txtTimKH.Text);
            cmd.Parameters.AddWithValue("HoKhachHang", txtHoKH.Text);
            cmd.Parameters.AddWithValue("TenKhachHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDienThoai.Text);
            
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridKH.DataSource = dt;
            cn.Close();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.LightSteelBlue;
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
