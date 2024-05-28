namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person Marcus = new Person
                {
                    Age = -15
                };
                Console.WriteLine($"Person age is {Marcus.Age}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
