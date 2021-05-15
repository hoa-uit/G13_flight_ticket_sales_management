namespace flight_ticket_sales_management_G13
{
    partial class DoanhThuNam
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
            this.txtNam_DTNam = new System.Windows.Forms.TextBox();
            this.btnBaoCao_DTNam = new System.Windows.Forms.Button();
            this.btnThoat_DTNam = new System.Windows.Forms.Button();
            this.lvDTNam = new System.Windows.Forms.ListView();
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(233, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU NĂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm: ";
            // 
            // txtNam_DTNam
            // 
            this.txtNam_DTNam.Location = new System.Drawing.Point(382, 117);
            this.txtNam_DTNam.Name = "txtNam_DTNam";
            this.txtNam_DTNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam_DTNam.TabIndex = 2;
            // 
            // btnBaoCao_DTNam
            // 
            this.btnBaoCao_DTNam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao_DTNam.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao_DTNam.Location = new System.Drawing.Point(238, 174);
            this.btnBaoCao_DTNam.Name = "btnBaoCao_DTNam";
            this.btnBaoCao_DTNam.Size = new System.Drawing.Size(147, 35);
            this.btnBaoCao_DTNam.TabIndex = 3;
            this.btnBaoCao_DTNam.Text = "Báo Cáo";
            this.btnBaoCao_DTNam.UseVisualStyleBackColor = false;
            this.btnBaoCao_DTNam.Click += new System.EventHandler(this.btnBaoCao_DTNam_Click);
            // 
            // btnThoat_DTNam
            // 
            this.btnThoat_DTNam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat_DTNam.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_DTNam.Location = new System.Drawing.Point(426, 175);
            this.btnThoat_DTNam.Name = "btnThoat_DTNam";
            this.btnThoat_DTNam.Size = new System.Drawing.Size(155, 34);
            this.btnThoat_DTNam.TabIndex = 4;
            this.btnThoat_DTNam.Text = "Thoát";
            this.btnThoat_DTNam.UseVisualStyleBackColor = false;
            this.btnThoat_DTNam.Click += new System.EventHandler(this.btnThoat_DTNam_Click);
            // 
            // lvDTNam
            // 
            this.lvDTNam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDTNam.HideSelection = false;
            this.lvDTNam.Location = new System.Drawing.Point(38, 240);
            this.lvDTNam.Name = "lvDTNam";
            this.lvDTNam.Size = new System.Drawing.Size(727, 186);
            this.lvDTNam.TabIndex = 5;
            this.lvDTNam.UseCompatibleStateImageBehavior = false;
            this.lvDTNam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tháng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số chuyến bay";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doanh thu";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tỷ lệ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 91;
            // 
            // DoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDTNam);
            this.Controls.Add(this.btnThoat_DTNam);
            this.Controls.Add(this.btnBaoCao_DTNam);
            this.Controls.Add(this.txtNam_DTNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuNam";
            this.Text = "DoanhThuNam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam_DTNam;
        private System.Windows.Forms.Button btnBaoCao_DTNam;
        private System.Windows.Forms.Button btnThoat_DTNam;
        private System.Windows.Forms.ListView lvDTNam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}