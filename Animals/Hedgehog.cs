using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Hedgehog : Animal
    {
        public bool IsPointy { get; private set; }
        public Hedgehog(string name, int age, double weight) : base(name, age, weight) 
        {
            IsPointy = true;
        }

        internal override void DoSound()
        {
            Console.WriteLine("Hedgehog says: give me milk");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is pointy: {IsPointy}";
        }
    }
}
