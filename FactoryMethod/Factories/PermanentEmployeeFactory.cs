using FactoryMethod.Interfaces;
using FactoryMethod.Managers;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            employee.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
