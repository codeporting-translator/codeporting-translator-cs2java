namespace TranslatorTestProject
{
    public class Employee : Person
    {
        public Salary Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", salary : {Salary}";
        }
    }
}
