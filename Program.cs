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
                    FName = "Marcus"
                };
                Console.WriteLine($"Persons age is {person.Age} years old and the first-name is {person.FName}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }
    }
}
