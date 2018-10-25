using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLiPetMarket
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }
        List<OrderDetails> GetODDT()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM HoaDonChiTiet";
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<OrderDetails> list = new List<OrderDetails>();
            string MaHDBan, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien;
            while (dr.Read())
            {
                MaHDBan = dr[0].ToString();
                MaSanPham = dr[1].ToString();
                SoLuong = dr[2].ToString();
                DonGia = dr[3].ToString();
                GiamGia = dr[4].ToString();
                ThanhTien = dr[5].ToString();
               

                OrderDetails odd = new OrderDetails(MaHDBan, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien);
                list.Add(odd);
            }
            
            cn.Close();

            return list;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmXemHoaDon xhd = new frmXemHoaDon();
            xhd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                int thanhtien = (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSoLuong.Text)) - Int32.Parse(txtGiamGia.Text);
                if(txtDonGia.Text != null && txtSoLuong.Text != null && txtGiamGia != null)
                {
                    txtThanhTien.Text = thanhtien.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Phải nhập đơn giá, số lượng, giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGia.Focus();
            }
        }
        public void Reset()
        {
            txtMaHD.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            txtMaHD.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "INSERT INTO HoaDonChiTiet VALUES('" + txtMaHD.Text + "',N'" + txtMaSP.Text + "',N'" + txtSoLuong.Text + "',N'" + txtDonGia.Text + "',N'" + txtGiamGia.Text + "',N'" + txtThanhTien.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaHD.Text))
                    return;
                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                GridHoaDon.DataSource = GetODDT();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, mã hoá đơn bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "UPDATE HoaDonChiTiet SET MaSanPham = @MaSanPham, SoLuong = @SoLuong, DonGia = @DonGia, GiamGia = @GiamGia, ThanhTien = @ThanhTien WHERE  MaHDBan = @MaHDBan";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("MaHDBan", txtMaHD.Text);
                cmd.Parameters.AddWithValue("MaSanPham", txtMaSP.Text);
                cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
                cmd.Parameters.AddWithValue("GiamGia", txtGiamGia.Text);
                cmd.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
                cmd.ExecuteNonQuery();
                GridHoaDon.DataSource = GetODDT();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Phải nhập đủ Mã Hoá Đơn và Mã Loại Sản Phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            GridHoaDon.DataSource = GetODDT();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM HoaDonChiTiet WHERE MaHDBan = @MaHDBan";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaHDBan", txtMaHD.Text);
            cmd.Parameters.AddWithValue("MaSanPham", txtMaSP.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("GiamGia", txtGiamGia.Text);
            cmd.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridHoaDon.DataSource = dt;
            cn.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            //cbMaLSP.Text = cbMaLSP.SelectedText;
            string sql = "DELETE FROM HoaDonChiTiet WHERE MaHDBan ='" + txtMaHD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (string.IsNullOrEmpty(txtMaSP.Text))
                return;

            int numOfRows = cmd.ExecuteNonQuery();
            if (numOfRows == 0)
            {
                MessageBox.Show("Không tìm được dữ liệu để xoá hoặc chưa nhập đủ mã hoá đơn và mã sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            GridHoaDon.DataSource = GetODDT();
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            GridHoaDon.DataSource = GetODDT();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            if (MessageBox.Show("Bạn muốn đóng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
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
