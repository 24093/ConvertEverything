namespace ConvertEverything.Quantities
{
    internal class Volume : DerivedQuantity
    {
        public Volume()
            : base(3, 0, 0, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "V";
    }
}