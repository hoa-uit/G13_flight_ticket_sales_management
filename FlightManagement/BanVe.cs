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

namespace FlightManagement
{
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
            Load_Form();
        }
        void Load_Form()
        {
            string ComboBox = "SELECT * from SANBAY";

            
            dgv_BanVe.ColumnHeadersDefaultCellStyle.Font=new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dgv_BanVe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            cbb_DES.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbb_DES.DisplayMember = "QuocGia";
            cbb_DES.ValueMember = "MaSanBay";


            cbb_ORI.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbb_ORI.DisplayMember = "QuocGia";
            cbb_ORI.ValueMember = "MaSanBay";

        }
        private void BanVe_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string ORI_AIRPORT = cbb_ORI.Text.ToString();
            string DES_AIRPORT = cbb_DES.Text.ToString();
            DateTime Light_Time = Time.Value;
           
            if (Light_Time.AddDays(1) < DateTime.Now)
            {
                MessageBox.Show("Ngày Đi Không Hợp Lệ");
            }
            else
            {
                dgv_BanVe.DataSource = ChuyenBayController.Instance.Load(ORI_AIRPORT, DES_AIRPORT, Light_Time);
            }
        }

        private void dgv_BanVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BanVe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Đặt Vé")
            {
                Ve Form = new Ve(dgv_BanVe.Rows[e.RowIndex].Cells["MACB"].Value.ToString());
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn nút Đặt Vé ", "Note");

            }

        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
