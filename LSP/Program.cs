using System;
using EmployeeLib;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            Employee accountingVp = new Manager();

            accountingVp.FirstName = "Emma";
            accountingVp.LastName = "Stone";
            accountingVp.CalculatePerHourRate(4);

            Console.WriteLine($"{ accountingVp.FirstName }'s salary is ${ accountingVp.Salary }/hour.");

            Employee emp = new CEO();

            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
