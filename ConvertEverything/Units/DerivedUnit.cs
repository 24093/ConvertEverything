using System.Collections.Generic;
using ConvertEverything.Quantities;

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

        private DerivedUnit(Dictionary<IQuantity, int> quantities)
            : base(quantities)
        {
        }

        public string Symbol => ComposeSymbol();
        
        private string ComposeSymbol()
        {
            return ComposeQuantifiedString((quantity, power) => quantity.SiUnit.Symbol + "^" + power + " ");
        }

        public IUnit DeepClone()
        {
            var q = new Dictionary<IQuantity, int>();

            foreach (var quantity in Quantities)
                q.Add(quantity.Key.DeepClone(), quantity.Value);

            return new DerivedUnit(q);
        }
    }
}