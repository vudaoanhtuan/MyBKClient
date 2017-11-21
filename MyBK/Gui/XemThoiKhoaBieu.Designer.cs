namespace MyBK.Gui {
    partial class XemThoiKhoaBieu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemThoiKhoaBieu));
            this.comboBox_ds_hoc_ki = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_lichhoc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_export = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ds_hoc_ki
            // 
            this.comboBox_ds_hoc_ki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_ds_hoc_ki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ds_hoc_ki.FormattingEnabled = true;
            this.comboBox_ds_hoc_ki.Location = new System.Drawing.Point(446, 5);
            this.comboBox_ds_hoc_ki.Name = "comboBox_ds_hoc_ki";
            this.comboBox_ds_hoc_ki.Size = new System.Drawing.Size(300, 28);
            this.comboBox_ds_hoc_ki.TabIndex = 1;
            this.comboBox_ds_hoc_ki.SelectedValueChanged += new System.EventHandler(this.comboBox_ds_hoc_ki_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_lichhoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.32899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.67101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 636);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel_lichhoc
            // 
            this.panel_lichhoc.AutoScroll = true;
            this.panel_lichhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_lichhoc.Location = new System.Drawing.Point(3, 49);
            this.panel_lichhoc.Name = "panel_lichhoc";
            this.panel_lichhoc.Size = new System.Drawing.Size(1167, 584);
            this.panel_lichhoc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_export);
            this.panel1.Controls.Add(this.comboBox_ds_hoc_ki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 40);
            this.panel1.TabIndex = 1;
            // 
            // button_export
            // 
            this.button_export.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_export.Location = new System.Drawing.Point(1080, 0);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(87, 40);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Xuất file";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button1_Click);
            // 
            // XemThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemThoiKhoaBieu";
            this.Text = "XemThoiKhoaBieu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ds_hoc_ki;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_lichhoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_export;
    }
}