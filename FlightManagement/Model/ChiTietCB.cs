using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace FlightManagement.Model
{
    public class ChiTietCB
    {
        private string macb;
        private string tensb;
        private string quocgia;
        private int thoigiandung;
        private string ghichu;

        public string Macb { get => macb; set => macb = value; }
        public string Tensb { get => tensb; set => tensb = value; }
        public string Quocgia { get => quocgia; set => quocgia = value; }
        public int Thoigiandung { get => thoigiandung; set => thoigiandung = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public ChiTietCB(DataRow row)
        {
            this.Macb = row["MaChuyenBay"].ToString();
            this.Tensb = row["TenSanBay"].ToString();
            this.Quocgia = row["QuocGia"].ToString();
            this.Ghichu = row["GhiChu"].ToString();

            this.Thoigiandung = (int)row["ThoiGianDung"];

        }
    }

}
