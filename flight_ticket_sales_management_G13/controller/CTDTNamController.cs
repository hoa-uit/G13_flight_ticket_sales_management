using flight_ticket_sales_management_G13.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_ticket_sales_management_G13.controller
{
    public class CTDTNamController
    {
        private static CTDTNamController instance;

        public static CTDTNamController Instance
        { 
            get { if (instance == null) instance = new CTDTNamController(); return CTDTNamController.instance; }
            private set { CTDTNamController.instance = value; }
        }
        private CTDTNamController() { }

        public List<CTDTNam> listDTThang (int nam)
        {
            List<CTDTNam> listDTThang = new List<CTDTNam>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUNAM " + nam);
            foreach (DataRow item in table.Rows)
            {
                CTDTNam x = new CTDTNam(item);
                listDTThang.Add(x);

            }    
            return listDTThang;
        }
    }


}
