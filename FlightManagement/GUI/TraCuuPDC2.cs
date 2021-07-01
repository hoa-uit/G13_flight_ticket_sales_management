using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Globalization;
using FlightManagement.Model;
namespace FlightManagement
{
    public partial class TraCuuPDC2 : Form
    {
        public TraCuuPDC2()
        {
            InitializeComponent();
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void loadInfo(string cmnd)
        {
            string mapdc;
            mapdc = (string)DataProvider.Instance.ExecuteQuery("exec LAYMA_PDC '" + cmnd + "'").Rows[0][0];
            txtMCB_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_macb '" + mapdc + "'").Rows[0][0];
            txtSBDi_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_SANBAYDI '" + mapdc + "'").Rows[0][0];
            txtSBDen_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_SANBAYDEN '" + mapdc + "'").Rows[0][0];
            double x = double.Parse(DataProvider.Instance.ExecuteQuery("exec lay_GIATIEN '" + mapdc + "'").Rows[0][0].ToString());
            CultureInfo culture = new CultureInfo("vi-VN");
             txtGia_TCPDC.Text = x.ToString("c",culture);
        
            //   dtp_ngaybay.Value = (DateTime)(DataProvider.Instance.ExecuteQuery("exec lay_NGAYBAY '" + mapdc + "'").Rows[0][0]);
            txtHangVe_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_HANGVE '" + mapdc + "'").Rows[0][0];
            txtTinhTrang_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_TINHTRANG '" + mapdc + "'").Rows[0][0];
            txtTenHK_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_tenhk '" + mapdc + "'").Rows[0][0];
            txtCMND_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_CMND '" + mapdc + "'").Rows[0][0];
            txtSDT_TCPDC.Text = (string)DataProvider.Instance.ExecuteQuery("exec lay_SDT '" + mapdc + "'").Rows[0][0];
            txtViTri_TCPDC.Text = (string)(DataProvider.Instance.ExecuteQuery("exec lay_vitripdc '" + mapdc + "'").Rows[0][0]).ToString();
            lblNgayBay_TCPDC.Text = (string)(DataProvider.Instance.ExecuteQuery("exec lay_NGAYBAY '" + mapdc + "'").Rows[0][0]).ToString();
            txtMDC_TCPDC.Text = mapdc;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecuteQuery("exec SET_STATUS_OUTOFDATE_PDC");  // set tình trạng hết hạn, tự động hủy vé
            int a = (int)DataProvider.Instance.ExecuteQuery("exec kt_pdc '" + txtCMND_TC_TCPDC.Text + "'").Rows[0][0];
            if ( string.IsNullOrEmpty(txtCMND_TC_TCPDC.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tra cứu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (a == 0)
            {
                MessageBox.Show("Mã đặt chỗ không tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                loadInfo(txtCMND_TC_TCPDC.Text);
                loadCTCB(txtMCB_TCPDC.Text);
            }
        }


        private void btnClose_TracuuPDC_Click(object sender, EventArgs e)
        {
            this.Close();

        }

     

        private void TraCuuPDC2_KeyDown(object sender, KeyEventArgs e)
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

        private void txb_giatien_TextChanged(object sender, EventArgs e)
        {

        }
        void loadCTCB(string macb)
        {
            lvCTCB_TCPDC.Items.Clear();
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
                lvCTCB_TCPDC.Items.Add(lvitem);
            }
        }

        private void txb_hotenhk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
