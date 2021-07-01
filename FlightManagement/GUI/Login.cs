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


      

        private void btnClose_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            txtMK_DN.UseSystemPasswordChar = true;
            txtMK_DN.Text = Properties.Settings.Default.Password;
            txtMNV_DN.Text = Properties.Settings.Default.Msnv;
            if (!string.IsNullOrEmpty(txtMNV_DN.Text))
            {
                cbNMK_DN.Checked = true;
            }    
        }
       
       
        #region xử lý phần nhấn nút đăng nhập
        private void button3_Click(object sender, EventArgs e)
        {
            if (cbNMK_DN.Checked)
            {
                Properties.Settings.Default.Msnv = txtMNV_DN.Text;
                Properties.Settings.Default.Password = txtMK_DN.Text;
                Properties.Settings.Default.Save();
            }    
            else
            {
                Properties.Settings.Default.Msnv = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(txtMNV_DN.Text) || string.IsNullOrEmpty(txtMK_DN.Text))
            {
                if (string.IsNullOrEmpty(txtMNV_DN.Text) && string.IsNullOrEmpty(txtMK_DN.Text))
                {
                    error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error1.SetError(txtMNV_DN, "please enter your username");
                    error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error2.SetError(txtMK_DN, "please enter your password");
                }
                else if (string.IsNullOrEmpty(txtMNV_DN.Text))
                {
                    error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error1.SetError(txtMNV_DN, "please enter your username");
                }
                else if (string.IsNullOrEmpty(txtMK_DN.Text))
                {
                    error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    error2.SetError(txtMK_DN, "please enter your password");
                }    
            }    
            else
            {
               
                string Msnv = txtMNV_DN.Text;
                string Password = txtMK_DN.Text;
               

                int a = CheckLogin.Instance.Check_Login(Msnv, Password);
                


                if (a > 0)
                {

                    // có tài khoản và đăng nhập thành công
                    Flight_Management.Quyen = DataProvider.Instance.ExecuteQuery("EXEC LAYQUYEN " + Msnv ).Rows[0][0].ToString();
                    Flight_Management.UserName = DataProvider.Instance.ExecuteQuery("EXEC LAYTENNV " + Msnv).Rows[0][0].ToString();
                    Flight_Management.MaNV = txtMNV_DN.Text;
                    this.Hide();
                    Flight_Management frm = new Flight_Management();
                    frm.Show();

                }
                else
                {
                    // đăng nhập không thành công
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK_DN.Text = "";
                    txtMNV_DN.Text = "";
                }
            }     
           
        }
        private void txtPassword_login_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMK_DN.Text))
            {
                error2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error2.SetError(txtMK_DN, "Please enter your username.");
            }
            else
            {
                error2.SetError(txtMK_DN, "");
            }
        }

        private void txtUserName_login_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMNV_DN.Text))
            {
                error1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                error1.SetError(txtMNV_DN, "Please enter your username.");
            }
            else
            {
                error1.SetError(txtMNV_DN, "");
            }
        }

        private void cbShowpass_login_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHTMK_DN.Checked)
            {
                txtMK_DN.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK_DN.UseSystemPasswordChar = true;
            }
        }


        #endregion


        #region xử lý phần quên mật khẩu
        private void btnSendCode_forgotpass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMNV_QMK_DN.Text) || string.IsNullOrEmpty(txtMK_QMK_DN.Text) || string.IsNullOrEmpty(txtXNMK_QMK_DN.Text))
            {
                if (string.IsNullOrEmpty(txtMNV_QMK_DN.Text) && string.IsNullOrEmpty(txtMK_QMK_DN.Text) && string.IsNullOrEmpty(txtXNMK_QMK_DN.Text))
                {
                    errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorEmail_forgotpassword.SetError(txtMNV_QMK_DN, "Please enter your email");
                    errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorNewpass_forgotpassword.SetError(txtMK_QMK_DN, "please enter your password");
                    errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorconfirm_forgotpassword.SetError(txtXNMK_QMK_DN, "please enter your confirm");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtMNV_QMK_DN.Text))
                    {
                        errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorEmail_forgotpassword.SetError(txtMNV_QMK_DN, "Please enter your email");
                    }
                    if (string.IsNullOrEmpty(txtMK_QMK_DN.Text))
                    {
                        errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorNewpass_forgotpassword.SetError(txtMK_QMK_DN, "please enter your password");
                    }
                    if (string.IsNullOrEmpty(txtXNMK_QMK_DN.Text))
                    {
                        errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                        errorconfirm_forgotpassword.SetError(txtXNMK_QMK_DN, "please enter your confirm");
                    }
                }

            }
            else if (txtMK_QMK_DN.Text != txtXNMK_QMK_DN.Text)
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtXNMK_QMK_DN, "Your confirm password is incorrect !");
            }
            else
            {
                int flag = 0;
                List<string> dsaccount = GetListMaNV.Instance.ListMSNV_Account();
                string msnv = txtMNV_QMK_DN.Text;
                foreach (string item in dsaccount)
                {
                    if (item == msnv)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Xin chờ trong giây lát","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    string to = (txtMNV_QMK_DN.Text).ToString() + "@gm.uit.edu.vn";
                    Random rand = new Random();
                    randomcode_forgotpassword = (rand.Next(999999)).ToString();
                    int x = SendCode.Instance.SendMail(to, randomcode_forgotpassword);
                    if (x == 1)
                    {
                        MessageBox.Show("Gửi mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == 0)
                    {
                        MessageBox.Show("Gửi mã không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã số nhân viên không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnSave_forgotpass_Click(object sender, EventArgs e)
        {
            if (txtMXN_QMK_DN.Text == randomcode_forgotpassword)
            {
                // lưu lại pass mới 
                string newpass = txtMK_QMK_DN.Text;
                string Msnv = txtMNV_QMK_DN.Text;
                string query = string.Format("UPDATE TAIKHOANDANGNHAP SET Matkhau = '{0}' WHERE MaNhanVien = '{1}' ", newpass, Msnv);
                int a = DataProvider.Instance.ExecuteNonQuery(query);
                if (a > 0)
                {
                    Flight_Management.UserName = DataProvider.Instance.ExecuteQuery("EXEC LAYTENNV " + Msnv).Rows[0][0].ToString();
                    Flight_Management.Quyen = DataProvider.Instance.ExecuteQuery("EXEC LAYQUYEN " + Msnv).Rows[0][0].ToString();
                    Flight_Management.MaNV = txtMNV_QMK_DN.Text;
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Flight_Management fm = new Flight_Management();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Mã không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtManv_forgotpass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMNV_QMK_DN.Text))
            {

                errorEmail_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorEmail_forgotpassword.SetError(txtMNV_QMK_DN, "Please enter your email");
            }
            else
            {
                errorEmail_forgotpassword.SetError(txtMNV_QMK_DN, "");
            }
        }

        private void txtPassword_forgotpass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMK_QMK_DN.Text))
            {
                errorNewpass_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNewpass_forgotpassword.SetError(txtMK_QMK_DN, "please enter your password");
            }
            else
            {
                errorNewpass_forgotpassword.SetError(txtMK_QMK_DN, "");
            }
        }
        private void txtConfirmpass_signup_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXNMK_QMK_DN.Text))
            {
                errorconfirm_forgotpassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorconfirm_forgotpassword.SetError(txtXNMK_QMK_DN, "please enter your confirm");
            }
            else
            {
                errorconfirm_forgotpassword.SetError(txtXNMK_QMK_DN, "");
            }
        }


        #endregion

        private void lblForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnForgotPassword.BringToFront();
        }

        private void lblDanhnhapkhac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Flight_Management.Quyen = "Khách";
            Flight_Management.UserName = "Khách";
            Flight_Management fm = new Flight_Management();
            fm.Show();
        }

        private void lbldangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.BringToFront();
        }
    }
}
