using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class CEO: BonusEmployee
    {
        public override double GetSalary(int days)
        {
            return Bonus * SalesVolume;
        }
    }
}
