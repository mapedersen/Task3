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
                    Age = 15,
                    FName = "Marcus",
                    LName = "Pedersen"
                };

                Console.WriteLine($"{person.FName} {person.LName} is {person.Age} years old");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
