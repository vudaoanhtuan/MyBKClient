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
    public partial class XemThoiKhoaBieu : Form {
        public XemThoiKhoaBieu() {
            InitializeComponent();
            LichHocItem l = new LichHocItem();
            this.Controls.Add(l);

        }
    }
}
