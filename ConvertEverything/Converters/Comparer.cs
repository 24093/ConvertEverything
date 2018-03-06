using System;
using ConvertEverything.Values;

namespace ConvertEverything.Converters
{
    internal static class Comparer
    {
        public static int Compare(this IValue a, IValue b)
        {
            if (a == null || b == null)
                throw new ArgumentException();

            if (a.Unit.GetType() == b.Unit.GetType())
                return a.Value.CompareTo(b.Value);

            if (CompareConverted(a, b, out var result) || CompareConverted(b, a, out result))
                return result;

            throw new ArgumentException();
        }

        private static bool CompareConverted(IValue a, IValue b, out int result)
        {
            var aa = CloneValue(a);

            if (aa?.CanConvert(b.Unit) ?? false)
            {
                if (!aa.Convert(b.Unit))
                {
                    result = 0;
                    return false;
                }

                result = aa.Value.CompareTo(b.Value);
                return true;
            }

            result = 0;
            return false;
        }
        
        private static MutableValue CloneValue(IValue value)
        {
            switch (value)
            {
                case MutableValue mutableValue:
                    return (MutableValue) mutableValue.DeepClone();
                case ReadOnlyValue readOnlyValue:
                    return readOnlyValue.ToMutableValue();
                default:
                    return null;
            }
        }
    }
}