

using System.Drawing;

namespace MyBK.Gui.MyUserControl {
    partial class LichHocItem {
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
            this.tableLayout_lich_hoc_item = new System.Windows.Forms.TableLayoutPanel();
            this.tuan_hoc = new System.Windows.Forms.Label();
            this.phong = new System.Windows.Forms.Label();
            this.tiet = new System.Windows.Forms.Label();
            this.thu = new System.Windows.Forms.Label();
            this.nhom_to = new System.Windows.Forms.Label();
            this.ten_mon_hoc = new System.Windows.Forms.Label();
            this.ma_mon_hoc = new System.Windows.Forms.Label();
            this.tableLayout_lich_hoc_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_lich_hoc_item
            // 
            this.tableLayout_lich_hoc_item.ColumnCount = 7;
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.24282F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.75718F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayout_lich_hoc_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 429F));
            this.tableLayout_lich_hoc_item.Controls.Add(this.tuan_hoc, 6, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.phong, 5, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.tiet, 4, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.thu, 3, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.nhom_to, 2, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.ten_mon_hoc, 1, 0);
            this.tableLayout_lich_hoc_item.Controls.Add(this.ma_mon_hoc, 0, 0);
            this.tableLayout_lich_hoc_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_lich_hoc_item.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_lich_hoc_item.Name = "tableLayout_lich_hoc_item";
            this.tableLayout_lich_hoc_item.RowCount = 1;
            this.tableLayout_lich_hoc_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_lich_hoc_item.Size = new System.Drawing.Size(1158, 48);
            this.tableLayout_lich_hoc_item.TabIndex = 0;
            // 
            // tuan_hoc
            // 
            this.tuan_hoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.tuan_hoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuan_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuan_hoc.Location = new System.Drawing.Point(729, 1);
            this.tuan_hoc.Margin = new System.Windows.Forms.Padding(1);
            this.tuan_hoc.Name = "tuan_hoc";
            this.tuan_hoc.Size = new System.Drawing.Size(428, 46);
            this.tuan_hoc.TabIndex = 6;
            this.tuan_hoc.Text = "Tuần Học";
            this.tuan_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phong
            // 
            this.phong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phong.Location = new System.Drawing.Point(625, 1);
            this.phong.Margin = new System.Windows.Forms.Padding(1);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(102, 46);
            this.phong.TabIndex = 5;
            this.phong.Text = "Phòng";
            this.phong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tiet
            // 
            this.tiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.tiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiet.Location = new System.Drawing.Point(549, 1);
            this.tiet.Margin = new System.Windows.Forms.Padding(1);
            this.tiet.Name = "tiet";
            this.tiet.Size = new System.Drawing.Size(74, 46);
            this.tiet.TabIndex = 4;
            this.tiet.Text = "Tiết";
            this.tiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thu
            // 
            this.thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.thu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu.Location = new System.Drawing.Point(494, 1);
            this.thu.Margin = new System.Windows.Forms.Padding(1);
            this.thu.Name = "thu";
            this.thu.Size = new System.Drawing.Size(53, 46);
            this.thu.TabIndex = 3;
            this.thu.Text = "Thứ";
            this.thu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nhom_to
            // 
            this.nhom_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.nhom_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhom_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhom_to.Location = new System.Drawing.Point(391, 1);
            this.nhom_to.Margin = new System.Windows.Forms.Padding(1);
            this.nhom_to.Name = "nhom_to";
            this.nhom_to.Size = new System.Drawing.Size(101, 46);
            this.nhom_to.TabIndex = 2;
            this.nhom_to.Text = "Nhóm Tổ";
            this.nhom_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ten_mon_hoc
            // 
            this.ten_mon_hoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ten_mon_hoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ten_mon_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_mon_hoc.Location = new System.Drawing.Point(115, 1);
            this.ten_mon_hoc.Margin = new System.Windows.Forms.Padding(1);
            this.ten_mon_hoc.Name = "ten_mon_hoc";
            this.ten_mon_hoc.Size = new System.Drawing.Size(274, 46);
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
            this.ma_mon_hoc.Size = new System.Drawing.Size(112, 46);
            this.ma_mon_hoc.TabIndex = 0;
            this.ma_mon_hoc.Text = "Mã MH";
            this.ma_mon_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LichHocItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_lich_hoc_item);
            this.Name = "LichHocItem";
            this.Size = new System.Drawing.Size(1158, 48);
            this.tableLayout_lich_hoc_item.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_lich_hoc_item;
        public System.Windows.Forms.Label thu;
        public System.Windows.Forms.Label nhom_to;
        public System.Windows.Forms.Label ten_mon_hoc;
        public System.Windows.Forms.Label ma_mon_hoc;
        public System.Windows.Forms.Label tuan_hoc;
        public System.Windows.Forms.Label phong;
        public System.Windows.Forms.Label tiet;

        public void setColor(Color col) {
            thu.BackColor = col;
        }
    }
}
