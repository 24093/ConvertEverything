namespace ConvertEverything
{
    internal interface IConverter<TSource, TDestination>
    {
        TDestination Convert(TSource value);
    }
}