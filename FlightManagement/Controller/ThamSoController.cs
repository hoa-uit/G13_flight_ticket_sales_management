using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Model;


namespace FlightManagement.Controller
{
    public class ThamSoController
    {
        private static ThamSoController instance;
        public int Min_Fly_Time;
        public int Num_Tran_Airpot;
        public int Min_Wait_Time;
        public int Max_Wait_Time;

        internal static ThamSoController Instance
        {
            get
            {
                if (instance == null) instance = new ThamSoController(); return ThamSoController.instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ThamSoController()
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM THAMSO");
            foreach (DataRow item in data.Rows)
            {
               
                ThamSo ThamSo = new ThamSo(item);
                if (ThamSo.TenThamSo == "ThoiGianBayToiThieu")
                {
                    this.Min_Fly_Time = ThamSo.GiaTri;
                }
                if (ThamSo.TenThamSo == "SoSanBayTrungGianToiDa")
                {
                    this.Num_Tran_Airpot = ThamSo.GiaTri;
                }
                if (ThamSo.TenThamSo == "ThoiGianDungToiThieu")
                {
                    this.Min_Wait_Time = ThamSo.GiaTri;
                }
                if (ThamSo.TenThamSo == "ThoiGianDungToiDa")
                {
                    this.Max_Wait_Time = ThamSo.GiaTri;
                }

            }
        }
        public bool check(int FlyTime, int NumTranAirport, int MinWaitTIme, int MaxWaitTime)
        {
            if (FlyTime < this.Min_Fly_Time)
            {
                MessageBox.Show("Thời Gian Bay Không Hợp Lệ ", "Note", MessageBoxButtons.OK);
                return false;


            }
            else
            {
                if (NumTranAirport > this.Num_Tran_Airpot)
                {
                    MessageBox.Show("Số Sân Bay Trung Gian Không Hợp Lệ", "Note", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    if ((MaxWaitTime > this.Max_Wait_Time) || (MinWaitTIme < this.Min_Wait_Time) && (MinWaitTIme != -1))
                    {
                        MessageBox.Show("Thời gian dừng tại sân bay trung gian không hợp lệ", "Note", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                        return true;
                }
            }


        }
    }
}
