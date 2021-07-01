namespace FlightManagement
{
    partial class TraCuuCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuCB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbThoiGian_TCCB = new System.Windows.Forms.CheckBox();
            this.cbDiemDen_TCCB = new System.Windows.Forms.CheckBox();
            this.cbDiemDi_TCCB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDiemDi_TCCB = new System.Windows.Forms.ComboBox();
            this.btnTimKiem_TCCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbbDiemDen_TCCB = new System.Windows.Forms.ComboBox();
            this.dtpThoiGian_TCCB = new System.Windows.Forms.DateTimePicker();
            this.lblTieuDe_TCCB = new System.Windows.Forms.Label();
            this.btnThoat_TCCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTatCaCB_TCCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_BanVe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose_tracuuCB = new System.Windows.Forms.Button();
            this.lvCTCB_TCCB = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_TraCuu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLGheDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaChuyenBay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXuatFileExecel_TCCB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbThoiGian_TCCB);
            this.groupBox1.Controls.Add(this.cbDiemDen_TCCB);
            this.groupBox1.Controls.Add(this.cbDiemDi_TCCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbDiemDi_TCCB);
            this.groupBox1.Controls.Add(this.btnTimKiem_TCCB);
            this.groupBox1.Controls.Add(this.cbbDiemDen_TCCB);
            this.groupBox1.Controls.Add(this.dtpThoiGian_TCCB);
            this.groupBox1.Location = new System.Drawing.Point(113, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(594, 300);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Bạn muốn tìm kiếm theo tiêu chuẩn nào hãy check vào ô đó";
            // 
            // cbThoiGian_TCCB
            // 
            this.cbThoiGian_TCCB.AutoSize = true;
            this.cbThoiGian_TCCB.Location = new System.Drawing.Point(39, 175);
            this.cbThoiGian_TCCB.Name = "cbThoiGian_TCCB";
            this.cbThoiGian_TCCB.Size = new System.Drawing.Size(18, 17);
            this.cbThoiGian_TCCB.TabIndex = 56;
            this.cbThoiGian_TCCB.UseVisualStyleBackColor = true;
            this.cbThoiGian_TCCB.CheckStateChanged += new System.EventHandler(this.cb_ThoiGian_CheckStateChanged);
            // 
            // cbDiemDen_TCCB
            // 
            this.cbDiemDen_TCCB.AutoSize = true;
            this.cbDiemDen_TCCB.Location = new System.Drawing.Point(39, 125);
            this.cbDiemDen_TCCB.Name = "cbDiemDen_TCCB";
            this.cbDiemDen_TCCB.Size = new System.Drawing.Size(18, 17);
            this.cbDiemDen_TCCB.TabIndex = 55;
            this.cbDiemDen_TCCB.UseVisualStyleBackColor = true;
            this.cbDiemDen_TCCB.CheckStateChanged += new System.EventHandler(this.cb_DiemDen_CheckStateChanged);
            // 
            // cbDiemDi_TCCB
            // 
            this.cbDiemDi_TCCB.AutoSize = true;
            this.cbDiemDi_TCCB.Location = new System.Drawing.Point(39, 75);
            this.cbDiemDi_TCCB.Name = "cbDiemDi_TCCB";
            this.cbDiemDi_TCCB.Size = new System.Drawing.Size(18, 17);
            this.cbDiemDi_TCCB.TabIndex = 54;
            this.cbDiemDi_TCCB.UseVisualStyleBackColor = true;
            this.cbDiemDi_TCCB.CheckStateChanged += new System.EventHandler(this.cb_DiemDi_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Thời gian đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Điểm đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Điểm đi:";
            // 
            // cbbDiemDi_TCCB
            // 
            this.cbbDiemDi_TCCB.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "hoa"});
            this.cbbDiemDi_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDi_TCCB.FormattingEnabled = true;
            this.cbbDiemDi_TCCB.Location = new System.Drawing.Point(211, 72);
            this.cbbDiemDi_TCCB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemDi_TCCB.Name = "cbbDiemDi_TCCB";
            this.cbbDiemDi_TCCB.Size = new System.Drawing.Size(345, 28);
            this.cbbDiemDi_TCCB.TabIndex = 44;
            // 
            // btnTimKiem_TCCB
            // 
            this.btnTimKiem_TCCB.ActiveBorderThickness = 1;
            this.btnTimKiem_TCCB.ActiveCornerRadius = 20;
            this.btnTimKiem_TCCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TCCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem_TCCB.ActiveLineColor = System.Drawing.Color.White;
            this.btnTimKiem_TCCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem_TCCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_TCCB.BackgroundImage")));
            this.btnTimKiem_TCCB.ButtonText = "Tìm Kiếm";
            this.btnTimKiem_TCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_TCCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem_TCCB.IdleBorderThickness = 3;
            this.btnTimKiem_TCCB.IdleCornerRadius = 20;
            this.btnTimKiem_TCCB.IdleFillColor = System.Drawing.Color.White;
            this.btnTimKiem_TCCB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TCCB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TCCB.Location = new System.Drawing.Point(297, 217);
            this.btnTimKiem_TCCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTimKiem_TCCB.Name = "btnTimKiem_TCCB";
            this.btnTimKiem_TCCB.Size = new System.Drawing.Size(259, 52);
            this.btnTimKiem_TCCB.TabIndex = 50;
            this.btnTimKiem_TCCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem_TCCB.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cbbDiemDen_TCCB
            // 
            this.cbbDiemDen_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDen_TCCB.FormattingEnabled = true;
            this.cbbDiemDen_TCCB.Location = new System.Drawing.Point(211, 122);
            this.cbbDiemDen_TCCB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemDen_TCCB.Name = "cbbDiemDen_TCCB";
            this.cbbDiemDen_TCCB.Size = new System.Drawing.Size(345, 28);
            this.cbbDiemDen_TCCB.TabIndex = 47;
            this.cbbDiemDen_TCCB.SelectedIndexChanged += new System.EventHandler(this.cbb_DES_SelectedIndexChanged);
            // 
            // dtpThoiGian_TCCB
            // 
            this.dtpThoiGian_TCCB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian_TCCB.CustomFormat = "";
            this.dtpThoiGian_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian_TCCB.Location = new System.Drawing.Point(211, 170);
            this.dtpThoiGian_TCCB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiGian_TCCB.Name = "dtpThoiGian_TCCB";
            this.dtpThoiGian_TCCB.Size = new System.Drawing.Size(345, 27);
            this.dtpThoiGian_TCCB.TabIndex = 49;
            this.dtpThoiGian_TCCB.Value = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            // 
            // lblTieuDe_TCCB
            // 
            this.lblTieuDe_TCCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe_TCCB.AutoSize = true;
            this.lblTieuDe_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_TCCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_TCCB.Location = new System.Drawing.Point(628, 34);
            this.lblTieuDe_TCCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe_TCCB.Name = "lblTieuDe_TCCB";
            this.lblTieuDe_TCCB.Size = new System.Drawing.Size(345, 32);
            this.lblTieuDe_TCCB.TabIndex = 76;
            this.lblTieuDe_TCCB.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // btnThoat_TCCB
            // 
            this.btnThoat_TCCB.ActiveBorderThickness = 1;
            this.btnThoat_TCCB.ActiveCornerRadius = 20;
            this.btnThoat_TCCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TCCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnThoat_TCCB.ActiveLineColor = System.Drawing.Color.White;
            this.btnThoat_TCCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_TCCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_TCCB.BackgroundImage")));
            this.btnThoat_TCCB.ButtonText = "Thoát";
            this.btnThoat_TCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_TCCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_TCCB.IdleBorderThickness = 3;
            this.btnThoat_TCCB.IdleCornerRadius = 20;
            this.btnThoat_TCCB.IdleFillColor = System.Drawing.Color.White;
            this.btnThoat_TCCB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TCCB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TCCB.Location = new System.Drawing.Point(1364, 408);
            this.btnThoat_TCCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThoat_TCCB.Name = "btnThoat_TCCB";
            this.btnThoat_TCCB.Size = new System.Drawing.Size(212, 58);
            this.btnThoat_TCCB.TabIndex = 73;
            this.btnThoat_TCCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_TCCB.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // btnTatCaCB_TCCB
            // 
            this.btnTatCaCB_TCCB.ActiveBorderThickness = 1;
            this.btnTatCaCB_TCCB.ActiveCornerRadius = 20;
            this.btnTatCaCB_TCCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTatCaCB_TCCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnTatCaCB_TCCB.ActiveLineColor = System.Drawing.Color.White;
            this.btnTatCaCB_TCCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnTatCaCB_TCCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTatCaCB_TCCB.BackgroundImage")));
            this.btnTatCaCB_TCCB.ButtonText = "Tất Cả Chuyến Bay";
            this.btnTatCaCB_TCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCaCB_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaCB_TCCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTatCaCB_TCCB.IdleBorderThickness = 3;
            this.btnTatCaCB_TCCB.IdleCornerRadius = 20;
            this.btnTatCaCB_TCCB.IdleFillColor = System.Drawing.Color.White;
            this.btnTatCaCB_TCCB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnTatCaCB_TCCB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTatCaCB_TCCB.Location = new System.Drawing.Point(113, 408);
            this.btnTatCaCB_TCCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTatCaCB_TCCB.Name = "btnTatCaCB_TCCB";
            this.btnTatCaCB_TCCB.Size = new System.Drawing.Size(259, 58);
            this.btnTatCaCB_TCCB.TabIndex = 71;
            this.btnTatCaCB_TCCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTatCaCB_TCCB.Click += new System.EventHandler(this.btn_GET_ALL_FLIGHT_Click);
            // 
            // btnClose_BanVe
            // 
            this.btnClose_BanVe.FlatAppearance.BorderSize = 0;
            this.btnClose_BanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_BanVe.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_BanVe.Location = new System.Drawing.Point(-107, -42);
            this.btnClose_BanVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose_BanVe.Name = "btnClose_BanVe";
            this.btnClose_BanVe.Size = new System.Drawing.Size(49, 46);
            this.btnClose_BanVe.TabIndex = 74;
            this.btnClose_BanVe.UseVisualStyleBackColor = true;
            this.btnClose_BanVe.Click += new System.EventHandler(this.btnClose_BanVe_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(570, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 43);
            this.button1.TabIndex = 57;
            this.button1.Text = "Danh sách chuyến bay thõa  mãn điều kiện";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClose_tracuuCB
            // 
            this.btnClose_tracuuCB.FlatAppearance.BorderSize = 0;
            this.btnClose_tracuuCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_tracuuCB.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_tracuuCB.Location = new System.Drawing.Point(3, 0);
            this.btnClose_tracuuCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose_tracuuCB.Name = "btnClose_tracuuCB";
            this.btnClose_tracuuCB.Size = new System.Drawing.Size(41, 39);
            this.btnClose_tracuuCB.TabIndex = 99;
            this.btnClose_tracuuCB.UseVisualStyleBackColor = true;
            this.btnClose_tracuuCB.Click += new System.EventHandler(this.btnClose_tracuuCB_Click);
            // 
            // lvCTCB_TCCB
            // 
            this.lvCTCB_TCCB.AllowDrop = true;
            this.lvCTCB_TCCB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvCTCB_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCTCB_TCCB.FullRowSelect = true;
            this.lvCTCB_TCCB.HideSelection = false;
            this.lvCTCB_TCCB.Location = new System.Drawing.Point(776, 150);
            this.lvCTCB_TCCB.Margin = new System.Windows.Forms.Padding(4);
            this.lvCTCB_TCCB.MaximumSize = new System.Drawing.Size(800, 318);
            this.lvCTCB_TCCB.Name = "lvCTCB_TCCB";
            this.lvCTCB_TCCB.Size = new System.Drawing.Size(800, 246);
            this.lvCTCB_TCCB.TabIndex = 100;
            this.lvCTCB_TCCB.UseCompatibleStateImageBehavior = false;
            this.lvCTCB_TCCB.View = System.Windows.Forms.View.Details;
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
            // dgv_TraCuu
            // 
            this.dgv_TraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TraCuu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_TraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MACB,
            this.SanBayDi,
            this.SanBayDen,
            this.ThoiGian,
            this.ThoiGianBay,
            this.DonGia,
            this.SLGheDat,
            this.SLGheTrong,
            this.XoaChuyenBay});
            this.dgv_TraCuu.EnableHeadersVisualStyles = false;
            this.dgv_TraCuu.Location = new System.Drawing.Point(113, 475);
            this.dgv_TraCuu.Name = "dgv_TraCuu";
            this.dgv_TraCuu.RowHeadersVisible = false;
            this.dgv_TraCuu.RowHeadersWidth = 51;
            this.dgv_TraCuu.RowTemplate.Height = 24;
            this.dgv_TraCuu.Size = new System.Drawing.Size(1463, 361);
            this.dgv_TraCuu.TabIndex = 102;
            this.dgv_TraCuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TraCuu_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MACB
            // 
            this.MACB.DataPropertyName = "MACB";
            this.MACB.HeaderText = "Mã Chuyến Bay";
            this.MACB.MinimumWidth = 6;
            this.MACB.Name = "MACB";
            this.MACB.ReadOnly = true;
            // 
            // SanBayDi
            // 
            this.SanBayDi.DataPropertyName = "SanBayDi";
            this.SanBayDi.HeaderText = "Sân Bay Đi";
            this.SanBayDi.MinimumWidth = 6;
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.ReadOnly = true;
            // 
            // SanBayDen
            // 
            this.SanBayDen.DataPropertyName = "SanBayDen";
            this.SanBayDen.HeaderText = "Sân Bay Đến";
            this.SanBayDen.MinimumWidth = 6;
            this.SanBayDen.Name = "SanBayDen";
            this.SanBayDen.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.FillWeight = 150F;
            this.ThoiGian.HeaderText = "Ngày Giờ";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.DataPropertyName = "ThoiGianBay";
            this.ThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ThoiGianBay.MinimumWidth = 6;
            this.ThoiGianBay.Name = "ThoiGianBay";
            this.ThoiGianBay.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "GiaTien";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SLGheDat
            // 
            this.SLGheDat.DataPropertyName = "SLGheDat";
            this.SLGheDat.FillWeight = 70F;
            this.SLGheDat.HeaderText = "Số Lượng Ghế Đặt";
            this.SLGheDat.MinimumWidth = 6;
            this.SLGheDat.Name = "SLGheDat";
            this.SLGheDat.ReadOnly = true;
            // 
            // SLGheTrong
            // 
            this.SLGheTrong.DataPropertyName = "SLGheTrong";
            this.SLGheTrong.FillWeight = 70F;
            this.SLGheTrong.HeaderText = "Số Lượng Ghế Trống";
            this.SLGheTrong.MinimumWidth = 6;
            this.SLGheTrong.Name = "SLGheTrong";
            this.SLGheTrong.ReadOnly = true;
            // 
            // XoaChuyenBay
            // 
            this.XoaChuyenBay.DataPropertyName = "ThaoTac";
            this.XoaChuyenBay.FillWeight = 50F;
            this.XoaChuyenBay.HeaderText = "Xoá Chuyến Bay";
            this.XoaChuyenBay.MinimumWidth = 6;
            this.XoaChuyenBay.Name = "XoaChuyenBay";
            this.XoaChuyenBay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XoaChuyenBay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(904, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(457, 43);
            this.button2.TabIndex = 103;
            this.button2.Text = "Danh sách sân bay trung gian";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnXuatFileExecel_TCCB
            // 
            this.btnXuatFileExecel_TCCB.ActiveBorderThickness = 1;
            this.btnXuatFileExecel_TCCB.ActiveCornerRadius = 20;
            this.btnXuatFileExecel_TCCB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatFileExecel_TCCB.ActiveForecolor = System.Drawing.Color.White;
            this.btnXuatFileExecel_TCCB.ActiveLineColor = System.Drawing.Color.White;
            this.btnXuatFileExecel_TCCB.BackColor = System.Drawing.SystemColors.Control;
            this.btnXuatFileExecel_TCCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatFileExecel_TCCB.BackgroundImage")));
            this.btnXuatFileExecel_TCCB.ButtonText = "Xuất file excel";
            this.btnXuatFileExecel_TCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFileExecel_TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileExecel_TCCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXuatFileExecel_TCCB.IdleBorderThickness = 3;
            this.btnXuatFileExecel_TCCB.IdleCornerRadius = 20;
            this.btnXuatFileExecel_TCCB.IdleFillColor = System.Drawing.Color.White;
            this.btnXuatFileExecel_TCCB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatFileExecel_TCCB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatFileExecel_TCCB.Location = new System.Drawing.Point(1117, 408);
            this.btnXuatFileExecel_TCCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnXuatFileExecel_TCCB.Name = "btnXuatFileExecel_TCCB";
            this.btnXuatFileExecel_TCCB.Size = new System.Drawing.Size(212, 58);
            this.btnXuatFileExecel_TCCB.TabIndex = 104;
            this.btnXuatFileExecel_TCCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatFileExecel_TCCB.Click += new System.EventHandler(this.btnXuatFileExecel_TCCB_Click);
            // 
            // TraCuuCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 942);
            this.Controls.Add(this.btnXuatFileExecel_TCCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_TraCuu);
            this.Controls.Add(this.lvCTCB_TCCB);
            this.Controls.Add(this.btnClose_tracuuCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat_TCCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe_TCCB);
            this.Controls.Add(this.btnTatCaCB_TCCB);
            this.Controls.Add(this.btnClose_BanVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraCuuCB";
            this.Text = "TraCuuCB";
            this.Load += new System.EventHandler(this.TraCuuCB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TraCuuCB_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDiemDi_TCCB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem_TCCB;
        private System.Windows.Forms.ComboBox cbbDiemDen_TCCB;
        private System.Windows.Forms.DateTimePicker dtpThoiGian_TCCB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_TCCB;
        private System.Windows.Forms.Label lblTieuDe_TCCB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTatCaCB_TCCB;
        private System.Windows.Forms.Button btnClose_BanVe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose_tracuuCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.CheckBox cbThoiGian_TCCB;
        private System.Windows.Forms.CheckBox cbDiemDen_TCCB;
        private System.Windows.Forms.CheckBox cbDiemDi_TCCB;
        private System.Windows.Forms.ListView lvCTCB_TCCB;
        private System.Windows.Forms.DataGridView dgv_TraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLGheDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLGheTrong;
        private System.Windows.Forms.DataGridViewButtonColumn XoaChuyenBay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXuatFileExecel_TCCB;
    }
}