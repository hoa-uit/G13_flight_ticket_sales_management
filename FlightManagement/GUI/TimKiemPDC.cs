using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using FlightManagement.Model;
namespace FlightManagement
{
    public partial class TimKiemPDC : Form
    {
        public int count;
        public TimKiemPDC()
        {
            InitializeComponent();
            dtgvPDC_TKPDC.Columns["ThanhToan"].DefaultCellStyle.NullValue = "Thanh toán";
             


        }
        void Load_datagridview()
        {
            for(int i = 0; i<dtgvPDC_TKPDC.Rows.Count; i++)
            {
                dtgvPDC_TKPDC.Rows[i].Cells["Column1"].Value = i + 1;
            }
        }

        void TimKiemTheoMacb(string macb)
        {
            listView1.Items.Clear();
            List<TimKiem> List = TraCuuChuyenBayController.Instance.TimKiempdcTheoMacb(macb);
            if (List.Count > 0)
            {
                    dtgvPDC_TKPDC.DataSource = List;
                Load_datagridview();
            }
            else
            {
                MessageBox.Show("Không có phiếu đặt chỗ nào nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        void TimKiemTheoCMND(string CMND)
        {
            listView1.Items.Clear();
            List<TimKiem> List = TraCuuChuyenBayController.Instance.TimKiempdcTheoCMND(CMND);
            if (List.Count > 0)
            {
                
                    dtgvPDC_TKPDC.DataSource = List;
            }
            else
            {
                MessageBox.Show("Không có phiếu đặt chỗ nào nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
         
        }
        void TimKiemTheomacbCMND(string macb, string CMND)
        {
            listView1.Items.Clear();
            List<TimKiem> List = TraCuuChuyenBayController.Instance.TimKiempdcTheoMacbCMND(macb, CMND);
            if (List.Count > 0)
            {
                dtgvPDC_TKPDC.DataSource = List;
            }
            else
            {
                MessageBox.Show("Không có phiếu đặt chỗ nào nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
          
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecuteQuery("exec SET_STATUS_OUTOFDATE_PDC");  // set tình trạng hết hạn, tự động hủy vé
            count = 1;
            Regex reg = new Regex("^[C]{1}[B]{1}[0-9]{3}$");
            Regex reg2 = new Regex("^[1-9]{1}[0-9]{8}$");
            if (string.IsNullOrEmpty(txtCB_TKPDC.Text) && string.IsNullOrEmpty(txtCMND_TKPDC.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin để tra cứu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCMND_TKPDC.Text))
            {

                if (reg.IsMatch(txtCB_TKPDC.Text))
                {
                    TimKiemTheoMacb(txtCB_TKPDC.Text);
                }
                else
                {
                    errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCB.SetError(txtCB_TKPDC, "Mã chuyến bay không hợp lệ.");
                }
              
            }
            else if (string.IsNullOrEmpty(txtCB_TKPDC.Text))
            {

                if (reg2.IsMatch(txtCMND_TKPDC.Text))
                {
                    TimKiemTheoCMND(txtCMND_TKPDC.Text);
                }
                else
                {
                    errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCMND.SetError(txtCMND_TKPDC, "CMND không hợp lệ.");
                }
               
            }
            else
            {
                MessageBox.Show("3");
                if (reg.IsMatch(txtCB_TKPDC.Text) == false)
                {
                    errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCB.SetError(txtCB_TKPDC, "Mã chuyến bay không hợp lệ.");
                }
                else if (reg2.IsMatch(txtCMND_TKPDC.Text) == false)
                {
                    errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorCMND.SetError(txtCMND_TKPDC, "CMND không hợp lệ.");
                }
                else
                {
                    TimKiemTheomacbCMND(txtCB_TKPDC.Text, txtCMND_TKPDC.Text);
                }
               
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_cmnd_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtCMND_TKPDC.Text))
            {
                errorCMND.SetError(txtCMND_TKPDC, "");
            }
            else if (reg.IsMatch(txtCMND_TKPDC.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_TKPDC, "CMND phải là các kí tự số");
            }
            else
            {
                errorCMND.SetError(txtCMND_TKPDC, "");
            }
        }

        private void txb_chuyenbay_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[C]{1}[B]{1}[0-9]{3}$");
            if (string.IsNullOrEmpty(txtCB_TKPDC.Text))
            {
                errorCB.SetError(txtCB_TKPDC, "");
            }
            else if (reg.IsMatch(txtCB_TKPDC.Text) == false)
            {
                errorCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCB.SetError(txtCB_TKPDC, "Mã hạng vé cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                errorCB.SetError(txtCB_TKPDC, "");
            }
        }

        private void btnClose_TimPDC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvPDC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dtgvPDC_TKPDC.Rows[0].IsNewRow == false)
            {

                if (e.ColumnIndex == dtgvPDC_TKPDC.Columns["ThanhToan"].Index)
                {
                   // string STT = dtgvPDC.Rows[e.RowIndex].Cells["Column1"].Value.ToString().Trim();
                    string MaPDC = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column8"].Value.ToString().Trim();
                    string MaCB = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column2"].Value.ToString().Trim();
                    string TenHK = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column3"].Value.ToString().Trim();
                    string CMND = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column4"].Value.ToString().Trim();
                    string SDT = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column5"].Value.ToString().Trim();
                    string HV = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column6"].Value.ToString().Trim();
                    string gia = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column7"].Value.ToString().Trim();
                    float Gia = float.Parse(gia);
                    string tinhtrang = dtgvPDC_TKPDC.Rows[e.RowIndex].Cells["Column9"].Value.ToString().Trim();
                    if (tinhtrang == "ĐÃ THANH TOÁN" || tinhtrang == "HẾT HẠN")
                    {
                        MessageBox.Show("Thanh toán thất bại, vé đã được thanh toán hoặc hết hạn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Bạn muốn thanh toán phiếu đặt chỗ số " + MaPDC + " phải không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            string maghe = (string)(DataProvider.Instance.ExecuteQuery("exec LAY_MAGHE '" + MaPDC + "'").Rows[0][0]).ToString();
                            string query = string.Format("exec THANHTOAN_PDC '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", MaCB, TenHK, CMND, SDT, maghe, Gia, MaPDC);
                            int a = DataProvider.Instance.ExecuteNonQuery(query);
                            if (a > 0)
                            {
                                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                string query11 = "exec LAYTENSANBAYDI '" + MaCB + "'";
                                string sanbaydi = DataProvider.Instance.ExecuteQuery(query11).Rows[0][0].ToString();
                                string query12 = "exec LAYTENSANBAYDEN '" + MaCB + "'";
                                string sanbayden = DataProvider.Instance.ExecuteQuery(query12).Rows[0][0].ToString();
                                string hanhtrinh = sanbaydi + "-" + sanbayden;
                                Thanhtoan th = new Thanhtoan(TenHK, SDT, CMND, "1", hanhtrinh, gia, gia, DateTime.Now.Date.ToString());
                                th.Show();
                                if (count == 1)
                                {
                                    bunifuThinButton21_Click(this, new EventArgs());

                                }    
                                else if (count == 0)
                                {
                                    btnXemTatCaPDC_Click(this, new EventArgs());
                                }    
                                
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }

                        }

                    }

                }
            }

        }

        private void btnXemTatCaPDC_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecuteQuery("exec SET_STATUS_OUTOFDATE_PDC");  // set tình trạng hết hạn, tự động hủy vé
            count = 0;
            listView1.Items.Clear();
            List<TimKiem> List = TraCuuChuyenBayController.Instance.TimKiemTatCaPDC();
            if (List.Count > 0)
            {

                dtgvPDC_TKPDC.DataSource = List;
            }
            else
            {
                MessageBox.Show("Không có phiếu đặt chỗ nào nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TimKiemPDC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnClose_TimPDC_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                bunifuThinButton21_Click(this, new EventArgs());
            }
        }
    }
}
