using FactoryMethod.Factories;
using FactoryMethod.Models;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method pattern");
            
            EmployeeManagerFactory employeeManagerFactory = new EmployeeManagerFactory();
            BaseEmployeeFactory baseEmployeeFactory = employeeManagerFactory.CreateFactory(
                new Models.Employee() { EmployeeType = 1 });
            
            Employee employee = baseEmployeeFactory.ApplyPay();

            Console.WriteLine($"Bonus: {employee.Bonus}");
            Console.WriteLine($"EmployeeType: {employee.EmployeeType}");
            Console.WriteLine($"House Allowance: {employee.HouseAllowance}");
            Console.WriteLine($"Medical Allowance: {employee.MedicalAllowance}");
            Console.WriteLine($"Pay: {employee.Pay}");

            Console.ReadLine();
        }
    }
}
