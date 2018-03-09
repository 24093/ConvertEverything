using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Second : IUnit
    {
        public string Symbol => "s";
        
        public IUnit DeepClone() => new Second();
    }
}