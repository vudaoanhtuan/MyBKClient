using System;
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

        public static LichHoc[] getLichThi(String json) {
            JObject jo = JObject.Parse(json);
            List<LichHoc> ds = new List<LichHoc>();
            if (jo == null)
                return null;
            foreach (var pair in jo) {
                String id = pair.Key;
                JToken token = pair.Value;
                LichHoc lt = token.ToObject<LichHoc>();
                ds.Add(lt);
            }
            return ds.ToArray();
        }
    }
}
