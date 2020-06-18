using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorJsTest.Entities.DBLogic;
using RazorJsTest.Entities.Tables;

namespace RazorJsTest.Pages
{
    public class CountersModel : PageModel
    {
        private readonly CountersLogic _countersLogic;

        public List<Counter> DisplayedCounters { get; set; }

        public CountersModel(CountersLogic countersLogic)
        {
            _countersLogic = countersLogic;
        }

        public void OnGet()
        {
            DisplayedCounters = _countersLogic.GetCounters().ToList();
        }
    }
}
