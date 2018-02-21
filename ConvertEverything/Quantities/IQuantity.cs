using ConvertEverything.Units;

namespace ConvertEverything.Quantities
{
    internal interface IQuantity
    {
        string QuantitySymbol { get; }

        string DimensionSymbol { get; }

        IUnit SiUnit { get; }
    }
}