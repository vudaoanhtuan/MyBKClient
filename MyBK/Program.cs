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


namespace Program {
    class Program {
        static void Main(string[] args) {
            Application.Run(new MainWindow());
            //test2();
           
        }

        static void test2() {
            StreamReader sr = new StreamReader("Data/ctdt.json", Encoding.UTF8);
            String json = sr.ReadToEnd();
            StreamWriter sw = new StreamWriter("Log.html", false, Encoding.UTF8);

            List<CTDT> ds = new List<CTDT>();
            JObject jo = JObject.Parse(json);
            JToken jk = jo["ctdt"];
            jo = JObject.Parse(jk.ToString());
            sw.Write(jk);
            sw.Close();
            
            foreach (var pair in jo) {
                String key = pair.Key;
                JToken jt = pair.Value;
                JToken ctdt = jt["ctdt"];
                List<CTDT_HK> ctdtHK = new List<CTDT_HK>();
                if (ctdt.ToString().IndexOf('[') >= 0)
                    ctdtHK = ctdt.ToObject<List<CTDT_HK>>();
                else {
                    foreach (var jtokenmonhoc in ctdt) {
                        CTDT_HK ctdtHKItem = jtokenmonhoc.First.ToObject<CTDT_HK>();
                        ctdtHK.Add(ctdtHKItem);
                    }
                }

                CTDT ct = new CTDT();
                ct.hocky = jt["hocky"].ToString();
                ct.dsCTDT = ctdtHK;

                ds.Add(ct);

            }
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




