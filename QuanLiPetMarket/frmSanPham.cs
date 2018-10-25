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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        List<SanPham> GetSanPham()
        {

            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM SanPham";
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<SanPham> list = new List<SanPham>();
            string MaSP, TenSP, MaLSP, SLTonKho, DGNhap, DGBan;
            while (dr.Read())
            {
                MaSP = dr[0].ToString();
                TenSP = dr[1].ToString();
                MaLSP = dr[2].ToString();
                SLTonKho = dr[3].ToString();
                DGNhap = dr[4].ToString();
                DGBan = dr[5].ToString();

                SanPham sp = new SanPham(MaSP, TenSP, MaLSP, SLTonKho, DGNhap, DGBan);
                list.Add(sp);
            }
            cn.Close();
            return list;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            //cbMaLSP.DataSource = GetSanPham();
            //cbMaLSP.DisplayMember = "MaLoaiSanPham";
            //cbMaLSP.ValueMember = "MaSanPham";
            GridSP.DataSource = GetSanPham();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            if (MessageBox.Show("Bạn muốn đóng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                //cbMaLSP.Text = cbMaLSP.SelectedText; 
                string sql = "INSERT INTO SanPham VALUES('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtMaLSP.Text + "',N'" + txtSLTonKho.Text + "',N'" + txtDGNhap.Text + "',N'" + txtDGBan.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaSP.Text))
                    return;

                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                GridSP.DataSource = GetSanPham();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, trùng mã sản phẩm hoặc nhập thiếu Mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
        public void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMaLSP.Text = "";
            txtSLTonKho.Text = "";
            txtDGBan.Text = "";
            txtDGNhap.Text = "";
            txtMaSP.Focus();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            //cbMaLSP.Text = cbMaLSP.SelectedText;
            string sql = "DELETE FROM SanPham WHERE MaSanPham ='" + txtMaSP.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (string.IsNullOrEmpty(txtMaSP.Text))
                return;

            int numOfRows = cmd.ExecuteNonQuery();
            if (numOfRows == 0)
            {
                MessageBox.Show("Không tìm được dữ liệu để xoá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            GridSP.DataSource = GetSanPham();
            cn.Close();
        }

        private void btTimSP_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaSanPham", txtTimSP.Text);
            cmd.Parameters.AddWithValue("TenSanPham", txtTenSP.Text);
            cmd.Parameters.AddWithValue("MaLoaiSanPham", txtMaLSP.Text);
            cmd.Parameters.AddWithValue("SoLuongTonKho", txtSLTonKho.Text);
            cmd.Parameters.AddWithValue("DonGiaNhap", txtDGNhap.Text);
            cmd.Parameters.AddWithValue("DonGiaBan", txtDGBan.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridSP.DataSource = dt;
            cn.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "UPDATE SanPham SET TenSanPham = @TenSanPham, MaLoaiSanPham = @MaLoaiSanPham, SoLuongTonKho = @SoLuongTonKho, DonGiaNhap = @DonGiaNhap, DonGiaBan=@DonGiaBan WHERE  MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("MaSanPham", txtMaSP.Text);
                cmd.Parameters.AddWithValue("TenSanPham", txtTenSP.Text);
                cmd.Parameters.AddWithValue("MaLoaiSanPham", txtMaLSP.Text);
                cmd.Parameters.AddWithValue("SoLuongTonKho", txtSLTonKho.Text);
                cmd.Parameters.AddWithValue("DonGiaNhap", txtDGNhap.Text);
                cmd.Parameters.AddWithValue("DonGiaBan", txtDGBan.Text);
                cmd.ExecuteNonQuery();
                GridSP.DataSource = GetSanPham();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Phải nhập đủ Mã SP và Mã LSP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.BackColor = Color.Black;
            label9.ForeColor = Color.White;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.LightSteelBlue;
            label9.ForeColor = Color.Black;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimLSP_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM SanPham WHERE MaLoaiSanPham = @MaLoaiSanPham";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaSanPham", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSanPham", txtTenSP.Text);
            cmd.Parameters.AddWithValue("MaLoaiSanPham", txtTimLSP.Text);
            cmd.Parameters.AddWithValue("SoLuongTonKho", txtSLTonKho.Text);
            cmd.Parameters.AddWithValue("DonGiaNhap", txtDGNhap.Text);
            cmd.Parameters.AddWithValue("DonGiaBan", txtDGBan.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridSP.DataSource = dt;
            cn.Close();
        }

        private void btReFr_Click(object sender, EventArgs e)
        {
            Reset();
            GridSP.DataSource = GetSanPham();
        }
    }
}
