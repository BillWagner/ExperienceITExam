using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dice.Models;

namespace Dice.Controllers
{
    public class DiceController : Controller
    {
        // GET: Die
        public ViewResult Index()
        {
            int[] die1 = { 1, 2, 3, 4, 5, 6 };
            int[] die2 = { 1, 2, 3, 4, 5, 6 };
            int[] results;
            int k = 0;
            for (int i = 0; i < die1.Count(); i++)
            {
                for (int j = 0; j < die2.Count(); j++)
                {
                    results[k] = die1[i];
                    results[k++] = die2[j];
                    k++;
                }
            }
            return View();
        }

        // GET: Die/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Die/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Die/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Die/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Die/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Die/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Die/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
