using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Village.Controllers
{
    public class ChiefController : Controller
    {
        // GET: Chief
        public ActionResult ShowCheif()
        {
            ViewBag.theChief = "Welcome Chief";
            return View();
        }
    }
}