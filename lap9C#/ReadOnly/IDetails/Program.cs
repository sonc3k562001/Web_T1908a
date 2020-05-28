using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDetails
{
    interface IDetails
    {
        void GetDetails();
    }
    class Student : IDetails
    {
        string _studName;
        int _studID;
        public Student(string name, int num)
        {
            _studName = name;
            _studID = num;
        }
        public void GetDetails()
        {
            Console.WriteLine(_studID + "\t" + _studName);
        }
    }
    class GenericList<T> where T : IDetails
    {
        T[] _values = new T[3];
        int _couter = 0;
        public void Add(T val)
        {
            _values[_couter] = val;
            _couter++;
        }
        public void Display()
        {
            for(int i = 0; i< 3; i++)
            {
                _values[i].GetDetails();
            }
        }
    }
    class InterfaceConstraintDemo
    {
        static void Main( string [] args)
        {
            GenericList<Student> objList = new GenericList<Student>();
            objList.Add(new Student("Wilson", 120));
            objList.Add(new Student("jack", 130));
            objList.Add(new Student("Peter", 140));
            objList.Display();
        }
    }
}
