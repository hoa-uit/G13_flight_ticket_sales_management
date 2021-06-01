using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
   public  class GetListMaNV
    {
        private static GetListMaNV instance;

        public static GetListMaNV Instance
        {
            get { if (instance == null) instance = new GetListMaNV(); return GetListMaNV.instance; }
            set { GetListMaNV.instance = value; }
        }
        private GetListMaNV() { }
        public List<string> ListMSNV_Account()
        {
            List<string> listaccount = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaNV FROM NHANVIEN");
            foreach (DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                listaccount.Add(x);
            }
            return listaccount;
        }
    }
}
