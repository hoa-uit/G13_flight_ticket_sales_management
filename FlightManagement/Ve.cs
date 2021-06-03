using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Controller;
using FlightManagement.Model;

namespace FlightManagement
{
    public partial class Ve : Form
    { Ghe BtnSelect;
        public Ve(string MaChuyenBay)
        {
            InitializeComponent();
            Flight_Text.Text = MaChuyenBay;
            Load_TicKet(MaChuyenBay);
        }

        void Load_TicKet(string MaChuyenBay)
        {
            List < Ghe > ListGhe = GheController.Instance.GheLoad(MaChuyenBay);
            foreach (Ghe item in ListGhe)
            {
                Button btn = new Button() { Width = 50, Height = 50, };

                btn.Text = "Vị Trí " + item.ViTri + Environment.NewLine + "Hang Ve" + item.Level;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TinhTrang)
                {
                    case 0:
                        {
                            btn.BackColor = Color.Green;


                            break;
                        }
                    default:
                        btn.BackColor = Color.Gray;
                        break;
                }
                if (item.Level == 1)

                    FLP_1.Controls.Add(btn);

                else
                    FLP_2.Controls.Add(btn);
            }


        }
        void btn_Click(object sender, EventArgs e)
        {
            BtnSelect = (sender as Button).Tag as Ghe;
            if(BtnSelect.TinhTrang == 1)
            {
                MessageBox.Show("Ghế đã có người xin vui lòng chọn ghế khác");
            }
            else
            {
                btn_ViTri.Text = ((sender as Button).Tag as Ghe).ViTri.ToString();
                btn_HangVe.Text = ((sender as Button).Tag as Ghe).Level.ToString();
                btn_Gia.Text = ((sender as Button).Tag as Ghe).Gia.ToString();

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string Maghe = BtnSelect.Id;
            string MaCB = BtnSelect.MACB;
            string CMND = txt_CMND.Text.ToString();
            string Name = txt_Name.Text.ToString();
            string Phone = txt_Phone.Text.ToString();
            float Gia = BtnSelect.Gia;
            string query = "EXEC INSERT_PASSENGER '" + MaCB + "', N'" + Name + "', '" + CMND + "', '" + Phone + "', '" + Maghe + "', '" + Gia + "'";
            if (DataProvider.Instance.ExecuteNonQuery(query) != -1)
            {
                MessageBox.Show("Thành Công ", "Note", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thất Bại", "Note ", MessageBoxButtons.OK);
            }


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
