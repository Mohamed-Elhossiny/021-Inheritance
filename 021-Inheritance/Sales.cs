namespace _021_Inheritance
{
    public class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }
        public Sales(int id, string name, decimal loggedHours, decimal wage,decimal salesvolume,decimal commsion) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume= salesvolume;
            this.Commission = commsion;
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }

        private decimal CalculateBouns() 
        {
            return SalesVolume * Commission;
        }


        public override string ToString()
        {
            return base.ToString() +
                 $"\nCommission: {Math.Round(Commission, 2):N0} $" +
                 $"\nBouns: {Math.Round(CalculateBouns(), 2):N0} $" +
                 $"\nNetSalary: {Math.Round(this.Calculate(), 2):N0} $";
        }
    }
}