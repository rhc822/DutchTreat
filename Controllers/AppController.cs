using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

TODO: Replace "object" in (object model), line 43, with "string" and see what happens. COMES BACK "NULL".
    
HELP:
    - Mod5/9, 1:06 "This time we're going to accept some payload from the page" line 40, object model. Why just "object"?
*/


namespace DutchTreat.Controllers
{
	public class AppController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch
            {
                throw new InvalidProgramException("Bad things happen to good developers");
            }
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }

    }
}