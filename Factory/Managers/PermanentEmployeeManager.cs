using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}
