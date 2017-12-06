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
    public class WorkOrderTestsController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: WorkOrderTests
        public ActionResult Index()
        {
            var workordertest = db.workordertest.Include(w => w.Status).Include(w => w.Test).Include(w => w.WorkOrderAssay);
            return View(workordertest.ToList());
        }

        // GET: WorkOrderTests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderTest workOrderTest = db.workordertest.Find(id);
            if (workOrderTest == null)
            {
                return HttpNotFound();
            }
            return View(workOrderTest);
        }

        // GET: WorkOrderTests/Create
        public ActionResult Create()
        {
            ViewBag.StatusID = new SelectList(db.status, "StatusID", "StatusDescription");
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName");
            ViewBag.WorkOrderAssayID = new SelectList(db.workorderassay, "WorkOrderAssayID", "DateArrived");
            return View();
        }

        // POST: WorkOrderTests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderTestID,WorkOrderAssayID,TestID,StatusID,TestResult,SampleConcentration,CustomerApproval,RawDataResult")] WorkOrderTest workOrderTest)
        {
            if (ModelState.IsValid)
            {
                db.workordertest.Add(workOrderTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StatusID = new SelectList(db.status, "StatusID", "StatusDescription", workOrderTest.StatusID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", workOrderTest.TestID);
            ViewBag.WorkOrderAssayID = new SelectList(db.workorderassay, "WorkOrderAssayID", "DateArrived", workOrderTest.WorkOrderAssayID);
            return View(workOrderTest);
        }

        // GET: WorkOrderTests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderTest workOrderTest = db.workordertest.Find(id);
            if (workOrderTest == null)
            {
                return HttpNotFound();
            }
            ViewBag.StatusID = new SelectList(db.status, "StatusID", "StatusDescription", workOrderTest.StatusID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", workOrderTest.TestID);
            ViewBag.WorkOrderAssayID = new SelectList(db.workorderassay, "WorkOrderAssayID", "DateArrived", workOrderTest.WorkOrderAssayID);
            return View(workOrderTest);
        }

        // POST: WorkOrderTests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderTestID,WorkOrderAssayID,TestID,StatusID,TestResult,SampleConcentration,CustomerApproval,RawDataResult")] WorkOrderTest workOrderTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrderTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StatusID = new SelectList(db.status, "StatusID", "StatusDescription", workOrderTest.StatusID);
            ViewBag.TestID = new SelectList(db.test, "TestID", "TestName", workOrderTest.TestID);
            ViewBag.WorkOrderAssayID = new SelectList(db.workorderassay, "WorkOrderAssayID", "DateArrived", workOrderTest.WorkOrderAssayID);
            return View(workOrderTest);
        }

        // GET: WorkOrderTests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrderTest workOrderTest = db.workordertest.Find(id);
            if (workOrderTest == null)
            {
                return HttpNotFound();
            }
            return View(workOrderTest);
        }

        // POST: WorkOrderTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrderTest workOrderTest = db.workordertest.Find(id);
            db.workordertest.Remove(workOrderTest);
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
