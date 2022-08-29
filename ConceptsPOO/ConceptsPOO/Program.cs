using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                Date date1 = new Date(2022, 8, 9);
                Console.WriteLine(date1);
                Console.WriteLine(new Date(2022, 18, 19));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
