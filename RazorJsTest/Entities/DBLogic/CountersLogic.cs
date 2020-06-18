using Microsoft.AspNetCore.Mvc;
using RazorJsTest.Entities.Tables;
using RazorJsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RazorJsTest.Entities.DBLogic
{
    public class CountersLogic
    {
        private readonly DB _db;

        public CountersLogic(DB dB)
        {
            _db = dB;
        }

        public IQueryable<Counter> GetCounters()
        {
            return _db.Counters;
        }

        public void AddCounter(Counter counter)
        {
            _db.Counters.Add(counter);

            _db.SaveChanges();
        }

        public IEnumerable<KeyInfoModel> FindCounter()
        {
            var res = _db.Counters.AsEnumerable().GroupBy(x => x.Key).Select(x => new KeyInfoModel()
            {
                Key = x.Key,
                Info = new InfoModel()
                {
                    Count = x.Select(y => y.Key).Count(),
                    CountMoreTheOne = x.Where(y => y.Value > 1).Select(y => y.Key).Count()
                }
            });

            return res;
        }
    }
}
