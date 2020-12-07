using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Quete_Razor_.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            String conclusion = String.Empty;
            IEnumerable<Int32> integers = new Int32[] { 1, 2, 3, 4 };
            Int32 sum = integers.Sum();

            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }

            return View("Index", conclusion);
        }
    }
}
