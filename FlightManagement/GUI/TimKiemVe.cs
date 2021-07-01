using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using FlightManagement.Model;
namespace FlightManagement
{
    public partial class TimKiemVe : Form
    {
        public TimKiemVe()
        {
            InitializeComponent();
        }

       
        void TimKiemTheoMacb(string macb)
        {
            lvVe_TKVCB.Items.Clear();
            List<timkiemve> List = TraCuuChuyenBayController.Instance.TimKiemVeTheoMacb(macb);
            if (List.Count > 0)
            {
                int a = 1;
                foreach (timkiemve item in List)
                {
                    ListViewItem lvitem = new ListViewItem(a.ToString());
                    lvitem.SubItems.Add(item.MaChuyenBay.ToString());
                    lvitem.SubItems.Add(item.TenHanhKhach.ToString());
                    lvitem.SubItems.Add(item.CMND.ToString());
                    lvitem.SubItems.Add(item.SDT.ToString());
                    lvitem.SubItems.Add(item.MaHangVe.ToString());
                    lvitem.SubItems.Add(item.GiaTien.ToString());

                    a++;
                    lvVe_TKVCB.Items.Add(lvitem);
                }
            }
            else
            {
                MessageBox.Show("Không có vé nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
           
        }
        void TimKiemTheoCMND(string CMND)
        {
            lvVe_TKVCB.Items.Clear();
            List<timkiemve> List = TraCuuChuyenBayController.Instance.TimKiemVeTheoCMND(CMND);
            if (List.Count > 0)
            {
                int a = 1;
                foreach (timkiemve item in List)
                {
                    ListViewItem lvitem = new ListViewItem(a.ToString());
                    lvitem.SubItems.Add(item.MaChuyenBay.ToString());
                    lvitem.SubItems.Add(item.TenHanhKhach.ToString());
                    lvitem.SubItems.Add(item.CMND.ToString());
                    lvitem.SubItems.Add(item.SDT.ToString());
                    lvitem.SubItems.Add(item.MaHangVe.ToString());
                    lvitem.SubItems.Add(item.GiaTien.ToString());

                    a++;
                    lvVe_TKVCB.Items.Add(lvitem);
                }
            }
            else
            {
                MessageBox.Show("Không có vé nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
          
        }
        void TimKiemTheomacbCMND(string macb,string CMND)
        {
            lvVe_TKVCB.Items.Clear();
            List<timkiemve> List = TraCuuChuyenBayController.Instance.TimKiemVeTheoMacbCMND(macb,CMND);
            if (List.Count > 0)
            {
                int a = 1;
                foreach (timkiemve item in List)
                {
                    ListViewItem lvitem = new ListViewItem(a.ToString());
                    lvitem.SubItems.Add(item.MaChuyenBay.ToString());
                    lvitem.SubItems.Add(item.TenHanhKhach.ToString());
                    lvitem.SubItems.Add(item.CMND.ToString());
                    lvitem.SubItems.Add(item.SDT.ToString());
                    lvitem.SubItems.Add(item.MaHangVe.ToString());
                    lvitem.SubItems.Add(item.GiaTien.ToString());

                    a++;
                    lvVe_TKVCB.Items.Add(lvitem);
                }
            }
            else
            {
                MessageBox.Show("Không có vé nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
           
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[C]{1}[B]{1}[0-9]{3}$");
            Regex reg2 = new Regex("^[1-9]{1}[0-9]{8}$");
            if(string.IsNullOrEmpty(txtMCB_TKVCB.Text) & string.IsNullOrEmpty(txtCMND_TKVCB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if(string.IsNullOrEmpty(txtCMND_TKVCB.Text))
            {
                if (reg.IsMatch(txtMCB_TKVCB.Text))
                {
                    TimKiemTheoMacb(txtMCB_TKVCB.Text);
                }
                else
                {
                    errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCB.SetError(txtMCB_TKVCB, "Mã chuyến bay không hợp lệ.");
                }
                    
            }    
            else if(txtMCB_TKVCB.Text == "")
            {

                if (reg2.IsMatch(txtCMND_TKVCB.Text))
                {
                    TimKiemTheoCMND(txtCMND_TKVCB.Text);
                }
                else
                {
                    errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCMND.SetError(txtCMND_TKVCB, "CMND không hợp lệ.");
                }
               
            }    
            else
            {
                if (reg.IsMatch(txtMCB_TKVCB.Text) == false)
                {
                    errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCB.SetError(txtMCB_TKVCB, "Mã chuyến bay không hợp lệ.");
                }
                else if (reg2.IsMatch(txtCMND_TKVCB.Text) == false)
                {
                    errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCMND.SetError(txtCMND_TKVCB, "CMND không hợp lệ.");
                }
                else
                {
                    TimKiemTheomacbCMND(txtMCB_TKVCB.Text, txtCMND_TKVCB.Text);
                }    
            }    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txb_chuyenbay_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("^[C]{1}[B]{1}[0-9]{3}$");
            if (string.IsNullOrEmpty(txtMCB_TKVCB.Text))
            {
                errorCB.SetError(txtMCB_TKVCB, "");
            }
            else if (reg.IsMatch(txtMCB_TKVCB.Text) == false)
            {
                errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCB.SetError(txtMCB_TKVCB, "Mã hạng vé cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                errorCB.SetError(txtMCB_TKVCB, "");
            }
        }

        private void txb_cmnd_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtCMND_TKVCB.Text))
            {
                errorCMND.SetError(txtCMND_TKVCB, "");
            }
            else if (reg.IsMatch(txtCMND_TKVCB.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_TKVCB, "CMND phải là các kí tự số");
            }
            else
            {
                errorCMND.SetError(txtCMND_TKVCB, "");
            }
        }

        private void btnClose_TimVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiemVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                bunifuThinButton21_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btn_thoat_Click(this, new EventArgs());
            }
        }

       

        private void btnXemTatCaVe_TCVCB_Click(object sender, EventArgs e)
        {
            lvVe_TKVCB.Items.Clear();
            List<timkiemve> List = TraCuuChuyenBayController.Instance.TimKiemTatCave();
            if (List.Count > 0)
            {
                int a = 1;
                foreach (timkiemve item in List)
                {
                    ListViewItem lvitem = new ListViewItem(a.ToString());
                    lvitem.SubItems.Add(item.MaChuyenBay.ToString());
                    lvitem.SubItems.Add(item.TenHanhKhach.ToString());
                    lvitem.SubItems.Add(item.CMND.ToString());
                    lvitem.SubItems.Add(item.SDT.ToString());
                    lvitem.SubItems.Add(item.MaHangVe.ToString());
                    lvitem.SubItems.Add(item.GiaTien.ToString());
                    a++;
                    lvVe_TKVCB.Items.Add(lvitem);
                }



            }
            else
            {
                MessageBox.Show("Không có vé nào nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
