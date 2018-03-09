using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Mole : IUnit
    {
        public string Symbol => "mol";
        
        public IUnit DeepClone() => new Mole();
    }
}