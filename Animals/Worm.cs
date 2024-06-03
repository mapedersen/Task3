using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Worm : Animal
    {
        public bool IsFishFood { get; protected set; }
        public Worm(string name, int age, double weight) : base(name, age, weight)
        {
            IsFishFood = false;
        }

        internal override void DoSound()
        {
            Console.WriteLine("Worm says: -no sound found-");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is fishfood: {IsFishFood}";
        }
    }
}
