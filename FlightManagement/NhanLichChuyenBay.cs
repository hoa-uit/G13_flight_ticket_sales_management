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
    public partial class NhanLichChuyenBay : Form
    {
        public NhanLichChuyenBay()
        {
            InitializeComponent();
            Task1_Load();
        }

        private void btnClose_nhanlich_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Task1_Load()
        {
            DataTable ComboBox_Data_Des, ComboBox_Data_Ori, ComboBox_Data_Tran;
            string ComBoBox = "select * from SANBAY";


            ComboBox_Data_Des = DataProvider.Instance.ExecuteQuery(ComBoBox);
            ComboBox_Data_Ori = DataProvider.Instance.ExecuteQuery(ComBoBox);
            ComboBox_Data_Tran = DataProvider.Instance.ExecuteQuery(ComBoBox);
            cbb_DesAirport.DataSource = ComboBox_Data_Des;
            cbb_DesAirport.DisplayMember = "TenSanBay";
            cbb_DesAirport.ValueMember = "TenSanBay";
            cbb_OriAirport.DataSource = ComboBox_Data_Ori;
            cbb_OriAirport.DisplayMember = "TenSanBay";
            cbb_OriAirport.ValueMember = "TenSanBay";
            cbb_TranAirport.DataSource = ComboBox_Data_Tran;
            cbb_TranAirport.DisplayMember = "TenSanBay";
            cbb_TranAirport.ValueMember = "TenSanBay";
            btn_IDFLIGHT.Text = btn_PRICE.Text = btn_SEATONE.Text = btn_SEATTWO.Text = btn_TIME.Text = null;
            dgv_DATAFLIGHT.ClearSelection();

        }
    

        private void btnThoat_nhanlich_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_nhanlich_Click(object sender, EventArgs e)
        {
            Task1_Load();
        }

        private void btnLuu_nhanlich_Click(object sender, EventArgs e)
        {
            int i;
            int min_WaitTime;
            int max_WaitTime;

            int Total_TranAirport = i = dgv_DATAFLIGHT.Rows.Count - 1;

            if (i == 0)
            { min_WaitTime = max_WaitTime = -1; }
            else
            {
                min_WaitTime = int.Parse(dgv_DATAFLIGHT.Rows[0].Cells[2].Value.ToString());
                max_WaitTime = int.Parse(dgv_DATAFLIGHT.Rows[0].Cells[2].Value.ToString());
                for (int j = i - 1; j > 0; j--)
                {
                    int cell_value = int.Parse(dgv_DATAFLIGHT.Rows[j].Cells[2].Value.ToString());
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
            List<string> Flight_Airport = new List<string>(i + 2);
            Flight_Airport.Add(cbb_OriAirport.Text);
            Flight_Airport.Add(cbb_DesAirport.Text);
            for (int j = 0; j < i; j++)
            {
                Flight_Airport.Add(dgv_DATAFLIGHT.Rows[j].Cells[1].Value.ToString());
            }


            if (Flight_Airport.Distinct().Count() != Flight_Airport.Count())
            {
                MessageBox.Show("Sân Bay Trùng", "NOTE", MessageBoxButtons.OK);
            }
            else
            {
                string ID_FLIGHT = btn_IDFLIGHT.Text.ToString();
                float PRICE = float.Parse(btn_PRICE.Text.ToString());
                string ORIAIRPORT = cbb_OriAirport.Text.ToString();
                string DESAIRPORT = cbb_DesAirport.Text.ToString();
                DateTime DATIMEFLIGHT = timepk_DATIMEFLIGHT.Value;
                int TIMELIGHT = int.Parse(btn_TIME.Text.ToString());
                int SEATONE = int.Parse(btn_SEATONE.Text.ToString());
                int SEATTWO = int.Parse(btn_SEATTWO.Text.ToString());
                if (ThamSoController.Instance.check(TIMELIGHT, Total_TranAirport, min_WaitTime, max_WaitTime))
                {

                    string query = "EXEC INSERTTOFLIGHT '" + ID_FLIGHT + "', N'" + ORIAIRPORT + "', N'" + DESAIRPORT + "', '" + DATIMEFLIGHT + "' , '" + PRICE + "', '" + TIMELIGHT + "', " + SEATONE + "," + SEATTWO;



                    int data = DataProvider.Instance.ExecuteNonQuery(query);

                    if (data != -1)

                    {
                        int k = 0;
                        if (i != 0)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                string AirportName = dgv_DATAFLIGHT.Rows[j].Cells[1].Value.ToString();
                                int WaitTime = int.Parse(dgv_DATAFLIGHT.Rows[j].Cells[2].Value.ToString());
                                string Note = dgv_DATAFLIGHT.Rows[j].Cells[3].Value.ToString();
                                string Query_TranAirport = "EXEC INSERT_TRANAIRPORT '" + ID_FLIGHT + "', N'" + AirportName + "', " + WaitTime + ", N'" + Note + "'";

                                if (DataProvider.Instance.ExecuteNonQuery(Query_TranAirport) != -1)
                                    k++;

                            }


                        }
                        if (k == i)
                            MessageBox.Show("success", "note", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("error", "note", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Mã Chuyến Bay Đã Tồn Tại Trong Hệ Thống");

                    }

                }

            }
        }

       
    }
}
