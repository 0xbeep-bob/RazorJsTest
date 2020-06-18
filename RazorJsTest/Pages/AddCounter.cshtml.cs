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
    public class AddCounterModel : PageModel
    {
        private readonly CountersLogic _countersLogic;

        public AddCounterModel(CountersLogic countersLogic)
        {
            _countersLogic = countersLogic;
        }

        public void OnGet()
        {

        }

        public void OnPost(int key, int value)
        {
            _countersLogic.AddCounter(new Counter()
            {
                Key = key,
                Value = value
            });
        }
    }
}
