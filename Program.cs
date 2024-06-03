using System.Security.Cryptography.X509Certificates;
using Task3.Animals;
using Task3.ErrorHandling;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Person person = new Person
                {
                    FName = "Marcus",
                    LName = "Pedersen"
                };
                PersonHandler personHandler = new PersonHandler();
                personHandler.SetAge(person, 27);
                Console.WriteLine($"{person.FName} {person.LName} is {person.Age} years old");
                */

                // Instantiate PersonHandler
                PersonHandler personHandler = new PersonHandler();

                // Create a new Person object
                personHandler.CreatePerson(27, "Marcus", "Pedersen", 1.87, 85);
                personHandler.CreatePerson(52, "Stefan", "Johanneson", 1.37, 45);
                personHandler.CreatePerson(55, "Krister", "Persson", 1.77, 73);
                personHandler.CreatePerson(88, "Nils", "Svensson", 1.95, 105);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // List of user errors
            List<UserError> errors = [new NumericInputError(), new TextInputError()];
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> animals = new List<Animal>
            {
                new Dog("Allan", 4, 30.2),
                new Horse("Asterix", 15, 560),
                new Wolf("Weezie", 6, 45.5)
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
            }
        }
    }
}
