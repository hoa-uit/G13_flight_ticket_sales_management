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
    public partial class PHIEUDATCHO : Form
    {
        Ghe BtnSelect;
        public SM mess;
        public PHIEUDATCHO(String macb, SM e)
        {
            InitializeComponent();
            Load_TicKet(macb);
            txtGia_PDC.ForeColor = Color.Red;
            this.mess = e;
           


        }
        void Load_TicKet(string MaChuyenBay)
        {
            bool check = GheController.Instance.Check_date(MaChuyenBay);
            if (check == true)
            {
                flpGhe_PDC.Controls.Clear();
                txtMCB_PDC.Text = MaChuyenBay;
                List<Ghe> ListGhe = GheController.Instance.GheLoad(MaChuyenBay);
                foreach (Ghe item in ListGhe)
                {
                    Button btn = new Button() { Width = 60, Height = 60, };

                    btn.Text = "Vị Trí " + item.ViTri + Environment.NewLine + "Hạng Vé " + item.MaHangVe;
                    btn.Click += btn_Click;
                    btn.Tag = item;
                    switch (item.TinhTrang)
                    {
                        case 0:
                            {
                                btn.BackColor = Color.LightBlue;
                                break;
                            }
                        case 3:
                            {
                                btn.BackColor = Color.Silver;
                                break;
                            }
                        default:
                            btn.BackColor = Color.LightCoral;
                            break;
                    }
                    flpGhe_PDC.Controls.Add(btn);
                }
            }
            else
            {
                flpGhe_PDC.Controls.Clear();
                txtMCB_PDC.Text = MaChuyenBay;
                List<Ghe> ListGhe = GheController.Instance.GheLoad(MaChuyenBay);
                foreach (Ghe item in ListGhe)
                {
                    Button btn = new Button() { Width = 60, Height = 60, };

                    btn.Text = "Vị Trí " + item.ViTri + Environment.NewLine + "Hạng Vé " + item.MaHangVe;
                    btn.Click += btn_Click;
                    btn.Tag = item;
                    btn.BackColor = Color.Silver;
                    flpGhe_PDC.Controls.Add(btn);
                }
            }
          
        }

      
        void btn_Click(object sender, EventArgs e)
        {

            BtnSelect = (sender as Button).Tag as Ghe;
            if (BtnSelect.TinhTrang == 1)
            {
                MessageBox.Show("Ghế đã có người xin vui lòng chọn ghế khác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool check = GheController.Instance.Check_date(BtnSelect.MaChuyenBay);
            // TXB_DIENTHOAI.Text = T.ThoiGianChamNhatDatVe.ToString();
          //  bool check_han = GheController.Instance.Check_hanPDC(BtnSelect.MaChuyenBay);
            if (BtnSelect.TinhTrang == 3)
            {
                MessageBox.Show("Phiếu đặt chỗ không còn khả dụng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (check == false)
            {
                MessageBox.Show("Ngày đặt không hợp lệ!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtViTri_PDC.Text = ((sender as Button).Tag as Ghe).ViTri.ToString();
                txtHangVe_PDC.Text = ((sender as Button).Tag as Ghe).MaHangVe.ToString();

                 double x= double.Parse(((sender as Button).Tag as Ghe).Gia.ToString());
                 CultureInfo culture = new CultureInfo("vi_VN");
                 txtGia_PDC.Text = x.ToString("c", culture);
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_DATCHO_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[1-9]{1}[0-9]{8}$");
            Regex reg2 = new Regex("^[0]{1}[1-9]{1}[0-9]{8}$");


            if (string.IsNullOrEmpty(txtCMND_PDC.Text) || string.IsNullOrEmpty(txtTenHK_PDC.Text) || string.IsNullOrEmpty(txtSDT_PDC.Text))
            {
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtHangVe_PDC.Text))
            {
                MessageBox.Show("Xin mời bạn hãy chọn ghế", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (reg.IsMatch(txtCMND_PDC.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_PDC, "Chứng minh nhân dân không hợp lệ");
            }
            else if (reg2.IsMatch(txtSDT_PDC.Text) == false)
            {
                errorSDT.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorSDT.SetError(txtSDT_PDC, "Số điện thoại không hợp lệ");
            }
            else
            {
                bool check_han = GheController.Instance.Check_hanPDC(BtnSelect.MaChuyenBay);
                if (check_han == true || BtnSelect.TinhTrang == 3)
                {
                    MessageBox.Show("Phiếu đặt chỗ không còn khả dụng, đặt chỗ thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Maghe = BtnSelect.Id;
                    string MaCb = BtnSelect.MaChuyenBay;
                    string CMND = txtCMND_PDC.Text.ToString();
                    string Name = txtTenHK_PDC.Text.ToString();
                    string SDT = txtSDT_PDC.Text.ToString();
                    float Gia = BtnSelect.Gia;
                    string MAHANGVE = txtHangVe_PDC.Text.ToString();
                    string query = "EXEC THEM_HANHKHACH '" + MaCb + "',N'" + Name + "', '" + CMND + "', '" + SDT + "', '" + Maghe + "', '" + Gia + "', '" + MAHANGVE + "'";

                    if (DataProvider.Instance.ExecuteNonQuery(query) != 1)
                    {
                        Ghe a = new Ghe();
                        a = GheController.Instance.LayMaDatCho(CMND);
                        MessageBox.Show("Đặt chỗ thành công! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bunifuThinButton22_Click(this, new EventArgs());
                        this.mess();
                    }
                    else
                    {
                        MessageBox.Show("Đặt chỗ thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            flpGhe_PDC.Controls.Clear();
            txtCMND_PDC.Clear();
            txtTenHK_PDC.Clear();
            txtSDT_PDC.Clear();
            txtHangVe_PDC.Clear();
            txtViTri_PDC.Clear();
            txtGia_PDC.Clear();
            
            Load_TicKet(txtMCB_PDC.Text);
        }

        private void btnClose_datcho_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PHIEUDATCHO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btn_DATCHO_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                bunifuThinButton21_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                bunifuThinButton22_Click(this, new EventArgs());
            }
        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtCMND_PDC.Text))
            {
                errorCMND.SetError(txtCMND_PDC, "");
            }
            else if (reg.IsMatch(txtCMND_PDC.Text) == false)
            {
                errorCMND.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorCMND.SetError(txtCMND_PDC, "CMND phải là các kí tự số");
            }
            else
            {
                errorCMND.SetError(txtCMND_PDC, "");
            }
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtSDT_PDC.Text))
            {
                errorSDT.SetError(txtSDT_PDC, "");
            }
            else if (reg.IsMatch(txtSDT_PDC.Text) == false)
            {
                errorSDT.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorSDT.SetError(txtSDT_PDC, "Số điện thoại phải là các kí tự số");
            }
            else
            {
                errorSDT.SetError(txtSDT_PDC, "");
            }
        }
    }
}
