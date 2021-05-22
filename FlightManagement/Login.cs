using FlightManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement
{
    public partial class Login : Form
    {
        public static string randomcode_createaccount;
        public static string randomcode_forgotpassword;
        public static string msnv;
        public static string mk;
        public Login()
        {
            InitializeComponent();
            CustommerDesign();
        }

        private void CustommerDesign()
        {
            pnSide2.Visible = true;
            pnSide3.Visible = false;
            pnLogin.BringToFront();
        }
        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            pnSide2.Visible = true;
            pnSide3.Visible = false;
     
            pnLogin.BringToFront();
        }

        private void btnSignup_login_Click(object sender, EventArgs e)
        {
            pnSide2.Visible = false;
            pnSide3.Visible = true;
     
            pnSignup.BringToFront();
        }

        private void label14_Click_1(object sender, EventArgs e)
        {
            pnSide2.Visible = false;
            pnSide3.Visible = false;
            pnForgotPassword.BringToFront();
        }

        private void btnClose_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword_login.Text = Properties.Settings.Default.Password;
            txtMSNV_login.Text = Properties.Settings.Default.Msnv;
        }

        #region xử lý phần nhấn nút đăng nhập
        private void button3_Click(object sender, EventArgs e)
        {
            if (cbRemember_login.Checked)
            {
                Properties.Settings.Default.Msnv = txtMSNV_login.Text;
                Properties.Settings.Default.Password = txtPassword_login.Text;
                Properties.Settings.Default.Save();
            }    
            if (string.IsNullOrEmpty(txtMSNV_login.Text) || string.IsNullOrEmpty(txtPassword_login.Text))
            {
                if (string.IsNullOrEmpty(txtMSNV_login.Text) && string.IsNullOrEmpty(txtPassword_login.Text))
                {
                    error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error1.SetError(txtMSNV_login, "please enter your username");
                    error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error2.SetError(txtPassword_login, "please enter your password");
                }
                else if (string.IsNullOrEmpty(txtMSNV_login.Text))
                {
                    error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error1.SetError(txtMSNV_login, "please enter your username");
                }
                else if (string.IsNullOrEmpty(txtPassword_login.Text))
                {
                    error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error2.SetError(txtPassword_login, "please enter your password");
                }    
            }    
            else
            {
                string Youremail = txtMSNV_login.Text;
                string Password = txtPassword_login.Text;
               

                int a = CheckLogin.Instance.Check_Login(Youremail, Password);


                if (a > 0)
                {

                    // có tài khoản và đăng nhập thành công
                    Flight_Management.quyen = DataProvider.Instance.ExecuteQuery("EXEC GETQUYEN " + Youremail + "," + Password).Rows[0][0].ToString();
                    Flight_Management.UserName = txtMSNV_login.Text;
                    this.Hide();
                    Flight_Management frm = new Flight_Management();
                    frm.ShowDialog();

                }
                else
                {
                    // đăng nhập không thành công
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword_login.Text = "";
                    txtMSNV_login.Text = "";
                }
            }     
           
        }
        private void txtPassword_login_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword_login.Text == "" || txtPassword_login.Text == null)
            {
                error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error2.SetError(txtPassword_login, "Please enter your username.");
            }
            else
            {
                error2.SetError(txtPassword_login, "");
            }
        }

        private void txtUserName_login_TextChanged(object sender, EventArgs e)
        {

            if (txtMSNV_login.Text == "" || txtMSNV_login.Text == null)
            {
                error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error1.SetError(txtMSNV_login, "Please enter your username.");
            }
            else
            {
                error1.SetError(txtMSNV_login, "");
            }
        }

        #endregion


        #region xử lý phần nhấn nút đăng kí

        private void btnSendCode_singup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFristName_signup.Text) || string.IsNullOrEmpty(txtLastName_signup.Text) || string.IsNullOrEmpty(txtUserName_signup.Text)
               || string.IsNullOrEmpty(txtPassword_signup.Text) || string.IsNullOrEmpty(txtConfirmpass_signup.Text) || cbChucVu_signup.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter full your information", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword_signup.Text != txtConfirmpass_signup.Text)
            {
                errorConfirmPass.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorConfirmPass.SetError(txtConfirmpass_signup, "error password");
            }
            else
            {
                int flag = 0;
                List<string> dsaccount = GetListMSNV.Instance.ListMSNV_Account();
                string msnv = txtUserName_signup.Text;
                foreach (string item in dsaccount)
                {
                    if (item == msnv)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    string to = (txtUserName_signup.Text).ToString() + "@gm.uit.edu.vn";
                    Random rand = new Random();
                    randomcode_createaccount = (rand.Next(999999)).ToString();
                    int x = SendCode.Instance.SendMail(to, randomcode_createaccount);
                    if (x == 1)
                    {
                        MessageBox.Show("Send code successfully!");
                    }
                    else if (x == 0)
                    {
                        MessageBox.Show("Send code successfully! Please check your email.");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!","Invalid",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
        }
        private void btnRegister_signup_Click_1(object sender, EventArgs e)
        {
           if (randomcode_createaccount == txtCode_signup.Text)
            {
                string fristname = txtFristName_signup.Text;
                string lastname = txtLastName_signup.Text;
                string username = txtUserName_signup.Text;
                string password = txtPassword_signup.Text;
                string confirmpass = txtConfirmpass_signup.Text;
                string chucvu = cbChucVu_signup.SelectedItem.ToString();
                string query = string.Format("INSERT INTO ACCOUNT VALUES (N'{0}', N'{1}', '{2}' ,'{3}','{4}')", fristname, lastname, username, password, chucvu);
                int a = DataProvider.Instance.ExecuteNonQuery(query);

                if (a > 0)
                {
                    Flight_Management.UserName = fristname + " " + lastname;
                    Flight_Management.quyen = cbChucVu_signup.SelectedItem.ToString();
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
                Flight_Management f2 = new Flight_Management();
                f2.ShowDialog();
            }
           else
            {
                error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error1.SetError(txtCode_signup, "Your code is incorrect!");
            }    
               
             
           
        }

        private void txtConfirmPass_signup_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmpass_signup.Text == "" || txtConfirmpass_signup.Text == null)
            {
                errorConfirmPass.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorConfirmPass.SetError(txtConfirmpass_signup, "Please enter your username.");
            }
            else
            {
                errorConfirmPass.SetError(txtConfirmpass_signup, "");
            }
        }

       


        #endregion


        #region xử lý phần nhấn nút save trong forgotpassword
        private void btnSendCode_forgotpassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSNV_signup.Text) || string.IsNullOrEmpty(txtNewPassWord_forgotpassword.Text) || string.IsNullOrEmpty(txtConfirmPassword_forgotpassword.Text))
            {
                if (string.IsNullOrEmpty(txtMSNV_signup.Text) && string.IsNullOrEmpty(txtNewPassWord_forgotpassword.Text) && string.IsNullOrEmpty(txtConfirmPassword_forgotpassword.Text))
                {
                    errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorEmail_forgotpassword.SetError(txtMSNV_signup, "Please enter your email");
                    errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorNewpass_forgotpassword.SetError(txtNewPassWord_forgotpassword, "please enter your password");
                    errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorconfirm_forgotpassword.SetError(txtConfirmPassword_forgotpassword, "please enter your confirm");
                }    
                else
                {
                    if (string.IsNullOrEmpty(txtMSNV_signup.Text))
                    {
                        errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorEmail_forgotpassword.SetError(txtMSNV_signup, "Please enter your email");
                    }    
                    if (string.IsNullOrEmpty(txtNewPassWord_forgotpassword.Text))
                    {
                        errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorNewpass_forgotpassword.SetError(txtNewPassWord_forgotpassword, "please enter your password");
                    }    
                    if (string.IsNullOrEmpty(txtConfirmPassword_forgotpassword.Text))
                    {
                        errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorconfirm_forgotpassword.SetError(txtConfirmPassword_forgotpassword, "please enter your confirm");
                    }
                }    

            }   
            else if (txtNewPassWord_forgotpassword.Text != txtConfirmPassword_forgotpassword.Text)
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtConfirmPassword_forgotpassword, "Your confirm password is incorrect !");
            }   
            else 
            {
                int flag = 0;
                List<string> dsaccount = GetListMSNV.Instance.ListMSNV_Account();
                string msnv = txtMSNV_signup.Text;
                foreach ( string item in dsaccount)
                {
                    if (item == msnv)
                    {
                        flag = 1;
                    }    
                }    
                if (flag == 1)
                {
                  
                    string to = (txtMSNV_signup.Text).ToString()+ "@gm.uit.edu.vn";
                    Random rand = new Random();
                    randomcode_forgotpassword = (rand.Next(999999)).ToString();
                    int x = SendCode.Instance.SendMail(to, randomcode_forgotpassword);
                    if (x == 1)
                    {
                        MessageBox.Show("Send code thành công");
                    }
                    else if (x == 0)
                    {
                        MessageBox.Show("không thành công");
                    }
                }    
                else
                {
                    MessageBox.Show("Your account is not exist");
                }    
               
            }    
           
        }

        private void txtEmail_forgotpassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSNV_signup.Text))
            {

                errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorEmail_forgotpassword.SetError(txtMSNV_signup, "Please enter your email");
            }    
            else
            {
                errorEmail_forgotpassword.SetError(txtMSNV_signup, "");
            }    
        }

        private void txtNewPassWord_forgotpassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassWord_forgotpassword.Text))
            {
                errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNewpass_forgotpassword.SetError(txtNewPassWord_forgotpassword, "please enter your password");
            }   
            else
            {
                errorNewpass_forgotpassword.SetError(txtNewPassWord_forgotpassword, "");
            }    
        }

        private void txtConfirmPassword_forgotpassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword_forgotpassword.Text))
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtConfirmPassword_forgotpassword, "please enter your confirm");
            }    
            else
            {
                errorconfirm_forgotpassword.SetError(txtConfirmPassword_forgotpassword, "");
            }    
        }

        private void btnSave_forgotpassword_Click(object sender, EventArgs e)
        {
            if (txtCode_forgotpassword.Text == randomcode_forgotpassword)
            {
                // lưu lại pass mới 
                string newpass = txtNewPassWord_forgotpassword.Text;
                string email = txtMSNV_signup.Text;
                string query = string.Format("UPDATE ACCOUNT SET PASS = '{0}' WHERE EMAIL = '{1}' ", newpass, email);
                int a = DataProvider.Instance.ExecuteNonQuery(query);
                if (a > 0)
                {
                    Flight_Management.UserName = txtMSNV_signup.Text;
                    Flight_Management.quyen = DataProvider.Instance.ExecuteQuery("EXEC GETQUYEN " + email + "," + newpass).Rows[0][0].ToString();
                    MessageBox.Show("Reset password successfully");
                    this.Hide();
                    Flight_Management fm = new Flight_Management();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Reset password unsuccessfully");
                }

            }
            else
            {
                MessageBox.Show("Your code is not correct");
            }

        }



        #endregion

       
    }
}
