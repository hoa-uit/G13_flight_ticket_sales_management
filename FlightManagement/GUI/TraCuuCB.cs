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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace FlightManagement
{
    public partial class TraCuuCB : Form
    {
        int count = 0;
        List<TraCuuChuyenBay> ListCB = new List<TraCuuChuyenBay>();
        int check = -1;
        public TraCuuCB()
        {
            InitializeComponent();
            Load_Form();
        }

        void Load_Datagridview()
        {

            dgv_TraCuu.DataSource = ListCB;
            for(int i = 0; i< dgv_TraCuu.RowCount;i++)
            {
                dgv_TraCuu.Rows[i].Cells["STT"].Value = i + 1;
            }    
            
            
        }
        private void btnClose_BanVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            check = 0;
            if (count == 0)
                MessageBox.Show("Bạn hãy điền thông tin để tra cứu", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (count == 1)
            {
                if (cbDiemDi_TCCB.Checked == true)
                {
                    ListCB = TraCuuChuyenBayController.Instance.TraCuu_QGDi(cbbDiemDi_TCCB.Text);
                    Load_Datagridview();
                }
                else if (cbDiemDen_TCCB.Checked == true)
                {
                    ListCB = TraCuuChuyenBayController.Instance.TraCuu_QGDen(cbbDiemDen_TCCB.Text);
                    Load_Datagridview();
                }
                else
                {
                    ListCB = TraCuuChuyenBayController.Instance.tra_cuu_tg(dtpThoiGian_TCCB.Value);
                    Load_Datagridview();
                }


            }
            if (count == 2)
            {
                if (cbDiemDi_TCCB.Checked == true)
                {
                    if (cbDiemDen_TCCB.Checked == true)
                    {
                        ListCB = TraCuuChuyenBayController.Instance.TraCuu_QGDi_QGDen(cbbDiemDi_TCCB.Text, cbbDiemDen_TCCB.Text);
                        Load_Datagridview();

                    }    
                    else
                    {
                        ListCB = TraCuuChuyenBayController.Instance.tra_cuu_qgdi_tg(cbbDiemDi_TCCB.Text, dtpThoiGian_TCCB.Value);
                        Load_Datagridview();
                    }

                }
                else
                {
                    ListCB = TraCuuChuyenBayController.Instance.tra_cuu_qgden_tg(cbbDiemDen_TCCB.Text, dtpThoiGian_TCCB.Value);
                    Load_Datagridview();
                }
            }
            if (count == 3)
            {
                ListCB = TraCuuChuyenBayController.Instance.result_TraCuu(cbbDiemDi_TCCB.Text, cbbDiemDen_TCCB.Text, dtpThoiGian_TCCB.Value);
                Load_Datagridview();
            }

        }
        void Load_Form()
        {
            cbbDiemDen_TCCB.Enabled = false;
            cbbDiemDi_TCCB.Enabled = false;
            dtpThoiGian_TCCB.Enabled = false;
            

        }
        /*
        void Show_result(string quocgiadi, string quocgiaden, DateTime ngaygio)
        {
            lvTraCuu.Items.Clear();
            List<TraCuuChuyenBay> List = TraCuuChuyenBayController.Instance.result_TraCuu(quocgiadi, quocgiaden, ngaygio);
            int a = 1;
            if (List.Count > 0)
            {
                foreach (TraCuuChuyenBay item in List)
                {
                    ListViewItem lvitem = new ListViewItem(a.ToString());
                    lvitem.SubItems.Add(item.MACB.ToString());
                    lvitem.SubItems.Add(item.SanBayDi.ToString());
                    lvitem.SubItems.Add(item.SanBayDen.ToString());
                    lvitem.SubItems.Add(item.ThoiGian.ToString());
                    lvitem.SubItems.Add(item.ThoiGianBay.ToString());
                    lvitem.SubItems.Add(item.SLGheTrong.ToString());
                    lvitem.SubItems.Add(item.SLGheDat.ToString());
                    lvitem.SubItems.Add(item.GiaTien.ToString());
                    a++;
                    lvTraCuu.Items.Add(lvitem);
                }
            }
            else
            {
                MessageBox.Show("Không có chuyến bay nào thõa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
           
        }
        void Tra_Cuu_theo_qgdi_tg(string quocgiadi, DateTime ngaygio)
        {
            lvTraCuu.Items.Clear();
            List<TraCuuChuyenBay> List = TraCuuChuyenBayController.Instance.tra_cuu_qgdi_tg(quocgiadi, ngaygio);
            int a = 1;
            foreach (TraCuuChuyenBay item in List)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.MACB.ToString());
                lvitem.SubItems.Add(item.SanBayDi.ToString());
                lvitem.SubItems.Add(item.SanBayDen.ToString());
                lvitem.SubItems.Add(item.ThoiGian.ToString());
                lvitem.SubItems.Add(item.ThoiGianBay.ToString());
                lvitem.SubItems.Add(item.SLGheTrong.ToString());
                lvitem.SubItems.Add(item.SLGheDat.ToString());
                lvitem.SubItems.Add(item.GiaTien.ToString());
                a++;
                lvTraCuu.Items.Add(lvitem);
            }
        }
        void Tra_Cuu_theo_qgden_tg(string quocgiaden, DateTime ngaygio)
        {
            lvTraCuu.Items.Clear();
            List<TraCuuChuyenBay> List = TraCuuChuyenBayController.Instance.tra_cuu_qgden_tg(quocgiaden, ngaygio);
            int a = 1;
            foreach (TraCuuChuyenBay item in List)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.MACB.ToString());
                lvitem.SubItems.Add(item.SanBayDi.ToString());
                lvitem.SubItems.Add(item.SanBayDen.ToString());
                lvitem.SubItems.Add(item.ThoiGian.ToString());
                lvitem.SubItems.Add(item.ThoiGianBay.ToString());
                lvitem.SubItems.Add(item.SLGheTrong.ToString());
                lvitem.SubItems.Add(item.SLGheDat.ToString());
                lvitem.SubItems.Add(item.GiaTien.ToString());
                a++;
                lvTraCuu.Items.Add(lvitem);
            }
        }
        void Tra_Cuu_theo_tg(DateTime ngaygio)
        {
            lvTraCuu.Items.Clear();
            List<TraCuuChuyenBay> List = TraCuuChuyenBayController.Instance.tra_cuu_tg(ngaygio);
            int a = 1;
            foreach (TraCuuChuyenBay item in List)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.MACB.ToString());
                lvitem.SubItems.Add(item.SanBayDi.ToString());
                lvitem.SubItems.Add(item.SanBayDen.ToString());
                lvitem.SubItems.Add(item.ThoiGian.ToString());
                lvitem.SubItems.Add(item.ThoiGianBay.ToString());
                lvitem.SubItems.Add(item.SLGheTrong.ToString());
                lvitem.SubItems.Add(item.SLGheDat.ToString());
                lvitem.SubItems.Add(item.GiaTien.ToString());
                a++;
                lvTraCuu.Items.Add(lvitem);
            }
        }
        void Lay_het()
        {
            lvTraCuu.Items.Clear();
            List<TraCuuChuyenBay> List = TraCuuChuyenBayController.Instance.Lay_tat_ca_cb();
            int a = 1;
            foreach (TraCuuChuyenBay item in List)
            {
                ListViewItem lvitem = new ListViewItem(a.ToString());
                lvitem.SubItems.Add(item.MACB.ToString());
                lvitem.SubItems.Add(item.SanBayDi.ToString());
                lvitem.SubItems.Add(item.SanBayDen.ToString());
                lvitem.SubItems.Add(item.ThoiGian.ToString());
                lvitem.SubItems.Add(item.ThoiGianBay.ToString());
                lvitem.SubItems.Add(item.SLGheTrong.ToString());
                lvitem.SubItems.Add(item.SLGheDat.ToString());
                lvitem.SubItems.Add(item.GiaTien.ToString());
                a++;
                lvTraCuu.Items.Add(lvitem);
            }
        }
        */
        private void btn_GET_ALL_FLIGHT_Click(object sender, EventArgs e)
        {
            ListCB = TraCuuChuyenBayController.Instance.Lay_tat_ca_cb();
           
            Load_Datagridview();
            check = 1;
            

        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_tracuuCB_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TraCuuCB_KeyDown(object sender, KeyEventArgs e)
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

        private void TraCuuCB_Load(object sender, EventArgs e)
        {

        }
        /*
        private void lvTraCuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTraCuu.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTraCuu.SelectedItems[0];
                string Macb = lvi.SubItems[1].Text;

                loadCTCB(Macb);
            }
        //}*/
        void loadCTCB(string macb)
        {
            lvCTCB_TCCB.Items.Clear();
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
                lvCTCB_TCCB.Items.Add(lvitem);
            }
        }
        

        private void cbb_DES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_DiemDi_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbDiemDi_TCCB.Checked == true)
            {
                cbbDiemDi_TCCB.Enabled = true;
                string ComboBox = "SELECT distinct QuocGia from SANBAY";
                cbbDiemDi_TCCB.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
                cbbDiemDi_TCCB.DisplayMember = "QuocGia";
                count++;
            }
            else
            {
                cbbDiemDi_TCCB.Enabled = false;
                cbbDiemDi_TCCB.DataSource = null;
                count--;
            }
        }

       

        private void cb_ThoiGian_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbThoiGian_TCCB.Checked == true)
            {
                dtpThoiGian_TCCB.Enabled = true;
                count++;
            }
            else
            {
                dtpThoiGian_TCCB.Enabled = false;
                count--;
            }
        }

        private void dgv_TraCuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {   if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == dgv_TraCuu.Columns["XoaChuyenBay"].Index)
                {
                    if ((int)dgv_TraCuu.Rows[e.RowIndex].Cells["SLGheDat"].Value != 0)
                        MessageBox.Show("Chuyến bay này đã có khách đặt không thể xoá", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn Muốn Xoá Chuyến Bay Này Phải Không", "Chú Ý", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            if (TraCuuChuyenBayController.Instance.XoaChuyenBay(dgv_TraCuu.Rows[e.RowIndex].Cells["MACB"].Value.ToString()))
                            {
                                MessageBox.Show("Xoá Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                if (check == 1)
                                    btn_GET_ALL_FLIGHT_Click(this, new EventArgs());
                                if (check == 0)
                                    btn_TimKiem_Click(this, new EventArgs());
                            }
                            else
                                MessageBox.Show("Xoá Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }


                }
                else
                    loadCTCB(dgv_TraCuu.Rows[e.RowIndex].Cells["MACB"].Value.ToString());
            } 
        }

        private void abcDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cb_DiemDen_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbDiemDen_TCCB.Checked == true)
            {
                cbbDiemDen_TCCB.Enabled = true;
                string ComboBox = "SELECT distinct QuocGia from SANBAY";
                cbbDiemDen_TCCB.DataSource = DataProvider.Instance.ExecuteQuery(ComboBox);
                cbbDiemDen_TCCB.DisplayMember = "QuocGia";
                count++;
            }
            else
            {
                cbbDiemDen_TCCB.Enabled = false;
                cbbDiemDen_TCCB.DataSource = null;
                count--;
            }

        }

        private void btnXuatFileExecel_TCCB_Click(object sender, EventArgs e)
        {
            
            if (dgv_TraCuu.Rows.Count > 0 && dgv_TraCuu.Rows[0].IsNewRow == false)
            {
               
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i< dgv_TraCuu.Columns.Count ; i++)
                {
                    obj.Cells[1, i] = dgv_TraCuu.Columns[i - 1].HeaderText;
                }    
                for (int i =0; i < dgv_TraCuu.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_TraCuu.Columns.Count - 1; j++)
                    {
                       
                       
                            obj.Cells[i + 2, j + 1] = dgv_TraCuu.Rows[i].Cells[j].Value.ToString();
                         
                    }    
                }
                obj.Columns.AutoFit();
                obj.Visible = true;
            } 
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất file. Xin kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
