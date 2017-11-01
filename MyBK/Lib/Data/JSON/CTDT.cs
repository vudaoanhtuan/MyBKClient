using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyBK.Lib.Data.JSON {
    public class CTDT_HK {
        public string masv { get; set; }
        public string ctdt { get; set; }
        public string nam { get; set; }
        public string hocky { get; set; }
        public string ma_monhoc { get; set; }
        public string stt_mh { get; set; }
        public string monhoc_batbuoc { get; set; }
        public object ma_tuchon { get; set; }
        public string ten_monhoc { get; set; }
        public string ma_hocky { get; set; }
        public string so_tin_chi { get; set; }
        public string ten_nganh { get; set; }
        public string diem { get; set; }
    }

    public class CTDT {
        public List<CTDT_HK> dsCTDT { get; set; }
        public string hocky { get; set; }

        public static CTDT[] getCTDT(String json) {
            List<CTDT> ds = new List<CTDT>();
            JObject jo = JObject.Parse(json);
            JToken jk = jo["ctdt"];
            jo = JObject.Parse(jk.ToString());

            foreach (var pair in jo) {
                String key = pair.Key;
                JToken jt = pair.Value;
                JToken ctdt = jt["ctdt"];
                List<CTDT_HK> ctdtHK = new List<CTDT_HK>();
                if (ctdt.ToString().IndexOf('[') >= 0)
                    ctdtHK = ctdt.ToObject<List<CTDT_HK>>();
                else {
                    foreach (var jtokenmonhoc in ctdt) {
                        CTDT_HK ctdtHKItem = jtokenmonhoc.First.ToObject<CTDT_HK>();
                        ctdtHK.Add(ctdtHKItem);
                    }
                }

                CTDT ct = new CTDT();
                ct.hocky = jt["hocky"].ToString();
                ct.dsCTDT = ctdtHK;
                
                ds.Add(ct);

            }
            return ds.ToArray();
        }
    }
}
