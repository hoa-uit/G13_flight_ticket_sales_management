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
    public delegate void SM();
    public partial class DATCHO : Form
    {
        public DATCHO()
        {
            InitializeComponent();
            Load_Form();
        }

        private void btnClose_BanVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Load_Form()
        {
            string ComboBox = "SELECT distinct QuocGia from SANBAY";


            dtgvChuyenBay_DatCho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dtgvChuyenBay_DatCho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cbbDiemDen_DatCho.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbbDiemDen_DatCho.DisplayMember = "QuocGia";
            //cbb_DES.ValueMember = "MaSanBay";


            cbbDiemDi_DatCho.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
            cbbDiemDi_DatCho.DisplayMember = "QuocGia";
            //cbb_ORI.ValueMember = "MaSanBay";

        }

        public void run()
        {
            btn_TimKiem_Click(this, new EventArgs());
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecuteQuery("exec SET_STATUS_OUTOFDATE_PDC");  // set tình trạng hết hạn, tự động hủy vé
            string ORI_AIRPORT = cbbDiemDi_DatCho.Text.ToString();
            string DES_AIRPORT = cbbDiemDen_DatCho.Text.ToString();
            DateTime Light_Time = dtpThoiGian_DatCho.Value;
            int a = (int)DataProvider.Instance.ExecuteQuery("select GiaTri from THAMSO where TenThamSo = 'ThoiGianChamNhatDatVe'").Rows[0][0];
            dtgvChuyenBay_DatCho.DataSource = ChuyenBayController.Instance.Load_DatCho(ORI_AIRPORT, DES_AIRPORT, Light_Time);

        }
        void loadCTCB(string macb)
        {
            lvCTCB_DatCho.Items.Clear();
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
                lvCTCB_DatCho.Items.Add(lvitem);
            }
        }
        private void dgv_BanVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string macb;
            macb = dtgvChuyenBay_DatCho.Rows[e.RowIndex].Cells[0].Value.ToString();
            loadCTCB(macb);
            if (dtgvChuyenBay_DatCho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Đặt Chỗ")
            {
               
                if ((int)dtgvChuyenBay_DatCho.Rows[e.RowIndex].Cells["SoLuongGheTrong"].Value == 0)
                {
                    MessageBox.Show("Chuyến bay này đã hết ghế trống. Vui lòng chọn ghế khác!","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PHIEUDATCHO Form = new PHIEUDATCHO(dtgvChuyenBay_DatCho.Rows[e.RowIndex].Cells["MACB"].Value.ToString(), run);
                    Form.ShowDialog();
                    // OpenChildForm(new Form());
                    //OpenChildForm(new DATCHO());
                    //   OpenChildForm(new PHIEUDATCHO(dgv_BanVe.Rows[e.RowIndex].Cells["MACB"].Value.ToString()));
                    
                }

            }
            
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATCHO_KeyDown(object sender, KeyEventArgs e)
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
