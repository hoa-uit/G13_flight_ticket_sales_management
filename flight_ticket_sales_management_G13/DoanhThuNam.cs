﻿using flight_ticket_sales_management_G13.controller;
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
    public partial class DoanhThuNam : Form
    {
        public DoanhThuNam()
        {
            InitializeComponent();
        }

        private void btnThoat_DTNam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_DTNam_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(txtNam_DTNam.Text);
            showCTDTNAM(nam);
        }

        void showCTDTNAM (int nam)
        {
            lvDTNam.Items.Clear();
            List<CTDTNam> listDTNam = CTDTNamController.Instance.listDTThang(nam);
            int a = 1;
            foreach (CTDTNam item in listDTNam)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.Thang.ToString());
                lvitem.SubItems.Add(item.Sochuyenbay.ToString());
                lvitem.SubItems.Add(item.Tong_dt_thang.ToString());
                lvitem.SubItems.Add(item.Tylethang.ToString());
                a++;
                lvDTNam.Items.Add(lvitem);
            }    
        }
    }
}
