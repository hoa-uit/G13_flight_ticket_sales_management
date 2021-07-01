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
using FlightManagement.Model;

namespace FlightManagement
{
    public delegate void SendMessage();
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
            Load_Form();
        }
        void Load_Form()
        {
            string ComboBox = "SELECT Distinct QuocGia from SANBAY";

            
            dtgvChuyenBay_BanVe.ColumnHeadersDefaultCellStyle.Font=new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dtgvChuyenBay_BanVe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            cbbDiemDen_BanVe.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbbDiemDen_BanVe.DisplayMember = "QuocGia";
          //  cbb_DES.ValueMember = "MaSanBay";


            cbbDiemDi_BanVe.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbbDiemDi_BanVe.DisplayMember = "QuocGia";
            //cbb_ORI.ValueMember = "MaSanBay";

        }
        void loadCTCB(string macb)
        {
            lvCTCB_BanVe.Items.Clear();
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
                lvCTCB_BanVe.Items.Add(lvitem);
            }
        }


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string ORI_AIRPORT = cbbDiemDi_BanVe.Text.ToString();
            string DES_AIRPORT = cbbDiemDen_BanVe.Text.ToString();
            DateTime Light_Time = dtpThoiGian_BanVe.Value;
           
            if (Light_Time.AddDays(1) < DateTime.Now)
            {
                MessageBox.Show("Ngày đi phải lớn hơn ngày hiện tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                dtgvChuyenBay_BanVe.DataSource = ChuyenBayController.Instance.Load(ORI_AIRPORT, DES_AIRPORT, Light_Time);
            }
        }

         public void run()
        {
            btn_TimKiem_Click(this, new EventArgs());
        }
        private void dgv_BanVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string macb;
            macb = dtgvChuyenBay_BanVe.Rows[e.RowIndex].Cells[0].Value.ToString();
            loadCTCB(macb);
            if (dtgvChuyenBay_BanVe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Đặt Vé")
            {   if ((int)dtgvChuyenBay_BanVe.Rows[e.RowIndex].Cells["SoLuongGheTrong"].Value == 0)
                {
                    MessageBox.Show("Chuyến Bay này đã hết ghế trống vui lòng chọn ghế khác");
                }
                else
                {
                    Ve Form = new Ve(dtgvChuyenBay_BanVe.Rows[e.RowIndex].Cells["MACB"].Value.ToString(),run);
                    Form.ShowDialog();
                }
  
            }
           

        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnClose_BanVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BanVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                btn_TimKiem_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btn_Quaylai_Click(this, new EventArgs());
            }
        }
    }
}
