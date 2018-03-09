using System;
using System.Collections.Generic;
using System.Text;
using ConvertEverything.Scales;
using ConvertEverything.Values;

namespace ConvertEverything.Converters
{
    internal static class Scaler
    {
        public static double Scale(this IValue source, IScale scale) => source.Value * scale.Factor;
    }
}
