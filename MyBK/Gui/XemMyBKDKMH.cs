using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBK.Lib.Request;
using MyBK.Lib.Data.DangKy;
using MyBK.Lib.Parser;
using MyBK.Lib.Data.MonHoc;
using MyBK.Gui.MyUserControl;

namespace MyBK.Gui {
    public partial class XemmyBKDKMH : Form {
        MyBKDKMH dkmh;
        public XemmyBKDKMH() {
            InitializeComponent();
            nhomLopHeader.setHeader();
            dkmh = new MyBKDKMH();

            String html = dkmh.getDanhSachLoaiDangKy();

            LoaiDangKy[] listLoaiDK = XMLParser.getDSLoaiDangKy(html);

            comboBox_loaiDK.DisplayMember = "KeyValuePair<string, LoaiDangKy>.Key";

            for (int i = 0; i < listLoaiDK.Length; i++) {
                if (listLoaiDK[i].tenLoaiDK.IndexOf("Kết") >= 0) {
                    KeyValuePair<string, LoaiDangKy> item =
                        new KeyValuePair<string, LoaiDangKy>(listLoaiDK[i].tenLoaiDK, listLoaiDK[i]);
                    comboBox_loaiDK.Items.Add(item); 

                }
            }
           
        }

        private void button_search_Click(object sender, EventArgs e) {
            // xoa control
            panel_monhoc.Controls.Clear();
            label_soTC.Text = "";
            label_maMH.Text = "";
            label_tenMH.Text = "";

            String msmh = textBox_msmh.Text;
            String html = dkmh.searchMonHocDangKy(msmh);

            if (html.IndexOf("tblMonHocMoLop") < 0) {
                Label lb = new Label();
                lb.Text = "Không có môn học mở";
                lb.Dock = DockStyle.Top;
                panel_monhoc.Controls.Add(lb);
                return;
            }

            String monhocId = XMLParser.getMonHocIdFromHtml(html);
            String soTC = XMLParser.getSoTCMonHocIdFromHtml(html);

            html = dkmh.getThongTinNhomLopMonHoc(monhocId);

            MonHoc monhoc = XMLParser.exportMonHoc(html);
            LopHoc[] listLH = monhoc.lopHoc;

            // set thong tin mon hoc

            label_maMH.Text = monhoc.maSoMonHoc;
            label_tenMH.Text = monhoc.tenMonHoc;
            label_soTC.Text = soTC;
            

            for (int i=listLH.Length - 1; i >= 0; i--) {

                BuoiHoc[] bh = listLH[i].buoiHoc;
                for (int j = bh.Length - 1; j >= 0; j--) {
                    NgayHoc_DKMHItem itembh = new NgayHoc_DKMHItem();
                    itembh.thu.Text = bh[j].thu;
                    itembh.tiet.Text = bh[j].tiet;
                    itembh.phong.Text = bh[j].phong;
                    itembh.coso.Text = bh[j].coSo;
                    itembh.bt.Text = bh[j].lopBT;
                    itembh.tuan_hoc.Text = bh[j].tuan;
                    itembh.Dock = DockStyle.Top;
                    panel_monhoc.Controls.Add(itembh);
                }

                NgayHoc_DKMHItem ngayhocheader = new NgayHoc_DKMHItem();
                ngayhocheader.setHeader();
                ngayhocheader.Dock = DockStyle.Top;
                panel_monhoc.Controls.Add(ngayhocheader);

                NhomLopItem item = new NhomLopItem();
                item.nhomlop.Text = listLH[i].nhomLop;
                item.dk_siso.Text = listLH[i].soSVDK;
                item.ngonngu.Text = listLH[i].ngonNgu;
                item.nhomLT.Text = listLH[i].nhomLT;
                item.giangvienLT.Text = listLH[i].gvLT;
                item.nhomBT.Text = listLH[i].nhomBT;
                item.giangvienBT.Text = listLH[i].gvBT;
                item.sisoLT.Text = listLH[i].siSoLop;
                item.Dock = DockStyle.Top;
                panel_monhoc.Controls.Add(item);
            }

            if (panel_monhoc.VerticalScroll.Visible)
                panel_nhomLopHeader.VerticalScroll.Visible = true;
            else
                panel_nhomLopHeader.VerticalScroll.Visible = false;

            panel_nhomLopHeader.VerticalScroll.Enabled = false;

        }

        private void comboBox_loaiDK_SelectedValueChanged(object sender, EventArgs e) {
            KeyValuePair<string, LoaiDangKy> item = (KeyValuePair<string, LoaiDangKy>)comboBox_loaiDK.SelectedItem;
            String html = dkmh.getDanhSachDotDK(item.Value.hocKyID);
            DotDangKy[] d = XMLParser.getDSDotDangKy(html);
            html = dkmh.getLichDangKy(d[0].idDotDangKy, d[0].idDotDangKy);


        }


    }
}
