using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Horse : Animal
    {
        public bool IsRideAble { get; protected set; }
        public Horse(string name, int age, double weight) : base(name, age, weight) 
        { 
            IsRideAble = true;
        }

        internal override void DoSound()
        {
            Console.WriteLine("geeeehegeeeehegeeeehe");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is rideable: {IsRideAble}";
        }
    }
}
