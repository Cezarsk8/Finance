namespace Finance.Entities
{
    public class Revenue : Transaction
    {
        public double value { get; set; }
        public DateTime date { get; set; }
    }
}