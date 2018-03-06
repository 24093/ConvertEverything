using System;
using ConvertEverything.Values;

namespace ConvertEverything.Units
{
    internal class MilliMetre : IUnit
    {
        public string Symbol => "mm";

        public IUnit DeepClone()
        {
            return new MilliMetre();
        }

        public Action<MutableValue> Converter(Metre unit)
        {
            return value =>
            {
                value.Value = value.Value / 1000;
                value.Precision = value.Precision / 1000;
                value.Unit = unit.DeepClone();
            };
        }
    }
}