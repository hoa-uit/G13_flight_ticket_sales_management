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
        }

        private void doanhThuThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuThang DTThang = new DoanhThuThang();
            DTThang.ShowDialog();
        }

        private void doanhThuNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuNam DTNam = new DoanhThuNam();
            DTNam.ShowDialog();
        }
    }
}
