namespace ConvertEverything.Quantities
{
    internal class Velocity : DerivedQuantity
    {
        public override string QuantitySymbol => "\\vec{v}";

        public Velocity()
            : base(1, 0, -1, 0, 0, 0, 0)
        {
        }
    }
}