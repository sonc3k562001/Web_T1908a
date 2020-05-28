using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine(" Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
    }
    class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lions roars");
        }
        static void Main(string[] args)
        {
            Lion objLione = new Lion();
            objLione.AnimalSound();
            objLione.Eat();
        }
    }
}
