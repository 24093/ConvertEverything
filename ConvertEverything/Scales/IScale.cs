namespace ConvertEverything.Scales
{
    internal interface IScale : IDeepCloneable<IScale>
    {
        double Factor { get; }

        string Symbol { get; }
    }
}