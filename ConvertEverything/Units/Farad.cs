namespace ConvertEverything.Units
{
    internal class Farad : DerivedUnit
    {
        public Farad()
            : base(-2, -1, 4, 1, 0, 0, 0)
        {
        }

        public override string Symbol => "F";
    }
}