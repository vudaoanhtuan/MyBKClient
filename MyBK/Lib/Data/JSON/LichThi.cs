using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

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
    }
}
