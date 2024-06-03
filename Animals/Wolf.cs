using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Wolf : Animal
    {
        public bool IsKiller { get; protected set; }
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
            IsKiller = true;
        }

        internal override void DoSound()
        {
            Console.WriteLine("owooooo");
        }
    }
}
