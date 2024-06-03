using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals.Birds
{
    internal class Pelican : Bird
    {
        public bool IsExotic { get; protected set; }
        public Pelican(string name, int age, double weight) : base(name, age, weight)
        {
            IsExotic = true;
        }
    }
}
