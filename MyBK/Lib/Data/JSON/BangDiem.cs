using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            JObject jo = JObject.Parse(json);
            List<BangDiem> ds = new List<BangDiem>();
            if (jo == null)
                return null;
            foreach (var pair in jo) {
                String id = pair.Key;
                JToken token = pair.Value;
                BangDiem lt = token.ToObject<BangDiem>();
                ds.Add(lt);
            }
            return ds.ToArray();
        }
    }
}
