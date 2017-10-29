using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace MyBK.Lib.Request {
    class MyBKStInfo {
        CookieContainer cookieSession;
        String _token;
        public MyBKStInfo() {
            // Log in
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.config);
            String logined = sr.ReadLine();
            if (logined == null) {
                sr.Close();
                return;
            }
            String user = sr.ReadLine();
            String pass = sr.ReadLine();
            sr.Close();
            CookieContainer cc = POST.Login(user, pass);
            
            _token = null;
            if (cc != null) {
                HttpWebResponse res = GET.getResponse("http://www.aao.hcmut.edu.vn/stinfo/", cc);

                // Get cookie
                String strCookie = res.Headers.Get("Set-Cookie");

                String uri = "http://aao.hcmut.edu.vn/stinfo/";

                String[] listCookie = strCookie.Split(',');
                CookieContainer allCookie = new CookieContainer();

                String[] temp = listCookie[0].Split(';')[0].Split('=');
                Cookie ck = new Cookie(temp[0], temp[1]);
                cc.Add(new Uri(uri), ck);
                temp = listCookie[2].Split(';')[0].Split('=');
                ck = new Cookie(temp[0], temp[1]);
                cc.Add(new Uri(uri), ck);
                cookieSession = cc;

                // Get _token
                Stream dataStream = res.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(responseFromServer);
                HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/html/head//meta");
                String str_token = list[3].OuterHtml;
                str_token = str_token.Substring(str_token.IndexOf("content=") + 9, 40);
                _token = "_token=" + str_token;
                reader.Close();
                dataStream.Close();
                res.Close();
            }     
        }

        
        public String getLichThi() {
            String str = str = POST.sendPOST("http://www.aao.hcmut.edu.vn/stinfo/lichthi/ajax_lichthi", _token, cookieSession);
            return str; // JSON
        }

        public String getLichHoc() {
            // TKB cac ky
            String str = str = POST.sendPOST("http://www.aao.hcmut.edu.vn/stinfo/lichthi/ajax_lichhoc", _token, cookieSession);
            return str; // JSON
        }

        public String getBangDiem() {
            String str = str = POST.sendPOST("http://www.aao.hcmut.edu.vn/stinfo/grade/ajax_grade", _token, cookieSession);
            return str; // JSON
        }
   
        public String getTienDoHocTap() {

            String str = str = POST.sendPOST("http://www.aao.hcmut.edu.vn/stinfo/ctdt/ajax_ctdt", _token, cookieSession);
            return str; // JSON
        }

        public String getKetQuaTuyenSinh() {
            String str = str = POST.sendPOST("http://www.aao.hcmut.edu.vn/stinfo/ketqua_tuyensinh", _token, cookieSession);
            return str; // HTML/XML
        }
    }
}
