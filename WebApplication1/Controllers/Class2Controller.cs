using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Class2Controller : Controller
    {
        private WebApplication1Context db = new WebApplication1Context();

        // GET: Class2
        public ActionResult Index()
        {
            return View(db.Class2.ToList());
        }

        // GET: Class2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class2 class2 = db.Class2.Find(id);
            if (class2 == null)
            {
                return HttpNotFound();
            }
            return View(class2);
        }

        // GET: Class2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName")] Class2 class2)
        {
            if (ModelState.IsValid)
            {
                db.Class2.Add(class2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(class2);
        }

        // GET: Class2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class2 class2 = db.Class2.Find(id);
            if (class2 == null)
            {
                return HttpNotFound();
            }
            return View(class2);
        }

        // POST: Class2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName")] Class2 class2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(class2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(class2);
        }

        // GET: Class2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class2 class2 = db.Class2.Find(id);
            if (class2 == null)
            {
                return HttpNotFound();
            }
            return View(class2);
        }

        // POST: Class2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class2 class2 = db.Class2.Find(id);
            db.Class2.Remove(class2);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
