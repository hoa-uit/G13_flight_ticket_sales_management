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
            dgv_NhanLich.ClearSelection();

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
            MessageBox.Show("chạy lại");
            #region check điều kiện
            if (string.IsNullOrEmpty(btn_IDFLIGHT.Text) || string.IsNullOrEmpty(btn_PRICE.Text) || string.IsNullOrEmpty(btn_SEATONE.Text) || string.IsNullOrEmpty(btn_SEATTWO.Text) || string.IsNullOrEmpty(btn_TIME.Text))
            {
                MessageBox.Show("Bạn hãy điền đây đủ thông tin");
            }   
            // kiểm tra mã chuyến bay có trùng k
            else if (ChuyenBayController.Instance.checkMaCB(btn_IDFLIGHT.Text))
            {
                errorMaSB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaSB.SetError(btn_IDFLIGHT, "Mã sân bay này đã tồn tại");
            }    
            else 
            {
                // i là tổng số sân bay trung gian
                int i;
                int min_WaitTime;
                int max_WaitTime;

                // i là tổng số sân bay trung gian
                int Total_TranAirport = i = dgv_NhanLich.Rows.Count - 1;

                // tìm ra thời gian chờ lớn nhất và nhỏ nhất trong số các sân bay trung gian
                if (i == 0)
                { 
                    min_WaitTime = max_WaitTime = -1; 
                }
                else
                {
                    min_WaitTime = int.Parse(dgv_NhanLich.Rows[0].Cells[2].Value.ToString());
                    max_WaitTime = int.Parse(dgv_NhanLich.Rows[0].Cells[2].Value.ToString());
                    for (int j = i - 1; j > 0; j--)
                    {
                        int cell_value = int.Parse(dgv_NhanLich.Rows[j].Cells[2].Value.ToString());
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
                //lấy một cái list gồm những sân bay đi sân bay đến và sân bay trung gian kiểm tra xem trong đó có cái nào trùng nhau không
                // nếu trùng thì báo lỗi
                List<string> Flight_Airport = new List<string>(i + 2);
                Flight_Airport.Add(cbb_OriAirport.Text);
                Flight_Airport.Add(cbb_DesAirport.Text);
                for (int j = 0; j < i; j++)
                {
                    Flight_Airport.Add(dgv_NhanLich.Rows[j].Cells[1].Value.ToString());
                }
                if (Flight_Airport.Distinct().Count() != Flight_Airport.Count())
                {
                    MessageBox.Show("Sân bay đi sân bay đến và sân bay trung gian phải khác nhau, xin kiểm tra lại", "NOTE", MessageBoxButtons.OK);
                }
               
                else if (!ThamSoController.Instance.checkTGBay(int.Parse(btn_TIME.Text)))
                {
                    errorThoigianbay.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorThoigianbay.SetError(btn_TIME, "Thời gian bay tối thiểu chưa đúng");
                }

                else if (timepk_DATIMEFLIGHT.Value.Date <= DateTime.Now.Date)
                {
                    errNgayGio.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errNgayGio.SetError(timepk_DATIMEFLIGHT, "Ngày giờ không hợp lệ");

                }
                // sai chỗ này
                else if (ThamSoController.Instance.checkTGcho(max_WaitTime, min_WaitTime))
                {
                    
                    errorThoigiancho.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorThoigiancho.SetError(dgv_NhanLich, "Thòi gian chờ không hợp lệ");
                    
                }   
                else if (!ThamSoController.Instance.checkSoSanBayTrungGian(i))
                {
                    errorSoSBTG.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errorSoSBTG.SetError(dgv_NhanLich, "Số sân bay trung gian chưa hợp lệ");
                }    
               
               
                #endregion xong phần check điều kiện
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
                   

                        string query = "EXEC INSERTTOFLIGHT '" + ID_FLIGHT + "', N'" + ORIAIRPORT + "', N'" + DESAIRPORT + "', '" + DATIMEFLIGHT + "' , '" + PRICE + "', '" + TIMELIGHT + "', " + SEATONE + "," + SEATTWO;



                        int data = DataProvider.Instance.ExecuteNonQuery(query);

                    if (data > 0)

                    {

                        int k = 0;
                        if (i != 0)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                // Console.OutputEncoding = Encoding.UTF8;
                                string AirportName = dgv_NhanLich.Rows[j].Cells[1].Value.ToString();
                                int WaitTime = int.Parse(dgv_NhanLich.Rows[j].Cells[2].Value.ToString());
                                string Note = dgv_NhanLich.Rows[j].Cells[3].Value.ToString();

                                string Query_TranAirport = "EXEC INSERT_TRANAIRPORT '" + ID_FLIGHT + "', N'" + AirportName + "', " + WaitTime + ", N'" + Note + "'";

                                if (DataProvider.Instance.ExecuteNonQuery(Query_TranAirport) != -1)
                                    k++;

                            }


                        }
                        if (k == i)
                            MessageBox.Show("Thêm chuyến bay thành công", "note", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Thêm thấy bại", "note", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm chuyến bay không thành công xin hãy kiểm tra lại");
                    }

                }
            }    
           
        } // kết thúc hàm

        private void btn_TIME_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btn_TIME.Text))
            {
                errorThoigianbay.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorThoigianbay.SetError(btn_TIME, "Thời gian bay tối thiểu chưa đúng");
            }    
            else
            {
                errorThoigianbay.SetError(btn_TIME, "");
            }    
        }

        private void timepk_DATIMEFLIGHT_ValueChanged(object sender, EventArgs e)
        {
           errNgayGio.SetError(timepk_DATIMEFLIGHT, "");
        }

        private void btn_IDFLIGHT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btn_IDFLIGHT.Text))
            {
                errorMaSB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorMaSB.SetError(btn_TIME, "Mã sân bay đã tồn tại");
            }
            else
            {
                errorMaSB.SetError(btn_IDFLIGHT, "");
            }
        }

        private void dgv_NhanLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errorThoigiancho.SetError(dgv_NhanLich, "");
        }
    }
}
