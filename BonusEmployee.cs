namespace Employees
{
    public abstract class BonusEmployee: Employee
    {
        public double Bonus { get; set; }
        public double SalesVolume { get; set; }
    }
}