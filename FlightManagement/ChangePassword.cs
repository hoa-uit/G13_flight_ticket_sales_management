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
    public partial class ChangePassword : Form
    {
        public static string randomcode_changepass;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_changepassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_login_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword_changepassword.Text))
            {
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorProvider1.SetError(txtOldPassword_changepassword, "your password is incorrect");
            }
            else
            {
                errorProvider1.SetError(txtOldPassword_changepassword, "");
            }
        }

        private void btnSave_changepassword_Click(object sender, EventArgs e)
        {

            if (txtCode_changepass.Text == randomcode_changepass)
            {
                // lưu lại pass mới 
                string newpass = txtNewpassword_changepassword.Text;
                string Msnv = Flight_Management.MaNV;
                string query = string.Format("UPDATE TAIKHOANDANHNHAP SET Matkhau = '{0}' WHERE MaNhanVien = '{1}' ", newpass, Msnv);
                int a = DataProvider.Instance.ExecuteNonQuery(query);
                if (a > 0)
                {
                   
                    MessageBox.Show("Reset password successfully");
                   
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

        private void txtConfirmPassword_changepassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword_changepassword.Text))
            {
                errorProvider2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorProvider2.SetError(txtConfirmPassword_changepassword, "Your Confirm password is incorrect");
            }    
            else
            {
                errorProvider2.SetError(txtConfirmPassword_changepassword, "");
            }    
        }

        private void btnSendcode_changepass_Click(object sender, EventArgs e)
        {
            string query1 = string.Format("SELECT Matkhau FROM TAIKHOANDANHNHAP WHERE MaNhanVien = '{0}'", Flight_Management.MaNV);
            string Password = DataProvider.Instance.ExecuteQuery(query1).Rows[0][0].ToString();
           
            if (string.IsNullOrEmpty(txtConfirmPassword_changepassword.Text)|| string.IsNullOrEmpty(txtNewpassword_changepassword.Text) || string.IsNullOrEmpty(txtOldPassword_changepassword.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !");
            }    
            else if (Password.Trim() != txtOldPassword_changepassword.Text)
            {
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorProvider1.SetError(txtOldPassword_changepassword, "your password is incorrect");
            }    
            else if (txtConfirmPassword_changepassword.Text != txtNewpassword_changepassword.Text)
            {
                errorProvider2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorProvider2.SetError(txtConfirmPassword_changepassword, "Your Confirm password is incorrect");
            }    
            else
            {
                MessageBox.Show("Xin chờ trong giây lát !");
                string to = (Flight_Management.MaNV).ToString() + "@gm.uit.edu.vn";
                Random rand = new Random();
                randomcode_changepass = (rand.Next(999999)).ToString();
                int x = SendCode.Instance.SendMail(to, randomcode_changepass);
                if (x == 1)
                {
                    MessageBox.Show("Send code thành công");
                }
                else if (x == 0)
                {
                    MessageBox.Show("không thành công");
                }
            }    
           
        }
    }
}
