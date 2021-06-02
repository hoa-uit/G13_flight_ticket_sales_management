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
            this.btnClose_nhanlich = new System.Windows.Forms.Button();
            this.btn_SEATTWO = new System.Windows.Forms.TextBox();
            this.btn_SEATONE = new System.Windows.Forms.TextBox();
            this.NumSeat1 = new System.Windows.Forms.Button();
            this.btn_TIME = new System.Windows.Forms.TextBox();
            this.FlightTime = new System.Windows.Forms.Button();
            this.timepk_DATIMEFLIGHT = new System.Windows.Forms.DateTimePicker();
            this.FlightDate = new System.Windows.Forms.Button();
            this.NumSeat2 = new System.Windows.Forms.Button();
            this.cbb_DesAirport = new System.Windows.Forms.ComboBox();
            this.cbb_OriAirport = new System.Windows.Forms.ComboBox();
            this.OriAirport = new System.Windows.Forms.Button();
            this.btn_PRICE = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Button();
            this.btn_IDFLIGHT = new System.Windows.Forms.TextBox();
            this.FlightID = new System.Windows.Forms.Button();
            this.DesAirport = new System.Windows.Forms.Button();
            this.dgv_NhanLich = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_TranAirport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat_nhanlich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLuu_nhanlich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTiep_nhanlich = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorThoigiancho = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorThoigianbay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoSBTG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNgayGio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaSB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanLich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigiancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigianbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoSBTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgayGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose_nhanlich
            // 
            this.btnClose_nhanlich.FlatAppearance.BorderSize = 0;
            this.btnClose_nhanlich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_nhanlich.Image = global::FlightManagement.Properties.Resources.icons8_close_window_30;
            this.btnClose_nhanlich.Location = new System.Drawing.Point(12, 12);
            this.btnClose_nhanlich.Name = "btnClose_nhanlich";
            this.btnClose_nhanlich.Size = new System.Drawing.Size(31, 32);
            this.btnClose_nhanlich.TabIndex = 20;
            this.btnClose_nhanlich.UseVisualStyleBackColor = true;
            this.btnClose_nhanlich.Click += new System.EventHandler(this.btnClose_nhanlich_Click);
            // 
            // btn_SEATTWO
            // 
            this.btn_SEATTWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEATTWO.Location = new System.Drawing.Point(1087, 416);
            this.btn_SEATTWO.Name = "btn_SEATTWO";
            this.btn_SEATTWO.Size = new System.Drawing.Size(250, 27);
            this.btn_SEATTWO.TabIndex = 21;
            // 
            // btn_SEATONE
            // 
            this.btn_SEATONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEATONE.Location = new System.Drawing.Point(446, 415);
            this.btn_SEATONE.Name = "btn_SEATONE";
            this.btn_SEATONE.Size = new System.Drawing.Size(312, 27);
            this.btn_SEATONE.TabIndex = 22;
            // 
            // NumSeat1
            // 
            this.NumSeat1.BackColor = System.Drawing.Color.LightGray;
            this.NumSeat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSeat1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumSeat1.Location = new System.Drawing.Point(179, 406);
            this.NumSeat1.Name = "NumSeat1";
            this.NumSeat1.Size = new System.Drawing.Size(225, 42);
            this.NumSeat1.TabIndex = 23;
            this.NumSeat1.Text = "Số lượng ghế hạng 1";
            this.NumSeat1.UseVisualStyleBackColor = false;
            // 
            // btn_TIME
            // 
            this.btn_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TIME.Location = new System.Drawing.Point(1087, 338);
            this.btn_TIME.Name = "btn_TIME";
            this.btn_TIME.Size = new System.Drawing.Size(250, 27);
            this.btn_TIME.TabIndex = 24;
            this.btn_TIME.TextChanged += new System.EventHandler(this.btn_TIME_TextChanged);
            // 
            // FlightTime
            // 
            this.FlightTime.BackColor = System.Drawing.Color.LightGray;
            this.FlightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FlightTime.Location = new System.Drawing.Point(815, 334);
            this.FlightTime.Name = "FlightTime";
            this.FlightTime.Size = new System.Drawing.Size(225, 42);
            this.FlightTime.TabIndex = 25;
            this.FlightTime.Text = "Thời gian Bay";
            this.FlightTime.UseVisualStyleBackColor = false;
            // 
            // timepk_DATIMEFLIGHT
            // 
            this.timepk_DATIMEFLIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepk_DATIMEFLIGHT.Location = new System.Drawing.Point(446, 344);
            this.timepk_DATIMEFLIGHT.Name = "timepk_DATIMEFLIGHT";
            this.timepk_DATIMEFLIGHT.Size = new System.Drawing.Size(312, 27);
            this.timepk_DATIMEFLIGHT.TabIndex = 34;
            this.timepk_DATIMEFLIGHT.Value = new System.DateTime(2021, 5, 13, 21, 56, 0, 0);
            this.timepk_DATIMEFLIGHT.ValueChanged += new System.EventHandler(this.timepk_DATIMEFLIGHT_ValueChanged);
            // 
            // FlightDate
            // 
            this.FlightDate.BackColor = System.Drawing.Color.LightGray;
            this.FlightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FlightDate.Location = new System.Drawing.Point(179, 334);
            this.FlightDate.Name = "FlightDate";
            this.FlightDate.Size = new System.Drawing.Size(225, 42);
            this.FlightDate.TabIndex = 26;
            this.FlightDate.Text = "Ngày - Giờ";
            this.FlightDate.UseVisualStyleBackColor = false;
            // 
            // NumSeat2
            // 
            this.NumSeat2.BackColor = System.Drawing.Color.LightGray;
            this.NumSeat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSeat2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumSeat2.Location = new System.Drawing.Point(815, 406);
            this.NumSeat2.Name = "NumSeat2";
            this.NumSeat2.Size = new System.Drawing.Size(225, 42);
            this.NumSeat2.TabIndex = 27;
            this.NumSeat2.Text = "Số lượng ghế hạng 2";
            this.NumSeat2.UseVisualStyleBackColor = false;
            // 
            // cbb_DesAirport
            // 
            this.cbb_DesAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DesAirport.FormattingEnabled = true;
            this.cbb_DesAirport.Location = new System.Drawing.Point(1087, 269);
            this.cbb_DesAirport.Name = "cbb_DesAirport";
            this.cbb_DesAirport.Size = new System.Drawing.Size(250, 28);
            this.cbb_DesAirport.TabIndex = 36;
            // 
            // cbb_OriAirport
            // 
            this.cbb_OriAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_OriAirport.FormattingEnabled = true;
            this.cbb_OriAirport.Location = new System.Drawing.Point(446, 267);
            this.cbb_OriAirport.Name = "cbb_OriAirport";
            this.cbb_OriAirport.Size = new System.Drawing.Size(312, 28);
            this.cbb_OriAirport.TabIndex = 35;
            // 
            // OriAirport
            // 
            this.OriAirport.BackColor = System.Drawing.Color.LightGray;
            this.OriAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriAirport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OriAirport.Location = new System.Drawing.Point(179, 262);
            this.OriAirport.Name = "OriAirport";
            this.OriAirport.Size = new System.Drawing.Size(225, 42);
            this.OriAirport.TabIndex = 29;
            this.OriAirport.Text = "Sân Bay Đi";
            this.OriAirport.UseVisualStyleBackColor = false;
            // 
            // btn_PRICE
            // 
            this.btn_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PRICE.Location = new System.Drawing.Point(1087, 198);
            this.btn_PRICE.Name = "btn_PRICE";
            this.btn_PRICE.Size = new System.Drawing.Size(250, 27);
            this.btn_PRICE.TabIndex = 30;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.LightGray;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Price.Location = new System.Drawing.Point(815, 190);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(225, 42);
            this.Price.TabIndex = 31;
            this.Price.Text = "Giá vé";
            this.Price.UseVisualStyleBackColor = false;
            // 
            // btn_IDFLIGHT
            // 
            this.btn_IDFLIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IDFLIGHT.Location = new System.Drawing.Point(446, 197);
            this.btn_IDFLIGHT.Name = "btn_IDFLIGHT";
            this.btn_IDFLIGHT.Size = new System.Drawing.Size(312, 27);
            this.btn_IDFLIGHT.TabIndex = 32;
            this.btn_IDFLIGHT.TextChanged += new System.EventHandler(this.btn_IDFLIGHT_TextChanged);
            // 
            // FlightID
            // 
            this.FlightID.BackColor = System.Drawing.Color.LightGray;
            this.FlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FlightID.Location = new System.Drawing.Point(179, 190);
            this.FlightID.Name = "FlightID";
            this.FlightID.Size = new System.Drawing.Size(225, 42);
            this.FlightID.TabIndex = 33;
            this.FlightID.Text = "Mã Chuyến Bay";
            this.FlightID.UseVisualStyleBackColor = false;
            // 
            // DesAirport
            // 
            this.DesAirport.BackColor = System.Drawing.Color.LightGray;
            this.DesAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesAirport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DesAirport.Location = new System.Drawing.Point(815, 262);
            this.DesAirport.Name = "DesAirport";
            this.DesAirport.Size = new System.Drawing.Size(225, 42);
            this.DesAirport.TabIndex = 28;
            this.DesAirport.Text = "Sân bay đến";
            this.DesAirport.UseVisualStyleBackColor = false;
            // 
            // dgv_NhanLich
            // 
            this.dgv_NhanLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanLich.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_NhanLich.ColumnHeadersHeight = 29;
            this.dgv_NhanLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_NhanLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.cbb_TranAirport,
            this.Column3,
            this.ghichu});
            this.dgv_NhanLich.Location = new System.Drawing.Point(179, 506);
            this.dgv_NhanLich.Name = "dgv_NhanLich";
            this.dgv_NhanLich.RowHeadersWidth = 51;
            this.dgv_NhanLich.RowTemplate.Height = 24;
            this.dgv_NhanLich.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_NhanLich.Size = new System.Drawing.Size(1158, 177);
            this.dgv_NhanLich.TabIndex = 38;
            this.dgv_NhanLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanLich_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(497, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "NHẬN LỊCH CHUYẾN BAY";
            // 
            // btnThoat_nhanlich
            // 
            this.btnThoat_nhanlich.ActiveBorderThickness = 1;
            this.btnThoat_nhanlich.ActiveCornerRadius = 20;
            this.btnThoat_nhanlich.ActiveFillColor = System.Drawing.Color.White;
            this.btnThoat_nhanlich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_nhanlich.ActiveLineColor = System.Drawing.Color.White;
            this.btnThoat_nhanlich.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat_nhanlich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_nhanlich.BackgroundImage")));
            this.btnThoat_nhanlich.ButtonText = "Thoát";
            this.btnThoat_nhanlich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_nhanlich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_nhanlich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_nhanlich.IdleBorderThickness = 1;
            this.btnThoat_nhanlich.IdleCornerRadius = 20;
            this.btnThoat_nhanlich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_nhanlich.IdleForecolor = System.Drawing.Color.White;
            this.btnThoat_nhanlich.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_nhanlich.Location = new System.Drawing.Point(179, 727);
            this.btnThoat_nhanlich.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat_nhanlich.Name = "btnThoat_nhanlich";
            this.btnThoat_nhanlich.Size = new System.Drawing.Size(215, 52);
            this.btnThoat_nhanlich.TabIndex = 43;
            this.btnThoat_nhanlich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_nhanlich.Click += new System.EventHandler(this.btnThoat_nhanlich_Click);
            // 
            // btnLuu_nhanlich
            // 
            this.btnLuu_nhanlich.ActiveBorderThickness = 1;
            this.btnLuu_nhanlich.ActiveCornerRadius = 20;
            this.btnLuu_nhanlich.ActiveFillColor = System.Drawing.Color.White;
            this.btnLuu_nhanlich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_nhanlich.ActiveLineColor = System.Drawing.Color.White;
            this.btnLuu_nhanlich.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu_nhanlich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu_nhanlich.BackgroundImage")));
            this.btnLuu_nhanlich.ButtonText = "Lưu";
            this.btnLuu_nhanlich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu_nhanlich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_nhanlich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLuu_nhanlich.IdleBorderThickness = 1;
            this.btnLuu_nhanlich.IdleCornerRadius = 20;
            this.btnLuu_nhanlich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_nhanlich.IdleForecolor = System.Drawing.Color.White;
            this.btnLuu_nhanlich.IdleLineColor = System.Drawing.Color.White;
            this.btnLuu_nhanlich.Location = new System.Drawing.Point(1122, 727);
            this.btnLuu_nhanlich.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu_nhanlich.Name = "btnLuu_nhanlich";
            this.btnLuu_nhanlich.Size = new System.Drawing.Size(215, 52);
            this.btnLuu_nhanlich.TabIndex = 44;
            this.btnLuu_nhanlich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu_nhanlich.Click += new System.EventHandler(this.btnLuu_nhanlich_Click);
            // 
            // btnTiep_nhanlich
            // 
            this.btnTiep_nhanlich.ActiveBorderThickness = 1;
            this.btnTiep_nhanlich.ActiveCornerRadius = 20;
            this.btnTiep_nhanlich.ActiveFillColor = System.Drawing.Color.White;
            this.btnTiep_nhanlich.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnTiep_nhanlich.ActiveLineColor = System.Drawing.Color.White;
            this.btnTiep_nhanlich.BackColor = System.Drawing.SystemColors.Control;
            this.btnTiep_nhanlich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiep_nhanlich.BackgroundImage")));
            this.btnTiep_nhanlich.ButtonText = "Tiếp";
            this.btnTiep_nhanlich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiep_nhanlich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep_nhanlich.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTiep_nhanlich.IdleBorderThickness = 1;
            this.btnTiep_nhanlich.IdleCornerRadius = 20;
            this.btnTiep_nhanlich.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTiep_nhanlich.IdleForecolor = System.Drawing.Color.White;
            this.btnTiep_nhanlich.IdleLineColor = System.Drawing.Color.White;
            this.btnTiep_nhanlich.Location = new System.Drawing.Point(897, 727);
            this.btnTiep_nhanlich.Margin = new System.Windows.Forms.Padding(5);
            this.btnTiep_nhanlich.Name = "btnTiep_nhanlich";
            this.btnTiep_nhanlich.Size = new System.Drawing.Size(215, 52);
            this.btnTiep_nhanlich.TabIndex = 45;
            this.btnTiep_nhanlich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTiep_nhanlich.Click += new System.EventHandler(this.btnTiep_nhanlich_Click);
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
            // NhanLichChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 803);
            this.Controls.Add(this.btnTiep_nhanlich);
            this.Controls.Add(this.btnLuu_nhanlich);
            this.Controls.Add(this.btnThoat_nhanlich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_NhanLich);
            this.Controls.Add(this.btn_SEATTWO);
            this.Controls.Add(this.btn_SEATONE);
            this.Controls.Add(this.NumSeat1);
            this.Controls.Add(this.btn_TIME);
            this.Controls.Add(this.FlightTime);
            this.Controls.Add(this.timepk_DATIMEFLIGHT);
            this.Controls.Add(this.FlightDate);
            this.Controls.Add(this.NumSeat2);
            this.Controls.Add(this.cbb_DesAirport);
            this.Controls.Add(this.cbb_OriAirport);
            this.Controls.Add(this.OriAirport);
            this.Controls.Add(this.btn_PRICE);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.btn_IDFLIGHT);
            this.Controls.Add(this.FlightID);
            this.Controls.Add(this.DesAirport);
            this.Controls.Add(this.btnClose_nhanlich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanLichChuyenBay";
            this.Text = "NhanLichChuyenBay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanLich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigiancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThoigianbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoSBTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgayGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose_nhanlich;
        private System.Windows.Forms.TextBox btn_SEATTWO;
        private System.Windows.Forms.TextBox btn_SEATONE;
        private System.Windows.Forms.Button NumSeat1;
        private System.Windows.Forms.TextBox btn_TIME;
        private System.Windows.Forms.Button FlightTime;
        private System.Windows.Forms.DateTimePicker timepk_DATIMEFLIGHT;
        private System.Windows.Forms.Button FlightDate;
        private System.Windows.Forms.Button NumSeat2;
        private System.Windows.Forms.ComboBox cbb_DesAirport;
        private System.Windows.Forms.ComboBox cbb_OriAirport;
        private System.Windows.Forms.Button OriAirport;
        private System.Windows.Forms.TextBox btn_PRICE;
        private System.Windows.Forms.Button Price;
        private System.Windows.Forms.TextBox btn_IDFLIGHT;
        private System.Windows.Forms.Button FlightID;
        private System.Windows.Forms.Button DesAirport;
        private System.Windows.Forms.DataGridView dgv_NhanLich;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_nhanlich;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu_nhanlich;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTiep_nhanlich;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbb_TranAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.ErrorProvider errorThoigiancho;
        private System.Windows.Forms.ErrorProvider errorThoigianbay;
        private System.Windows.Forms.ErrorProvider errorSoSBTG;
        private System.Windows.Forms.ErrorProvider errNgayGio;
        private System.Windows.Forms.ErrorProvider errorMaSB;
    }
}