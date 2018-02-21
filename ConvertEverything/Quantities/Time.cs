using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Time : IQuantity
    {
        public string QuantitySymbol => "t";

        public string DimensionSymbol => "T";

        public IUnit SiUnit => new Second();
    }
}