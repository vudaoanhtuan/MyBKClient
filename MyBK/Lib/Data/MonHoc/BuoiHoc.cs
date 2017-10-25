using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBK.Lib.Data.MonHoc {
    class BuoiHoc {
        public String thu { get; set; }
        public String tiet { get; set; }
        public String phong { get; set; }
        public String coSo { get; set; }
        public String lopLT { get; set; }
        public String lopBT { get; set; }
        public String tuan { get; set; }

        public override string ToString() {
            String res = "";
            res = res + "Thu: " + thu + "\n";
            res = res + "Tiet: " + tiet + "\n";
            res = res + "Phong: " + phong + "\n";
            res = res + "Co so: " + coSo + "\n";
            res = res + "Lop BT: " + lopBT + "\n";
            res = res + "Tuan hoc: " + tuan + "\n";
            return res;
        }

    }
}
