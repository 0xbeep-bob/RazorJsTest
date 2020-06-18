using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorJsTest.Models
{
    public class KeyInfoModel
    {
        public long Key { get; set; }
        public InfoModel Info { get; set; }
    }

    public class InfoModel
    {
        public int Count { get; set; }
        public int CountMoreTheOne { get; set; }
    }
}
