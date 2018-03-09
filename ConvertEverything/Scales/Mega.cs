namespace ConvertEverything.Scales
{
    internal class Mega : DecimalScale
    {
        public override string Symbol => "M";

        public Mega() : base(6) { }
    }
}