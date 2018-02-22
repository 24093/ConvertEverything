using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class LuminousIntensity : IQuantity
    {
        public string QuantitySymbol => "I_v";

        public string DimensionSymbol => "J";

        public IUnit SiUnit => new Candela();

        public IQuantity DeepClone()
        {
            return new LuminousIntensity();
        }
    }
}