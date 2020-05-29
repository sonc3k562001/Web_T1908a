using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiThi
{
    class program
    {
        static void Main(string[] args)
        {
            mobiephone m1 = new mobiephone(123, "nokia", 12.5, "and", "hfs");
            mobiephone m2 = new mobiephone(124, "oppo", 11.7, "and", "hfs");
            mobiephone m3 = new mobiephone(125, "samsung", 25.7, "and", "hfs");
            mobiephone m4 = new mobiephone(126, "nokia", 12.5, "and", "hfs");
            mobiephone m5 = new mobiephone(127, "pro", 35.5, "and", "hfs");
            mobiephone m6 = new mobiephone(128, "nokia", 40.0, "and", "hfs");

            m1.ComputeTax(0.08);
            m2.ComputeTax(0.08);
            m3.ComputeTax(0.08);
            m4.ComputeTax(0.08);
            m5.ComputeTax(0.08);
            m6.ComputeTax(0.08);


            book b1 = new book(152, "book", 82.9, "kimdong", "jsksf");
            book b2 = new book(152, "book", 82.9, "kimdong", "jsksf");
            book b3 = new book(152, "book", 82.9, "kimdong", "jsksf");
            book b4 = new book(152, "book", 82.9, "kimdong", "jsksf");
            book b5 = new book(152, "book", 82.9, "kimdong", "jsksf");
            book b6 = new book(152, "book", 82.9, "kimdong", "jsksf");

            b1.ComputeTax(0.1);
            b2.ComputeTax(0.1);
            b3.ComputeTax(0.1);
            b4.ComputeTax(0.1);
            b5.ComputeTax(0.1);
            b6.ComputeTax(0.1);
        }
    }
}
