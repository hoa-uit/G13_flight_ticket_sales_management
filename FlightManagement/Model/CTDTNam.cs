using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    class CTDTNam
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
            this.Ma_dt_thang = (string)row["MaDT_Thang"];
            this.Ma_dt_nam = (string)row["MaDT_Nam"];
            this.Thang = (int)row["Thang"];
            this.Tong_dt_thang = (int)row["TongDT_Thang"];
            this.Sochuyenbay = (int)row["SoChuyenBay"];
            this.Tylethang = (int)row["TyLeThang"];
        }

        public string Ma_dt_thang { get => ma_dt_thang; set => ma_dt_thang = value; }
        public int Thang { get => thang; set => thang = value; }
        public string Ma_dt_nam { get => ma_dt_nam; set => ma_dt_nam = value; }
        public int Tong_dt_thang { get => tong_dt_thang; set => tong_dt_thang = value; }
        public int Sochuyenbay { get => sochuyenbay; set => sochuyenbay = value; }
        public int Tylethang { get => tylethang; set => tylethang = value; }
    }
}
