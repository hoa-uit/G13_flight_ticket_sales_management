namespace FlightManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbkhac_login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowpass_login = new System.Windows.Forms.CheckBox();
            this.cbRemember_login = new System.Windows.Forms.CheckBox();
            this.lbForgotPassword_login = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPassword_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSNV_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnForgotPassword = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblogin_forgotpass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmpass_forgotpass = new System.Windows.Forms.TextBox();
            this.txtCode_forgotpass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSendCode_forgotpass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave_forgotpass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtManv_forgotpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword_forgotpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName_signup = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose_login = new System.Windows.Forms.Button();
            this.errorConfirmPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail_forgotpassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNewpass_forgotpassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorconfirm_forgotpassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnLogin.SuspendLayout();
            this.pnForgotPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail_forgotpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewpass_forgotpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorconfirm_forgotpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.White;
            this.pnLogin.Controls.Add(this.lbkhac_login);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.cbShowpass_login);
            this.pnLogin.Controls.Add(this.cbRemember_login);
            this.pnLogin.Controls.Add(this.lbForgotPassword_login);
            this.pnLogin.Controls.Add(this.panel3);
            this.pnLogin.Controls.Add(this.panel2);
            this.pnLogin.Controls.Add(this.button3);
            this.pnLogin.Controls.Add(this.txtPassword_login);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.txtMSNV_login);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Location = new System.Drawing.Point(430, 69);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(443, 527);
            this.pnLogin.TabIndex = 2;
            // 
            // lbkhac_login
            // 
            this.lbkhac_login.AutoSize = true;
            this.lbkhac_login.Location = new System.Drawing.Point(128, 445);
            this.lbkhac_login.Name = "lbkhac_login";
            this.lbkhac_login.Size = new System.Drawing.Size(192, 17);
            this.lbkhac_login.TabIndex = 14;
            this.lbkhac_login.Text = "Đăng nhập với tư cách khác?";
            this.lbkhac_login.Click += new System.EventHandler(this.lbkhac_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(94, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // cbShowpass_login
            // 
            this.cbShowpass_login.AutoSize = true;
            this.cbShowpass_login.Location = new System.Drawing.Point(113, 288);
            this.cbShowpass_login.Name = "cbShowpass_login";
            this.cbShowpass_login.Size = new System.Drawing.Size(129, 21);
            this.cbShowpass_login.TabIndex = 12;
            this.cbShowpass_login.Text = "Show Password";
            this.cbShowpass_login.UseVisualStyleBackColor = true;
            this.cbShowpass_login.CheckedChanged += new System.EventHandler(this.cbShowpass_login_CheckedChanged);
            // 
            // cbRemember_login
            // 
            this.cbRemember_login.AutoSize = true;
            this.cbRemember_login.Location = new System.Drawing.Point(113, 323);
            this.cbRemember_login.Name = "cbRemember_login";
            this.cbRemember_login.Size = new System.Drawing.Size(103, 21);
            this.cbRemember_login.TabIndex = 11;
            this.cbRemember_login.Text = "Rember me";
            this.cbRemember_login.UseVisualStyleBackColor = true;
            // 
            // lbForgotPassword_login
            // 
            this.lbForgotPassword_login.AutoSize = true;
            this.lbForgotPassword_login.Location = new System.Drawing.Point(164, 415);
            this.lbForgotPassword_login.Name = "lbForgotPassword_login";
            this.lbForgotPassword_login.Size = new System.Drawing.Size(114, 17);
            this.lbForgotPassword_login.TabIndex = 7;
            this.lbForgotPassword_login.Text = "Forget Password";
            this.lbForgotPassword_login.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(114, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(115, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(114, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPassword_login
            // 
            this.txtPassword_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_login.Location = new System.Drawing.Point(114, 238);
            this.txtPassword_login.Name = "txtPassword_login";
            this.txtPassword_login.Size = new System.Drawing.Size(219, 20);
            this.txtPassword_login.TabIndex = 3;
            this.txtPassword_login.TextChanged += new System.EventHandler(this.txtPassword_login_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(110, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // txtMSNV_login
            // 
            this.txtMSNV_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMSNV_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSNV_login.Location = new System.Drawing.Point(113, 151);
            this.txtMSNV_login.Name = "txtMSNV_login";
            this.txtMSNV_login.Size = new System.Drawing.Size(219, 20);
            this.txtMSNV_login.TabIndex = 1;
            this.txtMSNV_login.TextChanged += new System.EventHandler(this.txtUserName_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(110, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV:";
            // 
            // pnForgotPassword
            // 
            this.pnForgotPassword.BackColor = System.Drawing.SystemColors.Window;
            this.pnForgotPassword.Controls.Add(this.panel4);
            this.pnForgotPassword.Controls.Add(this.lblogin_forgotpass);
            this.pnForgotPassword.Controls.Add(this.label3);
            this.pnForgotPassword.Controls.Add(this.txtConfirmpass_forgotpass);
            this.pnForgotPassword.Controls.Add(this.txtCode_forgotpass);
            this.pnForgotPassword.Controls.Add(this.label15);
            this.pnForgotPassword.Controls.Add(this.btnSendCode_forgotpass);
            this.pnForgotPassword.Controls.Add(this.btnSave_forgotpass);
            this.pnForgotPassword.Controls.Add(this.panel8);
            this.pnForgotPassword.Controls.Add(this.panel7);
            this.pnForgotPassword.Controls.Add(this.panel6);
            this.pnForgotPassword.Controls.Add(this.txtManv_forgotpass);
            this.pnForgotPassword.Controls.Add(this.label7);
            this.pnForgotPassword.Controls.Add(this.txtPassword_forgotpass);
            this.pnForgotPassword.Controls.Add(this.label6);
            this.pnForgotPassword.Controls.Add(this.label5);
            this.pnForgotPassword.Controls.Add(this.txtLastName_signup);
            this.pnForgotPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnForgotPassword.Location = new System.Drawing.Point(430, 69);
            this.pnForgotPassword.Name = "pnForgotPassword";
            this.pnForgotPassword.Size = new System.Drawing.Size(442, 530);
            this.pnForgotPassword.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(211, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 1);
            this.panel4.TabIndex = 15;
            // 
            // lblogin_forgotpass
            // 
            this.lblogin_forgotpass.AutoSize = true;
            this.lblogin_forgotpass.Location = new System.Drawing.Point(210, 462);
            this.lblogin_forgotpass.Name = "lblogin_forgotpass";
            this.lblogin_forgotpass.Size = new System.Drawing.Size(43, 17);
            this.lblogin_forgotpass.TabIndex = 28;
            this.lblogin_forgotpass.Text = "Login";
            this.lblogin_forgotpass.Click += new System.EventHandler(this.lblogin_forgotpass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(135, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "FORGOT PASSWORD";
            // 
            // txtConfirmpass_forgotpass
            // 
            this.txtConfirmpass_forgotpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmpass_forgotpass.Location = new System.Drawing.Point(192, 265);
            this.txtConfirmpass_forgotpass.Name = "txtConfirmpass_forgotpass";
            this.txtConfirmpass_forgotpass.PasswordChar = '*';
            this.txtConfirmpass_forgotpass.Size = new System.Drawing.Size(219, 15);
            this.txtConfirmpass_forgotpass.TabIndex = 26;
            this.txtConfirmpass_forgotpass.TextChanged += new System.EventHandler(this.txtConfirmpass_signup_TextChanged_1);
            // 
            // txtCode_forgotpass
            // 
            this.txtCode_forgotpass.Location = new System.Drawing.Point(279, 325);
            this.txtCode_forgotpass.Name = "txtCode_forgotpass";
            this.txtCode_forgotpass.Size = new System.Drawing.Size(130, 22);
            this.txtCode_forgotpass.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(175, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Your code:";
            // 
            // btnSendCode_forgotpass
            // 
            this.btnSendCode_forgotpass.ActiveBorderThickness = 1;
            this.btnSendCode_forgotpass.ActiveCornerRadius = 20;
            this.btnSendCode_forgotpass.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSendCode_forgotpass.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendCode_forgotpass.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSendCode_forgotpass.BackColor = System.Drawing.SystemColors.Window;
            this.btnSendCode_forgotpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendCode_forgotpass.BackgroundImage")));
            this.btnSendCode_forgotpass.ButtonText = "Send code";
            this.btnSendCode_forgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode_forgotpass.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode_forgotpass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSendCode_forgotpass.IdleBorderThickness = 1;
            this.btnSendCode_forgotpass.IdleCornerRadius = 20;
            this.btnSendCode_forgotpass.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btnSendCode_forgotpass.IdleForecolor = System.Drawing.Color.White;
            this.btnSendCode_forgotpass.IdleLineColor = System.Drawing.Color.White;
            this.btnSendCode_forgotpass.Location = new System.Drawing.Point(54, 318);
            this.btnSendCode_forgotpass.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnSendCode_forgotpass.Name = "btnSendCode_forgotpass";
            this.btnSendCode_forgotpass.Size = new System.Drawing.Size(97, 45);
            this.btnSendCode_forgotpass.TabIndex = 23;
            this.btnSendCode_forgotpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendCode_forgotpass.Click += new System.EventHandler(this.btnSendCode_forgotpass_Click);
            // 
            // btnSave_forgotpass
            // 
            this.btnSave_forgotpass.ActiveBorderThickness = 1;
            this.btnSave_forgotpass.ActiveCornerRadius = 20;
            this.btnSave_forgotpass.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnSave_forgotpass.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnSave_forgotpass.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave_forgotpass.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave_forgotpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave_forgotpass.BackgroundImage")));
            this.btnSave_forgotpass.ButtonText = "Save";
            this.btnSave_forgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave_forgotpass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_forgotpass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave_forgotpass.IdleBorderThickness = 3;
            this.btnSave_forgotpass.IdleCornerRadius = 20;
            this.btnSave_forgotpass.IdleFillColor = System.Drawing.Color.White;
            this.btnSave_forgotpass.IdleForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave_forgotpass.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave_forgotpass.Location = new System.Drawing.Point(51, 395);
            this.btnSave_forgotpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave_forgotpass.Name = "btnSave_forgotpass";
            this.btnSave_forgotpass.Size = new System.Drawing.Size(359, 56);
            this.btnSave_forgotpass.TabIndex = 15;
            this.btnSave_forgotpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave_forgotpass.Click += new System.EventHandler(this.btnSave_forgotpass_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel8.Location = new System.Drawing.Point(192, 281);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 1);
            this.panel8.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Location = new System.Drawing.Point(192, 219);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 1);
            this.panel7.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(192, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 1);
            this.panel6.TabIndex = 14;
            // 
            // txtManv_forgotpass
            // 
            this.txtManv_forgotpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManv_forgotpass.Location = new System.Drawing.Point(190, 143);
            this.txtManv_forgotpass.Name = "txtManv_forgotpass";
            this.txtManv_forgotpass.Size = new System.Drawing.Size(219, 15);
            this.txtManv_forgotpass.TabIndex = 10;
            this.txtManv_forgotpass.TextChanged += new System.EventHandler(this.txtManv_forgotpass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(89, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "MSNV:";
            // 
            // txtPassword_forgotpass
            // 
            this.txtPassword_forgotpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_forgotpass.Location = new System.Drawing.Point(192, 202);
            this.txtPassword_forgotpass.Name = "txtPassword_forgotpass";
            this.txtPassword_forgotpass.PasswordChar = '*';
            this.txtPassword_forgotpass.Size = new System.Drawing.Size(219, 15);
            this.txtPassword_forgotpass.TabIndex = 8;
            this.txtPassword_forgotpass.TextChanged += new System.EventHandler(this.txtPassword_forgotpass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(73, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(47, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comfirm pass:";
            // 
            // txtLastName_signup
            // 
            this.txtLastName_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName_signup.Location = new System.Drawing.Point(192, 137);
            this.txtLastName_signup.Name = "txtLastName_signup";
            this.txtLastName_signup.Size = new System.Drawing.Size(219, 15);
            this.txtLastName_signup.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 652);
            this.panel1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(199, 611);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Develope by group 13 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(239, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 35);
            this.label11.TabIndex = 3;
            this.label11.Text = "System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(120, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 35);
            this.label10.TabIndex = 2;
            this.label10.Text = "Service Mangement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(166, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 35);
            this.label9.TabIndex = 1;
            this.label9.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagement.Properties.Resources.icons8_airplane_take_off_100;
            this.pictureBox1.Location = new System.Drawing.Point(96, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 611);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Support: contact me 037189967";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // btnClose_login
            // 
            this.btnClose_login.FlatAppearance.BorderSize = 0;
            this.btnClose_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_login.Image = global::FlightManagement.Properties.Resources.close;
            this.btnClose_login.Location = new System.Drawing.Point(926, 12);
            this.btnClose_login.Name = "btnClose_login";
            this.btnClose_login.Size = new System.Drawing.Size(34, 25);
            this.btnClose_login.TabIndex = 10;
            this.btnClose_login.UseVisualStyleBackColor = true;
            this.btnClose_login.Click += new System.EventHandler(this.btnClose_login_Click);
            // 
            // errorConfirmPass
            // 
            this.errorConfirmPass.ContainerControl = this;
            // 
            // errorEmail_forgotpassword
            // 
            this.errorEmail_forgotpassword.ContainerControl = this;
            // 
            // errorNewpass_forgotpassword
            // 
            this.errorNewpass_forgotpassword.ContainerControl = this;
            // 
            // errorconfirm_forgotpassword
            // 
            this.errorconfirm_forgotpassword.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 652);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose_login);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnForgotPassword.ResumeLayout(false);
            this.pnForgotPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail_forgotpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewpass_forgotpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorconfirm_forgotpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Panel pnForgotPassword;
        private System.Windows.Forms.TextBox txtManv_forgotpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword_forgotpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName_signup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPassword_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSNV_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave_forgotpass;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider errorConfirmPass;
        private System.Windows.Forms.Label lbForgotPassword_login;
        private System.Windows.Forms.TextBox txtCode_forgotpass;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendCode_forgotpass;
        private System.Windows.Forms.TextBox txtConfirmpass_forgotpass;
        private System.Windows.Forms.ErrorProvider errorEmail_forgotpassword;
        private System.Windows.Forms.ErrorProvider errorNewpass_forgotpassword;
        private System.Windows.Forms.ErrorProvider errorconfirm_forgotpassword;
        private System.Windows.Forms.CheckBox cbRemember_login;
        private System.Windows.Forms.CheckBox cbShowpass_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblogin_forgotpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbkhac_login;
    }
}

