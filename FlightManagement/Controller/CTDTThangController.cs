using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    class CTDTThangController
    {
     
            private static CTDTThangController instance;

            public static CTDTThangController Instance
            {
                get { if (instance == null) instance = new CTDTThangController(); return CTDTThangController.instance; }
                private set { CTDTThangController.instance = value; }
            }
            private CTDTThangController() { }

            public List<CTDTThang> ListCB_BCThang(int thang, int nam)
            {
                List<CTDTThang> listCB = new List<CTDTThang>();
                DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUTHANG " + thang + "," + nam);
                foreach (DataRow item in table.Rows)
                {
                    CTDTThang x = new CTDTThang(item);
                    listCB.Add(x);
                }

                return listCB;
            }
    }
}
