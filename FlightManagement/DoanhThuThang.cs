using FlightManagement.Controller;
using FlightManagement.Model;
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
    public partial class DoanhThuThang : Form
    {
        public DoanhThuThang()
        {
            InitializeComponent();
        }


        private void btnBaoCao_DTThang_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(cbThang_DTThang.SelectedItem.ToString());
            int b = int.Parse(txtNam_DTThang.Text);
            ShowCTDTThang(a, b);
        }

        void ShowCTDTThang(int thang, int nam)
        {
            lvDTThang.Items.Clear();
            List<CTDTThang> listDTThang = CTDTThangController.Instance.ListCB_BCThang(thang, nam);
            int a = 1;
            foreach (CTDTThang item in listDTThang)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.Macb.ToString());
                lvitem.SubItems.Add(item.Sove.ToString());
                lvitem.SubItems.Add(item.Tyletungchuyenbay1.ToString());
                lvitem.SubItems.Add(item.Doanhthu1.ToString());
                a++;
                lvDTThang.Items.Add(lvitem);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
