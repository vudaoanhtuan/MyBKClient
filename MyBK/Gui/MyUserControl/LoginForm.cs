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
    public partial class LoginForm : UserControl {
        public event EventHandler buttonLoginClicked;
        public LoginForm() {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e) {
            bool loginDone = true;
            // check login success here;
            if (buttonLoginClicked != null && loginDone)
                buttonLoginClicked(this, e);
        }
    }
}
