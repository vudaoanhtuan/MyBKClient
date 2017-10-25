using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBK.Lib.Data.DangKy {
    class LoaiDangKy {
        public String namHoc { get; set; }
        public String tenLoaiDK { get; set; }
        public String hocKyID { get; set; }

        public override string ToString() {
            String res = "Id: " + hocKyID + "\n"
                + "Nam hoc: " + namHoc + "\n"
                + "Ten: " + tenLoaiDK +"\n";
            return res;
        }
    }
}
