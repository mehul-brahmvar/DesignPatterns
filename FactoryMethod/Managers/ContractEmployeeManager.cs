using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }

        public decimal GetMedicalAllowance()
        {
            return 105;
        }
    }
}
