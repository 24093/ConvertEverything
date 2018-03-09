using System;
using ConvertEverything.Scales;
using ConvertEverything.Values;

namespace ConvertEverything.Units
{
    internal static class ScaledUnit
    {
        public static Action<MutableValue> Converter(IScale scale, IUnit unit) => Converter(scale.Factor, unit);

        private static Action<MutableValue> Converter(double factor, IUnit unit)
        {
            return value =>
            {
                value.Value = value.Value * factor;
                value.Precision = value.Precision * factor;
                value.Unit = unit.DeepClone();
            };
        }
    }
}