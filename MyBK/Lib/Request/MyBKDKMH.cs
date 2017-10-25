using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace MyBK.Lib.Request {
    class MyBKDKMH {
        CookieContainer cookieSession;
        public MyBKDKMH() {
            cookieSession = POST.Login("username", "password");
        }

        public String getDanhSachDotDK(String hocKyId) {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/getDanhSachDotDK.action", "hocKyId=" + hocKyId, cookieSession);
        }

        public String getLichDangKy(String dotDKId, String DKHocVienID) {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/getLichDangKy.action",
                                    "dotDKId=" + dotDKId + "&dotDKHocVienId=" + DKHocVienID,
                                    cookieSession);
        }

        public String getDanhSachMonHocDangKy(String dotDKId) {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/getDanhSachMonHocDangKy.action",
                                    "dotDKId=" + dotDKId,
                                    cookieSession);
        }

        public String getKetQuaDangKy() {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/getKetQuaDangKy.action", "", cookieSession);
        }

        public String searchMonHocDangKy(String msmh) {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/searchMonHocDangKy.action",
                                "msmh=" + msmh,
                                cookieSession);
        }

        public String getThongTinNhomLopMonHoc(String monHocId) {
            return POST.sendPOST("http://mybk.hcmut.edu.vn/dkmh/getThongTinNhomLopMonHoc.action",
                                "monHocId=" + monHocId,
                                cookieSession);
        }

    }
}
