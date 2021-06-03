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
    }
}
