using Factory.Factories;
using Factory.Interfaces;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory pattern");
            Console.WriteLine("===============");
            Console.WriteLine("Permanent employee");
            IEmployeeManager employeeManager = (new EmployeeManagerFactory()).GetEmployeeManager(1);
            Console.WriteLine($"Bonus: {employeeManager.GetBonus()}");
            Console.WriteLine($"Pay: {employeeManager.GetPay()}");

            Console.WriteLine("Contract employee");
            employeeManager = (new EmployeeManagerFactory()).GetEmployeeManager(2);
            Console.WriteLine($"Bonus: {employeeManager.GetBonus()}");
            Console.WriteLine($"Pay: {employeeManager.GetPay()}");

            Console.ReadLine();
        }
    }
}
