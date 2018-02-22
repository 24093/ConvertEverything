namespace ConvertEverything.Units
{
    internal class Kilogram : IUnit
    {
        public string Symbol => "kg";

        public IUnit DeepClone()
        {
            return new Kilogram();
        }
    }
}