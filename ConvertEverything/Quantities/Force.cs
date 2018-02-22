namespace ConvertEverything.Quantities
{
    internal class Force : DerivedQuantity
    {
        public override string QuantitySymbol => "\\vec{F}";

        public Force()
            : base(1, 1, -2, 0, 0, 0, 0)
        {
        }
    }
}