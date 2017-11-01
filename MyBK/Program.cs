﻿using System;
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


namespace Program {
    class Program {
        static void Main(string[] args) {
             Application.Run(new MainWindow());
            //test2();
        }

        static void test2() {
            StreamReader sr = new StreamReader("ttcn.html", Encoding.UTF8);
            String html = sr.ReadToEnd();
            String image = MyBK.Lib.Parser.XMLParser.getImageInHtml(html);
            StreamWriter sw = new StreamWriter("image.txt");
            sw.Write(image);
            sw.Close();

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




