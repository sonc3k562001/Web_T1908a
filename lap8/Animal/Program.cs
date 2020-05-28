using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
       
    }
    class Manmal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Nanmals give birth to young onea.");
        }
    }
    class Dog: Manmal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks");
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
    class Cat : Animal
    {
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
       
        }
    }
}
