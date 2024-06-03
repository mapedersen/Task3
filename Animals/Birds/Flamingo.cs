using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals.Birds
{
    internal class Flamingo : Bird
    {
        public bool IsPink { get; protected set; }
        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {
            IsPink = true;
        }
    }
}
