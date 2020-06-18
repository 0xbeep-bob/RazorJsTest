using Microsoft.AspNetCore.Mvc;
using RazorJsTest.Entities.DBLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorJsTest.Controllers
{
    public class KeysInfoController : Controller
    {
        private readonly CountersLogic _countersLogic;

        public KeysInfoController(CountersLogic countersLogic)
        {
            _countersLogic = countersLogic;
        }

        public IActionResult Index()
        {
            var keys = _countersLogic.FindCounter().ToList();

            return View(keys);
        }

        [HttpGet("keys")]
        public IActionResult Keys()
        {
            var keys = _countersLogic.FindCounter().ToList();

            return Json(keys);
        }
    }
}
