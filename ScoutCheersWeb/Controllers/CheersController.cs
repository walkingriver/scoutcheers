using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScoutCheersWeb.Models;

namespace ScoutCheersWeb.Controllers
{
    [Authorize]
    public class CheersController : Controller
    {
        private CheersContext db = new CheersContext();

        //
        // GET: /Cheer/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Cheers.ToList());
        }

        //
        // GET: /Cheer/Details/5

        public ActionResult Details(int id = 0)
        {
            Cheer cheer = db.Cheers.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            return View(cheer);
        }

        //
        // GET: /Cheer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cheer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cheer cheer)
        {
            if (ModelState.IsValid)
            {
                db.Cheers.Add(cheer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cheer);
        }

        //
        // GET: /Cheer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cheer cheer = db.Cheers.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            return View(cheer);
        }

        //
        // POST: /Cheer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cheer cheer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cheer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cheer);
        }

        //
        // GET: /Cheer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cheer cheer = db.Cheers.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            return View(cheer);
        }

        //
        // POST: /Cheer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cheer cheer = db.Cheers.Find(id);
            db.Cheers.Remove(cheer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}