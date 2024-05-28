namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Person person = new Person
                {
                    FName = "Marcus",
                    LName = "Pedersen"
                };
                PersonHandler personHandler = new PersonHandler();
                personHandler.SetAge(person, 27);
                Console.WriteLine($"{person.FName} {person.LName} is {person.Age} years old");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
