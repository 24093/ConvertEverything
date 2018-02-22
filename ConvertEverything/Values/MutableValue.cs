using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class MutableValue<TData> : IValue<TData>
    {
        public History History = new History();

        private TData _value;
        
        public TData Value
        {
            get => _value;
            set
            {
                _value = value;
                History.Add(nameof(Value), Value, value);
            }
        }

        public TData Precision { get; }

        public IQuantity Quantity { get; }

        public IUnit Unit { get; }
        
        public MutableValue(TData value, TData precision, IQuantity quantity, IUnit unit)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
        }
        
        public IValue<TData> DeepClone()
        {
            var value = Value is IDeepCloneable<TData> v ? v.DeepClone() : Value;
            var precision = Precision is IDeepCloneable<TData> p ? p.DeepClone() : Precision;

            return new MutableValue<TData>(value, precision, Quantity.DeepClone(), Unit.DeepClone())
            {
                History = History.DeepClone()
            };
        }

        public ReadOnlyValue<TData> ToReadOnlyValue()
        {
            var value = Value is IDeepCloneable<TData> v ? v.DeepClone() : Value;
            var precision = Precision is IDeepCloneable<TData> p ? p.DeepClone() : Precision;

            return new ReadOnlyValue<TData>(value, precision, Quantity.DeepClone(), Unit.DeepClone());
        }
    }
}