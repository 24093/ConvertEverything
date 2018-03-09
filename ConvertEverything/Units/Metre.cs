using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Metre : IUnit
    {
        public string Symbol => "m";
        
        public IUnit DeepClone() => new Metre();
    }
}