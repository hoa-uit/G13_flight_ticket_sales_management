using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
   public  class ThamSo
    {
        private string tenThamSo;
        private int giaTri;

        public string TenThamSo
        {
            get
            {
                return tenThamSo;
            }

            set
            {
                tenThamSo = value;
            }
        }

        public int GiaTri
        {
            get
            {
                return giaTri;
            }

            set
            {
                giaTri = value;
            }
        }

        public ThamSo(string TenTS, int GiaTri)
        {
            this.GiaTri = GiaTri;
            this.TenThamSo = TenTS;
        }
        public ThamSo(DataRow row)
        {
            this.TenThamSo = row["TenThamSo"].ToString();
            this.GiaTri = int.Parse(row["GiaTri"].ToString());
        }

    }
}
