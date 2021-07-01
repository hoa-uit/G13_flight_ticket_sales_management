using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FlightManagement.Model;
using FlightManagement.Controller;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlightManagement.Controller
{
   
      public  class HangVeController
    { private static HangVeController instance;

        internal static HangVeController Instance 
        {
            get { if (instance == null) instance = new HangVeController(); return HangVeController.instance; }
            set { HangVeController.instance = value; }
        }
        public List<HangVe> Load_HangVe()
        {
            DataTable Data = new DataTable();
            List<HangVe> HangVeList = new List<HangVe>();
            Data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HANGVE");
            foreach(DataRow row in Data.Rows)
            {
                HangVe HangVe = new HangVe(row);
                HangVeList.Add(HangVe);
            }
            return HangVeList;
        }
        public void Save_DaTa(List<HangVe> ListHangVe,string MaChuyenBay)
        { 
            foreach(HangVe item in ListHangVe)
            {
                if(item.ChonHangVe == true)
                {
                    string Query = "EXEC INSERT_CHITIETHANGVE N'" + MaChuyenBay + "', N'" + item.MaHangVe+"'," + item.SoLuongVe;
                    DataProvider.Instance.ExecuteQuery(Query);
                }
            }
        }
        public bool Check (List<HangVe> ListHangVe)
        {
            int count = 0;

            bool check = true;
                foreach (HangVe item in ListHangVe)
            {
                if (item.ChonHangVe == true && item.SoLuongVe <= 0)
                    check = false;
                if (item.ChonHangVe == true)
                    count++;
            }
            if (count == 0)
                check = false;
            return check;
        }
        public void ThemHangVe(string MaHangVe, string TenHangVe, string TyLe)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("EXEC THEMHANGVE '" + MaHangVe + "', N'" + TenHangVe + "', '" + TyLe + "'");
            if (check > 0)
                MessageBox.Show("Thêm Thành Công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void SuaHangVe(string MaHangVe, string TenHangVe, string TyLe)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("EXEC SUAHANGVE '" + MaHangVe + "', N'" + TenHangVe + "', '" + TyLe + "'");
            if (check > 0)
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mã hạng vé không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void XoaHangVe(string MaHangVe, string TenHangVe, string TyLe)
        {
            int check = 0;
            List<HangVe> ListHangVe = HangVeController.instance.Load_HangVe();
            foreach (HangVe item in ListHangVe)
            {
                if (item.MaHangVe.Trim() == MaHangVe.Trim())
                    check = 1;
            }
            if (check == 1)
            {
                int data = DataProvider.Instance.ExecuteNonQuery("EXEC XOAHANGVE '" + MaHangVe + "'");
                if (data > 0)
                {
                    MessageBox.Show("Xoá Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xoá  không thành công mã hạng vé đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã chuyến bay không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<string> ListMaHV()
        {
            List<string> listMaHV = new List<string>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaHangVe FROM HANGVE");
            foreach (DataRow item in table.Rows)
            {
                string x = item[0].ToString();
                listMaHV.Add(x);
            }
            return listMaHV;
        }

    }
}
