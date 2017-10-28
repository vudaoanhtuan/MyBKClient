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
    public partial class TTCNItem : UserControl {
        public TTCNItem() {
            InitializeComponent();
        }

        public TTCNItem(String key, String value) {
            InitializeComponent();
            this.label_key.Text = key;
            this.label_value.Text = value;
        }
    }
}
