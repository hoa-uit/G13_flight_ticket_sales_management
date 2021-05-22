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
            string Username = Flight_Management.UserName;
            string query1 = string.Format("SELECT PASS FROM ACCOUNT WHERE EMAIL = '{0}'",Username);
            string Password = DataProvider.Instance.ExecuteQuery(query1).Rows[0][0].ToString();
            if (Password == txtOldPassword_changepassword.Text)
            {
                if(txtNewpassword_changepassword.Text == txtConfirmPassword_changepassword.Text)
                {
                    //lưu thông tin lại
                    string newpass = txtNewpassword_changepassword.Text;
                    string query2 = string.Format("UPDATE ACCOUNT SET PASS = '{0}' WHERE EMAIL = '{1}' ", newpass, Username);
                    int a = DataProvider.Instance.ExecuteNonQuery(query2);
                    if (a >0)
                    {
                        MessageBox.Show("Reset password successfully");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Reset unsuccessfully");
                    }
                }
                else
                {
                    errorProvider2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorProvider2.SetError(txtConfirmPassword_changepassword, "Your Confirm password is incorrect");
                }    
            }
            else 
            {
                //pass bị sai
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorProvider1.SetError(txtOldPassword_changepassword, "your password is incorrect");
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
    }
}
