using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_ticket_sales_management_G13.model
{
    public class CTDTNam
    {
        private string ma_dt_thang;
        private int thang;
        private string ma_dt_nam;
        private int tong_dt_thang;
        private int sochuyenbay;
        private int tylethang;

        public CTDTNam(string MA_DT_THANG, int THANG, string MA_DT_NAM, int TONG_DT_THANG, int SOCHUYENBAY, int TYLETHANG)
        {
            this.Ma_dt_thang = MA_DT_THANG;
            this.Ma_dt_nam = MA_DT_NAM;
            this.Thang = THANG;
            this.Tong_dt_thang = TONG_DT_THANG;
            this.Sochuyenbay = SOCHUYENBAY;
            this.Tylethang = TYLETHANG;
        }

        public CTDTNam(DataRow row)
        {
            this.Ma_dt_thang = (string)row["MA_DT_THANG"];
            this.Ma_dt_nam =(string)row["MA_DT_NAM"];
            this.Thang = (int)row["THANG"];
            this.Tong_dt_thang = (int)row["TONG_DT_THANG"];
            this.Sochuyenbay = (int)row["SOCHUYENBAY"];
            this.Tylethang = (int)row["TYLETHANG"];
        }

        public string Ma_dt_thang { get => ma_dt_thang; set => ma_dt_thang = value; }
        public int Thang { get => thang; set => thang = value; }
        public string Ma_dt_nam { get => ma_dt_nam; set => ma_dt_nam = value; }
        public int Tong_dt_thang { get => tong_dt_thang; set => tong_dt_thang = value; }
        public int Sochuyenbay { get => sochuyenbay; set => sochuyenbay = value; }
        public int Tylethang { get => tylethang; set => tylethang = value; }
    }
}
