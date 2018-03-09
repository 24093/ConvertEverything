using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Ampere : IUnit
    {
        public string Symbol => "A";
        
        public IUnit DeepClone() => new Ampere();
    }
}