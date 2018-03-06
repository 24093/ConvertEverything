using System.Collections.Generic;
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

        private DerivedQuantity(Dictionary<IQuantity, int> quantities, IUnit siUnit)
            : base(quantities)
        {
            SiUnit = siUnit;
        }

        public virtual IUnit CommonUnit => SiUnit;

        public virtual string QuantitySymbol => ComposeQuantitySymbol();

        public string DimensionSymbol => ComposeDimensionSymbol();

        public IUnit SiUnit { get; }

        public IQuantity DeepClone()
        {
            var q = new Dictionary<IQuantity, int>();

            foreach (var quantity in Quantities)
                q.Add(quantity.Key.DeepClone(), quantity.Value);

            return new DerivedQuantity(q, SiUnit.DeepClone());
        }

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