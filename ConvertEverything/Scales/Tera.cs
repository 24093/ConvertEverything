namespace ConvertEverything.Scales
{
    internal class Tera : DecimalScale
    {
        public override string Symbol => "T";

        public Tera() : base(12) { }
    }
}