using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class Manager : BonusEmployee
    {
        public override double GetSalary(int days)
        {
            return base.GetSalary(days) + Bonus * SalesVolume;
        }
    }
}
