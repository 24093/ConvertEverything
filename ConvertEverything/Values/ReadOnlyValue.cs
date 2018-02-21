using ConvertEverything.Applications;
using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class ReadOnlyValue<TData> : IValue<TData>
    {
        public ReadOnlyValue(TData value, TData precision, IQuantity quantity, IUnit unit, IApplication application)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
            Application = application;
        }

        public TData Value { get; }

        public TData Precision { get; }

        public IQuantity Quantity { get; }

        public IUnit Unit { get; }

        public IApplication Application { get; }

        public IValue<TData> DeepClone()
        {
            var value = Value is IDeepCloneable<TData> v ? v.DeepClone() : Value;
            var precision = Precision is IDeepCloneable<TData> p ? p.DeepClone() : Precision;

            return new ReadOnlyValue<TData>(value, precision, Quantity, Unit, Application);
        }

        public MutableValue<TData> ToMutableValue()
        {
            var value = Value is IDeepCloneable<TData> v ? v.DeepClone() : Value;
            var precision = Precision is IDeepCloneable<TData> p ? p.DeepClone() : Precision;

            return new MutableValue<TData>
            {
                Value = value,
                Precision = precision,
                Quantity = Quantity,
                Unit = Unit,
                Application = Application
            };
        }
    }
}