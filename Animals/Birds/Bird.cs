using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals.Birds
{
    internal class Bird : Animal
    {
        public bool CanSing { get; protected set; }
        public Bird(string name, int age, double weight) : base(name, age, weight)
        {
            CanSing = true;
        }

        internal override void DoSound()
        {
            Console.WriteLine("Feeeeee-beeeeeee");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Can sing: {CanSing}";
        }
    }
}


// Om vi kommer fram till att samtliga fåglar behöver en ny egenskap implementerar
// vi det här då fåglarna ärver från denna klass, det innebär att vi inte behöver lägga
// till det hos varje enskild fågeltyp.