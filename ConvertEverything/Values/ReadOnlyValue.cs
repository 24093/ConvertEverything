using ConvertEverything.Applications;
using ConvertEverything.Dimensions;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class ReadOnlyValue<T> : IDeepCloneable<ReadOnlyValue<T>> where T : IDeepCloneable<T>
    {
        public T Value { get; }

        public T Precision { get; }

        public IDimension Dimension { get; }

        public IUnit Unit { get; }

        public IApplication Application { get; }

        public ReadOnlyValue(T value, T precision, IDimension dimension, IUnit unit, IApplication application)
        {
            Value = value;
            Precision = precision;
            Dimension = dimension;
            Unit = unit;
            Application = application;
        }

        public ReadOnlyValue<T> DeepClone()
        {
            return new ReadOnlyValue<T>(
                Value.DeepClone(),
                Precision.DeepClone(),
                Dimension.DeepClone(),
                Unit.DeepClone(),
                Application.DeepClone());
        }
    }
}