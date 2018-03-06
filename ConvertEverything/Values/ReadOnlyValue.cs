using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class ReadOnlyValue : IValue
    {
        public ReadOnlyValue(double value, double precision, IQuantity quantity, IUnit unit)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
        }

        public double Value { get; }

        public double Precision { get; }

        public IQuantity Quantity { get; }

        public IUnit Unit { get; }

        public IValue DeepClone()
        {
            return new ReadOnlyValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone());
        }

        public MutableValue ToMutableValue()
        {
            return new MutableValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone());
        }
    }
}