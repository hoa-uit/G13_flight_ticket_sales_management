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
        private string maChuyenBay;
        private string maHangVe;



      

        public Ghe()
        { }
        public Ghe(DataRow row)
        {
            this.Id = row["MaGhe"].ToString();
            this.TinhTrang = (int)row["TinhTrangGhe"];
            this.ViTri = int.Parse(row["ViTri"].ToString());
            this.Gia = float.Parse(row["Gia"].ToString());
            this.MaHangVe = row["MaHangVe"].ToString();
            this.MaChuyenBay = row["MaChuyenBay"].ToString();
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

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
    }
}
