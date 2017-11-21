using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Interop.Excel;

namespace MyBK.Lib.Data.JSON {
    public class DiemMonHoc {
        public string mssv { get; set; }
        public string hk_nh { get; set; }
        public string ma_mh { get; set; }
        public string ten_mh { get; set; }
        public string nhomto { get; set; }
        public string so_tin_chi { get; set; }
        public object diem_ktra { get; set; }
        public string diem_thi { get; set; }
        public string diem_tong_ket { get; set; }
        public string diem_thanhphan { get; set; }
        public object diem_thilai { get; set; }
        public string ten_file { get; set; }
        public string hoc_ky { get; set; }
        public string ngay_cap_nhat { get; set; }
        public string trang_thai { get; set; }
        public object ghi_chu { get; set; }
        public string ten_hocky { get; set; }
        public string ngay_th { get; set; }
        public string trangthai_th { get; set; }
        public string diem_tb { get; set; }
        public string so_tc { get; set; }
        public string so_tctl_hk { get; set; }
        public string so_tctl { get; set; }
        public string diem_tbtl { get; set; }
    }

    public class BangDiem {
        public List<DiemMonHoc> bang_diem { get; set; }
        public string ten_hocky { get; set; }
        public string hk_nh { get; set; }
        public string diem_tb { get; set; }
        public string so_tc { get; set; }
        public string so_tctl_hk { get; set; }
        public string so_tctl { get; set; }
        public string diem_tbtl { get; set; }
        public string ngay_cap_nhat { get; set; }
        public string ngay_th { get; set; }
        public string trang_thai { get; set; }

        public static BangDiem[] getBangDiem(String json) {
            List<BangDiem> ds = new List<BangDiem>();
            JObject jo = JObject.Parse(json);

            foreach (var pair in jo) {
                String key = pair.Key;
                JToken jt = pair.Value;
                JToken diem = jt["diem"];
                List<DiemMonHoc> dsdiemmonhoc = new List<DiemMonHoc>();
                if (diem.ToString().IndexOf('[') >= 0)
                    dsdiemmonhoc = diem.ToObject<List<DiemMonHoc>>();
                else {
                    foreach (var jtokenmonhoc in diem) {
                        DiemMonHoc dmh = jtokenmonhoc.First.ToObject<DiemMonHoc>();
                        dsdiemmonhoc.Add(dmh);
                    }
                }

                BangDiem bd = new BangDiem();
                bd.ten_hocky = jt["ten_hocky"].ToString();
                bd.bang_diem = dsdiemmonhoc;
                bd.hk_nh = jt["hk_nh"].ToString();
                bd.ngay_cap_nhat = jt["ngay_cap_nhat"].ToString();
                bd.trang_thai = jt["trang_thai"].ToString();
                bd.diem_tb = jt["diem_tb"].ToString();
                bd.so_tc = jt["so_tc"].ToString();
                bd.so_tctl = jt["so_tctl"].ToString();
                bd.so_tctl_hk = jt["so_tctl_hk"].ToString();
                bd.diem_tbtl = jt["diem_tbtl"].ToString();
                bd.ngay_th = jt["ngay_th"].ToString();



                ds.Add(bd);

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
            StreamReader sr = new StreamReader(Data.PathData.bangDiemData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            BangDiem[] bd = getBangDiem(json);
            int r = 5;
            foreach (var i in bd) {
                if (i.hk_nh == hocki) {
                    //sheet.Cells[1, 3] = "Hoc ki: ";
                    sheet.Cells[1, 6] = i.ten_hocky.ToUpper();
                    sheet.Cells[3, 3] = "Ngày cập nhật: " + i.ngay_cap_nhat;
                    sheet.Cells[4, 3] = "Mã MH";
                    sheet.Cells[4, 4] = "Tên Môn Học";
                    sheet.Cells[4, 5] = "Nhóm Tổ";
                    sheet.Cells[4, 6] = "Số Tín Chỉ";
                    sheet.Cells[4, 7] = "Điểm thành phần";
                    sheet.Cells[4, 8] = "Điểm thi";
                    sheet.Cells[4, 9] = "Điểm tổng kết";

                    foreach (var j in i.bang_diem) {
                        sheet.Cells[2, 3] = "Mã số sinh viên: " + j.mssv;
                        sheet.Cells[r, 3] = j.ma_mh;
                        sheet.Cells[r, 4] = j.ten_mh;
                        sheet.Cells[r, 5] = j.nhomto;
                        sheet.Cells[r, 6] = j.so_tin_chi;
                        sheet.Cells[r, 7] = j.diem_thanhphan;
                        sheet.Cells[r, 8] = j.diem_thi;
                        sheet.Cells[r, 9] = j.diem_tong_ket;
                        r++;
                    }
                    sheet.Cells[1 + r, 3] = "Điểm trung bình học kì: " + i.diem_tb;
                    sheet.Cells[1 + r, 7] = "Số tín chỉ đăng kí học kì: " + i.so_tc;
                    sheet.Cells[1 + r + 1, 7] = "Số tín chỉ tích lũy học kì: " + i.so_tctl_hk;
                    sheet.Cells[1 + r + 2, 7] = "Số tín chỉ tích lũy: " + i.so_tctl;
                    sheet.Cells[1 + r + 1, 3] = "Điểm trung bình tích lũy : " + i.diem_tbtl;
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
            fomat = sheet.get_Range("c4", "i" + (r + 4).ToString());
            fomat = sheet.get_Range("c" + (r + 1).ToString(), "i" + (r + 4).ToString());
            fomat.Font.Color = System.Drawing.Color.Red;
            fomat = sheet.get_Range("d" + (r + 1).ToString(), "d" + (r + 4).ToString());
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            fomat = sheet.get_Range("h" + (r + 1).ToString(), "h" + (r + 4).ToString());
            fomat.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            book.SaveAs(path);
            book.Close();
            app.Quit();

        }
    }
}
