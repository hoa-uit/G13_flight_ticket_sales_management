using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class SanBay
    {
        private string masb;

        public string Masb { get => masb; set => masb = value; }
        public string Tensb { get => tensb; set => tensb = value; }
        public string Quocgia { get => quocgia; set => quocgia = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        private string tensb;
        private string quocgia;
        private string diachi;
        public SanBay(string MaSB, string TenSB, string QuocGia, string Diachi)
        {
            this.Masb = MaSB;
            this.Tensb = TenSB;
            this.Quocgia = QuocGia;
            this.Diachi = Diachi;
        }
        
        public SanBay(DataRow row)
        {
            this.Masb = (string)row["MaSanBay"];
            this.Tensb = (string)row["TenSanBay"];
            this.Quocgia = (string)row["QuocGia"];
            this.Diachi = (string)row["DiaChi"];
        }

    }
}
