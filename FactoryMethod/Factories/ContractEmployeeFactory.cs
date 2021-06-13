using FactoryMethod.Interfaces;
using FactoryMethod.Managers;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            employee.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
