using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Meetinger.App.Client.Controllers.Web
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Company")]
        public IActionResult Company()
        {
            return View();
        }

        [Route("Users")]
        public IActionResult Users()
        {
            return View();
        }

        [Route("Project")]
        public IActionResult Project()
        {
            return View();
        }
    }
}
