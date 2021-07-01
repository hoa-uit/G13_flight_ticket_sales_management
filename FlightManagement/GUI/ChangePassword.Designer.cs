namespace FlightManagement
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKC_DMK = new System.Windows.Forms.TextBox();
            this.txtXNMK_DMK = new System.Windows.Forms.TextBox();
            this.txtMKM_DMK = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTieuDe_DMK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMXN_DMK = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLayMa_DMK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLuu_DMK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_changepassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // txtMKC_DMK
            // 
            this.txtMKC_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMKC_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKC_DMK.Location = new System.Drawing.Point(314, 152);
            this.txtMKC_DMK.Name = "txtMKC_DMK";
            this.txtMKC_DMK.Size = new System.Drawing.Size(203, 27);
            this.txtMKC_DMK.TabIndex = 8;
            this.txtMKC_DMK.TextChanged += new System.EventHandler(this.txtUserName_login_TextChanged);
            // 
            // txtXNMK_DMK
            // 
            this.txtXNMK_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtXNMK_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXNMK_DMK.Location = new System.Drawing.Point(314, 266);
            this.txtXNMK_DMK.Name = "txtXNMK_DMK";
            this.txtXNMK_DMK.Size = new System.Drawing.Size(203, 27);
            this.txtXNMK_DMK.TabIndex = 9;
            this.txtXNMK_DMK.TextChanged += new System.EventHandler(this.txtConfirmPassword_changepassword_TextChanged);
            // 
            // txtMKM_DMK
            // 
            this.txtMKM_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMKM_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM_DMK.Location = new System.Drawing.Point(314, 208);
            this.txtMKM_DMK.Name = "txtMKM_DMK";
            this.txtMKM_DMK.Size = new System.Drawing.Size(203, 27);
            this.txtMKM_DMK.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lblTieuDe_DMK
            // 
            this.lblTieuDe_DMK.AutoSize = true;
            this.lblTieuDe_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTieuDe_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe_DMK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe_DMK.Location = new System.Drawing.Point(205, 67);
            this.lblTieuDe_DMK.Name = "lblTieuDe_DMK";
            this.lblTieuDe_DMK.Size = new System.Drawing.Size(227, 32);
            this.lblTieuDe_DMK.TabIndex = 23;
            this.lblTieuDe_DMK.Text = "ĐỔI MẬT KHẨU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã xác nhận:";
            // 
            // txtMXN_DMK
            // 
            this.txtMXN_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMXN_DMK.Location = new System.Drawing.Point(422, 381);
            this.txtMXN_DMK.Name = "txtMXN_DMK";
            this.txtMXN_DMK.Size = new System.Drawing.Size(123, 27);
            this.txtMXN_DMK.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblTieuDe_DMK);
            this.panel4.Controls.Add(this.txtMXN_DMK);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnLayMa_DMK);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMKM_DMK);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtXNMK_DMK);
            this.panel4.Controls.Add(this.btnLuu_DMK);
            this.panel4.Controls.Add(this.txtMKC_DMK);
            this.panel4.Location = new System.Drawing.Point(545, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 725);
            this.panel4.TabIndex = 27;
            // 
            // btnLayMa_DMK
            // 
            this.btnLayMa_DMK.ActiveBorderThickness = 1;
            this.btnLayMa_DMK.ActiveCornerRadius = 20;
            this.btnLayMa_DMK.ActiveFillColor = System.Drawing.Color.White;
            this.btnLayMa_DMK.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnLayMa_DMK.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnLayMa_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLayMa_DMK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayMa_DMK.BackgroundImage")));
            this.btnLayMa_DMK.ButtonText = "Lấy mã";
            this.btnLayMa_DMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLayMa_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayMa_DMK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLayMa_DMK.IdleBorderThickness = 3;
            this.btnLayMa_DMK.IdleCornerRadius = 20;
            this.btnLayMa_DMK.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLayMa_DMK.IdleForecolor = System.Drawing.Color.White;
            this.btnLayMa_DMK.IdleLineColor = System.Drawing.Color.White;
            this.btnLayMa_DMK.Location = new System.Drawing.Point(87, 358);
            this.btnLayMa_DMK.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnLayMa_DMK.Name = "btnLayMa_DMK";
            this.btnLayMa_DMK.Size = new System.Drawing.Size(182, 63);
            this.btnLayMa_DMK.TabIndex = 24;
            this.btnLayMa_DMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLayMa_DMK.Click += new System.EventHandler(this.btnSendcode_changepass_Click);
            // 
            // btnLuu_DMK
            // 
            this.btnLuu_DMK.ActiveBorderThickness = 1;
            this.btnLuu_DMK.ActiveCornerRadius = 20;
            this.btnLuu_DMK.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_DMK.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuu_DMK.ActiveLineColor = System.Drawing.Color.White;
            this.btnLuu_DMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLuu_DMK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu_DMK.BackgroundImage")));
            this.btnLuu_DMK.ButtonText = "Lưu";
            this.btnLuu_DMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu_DMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_DMK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu_DMK.IdleBorderThickness = 1;
            this.btnLuu_DMK.IdleCornerRadius = 20;
            this.btnLuu_DMK.IdleFillColor = System.Drawing.Color.White;
            this.btnLuu_DMK.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu_DMK.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu_DMK.Location = new System.Drawing.Point(181, 491);
            this.btnLuu_DMK.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu_DMK.Name = "btnLuu_DMK";
            this.btnLuu_DMK.Size = new System.Drawing.Size(299, 54);
            this.btnLuu_DMK.TabIndex = 6;
            this.btnLuu_DMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu_DMK.Click += new System.EventHandler(this.btnSave_changepassword_Click);
            // 
            // btnClose_changepassword
            // 
            this.btnClose_changepassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose_changepassword.FlatAppearance.BorderSize = 0;
            this.btnClose_changepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_changepassword.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_changepassword.Location = new System.Drawing.Point(1, 2);
            this.btnClose_changepassword.Name = "btnClose_changepassword";
            this.btnClose_changepassword.Size = new System.Drawing.Size(37, 37);
            this.btnClose_changepassword.TabIndex = 2;
            this.btnClose_changepassword.UseVisualStyleBackColor = false;
            this.btnClose_changepassword.Click += new System.EventHandler(this.btnClose_changepassword_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightManagement.Properties.Resources.backround_changepassw1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1479, 944);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnClose_changepassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu_DMK;
        private System.Windows.Forms.TextBox txtMKC_DMK;
        private System.Windows.Forms.TextBox txtXNMK_DMK;
        private System.Windows.Forms.TextBox txtMKM_DMK;
        private System.Windows.Forms.Button btnClose_changepassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblTieuDe_DMK;
        private System.Windows.Forms.TextBox txtMXN_DMK;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLayMa_DMK;
        private System.Windows.Forms.Panel panel4;
    }
}