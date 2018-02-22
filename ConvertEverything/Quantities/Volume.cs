namespace ConvertEverything.Quantities
{
    internal class Volume : DerivedQuantity
    {
        public override string QuantitySymbol => "V";

        public Volume()
            : base(3, 0, 0, 0, 0, 0, 0)
        {
        }
    }
}