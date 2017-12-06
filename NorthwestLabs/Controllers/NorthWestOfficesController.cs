using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

namespace NorthwestLabs.Controllers
{
    public class NorthWestOfficesController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: NorthWestOffices
        public ActionResult Index()
        {
            return View(db.northwestoffices.ToList());
        }

        // GET: NorthWestOffices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NorthWestOffices northWestOffices = db.northwestoffices.Find(id);
            if (northWestOffices == null)
            {
                return HttpNotFound();
            }
            return View(northWestOffices);
        }

        // GET: NorthWestOffices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NorthWestOffices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfficeID,Description,Location")] NorthWestOffices northWestOffices)
        {
            if (ModelState.IsValid)
            {
                db.northwestoffices.Add(northWestOffices);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(northWestOffices);
        }

        // GET: NorthWestOffices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NorthWestOffices northWestOffices = db.northwestoffices.Find(id);
            if (northWestOffices == null)
            {
                return HttpNotFound();
            }
            return View(northWestOffices);
        }

        // POST: NorthWestOffices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfficeID,Description,Location")] NorthWestOffices northWestOffices)
        {
            if (ModelState.IsValid)
            {
                db.Entry(northWestOffices).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(northWestOffices);
        }

        // GET: NorthWestOffices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NorthWestOffices northWestOffices = db.northwestoffices.Find(id);
            if (northWestOffices == null)
            {
                return HttpNotFound();
            }
            return View(northWestOffices);
        }

        // POST: NorthWestOffices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NorthWestOffices northWestOffices = db.northwestoffices.Find(id);
            db.northwestoffices.Remove(northWestOffices);
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
