using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace MyBK.Lib.Request {
    class GET {
        public static string sentGET(string url) {
            string html = string.Empty;
            // tao request;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.AutomaticDecompression = DecompressionMethods.GZip;

            // tao response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // doc du lieu tu response
            Stream stream = response.GetResponseStream();
            // chuyen thanh String
            StreamReader reader = new StreamReader(stream);
            html = reader.ReadToEnd();
            reader.Close();
            return html;
        }

        public static string sentGET(String url, CookieContainer allCookie) {
            CookieContainer cookie = allCookie;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookie;
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public static HttpWebResponse getResponse(String url, CookieContainer allCookie) {
            CookieContainer cookie = allCookie;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookie;
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response;

        }


        public static StreamReader sentGET_Stream(string url) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.AutomaticDecompression = DecompressionMethods.GZip;

            // tao response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // doc du lieu tu response
            Stream stream = response.GetResponseStream();
            // chuyen thanh String
            StreamReader reader = new StreamReader(stream);
            return reader;
        }

        public static void getFormData(String html, out String lt, out String execution) {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/html/body/div/div/div/div/form/div/input");
            lt = Function.getValue(list[3].OuterHtml);
            execution = Function.getValue(list[4].OuterHtml);
        }

        public static void getFormData(HttpWebResponse response, out String lt, out String execution) {
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            String html = reader.ReadToEnd();
            reader.Close();
            getFormData(html, out lt, out execution);
        }

        public static Cookie getCookieFromResponse(HttpWebResponse response) {
            String cookieStr = response.Headers.Get("Set-Cookie");
            String[] listCookie = cookieStr.Split(new char[] { ';' });
            String[] JSESSIONID = listCookie[0].Split(new char[] { '=' });
            Cookie cookie = new Cookie(JSESSIONID[0], JSESSIONID[1]);
            return cookie;
        }

        public static Cookie getJSESSIONID() {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://sso.hcmut.edu.vn/cas/login");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return getCookieFromResponse(response);
        }
    }
}
