namespace FlightManagement
{
    partial class TimKiemPDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemPDC));
            this.listView1 = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND_TKPDC = new System.Windows.Forms.TextBox();
            this.txtCB_TKPDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem_TKPDC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTieuDe_TKPDC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat_TKPDC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_TimPDC = new System.Windows.Forms.Button();
            this.errorCB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgvPDC_TKPDC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemTatCa_TKPDC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPDC_TKPDC)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(156, 452);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1132, 306);
            this.listView1.TabIndex = 94;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "CMND:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCMND_TKPDC
            // 
            this.txtCMND_TKPDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND_TKPDC.Location = new System.Drawing.Point(206, 144);
            this.txtCMND_TKPDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND_TKPDC.Name = "txtCMND_TKPDC";
            this.txtCMND_TKPDC.Size = new System.Drawing.Size(303, 28);
            this.txtCMND_TKPDC.TabIndex = 92;
            this.txtCMND_TKPDC.TextChanged += new System.EventHandler(this.txb_cmnd_TextChanged);
            // 
            // txtCB_TKPDC
            // 
            this.txtCB_TKPDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCB_TKPDC.Location = new System.Drawing.Point(206, 60);
            this.txtCB_TKPDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCB_TKPDC.Name = "txtCB_TKPDC";
            this.txtCB_TKPDC.Size = new System.Drawing.Size(303, 28);
            this.txtCB_TKPDC.TabIndex = 91;
            this.txtCB_TKPDC.TextChanged += new System.EventHandler(this.txb_chuyenbay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Chuyến bay:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(595, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 44);
            this.button1.TabIndex = 96;
            this.button1.Text = "Danh sách phiếu đặt chỗ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTimKiem_TKPDC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCB_TKPDC);
            this.groupBox1.Controls.Add(this.txtCMND_TKPDC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(209, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(612, 253);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(207, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 41);
            this.label9.TabIndex = 96;
            this.label9.Text = "Mã chuyến bay có 5 kí tự, 2 chữ cái đầu là \"CB\" cộng với 3 chữ số ví dụ \"CB011\"";
            // 
            // btnTimKiem_TKPDC
            // 
            this.btnTimKiem_TKPDC.ActiveBorderThickness = 1;
            this.btnTimKiem_TKPDC.ActiveCornerRadius = 20;
            this.btnTimKiem_TKPDC.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TKPDC.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem_TKPDC.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem_TKPDC.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem_TKPDC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_TKPDC.BackgroundImage")));
            this.btnTimKiem_TKPDC.ButtonText = "Tìm Kiếm";
            this.btnTimKiem_TKPDC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_TKPDC.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_TKPDC.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem_TKPDC.IdleBorderThickness = 3;
            this.btnTimKiem_TKPDC.IdleCornerRadius = 20;
            this.btnTimKiem_TKPDC.IdleFillColor = System.Drawing.Color.White;
            this.btnTimKiem_TKPDC.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem_TKPDC.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem_TKPDC.Location = new System.Drawing.Point(327, 182);
            this.btnTimKiem_TKPDC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTimKiem_TKPDC.Name = "btnTimKiem_TKPDC";
            this.btnTimKiem_TKPDC.Size = new System.Drawing.Size(182, 49);
            this.btnTimKiem_TKPDC.TabIndex = 95;
            this.btnTimKiem_TKPDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem_TKPDC.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lblTieuDe_TKPDC
            // 
            this.lblTieuDe_TKPDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe_TKPDC.AutoSize = true;
            this.lblTieuDe_TKPDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_TKPDC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_TKPDC.Location = new System.Drawing.Point(622, 47);
            this.lblTieuDe_TKPDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe_TKPDC.Name = "lblTieuDe_TKPDC";
            this.lblTieuDe_TKPDC.Size = new System.Drawing.Size(383, 32);
            this.lblTieuDe_TKPDC.TabIndex = 105;
            this.lblTieuDe_TKPDC.Text = "TÌM KIẾM PHIẾU ĐẶT CHỖ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.flame_flight_is_awaiting3;
            this.pictureBox1.Location = new System.Drawing.Point(1008, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat_TKPDC
            // 
            this.btnThoat_TKPDC.ActiveBorderThickness = 1;
            this.btnThoat_TKPDC.ActiveCornerRadius = 20;
            this.btnThoat_TKPDC.ActiveFillColor = System.Drawing.Color.White;
            this.btnThoat_TKPDC.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKPDC.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKPDC.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_TKPDC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_TKPDC.BackgroundImage")));
            this.btnThoat_TKPDC.ButtonText = "Thoát";
            this.btnThoat_TKPDC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_TKPDC.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_TKPDC.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_TKPDC.IdleBorderThickness = 3;
            this.btnThoat_TKPDC.IdleCornerRadius = 20;
            this.btnThoat_TKPDC.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_TKPDC.IdleForecolor = System.Drawing.Color.White;
            this.btnThoat_TKPDC.IdleLineColor = System.Drawing.Color.White;
            this.btnThoat_TKPDC.Location = new System.Drawing.Point(1425, 808);
            this.btnThoat_TKPDC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat_TKPDC.Name = "btnThoat_TKPDC";
            this.btnThoat_TKPDC.Size = new System.Drawing.Size(235, 66);
            this.btnThoat_TKPDC.TabIndex = 97;
            this.btnThoat_TKPDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_TKPDC.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btnClose_TimPDC
            // 
            this.btnClose_TimPDC.FlatAppearance.BorderSize = 0;
            this.btnClose_TimPDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_TimPDC.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_TimPDC.Location = new System.Drawing.Point(2, 3);
            this.btnClose_TimPDC.Name = "btnClose_TimPDC";
            this.btnClose_TimPDC.Size = new System.Drawing.Size(37, 37);
            this.btnClose_TimPDC.TabIndex = 107;
            this.btnClose_TimPDC.UseVisualStyleBackColor = true;
            this.btnClose_TimPDC.Click += new System.EventHandler(this.btnClose_TimPDC_Click);
            // 
            // errorCB
            // 
            this.errorCB.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // dtgvPDC_TKPDC
            // 
            this.dtgvPDC_TKPDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPDC_TKPDC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPDC_TKPDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPDC_TKPDC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.ThanhToan,
            this.Column8});
            this.dtgvPDC_TKPDC.Location = new System.Drawing.Point(156, 452);
            this.dtgvPDC_TKPDC.Name = "dtgvPDC_TKPDC";
            this.dtgvPDC_TKPDC.RowHeadersVisible = false;
            this.dtgvPDC_TKPDC.RowHeadersWidth = 51;
            this.dtgvPDC_TKPDC.RowTemplate.Height = 24;
            this.dtgvPDC_TKPDC.Size = new System.Drawing.Size(1504, 347);
            this.dtgvPDC_TKPDC.TabIndex = 108;
            this.dtgvPDC_TKPDC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPDC_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaChuyenBay";
            this.Column2.HeaderText = "Chuyến bay";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenHanhKhach";
            this.Column3.HeaderText = "Hành khách";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CMND";
            this.Column4.HeaderText = "CMND";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Điện Thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaHangVe";
            this.Column6.HeaderText = "Hạng vé";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GiaTien";
            this.Column7.HeaderText = "Giá tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Tinhtrang";
            this.Column9.HeaderText = "Tình Trạng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // ThanhToan
            // 
            this.ThanhToan.DataPropertyName = "ThanhToan";
            this.ThanhToan.HeaderText = "Thanh Toán";
            this.ThanhToan.MinimumWidth = 6;
            this.ThanhToan.Name = "ThanhToan";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Mapdc";
            this.Column8.HeaderText = "Mã PDC";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Visible = false;
            // 
            // btnXemTatCa_TKPDC
            // 
            this.btnXemTatCa_TKPDC.ActiveBorderThickness = 1;
            this.btnXemTatCa_TKPDC.ActiveCornerRadius = 20;
            this.btnXemTatCa_TKPDC.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXemTatCa_TKPDC.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemTatCa_TKPDC.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXemTatCa_TKPDC.BackColor = System.Drawing.SystemColors.Control;
            this.btnXemTatCa_TKPDC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemTatCa_TKPDC.BackgroundImage")));
            this.btnXemTatCa_TKPDC.ButtonText = "Xem tất cả";
            this.btnXemTatCa_TKPDC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemTatCa_TKPDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCa_TKPDC.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXemTatCa_TKPDC.IdleBorderThickness = 3;
            this.btnXemTatCa_TKPDC.IdleCornerRadius = 20;
            this.btnXemTatCa_TKPDC.IdleFillColor = System.Drawing.Color.White;
            this.btnXemTatCa_TKPDC.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnXemTatCa_TKPDC.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXemTatCa_TKPDC.Location = new System.Drawing.Point(156, 394);
            this.btnXemTatCa_TKPDC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXemTatCa_TKPDC.Name = "btnXemTatCa_TKPDC";
            this.btnXemTatCa_TKPDC.Size = new System.Drawing.Size(182, 49);
            this.btnXemTatCa_TKPDC.TabIndex = 97;
            this.btnXemTatCa_TKPDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemTatCa_TKPDC.Click += new System.EventHandler(this.btnXemTatCaPDC_Click);
            // 
            // TimKiemPDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1012);
            this.Controls.Add(this.btnXemTatCa_TKPDC);
            this.Controls.Add(this.dtgvPDC_TKPDC);
            this.Controls.Add(this.btnClose_TimPDC);
            this.Controls.Add(this.lblTieuDe_TKPDC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThoat_TKPDC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiemPDC";
            this.Text = "TimKiemPDC";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimKiemPDC_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPDC_TKPDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND_TKPDC;
        private System.Windows.Forms.TextBox txtCB_TKPDC;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_TKPDC;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem_TKPDC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTieuDe_TKPDC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose_TimPDC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorCB;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.DataGridView dtgvPDC_TKPDC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemTatCa_TKPDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}