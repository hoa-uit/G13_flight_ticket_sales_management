namespace FlightManagement
{
    partial class DATCHO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DATCHO));
            this.dtgvChuyenBay_DatCho = new System.Windows.Forms.DataGridView();
            this.MACB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGheDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpThoiGian_DatCho = new System.Windows.Forms.DateTimePicker();
            this.lblTieuDe_DatCho = new System.Windows.Forms.Label();
            this.cbbDiemDi_DatCho = new System.Windows.Forms.ComboBox();
            this.cbbDiemDen_DatCho = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem_DatCho = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat_DatCho = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_BanVe = new System.Windows.Forms.Button();
            this.lvCTCB_DatCho = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay_DatCho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChuyenBay_DatCho
            // 
            this.dtgvChuyenBay_DatCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChuyenBay_DatCho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvChuyenBay_DatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay_DatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACB,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ThoiGianBay,
            this.SoLuongGheDat,
            this.SoLuongGheTrong,
            this.Column5});
            this.dtgvChuyenBay_DatCho.EnableHeadersVisualStyles = false;
            this.dtgvChuyenBay_DatCho.Location = new System.Drawing.Point(75, 508);
            this.dtgvChuyenBay_DatCho.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChuyenBay_DatCho.Name = "dtgvChuyenBay_DatCho";
            this.dtgvChuyenBay_DatCho.RowHeadersWidth = 51;
            this.dtgvChuyenBay_DatCho.RowTemplate.Height = 24;
            this.dtgvChuyenBay_DatCho.Size = new System.Drawing.Size(1462, 280);
            this.dtgvChuyenBay_DatCho.TabIndex = 70;
            this.dtgvChuyenBay_DatCho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BanVe_CellContentClick);
            // 
            // MACB
            // 
            this.MACB.DataPropertyName = "MACB";
            this.MACB.HeaderText = "Mã Chuyến Bay";
            this.MACB.MinimumWidth = 6;
            this.MACB.Name = "MACB";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SanBayDi";
            this.Column2.HeaderText = "Sân Bay Đi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SanBayDen";
            this.Column3.HeaderText = "Sân Bay Đến";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThoiGian";
            this.Column4.HeaderText = "Thời Gian Đi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.DataPropertyName = "ThoiGianBay";
            this.ThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ThoiGianBay.MinimumWidth = 6;
            this.ThoiGianBay.Name = "ThoiGianBay";
            // 
            // SoLuongGheDat
            // 
            this.SoLuongGheDat.DataPropertyName = "SLGheDat";
            this.SoLuongGheDat.HeaderText = "Số Lượng Ghế Đã Đặt";
            this.SoLuongGheDat.MinimumWidth = 6;
            this.SoLuongGheDat.Name = "SoLuongGheDat";
            // 
            // SoLuongGheTrong
            // 
            this.SoLuongGheTrong.DataPropertyName = "SLGheTrong";
            this.SoLuongGheTrong.HeaderText = "Số Lượng Ghế Trống";
            this.SoLuongGheTrong.MinimumWidth = 6;
            this.SoLuongGheTrong.Name = "SoLuongGheTrong";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DatVe";
            this.Column5.HeaderText = "Đặt Chỗ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtpThoiGian_DatCho
            // 
            this.dtpThoiGian_DatCho.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian_DatCho.Location = new System.Drawing.Point(207, 169);
            this.dtpThoiGian_DatCho.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiGian_DatCho.Name = "dtpThoiGian_DatCho";
            this.dtpThoiGian_DatCho.Size = new System.Drawing.Size(371, 27);
            this.dtpThoiGian_DatCho.TabIndex = 49;
            this.dtpThoiGian_DatCho.Value = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            // 
            // lblTieuDe_DatCho
            // 
            this.lblTieuDe_DatCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe_DatCho.AutoSize = true;
            this.lblTieuDe_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_DatCho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_DatCho.Location = new System.Drawing.Point(576, 41);
            this.lblTieuDe_DatCho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe_DatCho.Name = "lblTieuDe_DatCho";
            this.lblTieuDe_DatCho.Size = new System.Drawing.Size(408, 38);
            this.lblTieuDe_DatCho.TabIndex = 68;
            this.lblTieuDe_DatCho.Text = "ĐẶT CHỖ CHUYẾN BAY";
            // 
            // cbbDiemDi_DatCho
            // 
            this.cbbDiemDi_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDi_DatCho.FormattingEnabled = true;
            this.cbbDiemDi_DatCho.Location = new System.Drawing.Point(207, 39);
            this.cbbDiemDi_DatCho.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemDi_DatCho.Name = "cbbDiemDi_DatCho";
            this.cbbDiemDi_DatCho.Size = new System.Drawing.Size(371, 28);
            this.cbbDiemDi_DatCho.TabIndex = 44;
            // 
            // cbbDiemDen_DatCho
            // 
            this.cbbDiemDen_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDen_DatCho.FormattingEnabled = true;
            this.cbbDiemDen_DatCho.Location = new System.Drawing.Point(207, 107);
            this.cbbDiemDen_DatCho.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemDen_DatCho.Name = "cbbDiemDen_DatCho";
            this.cbbDiemDen_DatCho.Size = new System.Drawing.Size(371, 28);
            this.cbbDiemDen_DatCho.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbDiemDi_DatCho);
            this.groupBox1.Controls.Add(this.btnTimKiem_DatCho);
            this.groupBox1.Controls.Add(this.cbbDiemDen_DatCho);
            this.groupBox1.Controls.Add(this.dtpThoiGian_DatCho);
            this.groupBox1.Location = new System.Drawing.Point(71, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(603, 318);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Thời gian đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Điểm đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Điểm đi:";
            // 
            // btnTimKiem_DatCho
            // 
            this.btnTimKiem_DatCho.ActiveBorderThickness = 1;
            this.btnTimKiem_DatCho.ActiveCornerRadius = 20;
            this.btnTimKiem_DatCho.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_DatCho.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem_DatCho.ActiveLineColor = System.Drawing.Color.White;
            this.btnTimKiem_DatCho.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem_DatCho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_DatCho.BackgroundImage")));
            this.btnTimKiem_DatCho.ButtonText = "Tìm Kiếm";
            this.btnTimKiem_DatCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_DatCho.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem_DatCho.IdleBorderThickness = 3;
            this.btnTimKiem_DatCho.IdleCornerRadius = 20;
            this.btnTimKiem_DatCho.IdleFillColor = System.Drawing.Color.White;
            this.btnTimKiem_DatCho.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_DatCho.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_DatCho.Location = new System.Drawing.Point(319, 229);
            this.btnTimKiem_DatCho.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTimKiem_DatCho.Name = "btnTimKiem_DatCho";
            this.btnTimKiem_DatCho.Size = new System.Drawing.Size(259, 58);
            this.btnTimKiem_DatCho.TabIndex = 50;
            this.btnTimKiem_DatCho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem_DatCho.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(541, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 36);
            this.button1.TabIndex = 71;
            this.button1.Text = "Danh sách các chuyến bay thỏa mãn điều kiện";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThoat_DatCho
            // 
            this.btnThoat_DatCho.ActiveBorderThickness = 1;
            this.btnThoat_DatCho.ActiveCornerRadius = 20;
            this.btnThoat_DatCho.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_DatCho.ActiveForecolor = System.Drawing.Color.White;
            this.btnThoat_DatCho.ActiveLineColor = System.Drawing.Color.White;
            this.btnThoat_DatCho.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_DatCho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_DatCho.BackgroundImage")));
            this.btnThoat_DatCho.ButtonText = "Thoát";
            this.btnThoat_DatCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_DatCho.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_DatCho.IdleBorderThickness = 3;
            this.btnThoat_DatCho.IdleCornerRadius = 20;
            this.btnThoat_DatCho.IdleFillColor = System.Drawing.Color.White;
            this.btnThoat_DatCho.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_DatCho.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_DatCho.Location = new System.Drawing.Point(1325, 440);
            this.btnThoat_DatCho.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThoat_DatCho.Name = "btnThoat_DatCho";
            this.btnThoat_DatCho.Size = new System.Drawing.Size(212, 58);
            this.btnThoat_DatCho.TabIndex = 65;
            this.btnThoat_DatCho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_DatCho.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // btnClose_BanVe
            // 
            this.btnClose_BanVe.FlatAppearance.BorderSize = 0;
            this.btnClose_BanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_BanVe.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_BanVe.Location = new System.Drawing.Point(-4, -2);
            this.btnClose_BanVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose_BanVe.Name = "btnClose_BanVe";
            this.btnClose_BanVe.Size = new System.Drawing.Size(49, 46);
            this.btnClose_BanVe.TabIndex = 66;
            this.btnClose_BanVe.UseVisualStyleBackColor = true;
            this.btnClose_BanVe.Click += new System.EventHandler(this.btnClose_BanVe_Click);
            // 
            // lvCTCB_DatCho
            // 
            this.lvCTCB_DatCho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvCTCB_DatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCTCB_DatCho.FullRowSelect = true;
            this.lvCTCB_DatCho.HideSelection = false;
            this.lvCTCB_DatCho.Location = new System.Drawing.Point(681, 160);
            this.lvCTCB_DatCho.Margin = new System.Windows.Forms.Padding(4);
            this.lvCTCB_DatCho.Name = "lvCTCB_DatCho";
            this.lvCTCB_DatCho.Size = new System.Drawing.Size(856, 270);
            this.lvCTCB_DatCho.TabIndex = 102;
            this.lvCTCB_DatCho.UseCompatibleStateImageBehavior = false;
            this.lvCTCB_DatCho.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "STT";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Chuyến Bay";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên Sân Bay ";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Quốc Gia";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Thời Gian Dừng";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ghi Chú";
            this.columnHeader15.Width = 100;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(845, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(539, 36);
            this.button2.TabIndex = 104;
            this.button2.Text = "Danh sách các sân bay trung gian";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DATCHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 841);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvCTCB_DatCho);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat_DatCho);
            this.Controls.Add(this.dtgvChuyenBay_DatCho);
            this.Controls.Add(this.btnClose_BanVe);
            this.Controls.Add(this.lblTieuDe_DatCho);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DATCHO";
            this.Text = "DATCHO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DATCHO_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay_DatCho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvChuyenBay_DatCho;
        private System.Windows.Forms.Button btnClose_BanVe;
        private System.Windows.Forms.DateTimePicker dtpThoiGian_DatCho;
        private System.Windows.Forms.Label lblTieuDe_DatCho;
        private System.Windows.Forms.ComboBox cbbDiemDi_DatCho;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem_DatCho;
        private System.Windows.Forms.ComboBox cbbDiemDen_DatCho;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_DatCho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCTCB_DatCho;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGheDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGheTrong;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}