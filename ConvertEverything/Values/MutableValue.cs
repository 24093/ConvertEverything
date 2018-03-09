using ConvertEverything.Quantities;
using ConvertEverything.Units;
using System.Collections.Generic;
using ConvertEverything.Scales;

namespace ConvertEverything.Values
{
    internal class MutableValue : IValue
    {
        public readonly ReadOnlyValue OriginalValue;

        private readonly List<Change> _history = new List<Change>();

        private double _precision;

        private IQuantity _quantity;

        private IUnit _unit;

        private double _value;

        private IScale _scale;

        public MutableValue()
        {
        }

        public MutableValue(double value, double precision, IQuantity quantity, IUnit unit, IScale scale)
        {
            OriginalValue = new ReadOnlyValue(value, precision, quantity, unit, scale);

            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
            Scale = scale;
        }

        private MutableValue(double value, double precision, IQuantity quantity, IUnit unit, IScale scale, List<Change> history)
        {
            OriginalValue = new ReadOnlyValue(value, precision, quantity, unit, scale);

            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
            Scale = scale;
            _history = history;
        }

        public IEnumerable<Change> History => _history.AsReadOnly();

        public double Value
        {
            get => _value;
            set
            {
                LogChange(nameof(Value), Value, value);
                _value = value;
            }
        }

        public double Precision
        {
            get => _precision;
            set
            {
                LogChange(nameof(Precision), Precision, value);
                _precision = value;
            }
        }

        public IQuantity Quantity
        {
            get => _quantity;
            set
            {
                LogChange(nameof(Quantity), Quantity, value);
                _quantity = value;
            }
        }

        public IUnit Unit
        {
            get => _unit;
            set
            {
                LogChange(nameof(Unit), Unit, value);
                _unit = value;
            }
        }

        public IScale Scale
        {
            get => _scale;
            set
            {
                LogChange(nameof(Scale), Scale, value);
                _scale = value;
            }
        }
        
        public IValue DeepClone()
        {
            var history = new List<Change>();
            foreach (var change in _history) history.Add(change.DeepClone());

            return new MutableValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone(), Scale.DeepClone(), history);
        }

        public ReadOnlyValue ToReadOnlyValue()
        {
            return new ReadOnlyValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone(), Scale.DeepClone());
        }

        private void LogChange(string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            _history.Add(new Change(changedProperty, previousValue, nextValue));
        }
    }
}