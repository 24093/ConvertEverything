namespace ConvertEverything.Scales
{
    internal class Exa : DecimalScale
    {
        public override string Symbol => "E";

        public Exa() : base(E) { }
    }
}