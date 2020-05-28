using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITsystem
{
    class ITSystem
    {
        public virtual void Print()
        {
            Console.WriteLine("the system should be handled carefullly");
        }
    }
    class CompanySystem : ITSystem
    {
        public override sealed void Print()
        {
            Console.WriteLine("The system information is confidential");
            Console.WriteLine("This information should not be overridden");
        }
    }
    class SealedSystem : CompanySystem
    {
        static void Main(string[] args)
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.Print();
        }
    }
}
