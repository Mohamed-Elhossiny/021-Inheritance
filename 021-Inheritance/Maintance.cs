namespace _021_Inheritance
{
    public class Maintance : Employee
    {
        private const decimal HardShip = 100m;
        public Maintance(int id, string name, decimal loggedHours, decimal wage) : base(id,name,loggedHours,wage)
        {
            
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }

        public override string ToString()
        {
            return base.ToString() +
                 $"\nHardShip: {Math.Round(HardShip, 2):N0} $" +
                 $"\nNetSalary: {Math.Round(this.Calculate(), 2):N0} $";
        }
    }
}