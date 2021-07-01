using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightManagement.Model
{
    public class TraCuuChuyenBay
    {
        private int sTT;
        private string mACB;
        private string thoiGian;
        private string sanBayDi;
        private string sanBayDen;
        private int thoiGianBay;
        private float giaTien;
        private int sLGheDat;
        private int sLGheTrong;
        private string thaoTac;
        public TraCuuChuyenBay() { }
        public TraCuuChuyenBay(DataRow row)
        {
            this.STT = 0;
            this.MACB = row["MACB"].ToString();
            this.ThoiGian = row["NGAYGIO"].ToString();
            this.SanBayDi = row["DIEMDI"].ToString();
            this.SanBayDen = row["DIEMDEN"].ToString();
            this.ThoiGianBay = (int)row["ThoiGianBay"];
            this.GiaTien = float.Parse(row["DonGia"].ToString());
            this.SLGheDat = (int)row["SLGheDaDat"];
            this.SLGheTrong = (int)row["SLGheTrong"];
            this.ThaoTac = "Xoá";

        }
        public string MACB
        {
            get
            {
                return mACB;
            }

            set
            {
                mACB = value;
            }
        }

        public string ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }

        public string SanBayDi
        {
            get
            {
                return sanBayDi;
            }

            set
            {
                sanBayDi = value;
            }
        }

        public string SanBayDen
        {
            get
            {
                return sanBayDen;
            }

            set
            {
                sanBayDen = value;
            }
        }

        public int STT { get => sTT; set => sTT = value; }
        
        
        public string ThaoTac { get => thaoTac; set => thaoTac = value; }
        public int ThoiGianBay { get => thoiGianBay; set => thoiGianBay = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public int SLGheDat { get => sLGheDat; set => sLGheDat = value; }
        public int SLGheTrong { get => sLGheTrong; set => sLGheTrong = value; }
    }
}
