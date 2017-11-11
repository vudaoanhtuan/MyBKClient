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
    public partial class NgayHoc_DKMHItem : UserControl {
        public NgayHoc_DKMHItem() {
            InitializeComponent();
        }

        public void setHeader(Label lb) {
            Font font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb.Font = font;
        }

        public void setHeader() {
            setHeader(thu);
            setHeader(tiet);
            setHeader(phong);
            setHeader(coso);
            setHeader(bt);
            setHeader(tuan_hoc);
        }
    }
}
