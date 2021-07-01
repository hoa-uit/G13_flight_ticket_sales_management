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
    public partial class QLSanBay : Form
    {
        public QLSanBay()
        {
            InitializeComponent();
        }

        private void btnClose_changepassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLSanBay_Load(object sender, EventArgs e)
        {
            LoadListSanBay();
           // AddBinding();
        }
        void LoadListSanBay()
        {
            dtgSanBay_QLSB.DataSource = SanBayController.Instance.GetListSanBay();
            for (int i = 0; i< dtgSanBay_QLSB.Rows.Count; i++)
            {
                dtgSanBay_QLSB.Rows[i].Cells["XoaSB"].Value = "Xóa";
            }
                
        }
       

        #region thêm sân bay
        private void btnThem_QLSB_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[S]{1}[B]{1}[0-9]{2}$");
            if (string.IsNullOrEmpty(txtTenSB_QLSB.Text) || string.IsNullOrEmpty(txtMaSB_QLSB.Text) || string.IsNullOrEmpty(txtDiaChi_QLSB.Text) || string.IsNullOrEmpty(txtQuocGia_QLSB.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (reg.IsMatch(txtMaSB_QLSB.Text) == false)
            {
                errorMaSB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaSB.SetError(txtMaSB_QLSB, "Mã số sân bay chưa đúng cú pháp. Vui lòng nhập lại!");
            }
            else
            {
                // sau khi thông tin đã được điền đầy đủ
                // kiểm tra xem manv đã tồn tại hay chưa

                List<string> listMaSB = SanBayController.Instance.ListMaSB();
                int flag = 0;
                string masb = txtMaSB_QLSB.Text;
                foreach (string item in listMaSB)
                {
                    if (item.Trim() == masb.Trim())
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Mã sân bay này đã tồn tại","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn lưu sân bay với thông tin:" +
                        "\n Mã sân bay : " + txtMaSB_QLSB.Text + 
                        "\n Tên sân bay " + txtTenSB_QLSB.Text +
                        "\n Quốc gia : " + txtQuocGia_QLSB.Text +
                        "\n Tỉnh/Thành phố : " + txtDiaChi_QLSB.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        string query = string.Format("INSERT INTO SANBAY VALUES ('{0}',N'{1}',N'{2}',N'{3}')", txtMaSB_QLSB.Text, txtTenSB_QLSB.Text, txtQuocGia_QLSB.Text, txtDiaChi_QLSB.Text);

                        int a = DataProvider.Instance.ExecuteNonQuery(query);

                        if (a > 0)
                        {
                            MessageBox.Show("Lưu sân bay thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListSanBay();

                        }
                        else
                        {
                            MessageBox.Show("Lưu sân bay không thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                        
                   
                }
            }

        }
        #endregion

        #region sửa sân bay
        private void btnSua_QLSB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSB_QLSB.Text) || string.IsNullOrEmpty(txtMaSB_QLSB.Text) || string.IsNullOrEmpty(txtDiaChi_QLSB.Text) || string.IsNullOrEmpty(txtQuocGia_QLSB.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // sau khi thông tin đã được điền đầy đủ
                // kiểm tra xem manv đã tồn tại hay chưa

                List<string> listMaSB = SanBayController.Instance.ListMaSB();
                int flag = 0;
                string masb = txtMaSB_QLSB.Text;
                foreach (string item in listMaSB)
                {
                    if (item.Trim() == masb.Trim())
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    string query = string.Format("UPDATE SANBAY SET TenSanBay = N'{0}', QuocGia = N'{1}', DiaChi= N'{2}' WHERE MaSanBay = '{3}'", txtTenSB_QLSB.Text, txtQuocGia_QLSB.Text, txtDiaChi_QLSB.Text,txtMaSB_QLSB.Text);

                    int a = DataProvider.Instance.ExecuteNonQuery(query);

                    if (a > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin sân bay thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListSanBay();
                        
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sân bay  không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                   
                }
                else
                {
                    MessageBox.Show("Mã sân bay này chưa tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void btnThemmoi_QLSB_Click(object sender, EventArgs e)
        {
            
            txtDiaChi_QLSB.Text = "";
            txtMaSB_QLSB.Text = "";
            txtQuocGia_QLSB.Text = "";
            txtTenSB_QLSB.Text = "";
            errorMaSB.SetError(txtMaSB_QLSB, "");
        }

        private void txtMaSB_QLSB_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[S]{1}[B]{1}[0-9]{2}$");
            if (string.IsNullOrEmpty(txtMaSB_QLSB.Text))
            {
                errorMaSB.SetError(txtMaSB_QLSB, "");
            }
            else if (reg.IsMatch(txtMaSB_QLSB.Text) == false)
            {
                errorMaSB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaSB.SetError(txtMaSB_QLSB, "Mã sân bay cú pháp chưa đúng. Vui lòng nhập lại!");
            }
            else
            {
                errorMaSB.SetError(txtMaSB_QLSB, "");
            }
        }

        private void dtgSanBay_QLSB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
               
                    if (e.ColumnIndex == dtgSanBay_QLSB.Columns["XoaSB"].Index)
                    {
                        string MaSB = dtgSanBay_QLSB.Rows[e.RowIndex].Cells["Column1"].Value.ToString().Trim();
                        string query = string.Format("select * from CHUYENBAY WHERE SanBayDi = '{0}' or SanBayDen = '{1}'", MaSB,MaSB);
                  
                    DataTable table = DataProvider.Instance.ExecuteQuery(query);
                    int a = table.Rows.Count;
                        
                    if (a>0)
                            MessageBox.Show("Sân bay này đã tồn tại trong các chuyến bay, không thể xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                        {
                            DialogResult result = MessageBox.Show("Bạn muốn xóa sân bay có mã "+ MaSB +" không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {

                                string query2 = string.Format("DELETE FROM SANBAY WHERE MaSanBay = '{0}'", MaSB);

                                int b = DataProvider.Instance.ExecuteNonQuery(query2);

                                if (b > 0)
                                {
                                    MessageBox.Show("Xóa sân bay thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadListSanBay();
                                }
                                else
                                {
                                    MessageBox.Show("Xóa sân bay không thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                        }


                    }
                    else
                    {
                        txtMaSB_QLSB.Text = dtgSanBay_QLSB.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                        txtTenSB_QLSB.Text = dtgSanBay_QLSB.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtQuocGia_QLSB.Text = dtgSanBay_QLSB.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtDiaChi_QLSB.Text = dtgSanBay_QLSB.Rows[e.RowIndex].Cells[3].Value.ToString();
                    errorMaSB.SetError(txtMaSB_QLSB, "");
                    }    
               
            }
        }

        //private void QLSanBay_KeyDown(object sender, KeyEventArgs e)

        private void btnThoat_QLSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_QLSB_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenSB_QLSB.Text) || string.IsNullOrEmpty(txtMaSB_QLSB.Text) || string.IsNullOrEmpty(txtDiaChi_QLSB.Text) || string.IsNullOrEmpty(txtQuocGia_QLSB.Text))
            {
                MessageBox.Show("Bạn phỉa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // sau khi thông tin đã được điền đầy đủ
                // kiểm tra xem manv đã tồn tại hay chưa

                List<string> listMaSB = SanBayController.Instance.ListMaSB();
                int flag = 0;
                string masb = txtMaSB_QLSB.Text;
                foreach (string item in listMaSB)
                {
                    if (item.Trim() == masb.Trim())
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    string query = string.Format("UPDATE SANBAY SET TenSanBay = N'{0}', QuocGia = N'{1}', DiaChi= N'{2}' WHERE MaSanBay = '{3}'", txtTenSB_QLSB.Text, txtQuocGia_QLSB.Text, txtDiaChi_QLSB.Text, txtMaSB_QLSB.Text);

                    int a = DataProvider.Instance.ExecuteNonQuery(query);

                    if (a > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin sân bay thành công");
                        LoadListSanBay();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sân bay thành công");

                    }

                }
                else
                {
                    MessageBox.Show("Mã sân bay này chưa tồn tại");
                }
            }
        }

        private void QLSanBay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnThem_QLSB_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnThemmoi_QLSB_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnThoat_QLSB_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.M)

            {
                btnSua_QLSB_Click(this, new EventArgs());
            }
        }
    }
}
