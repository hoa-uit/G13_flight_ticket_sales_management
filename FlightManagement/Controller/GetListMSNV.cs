using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class GetListMSNV
    {
        private static GetListMSNV instance;

        public static GetListMSNV Instance
        { 
            get { if (instance == null) instance = new GetListMSNV(); return GetListMSNV.instance; }
            set { GetListMSNV.instance = value; }
        }
        private GetListMSNV() { }
        public List<string> ListMSNV_Account ()
        {
            List<string> listaccount = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT EMAIL FROM ACCOUNT");
            foreach(DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                listaccount.Add(x);
            }
            return listaccount;
        }
    }
}
