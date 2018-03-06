namespace ConvertEverything.Quantities
{
    internal class Pressure : DerivedQuantity
    {
        public Pressure()
            : base(-1, 1, -2, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "p";
    }
}