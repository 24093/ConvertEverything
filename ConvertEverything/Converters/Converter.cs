namespace ConvertEverything.Converters
{
    internal static class Converter
    {
        public static bool CanConvert<TSource, TTarget>(TSource value)
        {
            return value is IConvertable<TTarget>;
        }

        public static TTarget Convert<TSource, TTarget>(TSource value)
        {
            if (CanConvert<TSource, TTarget>(value)) return ((IConvertable<TTarget>) value).Convert();

            return default(TTarget);
        }

        public static bool TryConvert<TSource, TTarget>(TSource value, out TTarget convertedValue)
        {
            if (CanConvert<TSource, TTarget>(value))
            {
                convertedValue = Convert<TSource, TTarget>(value);
                return true;
            }

            convertedValue = default(TTarget);
            return false;
        }
    }
}