namespace XP_FP_Workshop
{
    public class Transaction
    {
        public readonly Location From;
        public readonly Location To;
        public readonly int Quantity;
        public readonly MedicalItem Item;

        public Transaction(Location From, Location To, MedicalItem Item, int Quantity)
        {
            this.From = From;
            this.To = To;
            this.Item = Item;
            this.Quantity = Quantity;
        }
    }
}