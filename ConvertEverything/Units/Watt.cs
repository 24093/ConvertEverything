namespace ConvertEverything.Units
{
    internal class Watt : DerivedUnit
    {
        public Watt()
            : base(2, 1, -3, 0, 0, 0, 0)
        {
        }

        public override string Symbol => "W";
    }
}