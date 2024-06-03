using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals.Birds
{
    internal class Swan : Bird
    {
        public bool IsACommonAnimal { get; protected set; }
        public Swan(string name, int age, double weight) : base(name, age, weight)
        {
            IsACommonAnimal = true;
        }
        public override string Stats()
        {
            return $"{base.Stats()}, Is a common animal: {IsACommonAnimal}";
        }
    }
}
