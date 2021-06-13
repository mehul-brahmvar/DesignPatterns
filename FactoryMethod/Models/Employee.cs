using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    public class Employee
    {
        public int EmployeeType { get; set; }
        public decimal Bonus { get; set; }
        public decimal Pay { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
    }
}
