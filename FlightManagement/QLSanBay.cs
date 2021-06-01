using FlightManagement.Controller;
using FlightManagement.Model;
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
        }
       

        #region thêm sân bay
        private void btnThem_QLSB_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Mã sân bay này đã tồn tại");
                }
                else
                {
                    string query = string.Format("INSERT INTO SANBAY VALUES ('{0}',N'{1}',N'{2}',N'{3}')", txtMaSB_QLSB.Text, txtTenSB_QLSB.Text,txtQuocGia_QLSB.Text,txtDiaChi_QLSB.Text);
           
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    
                    if (a > 0)
                    {
                        MessageBox.Show("Lưu sân bay thành công");
                        LoadListSanBay();
                        txtMaSB_QLSB.Text = "";
                        txtTenSB_QLSB.Text = "";
                        txtDiaChi_QLSB.Text = "";
                        txtQuocGia_QLSB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lưu sân bay không thành công");

                    }
                }
            }

        }
        #endregion


        #region xóa sân bay
        private void btnXoa_QLSB_Click(object sender, EventArgs e)
        {
            List<string> listMaSB = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaSanBay FROM SANBAY");
            foreach (DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                
                listMaSB.Add(x);
            }
           
            int flag = 0;
            string masb = txtMaSB_QLSB.Text;
            foreach (string item in listMaSB)
            {
                 
                if (item.Trim() == masb.Trim())
                {
                    flag = 1;
                }    
                 
            }
            if (flag == 0)
            {
                MessageBox.Show("Mã sân bay này chưa tồn tại");
            }
            else
            {
                string query = string.Format("DELETE FROM SANBAY WHERE MaSanBay = '{0}'", txtMaSB_QLSB.Text);
              
                int a = DataProvider.Instance.ExecuteNonQuery(query);
                
                if (a > 0)
                {
                    MessageBox.Show("Xóa sân bay thành công");
                    LoadListSanBay();
                }
                else
                {
                    MessageBox.Show("Xóa sân bay không thành công");

                }
            }
        }

        #endregion


        #region sửa sân bay
        private void btnSua_QLSB_Click(object sender, EventArgs e)
        {

        }
        #endregion

      
    }
}
