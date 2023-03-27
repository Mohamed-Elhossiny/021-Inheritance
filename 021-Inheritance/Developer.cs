namespace _021_Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commsion = .03m;
        protected bool TaskCompleted { get; set; }
        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskcompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskcompleted;
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }

        private decimal CalculateBouns()
        {
            if (TaskCompleted)
                return base.Calculate() * Commsion;
            return 0;
        }


        public override string ToString()
        {
            return base.ToString() +
                 $"\nTaskCompleted: {(TaskCompleted ? "Yes": "No")}" +
                 $"\nBouns: {Math.Round(CalculateBouns(), 2):N0} $" +
                 $"\nNetSalary: {Math.Round(this.Calculate(), 2):N0} $";
        }
    }
}