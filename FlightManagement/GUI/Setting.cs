
using FlightManagement.Controller;
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnClose_Setting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       private void LoadThamSo()
        {
            txtTGBTT_QDCB.Text = ThamSoController.Instance.Min_Fly_Time.ToString();
            txtSSBTGTD_QDCB.Text = ThamSoController.Instance.Num_Tran_Airpot.ToString();
            txtTGDTT_QDCB.Text = ThamSoController.Instance.Min_Wait_Time.ToString();
            txtTGDTD_QDCB.Text = ThamSoController.Instance.Max_Wait_Time.ToString();
            txtTGCNDV_QDCB.Text = ThamSoController.Instance.Latest_Time_Book.ToString();
            txtTGCNHV_QDCB.Text = ThamSoController.Instance.Latest_Time_Cancel.ToString();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadThamSo();
            this.KeyPreview = true;
        }

        
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            
            Regex regS = new Regex("\\D");       // not number

            #region TestError1 Min_Fly_Time

            if (string.IsNullOrEmpty(txtTGBTT_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời gian bay tối thiếu!", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGBTT_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtTGBTT_QDCB.Text) || Convert.ToInt32(txtTGBTT_QDCB.Text) < 0 || Convert.ToInt32(txtTGBTT_QDCB.Text) > 999)
            {
                MessageBox.Show("Thời gian bay tối thiểu không hợp lệ!  vui lòng nhập ký tự số từ 0 đến 999", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGBTT_QDCB.BackColor = Color.LightPink;
            }
            #endregion

            #region TestError2 Num_Tran_Airpot
            else if (string.IsNullOrEmpty(txtSSBTGTD_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Số sân bay trung gian tối đa!", "Thông tin lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSSBTGTD_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtSSBTGTD_QDCB.Text) || Convert.ToInt32(txtSSBTGTD_QDCB.Text) < 0 || Convert.ToInt32(txtSSBTGTD_QDCB.Text) > 20)
            {
                MessageBox.Show("Số sân bay trung gian tối đa không hợp lệ! Vui lòng nhập ký tự số từ 0 đến 20", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSSBTGTD_QDCB.BackColor = Color.LightPink;
            }
            #endregion

            #region TestError3 Min_Wait_Time

            else if (string.IsNullOrEmpty(txtTGDTT_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời gian dừng tối thiểu!", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGDTT_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtTGDTT_QDCB.Text) || Convert.ToInt32(txtTGDTT_QDCB.Text) < 0 || Convert.ToInt32(txtTGDTT_QDCB.Text) > 999)
            {
                MessageBox.Show("Thời gian dừng tối thiểu không hợp lệ!  vui lòng nhập ký tự số từ 0 đến 999", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGDTT_QDCB.BackColor = Color.LightPink;
            }
            #endregion

            #region TestError4 Max_Wait_Time

            else if (string.IsNullOrEmpty(txtTGDTD_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời gian dừng tối đa!", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGDTD_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtTGDTD_QDCB.Text) || Convert.ToInt32(txtTGDTD_QDCB.Text) < 0 || Convert.ToInt32(txtTGDTD_QDCB.Text) > 999)
            {
                MessageBox.Show("Thời gian dừng tối đa không hợp lệ!  vui lòng nhập ký tự số từ 0 đến 999", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGDTD_QDCB.BackColor = Color.LightPink;
            }
            #endregion

            #region TestError5 Latest_Book

            else if (string.IsNullOrEmpty(txtTGCNDV_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời gian chậm nhất đặt vé!", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGCNDV_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtTGCNDV_QDCB.Text) || Convert.ToInt32(txtTGCNDV_QDCB.Text) < 0 || Convert.ToInt32(txtTGCNDV_QDCB.Text) > 99)
            {
                MessageBox.Show("Thời gian chậm nhất đặt vé không hợp lệ!  vui lòng nhập ký tự số từ 0 đến 99", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGCNDV_QDCB.BackColor = Color.LightPink;
            }
            #endregion

            #region TestError6 Latest_Cancle_Book

            else if (string.IsNullOrEmpty(txtTGCNHV_QDCB.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời gian chậm nhất hủy đặt vé!", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGCNHV_QDCB.BackColor = Color.LightPink;
            }
            else if (regS.IsMatch(txtTGCNHV_QDCB.Text) || Convert.ToInt32(txtTGCNHV_QDCB.Text) < 0 || Convert.ToInt32(txtTGCNHV_QDCB.Text) > 99)
            {
                MessageBox.Show("Thời gian chậm nhất đặt vé không hợp lệ! Vui lòng nhập ký tự số từ 0 đến 99", "Thông tin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTGCNHV_QDCB.BackColor = Color.LightPink;
            }


            #endregion

            else
            {
                int Min_Fly_Time = Convert.ToInt32(txtTGBTT_QDCB.Text); //reg1
                int Num_Tran_Airpot = Convert.ToInt32(txtSSBTGTD_QDCB.Text);
                int Min_Wait_Time = Convert.ToInt32(txtTGDTT_QDCB.Text);
                int Max_Wait_Time = Convert.ToInt32(txtTGDTD_QDCB.Text);
                int Latest_Time_Book = Convert.ToInt32(txtTGCNDV_QDCB.Text);
                int Latest_Time_Cancel = Convert.ToInt32(txtTGCNHV_QDCB.Text);

                string query = "EXEC SETTING_UPDATE "
                            + " @min_fly_time = "
                            + Min_Fly_Time
                            + " , @num_tran_airpot = "
                            + Num_Tran_Airpot
                            + " , @min_wait_time ="
                            + Min_Wait_Time
                            + " , @max_wait_time ="
                            + Max_Wait_Time
                            + " , @latest_time_book ="
                            + Latest_Time_Book
                            + " , @latest_time_cancel ="
                            + Latest_Time_Cancel;

                int a = DataProvider.Instance.ExecuteNonQuery(query);
                if (a > 0) MessageBox.Show("Cập nhật thành công", "Thông tin cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTGBTT_QDCB.BackColor = Color.White;
                this.txtSSBTGTD_QDCB.BackColor = Color.White;
                this.txtTGDTD_QDCB.BackColor = Color.White;
                this.txtTGDTT_QDCB.BackColor = Color.White;
                this.txtTGCNDV_QDCB.BackColor = Color.White;
                this.txtTGCNHV_QDCB.BackColor = Color.White;
            }

            ThamSoController.Instance.LoadThamSo();
            LoadThamSo();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
               btn_capnhat_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btn_thoat_Click(this, new EventArgs());
            }
           
        }
    }
}
