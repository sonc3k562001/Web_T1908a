using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace baiThi
{
    class book:sanPham
    {
        public book(int id , string name,double price,string nsx,string nxd): base(id, name, price, nsx, nxd) { }
       
    }
     
}
