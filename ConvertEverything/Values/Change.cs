namespace ConvertEverything.Values
{
    internal class Change : IDeepCloneable<Change>
    {
        public readonly string ChangedProperty;

        public readonly dynamic PreviousValue;

        public readonly dynamic NextValue;

        public Change(string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            ChangedProperty = changedProperty;
            PreviousValue = previousValue;
            NextValue = nextValue;
        }

        public Change DeepClone()
        {
            return new Change(ChangedProperty, PreviousValue, NextValue);
        }

        public override string ToString()
        {
            return $"{ChangedProperty} was changed from {PreviousValue} to {NextValue}";
        }
    }
}