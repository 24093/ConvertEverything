using System;
using System.Collections.Generic;
using ConvertEverything.Quantities;

namespace ConvertEverything
{
    internal abstract class Quantified
    {
        protected readonly Dictionary<IQuantity, int> Quantities = new Dictionary<IQuantity, int>();

        protected Quantified(int lengthQuantity, int massQuantity, int timeQuantity, int electricCurrentQuantity,
            int thermodynamicTemperatureQuantity, int amountOfSubstanceQuantity, int luminousIntensityQuantity)
        {
            Quantities.Add(new Length(), lengthQuantity);
            Quantities.Add(new Mass(), massQuantity);
            Quantities.Add(new Time(), timeQuantity);
            Quantities.Add(new ElectricCurrent(), electricCurrentQuantity);
            Quantities.Add(new ThermodynamicTemperature(), thermodynamicTemperatureQuantity);
            Quantities.Add(new AmountOfSubstance(), amountOfSubstanceQuantity);
            Quantities.Add(new LuminousIntensity(), luminousIntensityQuantity);
        }

        protected Quantified(Dictionary<IQuantity, int> quantities)
        {
            Quantities = quantities;
        }
        
        protected string ComposeQuantifiedString(Func<IQuantity, int, string> quantityAction)
        {
            var symbol = string.Empty;

            foreach (var keyValuePair in Quantities)
                if (keyValuePair.Value != 0)
                    symbol += quantityAction(keyValuePair.Key, keyValuePair.Value);

            return symbol.Trim();
        }
    }
}