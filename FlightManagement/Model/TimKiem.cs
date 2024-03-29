﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace FlightManagement.Model
{
    public class TimKiem
    {
        private int sTT;
        private string macb;
        private string hanhkhach;
        private string cmnd;
        private string sdt;
        private string hangve;
        private float giatien;
        private string mapdc;
        private string tinhTrang;
        private string thanhToan;
        
        
   
        public TimKiem() { }
        public TimKiem(DataRow row)
        {
            this.STT = 0;
            this.MaChuyenBay = row["MaChuyenBay"].ToString();
            this.TenHanhKhach = row["TenHanhKhach"].ToString();
            this.CMND = row["CMND"].ToString();
            this.SDT = row["SDT"].ToString();
            this.MaHangVe = row["MaHangVe"].ToString();
            this.Mapdc = row["MaPDC"].ToString();
            this.GiaTien = float.Parse(row["GiaTien"].ToString());
            this.TinhTrang = row["TinhTrangPDC"].ToString();

        }
        public string MaChuyenBay
        {
            get
            {
                return macb;
            }

            set
            {
                macb = value;
            }
        }

        public string TenHanhKhach
        {
            get
            {
                return hanhkhach;
            }

            set
            {
                hanhkhach = value;
            }
        }
        public string CMND
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        public string MaHangVe
        {
            get
            {
                return hangve;
            }

            set
            {
                hangve = value;
            }
        }
        public float GiaTien
        {
            get
            {
                return giatien;
            }

            set
            {
                giatien = value;
            }
        }

        public string Mapdc { get => mapdc; set => mapdc = value; }
        public int STT { get => sTT; set => sTT = value; }
        public string ThanhToan { get => thanhToan; set => thanhToan = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
