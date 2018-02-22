namespace ConvertEverything.Quantities
{
    internal class Pressure : DerivedQuantity
    {
        public override string QuantitySymbol => "p";

        public Pressure()
            : base(-1, 1, -2, 0, 0, 0, 0)
        {
        }
    }
}