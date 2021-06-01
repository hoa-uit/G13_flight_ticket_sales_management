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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPassword_changepassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword_changepassword = new System.Windows.Forms.TextBox();
            this.txtNewpassword_changepassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode_changepass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendcode_changepass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_changepassword = new System.Windows.Forms.Button();
            this.btnSave_changepassword = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(425, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(425, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(425, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 2);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old Password: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = " New Password: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = " Conform Password: ";
            // 
            // txtOldPassword_changepassword
            // 
            this.txtOldPassword_changepassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPassword_changepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword_changepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword_changepassword.Location = new System.Drawing.Point(425, 162);
            this.txtOldPassword_changepassword.Name = "txtOldPassword_changepassword";
            this.txtOldPassword_changepassword.Size = new System.Drawing.Size(228, 20);
            this.txtOldPassword_changepassword.TabIndex = 8;
            this.txtOldPassword_changepassword.TextChanged += new System.EventHandler(this.txtUserName_login_TextChanged);
            // 
            // txtConfirmPassword_changepassword
            // 
            this.txtConfirmPassword_changepassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPassword_changepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword_changepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword_changepassword.Location = new System.Drawing.Point(425, 276);
            this.txtConfirmPassword_changepassword.Name = "txtConfirmPassword_changepassword";
            this.txtConfirmPassword_changepassword.Size = new System.Drawing.Size(228, 20);
            this.txtConfirmPassword_changepassword.TabIndex = 9;
            this.txtConfirmPassword_changepassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_changepassword_TextChanged);
            // 
            // txtNewpassword_changepassword
            // 
            this.txtNewpassword_changepassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewpassword_changepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewpassword_changepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpassword_changepassword.Location = new System.Drawing.Point(425, 218);
            this.txtNewpassword_changepassword.Name = "txtNewpassword_changepassword";
            this.txtNewpassword_changepassword.Size = new System.Drawing.Size(228, 20);
            this.txtNewpassword_changepassword.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(264, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "CHANGE PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Code:";
            // 
            // txtCode_changepass
            // 
            this.txtCode_changepass.Location = new System.Drawing.Point(500, 352);
            this.txtCode_changepass.Name = "txtCode_changepass";
            this.txtCode_changepass.Size = new System.Drawing.Size(153, 22);
            this.txtCode_changepass.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.cherry_happy_to_flight;
            this.pictureBox1.Location = new System.Drawing.Point(878, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendcode_changepass
            // 
            this.btnSendcode_changepass.ActiveBorderThickness = 1;
            this.btnSendcode_changepass.ActiveCornerRadius = 20;
            this.btnSendcode_changepass.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSendcode_changepass.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendcode_changepass.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSendcode_changepass.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendcode_changepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendcode_changepass.BackgroundImage")));
            this.btnSendcode_changepass.ButtonText = "Send code";
            this.btnSendcode_changepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendcode_changepass.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendcode_changepass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendcode_changepass.IdleBorderThickness = 3;
            this.btnSendcode_changepass.IdleCornerRadius = 20;
            this.btnSendcode_changepass.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendcode_changepass.IdleForecolor = System.Drawing.Color.White;
            this.btnSendcode_changepass.IdleLineColor = System.Drawing.Color.White;
            this.btnSendcode_changepass.Location = new System.Drawing.Point(227, 333);
            this.btnSendcode_changepass.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSendcode_changepass.Name = "btnSendcode_changepass";
            this.btnSendcode_changepass.Size = new System.Drawing.Size(150, 52);
            this.btnSendcode_changepass.TabIndex = 24;
            this.btnSendcode_changepass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendcode_changepass.Click += new System.EventHandler(this.btnSendcode_changepass_Click);
            // 
            // btnClose_changepassword
            // 
            this.btnClose_changepassword.FlatAppearance.BorderSize = 0;
            this.btnClose_changepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_changepassword.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_changepassword.Location = new System.Drawing.Point(1, 2);
            this.btnClose_changepassword.Name = "btnClose_changepassword";
            this.btnClose_changepassword.Size = new System.Drawing.Size(37, 37);
            this.btnClose_changepassword.TabIndex = 2;
            this.btnClose_changepassword.UseVisualStyleBackColor = true;
            this.btnClose_changepassword.Click += new System.EventHandler(this.btnClose_changepassword_Click);
            // 
            // btnSave_changepassword
            // 
            this.btnSave_changepassword.ActiveBorderThickness = 1;
            this.btnSave_changepassword.ActiveCornerRadius = 20;
            this.btnSave_changepassword.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave_changepassword.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave_changepassword.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSave_changepassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave_changepassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave_changepassword.BackgroundImage")));
            this.btnSave_changepassword.ButtonText = "Save";
            this.btnSave_changepassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave_changepassword.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_changepassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave_changepassword.IdleBorderThickness = 1;
            this.btnSave_changepassword.IdleCornerRadius = 20;
            this.btnSave_changepassword.IdleFillColor = System.Drawing.Color.White;
            this.btnSave_changepassword.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnSave_changepassword.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSave_changepassword.Location = new System.Drawing.Point(286, 416);
            this.btnSave_changepassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave_changepassword.Name = "btnSave_changepassword";
            this.btnSave_changepassword.Size = new System.Drawing.Size(304, 58);
            this.btnSave_changepassword.TabIndex = 6;
            this.btnSave_changepassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave_changepassword.Click += new System.EventHandler(this.btnSave_changepassword_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 772);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCode_changepass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSendcode_changepass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose_changepassword);
            this.Controls.Add(this.txtNewpassword_changepassword);
            this.Controls.Add(this.txtConfirmPassword_changepassword);
            this.Controls.Add(this.txtOldPassword_changepassword);
            this.Controls.Add(this.btnSave_changepassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave_changepassword;
        private System.Windows.Forms.TextBox txtOldPassword_changepassword;
        private System.Windows.Forms.TextBox txtConfirmPassword_changepassword;
        private System.Windows.Forms.TextBox txtNewpassword_changepassword;
        private System.Windows.Forms.Button btnClose_changepassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode_changepass;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendcode_changepass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}