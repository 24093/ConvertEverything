using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Length : IQuantity
    {
        public string QuantitySymbol => "l";

        public string DimensionSymbol => "L";

        public IUnit SiUnit => new Metre();
    }
}