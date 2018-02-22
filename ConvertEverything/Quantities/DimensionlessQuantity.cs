namespace ConvertEverything.Quantities
{
    internal abstract class DimensionlessQuantity : DerivedQuantity
    {
        protected DimensionlessQuantity()
            : base(0, 0, 0, 0, 0, 0, 0)
        {
        }
    }
}