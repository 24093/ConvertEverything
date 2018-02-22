namespace ConvertEverything.Units
{
    internal class Ampere : IUnit
    {
        public string Symbol => "A";

        public IUnit DeepClone()
        {
            return new Ampere();
        }
    }
}