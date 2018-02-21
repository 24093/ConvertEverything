namespace ConvertEverything.Units
{
    internal class DerivedUnit : Quantified, IUnit
    {
        public DerivedUnit(int lengthQuantity, int massQuantity, int timeQuantity, int electricCurrentQuantity,
            int thermodynamicTemperatureQuantity, int amountOfSubstanceQuantity, int luminousIntensityQuantity)
            : base(lengthQuantity, massQuantity, timeQuantity, electricCurrentQuantity,
                thermodynamicTemperatureQuantity, amountOfSubstanceQuantity, luminousIntensityQuantity)
        {
        }

        public string Symbol => ComposeSymbol();

        private string ComposeSymbol()
        {
            return ComposeQuantifiedString((quantity, power) => quantity.SiUnit.Symbol + "^" + power + " ");
        }
    }
}