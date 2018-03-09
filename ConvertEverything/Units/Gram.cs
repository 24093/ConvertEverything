using ConvertEverything.Scales;

namespace ConvertEverything.Units
{
    internal class Gram : IUnit
    {
        public string Symbol => "g";
        
        public IUnit DeepClone() => new Gram();
    }
}