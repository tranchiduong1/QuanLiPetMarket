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
    public partial class frmQuanTri : Form
    {
        public frmQuanTri()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmThemAccount add = new frmThemAccount();
            add.Show();
        }
        List<QuanTri> GetNhanVien()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM NhanVien";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            List<QuanTri> list = new List<QuanTri>();
            string MaNV, HoNV, TenNV, CD, NS, NBDLV, GT, DC, SDT;
            while (dr.Read())
            {
                MaNV = dr[0].ToString();
                HoNV = dr[1].ToString();
                TenNV = dr[2].ToString();
                CD = dr[3].ToString();
                NS = dr[4].ToString();
                NBDLV = dr[5].ToString();
                GT = dr[6].ToString();
                DC = dr[7].ToString();
                SDT = dr[8].ToString();

                QuanTri qt = new QuanTri(MaNV,HoNV,TenNV,CD,NS,NBDLV,GT,DC,SDT);
                list.Add(qt);
            }
            dr.Close();
            cn.Close();

            return list;

        }
        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            GridNhanVien.DataSource = GetNhanVien();
        }
        public void Reset()
        {
            txtMaNV.Text = "";
            txtHoNV.Text = "";
            txtTenNV.Text = "";
            txtChucDanh.Text = "";
            txtNgaySinh.Text = "";
            txtStartDate.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMaNV.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "INSERT INTO NhanVien VALUES('" + txtMaNV.Text + "',N'" + txtHoNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtChucDanh.Text + "',N'" + txtNgaySinh.Text + "',N'" + txtStartDate.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaNV.Text))
                    return;
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công, yêu cầu tạo tài khoản cho nhân viên mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    Reset();
                }
                GridNhanVien.DataSource = GetNhanVien();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, mã nhân viên bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXacNhanXoaNV xn = new frmXacNhanXoaNV();
            xn.ShowDialog();
            string cnsql = "Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            if (string.IsNullOrEmpty(txtMaNV.Text))
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
            GridNhanVien.DataSource = GetNhanVien();
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
                string sql = "UPDATE NhanVien SET HoNhanVien = @HoNhanVien, TenNhanVien = @TenNhanVien, ChucDanh = @ChucDanh, NgaySinh = @NgaySinh, NgayBatDauLamViec = @NgayBatDauLamViec, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE  MaNhanVien = @MaNhanVien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("MaNhanVien", txtMaNV.Text);
                cmd.Parameters.AddWithValue("HoNhanVien", txtHoNV.Text);
                cmd.Parameters.AddWithValue("TenNhanVien", txtTenNV.Text);
                cmd.Parameters.AddWithValue("ChucDanh", txtChucDanh.Text);
                cmd.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
                cmd.Parameters.AddWithValue("NgayBatDauLamViec", txtStartDate.Text);
                cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("SoDienThoai", txtSDT.Text);
            cmd.ExecuteNonQuery();
                GridNhanVien.DataSource = GetNhanVien();
                cn.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM NhanVien WHERE  MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaNhanVien", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoNhanVien", txtHoNV.Text);
            cmd.Parameters.AddWithValue("TenNhanVien", txtTenNV.Text);
            cmd.Parameters.AddWithValue("ChucDanh", txtChucDanh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
            cmd.Parameters.AddWithValue("NgayBatDauLamViec", txtStartDate.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("SoDienThoai", txtSDT.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridNhanVien.DataSource = dt;
            cn.Close();
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.BackColor = Color.Black;
            label11.BackColor = Color.White;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.LightSteelBlue;
            label11.ForeColor = Color.Black;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            GridNhanVien.DataSource = GetNhanVien();
        }
    }
}
