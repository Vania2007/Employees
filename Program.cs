using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Security() { Name = "Petro", Rank = 500 });
            employees.Add(new Manager() { Name = "Stepan", Rank = 200, Bonus = 0.01, SalesVolume = 100000 });
            employees.Add(new CEO() { Name = "Taras", Rank = 600, Bonus = 0.005, SalesVolume = 1000000 });
            foreach(Employee empl in employees)
            {
                Console.WriteLine($"{empl.Name} got {empl.GetSalary(30)}");
            }
        }
    }
}
