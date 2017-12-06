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
    public class EmpCostsController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: EmpCosts
        public ActionResult Index()
        {
            var empcost = db.empcost.Include(e => e.Employee).Include(e => e.WorkOrderTest);
            return View(empcost.ToList());
        }

        // GET: EmpCosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpCost empCost = db.empcost.Find(id);
            if (empCost == null)
            {
                return HttpNotFound();
            }
            return View(empCost);
        }

        // GET: EmpCosts/Create
        public ActionResult Create()
        {
            ViewBag.EmpID = new SelectList(db.employee, "EmpID", "EmpFirstName");
            ViewBag.WorkOrderTestID = new SelectList(db.workordertest, "WorkOrderTestID", "TestResult");
            return View();
        }

        // POST: EmpCosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpCostID,EmpID,WorkOrderTestID,HoursWorked")] EmpCost empCost)
        {
            if (ModelState.IsValid)
            {
                db.empcost.Add(empCost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpID = new SelectList(db.employee, "EmpID", "EmpFirstName", empCost.EmpID);
            ViewBag.WorkOrderTestID = new SelectList(db.workordertest, "WorkOrderTestID", "TestResult", empCost.WorkOrderTestID);
            return View(empCost);
        }

        // GET: EmpCosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpCost empCost = db.empcost.Find(id);
            if (empCost == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpID = new SelectList(db.employee, "EmpID", "EmpFirstName", empCost.EmpID);
            ViewBag.WorkOrderTestID = new SelectList(db.workordertest, "WorkOrderTestID", "TestResult", empCost.WorkOrderTestID);
            return View(empCost);
        }

        // POST: EmpCosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpCostID,EmpID,WorkOrderTestID,HoursWorked")] EmpCost empCost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empCost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpID = new SelectList(db.employee, "EmpID", "EmpFirstName", empCost.EmpID);
            ViewBag.WorkOrderTestID = new SelectList(db.workordertest, "WorkOrderTestID", "TestResult", empCost.WorkOrderTestID);
            return View(empCost);
        }

        // GET: EmpCosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpCost empCost = db.empcost.Find(id);
            if (empCost == null)
            {
                return HttpNotFound();
            }
            return View(empCost);
        }

        // POST: EmpCosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpCost empCost = db.empcost.Find(id);
            db.empcost.Remove(empCost);
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
