using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Hello World!");
                //Date date1 = new Date(2022, 8, 9);
                //Console.WriteLine(date1);
                //Console.WriteLine(new Date(2022, 18, 19));

                Employee employee1 = new SalaryEmployee()
                {
                    Id = 1023,
                    FirstName = "Alejandro",
                    LastName = "Betancur",
                    BirthDate = new Date(1990, 5, 23),
                    HiringDate = new Date(2022, 1, 14),
                    IsActive = true,
                    Salary = 1811345.45M
                };
                Console.WriteLine(employee1);

                Employee employee2 = new CommissionEmployee()
                {
                    Id = 2020,
                    FirstName = "Juan",
                    LastName = "Pedro",
                    BirthDate = new Date(1990, 5, 23),
                    HiringDate = new Date(2022, 1, 14),
                    IsActive = true,
                    Sales = 811345M,
                    CommissionPercentaje = 0.03F
                };
                Console.WriteLine(employee2);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
