using ConvertEverything.Quantities;
using ConvertEverything.Scales;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal interface IValue : IDeepCloneable<IValue>
    {
        double Value { get; }

        double Precision { get; }

        IQuantity Quantity { get; }

        IUnit Unit { get; }

        IScale Scale { get; }
    }
}