using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Interop.Excel;
using MyBK.Lib.Request;
using MyBK.Lib.Data.DangKy;
using MyBK.Lib.Parser;
using System.Drawing;
using MyBK.Lib.Data.MonHoc;

namespace MyBK.Lib.Data.JSON {
    public class MonHoc {
        public string ma_mh { get; set; }
        public string ten_mh { get; set; }
        public string nhomto { get; set; }
        public string tuan_hoc { get; set; }
        public string thu1 { get; set; }
        public string tiet_bd1 { get; set; }
        public string tiet_kt1 { get; set; }
        public string phong1 { get; set; }
        public string tc_hp { get; set; }
        public string kq { get; set; }
        public string so_tin_chi { get; set; }
        public string muc_hocphi { get; set; }
        public string ma_nhom { get; set; }
        public string mssv { get; set; }
        public string hk_nh { get; set; }
        public string ten_hk_nh { get; set; }
        public string ten_file { get; set; }
        public string ngay_cap_nhat { get; set; }
        public string trang_thai { get; set; }
        public object ghi_chu { get; set; }
    }

    public class LichHoc {
        public List<MonHoc> ds_mon_hoc { get; set; }
        public string ten_hocky { get; set; }
        public string hk_nh { get; set; }
        public string ngay_cap_nhat { get; set; }
        public string trang_thai { get; set; }

        public static String formatJson(String json) {
            if (json.IndexOf('[') >= 0)
                return json;
            int start = json.IndexOf('{');
            int end = json.LastIndexOf('}');
            String sub = json.Substring(start + 1, end - start -1);
            return "[" + sub + "]";
        }

        public static JToken formatJson(JToken jt) {
            String str = formatJson(jt.ToString());
            JToken j = JToken.Parse(str);
            return j;
            
        }
        public static LichHoc[] getLichHoc(String json) {
            List<LichHoc> ds = new List<LichHoc>();
            JObject jo = JObject.Parse(json);

            foreach (var pair in jo) {
                String key = pair.Key;
                JToken jt = pair.Value;
                JToken lichhoc = jt["lichhoc"];
                List<MonHoc> dsmonhoc = new List<MonHoc>();
                if (lichhoc.ToString().IndexOf('[') >=0)
                     dsmonhoc = lichhoc.ToObject<List<MonHoc>>();
                else {
                    foreach (var jtokenmonhoc in lichhoc) {
                        MonHoc mh = jtokenmonhoc.First.ToObject<MonHoc>();
                        dsmonhoc.Add(mh);
                    }
                }

                LichHoc lh = new LichHoc();
                lh.ten_hocky = jt["ten_hocky"].ToString();
                lh.ds_mon_hoc = dsmonhoc;
                lh.hk_nh = jt["hk_nh"].ToString();
                lh.ngay_cap_nhat = jt["ngay_cap_nhat"].ToString();
                lh.trang_thai = jt["trang_thai"].ToString();
                ds.Add(lh);
 
            }
            return ds.ToArray();
        }

        public static void FormatAsTable(Range SourceRange, string TableName, string TableStyleName) {
            SourceRange.Worksheet.ListObjects.Add(XlListObjectSourceType.xlSrcRange,
            SourceRange, System.Type.Missing, XlYesNoGuess.xlYes, System.Type.Missing).Name =
                TableName;
            SourceRange.Select();
            SourceRange.Worksheet.ListObjects[TableName].TableStyle = TableStyleName;

        }

        public static void exportExcel(string path, string hocki) {
            Application app = new Application();
            object misValue = System.Reflection.Missing.Value;
            Workbook book = app.Workbooks.Add(misValue);
            Worksheet sheet = book.Worksheets.Add();
            // Range changeRange;
            StreamReader sr = new StreamReader(Data.PathData.lichHocData, Encoding.UTF8);
            String json = sr.ReadToEnd();

            LichHoc[] lh = getLichHoc(json);
            int r = 5;

            foreach (var i in lh) {
                if (i.hk_nh == hocki) {
                    //sheet.Cells[1, 3] = "Hoc ki: ";
                    sheet.Cells[1, 6] = "THỜI KHÓA BIỂU - " + i.ten_hocky.ToUpper();

                    sheet.Cells[3, 3] = "Ngày cập nhật: " + i.ngay_cap_nhat;
                    sheet.Cells[4, 3] = "Mã Môn Học";
                    sheet.Cells[4, 4] = "Tên Môn Học";
                    sheet.Cells[4, 5] = "Nhóm Tổ";
                    sheet.Cells[4, 6] = "Thứ";
                    sheet.Cells[4, 7] = "Tiết";
                    sheet.Cells[4, 8] = "Phòng";
                    sheet.Cells[4, 9] = "Tuần học";

                    foreach (var j in i.ds_mon_hoc) {
                        sheet.Cells[2, 3] = "Mã số sinh viên: " + j.mssv;
                        sheet.Cells[r, 3] = j.ma_mh;
                        sheet.Cells[r, 4] = j.ten_mh;
                        sheet.Cells[r, 5] = j.nhomto;
                        sheet.Cells[r, 6] = j.thu1;
                        sheet.Cells[r, 7] = j.tiet_kt1;
                        sheet.Cells[r, 8] = j.phong1;
                        sheet.Cells[r, 9] = j.tuan_hoc;
                        r++;
                    }
                }
            }

            Range fomat;
            fomat = sheet.get_Range("c1", "i1");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 16;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            fomat = sheet.get_Range("c2", "i2");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            fomat = sheet.get_Range("c3", "i3");
            fomat.Merge();
            fomat.Font.Italic = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            fomat = sheet.get_Range("a4");
            fomat.EntireRow.Font.Bold = true;
            fomat.Columns.AutoFit();
            fomat = sheet.get_Range("c4", "i" + (r - 1).ToString());
            fomat.Columns.AutoFit();
            FormatAsTable(fomat, "Table2", "TableStyleMedium15");
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            book.SaveAs(path);
            book.Close();
            app.Quit();

        }

        public static void exportExcelDKMH(string path, String html) {

            //////////////////////////////////////////////////
            Data.MonHoc.MonHoc monhoc = XMLParser.exportMonHoc(html);
            LopHoc[] listLH = monhoc.lopHoc;

            Application app = new Application();
            object misValue = System.Reflection.Missing.Value;
            Workbook book = app.Workbooks.Add(misValue);
            Worksheet sheet = book.Worksheets.Add();
            int r = 5;

            sheet.Cells[1, 6] = "THỜI KHÓA BIỂU TỔNG - " + monhoc.tenMonHoc.ToUpper() + " - " + monhoc.maSoMonHoc;

            Range fomat;
            fomat = sheet.get_Range("c1", "j1");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 16;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            sheet.Cells[4, 3] = "Nhóm lớp";
            sheet.Cells[4, 4] = "DK/Sỉ số";
            sheet.Cells[4, 5] = "Ngôn ngữ";
            sheet.Cells[4, 6] = "Nhóm LT";
            sheet.Cells[4, 7] = "Giảng viên LT";
            sheet.Cells[4, 8] = "Nhóm BT";
            sheet.Cells[4, 9] = "Giảng viên BT";
            sheet.Cells[4, 10] = "Sỉ số LT";

            //Range fomat;
            fomat = sheet.get_Range("c4", "j4");
            fomat.Columns.AutoFit();
            fomat.Font.Bold = true;
            // fomat.ColumnWidth = 25;
            fomat.Font.Size = 12;
            fomat.Font.Color = Color.Red;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            for (int k = listLH.Length - 1; k >= 0; k--) {

                BuoiHoc[] bh = listLH[k].buoiHoc;
                sheet.Cells[r, 3] = listLH[k].nhomLop;
                sheet.Cells[r, 4] = listLH[k].soSVDK;
                sheet.Cells[r, 5] = listLH[k].ngonNgu;
                sheet.Cells[r, 6] = listLH[k].nhomLT;
                sheet.Cells[r, 7] = listLH[k].gvLT;
                sheet.Cells[r, 8] = listLH[k].nhomBT;
                sheet.Cells[r, 9] = listLH[k].gvBT;
                sheet.Cells[r, 10] = listLH[k].siSoLop;
                fomat = sheet.get_Range("c" + r.ToString(), "j" + r.ToString());
                fomat.Font.Bold = false;
                fomat.Font.Size = 12;
                fomat.Font.Color = Color.Blue;
                fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r++;

                sheet.Cells[r, 3] = "Thứ";
                sheet.Cells[r, 4] = "Tiết";
                sheet.Cells[r, 5] = "Phòng";
                sheet.Cells[r, 6] = "Cơ sở";
                sheet.Cells[r, 7] = "Lớp BT";
                sheet.Cells[r, 8] = "Tuần";
                fomat = sheet.get_Range("c" + r.ToString(), "j" + r.ToString());
                fomat.Font.Bold = true;

                fomat.Font.Size = 12;
                fomat.Font.Color = Color.Black;
                fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r++;

                int m = r;
                for (int j = bh.Length - 1; j >= 0; j--) {
                    //  NgayHoc_DKMHItem itembh = new NgayHoc_DKMHItem();              
                    sheet.Cells[r, 3] = bh[j].thu;
                    sheet.Cells[r, 4] = bh[j].tiet;
                    sheet.Cells[r, 5] = bh[j].phong;
                    sheet.Cells[r, 6] = bh[j].coSo;
                    sheet.Cells[r, 7] = bh[j].lopBT;
                    sheet.Cells[r, 8] = bh[j].tuan;
                    r++;
                }

                fomat = sheet.get_Range("c" + m.ToString(), "j" + (r - 1).ToString());
                //fomat.Font.Bold = true;
                //fomat.Columns.AutoFit();
                fomat.Font.Size = 12;
                fomat.Font.Color = Color.Black;
                fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            fomat = sheet.get_Range("c4", "j" + (r).ToString());
            //fomat.Font.Bold = true;
            fomat.Columns.AutoFit();
            // fomat.Font.Size = 12;
            // fomat.Font.Color = Color.Black;
            // fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            book.SaveAs(path);
            book.Close();
            app.Quit();

        }
    }
}
