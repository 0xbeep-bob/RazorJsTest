using RazorJsTest.Entities.Tables;
using System.Collections.Generic;

namespace RazorJsTest.Entities.Helpers
{
    public class FillTablesHelper
    {
        public static FillTablesHelper Instance => new FillTablesHelper();

        private FillTablesHelper() { }

        public IEnumerable<Counter> FillCounters()
        {
            List<Counter> counters = new List<Counter>();

            counters.Add(new Counter() { Id = 1, Key = 1, Value = 1 });
            counters.Add(new Counter() { Id = 2, Key = 1, Value = 2 });
            counters.Add(new Counter() { Id = 3, Key = 1, Value = 3 });
            counters.Add(new Counter() { Id = 4, Key = 2, Value = 1 });
            counters.Add(new Counter() { Id = 5, Key = 2, Value = 1 });
            counters.Add(new Counter() { Id = 6, Key = 2, Value = 3 });
            counters.Add(new Counter() { Id = 7, Key = 2, Value = 1 });

            return counters;
        }
    }
}
