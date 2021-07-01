using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class TraCuuChuyenBayController
    {
        private static TraCuuChuyenBayController instance;

        public static TraCuuChuyenBayController Instance
        {
            get { if (instance == null) instance = new TraCuuChuyenBayController(); return TraCuuChuyenBayController.instance; }
            private set { TraCuuChuyenBayController.instance = value; }
        }
        private TraCuuChuyenBayController() { }

        public List<TraCuuChuyenBay> result_TraCuu(string quocgiadi, string quocgiaden, DateTime ngaygio)
        {
            List<TraCuuChuyenBay> listDTThang = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TraCuuchuyenBay N'" + quocgiadi + "',N'" + quocgiaden + "','" + ngaygio + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<TraCuuChuyenBay> tra_cuu_qgdi_tg(string quocgiadi, DateTime ngaygio)
        {
            List<TraCuuChuyenBay> listDTThang = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TraCuuCB_qgdi_tg N'" + quocgiadi + "','" + ngaygio + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<TraCuuChuyenBay> tra_cuu_qgden_tg(string quocgiaden, DateTime ngaygio)
        {
            List<TraCuuChuyenBay> listDTThang = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TraCuuCB_qgden_tg N'" + quocgiaden + "','" + ngaygio + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<TraCuuChuyenBay> tra_cuu_tg(DateTime ngaygio)
        {
            List<TraCuuChuyenBay> listDTThang = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TraCuuCB_tg '" + ngaygio + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<TraCuuChuyenBay> Lay_tat_ca_cb()
        {
            List<TraCuuChuyenBay> listDTThang = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec Lay_tat_ca_cb ");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<ChiTietCB> Lay_SBTG(string macb)
        {
            List<ChiTietCB> listDTThang = new List<ChiTietCB>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec lay_chi_tiet_chuyen_bay '" + macb + "'");
            foreach (DataRow item in table.Rows)
            {
                ChiTietCB x = new ChiTietCB(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<TraCuuChuyenBay> TraCuu_QGDi(string quocgiadi)
        {
            List<TraCuuChuyenBay> listCB = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC TraCuuCB_QuocGiaDi N'" + quocgiadi + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listCB.Add(x);

            }
            return listCB;
        }


        #region
        public List<TraCuuChuyenBay> TraCuu_QGDen(string quocgiaden)
        {
            List<TraCuuChuyenBay> listCB = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC TraCuuCB_QuocGiaDen N'" + quocgiaden + "'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listCB.Add(x);

            }
            return listCB;
        }
        public List<TraCuuChuyenBay> TraCuu_QGDi_QGDen(string quocgiadi, string quocgiaden)
        {
            List<TraCuuChuyenBay> listCB = new List<TraCuuChuyenBay>();
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC TraCuuCB_QGDi_QGDen N'"+quocgiadi+"', N'"+quocgiaden+"'");
            foreach (DataRow item in table.Rows)
            {
                TraCuuChuyenBay x = new TraCuuChuyenBay(item);
                listCB.Add(x);

            }
            return listCB;
        }
        #region tìm kiếm vé
        public List<timkiemve> TimKiemVeTheoMacb(string macb)
        {
            List<timkiemve> listDTThang = new List<timkiemve>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_VE_MACB '" + macb + "'");
            foreach (DataRow item in table.Rows)
            {
                timkiemve x = new timkiemve(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<timkiemve> TimKiemVeTheoCMND(string CMND)
        {
            List<timkiemve> listDTThang = new List<timkiemve>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_VE_CMND '" + CMND + "'");
            foreach (DataRow item in table.Rows)
            {
                timkiemve x = new timkiemve(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        public List<timkiemve> TimKiemTatCave()
        {
            List<timkiemve> listDTThang = new List<timkiemve>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec Lay_tat_ca_ve");
            foreach (DataRow item in table.Rows)
            {
                timkiemve x = new timkiemve(item);
                listDTThang.Add(x);
            }
            return listDTThang;
        }

        public List<timkiemve> TimKiemVeTheoMacbCMND(string macb,string CMND)
        {
            List<timkiemve> listDTThang = new List<timkiemve>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_VE_MACB_cmnd '"+macb+"','" + CMND + "'");
            foreach (DataRow item in table.Rows)
            {
                timkiemve x = new timkiemve(item);
                listDTThang.Add(x);

            }
            return listDTThang;
        }
        #endregion xong tìm kiếm vé
        #region tìm kiếm pdc
        public List<TimKiem> TimKiempdcTheoMacb(string macb)
        {
            int num = 1;
            List<TimKiem> listDTThang = new List<TimKiem>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_pdc_MACB '" + macb + "'");
            foreach (DataRow item in table.Rows)
            {
                TimKiem x = new TimKiem(item);
                x.STT = num;
                listDTThang.Add(x);
                num++;

            }
            return listDTThang;
        }
        public List<TimKiem> TimKiempdcTheoCMND(string CMND)
        {
            int num = 1;
            List<TimKiem> listDTThang = new List<TimKiem>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_pdc_CMND '" + CMND + "'");
            foreach (DataRow item in table.Rows)
            {
                TimKiem x = new TimKiem(item);
                x.STT = num;
                listDTThang.Add(x);
                num++;

            }
            return listDTThang;
        }
        public List<TimKiem> TimKiempdcTheoMacbCMND(string macb, string CMND)
        {
            int num = 1;
            List<TimKiem> listDTThang = new List<TimKiem>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec TIMKIEM_pdc_MACB_cmnd '" + macb + "','" + CMND + "'");
            foreach (DataRow item in table.Rows)
            {
                TimKiem x = new TimKiem(item);
                x.STT = num;
                listDTThang.Add(x);
                num++;

            }
            return listDTThang;
        }

        public List<TimKiem> TimKiemTatCaPDC()
        {
            int num = 1;
            List<TimKiem> listDTThang = new List<TimKiem>();
            DataTable table = DataProvider.Instance.ExecuteQuery("exec Lay_tat_ca_pdc");
            foreach (DataRow item in table.Rows)
            {
                TimKiem x = new TimKiem(item);
                x.STT = num;
                listDTThang.Add(x);
                num++;

            }
            return listDTThang;
        }

        #endregion xong tìm kiếm pdc

        public bool XoaChuyenBay(string MACB)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("EXEC XOACHUYENBAY '" + MACB + "'");
            if (data != -1)
                return true;
            else
                return false;
        }
    }

    
}
#endregion