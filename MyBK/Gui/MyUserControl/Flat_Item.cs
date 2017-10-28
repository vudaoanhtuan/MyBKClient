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
    public partial class Flat_Item : UserControl {
        public Label[] listLable;
        public Flat_Item() {
            InitializeComponent();
        }

        public Flat_Item(int numItem) {
            
            listLable = new Label[numItem];
            for (int i=0; i<numItem; i++) {
                Label lb = new Label();
                lb.Name = "item" + i;
                lb.Dock = DockStyle.Left;
                lb.AutoSize = false;
                lb.Visible = true;
                lb.BackColor = Color.Aqua;
                this.Controls.Add(lb);
                listLable[i] = lb;
            }
            
            InitializeComponent();
        }

    }


}
