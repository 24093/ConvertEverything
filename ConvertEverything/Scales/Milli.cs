namespace ConvertEverything.Scales
{
    internal class Milli : DecimalScale
    {
        public override string Symbol => "m";

        public Milli() : base(-3) { }
    }
}