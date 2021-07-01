using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    class CTDTThang
    {
        public CTDTThang(string MACB, int SOVE, double TYLETUNGCHUYENBAY, int DOANHTHU, int THANG, int NAM)
        {

            this.Macb = MACB;
            this.Thang = THANG;
            this.Nam = NAM;
            this.Doanhthu = DOANHTHU;
            this.Sove = SOVE;
            this.Tyletungchuyenbay = TYLETUNGCHUYENBAY;
        }

        public CTDTThang(DataRow row)
        {
            this.Macb = (string)row["MaChuyenBay"];
            this.Thang = (int)row["Thang"];
            this.Nam = (int)row["Nam"];
            this.Doanhthu = (int)row["DoanhThu"];
            this.Sove = (int)row["SoVe"];
            double a = float.Parse(row["TyLeTungCB"].ToString());
            a = Math.Round(a, 2);
            this.Tyletungchuyenbay = a*100.0;
        }
       
        public string Macb { get => macb; set => macb = value; }
        public int Sove { get => sove; set => sove = value; }
        public int Doanhthu { get => doanhthu; set => doanhthu = value; }
        public int Nam { get => nam; set => nam = value; }
        public int Thang { get => thang; set => thang = value; }
        public double Tyletungchuyenbay { get => tyletungchuyenbay; set => tyletungchuyenbay = value; }

        private string macb;
        private int nam;
        private int thang;
        private int sove;
        private double tyletungchuyenbay;
        private int doanhthu;
    }
}
