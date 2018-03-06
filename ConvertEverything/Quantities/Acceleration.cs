namespace ConvertEverything.Quantities
{
    internal class Acceleration : DerivedQuantity
    {
        public Acceleration()
            : base(1, 0, 2, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "\\vec{v}";
    }
}