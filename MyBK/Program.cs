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
using System.Windows.Forms;
using MyBK.Lib.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using MyBK.Lib.Data.JSON;
using MyBK.Gui;

namespace Program {
    class Program {
        static void Main(string[] args) {
            //Application.Run(new MyBK.Gui.XemLichHoc());
            StreamReader sr = new StreamReader(PathData.lichHocData, Encoding.UTF8);
            StreamWriter sw = new StreamWriter("test.json", false, Encoding.UTF8);
            String json = sr.ReadToEnd();
            JObject jo = JObject.Parse(json);

            JToken jt = jo.First.Next;
            JToken tt = jt.First["lichhoc"];
            foreach (var pair in tt) {
                MonHoc mh = pair.First.ToObject<MonHoc>();
            }
            sw.Close();
            Application.Run(new XemDiem());
        }
    }

}




