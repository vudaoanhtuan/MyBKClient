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
    public partial class XemLichHoc : Form {
        LichHoc[] listLH;
        MonHoc[] listMH;
        LichHocItem[] listItem;
        public XemLichHoc() {
            InitializeComponent();
            this.setupHeader();
            
            StreamReader sr = new StreamReader(PathData.lichHocData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            sr.Close();
            listLH = LichHoc.getLichHoc(json);
           
            this.setLichHoc(listLH[0]);
            comboBox_ds_hoc_ki.Text = listLH[0].ten_hocky;
            this.setupDSHocKy();
        }

        public void setupDSHocKy() {
            comboBox_ds_hoc_ki.DisplayMember = "KeyValuePair<string, LichHoc>.Key";
            for (int i=0; i< listLH.Length; i++) {
                KeyValuePair<String, LichHoc> item =
                new KeyValuePair<string, LichHoc>(listLH[i].ten_hocky, listLH[i]);
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
            LichHocItem lt = new LichHocItem();
            setupHeader(lt.thu);
            setupHeader(lt.ma_mon_hoc);
            setupHeader(lt.ten_mon_hoc);
            setupHeader(lt.nhom_to);
            setupHeader(lt.phong);
            setupHeader(lt.tuan_hoc);
            setupHeader(lt.tiet);
            lt.Name = "header_tkb";
            lt.Dock = DockStyle.Top;
            this.panel_thoi_khoa_bieu.Controls.Add(lt);
        }

        public void setLichHoc(LichHoc lh) {
          
            if (listItem != null)
                for (int i = 0; i < listItem.Length; i++)
                    this.panel_thoi_khoa_bieu.Controls.Remove(listItem[i]);

            Control ct = this.panel_thoi_khoa_bieu.Controls["header_tkb"];
            if (ct != null) 
                this.panel_thoi_khoa_bieu.Controls.Remove(ct);

            listMH = lh.ds_mon_hoc.ToArray<MonHoc>();
            listItem = new LichHocItem[listMH.Length];
            for (int i=listMH.Length-1; i>=0; i--) {
                LichHocItem item = new LichHocItem();
                item.ma_mon_hoc.Text = listMH[i].ma_mh;
                item.ten_mon_hoc.Text = listMH[i].ten_mh;
                item.nhom_to.Text = listMH[i].nhomto;
                item.tiet.Text = listMH[i].tiet_bd1 + "-" + listMH[i].tiet_kt1;
                item.phong.Text = listMH[i].phong1;
                item.thu.Text = listMH[i].thu1;
                item.tuan_hoc.Text = listMH[i].tuan_hoc;
                listItem[i] = item;
                item.Dock = DockStyle.Top;
                this.panel_thoi_khoa_bieu.Controls.Add(item);
            }
            setupHeader();
        }

        private void comboBox_ds_hoc_ki_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<String, LichHoc> item = (KeyValuePair<String, LichHoc>)comboBox_ds_hoc_ki.SelectedItem;
            this.setLichHoc(item.Value);
        }
    }
}
