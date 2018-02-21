using ConvertEverything.Applications;
using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class MutableValue<TData> : IValue<TData>
    {
        public TData Value { get; set; }

        public TData Precision { get; set; }

        public IQuantity Quantity { get; set; }

        public IUnit Unit { get; set; }

        public IApplication Application { get; set; }

        public IValue<TData> DeepClone()
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

        public ReadOnlyValue<TData> ToReadOnlyValue()
        {
            var value = Value is IDeepCloneable<TData> v ? v.DeepClone() : Value;
            var precision = Precision is IDeepCloneable<TData> p ? p.DeepClone() : Precision;

            return new ReadOnlyValue<TData>(value, precision, Quantity, Unit, Application);
        }
    }
}