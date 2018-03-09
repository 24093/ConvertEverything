namespace ConvertEverything.Scales
{
    internal class Peta : DecimalScale
    {
        public override string Symbol => "P";

        public Peta() : base(15) { }
    }
}