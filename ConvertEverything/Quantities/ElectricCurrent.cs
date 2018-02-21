using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class ElectricCurrent : IQuantity
    {
        public string QuantitySymbol => "I";

        public string DimensionSymbol => "I";

        public IUnit SiUnit => new Ampere();
    }
}