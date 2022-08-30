using System;
using System.Collections.Generic;

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
                //Console.WriteLine(employee1);

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
                //Console.WriteLine(employee2);

                Employee employee3 = new HourlyEmployee()
                {
                    Id = 2034,
                    FirstName = "Rosa",
                    LastName = "Gil",
                    BirthDate = new Date(1990, 5, 23),
                    HiringDate = new Date(2022, 1, 14),
                    IsActive = true,
                    Hours = 123.5F,
                    HourValue = 12345.30M
                };
                //Console.WriteLine(employee3);

                Employee employee4 = new BaseCommissionEmployee()
                {
                    Id = 1034,
                    FirstName = "Pedro",
                    LastName = "Gil",
                    BirthDate = new Date(1990, 5, 23),
                    HiringDate = new Date(2022, 1, 14),
                    IsActive = true,
                    Base = 1200000M,
                    Sales = 50200000M,
                    CommissionPercentaje = 0.15F
                };
                //Console.WriteLine(employee3);

                //ICollection<Employee> employees = new List<Employee>();
                //employees.Add(employee1);
                //employees.Add(employee2);

                ICollection<Employee> employees = new List<Employee>()
                {
                    employee1, employee2, employee3, employee4
                };

                decimal payroll = 0;
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                    payroll += employee.GetValueToPay();
                }

                Console.WriteLine("            =======================");
                Console.WriteLine($"TOTAL   {payroll:C2}   =======================");

                Invoice invoice1 = new Invoice()
                {
                    Description = "Iphone 13",
                    Id = 1,
                    Price = 5300000M,
                    Quantity = 3
                };

                Invoice invoice2 = new Invoice()
                {
                    Description = "Posta",
                    Id = 2,
                    Price = 320000M,
                    Quantity = 17.5F
                };
                Console.WriteLine(invoice1);
                Console.WriteLine(invoice2);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
