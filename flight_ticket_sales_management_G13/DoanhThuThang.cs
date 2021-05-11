using flight_ticket_sales_management_G13.controller;
using flight_ticket_sales_management_G13.model;
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
    public partial class DoanhThuThang : Form
    {
        public DoanhThuThang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_DTThang_Click(object sender, EventArgs e)
        {
            int a = int.Parse(cbThang_DTThang.SelectedItem.ToString());
            int b = int.Parse(txtNam_DTThang.Text);
            ShowCTDTThang(a, b);

        }
         void ShowCTDTThang (int thang, int nam)
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
    }
}
