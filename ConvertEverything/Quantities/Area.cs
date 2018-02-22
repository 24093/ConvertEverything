namespace ConvertEverything.Quantities
{
    internal class Area : DerivedQuantity
    {
        public override string QuantitySymbol => "A";

        public Area() 
            : base(2, 0, 0, 0, 0, 0, 0)
        {
        }
    }
}