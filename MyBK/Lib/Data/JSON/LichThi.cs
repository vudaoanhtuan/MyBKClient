using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace MyBK.Lib.Data.JSON {
    public class MonThi {
        public string ma_mh { get; set; }
        public string ten_mh { get; set; }
        public string nhomto { get; set; }
        public string ngaykt { get; set; }
        public string tiet_bd_ktra { get; set; }
        public string gio_kt { get; set; }
        public string phong_ktra { get; set; }
        public string ngaythi { get; set; }
        public string tiet_bd_thi { get; set; }
        public string gio_thi { get; set; }
        public string phong_thi { get; set; }
        public string mssv { get; set; }
        public string ma_nhom { get; set; }
        public string ma_to { get; set; }
        public string kq { get; set; }
        public string hk_nh { get; set; }
        public string ten_hk_nh { get; set; }
        public string ten_file { get; set; }
        public string ngay_cap_nhat { get; set; }
        public object ghi_chu { get; set; }
        public string trang_thai { get; set; }
    }

    public class LichThi {
        public List<MonThi> ds_mon_thi { get; set; }
        public string ten_hocky { get; set; }
        public string hk_nh { get; set; }
        public string ngay_cap_nhat { get; set; }
        public string trang_thai { get; set; }

        public static LichThi[] getLichThi(String json) {
            List<LichThi> ds = new List<LichThi>();
            JObject jo = JObject.Parse(json);

            foreach (var pair in jo) {
                String key = pair.Key;
                JToken jt = pair.Value;
                JToken lichthi = jt["lichthi"];
                List<MonThi> dsmonthi = new List<MonThi>();
                if (lichthi.ToString().IndexOf('[') >= 0)
                    dsmonthi = lichthi.ToObject<List<MonThi>>();
                else {
                    foreach (var jtokenmonhoc in lichthi) {
                        MonThi mt = jtokenmonhoc.First.ToObject<MonThi>();
                        dsmonthi.Add(mt);
                    }
                }

                LichThi lh = new LichThi();
                lh.ten_hocky = jt["ten_hocky"].ToString();
                lh.ds_mon_thi = dsmonthi;
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
            StreamReader sr = new StreamReader(Data.PathData.lichThiData, Encoding.UTF8);
            String json = sr.ReadToEnd();

            LichThi[] lt = getLichThi(json);
            int r = 6;

            foreach (var i in lt) {
                if (i.hk_nh == hocki) {
                    //sheet.Cells[1, 3] = "Hoc ki: ";
                    sheet.Cells[1, 6] = "LỊCH THI HỌC KÌ - " + i.ten_hocky.ToUpper();

                    sheet.Cells[3, 3] = "Ngày cập nhật: " + i.ngay_cap_nhat;
                    sheet.Cells[5, 3] = "Mã Môn Học";
                    sheet.Cells[5, 4] = "Tên Môn Học";
                    sheet.Cells[5, 5] = "Nhóm Tổ";
                    sheet.Cells[5, 6] = "Ngày";
                    sheet.Cells[5, 7] = "Giờ";
                    sheet.Cells[5, 8] = "Phòng";
                    sheet.Cells[5, 9] = "Ngày";
                    sheet.Cells[5, 10] = "Giờ";
                    sheet.Cells[5, 11] = "Phòng";
                    sheet.Cells[4, 6] = "KIỂM TRA GIỮA KÌ";
                    sheet.Cells[4, 9] = "KIỂM TRA CUỐI KÌ";

                    foreach (var j in i.ds_mon_thi) {
                        sheet.Cells[2, 3] = "Mã số sinh viên: " + j.mssv;
                        sheet.Cells[r, 3] = j.ma_mh;
                        sheet.Cells[r, 4] = j.ten_mh;
                        sheet.Cells[r, 5] = j.nhomto;
                        sheet.Cells[r, 6] = "'" + j.ngaykt;
                        sheet.Cells[r, 7] = j.gio_kt;
                        sheet.Cells[r, 8] = j.phong_ktra;
                        sheet.Cells[r, 9] = "'" + j.ngaythi;
                        sheet.Cells[r, 10] = j.gio_thi;
                        sheet.Cells[r, 11] = j.phong_thi;
                        r++;
                    }
                }
            }

            Range fomat;
            fomat = sheet.get_Range("c1", "k1");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 16;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            fomat = sheet.get_Range("c2", "k2");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            fomat = sheet.get_Range("c3", "k3");
            fomat.Merge();
            fomat.Font.Italic = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            fomat = sheet.get_Range("f4", "h4");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            fomat = sheet.get_Range("i4", "k4");
            fomat.Merge();
            fomat.Font.Bold = true;
            fomat.Font.Size = 12;
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            fomat = sheet.get_Range("a5");
            fomat.EntireRow.Font.Bold = true;
            fomat.Columns.AutoFit();
            fomat = sheet.get_Range("c5", "k" + (r - 1).ToString());
            fomat.Columns.AutoFit();
            FormatAsTable(fomat, "Table2", "TableStyleMedium15");
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            book.SaveAs(path);
            book.Close();
            app.Quit();

        }
    }
}
