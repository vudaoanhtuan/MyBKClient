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
    public partial class NhomLopItem : UserControl {
        public NhomLopItem() {
            InitializeComponent();
        }

        public NhomLopItem(String inhomlop, String idkss, String ingonngu, String inhomLT,
            String igvLT, String inhomBT, String igvBT, String issLT) {
            InitializeComponent();
            nhomlop.Text = inhomlop;
            dk_siso.Text = idkss;
            ngonngu.Text = ingonngu;
            nhomLT.Text = inhomLT;
            giangvienLT.Text = igvLT;
            nhomBT.Text = inhomBT;
            giangvienBT.Text = igvBT;
            sisoLT.Text = issLT;        
        }

        public void setHeader(Label lb) {
            Color cl = ColorTranslator.FromHtml("#075385");
            lb.BackColor = cl;
            Font font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb.Font = font;
            lb.ForeColor = Color.White;
        }

        public void setHeader() {
            setHeader(nhomlop);
            setHeader(dk_siso);
            setHeader(ngonngu);
            setHeader(nhomLT);
            setHeader(giangvienLT);
            setHeader(nhomBT);
            setHeader(giangvienBT);
            setHeader(sisoLT);
            

        }
    }


}
