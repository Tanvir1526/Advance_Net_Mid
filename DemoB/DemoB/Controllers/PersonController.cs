using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoB.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Create()
        {
            return View();
        }
    }
}