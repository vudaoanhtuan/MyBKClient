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
using System.IO;
using MyBK.Lib.Data.JSON;

namespace MyBK.Gui {
    public partial class XemThoiKhoaBieu : Form {
        LichHoc[] listLH;
        MonHoc[] listMH;

        public XemThoiKhoaBieu() {
            InitializeComponent();
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.lichHocData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            sr.Close();
            listLH = LichHoc.getLichHoc(json);
            this.setupDSHocKy();
            this.setLichThi(listLH[0]);
            comboBox_ds_hoc_ki.Text = listLH[0].ten_hocky;

        }

        public static void setupHeader(Label lb) {
            Color cl = ColorTranslator.FromHtml("#075385");
            lb.BackColor = cl;
            Font font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb.Font = font;
            lb.ForeColor = Color.White;
        }

        public void setupHeader() {
            LichHocItem lt = new LichHocItem();
            setupHeader(lt.ma_mon_hoc);
            setupHeader(lt.ten_mon_hoc);
            setupHeader(lt.nhom_to);
            setupHeader(lt.phong);
            setupHeader(lt.thu);
            setupHeader(lt.tiet);
            setupHeader(lt.tuan_hoc);
           
            lt.Name = "header_lichthi";
            lt.Dock = DockStyle.Top;
            this.panel_lichhoc.Controls.Add(lt);
        }

        public void setupDSHocKy() {
            comboBox_ds_hoc_ki.DisplayMember = "KeyValuePair<string, LichHoc>.Key";
            for (int i = 0; i < listLH.Length; i++) {
                KeyValuePair<String, LichHoc> item =
                new KeyValuePair<string, LichHoc>(listLH[i].ten_hocky, listLH[i]);
                comboBox_ds_hoc_ki.Items.Add(item);
                // comboBox_ds_hoc_ki.Items.Add(new { Text = listLH[i].ten_hocky, Value = listLH[i] });
            }
            comboBox_ds_hoc_ki.Text = listLH[0].ten_hocky;
        }
        public void setLichThi(LichHoc lh) {

            this.panel_lichhoc.Controls.Clear();

            Control ct = this.panel_lichhoc.Controls["header_lichthi"];
            if (ct != null) 
                this.panel_lichhoc.Controls.Remove(ct);

            listMH = lh.ds_mon_hoc.ToArray<MonHoc>();

            for (int i = listMH.Length - 1; i >= 0; i--) {
                LichHocItem item = new LichHocItem();
                item.ma_mon_hoc.Text = listMH[i].ma_mh;
                item.ten_mon_hoc.Text = listMH[i].ten_mh;
                item.nhom_to.Text = listMH[i].nhomto;
                item.phong.Text = listMH[i].phong1;
                item.thu.Text = listMH[i].thu1;
                item.tiet.Text = listMH[i].tiet_bd1 + "-" + listMH[i].tiet_kt1;
                item.tuan_hoc.Text = listMH[i].tuan_hoc;

                item.TabIndex = i;
                item.Dock = DockStyle.Top;
                this.panel_lichhoc.Controls.Add(item);
            }
            setupHeader();
        }

        private void comboBox_ds_hoc_ki_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<String, LichHoc> item = (KeyValuePair<String, LichHoc>)comboBox_ds_hoc_ki.SelectedItem;
            this.setLichThi(item.Value);
        }
    }
}
