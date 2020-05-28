using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMath
{
    interface IMaths<T>
    {
        T Addition(T valOne, T valTwo);
        T Subtraction(T valOne, T valTwo);
    }
    class Numbers : IMaths<int>
    {
        public int Addition(int valOne , int valTwo)
        {
            return valOne + valTwo;
        }
        public int Subtraction(int valOne, int valTwo)
        {
            if (valOne > valTwo)
            {
                return (valOne - valTwo);
            }
            else
            {
                return (valTwo - valOne);
            }
        }
        static void Main(string[] args)
        {
            int numOne = 23;
            int numTwo = 45;
            Numbers objInterface = new Numbers();
            Console.WriteLine("Addition of two integer values is :");
            Console.WriteLine(objInterface.Addition(numOne, numTwo));
            Console.WriteLine("Subtraction of two integet");
            Console.WriteLine(objInterface.Subtraction(numOne, numTwo));
        }
    }
}
