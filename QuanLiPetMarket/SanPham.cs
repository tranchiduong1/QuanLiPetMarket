using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiPetMarket
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLSP { get; set; }
        public string  SLTonKho { get; set; }
        public string DGNhap { get; set; }
        public string DGBan { get; set; }

        public SanPham(string MaSP, string TenSP, string MaLSP, string SLTonKho, string DGNhap, string DGBan)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.MaLSP = MaLSP;
            this.SLTonKho = SLTonKho;
            this.DGNhap = DGNhap;
            this.DGBan = DGBan;
        }
    }
}
