using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Power : DerivedQuantity
    {
        public Power()
            : base(2, 1, -3, 0, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "P";

        public override IUnit CommonUnit => new Watt();
    }
}