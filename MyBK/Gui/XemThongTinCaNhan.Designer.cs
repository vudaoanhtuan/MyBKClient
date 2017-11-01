namespace MyBK.Gui {
    partial class XemThongTinCaNhan {
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
            this.panel_anh = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_image = new System.Windows.Forms.Panel();
            this.panel_anh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_anh
            // 
            this.panel_anh.Controls.Add(this.panel_image);
            this.panel_anh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_anh.Location = new System.Drawing.Point(0, 0);
            this.panel_anh.Name = "panel_anh";
            this.panel_anh.Size = new System.Drawing.Size(991, 220);
            this.panel_anh.TabIndex = 0;
            // 
            // panel_info
            // 
            this.panel_info.AutoScroll = true;
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_info.Location = new System.Drawing.Point(0, 220);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(991, 644);
            this.panel_info.TabIndex = 1;
            // 
            // panel_image
            // 
            this.panel_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_image.Location = new System.Drawing.Point(397, 12);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(189, 202);
            this.panel_image.TabIndex = 0;
            // 
            // XemThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 864);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_anh);
            this.Name = "XemThongTinCaNhan";
            this.Text = "XemThongTinCaNhan";
            this.panel_anh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_anh;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_image;
    }
}