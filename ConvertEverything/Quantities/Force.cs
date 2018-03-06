using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Force : DerivedQuantity
    {
        public Force()
            : base(1, 1, -2, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "\\vec{F}";

        public override IUnit CommonUnit => new Newton();
    }
}