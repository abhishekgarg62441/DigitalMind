using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessRatingBeepTest.Controllers
{
    public class FitnessRatingController : Controller
    {
        // GET: FitnessRatingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FitnessRatingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FitnessRatingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitnessRatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessRatingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FitnessRatingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessRatingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FitnessRatingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
