using FlightManagement.Controller;
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
    public partial class BanVe1 : Form
    {
        public BanVe1()
        {
            InitializeComponent();
            load_form();
        }

      
        public void load_form()
        {

            string ComboBox = "SELECT * from SANBAY";
            cbb_DES.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbb_DES.DisplayMember = "QuocGia";
            cbb_DES.ValueMember = "MaSanBay";


            cbb_ORI.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbb_ORI.DisplayMember = "QuocGia";
            cbb_ORI.ValueMember = "MaSanBay";

        }



        private void button4_Click(object sender, EventArgs e)
        {

            string ORI_AIRPORT = cbb_ORI.Text.ToString();
            string DES_AIRPORT = cbb_DES.Text.ToString();
            DateTime Light_Time = Time.Value;
            dgv_BuyTicKet.DataSource = ChuyenBayController.Instance.Load(ORI_AIRPORT, DES_AIRPORT, Light_Time);

        }



        private void dgv_BuyTicKet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BuyTicKet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Đặt Vé")
            {
                BanVe2 Form = new BanVe2 (dgv_BuyTicKet.Rows[e.RowIndex].Cells[0].Value.ToString());

                this.Close();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faile", "Note");

            }
        }

        private void btnClose_banve1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
    }
}
