namespace ConvertEverything
{
    internal class DeepCloneable<T> : IDeepCloneable<DeepCloneable<T>>
    {
        public T Value { get; set; }

        public DeepCloneable<T> DeepClone()
        {
            return new DeepCloneable<T> {Value = Value};
        }

        public static implicit operator DeepCloneable<T>(T value)
        {
            return new DeepCloneable<T> {Value = value};
        }

        public static implicit operator T(DeepCloneable<T> value)
        {
            return value.Value;
        }
    }
}