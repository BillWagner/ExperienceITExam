using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roll.Controllers
{
    public class DiceRoll : Controller
    {
        // GET: DiceRoll
        public ActionResult Index()
        {
            return View();
        }
    }
}