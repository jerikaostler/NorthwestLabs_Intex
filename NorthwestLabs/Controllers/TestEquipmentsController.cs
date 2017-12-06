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
    public class TestEquipmentsController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: TestEquipments
        public ActionResult Index()
        {
            var testequipment = db.testequipment.Include(t => t.Equipment).Include(t => t.Test);
            return View(testequipment.ToList());
        }

        // GET: TestEquipments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEquipment testEquipment = db.testequipment.Find(id);
            if (testEquipment == null)
            {
                return HttpNotFound();
            }
            return View(testEquipment);
        }

        // GET: TestEquipments/Create
        public ActionResult Create()
        {
            ViewBag.EquipmentID = new SelectList(db.equipment, "EquipmentID", "Description");
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName");
            return View();
        }

        // POST: TestEquipments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TestEquipmentID,TestID,EquipmentID")] TestEquipment testEquipment)
        {
            if (ModelState.IsValid)
            {
                db.testequipment.Add(testEquipment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EquipmentID = new SelectList(db.equipment, "EquipmentID", "Description", testEquipment.EquipmentID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", testEquipment.TestID);
            return View(testEquipment);
        }

        // GET: TestEquipments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEquipment testEquipment = db.testequipment.Find(id);
            if (testEquipment == null)
            {
                return HttpNotFound();
            }
            ViewBag.EquipmentID = new SelectList(db.equipment, "EquipmentID", "Description", testEquipment.EquipmentID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", testEquipment.TestID);
            return View(testEquipment);
        }

        // POST: TestEquipments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TestEquipmentID,TestID,EquipmentID")] TestEquipment testEquipment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testEquipment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EquipmentID = new SelectList(db.equipment, "EquipmentID", "Description", testEquipment.EquipmentID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", testEquipment.TestID);
            return View(testEquipment);
        }

        // GET: TestEquipments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEquipment testEquipment = db.testequipment.Find(id);
            if (testEquipment == null)
            {
                return HttpNotFound();
            }
            return View(testEquipment);
        }

        // POST: TestEquipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestEquipment testEquipment = db.testequipment.Find(id);
            db.testequipment.Remove(testEquipment);
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
