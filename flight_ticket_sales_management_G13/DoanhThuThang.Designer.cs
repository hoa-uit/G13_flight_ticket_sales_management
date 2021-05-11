namespace flight_ticket_sales_management_G13
{
    partial class DoanhThuThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThang_DTThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam_DTThang = new System.Windows.Forms.TextBox();
            this.btnBaoCao_DTThang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvDTThang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THÁNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng: ";
            // 
            // cbThang_DTThang
            // 
            this.cbThang_DTThang.FormattingEnabled = true;
            this.cbThang_DTThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang_DTThang.Location = new System.Drawing.Point(209, 96);
            this.cbThang_DTThang.Name = "cbThang_DTThang";
            this.cbThang_DTThang.Size = new System.Drawing.Size(121, 24);
            this.cbThang_DTThang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm:";
            // 
            // txtNam_DTThang
            // 
            this.txtNam_DTThang.Location = new System.Drawing.Point(450, 99);
            this.txtNam_DTThang.Name = "txtNam_DTThang";
            this.txtNam_DTThang.Size = new System.Drawing.Size(100, 22);
            this.txtNam_DTThang.TabIndex = 4;
            // 
            // btnBaoCao_DTThang
            // 
            this.btnBaoCao_DTThang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao_DTThang.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao_DTThang.Location = new System.Drawing.Point(211, 158);
            this.btnBaoCao_DTThang.Name = "btnBaoCao_DTThang";
            this.btnBaoCao_DTThang.Size = new System.Drawing.Size(132, 36);
            this.btnBaoCao_DTThang.TabIndex = 5;
            this.btnBaoCao_DTThang.Text = "Báo Cáo";
            this.btnBaoCao_DTThang.UseVisualStyleBackColor = false;
            this.btnBaoCao_DTThang.Click += new System.EventHandler(this.btnBaoCao_DTThang_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvDTThang
            // 
            this.lvDTThang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDTThang.HideSelection = false;
            this.lvDTThang.Location = new System.Drawing.Point(12, 220);
            this.lvDTThang.Name = "lvDTThang";
            this.lvDTThang.Scrollable = false;
            this.lvDTThang.Size = new System.Drawing.Size(718, 218);
            this.lvDTThang.TabIndex = 7;
            this.lvDTThang.UseCompatibleStateImageBehavior = false;
            this.lvDTThang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stt";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chuyến bay";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số vé";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tỷ lệ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doanh thu";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 182;
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDTThang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBaoCao_DTThang);
            this.Controls.Add(this.txtNam_DTThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbThang_DTThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuThang";
            this.Text = "DoanhThuThang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang_DTThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam_DTThang;
        private System.Windows.Forms.Button btnBaoCao_DTThang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvDTThang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}