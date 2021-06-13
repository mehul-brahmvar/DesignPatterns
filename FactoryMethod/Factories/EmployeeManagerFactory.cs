using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory baseEmployeeFactory = null;

            if(employee.EmployeeType == 1)
            {
                baseEmployeeFactory = new PermanentEmployeeFactory(employee);
            }
            else if(employee.EmployeeType == 2)
            {
                baseEmployeeFactory = new ContractEmployeeFactory(employee);
            }

            return baseEmployeeFactory;
        }
    }
}
