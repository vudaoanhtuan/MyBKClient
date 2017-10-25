using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBK.Lib.Data.DangKy {
    class DotDangKy {
        public String idDotDangKy { get; set; }
        public String tenDotDangKy { get; set; }

        public override string ToString() {
            return "Id: " + idDotDangKy + "\n"
                + "Ten: " + tenDotDangKy + "\n";
        }
    }
}
