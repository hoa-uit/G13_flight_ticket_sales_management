namespace FlightManagement
{
    partial class NhanLichChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanLichChuyenBay));
            this.txtThoiGian_NhanLich = new System.Windows.Forms.TextBox();
            this.dtpNgayGio_NhanLich = new System.Windows.Forms.DateTimePicker();
            this.cbbSBDen_NhanLich = new System.Windows.Forms.ComboBox();
            this.cbbSBDi_NhanLich = new System.Windows.Forms.ComboBox();
            this.txtGiaVe_NhanLich = new System.Windows.Forms.TextBox();
            this.txtMCB_NhanLich = new System.Windows.Forms.TextBox();
            this.dtgvSBTrungGian_NhanLich = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_TranAirport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe_NhanLich = new System.Windows.Forms.Label();
            this.btnThoat_NhanLich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemmoi_NhanLich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorThoigiancho = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorThoigianbay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoSBTG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNgayGio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaSB = new System.Windows.Forms.ErrorProvider(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.dtgvHangVe_NhanLich = new System.Windows.Forms.DataGridView();
            this.MaHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChonHangVe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoLuongVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu_NhanLich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose_Nhanlich = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáDòngNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.errorMaCB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGiaVe = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSBTrungGian_NhanLich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigiancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigianbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoSBTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgayGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe_NhanLich)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaVe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThoiGian_NhanLich
            // 
            this.txtThoiGian_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian_NhanLich.Location = new System.Drawing.Point(1087, 249);
            this.txtThoiGian_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThoiGian_NhanLich.Name = "txtThoiGian_NhanLich";
            this.txtThoiGian_NhanLich.Size = new System.Drawing.Size(296, 27);
            this.txtThoiGian_NhanLich.TabIndex = 3;
            this.txtThoiGian_NhanLich.TextChanged += new System.EventHandler(this.btn_TIME_TextChanged);
            this.txtThoiGian_NhanLich.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtThoiGian_NhanLich_MouseMove);
            // 
            // dtpNgayGio_NhanLich
            // 
            this.dtpNgayGio_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGio_NhanLich.Location = new System.Drawing.Point(445, 245);
            this.dtpNgayGio_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayGio_NhanLich.Name = "dtpNgayGio_NhanLich";
            this.dtpNgayGio_NhanLich.Size = new System.Drawing.Size(312, 27);
            this.dtpNgayGio_NhanLich.TabIndex = 34;
            this.dtpNgayGio_NhanLich.Value = new System.DateTime(2021, 5, 13, 21, 56, 0, 0);
            this.dtpNgayGio_NhanLich.ValueChanged += new System.EventHandler(this.timepk_DATIMEFLIGHT_ValueChanged);
            // 
            // cbbSBDen_NhanLich
            // 
            this.cbbSBDen_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSBDen_NhanLich.FormattingEnabled = true;
            this.cbbSBDen_NhanLich.Location = new System.Drawing.Point(1087, 178);
            this.cbbSBDen_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSBDen_NhanLich.Name = "cbbSBDen_NhanLich";
            this.cbbSBDen_NhanLich.Size = new System.Drawing.Size(342, 28);
            this.cbbSBDen_NhanLich.TabIndex = 36;
            // 
            // cbbSBDi_NhanLich
            // 
            this.cbbSBDi_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSBDi_NhanLich.FormattingEnabled = true;
            this.cbbSBDi_NhanLich.Location = new System.Drawing.Point(445, 196);
            this.cbbSBDi_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSBDi_NhanLich.Name = "cbbSBDi_NhanLich";
            this.cbbSBDi_NhanLich.Size = new System.Drawing.Size(312, 28);
            this.cbbSBDi_NhanLich.TabIndex = 35;
            // 
            // txtGiaVe_NhanLich
            // 
            this.txtGiaVe_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe_NhanLich.Location = new System.Drawing.Point(1087, 118);
            this.txtGiaVe_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaVe_NhanLich.Name = "txtGiaVe_NhanLich";
            this.txtGiaVe_NhanLich.Size = new System.Drawing.Size(264, 27);
            this.txtGiaVe_NhanLich.TabIndex = 2;
            this.txtGiaVe_NhanLich.TextChanged += new System.EventHandler(this.txtGiaVe_NhanLich_TextChanged);
            // 
            // txtMCB_NhanLich
            // 
            this.txtMCB_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCB_NhanLich.Location = new System.Drawing.Point(445, 118);
            this.txtMCB_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMCB_NhanLich.Name = "txtMCB_NhanLich";
            this.txtMCB_NhanLich.Size = new System.Drawing.Size(312, 27);
            this.txtMCB_NhanLich.TabIndex = 1;
            this.txtMCB_NhanLich.TextChanged += new System.EventHandler(this.txtMCB_NhanLich_TextChanged);
            // 
            // dtgvSBTrungGian_NhanLich
            // 
            this.dtgvSBTrungGian_NhanLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSBTrungGian_NhanLich.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvSBTrungGian_NhanLich.ColumnHeadersHeight = 29;
            this.dtgvSBTrungGian_NhanLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvSBTrungGian_NhanLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.cbb_TranAirport,
            this.Column3,
            this.ghichu});
            this.dtgvSBTrungGian_NhanLich.EnableHeadersVisualStyles = false;
            this.dtgvSBTrungGian_NhanLich.Location = new System.Drawing.Point(179, 590);
            this.dtgvSBTrungGian_NhanLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvSBTrungGian_NhanLich.Name = "dtgvSBTrungGian_NhanLich";
            this.dtgvSBTrungGian_NhanLich.RowHeadersWidth = 51;
            this.dtgvSBTrungGian_NhanLich.RowTemplate.Height = 24;
            this.dtgvSBTrungGian_NhanLich.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvSBTrungGian_NhanLich.Size = new System.Drawing.Size(1250, 177);
            this.dtgvSBTrungGian_NhanLich.TabIndex = 38;
            this.dtgvSBTrungGian_NhanLich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanBayTrungGian_CellClick);
            this.dtgvSBTrungGian_NhanLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanLich_CellContentClick);
            this.dtgvSBTrungGian_NhanLich.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanBayTrungGian_CellEndEdit);
            this.dtgvSBTrungGian_NhanLich.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SanBayTrungGian_CellMouseUp);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // cbb_TranAirport
            // 
            this.cbb_TranAirport.HeaderText = "Sân Bay Trung Gian";
            this.cbb_TranAirport.MinimumWidth = 6;
            this.cbb_TranAirport.Name = "cbb_TranAirport";
            this.cbb_TranAirport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbb_TranAirport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thời Gian Chờ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            // 
            // lblTieuDe_NhanLich
            // 
            this.lblTieuDe_NhanLich.AutoSize = true;
            this.lblTieuDe_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_NhanLich.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_NhanLich.Location = new System.Drawing.Point(666, 29);
            this.lblTieuDe_NhanLich.Name = "lblTieuDe_NhanLich";
            this.lblTieuDe_NhanLich.Size = new System.Drawing.Size(373, 32);
            this.lblTieuDe_NhanLich.TabIndex = 42;
            this.lblTieuDe_NhanLich.Text = "NHẬN LỊCH CHUYẾN BAY";
            // 
            // btnThoat_NhanLich
            // 
            this.btnThoat_NhanLich.ActiveBorderThickness = 3;
            this.btnThoat_NhanLich.ActiveCornerRadius = 20;
            this.btnThoat_NhanLich.ActiveFillColor = System.Drawing.Color.White;
            this.btnThoat_NhanLich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_NhanLich.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_NhanLich.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_NhanLich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_NhanLich.BackgroundImage")));
            this.btnThoat_NhanLich.ButtonText = "Thoát";
            this.btnThoat_NhanLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_NhanLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_NhanLich.IdleBorderThickness = 3;
            this.btnThoat_NhanLich.IdleCornerRadius = 20;
            this.btnThoat_NhanLich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_NhanLich.IdleForecolor = System.Drawing.Color.White;
            this.btnThoat_NhanLich.IdleLineColor = System.Drawing.Color.White;
            this.btnThoat_NhanLich.Location = new System.Drawing.Point(179, 779);
            this.btnThoat_NhanLich.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat_NhanLich.Name = "btnThoat_NhanLich";
            this.btnThoat_NhanLich.Size = new System.Drawing.Size(215, 60);
            this.btnThoat_NhanLich.TabIndex = 43;
            this.btnThoat_NhanLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_NhanLich.Click += new System.EventHandler(this.btnThoat_nhanlich_Click);
            // 
            // btnThemmoi_NhanLich
            // 
            this.btnThemmoi_NhanLich.ActiveBorderThickness = 3;
            this.btnThemmoi_NhanLich.ActiveCornerRadius = 20;
            this.btnThemmoi_NhanLich.ActiveFillColor = System.Drawing.Color.White;
            this.btnThemmoi_NhanLich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThemmoi_NhanLich.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemmoi_NhanLich.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemmoi_NhanLich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemmoi_NhanLich.BackgroundImage")));
            this.btnThemmoi_NhanLich.ButtonText = "Thêm mới";
            this.btnThemmoi_NhanLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemmoi_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi_NhanLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThemmoi_NhanLich.IdleBorderThickness = 3;
            this.btnThemmoi_NhanLich.IdleCornerRadius = 20;
            this.btnThemmoi_NhanLich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemmoi_NhanLich.IdleForecolor = System.Drawing.Color.White;
            this.btnThemmoi_NhanLich.IdleLineColor = System.Drawing.Color.White;
            this.btnThemmoi_NhanLich.Location = new System.Drawing.Point(969, 783);
            this.btnThemmoi_NhanLich.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemmoi_NhanLich.Name = "btnThemmoi_NhanLich";
            this.btnThemmoi_NhanLich.Size = new System.Drawing.Size(215, 60);
            this.btnThemmoi_NhanLich.TabIndex = 45;
            this.btnThemmoi_NhanLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemmoi_NhanLich.Click += new System.EventHandler(this.btnTiep_nhanlich_Click);
            // 
            // errorThoigiancho
            // 
            this.errorThoigiancho.ContainerControl = this;
            // 
            // errorThoigianbay
            // 
            this.errorThoigianbay.ContainerControl = this;
            // 
            // errorSoSBTG
            // 
            this.errorSoSBTG.ContainerControl = this;
            // 
            // errNgayGio
            // 
            this.errNgayGio.ContainerControl = this;
            // 
            // errorMaSB
            // 
            this.errorMaSB.ContainerControl = this;
            // 
            // dtgvHangVe_NhanLich
            // 
            this.dtgvHangVe_NhanLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHangVe_NhanLich.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvHangVe_NhanLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangVe_NhanLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangVe,
            this.TenHangVe,
            this.TyLe,
            this.ChonHangVe,
            this.SoLuongVe});
            this.dtgvHangVe_NhanLich.Location = new System.Drawing.Point(180, 352);
            this.dtgvHangVe_NhanLich.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvHangVe_NhanLich.Name = "dtgvHangVe_NhanLich";
            this.dtgvHangVe_NhanLich.RowHeadersWidth = 51;
            this.dtgvHangVe_NhanLich.Size = new System.Drawing.Size(1249, 178);
            this.dtgvHangVe_NhanLich.TabIndex = 51;
            this.dtgvHangVe_NhanLich.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangVe_CellValueChanged);
            this.dtgvHangVe_NhanLich.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_HangVe_CurrentCellDirtyStateChanged);
            // 
            // MaHangVe
            // 
            this.MaHangVe.DataPropertyName = "MaHangVe";
            this.MaHangVe.HeaderText = "Mã Hạng Vé";
            this.MaHangVe.MinimumWidth = 6;
            this.MaHangVe.Name = "MaHangVe";
            this.MaHangVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TenHangVe
            // 
            this.TenHangVe.DataPropertyName = "TenHangVe";
            this.TenHangVe.HeaderText = "Tên Hạng Vé";
            this.TenHangVe.MinimumWidth = 6;
            this.TenHangVe.Name = "TenHangVe";
            this.TenHangVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TyLe
            // 
            this.TyLe.DataPropertyName = "TyLeGiaVe";
            this.TyLe.HeaderText = "Tỷ Lệ Giá Vé";
            this.TyLe.MinimumWidth = 6;
            this.TyLe.Name = "TyLe";
            this.TyLe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ChonHangVe
            // 
            this.ChonHangVe.DataPropertyName = "ChonHangVe";
            this.ChonHangVe.FalseValue = "False";
            this.ChonHangVe.HeaderText = "Chọn Hạng Vé";
            this.ChonHangVe.MinimumWidth = 6;
            this.ChonHangVe.Name = "ChonHangVe";
            this.ChonHangVe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChonHangVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ChonHangVe.TrueValue = "True";
            // 
            // SoLuongVe
            // 
            this.SoLuongVe.DataPropertyName = "SoLuongVe";
            this.SoLuongVe.HeaderText = "Số Lượng Vé";
            this.SoLuongVe.MinimumWidth = 6;
            this.SoLuongVe.Name = "SoLuongVe";
            this.SoLuongVe.ReadOnly = true;
            this.SoLuongVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnLuu_NhanLich
            // 
            this.btnLuu_NhanLich.ActiveBorderThickness = 3;
            this.btnLuu_NhanLich.ActiveCornerRadius = 20;
            this.btnLuu_NhanLich.ActiveFillColor = System.Drawing.Color.White;
            this.btnLuu_NhanLich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_NhanLich.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_NhanLich.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu_NhanLich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu_NhanLich.BackgroundImage")));
            this.btnLuu_NhanLich.ButtonText = "Lưu";
            this.btnLuu_NhanLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu_NhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_NhanLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLuu_NhanLich.IdleBorderThickness = 3;
            this.btnLuu_NhanLich.IdleCornerRadius = 20;
            this.btnLuu_NhanLich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_NhanLich.IdleForecolor = System.Drawing.Color.White;
            this.btnLuu_NhanLich.IdleLineColor = System.Drawing.Color.White;
            this.btnLuu_NhanLich.Location = new System.Drawing.Point(1214, 783);
            this.btnLuu_NhanLich.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu_NhanLich.Name = "btnLuu_NhanLich";
            this.btnLuu_NhanLich.Size = new System.Drawing.Size(215, 60);
            this.btnLuu_NhanLich.TabIndex = 44;
            this.btnLuu_NhanLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu_NhanLich.Click += new System.EventHandler(this.btnLuu_nhanlich_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(608, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 36);
            this.button1.TabIndex = 52;
            this.button1.Text = "Danh sách các hạng vé";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(608, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 36);
            this.button2.TabIndex = 53;
            this.button2.Text = "Danh sách sân bay trung gian";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnClose_Nhanlich
            // 
            this.btnClose_Nhanlich.FlatAppearance.BorderSize = 0;
            this.btnClose_Nhanlich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_Nhanlich.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_Nhanlich.Location = new System.Drawing.Point(1, -1);
            this.btnClose_Nhanlich.Name = "btnClose_Nhanlich";
            this.btnClose_Nhanlich.Size = new System.Drawing.Size(37, 37);
            this.btnClose_Nhanlich.TabIndex = 54;
            this.btnClose_Nhanlich.UseVisualStyleBackColor = true;
            this.btnClose_Nhanlich.Click += new System.EventHandler(this.btnClose_Nhanlich_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáDòngNàyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 28);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // xoáDòngNàyToolStripMenuItem
            // 
            this.xoáDòngNàyToolStripMenuItem.Name = "xoáDòngNàyToolStripMenuItem";
            this.xoáDòngNàyToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.xoáDòngNàyToolStripMenuItem.Text = "Xoá Dòng Này";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1367, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã chuyến bay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Sân bay đi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Ngày - Giờ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(992, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Giá vé:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(948, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Sân bay đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(941, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Thời gian bay:";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(442, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 41);
            this.label9.TabIndex = 88;
            this.label9.Text = "Mã chuyến bay có 5 kí tự, 2 chữ cái đầu là \"CB\" cộng với 3 chữ số ví dụ \"CB011\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(424, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(424, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 90;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(424, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 91;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1062, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 25);
            this.label12.TabIndex = 92;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1062, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 25);
            this.label13.TabIndex = 93;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1060, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 25);
            this.label14.TabIndex = 94;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(15, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 25);
            this.label15.TabIndex = 95;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(42, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 96;
            this.label16.Text = "bắt buộc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1389, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 97;
            this.label17.Text = "Phút";
            // 
            // errorMaCB
            // 
            this.errorMaCB.ContainerControl = this;
            // 
            // errorGiaVe
            // 
            this.errorGiaVe.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(445, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 37);
            this.panel1.TabIndex = 98;
            // 
            // NhanLichChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose_Nhanlich);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvHangVe_NhanLich);
            this.Controls.Add(this.btnThemmoi_NhanLich);
            this.Controls.Add(this.btnLuu_NhanLich);
            this.Controls.Add(this.btnThoat_NhanLich);
            this.Controls.Add(this.lblTieuDe_NhanLich);
            this.Controls.Add(this.dtgvSBTrungGian_NhanLich);
            this.Controls.Add(this.txtThoiGian_NhanLich);
            this.Controls.Add(this.dtpNgayGio_NhanLich);
            this.Controls.Add(this.cbbSBDen_NhanLich);
            this.Controls.Add(this.cbbSBDi_NhanLich);
            this.Controls.Add(this.txtGiaVe_NhanLich);
            this.Controls.Add(this.txtMCB_NhanLich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanLichChuyenBay";
            this.Text = "s";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhanLichChuyenBay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSBTrungGian_NhanLich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigiancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigianbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoSBTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgayGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe_NhanLich)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorMaCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaVe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtThoiGian_NhanLich;
        private System.Windows.Forms.DateTimePicker dtpNgayGio_NhanLich;
        private System.Windows.Forms.ComboBox cbbSBDen_NhanLich;
        private System.Windows.Forms.ComboBox cbbSBDi_NhanLich;
        private System.Windows.Forms.TextBox txtGiaVe_NhanLich;
        private System.Windows.Forms.TextBox txtMCB_NhanLich;
        private System.Windows.Forms.DataGridView dtgvSBTrungGian_NhanLich;
        private System.Windows.Forms.Label lblTieuDe_NhanLich;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_NhanLich;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemmoi_NhanLich;
        private System.Windows.Forms.ErrorProvider errorThoigiancho;
        private System.Windows.Forms.ErrorProvider errorThoigianbay;
        private System.Windows.Forms.ErrorProvider errorSoSBTG;
        private System.Windows.Forms.ErrorProvider errNgayGio;
        private System.Windows.Forms.ErrorProvider errorMaSB;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.DataGridView dtgvHangVe_NhanLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChonHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongVe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu_NhanLich;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose_Nhanlich;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoáDòngNàyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbb_TranAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider errorMaCB;
        private System.Windows.Forms.ErrorProvider errorGiaVe;
        private System.Windows.Forms.Panel panel1;
    }
}