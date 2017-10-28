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

namespace MyBK.Gui {
    public partial class XemThongTinCaNhan : Form {
        public XemThongTinCaNhan() {
            InitializeComponent();
            
            addHeader("Thông tin cá nhân");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");
            addItem("Họ và tên", "");


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
