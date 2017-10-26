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
            JObject jo = JObject.Parse(json);
            List<LichThi> ds = new List<LichThi>();
            if (jo == null)
                return null;
            foreach (var pair in jo) {
                String id = pair.Key;
                JToken token = pair.Value;
                LichThi lt = token.ToObject<LichThi>();
                ds.Add(lt);
            }
            return ds.ToArray();
        }
    }
}
