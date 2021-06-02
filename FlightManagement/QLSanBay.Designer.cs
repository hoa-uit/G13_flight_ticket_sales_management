namespace FlightManagement
{
    partial class QLSanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSanBay));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSB_QLSB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSB_QLSB = new System.Windows.Forms.TextBox();
            this.dtgSanBay_QLSB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuocGia_QLSB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi_QLSB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua_QLSB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa_QLSB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem_QLSB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_changepassword = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.errorMaSB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanBay_QLSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(158, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ SÂN BAY";
            // 
            // txtMaSB_QLSB
            // 
            this.txtMaSB_QLSB.Location = new System.Drawing.Point(300, 175);
            this.txtMaSB_QLSB.Name = "txtMaSB_QLSB";
            this.txtMaSB_QLSB.Size = new System.Drawing.Size(295, 22);
            this.txtMaSB_QLSB.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã sân bay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên sân bay:";
            // 
            // txtTenSB_QLSB
            // 
            this.txtTenSB_QLSB.Location = new System.Drawing.Point(300, 220);
            this.txtTenSB_QLSB.Name = "txtTenSB_QLSB";
            this.txtTenSB_QLSB.Size = new System.Drawing.Size(295, 22);
            this.txtTenSB_QLSB.TabIndex = 27;
            // 
            // dtgSanBay_QLSB
            // 
            this.dtgSanBay_QLSB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSanBay_QLSB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSanBay_QLSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanBay_QLSB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgSanBay_QLSB.Location = new System.Drawing.Point(164, 495);
            this.dtgSanBay_QLSB.Name = "dtgSanBay_QLSB";
            this.dtgSanBay_QLSB.RowHeadersWidth = 51;
            this.dtgSanBay_QLSB.RowTemplate.Height = 24;
            this.dtgSanBay_QLSB.Size = new System.Drawing.Size(877, 270);
            this.dtgSanBay_QLSB.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Masb";
            this.Column1.HeaderText = "Mã Sân Bay";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tensb";
            this.Column2.HeaderText = "Tên Sân Bay";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quocgia";
            this.Column3.HeaderText = "Quốc gia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quốc gia:";
            // 
            // txtQuocGia_QLSB
            // 
            this.txtQuocGia_QLSB.Location = new System.Drawing.Point(300, 265);
            this.txtQuocGia_QLSB.Name = "txtQuocGia_QLSB";
            this.txtQuocGia_QLSB.Size = new System.Drawing.Size(295, 22);
            this.txtQuocGia_QLSB.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDiaChi_QLSB
            // 
            this.txtDiaChi_QLSB.Location = new System.Drawing.Point(300, 315);
            this.txtDiaChi_QLSB.Name = "txtDiaChi_QLSB";
            this.txtDiaChi_QLSB.Size = new System.Drawing.Size(295, 22);
            this.txtDiaChi_QLSB.TabIndex = 51;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FlightManagement.Properties.Resources.icons8_airplane_take_off_100__2_;
            this.pictureBox3.Location = new System.Drawing.Point(743, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 134);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlightManagement.Properties.Resources.icons8_paper_plane_64;
            this.pictureBox2.Location = new System.Drawing.Point(935, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 79);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.ảnh_phi_công;
            this.pictureBox1.Location = new System.Drawing.Point(1047, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnSua_QLSB
            // 
            this.btnSua_QLSB.ActiveBorderThickness = 1;
            this.btnSua_QLSB.ActiveCornerRadius = 20;
            this.btnSua_QLSB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua_QLSB.ActiveForecolor = System.Drawing.Color.White;
            this.btnSua_QLSB.ActiveLineColor = System.Drawing.Color.White;
            this.btnSua_QLSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua_QLSB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua_QLSB.BackgroundImage")));
            this.btnSua_QLSB.ButtonText = "Sửa";
            this.btnSua_QLSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua_QLSB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_QLSB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua_QLSB.IdleBorderThickness = 3;
            this.btnSua_QLSB.IdleCornerRadius = 20;
            this.btnSua_QLSB.IdleFillColor = System.Drawing.Color.White;
            this.btnSua_QLSB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnSua_QLSB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua_QLSB.Location = new System.Drawing.Point(777, 390);
            this.btnSua_QLSB.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua_QLSB.Name = "btnSua_QLSB";
            this.btnSua_QLSB.Size = new System.Drawing.Size(247, 55);
            this.btnSua_QLSB.TabIndex = 43;
            this.btnSua_QLSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua_QLSB.Click += new System.EventHandler(this.btnSua_QLSB_Click);
            // 
            // btnXoa_QLSB
            // 
            this.btnXoa_QLSB.ActiveBorderThickness = 1;
            this.btnXoa_QLSB.ActiveCornerRadius = 20;
            this.btnXoa_QLSB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa_QLSB.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa_QLSB.ActiveLineColor = System.Drawing.Color.White;
            this.btnXoa_QLSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa_QLSB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa_QLSB.BackgroundImage")));
            this.btnXoa_QLSB.ButtonText = "Xóa";
            this.btnXoa_QLSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa_QLSB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_QLSB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXoa_QLSB.IdleBorderThickness = 3;
            this.btnXoa_QLSB.IdleCornerRadius = 20;
            this.btnXoa_QLSB.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa_QLSB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa_QLSB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa_QLSB.Location = new System.Drawing.Point(472, 390);
            this.btnXoa_QLSB.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa_QLSB.Name = "btnXoa_QLSB";
            this.btnXoa_QLSB.Size = new System.Drawing.Size(247, 55);
            this.btnXoa_QLSB.TabIndex = 42;
            this.btnXoa_QLSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa_QLSB.Click += new System.EventHandler(this.btnXoa_QLSB_Click);
            // 
            // btnThem_QLSB
            // 
            this.btnThem_QLSB.ActiveBorderThickness = 1;
            this.btnThem_QLSB.ActiveCornerRadius = 20;
            this.btnThem_QLSB.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem_QLSB.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem_QLSB.ActiveLineColor = System.Drawing.Color.White;
            this.btnThem_QLSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem_QLSB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem_QLSB.BackgroundImage")));
            this.btnThem_QLSB.ButtonText = "Thêm";
            this.btnThem_QLSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem_QLSB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_QLSB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem_QLSB.IdleBorderThickness = 3;
            this.btnThem_QLSB.IdleCornerRadius = 20;
            this.btnThem_QLSB.IdleFillColor = System.Drawing.Color.White;
            this.btnThem_QLSB.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnThem_QLSB.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem_QLSB.Location = new System.Drawing.Point(164, 390);
            this.btnThem_QLSB.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem_QLSB.Name = "btnThem_QLSB";
            this.btnThem_QLSB.Size = new System.Drawing.Size(247, 55);
            this.btnThem_QLSB.TabIndex = 41;
            this.btnThem_QLSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem_QLSB.Click += new System.EventHandler(this.btnThem_QLSB_Click);
            // 
            // btnClose_changepassword
            // 
            this.btnClose_changepassword.FlatAppearance.BorderSize = 0;
            this.btnClose_changepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_changepassword.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_changepassword.Location = new System.Drawing.Point(0, 1);
            this.btnClose_changepassword.Name = "btnClose_changepassword";
            this.btnClose_changepassword.Size = new System.Drawing.Size(37, 37);
            this.btnClose_changepassword.TabIndex = 24;
            this.btnClose_changepassword.UseVisualStyleBackColor = true;
            this.btnClose_changepassword.Click += new System.EventHandler(this.btnClose_changepassword_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::FlightManagement.Properties.Resources.icons8_zalo_100;
            this.button10.Location = new System.Drawing.Point(135, 992);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 23);
            this.button10.TabIndex = 55;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::FlightManagement.Properties.Resources.icons8_facebook_128;
            this.button8.Location = new System.Drawing.Point(84, 992);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 54;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::FlightManagement.Properties.Resources.icons8_instagram_64;
            this.button4.Location = new System.Drawing.Point(34, 992);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 53;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // errorMaSB
            // 
            this.errorMaSB.ContainerControl = this;
            // 
            // QLSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 1058);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi_QLSB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuocGia_QLSB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgSanBay_QLSB);
            this.Controls.Add(this.btnSua_QLSB);
            this.Controls.Add(this.btnXoa_QLSB);
            this.Controls.Add(this.btnThem_QLSB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSB_QLSB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSB_QLSB);
            this.Controls.Add(this.btnClose_changepassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLSanBay";
            this.Text = "QLSanBay";
            this.Load += new System.EventHandler(this.QLSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanBay_QLSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose_changepassword;
        private System.Windows.Forms.TextBox txtMaSB_QLSB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSB_QLSB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua_QLSB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa_QLSB;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem_QLSB;
        private System.Windows.Forms.DataGridView dtgSanBay_QLSB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuocGia_QLSB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi_QLSB;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorMaSB;
    }
}