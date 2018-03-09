namespace ConvertEverything.Scales
{
    internal class Micro : DecimalScale
    {
        public override string Symbol => "µ";

        public Micro() : base(-6) { }
    }
}