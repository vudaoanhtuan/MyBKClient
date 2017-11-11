using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;

using MyBK.Lib.Parser;
using MyBK.Lib.Request;

using MyBK.Lib.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using MyBK.Lib.Data.JSON;
using MyBK.Gui;
using System.Net;
using System.Windows.Forms;
using MyBK.Gui.MyUserControl;
using MyBK.Lib.Data.DangKy;


namespace Program {
    class Program {
        static void Main(string[] args) {
            Application.Run(new MainWindow());
           
           
        }



        static void test2() {
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.config);
            String logined = sr.ReadLine();
            if (logined == null) {
                sr.Close();
                return;
            }
            String user = sr.ReadLine();
            String pass = sr.ReadLine();
            sr.Close();

            MyBKDKMH dkmh = new MyBKDKMH(user, pass);

            String html = dkmh.getDanhSachLoaiDangKy();

            LoaiDangKy[] l = MyBK.Lib.Parser.XMLParser.getDSLoaiDangKy(html);

            StreamWriter sw = new StreamWriter("log.html", false, Encoding.UTF8);
            sw.Write(html);

            LoaiDangKy li = null;

            for (int i=0; i<l.Length; i++) {
                if (l[i].tenLoaiDK.IndexOf("Kết") >= 0) {
                    sw.WriteLine(l[i].hocKyID + "\n" + l[i].tenLoaiDK);
                    li = l[i];
                }
            }

            html = dkmh.getDanhSachDotDK(li.hocKyID);

            DotDangKy[] d = XMLParser.getDSDotDangKy(html);

            html = dkmh.getLichDangKy(d[0].idDotDangKy, d[0].idDotDangKy);
            

            html = dkmh.getThongTinNhomLopMonHoc("14014");

            sw.Write(html);
           

            sw.Close();
            Console.WriteLine("Done");

        }

        static void test1() {
            System.Windows.Forms.Application.Run(new MyBK.Gui.MainWindow());
            //StreamReader sr = new StreamReader("Data/ttcn.html", Encoding.UTF8);
            //StreamWriter sw = new StreamWriter("test.html", false, Encoding.UTF8);
            //HtmlDocument doc = new HtmlDocument();
            //doc.Load(sr);
            //HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/div/div/div/div/div/div/table/tbody//tr");
            //Console.Write(list.Count);
            //for (int i = 0; i < list.Count; i++) {
            //    HtmlNode th = list[i].SelectSingleNode("./th");
            //    HtmlNode td = list[i].SelectSingleNode("./td");
            //    if (th != null)
            //        sw.Write(th.InnerText.Trim());
            //    if (td != null)
            //        sw.Write("|" + td.InnerText.Trim());
            //    sw.WriteLine();
            //}
            //sw.Close();
            // new MyBKStInfo();

        }

       
    }

}




