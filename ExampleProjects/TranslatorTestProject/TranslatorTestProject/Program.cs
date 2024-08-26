using System;

namespace TranslatorTestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var peter = new Employee()
            {
                FirstName = "Peter",
                LastName = "Parker",
                Salary = new Salary { Amount = 1000, SalaryCurrency = "USD" },
            };
            Console.WriteLine(peter);
        }
    }
}
