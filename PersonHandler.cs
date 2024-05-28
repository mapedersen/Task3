using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class PersonHandler
    {
        // Methods to handle operations on person
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public void SetFirstName(Person person, string firstName)
        {
            person.FName = firstName;
        }
        public void SetLastName(Person person, string lastName)
        {
            person.LName = lastName;
        }
        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        public void setWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        // Method to create a person object
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight,
            };
            return person;
        }
    }
}
