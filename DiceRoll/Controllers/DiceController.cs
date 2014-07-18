using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiceRoll.Controllers
{
    public class DiceController : Controller
    {
        // GET: Dice
        public ActionResult Index()
        {
            ViewBag.Message = "This is the thing";
                return View();
        }
    }
}