using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Worm : Animal
    {
        public bool IsAPet { get; protected set; }
        public Worm(string name, int age, double weight) : base(name, age, weight)
        {
            IsAPet = false;
        }

        internal override void DoSound()
        {
            Console.WriteLine("Worm says: -no sound found-");
        }
    }
}
