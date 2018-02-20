using ConvertEverything.Applications;
using ConvertEverything.Dimensions;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal class DoubleValue : TypedValue<double>
    {
        public DoubleValue(double value, double precision, IDimension dimension, IUnit unit, IApplication application)
            : base(value, precision, dimension, unit, application)
        {
        }
    }
}