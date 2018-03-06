namespace ConvertEverything.Quantities
{
    internal class Area : DerivedQuantity
    {
        public Area()
            : base(2, 0, 0, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "A";
    }
}