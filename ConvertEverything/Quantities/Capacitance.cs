using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Capacitance : DerivedQuantity
    {
        public Capacitance()
            : base(-2, -1, 4, 2, 0, 0, 0)
        {
        }

        public override string QuantitySymbol => "C";

        public override IUnit CommonUnit => new Farad();
    }
}