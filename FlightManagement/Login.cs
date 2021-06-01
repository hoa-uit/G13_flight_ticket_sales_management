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
              pnLogin.BringToFront();
        }


        private void label14_Click_1(object sender, EventArgs e)
        {
           
            pnForgotPassword.BringToFront();
        }

        private void btnClose_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword_login.UseSystemPasswordChar = true;
            txtPassword_login.Text = Properties.Settings.Default.Password;
            txtMSNV_login.Text = Properties.Settings.Default.Msnv;
        }
        private void lblogin_forgotpass_Click(object sender, EventArgs e)
        {
            pnLogin.BringToFront();
        }

        private void lbkhac_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flight_Management.Quyen = "Custommer";
            Flight_Management.UserName = "Custommer";
            Flight_Management fm = new Flight_Management();
            fm.Show();
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
               
                string Msnv = txtMSNV_login.Text;
                string Password = txtPassword_login.Text;
               

                int a = CheckLogin.Instance.Check_Login(Msnv, Password);
                


                if (a > 0)
                {

                    // có tài khoản và đăng nhập thành công
                    Flight_Management.Quyen = DataProvider.Instance.ExecuteQuery("EXEC LAYQUYEN " + Msnv ).Rows[0][0].ToString();
                    Flight_Management.UserName = DataProvider.Instance.ExecuteQuery("EXEC LAYTENNV " + Msnv).Rows[0][0].ToString();
                    Flight_Management.MaNV = txtMSNV_login.Text;
                    this.Hide();
                    Flight_Management frm = new Flight_Management();
                    frm.Show();

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
            if (string.IsNullOrEmpty(txtPassword_login.Text))
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

            if (string.IsNullOrEmpty(txtMSNV_login.Text))
            {
                error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error1.SetError(txtMSNV_login, "Please enter your username.");
            }
            else
            {
                error1.SetError(txtMSNV_login, "");
            }
        }

        private void cbShowpass_login_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpass_login.Checked)
            {
                txtPassword_login.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword_login.UseSystemPasswordChar = true;
            }
        }


        #endregion


        #region xử lý phần quên mật khẩu
        private void btnSendCode_forgotpass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv_forgotpass.Text) || string.IsNullOrEmpty(txtPassword_forgotpass.Text) || string.IsNullOrEmpty(txtConfirmpass_forgotpass.Text))
            {
                if (string.IsNullOrEmpty(txtManv_forgotpass.Text) && string.IsNullOrEmpty(txtPassword_forgotpass.Text) && string.IsNullOrEmpty(txtConfirmpass_forgotpass.Text))
                {
                    errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorEmail_forgotpassword.SetError(txtManv_forgotpass, "Please enter your email");
                    errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorNewpass_forgotpassword.SetError(txtPassword_forgotpass, "please enter your password");
                    errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorconfirm_forgotpassword.SetError(txtConfirmpass_forgotpass, "please enter your confirm");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtManv_forgotpass.Text))
                    {
                        errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorEmail_forgotpassword.SetError(txtManv_forgotpass, "Please enter your email");
                    }
                    if (string.IsNullOrEmpty(txtPassword_forgotpass.Text))
                    {
                        errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorNewpass_forgotpassword.SetError(txtPassword_forgotpass, "please enter your password");
                    }
                    if (string.IsNullOrEmpty(txtConfirmpass_forgotpass.Text))
                    {
                        errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorconfirm_forgotpassword.SetError(txtConfirmpass_forgotpass, "please enter your confirm");
                    }
                }

            }
            else if (txtPassword_forgotpass.Text != txtConfirmpass_forgotpass.Text)
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtConfirmpass_forgotpass, "Your confirm password is incorrect !");
            }
            else
            {
                int flag = 0;
                List<string> dsaccount = GetListMaNV.Instance.ListMSNV_Account();
                string msnv = txtManv_forgotpass.Text;
                foreach (string item in dsaccount)
                {
                    if (item == msnv)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Xin chờ trong giây lát");
                    string to = (txtManv_forgotpass.Text).ToString() + "@gm.uit.edu.vn";
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
                    MessageBox.Show("MSNV is incorrect");
                }

            }

        }

        private void btnSave_forgotpass_Click(object sender, EventArgs e)
        {
            if (txtCode_forgotpass.Text == randomcode_forgotpassword)
            {
                // lưu lại pass mới 
                string newpass = txtPassword_forgotpass.Text;
                string Msnv = txtManv_forgotpass.Text;
                string query = string.Format("UPDATE TAIKHOANDANHNHAP SET Matkhau = '{0}' WHERE MaNhanVien = '{1}' ", newpass, Msnv);
                int a = DataProvider.Instance.ExecuteNonQuery(query);
                if (a > 0)
                {
                    Flight_Management.UserName = DataProvider.Instance.ExecuteQuery("EXEC LAYTENNV " + Msnv).Rows[0][0].ToString();
                    Flight_Management.Quyen = DataProvider.Instance.ExecuteQuery("EXEC LAYQUYEN " + Msnv).Rows[0][0].ToString();
                    Flight_Management.MaNV = txtManv_forgotpass.Text;
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

        private void txtManv_forgotpass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv_forgotpass.Text))
            {

                errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorEmail_forgotpassword.SetError(txtManv_forgotpass, "Please enter your email");
            }
            else
            {
                errorEmail_forgotpassword.SetError(txtManv_forgotpass, "");
            }
        }

        private void txtPassword_forgotpass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword_forgotpass.Text))
            {
                errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNewpass_forgotpassword.SetError(txtPassword_forgotpass, "please enter your password");
            }
            else
            {
                errorNewpass_forgotpassword.SetError(txtPassword_forgotpass, "");
            }
        }
        private void txtConfirmpass_signup_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmpass_forgotpass.Text))
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtConfirmpass_forgotpass, "please enter your confirm");
            }
            else
            {
                errorconfirm_forgotpassword.SetError(txtConfirmpass_forgotpass, "");
            }
        }

        #endregion

       
    }
}
