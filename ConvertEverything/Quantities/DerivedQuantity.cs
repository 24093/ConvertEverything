using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal class DerivedQuantity : Quantified, IQuantity
    {
        public DerivedQuantity(int lengthQuantity, int massQuantity, int timeQuantity, int electricCurrentQuantity,
            int thermodynamicTemperatureQuantity, int amountOfSubstanceQuantity, int luminousIntensityQuantity)
            : base(lengthQuantity, massQuantity, timeQuantity, electricCurrentQuantity,
                thermodynamicTemperatureQuantity, amountOfSubstanceQuantity, luminousIntensityQuantity)
        {
            SiUnit = new DerivedUnit(lengthQuantity, massQuantity, timeQuantity, electricCurrentQuantity,
                thermodynamicTemperatureQuantity, amountOfSubstanceQuantity, luminousIntensityQuantity);
        }

        public string QuantitySymbol => ComposeQuantitySymbol();

        public string DimensionSymbol => ComposeDimensionSymbol();

        public IUnit SiUnit { get; }

        private string ComposeQuantitySymbol()
        {
            return ComposeQuantifiedString((quantity, power) => quantity.QuantitySymbol + "^" + power + " ");
        }

        private string ComposeDimensionSymbol()
        {
            return ComposeQuantifiedString((quantity, power) => quantity.DimensionSymbol + "^" + power + " ");
        }
    }
}