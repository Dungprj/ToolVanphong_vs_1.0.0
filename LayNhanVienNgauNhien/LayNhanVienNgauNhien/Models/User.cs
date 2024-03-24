using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayNhanVienNgauNhien
{
    public class User
    {
        private static int nextUID = 0;
        public String maNV { get; set; }
        public String hoTen { get; set; }
        public String phongBan { get; set; }
        public String chucDanh { get; set; }
        public int UID { get; set; }

        public User(String maNV,String hoTen,String phongBan,String chucDanh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.phongBan = phongBan;
            this.chucDanh = chucDanh;
            UID = nextUID++;
        }

        public User()
        {
            this.maNV = "";
            this.hoTen = "";
            this.phongBan = "";
            this.chucDanh = "";
            UID = nextUID++;
        }
    }
}
