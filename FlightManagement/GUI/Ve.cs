using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using FlightManagement.Model;

namespace FlightManagement
{
    public partial class Ve : Form
    { Ghe BtnSelect;
        public SendMessage send;
        public Ve(string MaChuyenBay, SendMessage e)
        {
            InitializeComponent();
            txtMCB_Ve.Text = MaChuyenBay;
            Load_TicKet(MaChuyenBay);
            this.send = e;
        }

        void Load_TicKet(string MaChuyenBay)
        {
            List < Ghe > ListGhe = GheController.Instance.GheLoad(MaChuyenBay);
            foreach (Ghe item in ListGhe)
            {
                Button btn = new Button() { Width = 60, Height = 60, };

                btn.Text = "Vị Trí " + item.ViTri + Environment.NewLine + "Hạng Vé " + item.MaHangVe;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TinhTrang)
                {
                    case 1:
                        {
                            btn.BackColor = Color.LightCoral;
                            break;
                        }
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                flpGhe_Ve.Controls.Add(btn);
            }


        }
        void btn_Click(object sender, EventArgs e)
        {
            BtnSelect = (sender as Button).Tag as Ghe;
            if(BtnSelect.TinhTrang == 1)
            {
                MessageBox.Show("Ghế đã có người. Xin vui lòng chọn ghế khác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtViTri_Ve.Text = ((sender as Button).Tag as Ghe).ViTri.ToString();
                txtHangVe_Ve.Text = ((sender as Button).Tag as Ghe).MaHangVe.ToString();

                double x = double.Parse(((sender as Button).Tag as Ghe).Gia.ToString());
               
               CultureInfo culture = new CultureInfo("vi-VN");
                txtGia_Ve.Text = x.ToString("c", culture);

            }

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[1-9]{1}[0-9]{8}$");
            Regex reg2 = new Regex("^[0]{1}[1-9]{1}[0-9]{8}$");
          
            if (string.IsNullOrEmpty(txtCMND_Ve.Text) ||string.IsNullOrEmpty(txtTenHK_Ve.Text) ||string.IsNullOrEmpty(txtSDT_Ve.Text))
            {
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtHangVe_Ve.Text))
            {
                MessageBox.Show("Xin mời bạn hãy chọn ghế", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (reg.IsMatch(txtCMND_Ve.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_Ve, "Chứng minh nhân dân không hợp lệ");
            }
            else if (reg2.IsMatch(txtSDT_Ve.Text) == false)
            {
                errorSDT.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorSDT.SetError(txtSDT_Ve, "Số điện thoại không hợp lệ");
            }  
            else
            {
                string Maghe = BtnSelect.Id;
                string MaCB = BtnSelect.MaChuyenBay;
                string CMND = txtCMND_Ve.Text.ToString();
                string Name = txtTenHK_Ve.Text.ToString();
                string Phone = txtSDT_Ve.Text.ToString();
                float Gia = BtnSelect.Gia;
                string query = "EXEC INSERT_PASSENGER '" + MaCB + "', N'" + Name + "', '" + CMND + "', '" + Phone + "', '" + Maghe + "', '" + Gia + "'";
                if (DataProvider.Instance.ExecuteNonQuery(query) != -1)
                {
                    MessageBox.Show("Thanh toán thành công! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sove = Maghe + "1";
                    string query11 = "exec LAYTENSANBAYDI " + txtMCB_Ve.Text;
                    string sanbaydi = DataProvider.Instance.ExecuteQuery(query11).Rows[0][0].ToString();
                    string query12 = "exec LAYTENSANBAYDEN " + txtMCB_Ve.Text;
                    string sanbayden = DataProvider.Instance.ExecuteQuery(query12).Rows[0][0].ToString();
                    string hanhtrinh = sanbaydi + "-" + sanbayden;
                    Thanhtoan th = new Thanhtoan(Name, Phone, CMND, sove, hanhtrinh, Gia.ToString(), txtGia_Ve.Text, DateTime.Now.Date.ToString());
                    th.Show();
                    btnThemmoi_Ve_Click(this, new EventArgs());
                    this.send();

                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }




        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Ve_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                bunifuThinButton21_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                btn_ThanhToan_Click(this, new EventArgs());
            }
        }

     

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtCMND_Ve.Text))
            {
                errorCMND.SetError(txtCMND_Ve, "");
            }
            else if (reg.IsMatch(txtCMND_Ve.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_Ve, "CMND phải là các kí tự số");
            }
            else
            {
                errorCMND.SetError(txtCMND_Ve, "");
            }
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtSDT_Ve.Text))
            {
                errorSDT.SetError(txtSDT_Ve, "");
            }
            else if (reg.IsMatch(txtSDT_Ve.Text) == false)
            {
                errorSDT.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorSDT.SetError(txtSDT_Ve, "Số điện thoại phải là các kí tự số");
            }
            else
            {
                errorSDT.SetError(txtSDT_Ve, "");
            }
        }

        private void btnThemmoi_Ve_Click(object sender, EventArgs e)
        {
            txtCMND_Ve.Text = "";
            txtGia_Ve.Text = "";
            txtSDT_Ve.Text = "";
            txtTenHK_Ve.Text = "";
            txtHangVe_Ve.Text = "";
            txtViTri_Ve.Text = "";
            errorCMND.SetError(txtCMND_Ve, "");
            errorSDT.SetError(txtSDT_Ve, "");
            flpGhe_Ve.Controls.Clear();
            Load_TicKet(txtMCB_Ve.Text);
        }

        private void Ve_Load(object sender, EventArgs e)
        {

        }
    }
}
