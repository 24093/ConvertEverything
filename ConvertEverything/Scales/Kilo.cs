namespace ConvertEverything.Scales
{
    internal class Kilo : DecimalScale
    {
        public override string Symbol => "k";

        public Kilo() : base(3) { }
    }
}