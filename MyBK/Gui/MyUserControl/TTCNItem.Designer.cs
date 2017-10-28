namespace MyBK.Gui.MyUserControl {
    partial class TTCNItem {
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
            this.tableLayout_TTCNitem = new System.Windows.Forms.TableLayoutPanel();
            this.label_key = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.tableLayout_TTCNitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_TTCNitem
            // 
            this.tableLayout_TTCNitem.ColumnCount = 2;
            this.tableLayout_TTCNitem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.55158F));
            this.tableLayout_TTCNitem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.44842F));
            this.tableLayout_TTCNitem.Controls.Add(this.label_value, 1, 0);
            this.tableLayout_TTCNitem.Controls.Add(this.label_key, 0, 0);
            this.tableLayout_TTCNitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_TTCNitem.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_TTCNitem.Name = "tableLayout_TTCNitem";
            this.tableLayout_TTCNitem.RowCount = 1;
            this.tableLayout_TTCNitem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_TTCNitem.Size = new System.Drawing.Size(979, 47);
            this.tableLayout_TTCNitem.TabIndex = 0;
            // 
            // label_key
            // 
            this.label_key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_key.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_key.Location = new System.Drawing.Point(3, 0);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(390, 47);
            this.label_key.TabIndex = 0;
            this.label_key.Text = "label1";
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_value
            // 
            this.label_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_value.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.Location = new System.Drawing.Point(399, 0);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(577, 47);
            this.label_value.TabIndex = 1;
            this.label_value.Text = "label1";
            this.label_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TTCNItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_TTCNitem);
            this.Name = "TTCNItem";
            this.Size = new System.Drawing.Size(979, 47);
            this.tableLayout_TTCNitem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_TTCNitem;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_key;
    }
}
