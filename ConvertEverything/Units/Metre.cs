namespace ConvertEverything.Units
{
    internal class Metre : IUnit
    {
        public string Symbol => "m";

        public IUnit DeepClone()
        {
            return new Metre();
        }
    }
}