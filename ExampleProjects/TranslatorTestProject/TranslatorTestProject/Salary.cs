namespace TranslatorTestProject
{
    public class Salary
    {
        public int Amount { get; set; }
        public string SalaryCurrency { get; set; }

        public override string ToString()
        {
            return $"{Amount} {SalaryCurrency}";
        }
    }
}
