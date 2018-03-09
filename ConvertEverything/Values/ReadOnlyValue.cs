using ConvertEverything.Quantities;
using ConvertEverything.Scales;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class ReadOnlyValue : IValue
    {
        public ReadOnlyValue(double value, double precision, IQuantity quantity, IUnit unit, IScale scale)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
            Scale = scale;
        }

        public double Value { get; }

        public double Precision { get; }

        public IQuantity Quantity { get; }

        public IUnit Unit { get; }

        public IScale Scale { get; }

        public IValue DeepClone()
        {
            return new ReadOnlyValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone(), Scale.DeepClone());
        }

        public MutableValue ToMutableValue()
        {
            return new MutableValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone(), Scale.DeepClone());
        }
    }
}