namespace ConvertEverything.Units
{
    internal class Second : IUnit
    {
        public string Symbol => "s";

        public IUnit DeepClone()
        {
            return new Second();
        }
    }
}