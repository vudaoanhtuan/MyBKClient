﻿namespace MyBK.Gui {
    partial class XemChuongTrinhDaoTao {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemChuongTrinhDaoTao));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_chuong_trinh_dao_tao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_ds_hoc_ki = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_chuong_trinh_dao_tao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.09985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 686);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel_chuong_trinh_dao_tao
            // 
            this.panel_chuong_trinh_dao_tao.AutoScroll = true;
            this.panel_chuong_trinh_dao_tao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chuong_trinh_dao_tao.Location = new System.Drawing.Point(3, 43);
            this.panel_chuong_trinh_dao_tao.Name = "panel_chuong_trinh_dao_tao";
            this.panel_chuong_trinh_dao_tao.Size = new System.Drawing.Size(1029, 640);
            this.panel_chuong_trinh_dao_tao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_ds_hoc_ki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 34);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_ds_hoc_ki
            // 
            this.comboBox_ds_hoc_ki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_ds_hoc_ki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ds_hoc_ki.FormattingEnabled = true;
            this.comboBox_ds_hoc_ki.Location = new System.Drawing.Point(377, 5);
            this.comboBox_ds_hoc_ki.Name = "comboBox_ds_hoc_ki";
            this.comboBox_ds_hoc_ki.Size = new System.Drawing.Size(300, 28);
            this.comboBox_ds_hoc_ki.TabIndex = 1;
            this.comboBox_ds_hoc_ki.SelectedValueChanged += new System.EventHandler(this.comboBox_ds_hoc_ki_SelectedValueChanged);
            // 
            // XemChuongTrinhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemChuongTrinhDaoTao";
            this.Text = "XemChuongTrinhDaoTao";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_chuong_trinh_dao_tao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_ds_hoc_ki;
    }
}