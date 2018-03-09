using System;
using ConvertEverything.Units;

namespace ConvertEverything.Scales
{
    internal abstract class DecimalScale : IScale
    {
        private readonly double _pow;

        public double Factor => Math.Pow(10, _pow);

        public abstract string Symbol { get; }

        protected DecimalScale(int pow)
        {
            _pow = pow;
        }
    }
}