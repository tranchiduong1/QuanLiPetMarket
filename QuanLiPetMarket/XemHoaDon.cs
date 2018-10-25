using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiPetMarket
{
    public class XemHoaDon
    {
        public string MaHDBan { get; set; }
        public string MaNhanVien { get; set; }

        public string NgayBan { get; set; }
        public string MaKhachHang { get; set; }

        public XemHoaDon(string MaHDBan, string MaNhanVien, string NgayBan, string MaKhachHang)
        {
            this.MaHDBan = MaHDBan;
            this.MaNhanVien = MaNhanVien;
            this.NgayBan = NgayBan;
            this.MaKhachHang = MaKhachHang;
        }
    }
}
