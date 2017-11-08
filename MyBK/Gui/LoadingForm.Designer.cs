namespace MyBK.Gui {
    partial class LoadingForm {
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
            this.lable_loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable_loading
            // 
            this.lable_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_loading.Location = new System.Drawing.Point(12, 9);
            this.lable_loading.Name = "lable_loading";
            this.lable_loading.Size = new System.Drawing.Size(215, 45);
            this.lable_loading.TabIndex = 4;
            this.lable_loading.Text = "Đang tải dữ liệu...";
            this.lable_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 63);
            this.Controls.Add(this.lable_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lable_loading;
    }
}