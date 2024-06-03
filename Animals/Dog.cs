using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Dog : Animal
    {
        //Properties
        public bool IsAPet { get; protected set; }

        //Constructor
        public Dog(string name, int age, double weight) : base(name, age, weight)
        {
            IsAPet = true;
        }
        internal override void DoSound()
        {
            Console.WriteLine("WoffWoff");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is a pet: {IsAPet}";
        }

        // Den här metoden kommer jag inte åt från Animals listan pga att den är definierad här.
        public string DogPoem()
        {
            return "Faithful friend with wagging tail, unconditional love never fails.";
        }
    }
}
