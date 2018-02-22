namespace ConvertEverything.Units
{
    internal class Kelvin : IUnit
    {
        public string Symbol => "K";

        public IUnit DeepClone()
        {
            return new Kelvin();
        }
    }
}