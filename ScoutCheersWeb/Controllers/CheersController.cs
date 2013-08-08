using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScoutCheersWeb.Models;

namespace ScoutCheersWeb.Controllers
{
    [Authorize]
    public class CheersController : Controller
    {
        static readonly Random _random;
        private readonly CheersContext _db = new CheersContext();

        static CheersController()
        {
            _random = new Random();
        }

        //
        // GET: /Cheer/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(_db.Cheers.ToList());
        }

        //
        // GET: /Cheer/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id = 0)
        {
            var cheer = _db.Cheers.Find(id);
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
                _db.Cheers.Add(cheer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cheer);
        }

        //
        // GET: /Cheer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var cheer = _db.Cheers.Find(id);
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
                _db.Entry(cheer).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cheer);
        }

        //
        // GET: /Cheer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var cheer = _db.Cheers.Find(id);
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
            Cheer cheer = _db.Cheers.Find(id);
            _db.Cheers.Remove(cheer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Random()
        {
            var upperBound = _db.Cheers.Count() - 1;

            if (upperBound < 0)
            {
                throw new HttpException(404, "No cheers exist. Please add some.");
            }

            var itemsToSkip = _random.Next(0, upperBound);
            var id = _db.Cheers
                .OrderBy(x=>x.Id)
                .Skip(itemsToSkip)
                .First()
                .Id;

            return RedirectToAction("Details", new {id});
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}