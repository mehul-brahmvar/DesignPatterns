using Factory.Interfaces;
using Factory.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public class EmployeeManagerFactory
    {
        public EmployeeManagerFactory()
        {

        }

        public IEmployeeManager GetEmployeeManager(int employeeType)
        {
            if (employeeType == 1)
                return new PermanentEmployeeManager();
            else if (employeeType == 2)
                return new ContractEmployeeManager();
            else
                return null;
        }
    }
}
