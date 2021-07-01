﻿using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.Controller
{
    public class ChuyenBayController
    {
        private static ChuyenBayController instance;

        internal static ChuyenBayController Instance
        {
            get
            {
                if (instance == null) instance = new ChuyenBayController();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        private ChuyenBayController() { }
        public List<ChuyenBay> Load(string ORI_AIRPORT, string DES_AIRPORT, DateTime Light_Time)
        {
            string query = "EXEC DATAGRIDVIEW N'" + ORI_AIRPORT + "',N'" + DES_AIRPORT + "', '" + Light_Time + "'";
            List<ChuyenBay> ListChuyenBay = new List<ChuyenBay>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    ChuyenBay ChuyenBay = new ChuyenBay(item);
                    ListChuyenBay.Add(ChuyenBay);
                }
                return ListChuyenBay;
            }
            else
            {
                MessageBox.Show("Không có chuyến bay nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataRow item in data.Rows)
                {
                    ChuyenBay ChuyenBay = new ChuyenBay(item);
                    ListChuyenBay.Add(ChuyenBay);
                }
                return ListChuyenBay;
            }
                
        }
        public List<ChuyenBay> Load_DatCho(string ORI_AIRPORT, string DES_AIRPORT, DateTime Light_Time)
        {
            string query = "EXEC DATAGRIDVIEW N'" + ORI_AIRPORT + "',N'" + DES_AIRPORT + "', '" + Light_Time + "'";
            List<ChuyenBay> ListChuyenBay = new List<ChuyenBay>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    ChuyenBay ChuyenBay = new ChuyenBay(item);
                    ChuyenBay.DatVe = "Đặt Chỗ";
                    ListChuyenBay.Add(ChuyenBay);
                }
                return ListChuyenBay;
            }
            else
            {
                MessageBox.Show("Không có chuyến bay nào thõa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataRow item in data.Rows)
                {
                    ChuyenBay ChuyenBay = new ChuyenBay(item);
                    ChuyenBay.DatVe = "Đặt Chỗ";
                    ListChuyenBay.Add(ChuyenBay);
                }
                return ListChuyenBay;
            }


          
        }
        public bool checkMaCB (string MACB)
        {
            List<string> listMaCB = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaChuyenBay FROM CHUYENBAY");
            foreach (DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                listMaCB.Add(x);
            }

            foreach (string macb in listMaCB)
            {
                if (macb.Trim() == MACB.Trim())
                {
                    return true;
                }    
            }
            return false;
        }

    }
}
