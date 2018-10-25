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
    public partial class frmXemHoaDon : Form
    {
        public frmXemHoaDon()
        {
            InitializeComponent();
        }
        List<XemHoaDon> GetXemHoaDon()
        {

            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM HoaDon";
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<XemHoaDon> listxhd = new List<XemHoaDon>();
            string MaHDBan, MaNhanVien, NgayBan, MaKhachHang, TongTien;
            while (dr.Read())
            {
                MaHDBan = dr[0].ToString();
                MaNhanVien = dr[1].ToString();
                NgayBan = dr[2].ToString();
                MaKhachHang = dr[3].ToString();

                XemHoaDon xhd = new XemHoaDon(MaHDBan, MaNhanVien, NgayBan, MaKhachHang);
                listxhd.Add(xhd);
            }
            dr.Close();
            cn.Close();
            return listxhd;
        }
        public void Reset()
        {
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtNgayBan.Text = "";
            txtMaKH.Text = "";
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            //cbMaLSP.Text = cbMaLSP.SelectedText;
            string sql = "DELETE FROM HoaDon WHERE MaHDBan ='" + txtMaHD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (string.IsNullOrEmpty(txtMaHD.Text))
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
            GridXemHD.DataSource = GetXemHoaDon();
            cn.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                if (string.IsNullOrEmpty(txtNgayBan.Text))
                {
                    txtNgayBan.Text = DateTime.Now.ToString();
                }
                txtNgayBan.Text = DateTime.Now.ToString();
                string sql = "INSERT INTO HoaDon VALUES('" + txtMaHD.Text + "',N'" + txtMaNV.Text + "',N'" + txtNgayBan.Text + "',N'" + txtMaKH.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (string.IsNullOrEmpty(txtMaHD.Text))
                    return;

                int numOfRows = cmd.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }

                GridXemHD.DataSource = GetXemHoaDon();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, trùng mã đơn hàng hoặc nhập sai mã nhân viên và mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            GridXemHD.DataSource = GetXemHoaDon();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            if (MessageBox.Show("Bạn muốn đóng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
                cn.Open();
                string sql = "UPDATE HoaDon SET MaNhanVien = @MaNhanVien, NgayBan = @NgayBan, MaKhachHang= @MaKhachHang WHERE MaHDBan = @MaHDBan";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("MaHDBan", txtMaHD.Text);
                cmd.Parameters.AddWithValue("MaNhanVien", txtMaNV.Text);
                cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
                cmd.Parameters.AddWithValue("MaKhachHang", txtMaKH.Text);
                cmd.ExecuteNonQuery();
                GridXemHD.DataSource = GetXemHoaDon();
                cn.Close();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            catch
            {
                MessageBox.Show("Phải nhập đủ mã nhân viên và mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM HoaDon WHERE MaHDBan = @MaHDBan ";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaHDBan", txtMaHD.Text);
            cmd.Parameters.AddWithValue("MaNhanVien", txtMaNV.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.Parameters.AddWithValue("MaKhachHang", txtMaKH.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridXemHD.DataSource = dt;
            cn.Close();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.LightSteelBlue;
            label6.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReFr_Click(object sender, EventArgs e)
        {
            Reset();
            GridXemHD.DataSource = GetXemHoaDon();
        }
    }
}
