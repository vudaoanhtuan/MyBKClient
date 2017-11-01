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

namespace MyBK.Gui {
    public partial class XemThongTinCaNhan : Form {
        public XemThongTinCaNhan() {
            InitializeComponent();
            StreamReader sr = new StreamReader(MyBK.Lib.Data.PathData.ttcnData, Encoding.UTF8);
            String line;
            List<String> listInfo = new List<String>();
            while ((line = sr.ReadLine()) != null) {
                listInfo.Add(line);
            }
            sr.Close();
            listInfo.Reverse();
            if (listInfo[0].Length < 2)
                listInfo.RemoveAt(0);
            for (int i=12; i<listInfo.Count; i++) {
                line = listInfo[i];
                if (line.IndexOf("|") > 0) {
                    addItem(line.Split('|')[0], line.Split('|')[1]);
                }
                else {
                    addHeader(line);
                }
            }

            // show image;
            sr = new StreamReader(MyBK.Lib.Data.PathData.imageText);
            byte[] imageBytes = Convert.FromBase64String(sr.ReadToEnd());
            sr.Close();
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            panel_image.BackgroundImage = image;
            
        }

        public void addHeader(String info) {
            TTCNHeaderItem header = new TTCNHeaderItem(info);
            header.Dock = DockStyle.Top;
            panel_info.Controls.Add(header);
        }

        public void addItem(String key, String value) {
            TTCNItem item = new TTCNItem(key, value);
            item.Dock = DockStyle.Top;
            panel_info.Controls.Add(item);
        }
    }
}
