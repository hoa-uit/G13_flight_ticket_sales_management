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
    public partial class QLHangVe : Form
    {
        public QLHangVe()
        {
            InitializeComponent();
            Load_Form();
        }
        void Load_Form()
        {
          
            errorMaHV.SetError(txtMaHV_QLHV, "");
            dtgHangVe_QLHV.AutoGenerateColumns = false;
            dtgHangVe_QLHV.DataSource = HangVeController.Instance.Load_HangVe();
            dtgHangVe_QLHV.Columns["XoaHV"].DefaultCellStyle.NullValue = "Xóa";
            

        }
        private void btnClose_QLHangve_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_QLSB_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[H]{1}[V]{1}[0-9]{2}$");
            if (string.IsNullOrEmpty(txtMaHV_QLHV.Text) || string.IsNullOrEmpty(txtTenHV_QLHV.Text) || string.IsNullOrEmpty(txtTyLe_QLHV.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (reg.IsMatch(txtMaHV_QLHV.Text) == false)
            {
                errorMaHV.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaHV.SetError(txtMaHV_QLHV, "Mã hạng vé cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                List<string> listMaHV = HangVeController.Instance.ListMaHV();
                int flag = 0;
                string mahv = txtMaHV_QLHV.Text;
                foreach (string item in listMaHV)
                {
                    if (item.Trim() == mahv.Trim())
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Mã hạng vé này đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn lưu hạng vé mới với thông tin:" +
                       "\n Mã hạng vé : " + txtMaHV_QLHV.Text +
                       "\n Tên hạng vé " + txtTenHV_QLHV.Text +
                       "\n Tỷ lệ : " + txtTyLe_QLHV.Text
                      , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        HangVeController.Instance.ThemHangVe(txtMaHV_QLHV.Text.ToString(), txtTenHV_QLHV.Text.ToString(), txtTyLe_QLHV.Text.ToString());
                        Load_Form();
                    }
                }
            }
        }

     

        private void btnThemmoi_QLSB_Click(object sender, EventArgs e)
        {
            txtMaHV_QLHV.Text = "";
            txtTenHV_QLHV.Text = "";
            txtTyLe_QLHV.Text = "";
            
            errorMaHV.SetError(txtMaHV_QLHV, "");
            errorTyle.SetError(txtTyLe_QLHV, "");
        }

        private void dtgHangVe_QLHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                if (e.ColumnIndex == dtgHangVe_QLHV.Columns["XoaHV"].Index)
                {
                    string MaHV = dtgHangVe_QLHV.Rows[e.RowIndex].Cells["Column1"].Value.ToString().Trim();
                    string query = string.Format("select * from CHITIETHANGVE WHERE MaHangVe = '{0}'", MaHV);

                    DataTable table = DataProvider.Instance.ExecuteQuery(query);
                    int a = table.Rows.Count;

                    if (a > 0)
                        MessageBox.Show("Hạng vé này đã tồn tại trong các chuyến bay, không thể xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn muốn xóa hạng vé có mã " + MaHV + " không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            string query2 = string.Format("DELETE FROM HANGVE WHERE MaHangVe = '{0}'", MaHV);

                            int b = DataProvider.Instance.ExecuteNonQuery(query2);

                            if (b > 0)
                            {
                                MessageBox.Show("Xóa hạng vé thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Load_Form();
                            }
                            else
                            {
                                MessageBox.Show("Xóa hạng vé không thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }


                }
                else
                {
                    txtMaHV_QLHV.Text = dtgHangVe_QLHV.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    txtTenHV_QLHV.Text = dtgHangVe_QLHV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTyLe_QLHV.Text = dtgHangVe_QLHV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    errorMaHV.SetError(txtMaHV_QLHV, "");
                    errorTyle.SetError(txtTyLe_QLHV, "");
                }

            }
           
        }

        private void txtMaHV_QLHV_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[H]{1}[V]{1}[0-9]{2}$");
            if (string.IsNullOrEmpty(txtMaHV_QLHV.Text))
            {
                errorMaHV.SetError(txtMaHV_QLHV, "");
            }   
            else if (reg.IsMatch(txtMaHV_QLHV.Text) == false)
            {
                errorMaHV.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaHV.SetError(txtMaHV_QLHV, "Mã hạng vé cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                errorMaHV.SetError(txtMaHV_QLHV, "");
            }
                
            
        }

        private void QLHangVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuu_QLSB_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
               btnThemmoi_QLSB_Click(this, new EventArgs());
            }
            if(e.Control && e.KeyCode == Keys.E)
            {
                btnThoat_QLHV_Click(this, new EventArgs());
            }
            if(e.Control && e.KeyCode == Keys.M)

            {
                btnSua_QLHV_Click(this, new EventArgs());
            }
           
        }

        private void dtgHangVe_QLHV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["XoaHV"].Value = "Xóa";
        }

        private void btnThoat_QLHV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_QLHV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHV_QLHV.Text) || string.IsNullOrEmpty(txtTenHV_QLHV.Text) || string.IsNullOrEmpty(txtTyLe_QLHV.Text))
            {
                MessageBox.Show("Bạn phỉa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HangVeController.Instance.SuaHangVe(txtMaHV_QLHV.Text, txtTenHV_QLHV.Text, txtTyLe_QLHV.Text);
                Load_Form();
            }
        }

       

        private void txtTyLe_QLHV_TextChanged(object sender, EventArgs e)
        {
            
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtTyLe_QLHV.Text))
            {
                errorTyle.SetError(txtTyLe_QLHV, "");
            }    
            else if (reg.IsMatch(txtTyLe_QLHV.Text) == false)
            {
                errorTyle.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorTyle.SetError(txtTyLe_QLHV, "Tỷ lệ phải là các kí tự số");
            }
            else
            {
                int a = int.Parse(txtTyLe_QLHV.Text.ToString());
                if (a < 1)
                {
                    errorTyle.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorTyle.SetError(txtTyLe_QLHV, "chú ý tỉ lệ tối thiểu là 1");
                }
                else
                {
                    errorTyle.SetError(txtTyLe_QLHV, "");

                }
            }    
           
        }

       
    }
}
