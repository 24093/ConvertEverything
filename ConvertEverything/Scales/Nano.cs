namespace ConvertEverything.Scales
{
    internal class Nano : DecimalScale
    {
        public override string Symbol => "n";

        public Nano() : base(-9) { }
    }
}