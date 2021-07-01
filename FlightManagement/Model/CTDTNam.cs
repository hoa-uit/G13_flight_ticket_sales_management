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
        private int nam;
        private int thang;
        private float tong_dt_thang;
        private int sochuyenbay;
        private float tylethang;

        public CTDTNam(int NAM, int THANG, float TONGDT, int SOCHUYENBAY, float TYLE)
        {
            this.Nam = NAM;
            this.Thang = THANG;
            this.Tong_dt_thang = TONGDT;
            this.Sochuyenbay = SOCHUYENBAY;
            this.Tylethang1 = TYLE;
        }

        public CTDTNam(DataRow row)
        {

            this.Nam = (int)row["MaNam"];
            this.Thang = (int)row["Thang"];
            this.Tong_dt_thang = float.Parse(row["TongDT_Thang"].ToString());
            this.Sochuyenbay = (int)row["SoChuyenBay"];
            float a  = float.Parse(row["TyLeThang"].ToString());
          
            this.Tylethang1 = a*100;
        }

        public int Thang { get => thang; set => thang = value; }
        public int Sochuyenbay { get => sochuyenbay; set => sochuyenbay = value; }
        public int Nam { get => nam; set => nam = value; }
        public float Tong_dt_thang { get => tong_dt_thang; set => tong_dt_thang = value; }
        public float Tylethang1 { get => tylethang; set => tylethang = value; }
    }
}
