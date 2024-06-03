using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Wolfman says: I'm the wolfman");
        }
    }
}
