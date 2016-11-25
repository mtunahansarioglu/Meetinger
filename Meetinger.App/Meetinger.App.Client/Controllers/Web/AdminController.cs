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
        //GET: /<controller>/
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
