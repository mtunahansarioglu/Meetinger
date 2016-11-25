using Meetinger.App.Client.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meetinger.App.Client.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("aol.com"))
            {
                ModelState.AddModelError("", "We do not support aol");
            }
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                ViewBag.Deneme = "Tunahan";
                ViewBag.UserMessage = "Message Sent";
                
            }


            return View();
        }

        
        public IActionResult About()
        {
            return View();
        }
    }
}
