using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class HanhKhach
    {
        private string mahanhkhach;
        private string tenhanhkhach;
        private string sdt;
        private string cmnd;

        public string Mahanhkhach { get => mahanhkhach; set => mahanhkhach = value; }
        public string Tenhanhkhach { get => tenhanhkhach; set => tenhanhkhach = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public HanhKhach(string MaHanhKhach, string TenHanhKhach, string CMND, string SDT)
        
        {
            this.Mahanhkhach = MaHanhKhach;
            this.Tenhanhkhach = TenHanhKhach;
            this.Sdt = SDT;
            this.Cmnd = cmnd;
            
        }
    }
}
