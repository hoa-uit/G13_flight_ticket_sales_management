using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_ticket_sales_management_G13.model
{
    public class CTDTThang
    {
       public CTDTThang(string ID, string MA_DT_THANG, string MACB, int SOVE, int TYLETUNGCHUYENBAY, int DOANHTHU)
        {
            this.Id = ID;
            this.Ma_dt_thang = MA_DT_THANG;
            this.Macb = MACB;
            this.Sove = SOVE;
            this.Tyletungchuyenbay1 = TYLETUNGCHUYENBAY;
            this.Doanhthu1 = DOANHTHU;
        }

        public CTDTThang(DataRow row)
        {
            this.Id = (string)row["MACTDT"];
            this.Ma_dt_thang = (string)row["MA_DT_THANG"];
            this.Macb = (string)row["MACB"];
            this.Sove = (int)row["SOVE"];
            this.Doanhthu1 = (int)row["DOANHTHU"];
            this.Tyletungchuyenbay1 = (int)row["TYLETUNGCHUYENBAY"];
           
        }
        public string Id { get => id; set => id = value; }
        public string Ma_dt_thang { get => ma_dt_thang; set => ma_dt_thang = value; }
        public string Macb { get => macb; set => macb = value; }
        public int Sove { get => sove; set => sove = value; }
        public int Tyletungchuyenbay1 { get => Tyletungchuyenbay; set => Tyletungchuyenbay = value; }
        public int Doanhthu1 { get => Doanhthu; set => Doanhthu = value; }

        private string ma_dt_thang;
        private string macb;
        private int sove;
        private int Tyletungchuyenbay;
        private int Doanhthu;
        private string id;

    }
}
