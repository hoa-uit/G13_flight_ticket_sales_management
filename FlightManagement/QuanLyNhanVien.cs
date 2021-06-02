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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnClose_QLNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
           
            LoadListNV();
            addBinding();
            gbThongTinNhanVien_QLNV.BringToFront();
        }

       
        void addBinding()
        {
            txtManv_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));
            txtTenNV_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "TenNV"));
            txtGioiTinh_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "GioiTinh"));
            txtSDT_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "SDT"));
            txtDiaChi_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "DiaChi"));
            cbQuyen_TTNV.DataBindings.Add(new Binding("SelectedItem", dtgvNhanVien_QLNV.DataSource, "QuyenTruyCap"));
            txtNgaySinh_TTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "NgaySinh"));
            txtMaNV_SuaQuyen.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));
            cbQuyen_suaquyen.DataBindings.Add(new Binding("SelectedItem", dtgvNhanVien_QLNV.DataSource, "QuyenTruyCap"));
            txtMaNV_XoaNV.DataBindings.Add(new Binding("Text", dtgvNhanVien_QLNV.DataSource, "MaNV"));

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
            if (string.IsNullOrEmpty(txtMaNV_ThemNV.Text) || string.IsNullOrEmpty(txtTenNV_ThemNV.Text) || string.IsNullOrEmpty(txtSDT_ThemNV.Text) || string.IsNullOrEmpty(txtDiaChi_ThemNV.Text) 
                || string.IsNullOrEmpty(txtPassWord_ThemNV.Text) || cbGioiTinh_ThemNV.SelectedIndex == -1 || cbQuyen_ThemNV.SelectedIndex == -1)
            {
                if (reg.IsMatch(txtMaNV_ThemNV.Text)==false)
                {
                    errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorMaNV_Tim.SetError(txtMaNV_ThemNV, "Mã số nhân viên là chuỗi 8 kí tự số");
                }
                if (reg2.IsMatch(txtSDT_ThemNV.Text) == false)
                {
                    errorMaNV_SuaQuyen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorQuyen_suaquyen.SetError(txtSDT_ThemNV, "Định dạng số điện thoại chưa đúng");
                }    
                MessageBox.Show("Bạn phỉa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {
                // sau khi thông tin đã được điền đầy đủ
                // kiểm tra xem manv đã tồn tại hay chưa
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMaNV_ThemNV.Text;
                foreach (string item in listaccount)
                {
                    if (item.Trim() == msnv.Trim())
                        flag = 1;
                }
                if (flag == 1)
                {
                    MessageBox.Show("MaNV này đã tồn tại");
                }
                else
                {
                    string query = string.Format("INSERT INTO NHANVIEN VALUES ('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}','{6}')", txtMaNV_ThemNV.Text, txtTenNV_ThemNV.Text,
                  dtpNgaySinh_ThemNV.Value, cbGioiTinh_ThemNV.SelectedItem.ToString(), txtSDT_ThemNV.Text, txtDiaChi_ThemNV.Text, cbQuyen_ThemNV.SelectedItem.ToString());
                    string query2 = string.Format("INSERT INTO TAIKHOANDANHNHAP VALUES ('{0}','{1}')", txtMaNV_ThemNV.Text, txtPassWord_ThemNV.Text);
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    int b = DataProvider.Instance.ExecuteNonQuery(query2);
                    if (a > 0 && b>0)
                    {
                        MessageBox.Show("Lưu nhân viên thành công");
                        LoadListNV();
                        txtMaNV_ThemNV.Text = "";
                        txtTenNV_ThemNV.Text = "";
                        txtPassWord_ThemNV.Text = "";
                        txtDiaChi_ThemNV.Text = "";
                        txtSDT_ThemNV.Text = "";
                        cbGioiTinh_ThemNV.SelectedIndex = -1;
                        cbGioiTinh_ThemNV.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Lưu nhân viên không thành công");

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
            if (string.IsNullOrEmpty(txtMaNV_XoaNV.Text) || reg.IsMatch(txtMaNV_XoaNV.Text) == false)
            {
                errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaNV_Tim.SetError(txtMaNV_XoaNV, "Mã nhân viên trống hoặc chưa đúng cú pháp, mã nhân viên là chuỗi 8 kí tự số");
            }   
            else
            {
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMaNV_XoaNV.Text;
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
                    string query = string.Format("DELETE FROM NHANVIEN WHERE MaNV = '{0}'", txtMaNV_XoaNV.Text);
                    string query2 = string.Format("DELETE FROM TAIKHOANDANHNHAP WHERE MaNhanVien = '{0}'", txtMaNV_XoaNV.Text);
                    int a = DataProvider.Instance.ExecuteNonQuery(query);
                    int b = DataProvider.Instance.ExecuteNonQuery(query2);
                    if (a > 0 && b > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công");

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
            if (string.IsNullOrEmpty(txtMaNV_SuaQuyen.Text) || cbQuyen_suaquyen.SelectedIndex == -1)
            {
                // các errorprovider
                
            }
            else
            {
                List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                int flag = 0;
                string msnv = txtMaNV_SuaQuyen.Text;
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
                    string query = string.Format("UPDATE NHANVIEN SET QuyenTruyCap = '{0}' WHERE MaNV = '{1}'", cbQuyen_suaquyen.SelectedItem.ToString(), txtMaNV_SuaQuyen.Text);
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


        #region tìm nhân viên
        private void btnTim_QLNV_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]{8}$");
            if (reg.IsMatch(txtTim_QLNV.Text))
            {
                if (string.IsNullOrEmpty(txtTim_QLNV.Text))
                {
                    errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorMaNV_Tim.SetError(txtTim_QLNV, "Hãy nhập mã số nhân viên");
                }
                else
                {
                    List<string> listaccount = GetListMaNV.Instance.ListMSNV_Account();
                    int flag = 0;
                    string msnv = txtTim_QLNV.Text;
                    foreach (string item in listaccount)
                    {
                        if (item.Trim() == msnv.Trim())
                            flag = 1;
                    }
                    if (flag == 1)
                    {
                        string query = string.Format("SELECT * FROM NHANVIEN WHERE MaNV = '{0}'", txtTim_QLNV.Text);
                        dtgvNhanVien_QLNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else
                    {
                        MessageBox.Show("Mã số nhân viên chưa tồn tại");
                    }
                }
            }    
            else
            {
                errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaNV_Tim.SetError(txtTim_QLNV, "Mã số sinh viên là dãy 8 kí tự số");
            }
            

        }

        private void txtTim_QLNV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim_QLNV.Text))
            {
                errorMaNV_Tim.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaNV_Tim.SetError(txtTim_QLNV, "Hãy nhập mã số nhân viên");
            }
            else
            {
                errorMaNV_Tim.SetError(txtTim_QLNV, "");
            }
        }
        #endregion


    }
}
