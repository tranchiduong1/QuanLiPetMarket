using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiPetMarket
{
    public class LoaiSanPham
    {
        public string MaLoaiSanPham { get; set; }
        public string  TenLoaiSanPham { get; set; }

        public LoaiSanPham(string MaLoaiSanPham, string TenLoaiSanPham)
        {
            this.MaLoaiSanPham = MaLoaiSanPham;
            this.TenLoaiSanPham = TenLoaiSanPham;
        }
    }
}
