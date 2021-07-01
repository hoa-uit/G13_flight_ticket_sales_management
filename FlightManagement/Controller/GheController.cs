using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class GheController
    {
        private static GheController instance;

        public static GheController Instance
        {
            get
            {
                if (instance == null) instance = new GheController();
                return instance;
            }

            private set
            {
                instance = value;
            }

        }
        private GheController() { }
        public List<Ghe> GheLoad(string MaChuyenBay)
        {
            List<Ghe> GheList = new List<Ghe>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SELECT_GHE '" + MaChuyenBay + "'");
            foreach (DataRow item in data.Rows)
            {
                Ghe ghe = new Ghe(item);
                GheList.Add(ghe);
            }
            return GheList;
        }
        public bool Set_status(string Maghe)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("EXEC SET_GHE '" + Maghe + "'");
            if (check != -1)
                return true;
            else
                return false;
        }
        public bool Check_date(string MACB)
        {
            DateTime b1 = DateTime.Now.Date;
            DateTime b2 = ((DateTime)DataProvider.Instance.ExecuteQuery("EXEC  SELECT_DATETIME '" + MACB + "'").Rows[0][0]).Date;

            int Thoigianchamnhatdatve = (int)DataProvider.Instance.ExecuteQuery("SELECT GiaTri FROM THAMSO where TenThamSo = 'ThoiGianChamNhatDatVe'").Rows[0][0];

            if ((b1.AddDays(Thoigianchamnhatdatve)) <= b2)
            {
                return true;
            }
            return false;
        }
       public bool Check_hanPDC(string MACB)
        {
            DateTime b1 = DateTime.Now;
            DateTime b2 = (DateTime)DataProvider.Instance.ExecuteQuery("EXEC  SELECT_DATETIME '" + MACB + "'").Rows[0][0];
           
            int Thoigianchamnhathuyve = (int)DataProvider.Instance.ExecuteQuery("SELECT GiaTri FROM THAMSO where TenThamSo = 'ThoiGianChamNhatHuyVe'").Rows[0][0];
            if ((b1.AddDays(Thoigianchamnhathuyve)) < b2)
            {
                return false;
            }
            return true;
        }
    
        public Ghe LayMaDatCho(string cmnd)
        {
            Ghe a = new Ghe();
            string maPDC = (string)DataProvider.Instance.ExecuteQuery("EXEC LAYMA_PDC '" + cmnd + "'").Rows[0][0];
            a.Id = maPDC;
            return a;
        }
        public void Cap_nhat_thong_tin(string mapdc)
        {
            DataProvider.Instance.ExecuteQuery("exec cap_nhat_pdc '" + mapdc + "'");
        }
    }
}
