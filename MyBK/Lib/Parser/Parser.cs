using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using MyBK.Lib.Data.MonHoc;
using System.IO;
using MyBK.Lib.Data.DangKy;

namespace MyBK.Lib.Parser {
    class Parser {
        public static void test() {
            StreamReader sr = new StreamReader("DSDotDK.html", Encoding.UTF8);
            StreamWriter sw = new StreamWriter("Log.html", false, Encoding.UTF8);
            HtmlDocument doc = new HtmlDocument();
            //doc.Load(sr);
            //HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/div/div/table/*");
            String str = sr.ReadToEnd();
            sr.Close();
            DotDangKy[] list = XMLParser.getDSDotDangKy(str);
            foreach (var l in list)
                sw.WriteLine(l);
            sw.Close();
        }
    }
    class XMLParser {
        static char[] listTrim = { '\n', '\t', '\r' };
        //public parseDanhSachLop(String html) {

        //} 

        public static bool isInList(char c, char[] list) {
            for (int i = 0; i < list.Length; i++)
                if (c == list[i])
                    return true;
            return false;
        }
        public static String eraserAllChar(String str, char[] listChar) {
            String res = "";
            for (int i = 0; i < str.Length; i++)
                if (!isInList(str[i], listChar))
                    res = res + str[i];
            return res;
        }
        public static String eraserAllChar(String str) {
            return eraserAllChar(str, listTrim);
        }
        public static LopHoc getLopHocInfo(HtmlNode node) {
            LopHoc lop = new LopHoc();
            HtmlNodeCollection listChilds = node.SelectNodes("./td");
            lop.nhomLop = listChilds[0].InnerText;
            lop.soSVDK = listChilds[1].InnerText;
            lop.ngonNgu = listChilds[2].InnerText;
            lop.nhomLT = listChilds[3].InnerText;
            lop.gvLT = listChilds[4].InnerText;
            lop.nhomBT = listChilds[5].InnerText;
            lop.gvBT = listChilds[6].InnerText;
            lop.siSoLop = listChilds[7].InnerText;
            lop.buoiHoc = null;
            return lop;
        }

        public static BuoiHoc[] getDSBuoiHoc(HtmlNode node) {
            List<BuoiHoc> listBH = new List<BuoiHoc>();

            HtmlNodeCollection listBuoiHoc = node.SelectNodes("./td/table/tr");
            for (int i = 1; i < listBuoiHoc.Count; i++) {
                HtmlNodeCollection infoBH = listBuoiHoc[i].SelectNodes("./td");
                BuoiHoc buoiHoc = new BuoiHoc();
                buoiHoc.thu = eraserAllChar(infoBH[0].InnerText);
                buoiHoc.tiet = eraserAllChar(infoBH[1].InnerText);
                buoiHoc.phong = eraserAllChar(infoBH[2].InnerText);
                buoiHoc.coSo = eraserAllChar(infoBH[3].InnerText);
                buoiHoc.lopBT = eraserAllChar(infoBH[4].InnerText);
                buoiHoc.tuan = eraserAllChar(infoBH[5].InnerText);
                listBH.Add(buoiHoc);
            }
            BuoiHoc[] DSBH = listBH.ToArray();
            return DSBH;
        }

        public static MonHoc exportMonHoc(HtmlDocument doc) {
            MonHoc monHoc = new MonHoc();
            HtmlNode nodeInfo = doc.DocumentNode.SelectSingleNode("/div/div/h4");
            String[] infoStr = nodeInfo.InnerText.Split('-');
            monHoc.maSoMonHoc = infoStr[0].Trim(listTrim).Trim();
            monHoc.tenMonHoc = infoStr[1].Trim(listTrim).Trim();

            List<LopHoc> listLopHoc = new List<LopHoc>();

            HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/div/div/div/div/table/*");
            for (int i = 2; i < list.Count; i += 3) {
                HtmlNode nodeLopHoc = list[i];
                LopHoc lop = getLopHocInfo(nodeLopHoc);

                HtmlNode nodeBuoiHoc = list[i + 1];
                BuoiHoc[] listBH = getDSBuoiHoc(nodeBuoiHoc);
                lop.buoiHoc = listBH;
                listLopHoc.Add(lop);
            }
            monHoc.lopHoc = listLopHoc.ToArray();
            return monHoc;
        }

        // ham lay danh sach cac loai dang ki
        // VD: Dang ky hoc ki chinh 172, Dang ky hoc du thinh 172...
        public static LoaiDangKy[] getDSLoaiDangKy(String html) {
            List<LoaiDangKy> ds = new List<LoaiDangKy>();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/html/body/div/div/div/section/div/section/div/div/table/*");
            if (list != null) {
                for (int i=1; i<list.Count; i++) {
                    LoaiDangKy loai = new LoaiDangKy();
                    HtmlNode node = list[i];
                    String str = node.OuterHtml;
                    String hocKyId = str.Substring(str.IndexOf('(') + 1, 3);
                    loai.hocKyID = hocKyId;
                    HtmlNodeCollection listChildNode = node.SelectNodes("./*");
                    loai.namHoc = listChildNode[1].InnerText;
                    loai.tenLoaiDK = listChildNode[2].InnerText;
                    ds.Add(loai);
                }
            }
            return ds.ToArray();
        }

        public static DotDangKy[] getDSDotDangKy(String html) {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/div/div/table/*");
            List<DotDangKy> ds = new List<DotDangKy>();
            if (list != null) {
                for (int i=1; i<list.Count; i++) {
                    DotDangKy dot = new DotDangKy();
                    HtmlNode node = list[i];
                    String str = node.OuterHtml;
                    int start = str.IndexOf('(');
                    int end = str.IndexOf(')');
                    str = str.Substring(start + 1, end - start - 1);
                    str = str.Split(new char[] { ',' })[1].Trim();
                    dot.idDotDangKy = str;
                    HtmlNodeCollection child = node.SelectNodes("./td");
                    dot.tenDotDangKy = child[1].InnerText;
                    ds.Add(dot);
                }

            }
            return ds.ToArray();
        }

        public static String parseTTCN(String html) {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            String res = "";
            HtmlNodeCollection list = doc.DocumentNode.SelectNodes("/div/div/div/div/div/div/table/tbody//tr");
            Console.Write(list.Count);
            for (int i = 0; i < list.Count; i++) {
                HtmlNode th = list[i].SelectSingleNode("./th");
                HtmlNode td = list[i].SelectSingleNode("./td");
                if (th != null)
                    res = res + th.InnerText.Trim();
                if (td != null)
                    res = res + "|" + td.InnerText.Trim();
                res = res + '\n';
            }
            return res;
        }
    }
}
