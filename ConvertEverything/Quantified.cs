using System;
using System.Collections.Generic;
using ConvertEverything.Quantities;

namespace ConvertEverything
{
    internal abstract class Quantified
    {
        private readonly Dictionary<IQuantity, int> _quantities = new Dictionary<IQuantity, int>();

        protected Quantified(int lengthQuantity, int massQuantity, int timeQuantity, int electricCurrentQuantity,
            int thermodynamicTemperatureQuantity, int amountOfSubstanceQuantity, int luminousIntensityQuantity)
        {
            _quantities.Add(new Length(), lengthQuantity);
            _quantities.Add(new Mass(), massQuantity);
            _quantities.Add(new Time(), timeQuantity);
            _quantities.Add(new ElectricCurrent(), electricCurrentQuantity);
            _quantities.Add(new ThermodynamicTemperature(), thermodynamicTemperatureQuantity);
            _quantities.Add(new AmountOfSubstance(), amountOfSubstanceQuantity);
            _quantities.Add(new LuminousIntensity(), luminousIntensityQuantity);
        }

        protected string ComposeQuantifiedString(Func<IQuantity, int, string> quantityAction)
        {
            var symbol = string.Empty;

            foreach (var keyValuePair in _quantities)
                if (keyValuePair.Value != 0)
                    symbol += quantityAction(keyValuePair.Key, keyValuePair.Value);

            return symbol.Trim();
        }
    }
}