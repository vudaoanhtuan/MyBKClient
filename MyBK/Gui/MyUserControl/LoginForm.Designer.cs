namespace MyBK.Gui.MyUserControl {
    partial class LoginForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayout_Login = new System.Windows.Forms.TableLayoutPanel();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.tableLayout_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Login
            // 
            this.tableLayout_Login.ColumnCount = 2;
            this.tableLayout_Login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.65116F));
            this.tableLayout_Login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.34884F));
            this.tableLayout_Login.Controls.Add(this.label_user, 0, 0);
            this.tableLayout_Login.Controls.Add(this.label_pass, 0, 1);
            this.tableLayout_Login.Controls.Add(this.textBox_user, 1, 0);
            this.tableLayout_Login.Controls.Add(this.textBox_pass, 1, 1);
            this.tableLayout_Login.Controls.Add(this.button_login, 1, 2);
            this.tableLayout_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Login.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Login.Name = "tableLayout_Login";
            this.tableLayout_Login.RowCount = 3;
            this.tableLayout_Login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayout_Login.Size = new System.Drawing.Size(344, 128);
            this.tableLayout_Login.TabIndex = 0;
            // 
            // label_user
            // 
            this.label_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_user.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(3, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(95, 37);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "MSSV";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pass
            // 
            this.label_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_pass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(3, 37);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(95, 37);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Mật khẩu";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_user
            // 
            this.textBox_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_user.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(104, 3);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(237, 28);
            this.textBox_user.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_pass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(104, 40);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(237, 28);
            this.textBox_pass.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(104, 77);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(125, 34);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Đăng nhập";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_Login);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(344, 128);
            this.tableLayout_Login.ResumeLayout(false);
            this.tableLayout_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_Login;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        public System.Windows.Forms.TextBox textBox_user;
        public System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_login;
    }
}
