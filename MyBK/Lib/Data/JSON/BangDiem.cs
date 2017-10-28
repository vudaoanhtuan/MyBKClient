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
    }
}
