using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace MyBK.Gui.MyUserControl {
    public partial class LoginForm : UserControl {
        public event EventHandler buttonLoginClicked;
        public LoginForm() {
            InitializeComponent();
            textBox_pass.PasswordChar = '*';
        }

        private void button_login_Click(object sender, EventArgs e) {
            bool loginDone = false;
            String user = textBox_user.Text;
            String pass = textBox_pass.Text;
            CookieContainer cc = null;
            try {
                cc = MyBK.Lib.Request.POST.Login(user, pass);
                if (cc != null) {
                    loginDone = true;

                    StreamWriter sw = new StreamWriter(MyBK.Lib.Data.PathData.config);
                    sw.WriteLine(1);
                    sw.WriteLine(user);
                    sw.WriteLine(pass);
                    sw.Close();
                }
                else {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "MyBK");
                }

                if (buttonLoginClicked != null && loginDone)
                    buttonLoginClicked(this, e);
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Lỗi");
            }


        }
    }
}
