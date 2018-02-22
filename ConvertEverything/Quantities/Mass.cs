using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class Mass : IQuantity
    {
        public string QuantitySymbol => "m";

        public string DimensionSymbol => "M";

        public IUnit SiUnit => new Kilogram();

        public IQuantity DeepClone()
        {
            return new Mass();
        }
    }
}