namespace ConvertEverything.Units
{
    internal class Candela : IUnit
    {
        public string Symbol => "cd";

        public IUnit DeepClone()
        {
            return new Candela();
        }
    }
}