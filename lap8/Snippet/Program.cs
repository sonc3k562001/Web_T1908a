using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snippet
{
    class Animal
    {
        public void Eat()
        {
            
        }
       
    }
    class employee
    {
        int _empId = 1;
        string _empName = "james Anderson";
        int _age = 25;
        public void Display()
        {
            Console.WriteLine("EmployeeID :" + _empId);
            Console.WriteLine("EmployeeName :" + _empName);
        }
    }
    class Department : employee
    {
        int _deptId = 501;
        string _deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department Id:" + _deptId);
            Console.WriteLine("Department name:" + _deptName);
        }
        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    }
   
}
