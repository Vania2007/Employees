using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public abstract class Employee
    {
        public string Name { get; set; } = "NoName";
        public double Rank { get; set; }
        public virtual double GetSalary(int days)=> Rank + days;
    }
}
