using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightManagement.Model
{
   public class HangVe
    {
        private string maHangVe;
        private string tenHangVe;
        private int tyLeGiaVe;
        private bool chonHangVe = false;
        private int soLuongVe = 0;

       
        private HangVe() { }
        public HangVe (DataRow row)
        {
            this.MaHangVe = row["MaHangVe"].ToString();
            this.TenHangVe = row["TenHangVe"].ToString();
            this.TyLeGiaVe = (int)row["TyLeGiaVe"];
        }
      
        public string TenHangVe { get => tenHangVe; set => tenHangVe = value; }
        public int TyLeGiaVe { get => tyLeGiaVe; set => tyLeGiaVe = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public bool ChonHangVe { get => chonHangVe; set => chonHangVe = value; }
        public int SoLuongVe { get => soLuongVe; set => soLuongVe = value; }
    }
}
