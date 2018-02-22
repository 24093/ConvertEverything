using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertEverything.Values
{
    internal class History : IDeepCloneable<History>
    {
        public readonly Dictionary<DateTime, Change> Log = new Dictionary<DateTime, Change>();

        public void Add(string changedProperty, dynamic previousValue, dynamic nextValue)
        {
            Log.Add(DateTime.Now, new Change(changedProperty, previousValue, nextValue));
        }

        public IEnumerable<string> GetLog()
        {
            foreach (var change in Log)
                yield return $"{change.Key}: {change.Value}";
        }

        public History()
        {
        }

        private History(Dictionary<DateTime, Change> log)
        {
            Log = log;
        }

        public History DeepClone()
        {
            var log = new Dictionary<DateTime, Change>();

            foreach (var change in Log)
            {
                log.Add(change.Key, change.Value.DeepClone());
            }

            return new History(log);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, GetLog());
        }
    }
}