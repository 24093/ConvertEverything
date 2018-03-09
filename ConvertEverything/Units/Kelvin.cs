using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Kelvin : IUnit
    {
        public string Symbol => "K";
        
        public IUnit DeepClone() => new Kelvin();
    }
}