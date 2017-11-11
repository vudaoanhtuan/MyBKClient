using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBK.Gui.MyUserControl;
using MyBK.Lib.Data.JSON;
using System.IO;
using MyBK.Lib.Data;

namespace MyBK.Gui {
    public partial class XemChuongTrinhDaoTao : Form {
        CTDT[] listCTDT;
        CTDT_HK[] listCTDTHK;
        CTDTItem[] listItem;
        public XemChuongTrinhDaoTao() {
            InitializeComponent();
            this.setupHeader();

            StreamReader sr = new StreamReader(PathData.ctdtData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            sr.Close();
            listCTDT = CTDT.getCTDT(json);

            this.setCTDT(listCTDT[0]);
            comboBox_ds_hoc_ki.Text = formatHocKy(listCTDT[0].hocky);
            this.setupDSHocKy();
        }
        public static String formatHocKy(String hk) {
            return "Năm học " + hk.Substring(0, 4) + " - HK " + hk.Substring(4);
        }
        public void setupDSHocKy() {
            comboBox_ds_hoc_ki.DisplayMember = "KeyValuePair<string, LichHoc>.Key";
            for (int i = 0; i < listCTDT.Length; i++) {
                KeyValuePair<String, CTDT> item =
                new KeyValuePair<string, CTDT>(formatHocKy(listCTDT[i].hocky), listCTDT[i]);
                comboBox_ds_hoc_ki.Items.Add(item);
                // comboBox_ds_hoc_ki.Items.Add(new { Text = listLH[i].ten_hocky, Value = listLH[i] });
            }

        }
        public static void setupHeader(Label lb) {
            Color cl = ColorTranslator.FromHtml("#075385");
            lb.BackColor = cl;
            Font font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb.Font = font;
            lb.ForeColor = Color.White;
        }

        public void setupHeader() {
            CTDTItem item = new CTDTItem();
            setupHeader(item.stt);
            setupHeader(item.ma_mon_hoc);
            setupHeader(item.ten_mon_hoc);
            setupHeader(item.diem);
            setupHeader(item.dat);
            setupHeader(item.chua_dat);
            setupHeader(item.so_tin_chi);
            setupHeader(item.ghi_chu);
            setupHeader(item.loai_mon_hoc);
            item.Name = "header_ctdt";
            item.Dock = DockStyle.Top;
            this.panel_chuong_trinh_dao_tao.Controls.Add(item);
        }

        public void setCTDT(CTDT ctdt) {

            if (listItem != null)
                for (int i = 0; i < listItem.Length; i++)
                    this.panel_chuong_trinh_dao_tao.Controls.Remove(listItem[i]);

            Control ct = this.panel_chuong_trinh_dao_tao.Controls["header_ctdt"];
            if (ct != null) 
                this.panel_chuong_trinh_dao_tao.Controls.Remove(ct);

            listCTDTHK = ctdt.dsCTDT.ToArray<CTDT_HK>();
            listItem = new CTDTItem[listCTDTHK.Length];
            for (int i = listCTDTHK.Length - 1; i >= 0; i--) {
                CTDTItem item = new CTDTItem();
                item.stt.Text = (listCTDTHK.Length - i).ToString();
                item.ma_mon_hoc.Text = listCTDTHK[i].ma_monhoc;
                item.ten_mon_hoc.Text = listCTDTHK[i].ten_monhoc;
                item.so_tin_chi.Text = listCTDTHK[i].so_tin_chi;
                if (listCTDTHK[i].monhoc_batbuoc == null)
                    item.loai_mon_hoc.Text = "Tự chọn";
                else
                    item.loai_mon_hoc.Text = "Bắt buộc";

                
                item.chua_dat.Text = "";
                item.dat.Text = "";
                if (listCTDTHK[i].diem == null) {
                    item.chua_dat.Text = "x";
                } else {
                    double diem;
                    bool converted = Double.TryParse(listCTDTHK[i].diem, out diem);
                    if ((converted && diem > 4.99999) || listCTDTHK[i].diem == "DT")
                        item.dat.Text  = "x";
                    else
                        item.chua_dat.Text = "x";
                }
                                
                item.diem.Text = listCTDTHK[i].diem;
                item.ghi_chu.Text = "";
                listItem[i] = item;
                item.Dock = DockStyle.Top;
                this.panel_chuong_trinh_dao_tao.Controls.Add(item);
            }
            setupHeader();
        }

        private void comboBox_ds_hoc_ki_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<String, CTDT> item = (KeyValuePair<String, CTDT>)comboBox_ds_hoc_ki.SelectedItem;
            this.setCTDT(item.Value);
        }
    }
}
