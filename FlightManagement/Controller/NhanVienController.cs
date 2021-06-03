using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class NhanVienController
    {
        private static NhanVienController instance;

        public static NhanVienController Instance 
        { 
            get { if (instance == null) instance = new NhanVienController(); return NhanVienController.instance; }
            set { NhanVienController.instance = value; }
        }
        private NhanVienController() { }

        public List<NhanVien> GetListNV ()
        {
            List<NhanVien> listNV = new List<NhanVien>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN");
            foreach (DataRow item in table.Rows)
            {
                NhanVien x = new NhanVien(item);
                listNV.Add(x);
            }
            return listNV;
        }
    }
}
