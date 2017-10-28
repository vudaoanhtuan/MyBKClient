using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBK.Gui.MyUserControl;
using MyBK.Lib.Data.JSON;
using System.IO;

namespace MyBK.Gui {
    public partial class XemLichThi : Form {
        LichThi[] listLT;
        MonThi[] listMT;
        LichThiItem[] listItem;
        public XemLichThi() {
            InitializeComponent();
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.lichThiData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            listLT = LichThi.getLichThi(json);
            this.setupDSHocKy();
            this.setLichThi(listLT[0]);
            comboBox_ds_hoc_ki.Text = listLT[0].ten_hocky;
        }

        public static void setupHeader(Label lb) {
            Color cl = ColorTranslator.FromHtml("#075385");
            lb.BackColor = cl;
            Font font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb.Font = font;
            lb.ForeColor = Color.White;
        }

        public void setupHeader() {
            LichThiItem lt = new LichThiItem();
            setupHeader(lt.ma_mon_hoc);
            setupHeader(lt.ten_mon_hoc);
            setupHeader(lt.nhom_to);
            setupHeader(lt.phongGK);
            setupHeader(lt.gioGK);
            setupHeader(lt.ngayGK);
            setupHeader(lt.phongCK);
            setupHeader(lt.gioCK);
            setupHeader(lt.ngayCK);
            lt.Name = "header_lichthi";
            lt.Dock = DockStyle.Top;
            this.panel_lichthi.Controls.Add(lt);
        }
   
        public void setupDSHocKy() {
            comboBox_ds_hoc_ki.DisplayMember = "KeyValuePair<string, LichHoc>.Key";
            for (int i = 0; i < listLT.Length; i++) {
                KeyValuePair<String, LichThi> item =
                new KeyValuePair<string, LichThi>(listLT[i].ten_hocky, listLT[i]);
                comboBox_ds_hoc_ki.Items.Add(item);
                // comboBox_ds_hoc_ki.Items.Add(new { Text = listLH[i].ten_hocky, Value = listLH[i] });
            }
            comboBox_ds_hoc_ki.Text = listLT[0].ten_hocky;
        }
        public void setLichThi(LichThi lh) {

            if (listItem != null)
                for (int i = 0; i < listItem.Length; i++)
                    this.panel_lichthi.Controls.Remove(listItem[i]);

            Control ct = this.panel_lichthi.Controls["header_lichthi"];
            if (ct != null) ;
            this.panel_lichthi.Controls.Remove(ct);

            listMT = lh.ds_mon_thi.ToArray<MonThi>();
            listItem = new LichThiItem[listMT.Length];
            for (int i = listMT.Length - 1; i >= 0; i--) {
                LichThiItem item = new LichThiItem();
                item.ma_mon_hoc.Text = listMT[i].ma_mh;
                item.ten_mon_hoc.Text = listMT[i].ten_mh;
                item.nhom_to.Text = listMT[i].nhomto;
                item.phongGK.Text = listMT[i].phong_ktra;
                item.ngayGK.Text = listMT[i].ngaykt;
                item.gioGK.Text = listMT[i].gio_kt;
                item.phongCK.Text = listMT[i].phong_thi;
                item.ngayCK.Text = listMT[i].ngaythi;
                item.gioCK.Text = listMT[i].gio_thi;
                listItem[i] = item;
                item.Dock = DockStyle.Top;
                this.panel_lichthi.Controls.Add(item);
            }
            setupHeader();
        }

        private void comboBox_ds_hoc_ki_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<String, LichThi> item = (KeyValuePair<String, LichThi>)comboBox_ds_hoc_ki.SelectedItem;
            this.setLichThi(item.Value);
        }
    }
}
