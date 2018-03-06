using System;
using System.Collections.Generic;
using System.Linq;
using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class MutableValue : IValue
    {
        private readonly List<Change> _history = new List<Change>();

        private double _precision;

        private IQuantity _quantity;

        private IUnit _unit;

        private double _value;

        public MutableValue()
        {
        }

        public MutableValue(double value, double precision, IQuantity quantity, IUnit unit)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
        }

        private MutableValue(double value, double precision, IQuantity quantity, IUnit unit, List<Change> history)
        {
            Value = value;
            Precision = precision;
            Quantity = quantity;
            Unit = unit;
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

        public IValue DeepClone()
        {
            var history = new List<Change>();
            foreach (var change in _history) history.Add(change.DeepClone());

            return new MutableValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone(), history);
        }

        public ReadOnlyValue ToReadOnlyValue()
        {
            return new ReadOnlyValue(Value, Precision, Quantity.DeepClone(), Unit.DeepClone());
        }

        private void LogChange(string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            _history.Add(new Change(changedProperty, previousValue, nextValue));
        }
    }
}