namespace FlightManagement
{
    partial class TimKiemVe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemVe));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMCB_TKVCB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND_TKVCB = new System.Windows.Forms.TextBox();
            this.lvVe_TKVCB = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem_TKVCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTieuDe_TKVCB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat_TKVCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorCB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose_TimVe = new System.Windows.Forms.Button();
            this.btnXemTatCaVe_TCVCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyến bay:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMCB_TKVCB
            // 
            this.txtMCB_TKVCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCB_TKVCB.Location = new System.Drawing.Point(197, 52);
            this.txtMCB_TKVCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCB_TKVCB.Name = "txtMCB_TKVCB";
            this.txtMCB_TKVCB.Size = new System.Drawing.Size(300, 28);
            this.txtMCB_TKVCB.TabIndex = 1;
            this.txtMCB_TKVCB.TextChanged += new System.EventHandler(this.txb_chuyenbay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND:";
            // 
            // txtCMND_TKVCB
            // 
            this.txtCMND_TKVCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND_TKVCB.Location = new System.Drawing.Point(197, 132);
            this.txtCMND_TKVCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND_TKVCB.Name = "txtCMND_TKVCB";
            this.txtCMND_TKVCB.Size = new System.Drawing.Size(300, 28);
            this.txtCMND_TKVCB.TabIndex = 4;
            this.txtCMND_TKVCB.TextChanged += new System.EventHandler(this.txb_cmnd_TextChanged);
            // 
            // lvVe_TKVCB
            // 
            this.lvVe_TKVCB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvVe_TKVCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVe_TKVCB.GridLines = true;
            this.lvVe_TKVCB.HideSelection = false;
            this.lvVe_TKVCB.Location = new System.Drawing.Point(164, 456);
            this.lvVe_TKVCB.Margin = new System.Windows.Forms.Padding(4);
            this.lvVe_TKVCB.Name = "lvVe_TKVCB";
            this.lvVe_TKVCB.Size = new System.Drawing.Size(1132, 345);
            this.lvVe_TKVCB.TabIndex = 12;
            this.lvVe_TKVCB.UseCompatibleStateImageBehavior = false;
            this.lvVe_TKVCB.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chuyến Bay";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hành khách";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CMND";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điện thoại";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hạng vé";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá tiền";
            this.columnHeader6.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(586, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.button1.Size = new System.Drawing.Size(313, 50);
            this.button1.TabIndex = 88;
            this.button1.Text = "Danh sách vé\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMCB_TKVCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTimKiem_TKVCB);
            this.groupBox1.Controls.Add(this.txtCMND_TKVCB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(164, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(607, 229);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(194, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 41);
            this.label9.TabIndex = 89;
            this.label9.Text = "Mã chuyến bay có 5 kí tự, 2 chữ cái đầu là \"CB\" cộng với 3 chữ số ví dụ \"CB011\"";
            // 
            // btnTimKiem_TKVCB
            // 
            this.btnTimKiem_TKVCB.ActiveBorderThickness = 1;
            this.btnTimKiem_TKVCB.ActiveCornerRadius = 20;
            this.btnTimKiem_TKVCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TKVCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem_TKVCB.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TKVCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem_TKVCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_TKVCB.BackgroundImage")));
            this.btnTimKiem_TKVCB.ButtonText = "Tìm Kiếm";
            this.btnTimKiem_TKVCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_TKVCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_TKVCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem_TKVCB.IdleBorderThickness = 3;
            this.btnTimKiem_TKVCB.IdleCornerRadius = 20;
            this.btnTimKiem_TKVCB.IdleFillColor = System.Drawing.Color.White;
            this.btnTimKiem_TKVCB.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem_TKVCB.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem_TKVCB.Location = new System.Drawing.Point(310, 170);
            this.btnTimKiem_TKVCB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTimKiem_TKVCB.Name = "btnTimKiem_TKVCB";
            this.btnTimKiem_TKVCB.Size = new System.Drawing.Size(187, 49);
            this.btnTimKiem_TKVCB.TabIndex = 87;
            this.btnTimKiem_TKVCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem_TKVCB.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lblTieuDe_TKVCB
            // 
            this.lblTieuDe_TKVCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe_TKVCB.AutoSize = true;
            this.lblTieuDe_TKVCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_TKVCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_TKVCB.Location = new System.Drawing.Point(580, 58);
            this.lblTieuDe_TKVCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe_TKVCB.Name = "lblTieuDe_TKVCB";
            this.lblTieuDe_TKVCB.Size = new System.Drawing.Size(393, 32);
            this.lblTieuDe_TKVCB.TabIndex = 104;
            this.lblTieuDe_TKVCB.Text = "TÌM KIẾM VÉ CHUYẾN BAY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.cherry_happy_to_flight1;
            this.pictureBox1.Location = new System.Drawing.Point(955, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat_TKVCB
            // 
            this.btnThoat_TKVCB.ActiveBorderThickness = 1;
            this.btnThoat_TKVCB.ActiveCornerRadius = 20;
            this.btnThoat_TKVCB.ActiveFillColor = System.Drawing.Color.White;
            this.btnThoat_TKVCB.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKVCB.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKVCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_TKVCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_TKVCB.BackgroundImage")));
            this.btnThoat_TKVCB.ButtonText = "Thoát";
            this.btnThoat_TKVCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_TKVCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_TKVCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_TKVCB.IdleBorderThickness = 3;
            this.btnThoat_TKVCB.IdleCornerRadius = 20;
            this.btnThoat_TKVCB.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKVCB.IdleForecolor = System.Drawing.Color.White;
            this.btnThoat_TKVCB.IdleLineColor = System.Drawing.Color.White;
            this.btnThoat_TKVCB.Location = new System.Drawing.Point(1061, 811);
            this.btnThoat_TKVCB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat_TKVCB.Name = "btnThoat_TKVCB";
            this.btnThoat_TKVCB.Size = new System.Drawing.Size(235, 66);
            this.btnThoat_TKVCB.TabIndex = 89;
            this.btnThoat_TKVCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_TKVCB.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorCB
            // 
            this.errorCB.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // btnClose_TimVe
            // 
            this.btnClose_TimVe.FlatAppearance.BorderSize = 0;
            this.btnClose_TimVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_TimVe.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_TimVe.Location = new System.Drawing.Point(0, 2);
            this.btnClose_TimVe.Name = "btnClose_TimVe";
            this.btnClose_TimVe.Size = new System.Drawing.Size(37, 37);
            this.btnClose_TimVe.TabIndex = 90;
            this.btnClose_TimVe.UseVisualStyleBackColor = true;
            this.btnClose_TimVe.Click += new System.EventHandler(this.btnClose_TimVe_Click);
            // 
            // btnXemTatCaVe_TCVCB
            // 
            this.btnXemTatCaVe_TCVCB.ActiveBorderThickness = 1;
            this.btnXemTatCaVe_TCVCB.ActiveCornerRadius = 20;
            this.btnXemTatCaVe_TCVCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXemTatCaVe_TCVCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemTatCaVe_TCVCB.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXemTatCaVe_TCVCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnXemTatCaVe_TCVCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemTatCaVe_TCVCB.BackgroundImage")));
            this.btnXemTatCaVe_TCVCB.ButtonText = "Xem tất cả vé";
            this.btnXemTatCaVe_TCVCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemTatCaVe_TCVCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCaVe_TCVCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXemTatCaVe_TCVCB.IdleBorderThickness = 3;
            this.btnXemTatCaVe_TCVCB.IdleCornerRadius = 20;
            this.btnXemTatCaVe_TCVCB.IdleFillColor = System.Drawing.Color.White;
            this.btnXemTatCaVe_TCVCB.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnXemTatCaVe_TCVCB.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXemTatCaVe_TCVCB.Location = new System.Drawing.Point(164, 400);
            this.btnXemTatCaVe_TCVCB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXemTatCaVe_TCVCB.Name = "btnXemTatCaVe_TCVCB";
            this.btnXemTatCaVe_TCVCB.Size = new System.Drawing.Size(205, 49);
            this.btnXemTatCaVe_TCVCB.TabIndex = 90;
            this.btnXemTatCaVe_TCVCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemTatCaVe_TCVCB.Click += new System.EventHandler(this.btnXemTatCaVe_TCVCB_Click);
            // 
            // TimKiemVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 966);
            this.Controls.Add(this.btnXemTatCaVe_TCVCB);
            this.Controls.Add(this.btnClose_TimVe);
            this.Controls.Add(this.lblTieuDe_TKVCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat_TKVCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvVe_TKVCB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiemVe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimKiemVe_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMCB_TKVCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND_TKVCB;
        private System.Windows.Forms.ListView lvVe_TKVCB;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem_TKVCB;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_TKVCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTieuDe_TKVCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorCB;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose_TimVe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemTatCaVe_TCVCB;
    }
}