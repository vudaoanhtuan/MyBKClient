namespace MyBK.Gui {
    partial class XemmyBKDKMH {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemmyBKDKMH));
            this.tableLayoutPanel_mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_msmh = new System.Windows.Forms.TextBox();
            this.comboBox_loaiDK = new System.Windows.Forms.ComboBox();
            this.panel_monhoc = new System.Windows.Forms.Panel();
            this.panel_nhomLopHeader = new System.Windows.Forms.Panel();
            this.nhomLopHeader = new MyBK.Gui.MyUserControl.NhomLopItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_soTC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_tenMH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_maMH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_nhomLopHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_mainPanel
            // 
            this.tableLayoutPanel_mainPanel.ColumnCount = 1;
            this.tableLayoutPanel_mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mainPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_mainPanel.Controls.Add(this.panel_monhoc, 0, 3);
            this.tableLayoutPanel_mainPanel.Controls.Add(this.panel_nhomLopHeader, 0, 2);
            this.tableLayoutPanel_mainPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel_mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mainPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_mainPanel.Name = "tableLayoutPanel_mainPanel";
            this.tableLayoutPanel_mainPanel.RowCount = 4;
            this.tableLayoutPanel_mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel_mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel_mainPanel.Size = new System.Drawing.Size(1163, 675);
            this.tableLayoutPanel_mainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_msmh);
            this.panel1.Controls.Add(this.comboBox_loaiDK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 62);
            this.panel1.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(797, 10);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(92, 40);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Tìm";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn học kì";
            // 
            // textBox_msmh
            // 
            this.textBox_msmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_msmh.Location = new System.Drawing.Point(284, 33);
            this.textBox_msmh.Name = "textBox_msmh";
            this.textBox_msmh.Size = new System.Drawing.Size(483, 26);
            this.textBox_msmh.TabIndex = 2;
            // 
            // comboBox_loaiDK
            // 
            this.comboBox_loaiDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loaiDK.FormattingEnabled = true;
            this.comboBox_loaiDK.Location = new System.Drawing.Point(284, 3);
            this.comboBox_loaiDK.Name = "comboBox_loaiDK";
            this.comboBox_loaiDK.Size = new System.Drawing.Size(483, 28);
            this.comboBox_loaiDK.TabIndex = 1;
            this.comboBox_loaiDK.SelectedValueChanged += new System.EventHandler(this.comboBox_loaiDK_SelectedValueChanged);
            // 
            // panel_monhoc
            // 
            this.panel_monhoc.AutoScroll = true;
            this.panel_monhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_monhoc.Location = new System.Drawing.Point(3, 171);
            this.panel_monhoc.Name = "panel_monhoc";
            this.panel_monhoc.Size = new System.Drawing.Size(1157, 501);
            this.panel_monhoc.TabIndex = 5;
            // 
            // panel_nhomLopHeader
            // 
            this.panel_nhomLopHeader.Controls.Add(this.nhomLopHeader);
            this.panel_nhomLopHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nhomLopHeader.Location = new System.Drawing.Point(3, 111);
            this.panel_nhomLopHeader.Name = "panel_nhomLopHeader";
            this.panel_nhomLopHeader.Size = new System.Drawing.Size(1157, 54);
            this.panel_nhomLopHeader.TabIndex = 6;
            // 
            // nhomLopHeader
            // 
            this.nhomLopHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomLopHeader.Location = new System.Drawing.Point(0, 0);
            this.nhomLopHeader.Name = "nhomLopHeader";
            this.nhomLopHeader.Size = new System.Drawing.Size(1157, 54);
            this.nhomLopHeader.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanel1.Controls.Add(this.label_soTC, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_tenMH, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_maMH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 34);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label_soTC
            // 
            this.label_soTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_soTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soTC.Location = new System.Drawing.Point(744, 0);
            this.label_soTC.Name = "label_soTC";
            this.label_soTC.Size = new System.Drawing.Size(91, 34);
            this.label_soTC.TabIndex = 5;
            this.label_soTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số TC:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tenMH
            // 
            this.label_tenMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenMH.Location = new System.Drawing.Point(365, 0);
            this.label_tenMH.Name = "label_tenMH";
            this.label_tenMH.Size = new System.Drawing.Size(266, 34);
            this.label_tenMH.TabIndex = 3;
            this.label_tenMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên MH:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_maMH
            // 
            this.label_maMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_maMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maMH.Location = new System.Drawing.Point(128, 0);
            this.label_maMH.Name = "label_maMH";
            this.label_maMH.Size = new System.Drawing.Size(120, 34);
            this.label_maMH.TabIndex = 1;
            this.label_maMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã MH:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XemmyBKDKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 675);
            this.Controls.Add(this.tableLayoutPanel_mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemmyBKDKMH";
            this.Text = "myBKDKMH";
            this.tableLayoutPanel_mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_nhomLopHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_msmh;
        private System.Windows.Forms.ComboBox comboBox_loaiDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel_monhoc;
        private System.Windows.Forms.Panel panel_nhomLopHeader;
        private MyUserControl.NhomLopItem nhomLopHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_soTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_tenMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_maMH;
        private System.Windows.Forms.Label label3;
    }
}