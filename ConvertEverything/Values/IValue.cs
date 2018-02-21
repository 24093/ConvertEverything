using ConvertEverything.Applications;
using ConvertEverything.Quantities;
using ConvertEverything.Units;

namespace ConvertEverything.Values
{
    internal interface IValue<TData> : IDeepCloneable<IValue<TData>>
    {
        TData Value { get; }

        TData Precision { get; }

        IQuantity Quantity { get; }

        IUnit Unit { get; }

        IApplication Application { get; }
    }
}