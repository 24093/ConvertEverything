namespace ConvertEverything.Units
{
    internal class Newton : DerivedUnit
    {
        public Newton()
            : base(2, 1, -2, 0, 0, 0, 0)
        {
        }

        public override string Symbol => "N";
    }
}