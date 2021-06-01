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
    public partial class Flight_Management : Form
    {
        public static string Quyen;
        public static string UserName;
        public static string MaNV;
        public Flight_Management()
        {
            InitializeComponent();
            CustommerDesign();
        }

        private void CustommerDesign()
        {
            pnAmin.Visible = false;
            pnManage.Visible = false;
            pnRevenue.Visible = false;
            pnSearch.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnAmin.Visible == true)
                pnAmin.Visible = false;
            if (pnManage.Visible == true)
                pnManage.Visible = false;
            if (pnRevenue.Visible == true)
                pnRevenue.Visible = false;
            if (pnSearch.Visible == true)
                pnSearch.Visible = false;
        }

        private void ShowSubMenu(Panel x)
        {
            if (x.Visible == false)
            {
                HideSubMenu();
                x.Visible = true;
            }    
            else
            {
                x.Visible = false;
            }    
        }

        private void btnAdmin_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnAmin);
            pnSide.Height = btnAdmin_main.Height;
            pnSide.Top = btnAdmin_main.Top;
          
        }

        private void btnSupport_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Support());
            pnSide.Height = btnSupport_main.Height;
            pnSide.Top = btnSupport_main.Top;
           
        }

        private void btnMangement_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnManage);
            pnSide.Height = btnMangement_main.Height;
            pnSide.Top = btnMangement_main.Top;
        }

        private void btnSearch_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnSearch);
            pnSide.Height = btnSearch_main.Height;
            pnSide.Top = btnSearch_main.Top;
        }

        private void btnRevenue_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnRevenue);
            pnSide.Height = btnRevenue_main.Height;
            pnSide.Top = btnRevenue_main.Top;
        }

        private void btnSetting_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Setting());
            pnSide.Height = btnSetting_main.Height;
            pnSide.Top = btnSetting_main.Top;
        }

        private void Flight_Management_Load(object sender, EventArgs e)
        {
            pnSide.Height = btnAdmin_main.Height;
            pnSide.Top = btnAdmin_main.Top;
            timer1.Start();
            lbTime_main.Text = DateTime.Now.ToLongTimeString();
            lbDate_main.Text = DateTime.Now.ToLongDateString();
            lbQuyen.Text = Quyen;
            lbTenTaiKhoan.Text = UserName;
            if (Quyen == "Custommer")
            {
                btnAdmin_main.Visible = false;
                pnAmin.Visible = false;
                btnMangement_main.Visible = false;
                pnManage.Visible = false;
                btnRevenue_main.Visible = false;
                pnRevenue.Visible = false;
                btnSetting_main.Visible = false;
            }    
            if (Quyen == "Personel")
            {

            }   
            if (Quyen == "Mangement")
            {

            }
        }

        private void btnClose_main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_main_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private Form activeForm = null;
        private void OpenChildForm(Form child)
        {
            if (activeForm != null)
                activeForm = null;
            activeForm = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(child);
            pnChildForm.Tag = child;
            child.BringToFront();
            child.Show();
        }

       

        private void btnDoanhthuthang_main_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThuThang());
            HideSubMenu();
        }

        private void btnDoanhthunam_main_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThuNam());
            HideSubMenu();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime_main.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnThoat_main_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void btnDoiMatKhau_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new ChangePassword());
        }

        private void btnQuanLyNhanVien_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new QuanLyNhanVien());
        }

       
        private void btnSanBay_Manage_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new QLSanBay());
        }

        private void btnNhanLich_manage_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new NhanLichChuyenBay());
        }
    }
}
