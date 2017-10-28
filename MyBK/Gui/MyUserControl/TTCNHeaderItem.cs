using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBK.Gui.MyUserControl {
    public partial class TTCNHeaderItem : UserControl {
        public TTCNHeaderItem() {
            InitializeComponent();
        }

        public TTCNHeaderItem(String info) {
            InitializeComponent();
            this.label_info.Text = info;
        }
    }
}
