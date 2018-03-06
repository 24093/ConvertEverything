using System;

namespace ConvertEverything.Values
{
    internal class Change : IDeepCloneable<Change>
    {
        public readonly string ChangedProperty;

        public readonly dynamic NextValue;

        public readonly dynamic PreviousValue;

        public readonly DateTime Timestamp;

        public Change(string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            Timestamp = DateTime.Now;
            ChangedProperty = changedProperty;
            PreviousValue = previousValue;
            NextValue = nextValue;
        }

        private Change(DateTime timestamp, string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            Timestamp = timestamp;
            ChangedProperty = changedProperty;
            PreviousValue = previousValue;
            NextValue = nextValue;
        }

        public Change DeepClone()
        {
            return new Change(Timestamp, ChangedProperty, PreviousValue, NextValue);
        }

        public override string ToString()
        {
            var previousString = GetString(PreviousValue);
            var nextString = GetString(NextValue);

            return $"{Timestamp}: {ChangedProperty} was changed from {previousString} to {nextString}";
        }

        private static string GetString(object obj)
        {
            if (obj == null)
                return "none";

            if (obj.GetType().GetMethod("ToString", Type.EmptyTypes).DeclaringType == typeof(object))
                return obj.GetType().Name;

            return obj.ToString();
        }
    }
}