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
    public partial class Thanhtoan : Form
    {
        public Thanhtoan(string TenKH, string SDTKH, string CMND, string SoVe, string HanhTrinh, string DonGia, string ThanhTien, string Ngay)
        {
            InitializeComponent();
            lbTenKhachHang.Text = TenKH;
            lbCMND.Text = CMND;
            lbSDT_KH.Text = SDTKH;
            lbSoVe.Text = SoVe;
            lbHanhTrinh.Text = HanhTrinh;
            lbDonGia.Text = DonGia;
            lbThanhtien.Text = ThanhTien;
            lbNgay.Text = Ngay;
            lbTongtien.Text = ThanhTien;
        }
        
        private void btnThoat_Thanhtoan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Thanhtoan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Thanhtoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnThoat_Thanhtoan.PerformClick();
            }
        }
    }
}
