using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal interface IUnit : IDeepCloneable<IUnit>
    {
        string Symbol { get; }
    }
}