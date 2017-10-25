using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBK.Lib.Data.MonHoc {
    class LopHoc {
        public String nhomLop { get; set; }
        public String siSoLop { get; set; }
        public String soSVDK { get; set; }
        public String ngonNgu { get; set; }
        public String nhomLT { get; set; }
        public String nhomBT { get; set; }
        public String gvLT { get; set; }
        public String gvBT { get; set; }
        public BuoiHoc[] buoiHoc { get; set; }

        public override string ToString() {
            String res = "";
            res = res + "Nhom lop: " + nhomLop + "\n";
            res = res + "Si so: " + siSoLop + "\n";
            res = res + "Dang ki: " + soSVDK + "\n";
            res = res + "Ngon ngu: " + ngonNgu + "\n";
            res = res + "Nhom LT: " + nhomLT + "\n";
            res = res + "GVLT: " + gvLT + "\n";
            res = res + "Nhom BT: " + nhomBT + "\n";
            res = res + "GVBT: " + gvBT + "\n";
            foreach (BuoiHoc buoiHoc in buoiHoc) {
                res = res + buoiHoc.ToString() + '\n';
            }
            return res;

        }
    }
}
