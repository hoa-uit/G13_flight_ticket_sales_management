namespace flight_ticket_sales_management_G13
{
    partial class Doanhthuthang
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
            this.txtNam_dtThang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_baocaothang = new System.Windows.Forms.Button();
            this.btn_thoatbaocaothang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNam_dtThang
            // 
            this.txtNam_dtThang.Location = new System.Drawing.Point(445, 123);
            this.txtNam_dtThang.Name = "txtNam_dtThang";
            this.txtNam_dtThang.Size = new System.Drawing.Size(117, 22);
            this.txtNam_dtThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm:";
            // 
            // cb_Thang
            // 
            this.cb_Thang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Thang.FormattingEnabled = true;
            this.cb_Thang.Items.AddRange(new object[] {
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
            this.cb_Thang.Location = new System.Drawing.Point(187, 119);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(121, 24);
            this.cb_Thang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "BÁO CÁO DOANH THU THÁNG";
            // 
            // btn_baocaothang
            // 
            this.btn_baocaothang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_baocaothang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocaothang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_baocaothang.Location = new System.Drawing.Point(187, 215);
            this.btn_baocaothang.Name = "btn_baocaothang";
            this.btn_baocaothang.Size = new System.Drawing.Size(150, 39);
            this.btn_baocaothang.TabIndex = 5;
            this.btn_baocaothang.Text = "Báo cáo";
            this.btn_baocaothang.UseVisualStyleBackColor = false;
            // 
            // btn_thoatbaocaothang
            // 
            this.btn_thoatbaocaothang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_thoatbaocaothang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoatbaocaothang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoatbaocaothang.Location = new System.Drawing.Point(394, 215);
            this.btn_thoatbaocaothang.Name = "btn_thoatbaocaothang";
            this.btn_thoatbaocaothang.Size = new System.Drawing.Size(158, 39);
            this.btn_thoatbaocaothang.TabIndex = 6;
            this.btn_thoatbaocaothang.Text = "Thoát";
            this.btn_thoatbaocaothang.UseVisualStyleBackColor = false;
            this.btn_thoatbaocaothang.Click += new System.EventHandler(this.btn_thoatbaocaothang_Click);
            // 
            // Doanhthuthang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 344);
            this.Controls.Add(this.btn_thoatbaocaothang);
            this.Controls.Add(this.btn_baocaothang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Thang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNam_dtThang);
            this.Name = "Doanhthuthang";
            this.Text = "Doanh Thu Tháng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNam_dtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_baocaothang;
        private System.Windows.Forms.Button btn_thoatbaocaothang;
    }
}