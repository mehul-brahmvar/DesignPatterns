using FactoryMethod.Interfaces;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public abstract class BaseEmployeeFactory
    {
        public Employee employee;
        public BaseEmployeeFactory(Employee employee)
        {
            this.employee = employee;
        }

        public abstract IEmployeeManager Create();

        public Employee ApplyPay()
        {
            IEmployeeManager manager = this.Create();
            this.employee.Bonus = manager.GetBonus();
            this.employee.Pay = manager.GetPay();

            return this.employee;
        }
    }
}
