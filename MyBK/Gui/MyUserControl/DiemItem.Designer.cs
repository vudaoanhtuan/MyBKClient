namespace MyBK.Gui.MyUserControl {
    partial class DiemItem {
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
            this.tableLayout_diem_item = new System.Windows.Forms.TableLayoutPanel();
            this.diemtongket = new System.Windows.Forms.Label();
            this.diemthi = new System.Windows.Forms.Label();
            this.sotinchi = new System.Windows.Forms.Label();
            this.nhom_to = new System.Windows.Forms.Label();
            this.ten_mon_hoc = new System.Windows.Forms.Label();
            this.ma_mon_hoc = new System.Windows.Forms.Label();
            this.diemthanhphan = new System.Windows.Forms.Label();
            this.tableLayout_diem_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_diem_item
            // 
            this.tableLayout_diem_item.ColumnCount = 7;
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.24282F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.75718F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayout_diem_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayout_diem_item.Controls.Add(this.diemtongket, 6, 0);
            this.tableLayout_diem_item.Controls.Add(this.diemthi, 5, 0);
            this.tableLayout_diem_item.Controls.Add(this.diemthanhphan, 4, 0);
            this.tableLayout_diem_item.Controls.Add(this.sotinchi, 3, 0);
            this.tableLayout_diem_item.Controls.Add(this.nhom_to, 2, 0);
            this.tableLayout_diem_item.Controls.Add(this.ten_mon_hoc, 1, 0);
            this.tableLayout_diem_item.Controls.Add(this.ma_mon_hoc, 0, 0);
            this.tableLayout_diem_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_diem_item.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_diem_item.Name = "tableLayout_diem_item";
            this.tableLayout_diem_item.RowCount = 1;
            this.tableLayout_diem_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_diem_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayout_diem_item.Size = new System.Drawing.Size(1080, 53);
            this.tableLayout_diem_item.TabIndex = 2;
            // 
            // diemtongket
            // 
            this.diemtongket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.diemtongket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diemtongket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemtongket.Location = new System.Drawing.Point(978, 1);
            this.diemtongket.Margin = new System.Windows.Forms.Padding(1);
            this.diemtongket.Name = "diemtongket";
            this.diemtongket.Size = new System.Drawing.Size(101, 51);
            this.diemtongket.TabIndex = 6;
            this.diemtongket.Text = "Điểm Tổng Kết";
            this.diemtongket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diemthi
            // 
            this.diemthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.diemthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diemthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemthi.Location = new System.Drawing.Point(880, 1);
            this.diemthi.Margin = new System.Windows.Forms.Padding(1);
            this.diemthi.Name = "diemthi";
            this.diemthi.Size = new System.Drawing.Size(96, 51);
            this.diemthi.TabIndex = 5;
            this.diemthi.Text = "Điểm Thi";
            this.diemthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sotinchi
            // 
            this.sotinchi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.sotinchi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sotinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotinchi.Location = new System.Drawing.Point(528, 1);
            this.sotinchi.Margin = new System.Windows.Forms.Padding(1);
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.Size = new System.Drawing.Size(78, 51);
            this.sotinchi.TabIndex = 3;
            this.sotinchi.Text = "Số TC";
            this.sotinchi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nhom_to
            // 
            this.nhom_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.nhom_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhom_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhom_to.Location = new System.Drawing.Point(412, 1);
            this.nhom_to.Margin = new System.Windows.Forms.Padding(1);
            this.nhom_to.Name = "nhom_to";
            this.nhom_to.Size = new System.Drawing.Size(114, 51);
            this.nhom_to.TabIndex = 2;
            this.nhom_to.Text = "Nhóm Tổ";
            this.nhom_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ten_mon_hoc
            // 
            this.ten_mon_hoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ten_mon_hoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ten_mon_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_mon_hoc.Location = new System.Drawing.Point(121, 1);
            this.ten_mon_hoc.Margin = new System.Windows.Forms.Padding(1);
            this.ten_mon_hoc.Name = "ten_mon_hoc";
            this.ten_mon_hoc.Size = new System.Drawing.Size(289, 51);
            this.ten_mon_hoc.TabIndex = 1;
            this.ten_mon_hoc.Text = "Tên MH";
            this.ten_mon_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ma_mon_hoc
            // 
            this.ma_mon_hoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ma_mon_hoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ma_mon_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma_mon_hoc.Location = new System.Drawing.Point(1, 1);
            this.ma_mon_hoc.Margin = new System.Windows.Forms.Padding(1);
            this.ma_mon_hoc.Name = "ma_mon_hoc";
            this.ma_mon_hoc.Size = new System.Drawing.Size(118, 51);
            this.ma_mon_hoc.TabIndex = 0;
            this.ma_mon_hoc.Text = "Mã MH";
            this.ma_mon_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diemthanhphan
            // 
            this.diemthanhphan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.diemthanhphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diemthanhphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemthanhphan.Location = new System.Drawing.Point(608, 1);
            this.diemthanhphan.Margin = new System.Windows.Forms.Padding(1);
            this.diemthanhphan.Name = "diemthanhphan";
            this.diemthanhphan.Size = new System.Drawing.Size(270, 51);
            this.diemthanhphan.TabIndex = 4;
            this.diemthanhphan.Text = "Điểm Thành Phần";
            this.diemthanhphan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiemItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_diem_item);
            this.Name = "DiemItem";
            this.Size = new System.Drawing.Size(1080, 53);
            this.tableLayout_diem_item.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_diem_item;
        public System.Windows.Forms.Label diemtongket;
        public System.Windows.Forms.Label diemthi;
        public System.Windows.Forms.Label diemthanhphan;
        public System.Windows.Forms.Label sotinchi;
        public System.Windows.Forms.Label nhom_to;
        public System.Windows.Forms.Label ten_mon_hoc;
        public System.Windows.Forms.Label ma_mon_hoc;
    }
}
