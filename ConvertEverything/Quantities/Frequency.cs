namespace ConvertEverything.Quantities
{
    internal class Frequency : DerivedQuantity
    {
        public override string QuantitySymbol => "f";

        public Frequency()
            : base(0, 0, -1, 0, 0, 0, 0)
        {
        }
    }
}