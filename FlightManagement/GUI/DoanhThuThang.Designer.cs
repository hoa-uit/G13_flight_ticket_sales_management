namespace FlightManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThuThang));
            this.txtNam_BCDTT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbThang_BCDTT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTieuDe_BCDTT = new System.Windows.Forms.Label();
            this.errThang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNam = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTyLe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongDT_BCDTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMCB_BCDTT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatfile_BCDTT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThoat_BCDTT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBaoCao_BCDTT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dtgvCTDT_BCDTT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose_DTThang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDT_BCDTT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNam_BCDTT
            // 
            this.txtNam_BCDTT.Location = new System.Drawing.Point(114, 64);
            this.txtNam_BCDTT.Name = "txtNam_BCDTT";
            this.txtNam_BCDTT.Size = new System.Drawing.Size(205, 22);
            this.txtNam_BCDTT.TabIndex = 13;
            this.txtNam_BCDTT.TextChanged += new System.EventHandler(this.txtNam_DTThang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbbThang_BCDTT
            // 
            this.cbbThang_BCDTT.FormattingEnabled = true;
            this.cbbThang_BCDTT.Items.AddRange(new object[] {
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
            this.cbbThang_BCDTT.Location = new System.Drawing.Point(114, 23);
            this.cbbThang_BCDTT.Name = "cbbThang_BCDTT";
            this.cbbThang_BCDTT.Size = new System.Drawing.Size(205, 24);
            this.cbbThang_BCDTT.TabIndex = 11;
            this.cbbThang_BCDTT.SelectedIndexChanged += new System.EventHandler(this.cbThang_DTThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tháng: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTieuDe_BCDTT
            // 
            this.lblTieuDe_BCDTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe_BCDTT.AutoSize = true;
            this.lblTieuDe_BCDTT.BackColor = System.Drawing.SystemColors.Control;
            this.lblTieuDe_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_BCDTT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_BCDTT.Location = new System.Drawing.Point(536, 41);
            this.lblTieuDe_BCDTT.Name = "lblTieuDe_BCDTT";
            this.lblTieuDe_BCDTT.Size = new System.Drawing.Size(522, 38);
            this.lblTieuDe_BCDTT.TabIndex = 9;
            this.lblTieuDe_BCDTT.Text = "BÁO CÁO DOANH THU THÁNG";
            this.lblTieuDe_BCDTT.Click += new System.EventHandler(this.label1_Click);
            // 
            // errThang
            // 
            this.errThang.ContainerControl = this;
            // 
            // errNam
            // 
            this.errNam.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(130, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(725, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Danh sách chi tiết doanh thu các chuyến bay trong tháng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(882, 127);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "DoanhThu";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(754, 409);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chartDTCB_BCDTT";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Biểu đồ doanh thu các chuyến bay trong tháng";
            this.chart1.Titles.Add(title2);
            // 
            // chartTyLe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTyLe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTyLe.Legends.Add(legend1);
            this.chartTyLe.Location = new System.Drawing.Point(882, 553);
            this.chartTyLe.Name = "chartTyLe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "TyLe";
            this.chartTyLe.Series.Add(series1);
            this.chartTyLe.Size = new System.Drawing.Size(540, 282);
            this.chartTyLe.TabIndex = 40;
            this.chartTyLe.Text = "chartTLDT_BCDTT";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tỷ lệ doanh thu các chuyến bay trong tháng";
            this.chartTyLe.Titles.Add(title1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tổng doanh thu tháng:";
            // 
            // txtTongDT_BCDTT
            // 
            this.txtTongDT_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDT_BCDTT.ForeColor = System.Drawing.Color.Red;
            this.txtTongDT_BCDTT.Location = new System.Drawing.Point(308, 25);
            this.txtTongDT_BCDTT.Name = "txtTongDT_BCDTT";
            this.txtTongDT_BCDTT.ReadOnly = true;
            this.txtTongDT_BCDTT.Size = new System.Drawing.Size(235, 27);
            this.txtTongDT_BCDTT.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Chuyến bay có doanh thu cao nhất:";
            // 
            // txtMCB_BCDTT
            // 
            this.txtMCB_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCB_BCDTT.ForeColor = System.Drawing.Color.Red;
            this.txtMCB_BCDTT.Location = new System.Drawing.Point(408, 76);
            this.txtMCB_BCDTT.Name = "txtMCB_BCDTT";
            this.txtMCB_BCDTT.ReadOnly = true;
            this.txtMCB_BCDTT.Size = new System.Drawing.Size(135, 27);
            this.txtMCB_BCDTT.TabIndex = 45;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.txtTongDT_BCDTT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMCB_BCDTT);
            this.panel1.Location = new System.Drawing.Point(130, 694);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 141);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnXuatfile_BCDTT);
            this.panel2.Controls.Add(this.btnThoat_BCDTT);
            this.panel2.Location = new System.Drawing.Point(1432, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 282);
            this.panel2.TabIndex = 50;
            // 
            // btnXuatfile_BCDTT
            // 
            this.btnXuatfile_BCDTT.ActiveBorderThickness = 1;
            this.btnXuatfile_BCDTT.ActiveCornerRadius = 20;
            this.btnXuatfile_BCDTT.ActiveFillColor = System.Drawing.Color.White;
            this.btnXuatfile_BCDTT.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatfile_BCDTT.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatfile_BCDTT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatfile_BCDTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatfile_BCDTT.BackgroundImage")));
            this.btnXuatfile_BCDTT.ButtonText = "Xuất báo cáo";
            this.btnXuatfile_BCDTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatfile_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatfile_BCDTT.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXuatfile_BCDTT.IdleBorderThickness = 3;
            this.btnXuatfile_BCDTT.IdleCornerRadius = 20;
            this.btnXuatfile_BCDTT.IdleFillColor = System.Drawing.Color.White;
            this.btnXuatfile_BCDTT.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatfile_BCDTT.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuatfile_BCDTT.Location = new System.Drawing.Point(11, 52);
            this.btnXuatfile_BCDTT.Margin = new System.Windows.Forms.Padding(6);
            this.btnXuatfile_BCDTT.Name = "btnXuatfile_BCDTT";
            this.btnXuatfile_BCDTT.Size = new System.Drawing.Size(184, 77);
            this.btnXuatfile_BCDTT.TabIndex = 22;
            this.btnXuatfile_BCDTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatfile_BCDTT.Click += new System.EventHandler(this.btnXuatfile_baocaothang_Click);
            // 
            // btnThoat_BCDTT
            // 
            this.btnThoat_BCDTT.ActiveBorderThickness = 1;
            this.btnThoat_BCDTT.ActiveCornerRadius = 20;
            this.btnThoat_BCDTT.ActiveFillColor = System.Drawing.Color.White;
            this.btnThoat_BCDTT.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_BCDTT.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_BCDTT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_BCDTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_BCDTT.BackgroundImage")));
            this.btnThoat_BCDTT.ButtonText = "Thoát";
            this.btnThoat_BCDTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_BCDTT.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat_BCDTT.IdleBorderThickness = 3;
            this.btnThoat_BCDTT.IdleCornerRadius = 20;
            this.btnThoat_BCDTT.IdleFillColor = System.Drawing.Color.White;
            this.btnThoat_BCDTT.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_BCDTT.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat_BCDTT.Location = new System.Drawing.Point(12, 127);
            this.btnThoat_BCDTT.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat_BCDTT.Name = "btnThoat_BCDTT";
            this.btnThoat_BCDTT.Size = new System.Drawing.Size(184, 75);
            this.btnThoat_BCDTT.TabIndex = 21;
            this.btnThoat_BCDTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat_BCDTT.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnBaoCao_BCDTT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbbThang_BCDTT);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNam_BCDTT);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(130, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 163);
            this.panel3.TabIndex = 51;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::FlightManagement.Properties.Resources.icons8_cloud_64;
            this.pictureBox3.Location = new System.Drawing.Point(425, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // btnBaoCao_BCDTT
            // 
            this.btnBaoCao_BCDTT.ActiveBorderThickness = 1;
            this.btnBaoCao_BCDTT.ActiveCornerRadius = 20;
            this.btnBaoCao_BCDTT.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnBaoCao_BCDTT.ActiveForecolor = System.Drawing.Color.White;
            this.btnBaoCao_BCDTT.ActiveLineColor = System.Drawing.Color.White;
            this.btnBaoCao_BCDTT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBaoCao_BCDTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao_BCDTT.BackgroundImage")));
            this.btnBaoCao_BCDTT.ButtonText = "Xem kết quả";
            this.btnBaoCao_BCDTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao_BCDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao_BCDTT.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBaoCao_BCDTT.IdleBorderThickness = 3;
            this.btnBaoCao_BCDTT.IdleCornerRadius = 12;
            this.btnBaoCao_BCDTT.IdleFillColor = System.Drawing.Color.White;
            this.btnBaoCao_BCDTT.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnBaoCao_BCDTT.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBaoCao_BCDTT.Location = new System.Drawing.Point(114, 107);
            this.btnBaoCao_BCDTT.Margin = new System.Windows.Forms.Padding(6);
            this.btnBaoCao_BCDTT.Name = "btnBaoCao_BCDTT";
            this.btnBaoCao_BCDTT.Size = new System.Drawing.Size(211, 50);
            this.btnBaoCao_BCDTT.TabIndex = 20;
            this.btnBaoCao_BCDTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaoCao_BCDTT.Click += new System.EventHandler(this.btnBaoCao_DTThang_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.abstract_online_flight_booking;
            this.pictureBox1.Location = new System.Drawing.Point(488, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::FlightManagement.Properties.Resources.icons8_cloud_64;
            this.pictureBox4.Location = new System.Drawing.Point(352, 80);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // dtgvCTDT_BCDTT
            // 
            this.dtgvCTDT_BCDTT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCTDT_BCDTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTDT_BCDTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvCTDT_BCDTT.Location = new System.Drawing.Point(130, 356);
            this.dtgvCTDT_BCDTT.Name = "dtgvCTDT_BCDTT";
            this.dtgvCTDT_BCDTT.RowHeadersWidth = 51;
            this.dtgvCTDT_BCDTT.RowTemplate.Height = 24;
            this.dtgvCTDT_BCDTT.Size = new System.Drawing.Size(725, 324);
            this.dtgvCTDT_BCDTT.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaChuyenBay";
            this.Column1.HeaderText = "Mã chuyến bay";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Thang";
            this.Column2.HeaderText = "Tháng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nam";
            this.Column3.HeaderText = "Năm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoVe";
            this.Column4.HeaderText = "Số vé";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TyLeTungCB";
            this.Column5.HeaderText = "Tỷ lệ (%)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DoanhThu";
            this.Column6.HeaderText = "Doanh thu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnClose_DTThang
            // 
            this.btnClose_DTThang.FlatAppearance.BorderSize = 0;
            this.btnClose_DTThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_DTThang.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_DTThang.Location = new System.Drawing.Point(-1, 0);
            this.btnClose_DTThang.Name = "btnClose_DTThang";
            this.btnClose_DTThang.Size = new System.Drawing.Size(37, 37);
            this.btnClose_DTThang.TabIndex = 33;
            this.btnClose_DTThang.UseVisualStyleBackColor = true;
            this.btnClose_DTThang.Click += new System.EventHandler(this.btnClose_DTThang_Click);
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1705, 1005);
            this.Controls.Add(this.dtgvCTDT_BCDTT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartTyLe);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose_DTThang);
            this.Controls.Add(this.lblTieuDe_BCDTT);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "DoanhThuThang";
            this.Text = "DoanhThuThang";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoanhThuThang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDT_BCDTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNam_BCDTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThang_BCDTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTieuDe_BCDTT;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat_BCDTT;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXuatfile_BCDTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errThang;
        private System.Windows.Forms.ErrorProvider errNam;
        private System.Windows.Forms.Button btnClose_DTThang;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBaoCao_BCDTT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTyLe;
        private System.Windows.Forms.TextBox txtTongDT_BCDTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMCB_BCDTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvCTDT_BCDTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}