using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiPetMarket
{
    public class ThemAccount
    {
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }

        public ThemAccount(string tk, string mk)
        {
            this.taiKhoan = tk;
            this.matKhau = mk;
        }
    }
}
