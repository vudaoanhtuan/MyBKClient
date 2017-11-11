using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyBK.Lib.Data.JSON;
using MyBK.Gui.MyUserControl;



namespace MyBK.Gui {
    public partial class XemDiem : Form {
        DiemMonHoc[] listDMH;
        BangDiem[] listBD;
        DiemItem[] listItem;

        public XemDiem() {
            InitializeComponent();
            this.setupHeader();

            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.bangDiemData, Encoding.UTF8);
            String json = sr.ReadToEnd();
            sr.Close();
            listBD = BangDiem.getBangDiem(json);

            this.setLichHoc(listBD[0]);
            comboBox_ds_hoc_ki.Text = listBD[0].ten_hocky;
            this.setupDSHocKy();
        }
        public void setupDSHocKy() {
            comboBox_ds_hoc_ki.DisplayMember = "KeyValuePair<string, LichHoc>.Key";
            for (int i = 0; i < listBD.Length; i++) {
                KeyValuePair<String, BangDiem> item =
                new KeyValuePair<string, BangDiem>(listBD[i].ten_hocky, listBD[i]);
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
            DiemItem lt = new DiemItem();
            setupHeader(lt.ma_mon_hoc);
            setupHeader(lt.ten_mon_hoc);
            setupHeader(lt.nhom_to);
            setupHeader(lt.sotinchi);
            setupHeader(lt.diemthanhphan);
            setupHeader(lt.diemthi);
            setupHeader(lt.diemtongket);
            lt.Name = "header_bangdiem";
            lt.Dock = DockStyle.Top;
            this.panel_bangdiem.Controls.Add(lt);
        }

        public void setLichHoc(BangDiem bd) {

            if (listItem != null)
                for (int i = 0; i < listItem.Length; i++)
                    this.panel_bangdiem.Controls.Remove(listItem[i]);

            Control ct = this.panel_bangdiem.Controls["header_bangdiem"];
            if (ct != null) 
                this.panel_bangdiem.Controls.Remove(ct);

            listDMH = bd.bang_diem.ToArray<DiemMonHoc>();
            listItem = new DiemItem[listDMH.Length];
            for (int i = listDMH.Length - 1; i >= 0; i--) {
                DiemItem item = new DiemItem();
                item.ma_mon_hoc.Text = listDMH[i].ma_mh;
                item.ten_mon_hoc.Text = listDMH[i].ten_mh;
                item.nhom_to.Text = listDMH[i].nhomto;
                item.sotinchi.Text = listDMH[i].so_tc;
                item.diemthanhphan.Text = listDMH[i].diem_thanhphan;
                item.diemthi.Text = listDMH[i].diem_thi;
                item.diemtongket.Text = listDMH[i].diem_tong_ket;
                listItem[i] = item;
                item.Dock = DockStyle.Top;
                this.panel_bangdiem.Controls.Add(item);
            }
            setupHeader();
            this.diemTBHK.Text = "Điểm trung bình học kỳ: " + bd.diem_tb;
            this.diemTBTL.Text = "Điểm trung bình tích lũy: " + bd.diem_tb;
            this.soTCDK.Text = "Số tín chỉ đăng ký học kỳ: " + bd.so_tc;
            this.soTCTL.Text = "Số tín chỉ tích lũy: " + bd.so_tctl;
            this.soTCTLHK.Text = "Số tín chỉ tích lũy học kỳ: " + bd.so_tctl_hk;
        }

        private void comboBox_ds_hoc_ki_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<String, BangDiem> item = (KeyValuePair<String, BangDiem>)comboBox_ds_hoc_ki.SelectedItem;
            this.setLichHoc(item.Value);
        }

    }
}
