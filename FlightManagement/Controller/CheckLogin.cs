using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class CheckLogin
    {
        private static CheckLogin instance;

        public static CheckLogin Instance 
        { 
            get { if (instance == null) instance = new CheckLogin(); return CheckLogin.instance; } 
            set { CheckLogin.instance = value; }
        }

        private CheckLogin() { }

        public int Check_Login (string msnv, string pass)
        {
           
            DataTable table = DataProvider.Instance.ExecuteQuery("exec KIEMTRADANGNHAP " + msnv + "," +pass);
            return table.Rows.Count;
        }
    }
}
