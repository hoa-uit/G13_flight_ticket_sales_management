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
    public partial class txtMNV_Them_QLNV : Form
    {
        public txtMNV_Them_QLNV()
        {
            InitializeComponent();
            dtgvNhanVien_QLNV.DefaultCellStyle.ForeColor = Color.Black;
        }

       
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
           
            LoadListNV();
            addBinding();
            gbThongTinNhanVien_QLNV.BringToFront();
        }

       
        void addBinding()
        {
            txtMNV_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));
            txtTenNV_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "TenNV"));
            txtGT_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "GioiTinh"));
            txtSDT_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "SDT"));
            txtDiaChi_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "DiaChi"));
            cbbQuyen_Xem_QLNV.DataBindings.Add(new Binding("SelectedItem", dtgvNhanVien_QLNV.DataSource, "QuyenTruyCap"));
            txtNS_Xem_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "NgaySinh"));
            txtMNV_Sua_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));
            cbbQuyen_Sua_QLNV.DataBindings.Add(new Binding("SelectedItem", dtgvNhanVien_QLNV.DataSource, "QuyenTruyCap"));
            txtMaNV_Xoa_QLNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));

        }
        void LoadListNV()
        {
            dtgvNhanVien_QLNV.DataSource = NhanVienController.Instance.GetListNV();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LoadListNV();
            gbThongTinNhanVien_QLNV.BringToFront();
        }

        #region Xử lý thêm nhân viên
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            gbThemNV.BringToFront();
        
        }

        private void btnSave_ThemNhanVien_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]{8}$");
            Regex reg2 = new Regex("^[0]{1}[1-9]{1}[0-9]{8}$");
            if (string.IsNullOrEmpty(txtMaNV_Them_QLNV.Text) || string.IsNullOrEmpty(txtTenNV_Them_QLNV.Text) || string.IsNullOrEmpty(txtSDT_Them_QLNV.Text) || string.IsNullOrEmpty(txtDiaChi_Them_QLNV.Text) 
                || string.IsNullOrEmpty(txtMK_Them_QLNV.Text) || cbbGT_Them_QLNV.SelectedIndex == -1 || cbbQuyen_QLNV.SelectedIndex == -1)
            {
                if (reg.IsMatch(txtMaNV_Them_QLNV.Text)==false)
                {
                    errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorMaNV_Tim.SetError(txtMaNV_Them_QLNV, "Mã số nhân viên là chuỗi 8 kí tự số!");
                }
                if (reg2.IsMatch(txtSDT_Them_QLNV.Text) == false)
                {
                    errorMaNV_SuaQuyen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorQuyen_suaquyen.SetError(txtSDT_Them_QLNV, "Định dạng số điện thoại chưa đúng!");
                }    
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {
                // sau khi thông tin đã được điền đầy đủ
                // kiểm tra xem manv đã tồn tại hay chưa
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMaNV_Them_QLNV.Text;
                foreach (string item in listaccount)
                {
                    if (item.Trim() == msnv.Trim())
                        flag = 1;
                }
                if (flag == 1)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = string.Format("INSERT INTO NHANVIEN VALUES ('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}',N'{6}')", txtMaNV_Them_QLNV.Text, txtTenNV_Them_QLNV.Text,
                  dtpkNS_Them_QLNV.Value, cbbGT_Them_QLNV.SelectedItem.ToString(), txtSDT_Them_QLNV.Text, txtDiaChi_Them_QLNV.Text, cbbQuyen_QLNV.SelectedItem.ToString());
                    string query2 = string.Format("INSERT INTO TAIKHOANDANGNHAP VALUES ('{0}','{1}')", txtMaNV_Them_QLNV.Text, txtMK_Them_QLNV.Text);
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    int b = DataProvider.Instance.ExecuteNonQuery(query2);
                    if (a > 0 && b>0)
                    {
                        MessageBox.Show("Lưu nhân viên thành công!","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListNV();
                        txtMaNV_Them_QLNV.Text = "";
                        txtTenNV_Them_QLNV.Text = "";
                        txtMK_Them_QLNV.Text = "";
                        txtDiaChi_Them_QLNV.Text = "";
                        txtSDT_Them_QLNV.Text = "";
                        cbbGT_Them_QLNV.SelectedIndex = -1;
                        cbbGT_Them_QLNV.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Lưu nhân viên không thành công!", "THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    }
                }
            }    
           

        }

        #endregion


        #region xử lý xóa nhân viên
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            gbXoaNV_QLNV.BringToFront();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]{8}$");
            if (string.IsNullOrEmpty(txtMaNV_Xoa_QLNV.Text) || reg.IsMatch(txtMaNV_Xoa_QLNV.Text) == false)
            {
                errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaNV_Tim.SetError(txtMaNV_Xoa_QLNV, "Mã nhân viên trống hoặc chưa đúng cú pháp, mã nhân viên là chuỗi 8 kí tự số");
            }   
            else
            {
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMaNV_Xoa_QLNV.Text;
                foreach (string item in listaccount)
                {
                    if (item.Trim() == msnv.Trim())
                        flag = 1;
                }
                if (flag == 0)
                {
                    MessageBox.Show("MaNV này chưa tồn tại");
                }
                else
                {
                    string query = string.Format("DELETE FROM NHANVIEN WHERE MaNV = '{0}'", txtMaNV_Xoa_QLNV.Text);
                    string query2 = string.Format("DELETE FROM TAIKHOANDANGNHAP WHERE MaNhanVien = '{0}'", txtMaNV_Xoa_QLNV.Text);
                    int b = DataProvider.Instance.ExecuteNonQuery(query2);
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    
                    if (a > 0 && b > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }    
           
        }

        #endregion


        #region xử lý sửa quyền nhân viên
        private void btnSua_QLNV_Click(object sender, EventArgs e)
        {
            gbSuaQuyen_QLNV.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMNV_Sua_QLNV.Text) || cbbQuyen_Sua_QLNV.SelectedIndex == -1)
            {
                // các errorprovider
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMNV_Sua_QLNV.Text;
                foreach (string item in listaccount)
                {
                    if (item.Trim() == msnv.Trim())
                        flag = 1;
                }
                if (flag == 0)
                {
                    MessageBox.Show("MaNV này chưa tồn tại");
                }
                else
                {
                    string query = string.Format("UPDATE NHANVIEN SET QuyenTruyCap = N'{0}' WHERE MaNV = '{1}'", cbbQuyen_Sua_QLNV.SelectedItem.ToString(), txtMNV_Sua_QLNV.Text);
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    if (a > 0)
                    {
                        MessageBox.Show("Sửa quyền thành công");
                        LoadListNV();

                    }
                    else
                    {
                        MessageBox.Show("Sửa quyền thất bại");

                    }
                }

            }
             
        }
        #endregion

        private void btnClose_QLNV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbQuyen_Sua_QLNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
