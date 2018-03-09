namespace ConvertEverything.Scales
{
    internal class Deci : DecimalScale
    {
        public override string Symbol => "d";

        public Deci() : base(-1) { }
    }
}