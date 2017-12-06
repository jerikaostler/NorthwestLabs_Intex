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
    public class WorkOrderAssaysController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: WorkOrderAssays
        public ActionResult Index()
        {
            var workorderassay = db.workorderassay.Include(w => w.Assay).Include(w => w.Compound).Include(w => w.WorkOrder);
            return View(workorderassay.ToList());
        }

        // GET: WorkOrderAssays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderAssay workOrderAssay = db.workorderassay.Find(id);
            if (workOrderAssay == null)
            {
                return HttpNotFound();
            }
            return View(workOrderAssay);
        }

        // GET: WorkOrderAssays/Create
        public ActionResult Create()
        {
            ViewBag.AssayID = new SelectList(db.assay, "AssayID", "AssayName");
            ViewBag.LT = new SelectList(db.compound, "LT", "CompoundName");
            ViewBag.WorkOrderID = new SelectList(db.workorder, "WorkOrderID", "Comments");
            return View();
        }

        // POST: WorkOrderAssays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderAssayID,WorkOrderID,AssayID,LT,AssayReport,QuantityInMilligrams,Weight,DateArrived,ReceivedBy,Appearance,MolecularMass")] WorkOrderAssay workOrderAssay)
        {
            if (ModelState.IsValid)
            {
                db.workorderassay.Add(workOrderAssay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssayID = new SelectList(db.assay, "AssayID", "AssayName", workOrderAssay.AssayID);
            ViewBag.LT = new SelectList(db.compound, "LT", "CompoundName", workOrderAssay.LT);
            ViewBag.WorkOrderID = new SelectList(db.workorder, "WorkOrderID", "Comments", workOrderAssay.WorkOrderID);
            return View(workOrderAssay);
        }

        // GET: WorkOrderAssays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderAssay workOrderAssay = db.workorderassay.Find(id);
            if (workOrderAssay == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssayID = new SelectList(db.assay, "AssayID", "AssayName", workOrderAssay.AssayID);
            ViewBag.LT = new SelectList(db.compound, "LT", "CompoundName", workOrderAssay.LT);
            ViewBag.WorkOrderID = new SelectList(db.workorder, "WorkOrderID", "Comments", workOrderAssay.WorkOrderID);
            return View(workOrderAssay);
        }

        // POST: WorkOrderAssays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderAssayID,WorkOrderID,AssayID,LT,AssayReport,QuantityInMilligrams,Weight,DateArrived,ReceivedBy,Appearance,MolecularMass")] WorkOrderAssay workOrderAssay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrderAssay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssayID = new SelectList(db.assay, "AssayID", "AssayName", workOrderAssay.AssayID);
            ViewBag.LT = new SelectList(db.compound, "LT", "CompoundName", workOrderAssay.LT);
            ViewBag.WorkOrderID = new SelectList(db.workorder, "WorkOrderID", "Comments", workOrderAssay.WorkOrderID);
            return View(workOrderAssay);
        }

        // GET: WorkOrderAssays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderAssay workOrderAssay = db.workorderassay.Find(id);
            if (workOrderAssay == null)
            {
                return HttpNotFound();
            }
            return View(workOrderAssay);
        }

        // POST: WorkOrderAssays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrderAssay workOrderAssay = db.workorderassay.Find(id);
            db.workorderassay.Remove(workOrderAssay);
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
