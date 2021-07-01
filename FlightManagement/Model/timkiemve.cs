using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class timkiemve
    {
        private string macb;
        private string hanhkhach;
        private string cmnd;
        private string sdt;
        private string hangve;
        private float giatien;





        public timkiemve() { }
        public timkiemve(DataRow row)
        {
            this.MaChuyenBay = row["MaChuyenBay"].ToString();
            this.TenHanhKhach = row["TenHanhKhach"].ToString();
            this.CMND = row["CMND"].ToString();
            this.SDT = row["SDT"].ToString();
            this.MaHangVe = row["MaHangVe"].ToString();

            this.GiaTien = float.Parse(row["GiaTien"].ToString());

        }
        public string MaChuyenBay
        {
            get
            {
                return macb;
            }



            set
            {
                macb = value;
            }
        }



        public string TenHanhKhach
        {
            get
            {
                return hanhkhach;
            }



            set
            {
                hanhkhach = value;
            }
        }
        public string CMND
        {
            get
            {
                return cmnd;
            }



            set
            {
                cmnd = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }



            set
            {
                sdt = value;
            }
        }
        public string MaHangVe
        {
            get
            {
                return hangve;
            }



            set
            {
                hangve = value;
            }
        }
        public float GiaTien
        {
            get
            {
                return giatien;
            }



            set
            {
                giatien = value;
            }
        }
    }
}
