using FlightManagement.Controller;
using FlightManagement.Model;
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

namespace FlightManagement
{
    public partial class NhanLichChuyenBay : Form
    {
        public NhanLichChuyenBay()
        {
            InitializeComponent();
            NhanLichChuyenBay_Load();
        }
        public List<HangVe> ListHangVe;
        private void btnClose_nhanlich_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanLichChuyenBay_Load()
        {
            DataTable ComboBox_Data_Des, ComboBox_Data_Ori, ComboBox_Data_Tran;
            string ComBoBox = "select * from SANBAY";

            

           
            
            ComboBox_Data_Des = DataProvider.Instance.ExecuteQuery(ComBoBox);
            ComboBox_Data_Ori = DataProvider.Instance.ExecuteQuery(ComBoBox);
            ComboBox_Data_Tran = DataProvider.Instance.ExecuteQuery(ComBoBox);
            cbbSBDen_NhanLich.DataSource = ComboBox_Data_Des;
            cbbSBDen_NhanLich.DisplayMember = "TenSanBay";
            cbbSBDen_NhanLich.ValueMember = "TenSanBay";
            cbbSBDi_NhanLich.DataSource = ComboBox_Data_Ori;
            cbbSBDi_NhanLich.DisplayMember = "TenSanBay";
            cbbSBDi_NhanLich.ValueMember = "TenSanBay";
            cbb_TranAirport.DataSource = ComboBox_Data_Tran;
            cbb_TranAirport.DisplayMember = "TenSanBay";
            cbb_TranAirport.ValueMember = "TenSanBay";
            ListHangVe = HangVeController.Instance.Load_HangVe();
            dtgvHangVe_NhanLich.DataSource = ListHangVe;
            dtgvSBTrungGian_NhanLich.Rows.Clear();
            dtgvSBTrungGian_NhanLich.Refresh();

        }


        private void btnThoat_nhanlich_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_nhanlich_Click(object sender, EventArgs e)
        {
            NhanLichChuyenBay_Load();
            dtgvSBTrungGian_NhanLich.Controls.Clear();
            txtMCB_NhanLich.Text = "";
            txtThoiGian_NhanLich.Text = "";
            txtGiaVe_NhanLich.Text = "";
            errNgayGio.SetError(dtpNgayGio_NhanLich, "");
            errorThoigianbay.SetError(txtThoiGian_NhanLich, "");
            errorMaSB.SetError(txtMCB_NhanLich, "");
            errorSoSBTG.SetError(dtgvSBTrungGian_NhanLich, "");
            errorThoigiancho.SetError(dtgvSBTrungGian_NhanLich, "");
        }

        private void btnLuu_nhanlich_Click_1(object sender, EventArgs e)
          {
            int count = 0;
               foreach (HangVe HangVe in ListHangVe)
            {
                count += HangVe.SoLuongVe;
            }
              #region check điều kiện
              if (string.IsNullOrEmpty(txtMCB_NhanLich.Text) || string.IsNullOrEmpty(txtGiaVe_NhanLich.Text)  || string.IsNullOrEmpty(txtThoiGian_NhanLich.Text))
              {
                  MessageBox.Show("Bạn hãy điền đây đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }   
              // kiểm tra mã chuyến bay có trùng k
              else if (ChuyenBayController.Instance.checkMaCB(txtMCB_NhanLich.Text))
              {
                  errorMaCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                  errorMaCB.SetError(txtMCB_NhanLich, "Mã chuyến bay này đã tồn tại");
              }    
              else 
              {
                  // i là tổng số sân bay trung gian
                  int i;
                  int min_WaitTime;
                  int max_WaitTime;

                  // i là tổng số sân bay trung gian
                  int Total_TranAirport = i = dtgvSBTrungGian_NhanLich.Rows.Count - 1;

                  // tìm ra thời gian chờ lớn nhất và nhỏ nhất trong số các sân bay trung gian
                  if (i == 0)
                  { 
                      min_WaitTime = max_WaitTime = -1; 
                  }
                  else
                  {
                      min_WaitTime = int.Parse(dtgvSBTrungGian_NhanLich.Rows[0].Cells[2].Value.ToString());
                      max_WaitTime = int.Parse(dtgvSBTrungGian_NhanLich.Rows[0].Cells[2].Value.ToString());
                      for (int j = i - 1; j > 0; j--)
                      {
                          int cell_value = int.Parse(dtgvSBTrungGian_NhanLich.Rows[j].Cells[2].Value.ToString());
                          if (cell_value < min_WaitTime)
                          {
                              min_WaitTime = cell_value;
                          }
                          if (cell_value > max_WaitTime)
                          {
                              max_WaitTime = cell_value;
                          }
                      }
                  }
                  //lấy một cái list gồm những sân bay đi sân bay đến và sân bay trung gian kiểm tra xem trong đó có cái nào trùng nhau không
                  // nếu trùng thì báo lỗi
                  List<string> Flight_Airport = new List<string>(i + 2);
                  Flight_Airport.Add(cbbSBDi_NhanLich.Text);
                  Flight_Airport.Add(cbbSBDen_NhanLich.Text);
                  for (int j = 0; j < i; j++)
                  {
                      Flight_Airport.Add(dtgvSBTrungGian_NhanLich.Rows[j].Cells[1].Value.ToString());
                  }
                  if (Flight_Airport.Distinct().Count() != Flight_Airport.Count())
                  {
                      MessageBox.Show("Sân bay đi, sân bay đến và sân bay trung gian phải khác nhau, xin kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }

                  else if (!ThamSoController.Instance.checkTGBay(int.Parse(txtThoiGian_NhanLich.Text)))
                  {
                      errorThoigianbay.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                      errorThoigianbay.SetError(txtThoiGian_NhanLich, "Thời gian bay chưa đúng");
                  }

                  else if (dtpNgayGio_NhanLich.Value.Date < DateTime.Now.Date)
                  {
                      errNgayGio.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                      errNgayGio.SetError(dtpNgayGio_NhanLich, "Ngày giờ không hợp lệ");

                  }
                  // sai chỗ này
                  else if (ThamSoController.Instance.checkTGcho(max_WaitTime, min_WaitTime))
                  {
                      errorThoigiancho.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                      errorThoigiancho.SetError(dtgvSBTrungGian_NhanLich, "Thời gian chờ không hợp lệ");
                  }   
                  else if (!ThamSoController.Instance.checkSoSanBayTrungGian(i))
                  {
                      errorSoSBTG.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                      errorSoSBTG.SetError(dtgvSBTrungGian_NhanLich, "Số sân bay trung gian chưa hợp lệ");
                  }    
                  //Kiểm tra lỗi chọn hạng vé nhưng số lượng không hợp lệ
                  else if(!HangVeController.Instance.Check(ListHangVe))
                {
                    MessageBox.Show("Số lượng vé không hợp lệ!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                  #endregion xong phần check điều kiện
                  else
                  {

                      string ID_FLIGHT = txtMCB_NhanLich.Text.ToString();
                      float PRICE = float.Parse(txtGiaVe_NhanLich.Text.ToString());
                      string ORIAIRPORT = cbbSBDi_NhanLich.Text.ToString();
                      string DESAIRPORT = cbbSBDen_NhanLich.Text.ToString();
                      DateTime DATIMEFLIGHT = dtpNgayGio_NhanLich.Value;
                      int TIMELIGHT = int.Parse(txtThoiGian_NhanLich.Text.ToString());



                    string query = "EXEC INSERTTOFLIGHT '" + ID_FLIGHT + "', N'" + ORIAIRPORT + "', N'" + DESAIRPORT + "', '" + DATIMEFLIGHT + "' , '" + PRICE + "', '" + TIMELIGHT + "', " + count;
                    int data = DataProvider.Instance.ExecuteNonQuery(query);
                    //Thêm Chi Tiet hang Ve  Vào CSDL //
                    HangVeController.Instance.Save_DaTa(ListHangVe,ID_FLIGHT);


                    if (data > 0)

                      {

                          int k = 0;
                          if (i != 0)
                          {
                              for (int j = 0; j < i; j++)
                              {
                                  // Console.OutputEncoding = Encoding.UTF8;
                                  string AirportName = dtgvSBTrungGian_NhanLich.Rows[j].Cells[1].Value.ToString();
                                  int WaitTime = int.Parse(dtgvSBTrungGian_NhanLich.Rows[j].Cells[2].Value.ToString());
                                  string Note = dtgvSBTrungGian_NhanLich.Rows[j].Cells[3].Value.ToString();

                                  string Query_TranAirport = "EXEC INSERT_TRANAIRPORT '" + ID_FLIGHT + "', N'" + AirportName + "', " + WaitTime + ", N'" + Note + "'";

                                  if (DataProvider.Instance.ExecuteNonQuery(Query_TranAirport) != -1)
                                      k++;

                              }


                          }
                          if (k == i)
                              MessageBox.Show("Thêm chuyến bay thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          else
                              MessageBox.Show("Thêm thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      }
                      else
                      {
                          MessageBox.Show("Thêm chuyến bay không thành công. Xin hãy kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                    
                  }
                    
              }    

          } 
          
        private void btn_TIME_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtThoiGian_NhanLich.Text))
            {
                errorThoigianbay.SetError(txtThoiGian_NhanLich, "");
            }
            else if (reg.IsMatch(txtThoiGian_NhanLich.Text) == false)
            {
                errorThoigianbay.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorThoigianbay.SetError(txtThoiGian_NhanLich, "Tỷ lệ phải là các kí tự số");
            }
            else
            {
                int a = int.Parse(txtThoiGian_NhanLich.Text.ToString());
                if (a < ThamSoController.Instance.Min_Fly_Time)
                {
                    errorThoigianbay.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorThoigianbay.SetError(txtThoiGian_NhanLich, "chú ý thời gian bay tối thiểu");
                }
                else
                {
                    errorThoigianbay.SetError(txtThoiGian_NhanLich, "");

                }
            }
        }

        private void timepk_DATIMEFLIGHT_ValueChanged(object sender, EventArgs e)
        {
            errNgayGio.SetError(dtpNgayGio_NhanLich, "");
        }
        
        private void btn_IDFLIGHT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMCB_NhanLich.Text))
            {
                errorMaSB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaSB.SetError(txtThoiGian_NhanLich, "Mã sân bay đã tồn tại");
            }
            else
            {
                errorMaSB.SetError(txtMCB_NhanLich, "");
            }
        }
        
        private void dgv_NhanLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errorThoigiancho.SetError(dtgvSBTrungGian_NhanLich, "");
            errorSoSBTG.SetError(dtgvSBTrungGian_NhanLich, "");
        }

      

        private void dgv_HangVe_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dtgvHangVe_NhanLich.IsCurrentCellDirty)
            {
                dtgvHangVe_NhanLich.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_HangVe_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvHangVe_NhanLich.Columns[e.ColumnIndex].Name=="ChonHangVe")
            {   if ((bool)dtgvHangVe_NhanLich.Rows[e.RowIndex].Cells["ChonHangVe"].Value == true)
                    dtgvHangVe_NhanLich.Rows[e.RowIndex].Cells["SoLuongVe"].ReadOnly = false;
                else
                { dtgvHangVe_NhanLich.Rows[e.RowIndex].Cells["SoLuongVe"].Value = 0;
                    dtgvHangVe_NhanLich.Rows[e.RowIndex].Cells["SoLuongVe"].ReadOnly = true;
                 }
            }
        }

        private void btnClose_Nhanlich_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_SanBayTrungGian_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dtgvSBTrungGian_NhanLich.Rows[e.RowIndex].Selected = true;
                this.Tag = e.RowIndex;
                this.dtgvSBTrungGian_NhanLich.CurrentCell = this.dtgvSBTrungGian_NhanLich.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dtgvSBTrungGian_NhanLich, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dtgvSBTrungGian_NhanLich.Rows[(int)this.Tag].IsNewRow)
            {
                dtgvSBTrungGian_NhanLich.Rows.RemoveAt((int)this.Tag);
                errorSoSBTG.SetError(dtgvHangVe_NhanLich, "");
            }
            for (int i = 0; i < dtgvSBTrungGian_NhanLich.Rows.Count - 1; i++)
            {
                dtgvSBTrungGian_NhanLich.Rows[i].Cells[0].Value = i + 1;
            }
          
        }

        private void dgv_SanBayTrungGian_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.dtgvSBTrungGian_NhanLich.Rows[e.RowIndex].IsNewRow)
            {
                if (dtgvSBTrungGian_NhanLich.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dtgvSBTrungGian_NhanLich.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                }
            }
        }

        private void NhanLichChuyenBay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuu_nhanlich_Click_1(this,new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
               btnTiep_nhanlich_Click(this, new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                btnThoat_nhanlich_Click(this, new EventArgs());
            }

        }

        private void dgv_SanBayTrungGian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorSoSBTG.SetError(dtgvSBTrungGian_NhanLich, "");
            errorThoigiancho.SetError(dtgvSBTrungGian_NhanLich, "");
        }

        private void txtThoiGian_NhanLich_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void txtMCB_NhanLich_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[C]{1}[B]{1}[0-9]{3}$");
            if (string.IsNullOrEmpty(txtMCB_NhanLich.Text))
            {
                errorMaCB.SetError(txtMCB_NhanLich, "");
            }
            else if (reg.IsMatch(txtMCB_NhanLich.Text) == false)
            {
                errorMaCB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaCB.SetError(txtMCB_NhanLich, "Mã hạng vé cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                errorMaCB.SetError(txtMCB_NhanLich, "");
            }
        }

        private void txtGiaVe_NhanLich_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtGiaVe_NhanLich.Text))
            {
                errorGiaVe.SetError(txtGiaVe_NhanLich, "");
            }
            else if (reg.IsMatch(txtGiaVe_NhanLich.Text) == false)
            {
                errorGiaVe.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorGiaVe.SetError(txtGiaVe_NhanLich, "Tỷ lệ phải là các kí tự số");
            }
            else
            {
                errorGiaVe.SetError(txtGiaVe_NhanLich, "");
            }
        }

       
    }
}