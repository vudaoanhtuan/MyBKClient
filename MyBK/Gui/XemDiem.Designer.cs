namespace MyBK.Gui {
    partial class XemDiem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiem));
            this.comboBox_ds_hoc_ki = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bangdiem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_export = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_dieminfo = new System.Windows.Forms.Panel();
            this.diemTBTL = new System.Windows.Forms.Label();
            this.diemTBHK = new System.Windows.Forms.Label();
            this.panel_tinchiinfo = new System.Windows.Forms.Panel();
            this.soTCTL = new System.Windows.Forms.Label();
            this.soTCTLHK = new System.Windows.Forms.Label();
            this.soTCDK = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_dieminfo.SuspendLayout();
            this.panel_tinchiinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ds_hoc_ki
            // 
            this.comboBox_ds_hoc_ki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_ds_hoc_ki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ds_hoc_ki.FormattingEnabled = true;
            this.comboBox_ds_hoc_ki.Location = new System.Drawing.Point(358, 5);
            this.comboBox_ds_hoc_ki.Name = "comboBox_ds_hoc_ki";
            this.comboBox_ds_hoc_ki.Size = new System.Drawing.Size(300, 28);
            this.comboBox_ds_hoc_ki.TabIndex = 1;
            this.comboBox_ds_hoc_ki.SelectedValueChanged += new System.EventHandler(this.comboBox_ds_hoc_ki_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_bangdiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.638555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.36144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 567);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel_bangdiem
            // 
            this.panel_bangdiem.AutoScroll = true;
            this.panel_bangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bangdiem.Location = new System.Drawing.Point(3, 49);
            this.panel_bangdiem.Name = "panel_bangdiem";
            this.panel_bangdiem.Size = new System.Drawing.Size(990, 425);
            this.panel_bangdiem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_export);
            this.panel1.Controls.Add(this.comboBox_ds_hoc_ki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 40);
            this.panel1.TabIndex = 1;
            // 
            // button_export
            // 
            this.button_export.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_export.Location = new System.Drawing.Point(905, 0);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(85, 40);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Xuất file";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel_dieminfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_tinchiinfo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(990, 84);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel_dieminfo
            // 
            this.panel_dieminfo.Controls.Add(this.diemTBTL);
            this.panel_dieminfo.Controls.Add(this.diemTBHK);
            this.panel_dieminfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dieminfo.Location = new System.Drawing.Point(3, 3);
            this.panel_dieminfo.Name = "panel_dieminfo";
            this.panel_dieminfo.Size = new System.Drawing.Size(489, 78);
            this.panel_dieminfo.TabIndex = 0;
            // 
            // diemTBTL
            // 
            this.diemTBTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.diemTBTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemTBTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(60)))), ((int)(((byte)(31)))));
            this.diemTBTL.Location = new System.Drawing.Point(0, 23);
            this.diemTBTL.Name = "diemTBTL";
            this.diemTBTL.Size = new System.Drawing.Size(489, 23);
            this.diemTBTL.TabIndex = 1;
            this.diemTBTL.Text = "Điểm trung bình tích lũy";
            // 
            // diemTBHK
            // 
            this.diemTBHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.diemTBHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemTBHK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(60)))), ((int)(((byte)(31)))));
            this.diemTBHK.Location = new System.Drawing.Point(0, 0);
            this.diemTBHK.Name = "diemTBHK";
            this.diemTBHK.Size = new System.Drawing.Size(489, 23);
            this.diemTBHK.TabIndex = 0;
            this.diemTBHK.Text = "Điểm trung bình học kỳ";
            // 
            // panel_tinchiinfo
            // 
            this.panel_tinchiinfo.Controls.Add(this.soTCTL);
            this.panel_tinchiinfo.Controls.Add(this.soTCTLHK);
            this.panel_tinchiinfo.Controls.Add(this.soTCDK);
            this.panel_tinchiinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tinchiinfo.Location = new System.Drawing.Point(498, 3);
            this.panel_tinchiinfo.Name = "panel_tinchiinfo";
            this.panel_tinchiinfo.Size = new System.Drawing.Size(489, 78);
            this.panel_tinchiinfo.TabIndex = 1;
            // 
            // soTCTL
            // 
            this.soTCTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.soTCTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTCTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(60)))), ((int)(((byte)(31)))));
            this.soTCTL.Location = new System.Drawing.Point(0, 46);
            this.soTCTL.Name = "soTCTL";
            this.soTCTL.Size = new System.Drawing.Size(489, 23);
            this.soTCTL.TabIndex = 3;
            this.soTCTL.Text = "Số tín chỉ tích lũy";
            // 
            // soTCTLHK
            // 
            this.soTCTLHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.soTCTLHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTCTLHK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(60)))), ((int)(((byte)(31)))));
            this.soTCTLHK.Location = new System.Drawing.Point(0, 23);
            this.soTCTLHK.Name = "soTCTLHK";
            this.soTCTLHK.Size = new System.Drawing.Size(489, 23);
            this.soTCTLHK.TabIndex = 2;
            this.soTCTLHK.Text = "Số tín chỉ tích lũy học kỳ";
            // 
            // soTCDK
            // 
            this.soTCDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.soTCDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTCDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(60)))), ((int)(((byte)(31)))));
            this.soTCDK.Location = new System.Drawing.Point(0, 0);
            this.soTCDK.Name = "soTCDK";
            this.soTCDK.Size = new System.Drawing.Size(489, 23);
            this.soTCDK.TabIndex = 1;
            this.soTCDK.Text = "Số tín chỉ đăng ký học kỳ";
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemDiem";
            this.Text = "XemDiem";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_dieminfo.ResumeLayout(false);
            this.panel_tinchiinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ds_hoc_ki;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_bangdiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_dieminfo;
        private System.Windows.Forms.Label diemTBTL;
        private System.Windows.Forms.Label diemTBHK;
        private System.Windows.Forms.Panel panel_tinchiinfo;
        private System.Windows.Forms.Label soTCTL;
        private System.Windows.Forms.Label soTCTLHK;
        private System.Windows.Forms.Label soTCDK;
        private System.Windows.Forms.Button button_export;
    }
}