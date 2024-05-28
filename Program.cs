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
                personHandler.CreatePerson(15, "Marcus", "Pedersen", 1.87, 85);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
