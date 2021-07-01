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

      

        private void btnMangement_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnManage);
            pnSide.Height = btnQuanLy_main.Height;
            pnSide.Top = btnQuanLy_main.Top;
        }

        private void btnSearch_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnSearch);
            pnSide.Height = btnTraCuu_main.Height;
            pnSide.Top = btnTraCuu_main.Top;
        }

        private void btnRevenue_main_Click(object sender, EventArgs e)
        {
           
            ShowSubMenu(pnRevenue);
            pnSide.Height = btnDoanhThu_main.Height;
            pnSide.Top = btnDoanhThu_main.Top;
        }
        private void btnSupport_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Hotro());
            pnSide.Height = btnHoTro_main.Height;
            pnSide.Top = btnHoTro_main.Top;

        }
        private void btnSetting_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Setting());
            pnSide.Height = btnQuiDinh_main.Height;
            pnSide.Top = btnQuiDinh_main.Top;
        }
        private void btnGioithieu_main_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Gioithieu());
            pnSide.Height = btnGioithieu_main.Height;
            pnSide.Top = btnGioithieu_main.Top;
        }
        private void Flight_Management_Load(object sender, EventArgs e)
        {
            pnSide.Height = btnAdmin_main.Height;
            pnSide.Top = btnAdmin_main.Top;
            timer1.Start();
            lbTime_main.Text = DateTime.Now.ToLongTimeString();
            lbDate_main.Text = DateTime.Now.ToLongDateString();
            lblQuyen_main.Text = Quyen;
            lblTTK_main.Text = UserName;
            if (Quyen == "Khách")
            {
                btnQuanLyNhanVien_main.Enabled = false;
                btnDoiMatKhau_main.Enabled = false;
                btnQuanLy_main.Visible = false;
                pnManage.Visible = false;
                btnDoanhThu_main.Visible = false;
                pnRevenue.Visible = false;
                btnQuiDinh_main.Visible = false;
                btnTimPDC_NV.Visible = false;
                pnSearch.Height = 180;
                pnAmin.Height = 95;
                btnTraCuuChuyenBay_Search.Enabled = false;
            }    
            if (Quyen == "Nhân viên")
            {
                btnQuanLyNhanVien_main.Enabled = false;
                btnQLNV_Shortcut.Enabled = false;
               
            }   
            if (Quyen == "Quản lý")
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

        public Form activeForm = null;
        public void OpenChildForm(Form child)
        {
           
            if (activeForm != null)
                activeForm = null;
            activeForm = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnChildForm.Controls.Remove((Form)pnChildForm.Tag);
            pnChildForm.Controls.Add(child);
            pnChildForm.Tag = child;
            child.BringToFront();
            child.Show();
            activeForm.Focus();
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

      

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

 


        #region các nút chức năng
        private void btnQLHangVe_manage_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new QLHangVe());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();   
            OpenChildForm(new DATCHO());
        }

        private void btnTraCuuChuyenBay_Search_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new TraCuuCB());
        }

        private void btnTraCuuVe_search_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new TraCuuVe2());
        }

        private void btnTraCuuHanhKhach_search_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new TraCuuPDC2());
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
            OpenChildForm(new txtMNV_Them_QLNV());
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

        private void btnBanVe_manage_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new BanVe());
        }



        #endregion



        #region phần slide 
        private int image_number = 2;
        private void LoadNext_image()
        {
            if (image_number == 7)
            {
                image_number = 2;
            }
            picSlide.ImageLocation = string.Format(@"Images\{0}.jpg", image_number);
            image_number++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNext_image();
        }
        #endregion



        #region phần các nút shortcut
        private void btnQLNV_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new txtMNV_Them_QLNV());

        }
     
        private void btnNhanlich_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new NhanLichChuyenBay());
        }

        private void btnDatve_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new BanVe());
        }

        private void btnPDC_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new DATCHO());
        }

        private void btnQLSB_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new QLSanBay());
        }

        private void btnTracuuCB_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new TraCuuCB());
        }

        private void btnTracuuve_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new TraCuuVe2());
        }

        private void btnDoanhthuthang_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new DoanhThuThang());
        }

        private void btnSetting_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Setting());
        }

        private void btnHotro_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Hotro());
        }
        private void btnQLNV_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Quản lý nhân viên", btnQLNV_Shortcut);
        }

        private void btnNhanlich_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Nhận lịch chuyến bay", btnNLCB_Shortcut);
        }

        private void btnDatve_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Đặt vé", btnBV_Shortcut);
        }

        private void btnPDC_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Đặt chỗ chuyến bay", btnPDC_Shortcut);
        }

        private void btnQLSB_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Quản lý sân bay", btnQLSB_Shortcut);
        }

        private void btnTracuuCB_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tra cứu chuyến bay", btnTCCB_Shortcut);
        }

        private void btnTracuuve_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tra cứu vé", btnTCV_Shortcut);
        }

        private void btnDoanhthuthang_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Báo cáo doanh thu tháng", btnDTT_Shortcut);
        }

        private void btnSetting_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cài đặt các quy định", btnQDCB_Shortcut);
        }

        private void btnHotro_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Hỗ trợ", btnHotro_Shortcut);
        }


        #endregion

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

      

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void btnHangve_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new QLHangVe());

        }

        private void btnThongtin_shortcut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Gioithieu());
        }

        private void btnHangve_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Quản lý hạng vé", btnQLHV_Shortcut);
        }

        private void btnThongtin_shortcut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Giới thiệu", btnGioiThieu_Shortcut);
        }

        private void pnChildForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Flight_Management_MouseDown(object sender, MouseEventArgs e)
        {
            pnChildForm.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemVe());
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemPDC());
            HideSubMenu();
        }

        private void btnTimVe_NV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemVe());
            HideSubMenu();
        }

        private void btnTimPDC_NV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemPDC());
            HideSubMenu();
        }

        private void picSlide_Click(object sender, EventArgs e)
        {

        }
    }
}
