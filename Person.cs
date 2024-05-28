using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Person
    {
        private int _age;
        private string _fName;
        private string _lName;
        private int _height;
        private int _weight;

        public int Age 
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be less than 0");
                else if (value > 0)
                {
                    _age = value;
                }
            } 
        }
    }
}
