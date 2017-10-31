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
using MyBK.Lib.Data;
using MyBK.Gui.MyUserControl;
using MyBK.Gui;
using MyBK.Lib.Request;

namespace MyBK.Gui {
    public partial class MainWindow : Form {
        bool Logined;
        String user;
        String pass;
        public MainWindow() {
            InitializeComponent();
            Logined = checkLogin();
            if (!Logined) {
                flowLayout_Body.Hide();
                LoginForm lf = new LoginForm();
                lf.Dock = DockStyle.Top;
                lf.Name = "loginform";
                lf.Margin = new Padding(50,50,50,0);
                tablePanel_all.Controls.Add(lf, 0, 1);
                lf.buttonLoginClicked += LoadDataLoginSuccess;
            }
            
        }

        void LoadDataLoginSuccess(object sender, EventArgs e) {
            // show panel
            Control ct = tablePanel_all.Controls["loginform"];
            if (ct != null) {
                tablePanel_all.Controls.Remove(ct);
            }
            flowLayout_Body.Show();

            // load data from mybk

            StreamWriter sw;
            MyBKStInfo mybk = new MyBKStInfo();
            String response;

            sw = new StreamWriter(MyBK.Lib.Data.PathData.lichHocData, false, Encoding.UTF8);
            response = mybk.getLichHoc();
            sw.Write(response);
            sw.Close();

            sw = new StreamWriter(MyBK.Lib.Data.PathData.lichThiData, false, Encoding.UTF8);
            response = mybk.getLichThi();
            sw.Write(response);
            sw.Close();

            sw = new StreamWriter(MyBK.Lib.Data.PathData.bangDiemData, false, Encoding.UTF8);
            response = mybk.getBangDiem();
            sw.Write(response);
            sw.Close();

            sw = new StreamWriter(MyBK.Lib.Data.PathData.ttcnXML, false, Encoding.UTF8);
            response = mybk.getThongTinCaNhan();
            sw.Write(response);
            sw.Close();


            sw = new StreamWriter(MyBK.Lib.Data.PathData.ttcnData, false, Encoding.UTF8);
            response = MyBK.Lib.Parser.XMLParser.parseTTCN(response);
            sw.Write(response);
            sw.Close();


        }



        bool checkLogin() {
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.config);
            String login = sr.ReadLine();
            if (login == null) {
                sr.Close();
                return false;
            }
            if (login.Equals("1")) {
                user = sr.ReadLine();
                pass = sr.ReadLine();
                sr.Close();
                return true;
            }
            sr.Close();
            return false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void button_thoi_khoa_bieu_Click(object sender, EventArgs e) {
            XemThoiKhoaBieu xtkb = new XemThoiKhoaBieu();
            xtkb.Show();
        }

        private void button_lich_thi_Click(object sender, EventArgs e) {
            XemLichThi xlt = new XemLichThi();
            xlt.Show();
        }

        private void button_bang_diem_Click(object sender, EventArgs e) {
            XemDiem xd = new XemDiem();
            xd.Show();
        }

        private void button_tt_ca_nhan_Click(object sender, EventArgs e) {
            XemThongTinCaNhan xttcn = new XemThongTinCaNhan();
            xttcn.Show();
        }

        private void button_exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_logout_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter(MyBK.Lib.Data.PathData.config, false);
            sw.Write(0);
            sw.Close();
            flowLayout_Body.Hide();
            LoginForm lf = new LoginForm();
            lf.Dock = DockStyle.Top;
            lf.Name = "loginform";
            lf.Margin = new Padding(50, 50, 50, 0);
            tablePanel_all.Controls.Add(lf, 0, 1);
            lf.buttonLoginClicked += LoadDataLoginSuccess;
        }
    }
}
