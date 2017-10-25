using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace MyBK.Lib.Request {
    class POST {
        public static CookieContainer Login(String user, String pass) {
            String lt, exe;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://sso.hcmut.edu.vn/cas/login");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            GET.getFormData(response, out lt, out exe);
            Cookie JSESSIONID = GET.getCookieFromResponse(response);
            string service = "http://mybk.hcmut.edu.vn";
            string data = String.Format("service={4}&username={0}&password={1}&lt={2}&execution={3}&_eventId=submit&submit=Login", user, pass, lt, exe, service);

            CookieContainer cookie = new CookieContainer();
            cookie.Add(new Uri("https://sso.hcmut.edu.vn/cas/login"), JSESSIONID);

            request = (HttpWebRequest)WebRequest.Create("https://sso.hcmut.edu.vn/cas/login");
            request.CookieContainer = cookie;
            request.KeepAlive = true;
            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            request.ContentLength = byteArray.Length;
            Stream ds = request.GetRequestStream();
            ds.Write(byteArray, 0, byteArray.Length);
            ds.Close();

            response = (HttpWebResponse)request.GetResponse();



            HttpWebResponse wr = (HttpWebResponse)response;
            CookieCollection cc = wr.Cookies;
            foreach (var ck in cc)
                Console.WriteLine(ck);

            cookie = new CookieContainer();
            cookie.Add(cc);
            cookie.Add(new Uri("http://mybk.hcmut.edu.vn"), JSESSIONID);

            request = (HttpWebRequest)WebRequest.Create("http://mybk.hcmut.edu.vn/dkmh/home.action");
            request.CookieContainer = cookie;
            request.KeepAlive = true;
            response = (HttpWebResponse)request.GetResponse();

            Console.Write(response.Headers);



            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            StreamWriter sw = new StreamWriter("Log.html", false, Encoding.UTF8);
            sw.Write(responseFromServer);
            sw.Close();
            reader.Close();
            dataStream.Close();
            response.Close();
            return cookie;

        }
        public static String sendPOST(String url, String data, CookieContainer allCookie) {
            CookieContainer cookie = allCookie;
            //cookie.Add(new Uri(url), JSESSIONID);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookie;
            request.KeepAlive = true;
            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            request.ContentLength = byteArray.Length;
            Stream ds = request.GetRequestStream();
            ds.Write(byteArray, 0, byteArray.Length);
            ds.Close();

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;

        }
    }
}
