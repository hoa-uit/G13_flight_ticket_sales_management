using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class ChuyenBay
    {
        private string mACB;
        private string thoiGian;
        private string sanBayDi;
        private string sanBayDen;
        private string datVe;

        public ChuyenBay() { }
        public ChuyenBay(DataRow row)
        {
            this.MACB = row["MACB"].ToString();
            this.ThoiGian = row["NGAYGIO"].ToString();
            this.SanBayDi = row["DIEMDI"].ToString();
            this.SanBayDen = row["DIEMDEN"].ToString();
            this.DatVe = "Đặt Vé";
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

        public string DatVe
        {
            get
            {
                return datVe;
            }

            set
            {
                datVe = value;
            }
        }
    }
}
