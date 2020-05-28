using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class General<T>
    {
        T[] values;
        int _couter = 0;
        public General (int max)
        {
            values = new T[max];
        }
        public void Add(T val)
        {
            if (_couter < values.Length)
            {
                values[_couter] = val;
                _couter++;

            }
        }
        public void Display()
        {
            Console.WriteLine("Constructed Class is of type:" + typeof(T));
            Console.WriteLine("value stored in the object of constructed class are:");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
    class Students
    {
        static void Main(string[] args)
        {
            General<string> objGeneral = new General<string>(3);
            objGeneral.Add("John");
            objGeneral.Add("Patrick");
            objGeneral.Display();
            General<int> objGeneral2 = new General<int>(2);
            objGeneral2.Add(200);
            objGeneral2.Add(35);
            objGeneral2.Display();
        }
    }
}
