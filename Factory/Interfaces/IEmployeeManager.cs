using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IEmployeeManager
    {
        public decimal GetPay();
        public decimal GetBonus();
    }
}
