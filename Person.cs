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
        private double _height;
        private double _weight;

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
        public required string FName
        {
            get { return _fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name cannot be less than 2 or longer than 10 characters");
                }
                else
                {
                    _fName = value;
                }
            }
        }
        public required string LName
        {
            get { return _lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name cannot be less than or longer than 15 characters");
                }
                else
                {
                    _lName = value;
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight 
        { 
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
