using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class ThermodynamicTemperature : IQuantity
    {
        public string QuantitySymbol => "T";

        public string DimensionSymbol => "Θ";

        public IUnit SiUnit => new Kelvin();
    }
}