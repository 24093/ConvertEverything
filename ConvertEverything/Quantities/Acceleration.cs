namespace ConvertEverything.Quantities
{
    internal class Acceleration : DerivedQuantity
    {
        public override string QuantitySymbol => "\\vec{v}";

        public Acceleration()
            : base(1, 0, 2, 0, 0, 0, 0)
        {
        }
    }
}