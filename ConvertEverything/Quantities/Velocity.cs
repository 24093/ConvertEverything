namespace ConvertEverything.Quantities
{
    internal class Velocity : DerivedQuantity
    {
        public Velocity()
            : base(1, 0, -1, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "\\vec{v}";
    }
}