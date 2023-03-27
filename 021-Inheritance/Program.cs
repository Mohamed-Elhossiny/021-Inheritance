namespace _021_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(1000, "Ali Ahmed", 180, 10);

            Maintance ms = new Maintance(1000, "Salim M.", 182, 8);

            Sales s = new Sales(1002, "Sara", 176, 9, 10000m, .05m);

            Developer d = new Developer(1003, "Mohamed Said", 186, 15, true);

            Employee[] employees = { m, ms, s, d };

            foreach (var employee in employees)
            {
                Console.WriteLine("\n-----------");
                Console.WriteLine(employee);
            }


            Console.ReadKey();
        }
    }


}