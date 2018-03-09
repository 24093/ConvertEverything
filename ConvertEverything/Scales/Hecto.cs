namespace ConvertEverything.Scales
{
    internal class Hecto : DecimalScale
    {
        public override string Symbol => "h";

        public Hecto() : base(2) { }
    }
}