using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace baiThi
{
    
    public abstract class sanPham
    {
        private int id;
        private string ten;
        private double gia;
        private string nhasanxuat;
        private string nhaxaydung;
       
        public sanPham(int id,string ten , double gia , string nhasanxuat,string nhaxaydung)
        {
            this.id = id;
            this.gia = gia;
            this.nhasanxuat = nhasanxuat;
            this.nhaxaydung = nhaxaydung;
        }

        public int GetID
        {
            get
            {
                return id;
            }
        }
        public string GetName
        {
            get
            {
                return ten;
            }
        }
        public double getGia
        {
            get
            {
                return gia;
            }
        }
        public string getnsx
        {
            get
            {
                return nhasanxuat;
            }
        }
        public string Getnxd
        {
            get
            {
                return nhaxaydung;
            }
        }

        public string ComputeTax(double rad) {
            return "gia:" + (gia = gia * rad);
        }
    }
   

 
}
