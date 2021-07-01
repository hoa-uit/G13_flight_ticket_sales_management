using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class SanBayController
    {
        private static SanBayController instance;

        public static SanBayController Instance
        {
            get { if (instance == null) instance = new SanBayController(); return SanBayController.instance; }
            set { SanBayController.instance = value; }
        }
        private SanBayController() { }

        public List<SanBay> GetListSanBay()
        {
            List<SanBay> listSB = new List<SanBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM SANBAY");
            foreach (DataRow item in table.Rows)
            {
                SanBay x = new SanBay(item);
                listSB.Add(x);
            }
            return listSB;
        }
        public List<string> ListMaSB()
        {
            List<string> listMasb = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaSanBay FROM SANBAY");
            foreach (DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                listMasb.Add(x);
            }
            return listMasb;
        }
    }
}
