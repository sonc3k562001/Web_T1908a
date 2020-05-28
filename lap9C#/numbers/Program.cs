using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
delegate T DelMath<T>(T val);
namespace general
{
    class general<T,U>
    {
        T _valOne;
        U _valTwo;
        public void AcceptValues(T item)
        {
            _valOne = item;
        }
        public void AcceptValues(U item)
        {
            _valTwo = item;
        }
        public void Display()
        {
            Console.WriteLine(_valOne + "\t" + _valTwo);
        }
    }
    class MethodOverload
    {
        static void Main (string[] args)
        {
            general<int, string> objGenOne = new general<int, string>();
            objGenOne.AcceptValues(10);
            objGenOne.AcceptValues("Smith");
            Console.WriteLine("ID\tName\tDesignation\tSalary");
            objGenOne.Display();
            general<string, float> objGenTwo = new general<string, float>();
            objGenTwo.AcceptValues("Mechanic");
            objGenTwo.AcceptValues(2500);
            Console.WriteLine("\t");
            objGenTwo.Display();
            Console.WriteLine();
        }
    }
}
