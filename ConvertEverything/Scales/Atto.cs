namespace ConvertEverything.Scales
{
    internal class Atto : DecimalScale
    {
        public override string Symbol => "a";

        public Atto() : base(-18) { }
    }
}