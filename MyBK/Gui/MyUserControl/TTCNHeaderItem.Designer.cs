namespace MyBK.Gui.MyUserControl {
    partial class TTCNHeaderItem {
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
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.White;
            this.label_info.Location = new System.Drawing.Point(0, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(912, 52);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "Info";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TTCNHeaderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_info);
            this.Name = "TTCNHeaderItem";
            this.Size = new System.Drawing.Size(912, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_info;
    }
}
