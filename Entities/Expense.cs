namespace Finance.Entities
{
    public class Expense : Transaction
    {
        public double value { get; set; }
        public DateTime date { get; set; }
    }
}
