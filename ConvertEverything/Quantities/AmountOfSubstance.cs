using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class AmountOfSubstance : IQuantity
    {
        public string QuantitySymbol => "n";

        public string DimensionSymbol => "N";

        public IUnit SiUnit => new Mole();

        public IQuantity DeepClone()
        {
            return new AmountOfSubstance();
        }
    }
}