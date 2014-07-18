using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DiceRollController : Controller
    {
        // GET: DiceRoll
        public ActionResult Index()
        {
            return View();
        }
    }
}