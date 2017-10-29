﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
    }
}