using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Managers
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
    }
}
