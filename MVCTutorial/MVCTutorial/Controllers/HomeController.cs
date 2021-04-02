using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Heather";
            user.LastName = "Hanson";
            user.Age = 38;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello!!!";

            return View();
        }
    }
}

// All classes inherit from Controller, otherwise they are not a controller.  It gives them powerful properties the main being able to route HTTP requests.