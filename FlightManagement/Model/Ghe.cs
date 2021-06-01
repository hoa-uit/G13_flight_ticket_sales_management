using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class Ghe
    {
        private int tinhTrang;
        private string id;
        private int viTri;
        private float gia;
        private string mACB;
        private int level;

        public Ghe()
        { }
        public Ghe(DataRow row)
        {
            this.Id = row["MaGhe"].ToString();
            this.TinhTrang = (int)row["TinhTrangGhe"];
            this.ViTri = int.Parse(row["ViTri"].ToString());
            this.Gia = float.Parse(row["Gia"].ToString());
            this.Level = int.Parse(row["MaHangVe"].ToString());
            this.MACB = row["MaChuyenBay"].ToString();
        }
        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int ViTri
        {
            get
            {
                return viTri;
            }

            set
            {
                viTri = value;
            }
        }

        public float Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
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

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
    }
}
