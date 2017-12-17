namespace XP_FP_Workshop
{
    public enum Items
    {
        Paracetamol,
        Ibuprofen,
        Syringe,
        Scalpel
    }

    public class MedicalItem
    {
        public readonly Items Name;
        public readonly int Quantity;

        public MedicalItem(Items Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}