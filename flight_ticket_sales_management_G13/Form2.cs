using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_ticket_sales_management_G13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            PannelSubMenuBaoCao.Visible = false;
           
        }
        private void hideSubMenu()
        {
            if (PannelSubMenuBaoCao.Visible = true)
                PannelSubMenuBaoCao.Visible = false;
         
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible = true)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            showSubMenu(PannelSubMenuBaoCao);
        }

        private void BtnDTBV_Click_1(object sender, EventArgs e)
        {
            // your code here: ...
            hideSubMenu();
        }

        private void BtnDTN_Click_1(object sender, EventArgs e)
        {
            // your code
            hideSubMenu();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            new FormHelp().Show();

        }
    }
}
