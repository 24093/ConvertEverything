namespace ConvertEverything.Scales
{
    internal class Femto : DecimalScale
    {
        public override string Symbol => "f";

        public Femto() : base(-15) { }
    }
}