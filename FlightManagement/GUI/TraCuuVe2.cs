using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using FlightManagement.Model;
namespace FlightManagement
{
    public partial class TraCuuVe2 : Form
    {
        public TraCuuVe2()
        {
            InitializeComponent();
        }
        void loadInfo(string mapdc)
        {
            txtMCB_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_macb_ve '" + mapdc + "'").Rows[0][0];
            txtSBDi_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec LAY_SANBAYDI_VE '" + mapdc + "'").Rows[0][0];
            txtSBDen_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec LAY_SANBAYDEN_VE '" + mapdc + "'").Rows[0][0];
            CultureInfo culture = new CultureInfo("vi-VN");
            double x = double.Parse((DataProvider.Instance.ExecuteQuery("exec lay_GIATIEN_ve '" + mapdc + "'").Rows[0][0]).ToString());
            txtGia_TCVCB.Text = x.ToString("c", culture);
                
            txtHangVe_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_HANGVE_ve '" + mapdc + "'").Rows[0][0];
            txtTenHK_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_HOTEN_ve '" + mapdc + "'").Rows[0][0];
            txbCMND_TCVCB.Text = mapdc;
            txtSDT_TCVCB.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_SDT_ve '" + mapdc + "'").Rows[0][0];
            txtViTri_TCVCB.Text = (string)(DataProvider.Instance.ExecuteQuery("exec lay_VITRI_ve '" + mapdc + "'").Rows[0][0]).ToString();
            lblNgayBay_TCVCB.Text = (string)(DataProvider.Instance.ExecuteQuery("exec lay_NGAYGIO_VE '" + mapdc + "'").Rows[0][0]).ToString();

        }

        void loadCTCB(string macb)
        {
            lvCTCB_TCVCB.Items.Clear();
            List<ChiTietCB> List = TraCuuChuyenBayController.Instance.Lay_SBTG(macb);
            int a = 1;
            foreach (ChiTietCB item in List)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.Macb.ToString());
                lvitem.SubItems.Add(item.Tensb.ToString());
                lvitem.SubItems.Add(item.Quocgia.ToString());

                lvitem.SubItems.Add(item.Thoigiandung.ToString());
                lvitem.SubItems.Add(item.Ghichu.ToString());

                a++;
                lvCTCB_TCVCB.Items.Add(lvitem);
            }
        }


        private void btnClose_changepassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Tracuuve_Click(object sender, EventArgs e)
        {
            int a = (int)DataProvider.Instance.ExecuteQuery("exec tim_hk '" + txtCMND_TC_TCVCB.Text + "'").Rows[0][0];
            if (txtCMND_TC_TCVCB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (a == 0)
            {
                MessageBox.Show("Vé không tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadInfo(txtCMND_TC_TCVCB.Text);
                loadCTCB(txtMCB_TCVCB.Text);
            }
        }

        private void btnThoat_tracuuCB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TraCuuVe2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnTim_Tracuuve_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnThoat_tracuuCB_Click(this, new EventArgs());
            }
        }

        private void txtCMND_TC_TCVCB_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtCMND_TC_TCVCB.Text))
            {
                errorCMND.SetError(txtCMND_TC_TCVCB, "");
            }
            else if (reg.IsMatch(txtCMND_TC_TCVCB.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_TC_TCVCB, "CMND phải là các kí tự số");
            }
            else
            {
                errorCMND.SetError(txtCMND_TC_TCVCB, "");
            }
        }
    }
}
